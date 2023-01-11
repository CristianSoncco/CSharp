using ConsoleApp2.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp2.Repository
{
    public class UserRepository : IUserRepository
    {
        public async Task<List<User>> GetUsers()
        {
            var url = "https://reqres.in/api/users";
            var options = new JsonSerializerOptions { WriteIndented = true,PropertyNameCaseInsensitive = true };
            List<User> listUsers = new List<User>();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    UserRes users = System.Text.Json.JsonSerializer.Deserialize<UserRes>(content, options);
                    listUsers = users.data;

                }


            }
            return listUsers;

        }
    }
}
