using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CraftsWebsite.Models
{
    public class Product
    {

        public string Id { get; set; }
        public string Maker { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }

        public string URL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int[] Ratings { get; set; }

        // Convert object information into text for JSON file
        public override string ToString() { return JsonSerializer.Serialize<Product>(this); }
    }
}
