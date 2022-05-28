public enum Cargos
{
    Auxiliar, Ingeniero, Administrativo, Especialista, Investigador
}

public class Empleado
{

    public string Nombre;
    public string Apellido;
    public DateTime FecNac;

    public char EstadoCivil;
    public char genero;
    public DateTime FecIngreso;
    public Double SueldoBasico;
    public Cargos Cargo;

    public Empleado()
    {
        Console.WriteLine("Ingrese fecha de ingreso");

        FecIngreso = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Ingrese fecha de nacimioento");
        FecNac = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Ingrese nombre");
        Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese Apellido");
        Apellido = Console.ReadLine();
        Console.WriteLine("Ingrese Estado Civil S o C");
        EstadoCivil = char.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un numero del 1 al 5");
        Cargo = (Cargos)Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el salario kbron");
        SueldoBasico=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Carge el sexo F o M");
        genero=char.Parse(Console.ReadLine());


    }

    public double Antiguedad()
    {  
        return (DateTime.Now - FecIngreso).Days/365;
    }
    public double edad()
    {

        return (DateTime.Now - FecNac).Days/365;
    }
    public double Ajubliar()
    {
        if (genero == 'M')
        {
            return (65 - edad());
        }
        else
        {
            return (60 - edad());
        }
    }

    public double salario()
    {

        double adicional;
        if (Antiguedad() > 20)
        {
            adicional = SueldoBasico * 0.25;
        }
        else
        {
            adicional = SueldoBasico * (Antiguedad() / 100);
        }
        if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
        {
            adicional = adicional * 1.50;

        }
        if (EstadoCivil == 'C')
        {
            adicional = adicional + 15000;
        }
        return SueldoBasico + adicional;
    }

    public void Mostrar(){
        Console.WriteLine("NOMBRE: " + Nombre);
        Console.WriteLine("Apellido: " + Apellido);
        Console.WriteLine("FecIngreso: " + FecIngreso);
        Console.WriteLine("FecNac: " + FecNac);
        Console.WriteLine("EstadoCivil: " + EstadoCivil);
        Console.WriteLine("Genero: " + genero);
        Console.WriteLine("SueldoBasico: " + SueldoBasico);
        Console.WriteLine("Antiguedad: " + Math.Floor(Antiguedad()));
        Console.WriteLine("Edad: " + Math.Floor(edad())); 
        Console.WriteLine("Años p/Jubilacion: " + Math.Floor(Ajubliar()));
        Console.WriteLine("SueldoNeto: " + salario());


    }
}