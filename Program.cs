namespace Assignment2._1._3
{
    class Mathmathics
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2, decimal num3)
        {
            return num1 + num2 + num3;
        }
        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }
        public static float Multiply(float num1, float num2, float num3)
        {
            return num1 * num2 * num3;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathmathics maths = new Mathmathics();

            Console.WriteLine("Select an operaation: " +
                "\n\t1) Add two integers" +
                "\n\t2) Add three decimals" +
                "\n\t3) Multiply two floats" +
                "\n\t4) Multiply three floats");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter two whole numbers: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{num1} + {num2} = {Mathmathics.Add(num1, num2)}");
                    break;
                case 2:
                    Console.WriteLine("Enter three whole numbers: ");
                    int dec1 = Convert.ToInt32(Console.ReadLine());
                    int dec2 = Convert.ToInt32(Console.ReadLine());
                    int dec3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{dec1} + {dec2} + {dec3} = {Mathmathics.Add(dec1, dec2, dec3)}");
                    break;
                case 3:
                    Console.WriteLine("Enter two whole numbers: ");
                    int float1 = Convert.ToInt32(Console.ReadLine());
                    int float2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{float1} + {float2} = {Mathmathics.Multiply(float1, float2)}");
                    break;
                case 4:
                    Console.WriteLine("Enter three whole numbers: ");
                    int float3 = Convert.ToInt32(Console.ReadLine());
                    int float4 = Convert.ToInt32(Console.ReadLine());
                    int float5 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{float3} + {float4} + {float5} = {Mathmathics.Multiply(float3, float4, float5)}");
                    break;
            }

        }
    }
}
