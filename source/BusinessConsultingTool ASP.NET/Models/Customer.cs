using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace BusinessConsultingTool_ASP.NET.DataAPI.Models
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("yritys")]
        [JsonPropertyName("yritys")]
        public string Name { get; set; } = "Yrityksen nimi";
    }
}
