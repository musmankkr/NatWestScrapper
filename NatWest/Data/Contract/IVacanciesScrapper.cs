using NatWest.Model.DTO;

namespace NatWest.Data.Contract
{
    public interface IVacanciesScrapper
    {
        public List<VacanciesDTO> ScrapeVacancies();

        public IEnumerable<VacanciesDTO> FilterVacancies(IEnumerable<VacanciesDTO> VacanyList);
    }
}
