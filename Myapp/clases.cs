public enum Cargos
{
    Auxiliar , Ingeniero, Administrativo, Especialista, Investigador
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

    public void Empleado(){
        FecIngreso = Convert.ToDateTime(Console.ReadLine()); 
    }
    public int Antiguedad()
    {
        return Convert.ToInt32(DateTime.Now - FecIngreso);
    }
    public int edad()
    {

        return Convert.ToInt32(DateTime.Now - FecNac);
    }
    public int Ajubliar()
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

    public double salario(double S)
    {

        double adicional;
        if (Antiguedad() > 20)
        {
            adicional = S * 0.25;
        }
        else
        {
            adicional = S * (Antiguedad() / 100);
        }
        if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
        {
            adicional = adicional * 1.50;

        }
        if (EstadoCivil == 'C')
        {
            adicional = adicional + 15000;
        }
        return S + adicional;
    }
}