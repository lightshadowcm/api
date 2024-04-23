using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class clientecontroller : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
         
        public dynamic listarClientes()
        {

            List<cliente> clientes = new List<cliente>()
            {
                new cliente
                {
                    id = "1",
                    nombre="bernardo"

                }
            };
            return clientes;
        }
        [HttpPost]
        [Route("guardar")]
        public dynamic guardarCliente(cliente cliente
            )
        {
            

            return new
            {
                success = true,
                message = "cliente registrado " + cliente,
                result = cliente
            };
        }
        [HttpGet]
        [Route("listarxid")]

        public dynamic listarClientesxid(int _id)
        {

            List<cliente> clientes = new List<cliente>()
            {
                new cliente
                {
                    id = _id.ToString(),
                    nombre="bernardo"

                }
            };
            return clientes;
        }
        [HttpGet]
        [Route("listarxnombre")]

        public dynamic listarClientesxnombre(string nombre)
        {

            List<cliente> clientes = new List<cliente>()
            {
                new cliente
                {
                    nombre = "hola "+ nombre.ToString()
                   

                }
            };
            return clientes;
        }



    }
}
