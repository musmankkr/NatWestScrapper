using NatWest.Business;
using Newtonsoft.Json;

namespace NatWest.Model.DTO
{
    public class VacanciesDTO
    {
        [JsonRequired]
        public int? Id { get; set; }
        public int? Salary { get; set; }
        public string? location { get; set; }
        public string? typeofEmployment { get; set; }
        [System.Text.Json.Serialization.JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateTime postingDate { get; set; }
        public string? candidaterequirements { get; set; }
        public string? roledescription { get; set; }
        public string? vacancyDescription { get; set; }
        public string? learningoutcomes { get; set; }
    }
    
    public class VacancyResponse
    {
        public int Index { get; set; }
        public List<VacanciesDTO> Vacancies { get; set; }
        public bool HasPrevious { get; set; }
        public bool HasNext { get; set; }

    }
}
