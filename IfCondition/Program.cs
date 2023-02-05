
namespace Ifcondition
{
    class Program{
        static void Main(string []args){
            int val =50;

            // if-else 
            if(val==50){
                Console.WriteLine("the val is 50");
            }
            else if(val>=51 && val<=60){
                Console.WriteLine("the val is in between 51 and 60");
            }
            else{
                Console.WriteLine("The val is something else");
            }

            // ternary Operator

            Console.WriteLine(val<50 ? "the val is smaller":"the val is > 50");
        }
    }
}