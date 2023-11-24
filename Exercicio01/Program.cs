//Operadores aritimeticos
namespace Exercicio01;

class Program
{
    private static void Main()
    {
        //Soma
        Console.WriteLine("Insira um valor: ");
        int soma1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insira outro valor: ");
        int soma2 = Convert.ToInt32(Console.ReadLine());
        //int valorTotalSoma = Convert.ToInt32(valor1 + valor2);
        Console.WriteLine("Os valores "+ soma1 +" + " + soma2 + " = " + Convert.ToInt32(soma1 + soma2));
             
            
        //Subtração
        Console.WriteLine("Insira um valor: ");
        int sub1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insira outro valor: ");
        int sub2 = Convert.ToInt32(Console.ReadLine());
        int valorTotalSub = sub1 - sub2;
        Console.WriteLine("Os valores "+ sub1 +" - " + sub2 + " = " + valorTotalSub);

        //Multiplicação
        Console.WriteLine("Insira um valor: ");
        int mult1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insira outro valor: ");
        int mult2 = Convert.ToInt32(Console.ReadLine());
        int valorTotalMult = mult1 * mult2;
        // int valorTotal = Convert.ToInt32(valor1 * valor2);  
        Console.WriteLine("Os valores " + mult1 + " * " + mult2 + " = " + valorTotalMult);
             
            
        //Divisão
        Console.WriteLine("Insira um valor: ");
        int valor1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insira outro valor: ");
        int valor2 = Convert.ToInt32(Console.ReadLine());
        int valorTotal = valor1 / valor2;
        Console.WriteLine("Os valores " + valor1 + " / " + valor2 + " = " + valorTotal); 

    }
}