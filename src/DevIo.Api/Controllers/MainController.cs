using DevIo.Api.ViewModels;
using DevIO.Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DevIo.Api.Controllers
{

    [ApiController]
    public abstract class MainController : ControllerBase
    {

        // Validação de notificações de erro

        // Validação de modelstate 

        // Validação de operação de negócios

    }

    [Route("api/fornecedores")]
    public  class FornecedoresController : MainController
    {
        public async Task<ActionResult<IEnumerable<FornecedorViewModel>>> ObterTodos()
        {
            var fornecedor = await FornecedorRepository.ObterTodos();
            
            
            
            return Ok();
        }
    }

}
