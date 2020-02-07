using Microsoft.AspNetCore.Mvc;
using Reply.Domain.ReplyContext.Commands.Inputs;
using Reply.Domain.ReplyContext.Commands.Outputs;
using Reply.Domain.ReplyContext.Handlers;
using Reply.Domain.ReplyContext.Repository;
using Reply.Domain.ReplyContext.ValueObjects;
using Reply.Shared.Commands;



namespace Reply.Api.Controllers
{
    public class InsuranceController : Controller
    {
        private readonly InsuranceHandler _insuranceHandler;
        private readonly IInsuranceRepository _iInsuranceRepository;

        public InsuranceController(InsuranceHandler insuranceHandler, IInsuranceRepository iInsuranceRepository)
        {
            _insuranceHandler = insuranceHandler;
            _iInsuranceRepository = iInsuranceRepository;
        }

        /// <summary> 
        /// Controller responsible to receive insurance data 
        /// and send to your Handler     
        /// </summary>
        /// <param name="command">Objeto contem todos os dados necessarios para simular o seguro</param>
        /// <returns></returns>
        [HttpPost]
        [Route("v1/Insurance")]
        public IActionResult Post([FromBody]InsuranceCreateCommand command)
        {
            return Ok(_insuranceHandler.Handler(command));
        }

        /// <summary>
        /// Controller responsible for searching data of insurance by Cpf
        /// end return a Json      
        /// </summary>
        /// <param name="cpf">insured's identification </param>
        /// <returns></returns>
        [HttpGet]
        [Route("v1/Insurance/{cpf}")]
        public IActionResult GetByDocument(string cpf)
        {

            var document = new Document(cpf);

            if (document.Invalid)
                return BadRequest(new CommandResult(false, "Cpf Invalido!", document));

            var result = _iInsuranceRepository.GetInsuranceByDocument(cpf);

            return Ok(new CommandResult(true, "sucesso!", result));
        }

        /// <summary>
        /// Controller responsible for  searching  report of average
        /// and return data by Json
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("v1/Insurance/Relatorio")]
        public IActionResult Relatorio()
        {          
                      
            var result = _iInsuranceRepository.GetToRelatorio();

            return Ok(result);
        }

    }
}
