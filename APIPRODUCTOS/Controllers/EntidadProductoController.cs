using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIPRODUCTOS.Entidades;
using APIPRODUCTOS.DAO;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace APIPRODUCTOS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntidadProductoController : ControllerBase
    {
        [HttpGet("GetProductos")] 
        public async Task<ActionResult<List<EntidadProducto>>> Get()
        {
            var lista = await Task.Run(() => (new ProductoDAO()).GetProductos());
            return Ok(lista);
        }
    }
}
