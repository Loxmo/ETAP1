Random rand = new Random();

int chosenNumber = rand.Next(1, 1000);
int trycount = 0;
int num;
const int maxTries = 10;
do
{
    Console.WriteLine("Devinez le nombre secret (entre 1 et 1000) : ");
    if(int.TryParse(Console.ReadLine(), out num ))
    {

        if (chosenNumber > num)
        {
           Console.WriteLine("Trop petit !");
        }
        if (chosenNumber < num)
        {
           Console.WriteLine("Trop grand !");
        }
        trycount += 1;
    }
    else
    {
        Console.WriteLine("Ce n'est pas un nombre !");
    }
}
while (num != chosenNumber && trycount < maxTries);
    if(num == chosenNumber)
        {
        Console.WriteLine("Vous avez trouver en " + trycount + " essais");
        }
    else
    {
        Console.WriteLine("Vous n'avez pas reussi a trouve en "+ maxTries +" essais \n le nombre etait" + chosenNumber);
    }
    