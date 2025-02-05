using ComponentIO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    /// <summary>
    /// [作成者 kj]
    /// Kintoneの各アプリケーションと連携するためのクラス
    /// </summary>
    public class KintoneApiClient
    {
        /// <summary>通信用</summary>
        HttpClient httpClient;
        /// <summary>URL</summary>
        string baseUrl;
        /// <summary>アプリケーションID</summary>
        string appId;
        /// <summary>Basic認証ユーザー</summary>
        string base_user;
        /// <summary>Basic認証ユーザーパスワード</summary>
        string base_pass;

        /// <summary>APIトークン</summary>
        List<string> apiToken;
        /// <summary>SUBTABLEの親ID</summary>
        public const string Fld_ParentID = "Fld_ParentID";
        /// <summary>SUBTABLEのID</summary>
        public const string Fld_SubID    = "Fld_SubID";

        /// <summary>
        /// コンストラクタ（APIトークン用）
        /// </summary>
        /// <param name="sub_domain">サブドメイン</param>
        /// <param name="appId">アプリケーションID</param>
        /// <param name="token">認証用トークン</param>
        public KintoneApiClient(string sub_domain,  List<string> token = null, string appId = null)
        {
            this.baseUrl    = $"https://{sub_domain}.cybozu.com";
            this.appId      = appId;

            if (token == null)
            {
                this.apiToken = new List<string>();
            }
            else
            {
                this.apiToken = token;
            }

            httpClient = new HttpClient();
            setHttpHeadersForToken();
        }

        /// <summary>
        /// コンストラクタ（Basic認証用）
        /// </summary>
        /// <param name="sub_domain">サブドメイン</param>
        /// <param name="appId">アプリケーションID</param>
        /// <param name="basicUser">ユーザー名</param>
        /// <param name="basicPass">パスワード</param>
        public KintoneApiClient(string sub_domain, string basicUser = null, string basicPass = null, string appId = null)
        {
            this.baseUrl    = $"https://{sub_domain}.cybozu.com";
            this.appId      = appId;

            this.base_user = basicUser;
            this.base_pass = basicPass;

            httpClient = new HttpClient();
            setHttpHeadersForBasic();
        }

        /// <summary>
        /// APIトークン認証用のヘッダを設定します。
        /// </summary>
        void setHttpHeadersForToken()
        {
            string str = string.Join(",", apiToken);

            if (httpClient != null)
            {
                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Add("X-Cybozu-API-Token", str);
            }
        }

        /// <summary>
        /// Basic認証用のヘッダを設定します。
        /// </summary>
        void setHttpHeadersForBasic()
        {
            if (httpClient != null)
            {
                string auth = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{this.base_user}:{this.base_pass}"));

                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Add("X-Cybozu-Authorization", auth);
            }
        }

        /// <summary>
        /// ユーザー情報一覧を取得します。
        /// </summary>
        /// <returns></returns>
        public async Task<List<KintoneUser>> GetAllUsersAsync()
        {
            try
            {
                var url = $"{baseUrl}/v1/users.json";
                var response = await httpClient.GetAsync(url);
                var body = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = JObject.Parse(body);
                    return JsonConvert.DeserializeObject<List<KintoneUser>>(jsonResponse["users"].ToString());
                }
                else
                {
                    Console.WriteLine($"Error fetching users: {response.StatusCode} - {response.ReasonPhrase}");
                    return new List<KintoneUser>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<KintoneUser>();
            }
        }

        /// <summary>
        /// 組織情報一覧を取得します。
        /// </summary>
        /// <returns></returns>
        public async Task<List<KintoneOrganization>> GetAllOrganizationsAsync()
        {
            try
            {
                var url = $"{baseUrl}/v1/organizations.json";
                var response = await httpClient.GetAsync(url);
                var body = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = JObject.Parse(body);
                    return JsonConvert.DeserializeObject<List<KintoneOrganization>>(jsonResponse["organizations"].ToString());
                }
                else
                {
                    Console.WriteLine($"Error fetching organizations: {response.StatusCode} - {response.ReasonPhrase}");
                    return new List<KintoneOrganization>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<KintoneOrganization>();
            }
        }

        /// <summary>
        /// 指定されたレコードの対象フィールドを更新します。
        /// </summary>
        /// <param name="recordsToUpdate"></param>
        /// <returns></returns>
        public async Task<bool> UpdateMultipleRecordsAsync(List<Dictionary<string, object>> recordsToUpdate)
        {
            try
            {
                var url = $"{baseUrl}/k/v1/records.json";
                var requestBody = new
                {
                    app = appId,
                    records = recordsToUpdate
                };

                var jsonContent = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");
                var response = await httpClient.PutAsync(url, jsonContent);

                // 戻り値の確認
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"<Update> Return JSON :{body}");

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Failed to update multiple records: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }


        /// <summary>
        /// 指定されたレコードを追加します。
        /// </summary>
        /// <param name="recordsToAdd"></param>
        /// <returns></returns>
        public async Task<bool> AddMultipleRecordsAsync(List<Dictionary<string, object>> recordsToAdd)
        {
            try
            {
                var url = $"{baseUrl}/k/v1/records.json";
                var requestBody = new
                {
                    app = appId,
                    records = recordsToAdd
                };

                var jsonContent = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(url, jsonContent);

                // 戻り値の確認
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"<Add> Return JSON :{body}");

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Failed to add multiple records: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// 指定されたレコードを削除します。
        /// </summary>
        /// <param name="recordIds"></param>
        /// <returns></returns>
        public async Task<bool> DeleteMultipleRecordsAsync(List<string> recordIds)
        {
            try
            {
                var url = $"{baseUrl}/k/v1/records.json";
                var requestBody = new
                {
                    app = appId,
                    ids = recordIds
                };

                var jsonContent = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");
                var request = new HttpRequestMessage(HttpMethod.Delete, url) { Content = jsonContent };
                var response = await httpClient.SendAsync(request);

                 // 戻り値の確認
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"<Delete> Return JSON :{body}");

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Failed to delete multiple records: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// 非同期で全てのレコードを取得して、JsonObjectとして返します。
        /// </summary>
        /// <param name="limit">最大行数</param>
        /// <returns></returns>
        public async Task<List<JObject>> GetAllRecordsAsync(int limit = 100)
        {
            int offset = 0;
            List<JObject> allRecords = new List<JObject>();
            bool hasMoreRecords = true;

            while (hasMoreRecords)
            {
                var records = await GetRecordsAsync(offset, limit);
                if (records != null && records["records"] != null && records["records"].HasValues)
                {
                    foreach (var record in records["records"])
                    {
                        allRecords.Add((JObject)record);
                    }

                    offset += limit;
                    hasMoreRecords = records["records"].Count() == limit;
                }
                else
                {
                    hasMoreRecords = false;
                }
            }

            return allRecords;
        }

        /// <summary>
        /// 非同期で指定されたレコードを取得して、JsonObjectとして返します。
        /// </summary>
        /// <param name="offset">開始位置</param>
        /// <param name="limit">最大行数</param>
        /// <returns></returns>
        private async Task<JObject> GetRecordsAsync(int offset, int limit)
        {
            try
            {
                var url = $"{baseUrl}/k/v1/records.json?app={appId}&offset={offset}&limit={limit}";
                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JObject.Parse(jsonString);
                }
                else
                {
                    throw new Exception($"Failed to get records: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// 非同期で取得したレコードをDataTableとして返します。
        /// </summary>
        /// <returns></returns>
        public async Task<(DataTable mainTbl, Dictionary<string, DataTable> subTbls)> GetDataTableAsync()
        {
            List<JObject> jrows = await GetAllRecordsAsync();

            return ConvertJsonToDataTable(jrows);
        }

        /// <summary>
        /// SUBTABLEの生成
        /// </summary>
        /// <param name="tbl"></param>
        /// <param name="subRows"></param>
        /// <param name="parentId"></param>
        void createSubTable(DataTable tbl, JArray subRows, object parentId)
        {
            // サブテーブルのカラムを初期化（最初のレコードの時のみ）
            if (tbl.Columns.Count == 0 && subRows.Count > 0)
            {
                var firstSubRecord = subRows[0]["value"] as JObject;
                if (firstSubRecord != null)
                {
                    // 親IDの列
                    tbl.Columns.Add(Fld_ParentID, typeof(decimal));
                    tbl.Columns.Add(Fld_SubID, typeof(decimal));

                    foreach (var prop in firstSubRecord.Properties())
                    {
                        var fieldType = Cast.String(prop.Value["type"]);
                        var colName = prop.Name;

                        Type colType = typeof(string);  // デフォルトの型をstringに設定

                        // 型に基づいてDataTableのカラム型を設定
                        switch (fieldType)
                        {
                            case "NUMBER":
                                colType = typeof(decimal);
                                break;
                            case "DATE":
                            case "DATETIME":
                                colType = typeof(DateTime);
                                break;
                            case "SUBTABLE":
                                // サブのサブはないはず
                                continue;
                            default:
                                colType = typeof(string); // 他のすべてのタイプはデフォルトで文字列
                                break;
                        }

                        tbl.Columns.Add(colName, colType);

                    }
                }
            }

            // サブテーブルのレコードをDataTableに追加
            foreach (var jrow in subRows)
            {
                var row = tbl.NewRow();
                var subFields = jrow["value"] as JObject;

                if (subFields != null)
                {
                    row[Fld_ParentID] = parentId;
                    row[Fld_SubID]      = Cast.Decimal(jrow["id"]);

                    foreach (var prop in subFields.Properties())
                    {
                        var colType = Cast.String(prop.Value["type"]);
                        var colName = prop.Name; 
                        string val;

                        if (colType == "CREATOR" || colType == "MODIFIER")
                        {
                            // 作成者と更新者の名前を取得
                            val = Cast.String(prop.Value["value"]["name"]);
                        }
                        else
                        if (colType == "USER_SELECT" || colType == "ORGANIZATION_SELECT")
                        {
                            val = "";
                            foreach(var obj in prop.Value["value"])
                            {
                                if (val != "") val += ",";
                                val += Cast.String(obj["name"]);
                            }
                        }
                        else
                        {
                            val = Cast.String(prop.Value["value"]);
                        }

                        // 特定の型の処理
                        if (tbl.Columns[colName].DataType == typeof(DateTime))
                        {
                            row[colName] = Cast.DateTime(val);
                        }
                        else 
                        if (tbl.Columns[colName].DataType == typeof(decimal))
                        {
                            row[colName] = Cast.Decimal(val);
                        }
                        else
                        {
                            row[colName] = val;
                        }
                    }

                    tbl.Rows.Add(row);
                }
            }
        }

        /// <summary>
        /// JsonのリストをDataTableに変換します。
        /// </summary>
        /// <param name="jrows"></param>
        /// <returns></returns>
        public (DataTable mainTbl, Dictionary<string, DataTable> subTbls) ConvertJsonToDataTable(List<JObject> jrows)
        {
            var mainTbl = new DataTable();
            var subTbls = new Dictionary<string, DataTable>();
            
            if (jrows == null || jrows.Count == 0)
            {
                return (mainTbl, subTbls);
            }

            // カラムをDataTableに追加（型を推定して設定）
            foreach (var property in jrows[0].Properties())
            {
                var fieldType = Cast.String(property.Value["type"]);
                var colName = property.Name;
                Type colType = typeof(string);  // デフォルトの型をstringに設定

                // 型に基づいてDataTableのカラム型を設定
                switch (fieldType)
                {
                    case "NUMBER":
                        colType = typeof(decimal);
                        break;
                    case "DATE":
                    case "DATETIME":
                        colType = typeof(DateTime);
                        break;
                    case "SUBTABLE":
                        // サブテーブルのカラムはメインテーブルには追加せず、別のDataTableを作成する
                        subTbls[colName] = new DataTable(colName);
                        break;
                    default:
                        colType = typeof(string); // 他のすべてのタイプはデフォルトで文字列
                        break;
                }

                if (fieldType != "SUBTABLE")
                {
                    mainTbl.Columns.Add(colName, colType);
                }
            }

             // レコードをDataTableに追加
            foreach (var jrow in jrows)
            {
                var row = mainTbl.NewRow();

                foreach (var prop in jrow.Properties())
                {
                    var colType = Cast.String(prop.Value["type"]);
                    var colName = prop.Name; 

                    //■ SUBTABLEを生成
                    if (colType == "SUBTABLE")
                    {
                        var subRows = prop.Value["value"] as JArray;

                        // サブテーブルを生成
                        if (subRows != null)
                        {
                            var tbl = subTbls[colName];
                            createSubTable(tbl,subRows, jrow["$id"]["value"]);
                        }
                    }
                    else
                    {
                        string val;

                        if (colType == "CREATOR" || colType == "MODIFIER")
                        {
                            // 作成者と更新者の名前を取得
                            val = Cast.String(prop.Value["value"]["name"]);
                        }
                        else
                        if (colType == "USER_SELECT" || colType == "ORGANIZATION_SELECT")
                        {
                            val = "";
                            foreach(var obj in prop.Value["value"])
                            {
                                if (val != "") val += ",";
                                val += Cast.String(obj["name"]);
                            }
                        }
                        else
                        {
                            val = Cast.String(prop.Value["value"]);
                        }

                        // 特定の型の処理
                        if (mainTbl.Columns[colName].DataType == typeof(DateTime))
                        {
                            row[prop.Name] = Cast.DateTime(val);
                        }
                        else 
                        if (mainTbl.Columns[colName].DataType == typeof(decimal))
                        {
                            row[colName] = Cast.Decimal(val);
                        }
                        else
                        {
                            row[colName] = val;
                        }
                     }
                }

                mainTbl.Rows.Add(row);
            }

            return (mainTbl,subTbls);
        }
    }

    /// <summary>
    /// Kintoneのユーザーデータを管理するクラス
    /// </summary>
    public class KintoneUser
    {
        /// <summary>ユーザーコード (ログインID)</summary>
        public string Code { get; set; }
        /// <summary>ユーザー名</summary>
        public string Name { get; set; }
        /// <summary>メールアドレス</summary>
        public string Email { get; set; }
        /// <summary>言語</summary>
        public string Language { get; set; }
        /// <summary>タイムゾーン</summary>
        public string Timezone { get; set; }
    }

    /// <summary>
    /// Kintoneの組織データを管理するクラス
    /// </summary>
    public class KintoneOrganization
    {
        /// <summary>組織ID</summary>
        public string Id { get; set; }
        /// <summary>組織名</summary>
        public string Name { get; set; }
        /// <summary>親組織のID</summary>
        public string Parent {get; set; }
    }
}
