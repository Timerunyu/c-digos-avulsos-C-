using System;

class Program{
    public static void Main(){
        int contador = 0;
        int soma = 0;
        int menorValor = int.MaxValue;
        int maiorValor = int.MinValue;

        while (true){
            Console.Write("Informe um valor (número negativo para parar): ");
            int valor = int.Parse(Console.ReadLine());

            if (valor < 0)
            {
                break;
            }

            contador++;
            soma += valor;

            if (valor < menorValor)
            {
                menorValor = valor;
            }

            if (valor > maiorValor)
            {
                maiorValor = valor;
            }
        }

        if (contador > 0)
        {
            double media = (double)soma / contador;

            Console.WriteLine("n1 Contador de valores válidos: {contador}");
            Console.WriteLine("2 Soma dos valores: " + soma);
            Console.WriteLine("3 Média dos valores: "+ media);
            Console.WriteLine("4 Menor valor informado: " + menorValor);
            Console.WriteLine("5 Maior valor informado: "+ maiorValor);
        }
        else
        {
            Console.WriteLine("Nenhum valor válido foi informado.");
        }
    }
}