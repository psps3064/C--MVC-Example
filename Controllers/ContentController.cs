using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
public class ContentController : Controller
{
    // GET: Student
    public ActionResult Index()
    {
        string apiUrl = "https://jsonplaceholder.typicode.com/posts";
        IEnumerable<ContentModel> contents = null;

        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri(apiUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            //HTTP GET
            var responseTask = client.GetAsync(apiUrl);
            responseTask.Wait();

            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<ContentModel>>();
                readTask.Wait();
                
                contents = readTask.Result;
            }
            else //web api sent error response 
            {
                //log response status here..

                contents = Enumerable.Empty<ContentModel>();

                ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
            }
        }
        return View(contents);
    }
}
