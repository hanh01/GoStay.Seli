using Newtonsoft.Json;

namespace GoStay.Seli.srcComponent;

public class Item
{
    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("label")] public string Label { get; set; }

    [JsonProperty("icon")] public string Icon { get; set; }

    [JsonProperty("description")] public string Description { get; set; }
}

public class List
{
    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("label")] public string Label { get; set; }

    [JsonProperty("items")] public List<Item> Items { get; set; }
}

public class Filter
{
    [JsonProperty("list")] public List<List> List { get; set; }
}
