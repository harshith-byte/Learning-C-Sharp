namespace forloop
{
    class Program
    {
        static void Main(string []args){
            int val = 15;
            int[] num=new int[]{3,14,15,92,6};
            string str="The quick brown fox jumps over the lazy dog";

            // basic loop
            Console.WriteLine("Basic for loop");
            for(int i=0;i<val;i++){
                Console.WriteLine("i is currently in {0}",i);
            }

            // foreach Loop
            Console.WriteLine("For each loop");
            foreach(int i in num){
                Console.WriteLine("i is currently in {0}",i);
            }

            // Number of o's in the string str
            int count=0;
            foreach(char c in str){
                if(c=='o'){
                    count++;
                }
            }
            Console.WriteLine("Count of o's in string str is {0}",count);
        }
    }
}