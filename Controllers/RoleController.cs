using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using salian_api.Entities;

namespace salian_front.Controllers
{
    public class RoleController : Controller
    {
        string baseUrl = "https://localhost:7067/";

        public async Task<List<RoleEntity>> Test()
        {
            using (var client = new HttpClient())
            {
                List<RoleEntity> roles = new List<RoleEntity>();
                client.BaseAddress = new Uri("https://localhost:7067/api/");
                //HTTP GET
                var responseTask = client.GetAsync("role");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = await result.Content.ReadAsStringAsync();
                    //readTask.Wait();

                    //var students = readTask.Result;
                    //
                    //string jsonstring = JsonConvert.SerializeObject(students);

                    Console.WriteLine(readTask);
                   /* roles = JsonConvert.DeserializeObject<List<RoleEntity>>(jsonstring);
                    return roles;*/
                }

            }
            return null;
        }
            public ActionResult List()
        {
           /* List<RoleEntity> roles = new List<RoleEntity>();
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage Res = await client.GetAsync("api/role");
            if (Res.IsSuccessStatusCode)
            {
                var Result = Res.Content.ReadAsStringAsync().Result;
                roles = JsonConvert.DeserializeObject<List<RoleEntity>>(Result);
            }

            return roles;
            *//*HttpClient httpClient = new HttpClient();
            var baseUrl = "https://localhost:7067/";
            var url = $"{baseUrl}api/role";
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();

                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine(response.StatusCode.ToString());
                Console.WriteLine(await response.Content.ReadAsStringAsync());
            }*/
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
}
}
