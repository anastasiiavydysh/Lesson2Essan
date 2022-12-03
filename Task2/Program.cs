//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//    Потрібно: Створити клас Converter. У тілі класу створити користувальницький конструктор, 
//    який приймає три речові аргументи, і ініціалізує поля, що відповідають курсу 3-х основних валют, 
//    по відношенню до гривні – public Converter (double usd, double eur, double zl). 
//    Написати програму, яка виконуватиме конвертацію з гривні в одну із зазначених валют, 
//    також програма повинна проводити конвертацію із зазначених валют у гривню.

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter \"from\"/\"to\" grn -> ");
            string fromTo = Console.ReadLine();
            Console.Write("Enter sum currency (usd, eur, zl) -> ");
            string currency = Console.ReadLine();
            Console.Write("Enter sum -> ");
            double sum = Convert.ToDouble(Console.ReadLine());
            Converter converter = new Converter(38,40,8);

            switch (fromTo.ToLower())
            {
                case "from":
                    Console.WriteLine("Result = " + converter.FromGrn(sum, currency));
                break;
                case "to":
                    Console.WriteLine("Result = " + converter.ToGrn(sum, currency));
                break;
                default: Console.WriteLine("Cannot recognize currency");
                return;
            }
        }
    }
}