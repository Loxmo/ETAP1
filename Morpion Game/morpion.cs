using System.Security.Cryptography.X509Certificates;

bool gameEnded = false;
int horizontal;
int vertical;

static void affichageGrille()
{
    for (int i = 0; i < 3; i++)
    {
        for (int l = 0; l < 3; l++)
        {
            Console.Write("# ");
        }
        Console.Write("\n");
    }
}

static void calculDesCoordonees(int cellule)
{
    Console.WriteLine("Quelle case jouer ?");
    cellule = int.Parse(Console.ReadLine());
    if(cellule < 3)
    {
        horizontal = 1;
        return;
    }
    else if(cellule > 6)
    {
        horizontal = 3;
        return;
    }
    else
    {
        horizontal = 2;
        return;
    }
}


do
{
    
}
while (!gameEnded);
Console.WriteLine("fin de la partie");