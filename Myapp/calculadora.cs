public class calculadora{

   public double resultado;
   
    public calculadora(double B){
        resultado=B;
    }
    public void sumar(double valor1){
       resultado+=valor1;
    }
    public void resta(double valor1){
       resultado-=valor1;
    }
    public void producto(double valor1){
       resultado*=valor1;
    }
     public void division(double valor1){
       resultado/=valor1;
    }
    
    public void limpiar(){
       resultado=0;
    }
}