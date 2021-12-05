static void WelcomeMessage()
{
    Console.WriteLine("Autorem zawartości tego pliku jest Ajax.\nWszelkie prawa zastrzeżone.\n");
}

static void ShowForUserMenu()
{
    Console.WriteLine("1. Dodawanie liczb");
    Console.WriteLine("2. Odejowanie liczb");
    Console.WriteLine("3. Mnożenie liczb");
    Console.WriteLine("4. Dzielenie liczb\n");

    Console.WriteLine("Wpisz poniżej liczbę, która oznacza wybrane przez Ciebie działanie.");
}

// Functions
static double ajax_Sum(double x, double y)
{
    double result;
    result = x + y;
    return result;
}

static double ajax_Difference(double x, double y)
{
    double result;
    result = x - y;
    return result;
}

static double ajax_Product(double x, double y)
{
    double result;
    result = x * y;
    return result;
}

static double ajax_Quotient(double x, double y)
{
    double result;
    result = x / y;
    return result;
}

WelcomeMessage();
ShowForUserMenu();

int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        {
            Console.WriteLine("> Wpisz jakąś liczbę: ");
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine("> Wpisz jakąś liczbę: ");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Wynik sumy liczby {0} i {1} wynosi: {2}", number, number2, ajax_Sum(number, number2));
            break;
        }
    case 2:
        {
            Console.WriteLine("> Wpisz jakąś liczbę: ");
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine("> Wpisz jakąś liczbę: ");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Wynik różnicy liczb {0} i {1} wynosi: {2}", number, number2, ajax_Difference(number, number2));
            break;
        }
    case 3:
        {
            Console.WriteLine("> Wpisz jakąś liczbę: ");
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine("> Wpisz jakąś liczbę: ");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Wynik mnożenia liczb {0} i {1} wynosi: {2}", number, number2, ajax_Product(number, number2));
            break;
        }
    case 4:
        {
            Console.WriteLine("> Wpisz jakąś liczbę: ");
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine("> Wpisz jakąś liczbę: ");
            double number2 = double.Parse(Console.ReadLine());

            if (number == 0 || number2 == 0)
            {
                Console.WriteLine("Nie można dzielić przez 0 !!!");
                break;
            }

            Console.WriteLine("Wynik dzielenia liczb {0} i {1} wynosi: {2}", number, number2, ajax_Quotient(number, number2));
            break;
        }
    default:
        {
            Console.WriteLine("Wprowadzono nieprawidłowy wybór. Musisz wprowadzić liczbę w przedziale 1-4.\nSpróbuj jeszcze raz.");
            break;
        }
}
