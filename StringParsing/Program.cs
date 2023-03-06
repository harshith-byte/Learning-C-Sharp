using System;
using System.Globalization;

namespace StringParsing
{
    class Program{
        static void Main(string[] args){
            string numstr1="1";
            string numstr2="2.00";
            string numstr3="3,000";
            string numstr4="3,000.00";

            //Parse Function attempts to parse a string into a number 
            //but it might throw a exception, so we need to catch that

            int targetnum=0;
            try{

                // use parse to try a simple integer
                targetnum=int.Parse(numstr1);
                Console.WriteLine(targetnum);

                // use parse to try a floating point number 
                // this only works if the decimal value is 0
                // System.Globalization is used for NumberStyles
                targetnum=int.Parse(numstr2,NumberStyles.Float);
                Console.WriteLine(targetnum);

                // use parse to try a number with thousands marker
                targetnum=int.Parse(numstr3,NumberStyles.AllowThousands);
                Console.WriteLine(targetnum); 

                // use parse to try a number with thousands marker and decimal
                targetnum=int.Parse(numstr4,NumberStyles.AllowThousands | NumberStyles.Float);
                Console.WriteLine(targetnum); 

                // this works with other types like bool
                Console.WriteLine($"{bool.Parse("True")}");

                //or floating point number
                Console.WriteLine($"{float.Parse("1.235"):F2}");
            }catch{
                Console.WriteLine("Conversion failed");
            }
            

        // tryparse function is similar but handles the exception for us 
        bool success=false;
        success=Int32.TryParse(numstr1,out targetnum);
        if(success){
            Console.WriteLine($"{targetnum}");
        }


        }
    }
}