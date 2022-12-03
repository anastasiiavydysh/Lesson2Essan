﻿//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.

//Потрібно: Створити клас Invoice. У тілі класу створити три поля int account, string customer, string provider,
//    які мають бути проініціалізовані один раз (при створенні екземпляра даного класу) без можливості 
//    їхньої подальшої зміни. У тілі класу створити два закриті поля string article, int quantity 
//    Створити метод розрахунку вартості замовлення з ПДВ та без ПДВ. 
//    Написати програму, яка виводить на екран суму оплати замовленого товару з ПДВ чи без ПДВ.

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(500,"customer","provider");
            Console.WriteLine("With PDV = "+invoice.WithPdv());
            Console.WriteLine("Without PDV = "+invoice.WithoutPdv());
        }
    }
}