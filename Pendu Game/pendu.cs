string mot = "pomme";

const int maxlives = 6;
int lives = 0;

char typedLetter;

bool isFound = false;
do
{

    for(int l = 0 ; l < mot.Length; l += 1)
    {
        Console.Write("_ ");
    }





    //etape de verification
    if(char.TryParse(Console.ReadLine()!,out typedLetter))
    {
        bool hasLetter = mot.Contains(typedLetter);
        if(hasLetter == true)
        {
           Console.WriteLine("c'est une lettre du mot");
            for(int i = 0; mot.Length > i; i++)
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