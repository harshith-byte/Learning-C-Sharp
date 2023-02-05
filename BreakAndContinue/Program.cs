namespace BreakandContinue
{
    class Program
    {
        static void Main(string []args){
            int []values={15,7,12,23,41,28,9,17,36};

            Console.WriteLine("using break and continue statements");
            foreach(int i in values){
                // continue - to skip particular iteration of the loop
                if(i>=20 && i<=29){
                    continue;
                }

                // break - to terminate the loop from futher execution
                Console.WriteLine("the current value is {0}",i);
                if(i>=40){
                    break;
                }
            }
        }
    }
}