// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int fin = 0;
int i = 0;
string cadena="";
Console.WriteLine("Ingresa el primer numero");
double B=double.Parse(Console.ReadLine());

calculadora calc= new calculadora(B);
cadena=string.Concat(cadena,B);
Console.WriteLine(cadena);

while (fin != 1)
{

    Console.WriteLine("Ingresa el numero a operar");
    double A = double.Parse(Console.ReadLine());
    Console.WriteLine("1.SUMA 2.RESTA 3.PRODUCTO 4.DIVISION 5.LIMPIAR");
    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
              cadena=string.Concat(cadena," + ");    
              cadena=string.Concat(cadena,A);
              calc.sumar(A);    
              Console.WriteLine(cadena);
            break;
        case 2:
         cadena=string.Concat(cadena," - ");    
              cadena=string.Concat(cadena,A);
              calc.resta(A);
              Console.WriteLine(cadena);
            break;
        case 3:

        cadena=string.Concat(cadena," * ");
        cadena=string.Concat(cadena,A);
              calc.producto(A);
              Console.WriteLine(cadena);
            break;
        case 4:
        cadena=string.Concat(cadena," / ");
        cadena=string.Concat(cadena,A);
              calc.division(A);
              Console.WriteLine(cadena);
            break;
        case 5:
        calc.limpiar();
        cadena="";
            break;
        default: fin=1;
        break;
    }

    Console.WriteLine(calc.resultado);
}
