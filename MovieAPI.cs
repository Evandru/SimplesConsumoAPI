﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplesConsumoAPI
{
    public class MovieAPI
    {
        public async Task<MovieModel> GetMovie(string title)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"http://www.omdbapi.com/?apikey=931237d&t={title}");
            var jsonString = await response.Content.ReadAsStringAsync();

            MovieModel movie = JsonConvert.DeserializeObject<MovieModel>(jsonString);

            return movie;
        }

        public async Task<SearchResponseModel> GetSearchResponse(string search)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"http://www.omdbapi.com/?apikey=931237d&s={search}");
            var jsonString = await response.Content.ReadAsStringAsync();
            
            SearchResponseModel searchResponse = JsonConvert.DeserializeObject<SearchResponseModel>(jsonString);

            return searchResponse;
        }
    }
}
