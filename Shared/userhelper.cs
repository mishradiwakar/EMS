using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS.Shared
{
    public static class userhelper
    {
        private static readonly string baseURL = "https://gorest.co.in/public/v2/";
        private static readonly string accessToken = "fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56";

        public static async Task<string>GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
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
               client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
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
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
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
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
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
        public static async Task<string> Delete(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                using (HttpResponseMessage res = await client.DeleteAsync(baseURL + "users/" + id))
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
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
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
