using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;

namespace WebApplication5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }



        public string res;
        public string res1;

        [HttpGet]
        [ActionName("GetTemp")]
        public async Task<string> GetTemp()
        {
            try
            {
                var URL = "https://localhost:44373/api/temperature";
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(URL);
                if (Response.StatusCode == 200)
                {
                    return await response.Content.ReadAsStringAsync();
                }

                else
                {
                    return "Error occured while querring Temperature";
                }
            }
            catch (Exception ex)
            {
                return ("error" + ex);
            }
        }



        [HttpGet]


        public async Task<string> GetPres()
        {
            try
            {
                var URL2 = "https://localhost:44313/api/pressure";
                var httpClient1 = new HttpClient();
                var response1 = await httpClient1.GetAsync(URL2);
                if (Response.StatusCode == 200)
                {
                    return await response1.Content.ReadAsStringAsync();
                }

                else
                {
                    return "Error occured while querring Pressure";
                }
            }
            catch (Exception ex)
            {
                return ("error" + ex);
            }
        }
    }
}

/*public async Task<string> GetToday()
{
    var URL = "https://localhost:44373/api/temperature";
    var URL2 = "https://localhost:44313/api/pressure";

    try
    {
        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.GetAsync(URL);

            if (Response.StatusCode == 200)
            {
                res = await response.Content.ReadAsStringAsync();

            }
            try
            {


                    var response1 = await httpClient.GetAsync(URL2);

                    if (Response.StatusCode == 200)
                    {
                        res = await response1.Content.ReadAsStringAsync();

                    }


            }
            catch (Exception ex)
            {
            }
        }
    }
    catch (Exception ex)
    {

    }
    return res;
    return res1;
}*/




/*[HttpGet]


public async Task<string> GetPres()
{
    try
    {
        var URL = "https://localhost:44373/api/temperature";
        var URL2 = "https://localhost:44313/api/pressure";
        var httpClient1 = new HttpClient();

        var response1 = await httpClient1.GetAsync(URL2);
        var response = await httpClient1.GetAsync(URL);
        if (Response.StatusCode == 200)
        {
            return await response1.Content.ReadAsStringAsync();
            return await response.Content.ReadAsStringAsync();
        }

        else
        {
            return "Error occured while querring Pressure";
        }


    }
    catch (Exception ex)
    {
        return ("error");
    }
}*/




/*[HttpGet]
public async Task<string> Get2()
{

    var URL2 = "https://localhost:44313/api/pressure";
    var httpClient = new HttpClient();
    var response = await httpClient.GetAsync(URL2);
    return await response.Content.ReadAsStringAsync();


}*/



/* public async Task<string> Get2()
 {

     try
     {

         var url = "https://localhost:44313/api/pressure";
         // Creates an HttpWebRequest for the specified URL.
         HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
         // Sends the HttpWebRequest and waits for a response.
         HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
         if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
         return await myHttpWebResponse.GetResponseStream(v);
         // Releases the resources of the response.
         myHttpWebResponse.Close();
     }
     catch (WebException e)
     {
         Console.WriteLine("\r\nWebException Raised. The following error occurred : {0}", e.Status);
     }
     catch (Exception e)
     {
         Console.WriteLine("\nThe following Exception was raised : {0}", e.Message);
     }
 }*/




/* public async Task<string> Get2()
 {

     var URL2 = "https://localhost:44313/api/pressure";
     var httpClient = new HttpClient();
     var response = await httpClient.GetAsync(URL2);
     return await response.Content.ReadAsStringAsync();


 }*/

/*public IActionResult Index2()
{

    var url = Url.Action("Buy", "Products", new { id = 17 }, protocol: Request.Scheme);
    // Returns https://localhost:5001/Products/Buy/17
    return Content(url);
}*/








/*public async Task<JsonResult> Get()
{
    var URL = "https://localhost:44313/api/pressure";
    var httpClient = new HttpClient();
    var response = await httpClient.GetAsync(URL);
    // return await response.Content.ReadAsAsync<JsonResult>();
    return Json(Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response));


}*/

/*public async Task<JsonResult> GetUserMenu()
{
    string result = string.Empty;
    var url = "https://localhost:44373/api/temperature";
    using (HttpClient client = new HttpClient())
    {
        client.BaseAddress = new Uri(url);
        HttpResponseMessage response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            result = await response.Content.ReadAsStringAsync();
        }
    }

    return (Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(result));
}*/