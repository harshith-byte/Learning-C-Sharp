// See https://aka.ms/new-console-template for more information
namespace VariableAndDatatype{
    class program{
        static void Main(string []args){
            // Basic Datatypes
            int i=10;
            float f=2.0f;
            decimal d=5.0m;
            bool b=true;
            char c='c';

            // Collection of Characters
            string str="a string";

            // implicit declaration in c#
            var x=13;
            var z="hello";

            //array declaration
            int []vals=new int[5];

            // to implicity add data to array
            string []strs={"one","two","three"};

            // formatting string
            Console.WriteLine("Basic Datatypes");
            Console.WriteLine("Integer - {0}\nFloat - {1}\nDecimal - {2}"+
                    "\nBoolean - {3}\nCharacter - {4}\nString - {5}",i,f,d,b,c,str);
            
            Console.WriteLine("\nImplicit declaration");
            Console.WriteLine("var x = {0}\nvar z = {1}",x,z);

            Console.WriteLine("\nArray");
            Console.WriteLine("string []strs = {0}",strs);

            // Null
            Object obj=null;
            Console.WriteLine(obj);

            // Implicit Conversion between types
            long bignum;
            bignum=i;
            Console.WriteLine("Implicit conversion of int to long type - {0}",bignum);
            
            // Explicit Conversion between types
            float i_to_f;
            i_to_f=(float)i;
            Console.WriteLine("Explicit Conversion of int to float - {0}",i_to_f);

        }
    }
}

