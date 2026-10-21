const int Hauteur = 6;
const int Largeur = 7;
const char caseVide = '_';
char[,] grille = new char[Hauteur, Largeur];
bool gameEnded = false;

void affichageGrille(char[,] g)
{
    for (int j = 1; j <= Largeur; j++)
    {
        Console.Write($" {j} ");
    }
    Console.Write("\n");
    for (int i = 0; i < Hauteur; i++)
    {
        for (int j = 0; j < Largeur; j++)
        {
            Console.Write($"|{g[i, j]}|");
        }
        Console.Write("\n");
    }
}


void nouvellePartie(char[,] g)
{
    //permet de clear la grille.
    for (int i = 0; i < Hauteur; i++)
    {
        for (int j = 0; j < Largeur; j++)
        {
            g[i, j] = caseVide;
        }
    }
}





//boucle principale.
nouvellePartie(grille);
do
{

    affichageGrille(grille);
    gameEnded = true;
}
while (!gameEnded);