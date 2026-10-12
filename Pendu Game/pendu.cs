

const int maxlives = 6;
int death = 0;
// on creer une liste et on choisit un mot dedans
List<string> mots = new List<string> { "pomme", "poire", "abricot", "fraise", "carotte", "patate", "radis", "courgette", "haricot", "lentilles" };
string mot = mots[Random.Shared.Next(mots.Count)];

char typedLetter;
//on cree un tableau de charactere a partir de la taille du mot choisi
char[] tableau = new char[mot.Length];

bool isFound = false;

//initalisation pour afficher les cases vide en fonction de la longueur du mot
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
        bool hasLetter = mot.ToLower().Contains(char.ToLower(typedLetter)); // on verifie si la lettre est dans le mot tout en evitant le probleme de casse
        if(hasLetter == true)
        {
           Console.WriteLine("c'est une lettre du mot");
            for (int i = 0; i < mot.Length; i++)
            {
                if(mot[i] == typedLetter && tableau[i] == '_')  //on check si la lettre fait parti du mot et n'a pas deja ete trouve 
                {
                    tableau[i] = typedLetter;
                }
                else if (mot[i] == typedLetter && tableau[i] != '_')
                {
                    Console.WriteLine("la lettre a deja ete trouvee");
                }
            }
            //on verifie si le mot est trouve en regardant si il reste des tirets dans le tableau
            if(Array.IndexOf(tableau, '_')== -1)
            {
                isFound = true;
            }
        }
        else
        {
            death++;
            Console.WriteLine("La lettre n'est pas dans le mot, plus que " + (maxlives-death) + " vies"); // on retire une vie et on dit que le mot n'est pqs trouve
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
    