string mot = "pomme";

const int maxlives = 6;
int death = 0;

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
                if(mot[i] == typedLetter )
                {
                    tableau[i] = typedLetter;
                }
            }
            //on verifie si le mot est trouve
            if(Array.IndexOf(tableau, '_')== -1)
            {
                isFound = true;
            }
        }
        else
        {
            death++;
            Console.WriteLine("La lettre n'est pas dans le mot, plus que " + (maxlives-death) + "vies");
        }

    }
    else
    {
        Console.WriteLine("ce n'est pas une lettre !");
    }
}
while(isFound != true && maxlives > death);
if(isFound == true)
{
    Console.WriteLine("Win");
}
else
{
    Console.WriteLine("Perdu !!");
}
    