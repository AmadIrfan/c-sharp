using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace API_APP
{
    internal class REST_API
    {
        public static async Task<String> getAPI()
        {
            using(HttpClient client=new HttpClient())
            {
                using(HttpResponseMessage hrm=await client.GetAsync("https://jsonplaceholder.typicode.com/posts") ) { 
                    using(HttpContent content = hrm.Content)
                    {
                        String data =await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }

            }
            return String.Empty;
        }
    }
}
