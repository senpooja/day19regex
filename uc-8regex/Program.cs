namespace day19assignment
{

    class Program
    {
        static void Main(String[] args)
        {
            Patterns patterns = new Patterns();
            //Console.WriteLine(patterns.validatePinCode("xyz@bridgelabz.com.in.in.in"));
            if (patterns.validateString("Akashs1@"))
            {
                Console.WriteLine("Valid");
            }
            else
                Console.WriteLine("Invalid");
            Console.ReadKey();
        }
    }
}