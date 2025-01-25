string secretWord = "secret";
string guess = "";
int guessCount = 0; // increment ++ 
int maxAttempt = 5;
bool playAgain = true;

while (playAgain)
{
      Console.WriteLine("WELCOME TO OUR GAME OF GUESSING THE SECRET WORD");
      guess = "";
      guessCount = 0;

      while (guess != secretWord && guessCount < maxAttempt)
      {
            Console.Write(" ENTER GUESS: ");
            guess = Console.ReadLine();

            if (guess != secretWord)
            {
                  guessCount++;
                  if (guessCount < maxAttempt)
                  {
                        Console.WriteLine($"Try again, you have {maxAttempt - guessCount} attempts left.");
                  }
            }
      }

      if (guess == secretWord)

      {
            Console.WriteLine("YOU WIN");
            Console.WriteLine($"YOU WERE AMAZING, CONGRATS you did it in  {guessCount} times! ");

      }
      else
      {
            Console.WriteLine($"Bro you try more times that the allowed. you tried  {guessCount} times");
            Console.WriteLine($" The secret word was '{secretWord}'.");

      }

      Console.WriteLine($"Would you like to play again?  Y for YES or N for NOT ");
      string response = Console.ReadLine().ToUpper();

      if (response == "N" || response == "NOT" )
      {
            playAgain = false;
            Console.WriteLine("Thank for playing with us, see you next time");
      }
      else if (response == "Y" || response == "YES" )
      {
            playAgain = true;
            Console.Clear();
      }
      else
      {
            Console.WriteLine("Sorry bro, we didnt understand what you want to do");
            playAgain = false;
      }

}



