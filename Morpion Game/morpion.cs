bool gameEnded = false;
char[] grille = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
int horizontal;
int vertical;

static void affichageGrille(char[] b)
{
    Console.Clear();
    Console.WriteLine($" {b[0]} | {b[1]} | {b[2]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {b[3]} | {b[4]} | {b[5]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {b[6]} | {b[7]} | {b[8]} ");
}

void calculDesCoordonees(int cellule)
{
    Console.WriteLine("Quelle case jouer ? ");
    cellule = int.Parse(Console.ReadLine());
   
}


affichageGrille(grille);