using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6
{
    internal class LAB666
    {
        public string _stringValue = "42";
        public int _intvalue = 1;
        public double _doubleValue = 1d;
        public string? _stringValueMBnull;
        public int? _intValueMBnull;
        public double? _doublevalieMBnull;


        public LAB666(string stringValue, int intValue, double doubleValue, string? stringValueMBnull = null, int? intValueMBnull = null, double? doubleValueMBnull = null)
        {
            _stringValue = stringValue;
            _intvalue = intValue;
            _doubleValue = doubleValue;
            _stringValueMBnull = stringValueMBnull;
            _intValueMBnull = intValueMBnull;
            _doublevalieMBnull = doubleValueMBnull;
        }


        public static void Info(LAB666 oleg)
        {
            if (oleg != null)
            {
                if (oleg._stringValue != null)
                {
                    Console.WriteLine(oleg._stringValue);
                }
                else { Console.WriteLine("No Data"); }
                Console.WriteLine(oleg._intvalue);
                Console.WriteLine(oleg._doubleValue);

                if (oleg._stringValueMBnull != null)
                {
                    Console.WriteLine(oleg._stringValueMBnull);
                }
                else { Console.WriteLine("No Data"); }

                if (oleg._intValueMBnull != null)
                {
                    Console.WriteLine(oleg._intValueMBnull);
                }
                else { Console.WriteLine("No Data"); }

                if (oleg._doublevalieMBnull != null)
                {
                    Console.WriteLine(oleg._doublevalieMBnull);
                }
                else { Console.WriteLine("No Data"); }
            }
            Console.WriteLine('\n');
        }


        public static void ReplaceNull(LAB666 oleg)
        {
            oleg._stringValueMBnull ??= "sobaka42";
            oleg._intValueMBnull ??= 42;
            oleg._doublevalieMBnull ??= 42d;
        }

        public static string Lab6Ex9(LAB666? oleg)
        {
            return oleg is null ? "No value" : oleg._stringValue;
        } 

        public static string Lab6Ex10(LAB666 oleg)
        {
            return oleg._stringValueMBnull ?? "No value 2";
        }
    }
}
