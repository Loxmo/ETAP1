using System.Runtime.CompilerServices;

bool gameEnded = false;
char[] grille = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };


static void affichageGrille(char[] b)
{
    Console.Clear();
    Console.WriteLine($" {b[0]} | {b[1]} | {b[2]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {b[3]} | {b[4]} | {b[5]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {b[6]} | {b[7]} | {b[8]} ");
}

void calculDesCoordonees(out int ligne, out int colonne)
{
    Console.WriteLine("Quelle case jouer ? ");
    int cellule = int.Parse(Console.ReadLine()) - 1;
    colonne = cellule % 3;
    ligne = cellule / 3;

}


affichageGrille(grille);