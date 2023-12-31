﻿using System;
using Newtonsoft.Json;

namespace VirusTotalNet.Objects;

public class DomainResolution
{
    [JsonProperty("last_resolved", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime LastResolved { get; set; }

    [JsonProperty("ip_address")]
    public string IPAddress { get; set; }
}