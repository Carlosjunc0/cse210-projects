using System;

class Program
{
    static void Main(string[] args)
    {
        // part 1 and 2
        //Console.Write("What is the magic number? ");
        //int magicNumberUser = int.Parse(Console.ReadLine());

        //while (guessNumberUser != magicNumberUser)
        //{
        //Console.Write("What is your guess? ");
        //int guessNumberUser = int.Parse(Console.ReadLine());
        //if (guessNumberUser > magicNumberUser)
        //{
        //    Console.WriteLine("Higher");
        //}
        //else if (guessNumberUser < magicNumberUser)
        //{
        //    Console.WriteLine("Lower");
        //}
        //else
        //{
        //    Console.WriteLine("You guessed it!");
        //}
        //}

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
        }
    }   
}