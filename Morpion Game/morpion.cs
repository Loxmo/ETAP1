using System.Reflection.Metadata;
bool gameDrawed = false;
bool wantToPlay = true;
bool gameEnded = false;
bool player1isplaying = true;
const int taille = 3;
int compteurTour = 0;
char[,] grille = new char[taille, taille];//on creer une grille a deux dimension
char symbole;



static void affichageGrille(char[,] b)
{
    Console.WriteLine($" {b[0, 0]}  | {b[0, 1]}  | {b[0, 2]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {b[1, 0]}  | {b[1, 1]}  | {b[1, 2]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {b[2, 0]}  | {b[2, 1]}  | {b[2, 2]} ");
}

static bool jouerCoup(char[,] g, char symbole)
{

    Console.WriteLine("Quelle case jouer ? ");
    if (int.TryParse(Console.ReadLine(), out int cellule) && cellule <= (taille*taille) && cellule > 0) // on check si c'est un chiffre entre 1 et 9
    {
        cellule -= 1;
        int colonne = cellule % taille;
        int ligne = cellule / taille;

        if (g[ligne, colonne] == '\0')
        {
            g[ligne, colonne] = symbole;
            return true;
        }
        else
        {
            Console.WriteLine("Case deja remplie");
            return false;
        }
    }
    else
    {
        Console.WriteLine("Ce n'est pas un chiffre contenu entre 1 et 9");
        return false;
    }

}

static bool aGagne(char[,] g, char symbole)
{
    for (int i = 0; i < taille; i++)
    {
        bool ligneComplete = true;
        for (int j = 0; j < taille; j++)
        {
            if (g[i, j] != symbole)
            {
                ligneComplete = false;
            }
        }
        if (ligneComplete)
        {
            return true;
        }
        bool colonneComplete = true;
        for (int l = 0; l < taille; l++)
        {
            if (g[l, i] != symbole)
            {
                colonneComplete = false;
            }
        }
        if (colonneComplete)
        {
            return true;
        }
        bool diago1Complete = true;
        bool diago2Complete = true;
        for (int j = 0; j < taille; j++)
        {
            if (g[j, j] != symbole)
            {
                diago1Complete = false;
            }
            if (g[j, taille - 1 - j] != symbole)
            {
                diago2Complete = false;
            }

        }
        if (diago1Complete || diago2Complete)
        {
            return true;
        }

    }


    return false;
}


void nouvellePartie()
{
    compteurTour = 0;
    for (int i = 0; i < taille; i++)
    {
        for (int j = 0; j < taille; j++)
        {
            grille[i, j] = '\0';
        }
    }
    player1isplaying = true;
    gameDrawed = false;
}



do
{
    nouvellePartie();
    do
    {
        affichageGrille(grille);

        if (player1isplaying)
        {
            symbole = 'X';
        }
        else
        {
            symbole = 'O';
        }
        bool coupjoue = jouerCoup(grille, symbole);
        if (coupjoue)
        {
            player1isplaying = !player1isplaying;
            compteurTour++;
        }
        gameEnded = aGagne(grille, symbole);

        if (compteurTour == 9 && !gameEnded)
        {
            Console.WriteLine("Match nul !!!");
            gameEnded = true;
            gameDrawed = true;
        }
    }
    while (!gameEnded);
    affichageGrille(grille);
    if (!gameDrawed)
    {
        Console.WriteLine("\nLa Partie est finie !! " + symbole + " a gagne !!!");
    }

    Console.WriteLine("Voulez vous rejouer ?  O/N");
    if (char.TryParse(Console.ReadLine(), out char reponse) && char.ToUpper(reponse) == 'N')
    {
        wantToPlay = false;
    }

}
while (wantToPlay);
