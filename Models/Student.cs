using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HistoryServer.Models
{
    public class Student
    {
        public static ValidationResult Validate(string Name)
        {
            if (Name.Length < 3 || Name.Length > 30)
                return new ValidationResult("Имя должно быть от 3 до 30 символов");
            if (!(Encoding.UTF8.GetByteCount(Name) == Name.Length))
                return new ValidationResult("Имя должно содержать только ASCII символы\n(латинские буквы, цифры и спец символы)");
            return ValidationResult.Success;
        }
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required]
        [CustomValidation(typeof(Student), "Validate")]
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
