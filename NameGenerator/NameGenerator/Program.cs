namespace NameGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'Y', 'Å', 'Ä', 'Ö'};
            char[] consonants = { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X' };
            
            //variabler som vi har skapat 
            bool woman = false;
            

            //Fråga användaren om antalet bokstäver och namn
            Console.WriteLine("Hur många bokstäver ska namnet ha?");
            int numberOfLetters = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hur många namn vill du generera?");
            int numberOfNames = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv 1 för kvinnliga och 2 för manliga namn:");
            int gender = Convert.ToInt32(Console.ReadLine());

            if (gender == 1)
            {
                woman = true;
            }

            //Generera namn
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            Random rnd3 = new Random();
            //variabler för random systemet 
            int check;
            int cons;
            int vow;

            for (int i2 = 0; i2 < numberOfNames; i2++)
            {
                for (int i = 0; numberOfLetters > i; i++)
                {
                    check = rnd1.Next(2);

                    if (check == 0)
                    {
                        cons = rnd2.Next(18);
                        Console.Write(consonants[cons]);
                    }
                    if (check == 1)
                    {
                        vow = rnd3.Next(8);
                        Console.Write(vowels[vow]);
                    }
                }
                if (woman)
                {
                    Console.Write("A");
                }

                Console.WriteLine();
            }
            
        
        
        
        }
    }
}