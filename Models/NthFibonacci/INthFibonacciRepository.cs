using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore_Examples.Models.NthFibonacci
{
    public interface INthFibonacciRepository
    {
        List<NthFibonacciModel> Get_Nth_Fibonacci_Repository(Double Number);
        Boolean Is_Fibonacci_Number(double Number);
        //List<NthFibonacciModel> SpecificNumber_Nth_Fibonacci_Data(int Number);
    }
}
