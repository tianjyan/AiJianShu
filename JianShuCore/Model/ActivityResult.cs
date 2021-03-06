﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JianShuCore.Model
{
    public class ActivityResult
    {
        [JsonProperty("id")]
        public int Id
        {
            get;
            set;
        }

        [JsonProperty("event")]
        public string Event
        {
            get;
            set;
        }

        [JsonProperty("source")]
        public Source Source
        {
            get;
            set;
        }

        [JsonProperty("target")]
        public Target Target
        {
            get;
            set;
        }

        [JsonProperty("created_at")]
        public int CreatedAt
        {
            get;
            set;
        }
    }
}
