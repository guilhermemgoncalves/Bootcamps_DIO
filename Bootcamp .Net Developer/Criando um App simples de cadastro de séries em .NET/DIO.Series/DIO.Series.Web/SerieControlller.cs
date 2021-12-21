using Microsoft.AspNetCore.Mvc;

namespace DIO.Series.Web
{
    [Route("[controller]")]
    public class SerieControlller : Controller
    {
        /* 
         * GET = RETONRAR ALGO
         * POST = INSERIR ALGO
         * PUT = ALTERAR ALGO
         * DELETE = EXCLUIR ALGO
         * 
         */
        [HttpGet("")]
        public IActionResult Lista()
        { IList<SerieModels> series = new List<SerieModels>();
            series.Add(new SerieModels() { Titulo = "Titulo Séries!" });
            series.Add(new SerieModels() { Titulo = "Titulo Séries!" });
            series.Add(new SerieModels() { Titulo = "Titulo Séries!" });
            series.Add(new SerieModels() { Titulo = "Titulo Séries!" });
            series.Add(new SerieModels() { Titulo = "Titulo Séries!" });


            return Ok(series);
        }
    }
}
