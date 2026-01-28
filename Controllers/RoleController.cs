using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

/*using Newtonsoft.Json;
using salian_api.Entities;*/

namespace salian_front.Controllers
{
    public class RoleController : Controller
    {
        private readonly HttpClient _client = new HttpClient();
        private const string baseUrl = "https://localhost:7067/";


        public async Task Test()
        {
            HttpResponseMessage response = await _client.GetAsync(baseUrl + "api/role");
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            var roles = JsonSerializer.Serialize(responseBody);

            Console.WriteLine(roles);
            foreach (var role in roles)
            {
                Console.WriteLine(role);
            }

            // using HttpClient client = new HttpClient();
            /* try
             {
                 string url = "https://localhost:7067/api/role";
                 HttpResponseMessage response = await client.GetAsync(url);
                 response.EnsureSuccessStatusCode();

                 string responseBody = await response.Content.ReadAsStringAsync();


                 responseBody=  JsonSerializer.Serialize(responseBody);
                 //
                 //string jsonstring = JsonConvert.SerializeObject(students);
                 Console.WriteLine(responseBody);
                 //JsonConvert.DeserializeObject(responseBody);
                 return responseBody;

                 // is ok
                 *//*response.EnsureSuccessStatusCode();

                 string responseBody = await response.Content.ReadAsStringAsync();

                 Console.WriteLine(responseBody);*//*
             }
             catch (Exception ex)
             {
                 Console.WriteLine("Problem Reason :: " + ex.Message);
                 return ex.Message;
             }*/
        }
            /*public async Task<List<RoleEntity>> Test()
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

               //Console.WriteLine(students);
              // Console.WriteLine(readTask);
               //roles = JsonConvert.DeserializeObject<List<RoleEntity>>(jsonstring);
               //return roles;
           }

       }
       return null;
    }*/
            public IActionResult List()
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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async void Create(string[] data)
        {
            /*using HttpClient client = new HttpClient();

            //var json = "{\"title\":\"foo\",\"body\":\"bar\",\"userId\":1}";
            var json =
            [
                "FaName" = data["FaName"],
                "EnName" = data["EnName"],
            ];
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync("https://localhost:7067/api/create", content);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"خطا در ارسال درخواست: {e.Message}");
            }*/

        }
    }
}
