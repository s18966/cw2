using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace CW2
{
    [Serializable]
    public class Studies
    {
        [JsonProperty("name")]
        public string imie{ get; set; }
        [JsonProperty("type")]
        public string typ { get; set; }

        public override string ToString()
        {
            return "Name: " + imie + " type: " + typ;

        }
    }
}
