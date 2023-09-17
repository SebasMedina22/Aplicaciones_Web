// See https://aka.ms/new-console-template for more information
using EmployeeOOP.Classes;

Console.WriteLine("Hello, World!");
try
{
    int day, month, year;
    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("----------------");
    Console.WriteLine("Ingresar el dia: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingresar el dia: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicialización clase date
    Date dateObject = new Date(day, month, year);
    Console.WriteLine(dateObject.ToString());
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}