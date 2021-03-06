﻿using System;

namespace Server.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    public class StatsRanking
    {
        public StatsRanking()
        {
            this.Champions = new HashSet<Champion>();
        }
        [JsonIgnore]
        public int Id { get; set; }
        public int SummonerId { get; set; }
        [JsonIgnore]
        public string SummonerName { get; set; }
        public long ModifyDate { get; set; }
        public ICollection<Champion> Champions { get; set; }
    }
}
