string mot = "pomme";

const int maxlives = 6;
int lives = 0;

char typedLetter;
char[] tableau = new char[mot.Length];

bool isFound = false;
//initalisation
for(int i = 0; i < mot.Length; i++)
    {
        tableau[i] = '_';
    }
do
{
    //affichage des lettres
    for(int i = 0; i < mot.Length; i++)
    {
        Console.Write(tableau[i] + " ");
    }
    //etape de verification
    if(char.TryParse(Console.ReadLine()!,out typedLetter))
    {
        bool hasLetter = mot.Contains(typedLetter);
        if(hasLetter == true)
        {
           Console.WriteLine("c'est une lettre du mot");
            for (int i = 0; i < mot.Length; i++)
            {
                if(mot[i] == typedLetter)
                {
                    tableau[i] = typedLetter;
                }
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