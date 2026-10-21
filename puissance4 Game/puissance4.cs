const int Hauteur = 6;
const int Largeur = 7;
const char caseVide = '_';

char symbole = 'X';
char[,] grille = new char[Hauteur, Largeur];

bool gameEnded = false;
bool playerXisplaying = true;




static void affichageGrille(char[,] g)
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


static void nouvellePartie(char[,] g)
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

static int lireColonne(char symbole)
{
    while (true)
    {
        Console.Write("Quelle colonne jouer " + symbole + " ? : ");
        if (int.TryParse(Console.ReadLine(), out int colonne) && colonne <= Largeur && colonne >= 1)
        {
            return colonne - 1;
        }
        else
        {
            Console.WriteLine("Entree Invalide");

        }
    }

}



static bool placerPion(char[,] g, char symbole, int colonne)
{

    //colonne pleine
    if (g[0, colonne] != caseVide)
    {
        Console.WriteLine("La colonne est pleine");
        return false;
    }
    //faire descenre pion
    int ligne = 0;
    while (ligne < Hauteur-1 && g[ligne + 1, colonne] == caseVide)
    {
        ligne++;
    }
    //poser le pion
    g[ligne, colonne] = symbole;
    return true;
}





//boucle principale.
nouvellePartie(grille);
do
{
    int colonne;
    affichageGrille(grille);
    if (playerXisplaying)
    {
        symbole = 'X';
    }
    else
    {
        symbole = 'O';
    }
    colonne = lireColonne(symbole);
    bool aJouer = placerPion(grille, symbole, colonne);
    if (aJouer)
    {
        playerXisplaying = !playerXisplaying;
    }





}
while (!gameEnded);