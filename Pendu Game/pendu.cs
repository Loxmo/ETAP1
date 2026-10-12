string mot = "pomme";
const int maxtries = 6;

char typedLetter;

bool isFound = false;
do
{
    if(char.TryParse(Console.ReadLine,out typedLetter))
    {
        
    }
    else
    {
        Console.WriteLine("ce n'est pas une lettre !");
    }
}
while(isFound != true);
Console.WriteLine("Win");