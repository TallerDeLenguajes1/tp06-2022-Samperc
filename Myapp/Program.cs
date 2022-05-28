// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Empleado[] empleados = new Empleado[3];


for (int i = 0; i < 3; i++)
{
    empleados[i] = new Empleado();
}
double Monto=0;
foreach (var item in empleados)
{
    Monto=Monto + item.salario();
}
Console.WriteLine(Monto);
double jmenor=100;
int m=0;
for (int i = 0; i < 3; i++)
{
    if (jmenor > empleados[i].Ajubliar())
    {
        jmenor=empleados[i].Ajubliar();
        m=i;
       
    }
    
}
 empleados[m].Mostrar();
