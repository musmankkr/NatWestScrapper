using NatWest.Data.Contract;
using NatWest.Model.DTO;
using Newtonsoft.Json;

namespace NatWest.Data
{
    public class VacancyStore : IVacancyStore
    {
        IConfiguration _configuration;
        string WriteFileName;
        string WorkingDirectory;
        string FolderName;

        public VacancyStore(IConfiguration iconfig)
        {
            _configuration = iconfig;
            WriteFileName = _configuration.GetValue<string>("MySettings:WriteFileName");
            FolderName = _configuration.GetValue<string>("MySettings:FolderName");
            WorkingDirectory = Environment.CurrentDirectory;
        }

        /// <summary>
        /// Save Vacancies scrapped from Natwest Website to WorkingDirectory/FolderName
        /// </summary>
        /// <param name="vacancies"></param>
        public void SaveVacancies(IList<VacanciesDTO> vacancies)
        {
            try
            {
                string finalVacancies = JsonConvert.SerializeObject(vacancies);
                string filepath = WorkingDirectory + "\\" + FolderName + "\\" + Guid.NewGuid()+WriteFileName;
                File.WriteAllText(filepath, finalVacancies);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
