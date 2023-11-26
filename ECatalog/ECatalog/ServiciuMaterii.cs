using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECatalog
{
    public class ServiciuMaterii
    {
        public ServiciuMaterii()
        {

        }
        public async Task<List<Materie>> PreiaMaterii()
        {
            try
            {
                var jsonData = await DownloadJsonAsync("https://www.jsonkeeper.com/b/M4UY");
                var materii = JsonConvert.DeserializeObject<List<Materie>>(jsonData);
                return materii;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        static async Task<string> DownloadJsonAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                return await client.GetStringAsync(url);
            }
        }
    }
}
