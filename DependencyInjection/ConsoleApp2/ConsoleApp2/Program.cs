using ConsoleApp2.Entity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void ShowProduct(User user)
        {
            Console.WriteLine($"First_Name: {user.first_name}, Last_Name: " +
                $"{user.last_name}. Email: {user.email}");
        }

        static async Task Main(string[] args)
        {
            /*
             tiers:
            repo
            service
            entities
             */
            var url = "https://reqres.in/api/users";
            var options = new JsonSerializerOptions { WriteIndented = true,PropertyNameCaseInsensitive = true };
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Response users = System.Text.Json.JsonSerializer.Deserialize<Response>(content, options);
                    var listUsers = users.data;
                    foreach (var item in listUsers)
                    {
                        ShowProduct(item);
                    }
                }


            }
        }

    }
}
