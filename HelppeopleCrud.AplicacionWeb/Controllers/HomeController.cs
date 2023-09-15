using HelppeopleCrud.AplicacionWeb.DTO_s;
using HelppeopleCrud.AplicacionWeb.Models;
using HelppeopleCrud.BLL.Service;
using HelppeopleCrud.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelppeopleCrud.AplicacionWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICiudadanoService _ciudadanoService;
        private readonly IVacanteService _vacanteService;


        public HomeController(ICiudadanoService ciudadanoServ, IVacanteService vacanteServ)
        {
            _ciudadanoService = ciudadanoServ;
            _vacanteService = vacanteServ;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] public async Task<IActionResult> ListaC()
        {
            IQueryable<Ciudadano> queryciudadano = await  _ciudadanoService.ObtenerTodos();
            List<CiudadanoDTO> ciudadanoDTO = queryciudadano
                .Select(x => new CiudadanoDTO()
                {
                    Id= x.Id,
                    Nombres= x.Nombres,
                    Apellidos= x.Apellidos,
                    FechaNacimiento = x.FechaNacimiento,
                    Profesion = x.Profesion,
                    Aspiracion= x.Aspiracion,
                    Email= x.Email,
                    NumeroDoc= x.NumeroDoc,
                    TipoDoc= x.TipoDoc
                }).ToList();

                
            return StatusCode(StatusCodes.Status200OK,ciudadanoDTO);
        }

        [HttpGet]
        public async Task<IActionResult> ListaV()
        {
            IQueryable<Vacante> queryciudadano = await _vacanteService.ObtenerTodos();
            List<VacanteDTO> vacanteDTO = queryciudadano
                .Select(x => new VacanteDTO()
                {
                    Id = x.Id,
                    Cargo = x.Cargo,
                    Descripcion = x.Descripcion,
                    Codigo = x.Codigo,
                    Empresa = x.Empresa,
                    Estado = x.Estado,
                    IdCiudadano = x.IdCiudadano,
                    Salario = x.Salario
                }).ToList();


            return StatusCode(StatusCodes.Status200OK, vacanteDTO);
        }

        [HttpPost]
        public async Task<IActionResult> InsertarC([FromBody]CiudadanoDTO ciudadanoDTO)
        {
            Ciudadano ciudadano = new Ciudadano()
            {
                Nombres = ciudadanoDTO.Nombres,
                Apellidos = ciudadanoDTO.Apellidos,
                FechaNacimiento = ciudadanoDTO.FechaNacimiento,
                Profesion = ciudadanoDTO.Profesion,
                Aspiracion = ciudadanoDTO.Aspiracion,
                Email = ciudadanoDTO.Email,
                NumeroDoc = ciudadanoDTO.NumeroDoc,
                TipoDoc = ciudadanoDTO.TipoDoc
            };

            bool response = await _ciudadanoService.Insertar(ciudadano);

            return StatusCode(StatusCodes.Status200OK, new { valor = response } );
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarC([FromBody] CiudadanoDTO ciudadanoDTO)
        {
            Ciudadano ciudadano = new Ciudadano()
            {
                Nombres = ciudadanoDTO.Nombres,
                Apellidos = ciudadanoDTO.Apellidos,
                FechaNacimiento = ciudadanoDTO.FechaNacimiento,
                Profesion = ciudadanoDTO.Profesion,
                Aspiracion = ciudadanoDTO.Aspiracion,
                Email = ciudadanoDTO.Email,
                NumeroDoc = ciudadanoDTO.NumeroDoc,
                TipoDoc = ciudadanoDTO.TipoDoc
            };

            bool response = await _ciudadanoService.Actualizar(ciudadano);

            return StatusCode(StatusCodes.Status200OK, new { valor = response });
        }

        public async Task<IActionResult> ActualizarV([FromBody] VacanteDTO vacanteDTO)
        {
            Vacante vacante = new Vacante()
            {
                Id = vacanteDTO.Id,
                Cargo = vacanteDTO.Cargo,
                Descripcion = vacanteDTO.Descripcion,
                Codigo = vacanteDTO.Codigo,
                Empresa = vacanteDTO.Empresa,
                Estado = vacanteDTO.Estado,
                IdCiudadano = vacanteDTO.IdCiudadano,
                Salario = vacanteDTO.Salario
            };

            bool response = await _vacanteService.Actualizar(vacante);

            return StatusCode(StatusCodes.Status200OK, new { valor = response });
        }

        [HttpDelete]
        public async Task<IActionResult> Eliminar(int Id)
        {
            
            bool response = await _ciudadanoService.Eliminar(Id);

            return StatusCode(StatusCodes.Status200OK, new { valor = response });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}