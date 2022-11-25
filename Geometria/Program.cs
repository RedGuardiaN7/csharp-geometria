//Consegna: chiedere all’utente di inserire, da console, i valori di base e di altezza con cui istanziare un nuovo Rettangolo
//Dopo averlo istanziato, occupatevi di configurare le sue proprietà di base e altezza e stampare a video il perimetro e l’area

//Viene creato l'oggetto prima di tutto

using System.Drawing;

Rectangle Rectangle_1 = new Rectangle();

Console.WriteLine("Indichi la base del rettangolo...");

string StringUserWidth = Console.ReadLine();

int UserWidth = int.Parse(StringUserWidth);

Rectangle_1.Width = UserWidth;

Console.WriteLine("Indichi l'altezza del rettangolo...");

string StringUserHeight = Console.ReadLine();

int UserHeight = int.Parse(StringUserHeight);

Rectangle_1.Height = UserHeight;

Console.WriteLine(UserHeight + " " + UserWidth);