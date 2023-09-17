using EmployeeOOP.Classes;
try
{
    int day, month, year;
    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("----------------");
    Console.Write("Ingresar el dia: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicialización clase date
    Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());

    Employee SalaryEmployeeObject = new SalaryEmployee()
    {
        Id = 123456,
        FirstName = Console.ReadLine(),
        LastName = Console.ReadLine(),
        Birthday = dateObject,
        HiringDate= dateObject,
        IsActive= true,
        Salary=Decimal.Parse(Console.ReadLine()),
    };

    Console.WriteLine(SalaryEmployeeObject.ToString());

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}