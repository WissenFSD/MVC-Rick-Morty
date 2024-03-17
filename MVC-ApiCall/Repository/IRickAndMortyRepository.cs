﻿using MVC_ApiCall.Models;
using RestSharp;
using Newtonsoft.Json;

namespace MVC_ApiCall.Repository
{
    public interface IRickAndMortyRepository
    {
        public CharacterResults GetCharacters(int page);

    }


    public class RickAndMortyRepository : IRickAndMortyRepository
    {
        public CharacterResults GetCharacters(int page)
        {
            //RestSharp ile apiye istek atmak
            var restClient = new RestClient("https://rickandmortyapi.com/api");
            var restRequest = new RestRequest("character/?page="+page);
            var response = restClient.ExecuteGet(restRequest);

            // Gelen json veriyi benim istediğim tipe çevirmek için bir paket kullanacağım 
            // Paketin adı NewtonSoft.Json

            var characterResults = JsonConvert.DeserializeObject<CharacterResults>(response.Content);

            return characterResults;
        }

        

    }


}
