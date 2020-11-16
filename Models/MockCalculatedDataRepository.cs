using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore_Examples.Models
{

    //The Mock Data Repository has an interface file with one main method that is configured in Startup.cs.
    // This repository can be replace if we ever implement Entity Framework.
    public class MockCalculatedDataRepository : ICalculatedDataRepository
    {
        private FileInfo ParamFile;
        private FileInfo RawDataFile;
        private StreamReader ParamReader;
        private StreamReader RawDataReader;
        private List<CalculatedDataModel> CalculatedDataModels;
        private decimal c;
        private decimal m;
        private List<decimal> RawDataListTotalItems;
        private List<decimal> CalculatedList;

        //Constructor to set local parameters and check if input files exist.
        public MockCalculatedDataRepository()
        {
            FileInfo _ParamFile = new FileInfo(@"Inputs\param.txt");
            FileInfo _RawDataFile = new FileInfo(@"Inputs\rawdata.txt");


            if (!_ParamFile.Exists)
                throw new FileNotFoundException("Could not find the Parameter file to process.");

            this.ParamFile = _ParamFile;

            if (!_RawDataFile.Exists)
                throw new FileNotFoundException("Could not find the Raw Data file to process.");

            this.RawDataFile = _RawDataFile;

            this.CalculatedDataModels = new List<CalculatedDataModel>();

        }


        //Specific functions Function1, 2, 3 and 4 for ease of reading.
        static decimal Function1_ToCalculateY(decimal m, decimal x, decimal c)
        {
            decimal Y;
            return Y = (m * x) + c;
        }

        static decimal Function3_ToCalculateA(decimal x)
        {
            decimal A;
            return A = 1 / x;
        }

        static decimal Function2_ToCalculateb(decimal A, decimal Y, List<decimal> X)
        {
            decimal B = A + Y;
            decimal b = B / X.Count();
            return b;
        }

        static decimal Function2_ToCalculateb_with_XCount(decimal A, decimal Y, int XCount)
        {
            decimal B = A + Y;
            decimal b = B / XCount;
            return b;
        }

        static decimal Function4_ToCalculate_SpecificValue_for_Output_ArrayListC(decimal SpecificValue_of_ArrayListX, decimal b)
        {
            decimal C = SpecificValue_of_ArrayListX + b;
            return C;
        }

        public decimal Calculate_Final_Value(decimal RawDataValueX, int RawDataCount, decimal _m, decimal _c)
        {
            decimal Y = Function1_ToCalculateY(_m, RawDataValueX, _c);
            decimal A = Function3_ToCalculateA(RawDataValueX);
            decimal b = Function2_ToCalculateb_with_XCount(A, Y, RawDataCount);
            decimal _Calculated = Function4_ToCalculate_SpecificValue_for_Output_ArrayListC(RawDataValueX, b);
            return _Calculated;
        }

        // A method to read the input files Eg. RawData and Paramere files and apply the various functions and export the Calculated Data to a list.
        public List<decimal> Calculate_New_Data_Results(List<decimal> RawDataListX, decimal _m, decimal _c)
        {
            int RawDataCount = RawDataListX.Count();
            List<decimal> _CalculatedList = new List<decimal>();

            for (int i = 0; i < RawDataListX.Count; i++)
            {
                decimal RawDataValueX = RawDataListX[i];

                /*
                //static decimal Function1_ToCalculateY(decimal m, decimal x, decimal c)
                decimal Y = Function1_ToCalculateY(m, RawDataValueX, c);
                //static decimal Function3_ToCalculateA(decimal x)
                decimal A = Function3_ToCalculateA(RawDataValueX);
                // static decimal Function2_ToCalculateb(decimal A, decimal Y, List<decimal> X)
                // decimal b = Function2_ToCalculateb(A, Y, RawDataListX);    
                decimal b = Function2_ToCalculateb_with_XCount(A, Y, RawDataCount);
                //static decimal Function4_ToCalculate_SpecificValue_for_Output_ArrayListC(decimal SpecificValue_of_ArrayListX, decimal b)
                decimal _Calculated = Function4_ToCalculate_SpecificValue_for_Output_ArrayListC(RawDataValueX, b);
                _CalculatedList.Add(_Calculated);
                */

                decimal _Calculated = Calculate_Final_Value(RawDataValueX, RawDataCount, _m, _c);
                _CalculatedList.Add(_Calculated);
            }

            return _CalculatedList;
        }

        // Main Repository method GetAllCalculatedDataRepository which reads the contents of the Params.txt file and assign to local variabales.
        // Output the newly calculatated list to the local variable this.CalculatedList.
        // Add all the CalculatedData to an IEnumerable<CalculatedDataModel>.  This list is then returns to the CalculationController.

        public List<CalculatedDataModel> GetAllCalculatedDataRepository()
        {
            // Read the Params file and update the 2 private variables m and c.
            try
            {
                this.ParamReader = new StreamReader(this.ParamFile.FullName);
                while (!ParamReader.EndOfStream)
                {
                    string line = ParamReader.ReadLine();
                    if (line.Contains("m ="))
                    {
                        this.m = Convert.ToDecimal(line.Substring(4));
                    }
                    if (line.Contains("c ="))
                    {
                        this.c = Convert.ToDecimal(line.Substring(4));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The Params file could not be read,  It must be in the wrong format.");
                Console.WriteLine(e.Message);
            }

            // Read the raw Data file and update the private list RawDataListTotalItems
                try
                {
                    this.RawDataReader = new StreamReader(this.RawDataFile.FullName);
                    while (!RawDataReader.EndOfStream)
                    {
                        string line = RawDataReader.ReadLine();
                        if (!line.Contains("X ="))
                        {
                            this.RawDataListTotalItems = line.Split(',')
                                .Where(m => decimal.TryParse(m, out _))
                                .Select(m => decimal.Parse(m))
                                .ToList();
                            Console.WriteLine("The number of items in Raw Data File: " + RawDataListTotalItems.Count());
                        }
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("The Raw Data file could not be read,  It must be in the wrong format.");
                    Console.WriteLine(e.Message);
                };

            // Calculated the Output list
            this.CalculatedList = Calculate_New_Data_Results(RawDataListTotalItems, m, c);
            
            //Create the models.
            int RawDataCount = RawDataListTotalItems.Count();
            for (int i = 0; i < RawDataCount; i++)
                {
                    CalculatedDataModel _CalculatedDataModel = new CalculatedDataModel()
                    {
                        Id = i + 1,
                        RawData = this.RawDataListTotalItems[i],
                        c = this.c,
                        m = this.m,
                        Calculated = this.CalculatedList[i]
                    };

                    this.CalculatedDataModels.Add(_CalculatedDataModel);
            }

            return this.CalculatedDataModels.ToList();
        }

        public void Create(CalculatedDataModel CalculatedData)
        {
            throw new NotImplementedException();
        }

        public void Update(CalculatedDataModel CalculatedData)
        {
            throw new NotImplementedException();
        }
    }
}
