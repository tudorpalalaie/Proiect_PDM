using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECatalog
{
    public class ServiciuAutentificareStudent
    {
        public ServiciuAutentificareStudent() { }

        public static async Task<Student> PreiaUtilizator()
        {
            try
            {
                var jsonData = await DownloadJsonAsync("https://www.jsonkeeper.com/b/JEAF");
                var student = JsonConvert.DeserializeObject<Student>(jsonData);
                return student;
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
