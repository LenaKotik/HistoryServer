using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace HistoryServer.Models
{
    public class Student
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("result")]
        public int Result { get; set; }

        [JsonPropertyName("date")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }
        public override string ToString()
        {
            return $"name:{this.Name}, time:{this.Date.TimeOfDay}, result:{this.Result}";
        }
    }
}
