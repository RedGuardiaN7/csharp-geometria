//BONUS: Aggiungere alla classe Rettangolo un metodo “disegna” che disegna in console il rettangolo con le sue dimensioni

//Viene creato l'oggetto prima di tutto

using Bonus;

Rectangle Rectangle_1 = new Rectangle();

Console.WriteLine("Indichi la base del rettangolo...");

//Sanificazione input dell'utente, in modo tale che vengano accettati solo numeri maggiori di 0

bool WidthSanification = false;
string StringUserWidth = "";
int UserWidth = 0;
do
{
    StringUserWidth = Console.ReadLine();
    if (int.TryParse(StringUserWidth, out UserWidth) & UserWidth > 0)           //Se l'input dell'utente è un numero (ed è maggiore di 0), verrà convertito correttamente
    {                                                                           //e il ciclo do while si interrompe
        WidthSanification = true;
    }
    else
    {
        Console.WriteLine("Per favore inserisca un numero valido");             //Altrimenti, se l'imput è invalido, il ciclo do while ricomnicia da capo, richiedendo l'imput
    }

} while (WidthSanification == false);

Rectangle_1.Width = UserWidth;

Console.WriteLine("Indichi l'altezza del rettangolo...");

//Sanificazione input dell'utente

bool HeightSanification = false;
string StringUserHeight = "";
int UserHeight = 0;
do
{
    StringUserHeight = Console.ReadLine();
    if (int.TryParse(StringUserHeight, out UserHeight) & UserHeight > 0)
    {
        HeightSanification = true;
    }
    else
    {
        Console.WriteLine("Per favore inserisca un numero valido");
    }

} while (HeightSanification == false);

Rectangle_1.Height = UserHeight;

Rectangle_1.area = Rectangle_1.CalculateArea();

Rectangle_1.perimeter = Rectangle_1.CalculatePerimeter();

Rectangle_1.Print(1);

Rectangle_1.Draw(1);