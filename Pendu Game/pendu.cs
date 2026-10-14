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


void affichageMot()
    {
          for (int i = 0; i < mot.Length; i++)
            {
                Console.Write(motcache[i] + " ");
            }
    }


//initalisation pour afficher les cases vide en fonction de la longueur du mot
for (int i = 0; i < mot.Length; i++)
{
    motcache[i] = '_';
}
do
{
    string listeDeLettres = string.Join(", ", lettresUtilises);//on transforme la liste de mot en un seul string
    Console.WriteLine("\nLettres deja utilises : "+ listeDeLettres);
    Console.WriteLine("il te reste " + (maxlives - death) + " vies");

    //affichage des lettres
    affichageMot();
          
    Console.Write("\n >>: ");
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

                    if (mot[i] == typedLetter) 
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
                    Console.WriteLine("La lettre n'est pas dans le mot"); // on retire une vie et on dit que le mot n'est pqs trouve
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
   affichageMot();

    Console.WriteLine("\nWin");
}
else
{
    Console.WriteLine("Perdu !! le mot etait : "+ mot );
}
