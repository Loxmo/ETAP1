string mot = "pomme";

const int maxlives = 6;
int lives = 0;

char typedLetter;

bool isFound = false;
do
{







    //etape de verification
    if(char.TryParse(Console.ReadLine()!,out typedLetter))
    {
        bool hasLetter = mot.Contains(typedLetter);
        if(hasLetter == true)
        {
           Console.WriteLine("c'est une lettre du mot");

        }

    }
    else
    {
        Console.WriteLine("ce n'est pas une lettre !");
    }
}
while(isFound != true && maxlives > lives);
Console.WriteLine("Win");