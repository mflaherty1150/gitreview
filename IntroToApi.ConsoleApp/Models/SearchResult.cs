using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IntroToApi.ConsoleApp.Models
{
    public class SearchResult<T>
    {
        [JsonProperty("count")]
        public int Count {get; set;}

        [JsonProperty("results")]
        public List<T> Results {get; set;}
    }
}