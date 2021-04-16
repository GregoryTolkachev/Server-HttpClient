
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models.Cards
{

    public class Cards
    {

        public ICollection<Card> Data { get; set; }

        [JsonPropertyName("total_cards")]
        public uint TotalCards { get; set; }
    }

}