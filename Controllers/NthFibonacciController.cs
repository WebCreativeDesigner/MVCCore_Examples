using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCCore_Examples.Models.NthFibonacci;

namespace MVCCore_Examples.Controllers
{
    public class NthFibonacciController : Controller
    {
        private List<NthFibonacciModel> NthFibonacciModelList = null;
        private INthFibonacciRepository repository = null;

        private readonly ILogger<NthFibonacciController> _logger;

        public NthFibonacciController(ILogger<NthFibonacciController> logger, INthFibonacciRepository _repository)
        {
            _logger = logger;
            this.repository = _repository;
            this.NthFibonacciModelList = new List<NthFibonacciModel>();
        }

        [HttpGet]
        public IActionResult Index()
        {
            //return View();
            int Number = 4;
            NthFibonacciModelList = (List<NthFibonacciModel>)repository.Get_Nth_Fibonacci_Repository(Number);
            return View(NthFibonacciModelList.ToList());
        }

        [HttpPost]
        public IActionResult Index(string Number)
        {
            //return View();
            NthFibonacciModelList = (List<NthFibonacciModel>)repository.Get_Nth_Fibonacci_Repository(Convert.ToInt32(Number));
            return View(NthFibonacciModelList.ToList());
        }


    }
}
