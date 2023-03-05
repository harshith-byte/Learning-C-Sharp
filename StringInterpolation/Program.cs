namespace StringInterpolation
{
    class Program{
        static void Main(string[] args){
            string make="Mercedes-Benz";
            string model="G Class";
            int year=2020;
            float miles=8_450.27f;
            decimal price=60_275.0m;

            //output info using string format
            Console.WriteLine("the car is {0} {1} {2}, with {3} and costs {4}"
            ,year,make,model,miles,price);

            // using interpolation
            Console.WriteLine($"the car is {year} {make} {model}, with {miles} and costs {price}");
        }
    }
}