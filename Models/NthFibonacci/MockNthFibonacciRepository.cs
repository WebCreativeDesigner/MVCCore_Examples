using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore_Examples.Models.NthFibonacci
{
    public class MockNthFibonacciRepository : INthFibonacciRepository
    {
        private int Id;
        private int Number;
        private Boolean NthFibonacciType;
        private List<NthFibonacciModel> NthFibonacciModels;
        decimal CalculatedNumber1 = 0;
        private Boolean CalculatedNumber1_Validity;
        decimal CalculatedNumber2 = 0;
        private Boolean CalculatedNumber2_Validity;
        private Boolean res;
        private Int64 a;
        public MockNthFibonacciRepository()
        {
            this.NthFibonacciModels = new List<NthFibonacciModel>();
        }

        public List<NthFibonacciModel> Get_Nth_Fibonacci_Repository(int Number)
        {
            this.Id = 1;
            //this.Number = 5;  // this is result in true
            // this.Number = 3;  // this is result in true
            this.Number = Number;
            //this.Number = 4;  // this will result in a True

            //this.CalculatedNumber1 = Convert.ToDecimal(Math.Sqrt(5 * (Number * Number) - 4));

            CalculatedNumber1_Validity = Int64.TryParse(Convert.ToString(Math.Sqrt(5 * (Number * Number) + 4)), out a);
            CalculatedNumber2_Validity = Int64.TryParse(Convert.ToString(Math.Sqrt(5 * (Number * Number) - 4)), out a);
            if (CalculatedNumber1_Validity == true || CalculatedNumber2_Validity == true)
            {
                NthFibonacciType = true;
                if (CalculatedNumber1_Validity == true)
                {
                    CalculatedNumber1 = Convert.ToDecimal(Math.Sqrt(5 * (Number * Number) + 4));
                };

                if (CalculatedNumber2_Validity == true)
                {
                    CalculatedNumber2 = Convert.ToDecimal(Math.Sqrt(5 * (Number * Number) - 4));
                };
            }
            else
            {
                NthFibonacciType = false;
            }

            NthFibonacciModel _NthFibonacciModel = new NthFibonacciModel()
            {
                Id = this.Id,
                Number = this.Number,
                CalculatedNumber1 = this.CalculatedNumber1,
                CalculatedNumber2 = this.CalculatedNumber2,
                NthFibonacciType = this.NthFibonacciType
            };

            this.NthFibonacciModels.Add(_NthFibonacciModel);

            return this.NthFibonacciModels.ToList();
        }

        public Boolean Is_Fibonacci_Number(int Number)
        {
            this.Number = Number;

            CalculatedNumber1_Validity = Int64.TryParse(Convert.ToString(Math.Sqrt(5 * (Number * Number) + 4)), out a);
            CalculatedNumber2_Validity = Int64.TryParse(Convert.ToString(Math.Sqrt(5 * (Number * Number) - 4)), out a);
            if (CalculatedNumber1_Validity == true || CalculatedNumber2_Validity == true)
            {
                NthFibonacciType = true;
            }
            else
            {
                NthFibonacciType = false;
            }

            return NthFibonacciType;
        }
    }
}
