using Microsoft.AspNetCore.Mvc;

namespace AndisbankAPI_GraphQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GarantiasController : ControllerBase
    {
        private static readonly string[] garantias = new[]
        {
        "inmueble","vehiculo","terreno",
        };

        [HttpGet(Name = "GetGarantias")]
        public IEnumerable<string> GetGarantias()
        {
            return garantias;
        }
    }
}