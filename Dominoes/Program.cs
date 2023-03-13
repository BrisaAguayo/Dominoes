class Dominoes
{
    //Declaramos nuestros parámetros
    int arriba;
    int abajo;

    //asignamos a nuestra clase los parametros, dónse se pondrán
    public Dominoes(int arriba, int abajo)
    {
        this.arriba = arriba;
        this.abajo = abajo;
    }

    public static int operator + (Dominoes a, Dominoes b)
    {
        int suma = a.arriba + b.arriba + a.abajo + b.abajo;
        return suma;
    }
}
internal class Program 
{
    private static void Main(string[] args)
    {
       Dominoes d1 = new Dominoes(0,1);
       Dominoes d2 = new Dominoes(2,3);
       int suma  = d1 + d2;
       Console.WriteLine(suma);

    }

}
