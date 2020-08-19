using CalcDecomposition.Shared.Queries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CalcDecomposition.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DecompositionCalculationController : ControllerBase
    {
        /// <summary>
        /// EndPoint responsável por retornar o resultado dos divisores e 
        /// números primos (dos divisores) de acordo com o número de entrada.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        [HttpGet("Calculate/Divisor/{number}")]
        public async Task<IActionResult> CalculateDivisorByNumber(int number)
        {
            try
            {
                var queryResult = CalculateDivisorQueries.GetDividersByNumber(number);
                return await Task.FromResult(Ok(queryResult));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
