namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Array of numbers
            int[] numerot = { 3, 4, 5 };

            // Call the methods
            Summa(numerot);
            Erotus(numerot);
            Osamaara(numerot);
            Tulo(numerot);
        }

        // Method to calculate the sum
        public static void Summa(int[] lista)
        {
            int summa = lista.Sum();
            Console.WriteLine("Summa:    " + summa);
        }

        // Method to calculate the difference
        public static void Erotus(int[] lista)
        {
            int erotus = lista[0];
            foreach (int luku in lista.Skip(1))
            {
                erotus -= luku;
            }
            Console.WriteLine("Erotus: " + erotus);
        }

        // Method to calculate the quotient
        public static void Osamaara(int[] lista)
        {
            double osamäärä = lista[0]; // Initialize with the first element
            foreach (int luku in lista.Skip(1))
            {
                osamäärä /= luku; // Divide by the next element
            }
            Console.WriteLine("Osamäärä: " + osamäärä);
        }

        // Method to calculate the product
        public static void Tulo(int[] lista)
        {
            int tulo = lista[0]; // Initialize with the first element
            foreach (int luku in lista.Skip(1))
            {
                tulo *= luku; // Multiply by the next element
            }
            Console.WriteLine("Tulo: " + tulo);
        }
    }
}
