namespace operators{
    class Program{
        static void Main(string []args){
            
            //Declare variables
            int x=10, y=5;
            string a="abcd", b="efgh";

            // basic maths operator
            Console.WriteLine("----Basic Math Operators----");
            Console.WriteLine("(x / y) * x -> "+(x / y) * x);
            Console.WriteLine("a + b -> "+(a+b));

            // increment / decrement operator
            Console.WriteLine("----ShortHand----");
            x++;
            y--;
            Console.WriteLine("x++ -> "+x+ " ,y-- -> "+y);

            // Operator can be shorthand: a=a+b
            a+=b;
            Console.WriteLine("a+=b -> "+a);

            // Logical Operator &&, ||
            Console.WriteLine("----Logical Operator----");
            Console.WriteLine("(x > y && y >=5) -> "+(x > y && y >=5));
            Console.WriteLine("(x > y || y >=5) -> "+(x > y || y >=5));

            // null-coalescing operators
            string str=null;
            // the operator ?? uses left operand if not null, or right operator if it is null
            Console.WriteLine(str ?? "the str is null so it is printing this");

            // operator ??= assigns the right operand if the left one is null
            // it replaces the code:
            //if(variable is null){
            //  variable = somevalue;
            //}   

            str ??= "this string value is added by checking if str is null";
            Console.WriteLine(str);
        }
    }
}
