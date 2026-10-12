string mot = "pomme";

const int maxlives = 6;
int lives = 0;

char typedLetter;
char[] tableau = new char[mot.Length];

bool isFound = false;

for(int i = 0; i < mot.Length; i++)
    {
        tableau[i] = '_';
    }
do
{
    






    //etape de verification
    if(char.TryParse(Console.ReadLine()!,out typedLetter))
    {
        bool hasLetter = mot.Contains(typedLetter);
        if(hasLetter == true)
        {
           Console.WriteLine("c'est une lettre du mot");
            for (int i = 0; i < mot.Length; i++)
            {
                
            }
        }

    }
    else
    {
        Console.WriteLine("ce n'est pas une lettre !");
    }
}
while(isFound != true && maxlives > lives);
Console.WriteLine("Win");