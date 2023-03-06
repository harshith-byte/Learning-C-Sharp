using System;
using System.Text;

namespace stringbuilder
{
    class Program{
        static void Main(String[] args){
            int jumpcount=10;
            string[] animals = {"goats","cats","pigs"};

            // create string builder
            StringBuilder sb = new StringBuilder("Initial String.",200);

            // print some basics stats about the stringbuilder
            Console.WriteLine($"Capacity : {sb.Capacity}; Length : {sb.Length}");

            // Add some string to the builder using Append
            sb.Append("The quick brown fox ");
            sb.Append("jumped over a lazy dog.");

            // AppendLine can append a line ending
            sb.AppendLine();

            //AppendFormat can be used to append formatted string
            sb.AppendFormat("He did this {0} times.",jumpcount);
            sb.AppendLine();

            // AppendJoin can itterate over a set of values
            sb.Append("He also jumped over ");
            sb.AppendJoin(',',animals);

            //modify the content using Replace
            sb.Replace("fox","cat");

            //insert content at the index
            sb.Insert(0,"This is the ");

            //convert to a single string
            Console.WriteLine($"Capacity : {sb.Capacity}; Length : {sb.Length}");
            Console.WriteLine(sb.ToString());
        }
    }
}