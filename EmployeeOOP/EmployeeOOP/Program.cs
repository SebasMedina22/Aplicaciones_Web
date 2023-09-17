using EmployeeOOP.Classes;
try
{
    int day, month, year, hours;
    string firstname, lastname, tipoempleado;
    decimal salary, hoursvalue;
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

    Console.Write("Ingresar nombre completo: ");
    firstname = Console.ReadLine();

    Console.Write("Ingresar apellidos: ");
    lastname = Console.ReadLine();



    Console.Write("Ingrese el tipo de empleado: ");
    tipoempleado = Console.ReadLine();
    if (tipoempleado == "asalariado")
    {
        Console.WriteLine("Ingresar salario devengado: ");
        salary = Decimal.Parse(Console.ReadLine());
        Employee SalaryEmployeeObject = new SalaryEmployee()
        {
        Id = 123456,
        FirstName = firstname,
        LastName = lastname,
        Birthday = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Salary = salary,
        };
        Console.WriteLine(SalaryEmployeeObject.ToString());
    }
    else if (tipoempleado == "por horas")
    {
        Console.Write("Ingrese horas trabajadas: ");
        hours=Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese valor por hora: ");
        hoursvalue=Decimal.Parse(Console.ReadLine());

        Employee HourlyEmployee = new HourlyEmployee()
        {
            Id = 123456,
            FirstName = firstname,
            LastName = lastname,
            Birthday = dateObject,
            HiringDate = dateObject,
            IsActive = true,
            Hours = hours,
            HourValue = hoursvalue,
            HourlyEmployeeSalary = hours * hoursvalue,
        };
        Console.WriteLine(HourlyEmployee.ToString());
    }



}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}