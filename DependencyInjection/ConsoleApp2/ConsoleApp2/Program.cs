using ConsoleApp2.Entity;
using Newtonsoft.Json;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using ConsoleApp2.Repository;
using ConsoleApp2.Services;

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
            var repository = new UserRepository();
            var pokeRepository = new PokemonRepository();
            var listUsers = await repository.GetUsers();
            var listPokemons = await pokeRepository.GetPokemons();
            var listPokeItems = await pokeRepository.GetPokeItems();

            var printer1 = new InyeccionPrinterService();
            var printer2 = new LaserPrinterService();

            foreach (var item in listUsers)
            {
                ShowProduct(item);
            }
            foreach (var item in listPokemons)
            {
                printer1.Print(item,"Certificado el pokemon.");    
            }
            foreach (var item in listPokeItems)
            {
                printer2.Print(item,"No Certificado el item.");
            }   
        }
    }
}
