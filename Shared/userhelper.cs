using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS.Shared
{
    public static class userhelper
    {
        private static readonly string baseURL = "https://gorest.co.in/public/v2/";
        public static async Task<string>GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "users"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if(data != null)
                        {
                            return data;
                        }
                    }

                }

            }
            return string.Empty;

        }
        public static async Task<string> Get(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "users/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }

                }

            }
            return string.Empty;

        }
        public static async Task<string> Post(string name,string email, string gender, string status)
        {
            var inputdata = new Dictionary<string, string>
            {
                {"name", name},
                { "email", email},
                {"gender", gender},
                { "status", status }
            };
            var input = new FormUrlEncodedContent(inputdata);
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PostAsync(baseURL + "users", input))
                {
                    using (HttpContent content = res.Content)
                    {
                        MessageBox.Show(((int)res.StatusCode).ToString());
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }

                }

            }

            return string.Empty;

        }
        public static async Task<string> Put(string id,string name, string email, string gender, string status)
        {
            var inputdata = new Dictionary<string, string>
            {
                {"id", id},
                {"name", name},
                { "email", email},
                {"gender", gender},
                { "status", status }
            };
            var input = new FormUrlEncodedContent(inputdata);
            using (HttpClient client = new HttpClient())
            {
                
                    using (HttpResponseMessage res = await client.PutAsync(baseURL + "users/" + id, input))
                    {
                        using (HttpContent content = res.Content)
                        {
                            MessageBox.Show(((int)res.StatusCode).ToString());
                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                return data;
                            }
                        }

                    }

            }

            return string.Empty;

        }
        public static async Task<string> GetByName(string name)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "users?name="+name+""))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }

                }

            }
            return string.Empty;

        }
        public static string beautifyJson(string jsonstr)
        {
            JToken parseJson = JToken.Parse(jsonstr);
            return parseJson.ToString(Formatting.Indented);
        }
    }
}
