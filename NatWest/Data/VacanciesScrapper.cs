using NatWest.Data.Contract;
using NatWest.Model.DTO;
using Newtonsoft.Json;

namespace NatWest.Data
{
    public class VacanciesScrapper : IVacanciesScrapper
    {
        HttpClient client;

        private readonly IConfiguration? _configuration;
        public VacanciesScrapper(HttpClient client, IConfiguration configuration)
        {
            this.client = client;
            _configuration = configuration;
        }

        /// <summary>
        /// Scrapes the data from the dummy NatWestWebsite.
        /// </summary>
        /// <returns></returns>
        public List<VacanciesDTO> ScrapeVacancies()
        {
            List<VacanciesDTO> Vacancies = new List<VacanciesDTO>();

            var index = 0;
            bool next;
            do
            {
                string? url = _configuration?.GetValue<string>("MySettings:url");

                var res = client.GetAsync(url + "/test?index=" + index).Result.Content.ReadAsStringAsync().Result;

                var resp = JsonConvert.DeserializeObject<VacancyResponse>(res);

                var filteredVacancies = FilterVacancies(resp.Vacancies);

                Vacancies.AddRange(filteredVacancies);

                index++;
                next = resp.HasNext;
            } while (next);

            return Vacancies;
        }

        #region Helper

        /// <summary>
        /// Filters Vacancies; in this case it's filtering out those vacancies which doesn't have any Desciption or Salary
        /// </summary>
        /// <param name="VacanyList"></param>
        /// <returns>IEnumerable<VacanciesDTO></returns>
        public IEnumerable<VacanciesDTO> FilterVacancies(IEnumerable<VacanciesDTO> VacanyList)
        {
            return ((VacanyList.Where(x => x.Salary > 0)).Where(x => x.vacancyDescription != "")).Where(x => x.vacancyDescription != null);

        }
        #endregion

    }
}
