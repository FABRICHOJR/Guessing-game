Random random = new Random();
string guessN = "";
int randomNumber = random.Next(1, 100);
int guessNumber = 0;
bool adivinaste = false;

Console.WriteLine("GUESSING GAME BY FABRIZIO RADICCI");


while (!adivinaste)
{
    Console.WriteLine("Enter your guess number: ");
    guessN = Console.ReadLine()!;

    if (int.TryParse(guessN, out guessNumber))
    {
        if (guessNumber == randomNumber)
        {
            adivinaste = true;
            Console.WriteLine("Bravisimo!!! GANASTE!");
        }
        else if (guessNumber < randomNumber)
        {
            Console.WriteLine(" es un numero mas alto");

        }
        else
        {
            Console.WriteLine("es un numero mas bajo ");
        }
    }
else
        {
            Console.WriteLine("Invalid number, try again");

        }
    }












