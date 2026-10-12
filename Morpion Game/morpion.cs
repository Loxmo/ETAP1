bool gameEnded = false;
char[,] grille = new char[3, 3];


static void affichageGrille(char[,] b)
{
    Console.WriteLine($" {b[0, 0]}  | {b[0, 1]}  | {b[0, 2]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {b[1, 0]}  | {b[1, 1]}  | {b[1, 2]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {b[2, 0]}  | {b[2, 1]}  | {b[2, 2]} ");
}

static void calculDesCoordonees(char[,] g)
{

    Console.WriteLine("Quelle case jouer ? ");
    if (int.TryParse(Console.ReadLine(), out int cellule) && cellule < 9 && cellule > 0) // on check si c'est un chiffre entre 1 et 9
    {
        cellule -= 1;
        int colonne = cellule % 3;
        int ligne = cellule / 3;
        if(g[ligne,colonne] == 'X' && g[ligne,colonne] == 'O')
        {
            
        }
        g[ligne, colonne] = 'X';
    }
    else
    {
        Console.WriteLine("Ce n'est pas un chiffre contenu entre 1 et 9");
    }

}

do
{
    affichageGrille(grille);
    calculDesCoordonees(grille);
}
while (!gameEnded);
