﻿using Newtonsoft.Json;

namespace Moonlight.App.Models.Wings.Requests;

public class RestoreBackupRequest
{
    [JsonProperty("adapter")]
    public string Adapter { get; set; }

    [JsonProperty("truncate_directory")] public bool TruncateDirectory { get; set; } = false;
    [JsonProperty("download_url")] public string DownloadUrl { get; set; } = "";
}