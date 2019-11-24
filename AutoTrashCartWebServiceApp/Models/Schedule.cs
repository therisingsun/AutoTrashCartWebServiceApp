﻿using Newtonsoft.Json;

namespace AutoTrashCartWebServiceApp.Models
{
    public class Schedule
    {
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }
        public int Day { get; set; }
        public System.TimeSpan Pickup { get; set; }
        public bool Holidays { get; set; }
    }
}