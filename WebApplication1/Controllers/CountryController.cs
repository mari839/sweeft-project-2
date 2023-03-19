using Microsoft.AspNetCore.Mvc;
using WebApplication1.ApiServices;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/countries")]
    public class CountryController : ControllerBase
    {
        private readonly CountryDataFilesGeneratorService _countryDataFilesGeneratorService;

        public CountryController(CountryDataFilesGeneratorService countryDataFilesGeneratorService)
        {
            _countryDataFilesGeneratorService = countryDataFilesGeneratorService ?? throw new ArgumentNullException(nameof(countryDataFilesGeneratorService));
        }

        [HttpGet]
        [Route("GenerateCountryDataFiles")]
        public void GenerateCountryDataFiles()
        {
            _countryDataFilesGeneratorService.GenerateCountryDataFiles();
        }
    }
}
