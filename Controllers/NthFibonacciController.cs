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
        private List<NthFibonacciModel> NthFibonacciModel = null;
        private INthFibonacciRepository repository = null;

        private readonly ILogger<NthFibonacciController> _logger;

        public NthFibonacciController(ILogger<NthFibonacciController> logger, INthFibonacciRepository _repository)
        {
            _logger = logger;
            this.repository = _repository;
            this.NthFibonacciModel = new List<NthFibonacciModel>();
        }

        [HttpGet]
        public IActionResult Index()
        {
            //return View();
            int Number = 4;
            //NthFibonacciModel = (List<NthFibonacciModel>)repository.Get_Nth_Fibonacci_Repository(Number);
            NthFibonacciListViewModel NthFibonacciListViewModel = new NthFibonacciListViewModel();
            //return View(NthFibonacciModel.ToList());
            NthFibonacciListViewModel.NthFibonacciModels = repository.Get_Nth_Fibonacci_Repository(Convert.ToDouble(Number));
            NthFibonacciListViewModel.Number = Convert.ToString(Number);
            return View(NthFibonacciListViewModel);
        }

        [HttpPost]
        public IActionResult Index(string Number)
        {
            NthFibonacciListViewModel NthFibonacciListViewModel = new NthFibonacciListViewModel();
            NthFibonacciListViewModel.Number = Number;

            //return View();
            try
            {
                //NthFibonacciModel = (List<NthFibonacciModel>)repository.Get_Nth_Fibonacci_Repository(Convert.ToDouble(Number));
                NthFibonacciListViewModel.NthFibonacciModels = repository.Get_Nth_Fibonacci_Repository(Convert.ToDouble(Number));
                NthFibonacciListViewModel.Number = Number;
                //return View(NthFibonacciListViewModel);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                ModelState.AddModelError("", "The Number entered is the wrong type.  It should be an integer or a double.");
            }

            //return View(repository.Get_Nth_Fibonacci_Repository(Convert.ToDouble(Number)));
            return View(NthFibonacciListViewModel);
            //return View(NthFibonacciModel.ToList());

        }


    }
}
