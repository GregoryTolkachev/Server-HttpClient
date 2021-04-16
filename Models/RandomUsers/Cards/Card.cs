using System.Collections;
using System.Text.Json.Serialization;

namespace Models.Cards
{

    public class Card
    {

        public string Id { get; set; }

        [JsonPropertyName("image_uris")]
        public ImageUris ImageUris { get; set; }
    }

}