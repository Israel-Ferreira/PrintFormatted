namespace PrintFormatted
{
    internal class Program
    {


        static void FormatAndPrintAllNumbersInRange(int num)
        {
            for(int itNumber=  1; itNumber <= num; itNumber++)
            {
                string hexNumber = itNumber.ToString("X");
                string octalNumber = Convert.ToString(itNumber, 8);

                Console.WriteLine($"{itNumber}  {octalNumber}  {hexNumber}");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("\nInforme um número: ");
            int numero = int.Parse(Console.ReadLine()!);


            FormatAndPrintAllNumbersInRange(numero);
        }
    }
}