const int maxlives = 6;
int death = 0;
// on creer une liste et on choisit un mot dedans
List<string> mots = new List<string> { "pomme", "poire", "abricot", "fraise", "carotte", "patate", "radis", "courgette", "haricot", "lentilles" };
string mot = mots[Random.Shared.Next(mots.Count)];
List<char> lettresUtilises = new List<char>();

char typedLetter;
//on cree un tableau de charactere a partir de la taille du mot choisi
char[] motcache = new char[mot.Length];


bool isFound = false;

//initalisation pour afficher les cases vide en fonction de la longueur du mot
for (int i = 0; i < mot.Length; i++)
{
    motcache[i] = '_';
}
do
{

    //affichage des lettres
    for (int i = 0; i < mot.Length; i++)
    {
        Console.Write(motcache[i] + " ");
    }
    //etape de verification
    if (char.TryParse(Console.ReadLine()!, out typedLetter) && char.IsLetter(typedLetter))
    {
        typedLetter = char.ToLower(typedLetter);
        if (!lettresUtilises.Contains(typedLetter))
        {
            lettresUtilises.Add(typedLetter);
            bool hasLetter = mot.ToLower().Contains(typedLetter); // on verifie si la lettre est dans le mot tout en evitant le probleme de casse
            if (hasLetter == true)
            {

                Console.WriteLine("c'est une lettre du mot");
                for (int i = 0; i < mot.Length; i++)
                {

                    if (mot[i] == typedLetter)  //on check si la lettre fait parti du mot et n'a pas deja ete trouve 
                    {
                        motcache[i] = typedLetter;
                    }

                }
                //on verifie si le mot est trouve en regardant si il reste des tirets dans le tableau
                if (Array.IndexOf(motcache, '_') == -1)
                {
                    isFound = true;
                }
                
            }
            else
                {
                    death++;
                    Console.WriteLine("La lettre n'est pas dans le mot, plus que " + (maxlives - death) + " vies"); // on retire une vie et on dit que le mot n'est pqs trouve
                }

        }
        else
            {
                Console.WriteLine("Lettre deja utilise");
            }

    }
    else
    {
        Console.WriteLine("ce n'est pas une lettre !");
    }
}
while (!isFound && maxlives > death);
if (isFound == true)
{
    Console.WriteLine("Win");
}
else
{
    Console.WriteLine("Perdu !!");
}
