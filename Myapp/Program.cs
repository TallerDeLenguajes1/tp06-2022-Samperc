// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Empleado[] empleados = new Empleado[3];


for (int i = 0; i < 3; i++)
{
    empleados[i] = new Empleado();
    empleados[i].FecIngreso = Convert.ToDateTime(Console.ReadLine()); 
    empleados[i].FecNac = Convert.ToDateTime(Console.ReadLine());
    empleados[i].Nombre = Console.ReadLine();
    empleados[i].Apellido = Console.ReadLine();
    empleados[i].EstadoCivil = char.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese un numero del 1 al 5");
    empleados[i].Cargo=(Cargos)Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(empleados[i].Cargo);
    Console.WriteLine(empleados[i].FecIngreso);
}
