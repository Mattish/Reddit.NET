﻿using Newtonsoft.Json;
using System;

namespace Reddit.NET.Models.Structures
{
    [Serializable]
    public class DynamicListingChild : BaseContainer
    {
        [JsonProperty("data")]
        public dynamic Data;
    }
}