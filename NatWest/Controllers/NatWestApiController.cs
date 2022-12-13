using Microsoft.AspNetCore.Mvc;
using NatWest.Data;
using NatWest.Data.Contract;
using NatWest.Model.DTO;
using Newtonsoft.Json;

namespace NatWest.Controllers
{
    [Route("api/NatWestApi")]
    [ApiController]
    public class NatWestApiController : ControllerBase
    {
        public IVacanciesScrapper _vacancyScrapper;
        public IVacancyStore vacancyStore;

        public NatWestApiController(IVacanciesScrapper vacancyScrapper, IVacancyStore vacancyStore)
        {
            _vacancyScrapper = vacancyScrapper;
            this.vacancyStore = vacancyStore;
        }

        /// <summary>
        /// HTTPGet End point 
        /// Retrieves all the filtered Vacancies
        /// </summary>
        /// <returns>ActionResult<IEnumerable<VacanciesDTO>></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<VacanciesDTO>> GetVacancies()
        {
            try
            {
                var vacancies = _vacancyScrapper.ScrapeVacancies(); //read vacancies from the natwestWebsite
                vacancyStore.SaveVacancies(vacancies); //save vancies to the file
                return Ok(_vacancyScrapper.ScrapeVacancies()); //return vacancies as a json response
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Exception Message", e.Message);
                return BadRequest(ModelState);
            }
        }
    }
}
