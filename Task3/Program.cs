//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//    Потрібно створити клас Employee. У тілі класу створити користувальницький конструктор, 
//    який приймає два рядкові аргументи, та ініціалізує поля, що відповідають прізвищу та імені співробітника. 
//    Створити метод, що розраховує оклад співробітника (залежно від посади та стажу) та податковий збір. 
//    Написати програму, 
//    яка виводить на екран інформацію про співробітника (прізвище, ім'я, посада), оклад та податковий збір. 

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Petro", "Pjatochkyn");
            employee1.DisplayName();
            employee1.CalculateSalary("Junior", 2);
            employee1.CalculateTaxes("Junior", 2);

            Employee employee2 = new Employee("Oleksandr", "Gajczenko");
            employee2.DisplayName();
            employee2.CalculateSalary("Senior", 12);
            employee2.CalculateTaxes("Senior", 12);

        }
    }
}