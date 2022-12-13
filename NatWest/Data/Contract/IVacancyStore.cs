using NatWest.Model.DTO;

namespace NatWest.Data.Contract
{
    public interface IVacancyStore
    {
        public void SaveVacancies(IList<VacanciesDTO> vacancies);
    }
}
