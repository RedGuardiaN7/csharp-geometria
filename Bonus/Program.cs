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

//Prova con diversi rettangoli
//Rettangolo 2

Rectangle Rectangle_2 = new Rectangle();

Rectangle_2.Width = 8;

Rectangle_2.Height = 5;

Rectangle_2.perimeter = Rectangle_2.CalculatePerimeter();
Rectangle_2.area= Rectangle_2.CalculateArea();
Rectangle_2.Print(2);

//Rettangolo 3

Rectangle Rectangle_3 = new Rectangle();

Rectangle_3.Width = 18;

Rectangle_3.Height = 4;

Rectangle_3.perimeter = Rectangle_3.CalculatePerimeter();
Rectangle_3.area = Rectangle_3.CalculateArea();
Rectangle_3.Print(2);