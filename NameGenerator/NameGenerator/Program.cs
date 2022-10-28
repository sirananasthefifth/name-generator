using Microsoft.VisualBasic;

namespace NameGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays med bokstävstyper
            char[] vowels = {
                'A', 'E', 'I', 
                'O', 'U', 'Y'
            };
            char[] consonants = {
            'B', 'C', 'D', 'F', 'G', 
            'H', 'J', 'K', 'L', 'M',
            'N', 'P', 'Q', 'R', 'S',
            'T', 'V', 'W', 'X'
            };
            char[] commonConsonants = {
            'B', 'C', 'D', 'F', 'L', 
            'M', 'N', 'R', 'S', 'T'
            };
            char[] commonVowels = {
            'A', 'E', 'I', 'O', 'U',
            };
            int answer = 0;

            while (true)
            {
                Console.WriteLine("(1) Företagsnamn");
                Console.WriteLine("(2) För- och efternamn");
                
                try
                {
                    answer = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Felaktig input");
                }


                if (answer == 1)
                {
                    CompanyNameQuestions(vowels, consonants, commonConsonants, commonVowels);
                }
                else if (answer == 2)
                {
                    FirstAndLastNameQuestions(vowels, consonants, commonConsonants, commonVowels);
                }
                else
                {
                    Console.WriteLine("Felaktig input");
                }
            }
            

        }
        static void CompanyNameQuestions(char[] vowels, char[] consonants, char[] commonConsonants, char[] commonVowels)
        {
            bool loop = true;
            int nameLetters = 0;
            int numberOfNames = 0;

            while (loop)
            {

                //Fråga användaren om antalet bokstäver, antalet namn och vilket kön
                loop = true;
                while (loop)
                {
                    try
                    {
                        Console.WriteLine("Hur många bokstäver ska namnet ha?");
                        nameLetters = Convert.ToInt32(Console.ReadLine());
                        if (nameLetters > 0)
                        {
                            loop = false;
                        }
                        else
                        {
                            Console.WriteLine("Vänligen skriv in ett positiv tal.");
                            loop = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Vänlingen skriv in ett positiv tal");
                    }
                }

                

                loop = true;
                while (loop)
                {


                    try
                    {
                        Console.WriteLine("Hur många namn vill du generera?");
                        numberOfNames = Convert.ToInt32(Console.ReadLine());
                        if (numberOfNames > 0)
                        {
                            loop = false;
                        }
                        else
                        {
                            Console.WriteLine("Vänligen skriv in ett positiv tal.");
                            loop = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Vänlingen skriv in ett positiv tal.");
                    }
                }

                }

                GenerateCompanyName(numberOfNames, nameLetters, vowels, consonants, commonConsonants, commonVowels);
            }

        static void GenerateCompanyName(int numberOfNames, int nameLetters, char[] vowels, char[] consonants, char[] commonConsonants, char[] commonVowels)
        {
            //Generera namn
            //random variabler
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            Random rnd3 = new Random();
            Random rnd4 = new Random();
            Random rnd5 = new Random();
            Random rnd6 = new Random();
            Random rnd7 = new Random();
            Random rnd8 = new Random();
            Random rnd9 = new Random();
            Random rnd10 = new Random();
            //variabler för random systemet 
            int check;
            int cons;
            int vow;
            int commonVow;
            int commonCon;
            int res = 5;

            

            for (int i2 = 0; i2 < numberOfNames; i2++)
            {
                //Generera förnamn 

                //Samma bokstav från samma array ska inte användas igen 
                for (int i = 0; nameLetters > i; i++)
                {
                    check = rnd1.Next(4); //Slumpa mellan vokal, konsonant, vanlig vokal och vanlig konsonant
                    if (check == res)
                    {
                        if (check == 0)
                        {
                            check++;
                        }
                        else if (check <= 3)
                        {
                            check--;
                        }
                    }

                    //If-loopar för att sätta in bokstäver från våra olika arrays

                    if (check == 0) //Konsonanter
                    {
                        res = check;
                        cons = rnd2.Next(consonants.Length);
                        Console.Write(consonants[cons]);
                    }
                    if (check == 1) //Vokaler
                    {
                        res = check;
                        vow = rnd3.Next(vowels.Length);
                        Console.Write(vowels[vow]);
                    }
                    if (check == 2) //Vanliga konsonanter
                    {
                        res = check;
                        commonCon = rnd7.Next(commonConsonants.Length);
                        Console.Write(commonConsonants[commonCon]);
                    }
                    if (check == 3) //Vanliga vokaler
                    {
                        res = check;
                        commonVow = rnd8.Next(commonVowels.Length);
                        Console.Write(commonVowels[commonVow]);
                    }
                }
                

                Console.WriteLine();
            }
        }
        static void FirstAndLastNameQuestions(char[] vowels, char[] consonants, char[] commonConsonants, char[] commonVowels)
        {
            //variabler 
            bool woman = false;
            bool loop = true;
            int firstNameLetters = 0;
            int lastNameLetters = 0;
            int numberOfNames = 0;

            while (loop)
            {

                //Fråga användaren om antalet bokstäver, antalet namn och vilket kön
                loop = true;
                while (loop)
                {
                    try
                    {
                        Console.WriteLine("Hur många bokstäver ska förnamnet ha?");
                        firstNameLetters = Convert.ToInt32(Console.ReadLine());
                        if (firstNameLetters > 0)
                        {
                            loop = false;
                        }
                        else
                        {
                            Console.WriteLine("Vänligen skriv in ett positiv tal.");
                            loop = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Vänlingen skriv in ett positiv tal");
                    }
                }

                loop = true;
                while (loop)
                {


                    try
                    {
                        Console.WriteLine("Hur många bokstäver ska efternamnet ha?");
                        lastNameLetters = Convert.ToInt32(Console.ReadLine());
                        if (lastNameLetters > 0)
                        {
                            loop = false;
                        }
                        else
                        {
                            Console.WriteLine("Vänligen skriv in ett positiv tal.");
                            loop = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Vänlingen skriv in ett positiv tal.");
                    }
                }

                loop = true;
                while (loop)
                {


                    try
                    {
                        Console.WriteLine("Hur många namn vill du generera?");
                        numberOfNames = Convert.ToInt32(Console.ReadLine());
                        if (numberOfNames > 0)
                        {
                            loop = false;
                        }
                        else
                        {
                            Console.WriteLine("Vänligen skriv in ett positiv tal.");
                            loop = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Vänlingen skriv in ett positiv tal.");
                    }
                }



                //Kolla ifall kvinnonamn eller manliga ska genereras
                loop = true;

                while (loop)
                {
                    try
                    {
                        Console.WriteLine("Skriv 1 för kvinnliga namn och 2 för manliga namn:");
                        int gender = Convert.ToInt32(Console.ReadLine());
                        if (gender == 1)
                        {
                            woman = true;
                            loop = false;
                        }
                        else if (gender == 2)
                        {
                            woman = false;
                            loop = false;
                        }
                        else
                        {
                            Console.WriteLine("Vänligen skriv bara 1 eller 2.");
                            woman = false;
                            loop = true;
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Vänligen skriv bara 1 eller 2.");
                    }
                }

                //kallar på generator metoden//
                GenerateFirstAndLastName(woman, vowels, consonants, firstNameLetters, numberOfNames, lastNameLetters, commonConsonants, commonVowels);
            }
        }

        static void GenerateFirstAndLastName(bool woman, char[] vowels, char[] consonants, int firstNameLetters, int numberOfNames, int lastNameLetters, char[] commonConsonants, char[] commonVowels)
        {
            //Generera namn
            //random variabler
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            Random rnd3 = new Random();
            Random rnd4 = new Random();
            Random rnd5 = new Random();
            Random rnd6 = new Random();
            Random rnd7 = new Random();
            Random rnd8 = new Random();
            Random rnd9 = new Random();
            Random rnd10 = new Random();
            //variabler för random systemet 
            int check;
            int cons;
            int vow;
            int commonVow;
            int commonCon;
            int res = 5;

            //Ta bort sista bokstäven om kvinnonamn för att lägga till ett A
            if (woman)
            {
                firstNameLetters--;
            }

            for (int i2 = 0; i2 < numberOfNames; i2++)
            {
                //Generera förnamn 

                //Samma bokstav från samma array ska inte användas igen 
                for (int i = 0; firstNameLetters > i; i++)
                {
                    check = rnd1.Next(4); //Slumpa mellan vokal, konsonant, vanlig vokal och vanlig konsonant
                    if (check == res)
                    {
                        if (check == 0)
                        {
                            check++;
                        }
                        else if (check <= 3)
                        {
                            check--;
                        }
                    }

                    //If-loopar för att sätta in bokstäver från våra olika arrays

                    if (check == 0) //Konsonanter
                    {
                        res = check;
                        cons = rnd2.Next(consonants.Length);
                        Console.Write(consonants[cons]);
                    }
                    if (check == 1) //Vokaler
                    {
                        res = check;
                        vow = rnd3.Next(vowels.Length);
                        Console.Write(vowels[vow]);
                    }
                    if (check == 2) //Vanliga konsonanter
                    {
                        res = check;
                        commonCon = rnd7.Next(commonConsonants.Length);
                        Console.Write(commonConsonants[commonCon]);
                    }
                    if (check == 3) //Vanliga vokaler
                    {
                        res = check;
                        commonVow = rnd8.Next(commonVowels.Length);
                        Console.Write(commonVowels[commonVow]);
                    }
                }
                if (woman)
                {
                    Console.Write("A");
                }
                Console.Write(" ");

                //Generera efternamn
                for (int i3 = 0; i3 < lastNameLetters; i3++)
                {
                    check = rnd4.Next(4); //Slumpa mellan vokal, konsonant, vanlig vokal och vanlig konsonant

                    //If loop för att se till att vi inte får bokstäver från samma array två gåner i rad

                    if (check == res)
                    {
                        if (check == 0)
                        {
                            check++;
                        }
                        else if (check <= 3)
                        {
                            check--;
                        }
                    }

                    //If-loopar för att sätta in bokstäver från våra olika arrays
                    if (check == 0) //Konsonanter
                    {
                        res = check;
                        cons = rnd5.Next(consonants.Length);
                        Console.Write(consonants[cons]);
                    }
                    if (check == 1) //Vokaler
                    {
                        res = check;
                        vow = rnd6.Next(vowels.Length);
                        Console.Write(vowels[vow]);
                    }
                    if (check == 2) //Vanliga konsonanter
                    {
                        res = check;
                        commonCon = rnd9.Next(commonConsonants.Length);
                        Console.Write(commonConsonants[commonCon]);
                    }
                    if (check == 3) //Vanliga vokaler
                    {
                        res = check;
                        commonVow = rnd10.Next(commonVowels.Length);
                        Console.Write(commonVowels[commonVow]);
                    }

                }

                Console.WriteLine();
            }

        }
    }
}