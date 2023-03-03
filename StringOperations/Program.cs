namespace Str
{
    class Program{
        static void Main(string[] args){
            string outstr;
            string str1="The quick brown fox jumps over the lazy dog";
            string str2="This is a string";
            string str3="THIS is a STRING";
            string[] strs={"one","two","three","four"};

            // length of the string
            Console.WriteLine(str1.Length);

            // access individual characters
            Console.WriteLine(str1[14]);

            //iterate over string like any other sequence of values
            foreach(char ch in str1){
                Console.Write(ch);
                if(ch == 'b'){
                    Console.WriteLine();
                    break;
                }
            }

            // concatenate
            outstr=string.Concat(strs);
            Console.WriteLine(outstr);

            //joining strings together with join
            outstr=string.Join('.',strs);
            Console.WriteLine(outstr);

            outstr=string.Join("---",strs);
            Console.WriteLine(outstr);

            //string comparison
            // < 0 : first string comes before second in sort order
            //  0  : first and second strings are same position in sort order
            // > 0 : first string comes after second in sort order
            // used when sorting strings 
            int result = String.Compare(str2,"This is a string");
            Console.WriteLine(result);

            // equals just returns a regular boolean
            // straight true or false boolean result
            bool isEqual = str2.Equals(str3);
            Console.WriteLine(isEqual);

            //string searching
            Console.WriteLine(str1.IndexOf('e'));
            Console.WriteLine(str1.IndexOf("fox"));

            Console.WriteLine(str1.LastIndexOf('e'));
            Console.WriteLine(str1.LastIndexOf("the"));

            outstr = str1.Replace("fox","cat");
            Console.WriteLine(outstr);

            Console.WriteLine(outstr.IndexOf("fox"));
        }
    }
}