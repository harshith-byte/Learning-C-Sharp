namespace ExceptionHandling
{
    class Program
    {
        static void Main(string []args){
            int x=10000;
            int y=0;
            int result;
            
            // try catch expressions make error checking easier
            try{
                if(x>1000){
                    throw new ArgumentOutOfRangeException("x","x is greater than 1000");
                }
                result = x/y;
                Console.WriteLine("the result is {0}",result);    
            }
            catch (DivideByZeroException e){
                Console.WriteLine("divided by zero exception");
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e){
                Console.WriteLine("Sorry 1000 is limit");
                Console.WriteLine(e.Message);    
            }
            finally{
                Console.WriteLine("this code always runs");
            }
        }
    }
}