
namespace GuessNumber
{
    class Program{
        static void Main(string[] args){
            int theNumber = new Random().Next(20);
            int count=0;
            int targetnum=0;
            //printing greetings
            Console.WriteLine("Let's play 'Guess the Number' !");
            Console.WriteLine("I'm thinking of a Number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");
            

            while(true){
                bool success=false;
                
                Console.WriteLine("What's your guess?");
                string n=Console.ReadLine();
                
                success=Int32.TryParse(n,out targetnum);
                Console.WriteLine($"targetnum - {targetnum}");
                if(success){
                    count=count+1;
                    if(targetnum==-1){
                        break;
                    }
                    if(targetnum==theNumber){
                        Console.WriteLine($"you got it in {count} guesses!!");
                        break;
                    }
                    else if(targetnum<theNumber){
                        Console.WriteLine("Nope. Higher than that.");
                    }
                    else if(targetnum>theNumber){
                        Console.WriteLine("Nope. Lower than that.");
                    }      
                }
                else{
                    Console.WriteLine("Hmm. that's doesn't look like a number. Try Again.");
                }
            }
        }
    }
}