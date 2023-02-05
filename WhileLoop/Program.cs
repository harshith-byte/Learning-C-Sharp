namespace whileLoop
{
    class Program
    {
        static void Main(string []args){
            
            string str = "";
            // basic while loop
            Console.WriteLine("Basic While loop");
            while(str!="exit"){
                str = Console.ReadLine();
                Console.WriteLine("You entered {0}",str);
            }
            Console.WriteLine();

            // do while loop
            Console.WriteLine("do-While() loop");
            do{
                str = Console.ReadLine();
                Console.WriteLine("You entered {0}",str);
            }while(str!="exit");
        }
    }
}