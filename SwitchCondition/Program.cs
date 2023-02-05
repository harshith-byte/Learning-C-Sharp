namespace SwitchCondition
{
    class Program{
        static void Main(string []args){
             int val =60;

             //Switch statement
             switch(val){
                case 50:
                    Console.WriteLine("the val is 50");
                    break;
                case 51:
                    Console.WriteLine("the val is 51");
                    break;
                case 52:
                    Console.WriteLine("the val is 52");
                    break;
                case 53:
                case 54:
                case 55:
                    Console.WriteLine("the val is between 53 and 55");
                    break;
                default:
                    Console.WriteLine("the val is something else");
                    break;
             }
        }
    }
}