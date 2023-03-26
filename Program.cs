int num1 = 0; //die erste Fibonacci Zahl
int num2 = 1; //die zweite Fibonacci Zahl
Console.WriteLine("Bitte Geben Sie ein wie viele Zahlen in der Fibonacci-Folge verwendet werden: ");//input vom user
int fib = int.Parse(Console.ReadLine());//String Input wird converted zu integer
Console.WriteLine("Fibonacci-Folge: ");//Gibt die Fibonacci-Folge aus
for (int i = 0; i < fib; i++)//for-Schleife berechnet Fibonacci bis zur angegebenen Zahl
{
    Console.WriteLine(num1 + " ");//Die Aktuelle Fibonacci-Zahl wird ausgegeben
    int fibo = num1;//fibo dient dazu temporär num1 zu speichern ohne num1 zu überschreiben
    num1 = num2;//num1 nimmt die Zahl von num2 und rechnet dann weiter mit der Zahl von num2
    num2 = fibo + num2;//num2 rechnet die letzte Fibonacci-Zahl aus und Die Summe wird zu num2
}