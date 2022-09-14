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
            

            //Fråga användaren om antalet bokstäver, antalet namn och vilket kön
            Console.WriteLine("Hur många bokstäver ska förnamnet ha?");
            int firstNameLetters = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hur många bokstäver ska efternamnet ha?");
            int lastNameLetters = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hur många namn vill du generera?");
            int numberOfNames = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv 1 för kvinnliga namn och 2 för manliga namn:");
            int gender = Convert.ToInt32(Console.ReadLine());

            
            if (gender == 1)
            {
                woman = true;
            }

            //kallar på generator metoden//
            Generate(woman, vowels, consonants, firstNameLetters, numberOfNames, lastNameLetters);


        }

        static void Generate(bool woman, char[] vowels, char[] consonants, int firstNameLetters, int numberOfNames, int lastNameLetters)
        {
             //Generera namn
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            Random rnd3 = new Random();
            Random rnd4 = new Random();
            Random rnd5 = new Random();
            Random rnd6 = new Random();
            //variabler för random systemet 
            int check;
            int cons;
            int vow;

            if (woman)
            {
                firstNameLetters--;
            }

            for (int i2 = 0; i2 < numberOfNames; i2++)
            {
                //Generera förnamn
                for (int i = 0; firstNameLetters > i; i++)
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
                Console.Write(" ");

                //Generera efternamn
                

                
               //Generera förnamn
               for (int i3 = 0; i3 < lastNameLetters; i3++)
               {
                  check = rnd4.Next(2); // Randomise consonant or vowel

                  if (check == 0)
                  {
                     cons = rnd5.Next(consonants.Length);
                     Console.Write(consonants[cons]);
                  }
                  if (check == 1)
                  {
                     vow = rnd6.Next(vowels.Length);
                     Console.Write(vowels[vow]);
                  }
                    
               }

                    Console.WriteLine();
            }
        }
    }
}