using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FibAPI.Services;

namespace FibAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FibonacciController : ControllerBase
    {
       
        private readonly ILogger<FibonacciController> _logger;
        private readonly FibonacciService _service;

        public FibonacciController(ILogger<FibonacciController> logger, FibonacciService service)
        {
            _logger = logger;
            _service = service;
        }

        /// <summary>
        /// API endpoint for getting Fibonacci Sequence
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<int> Get(int len)
        {
            return _service.GetSequence(len);
        }
    }
}
