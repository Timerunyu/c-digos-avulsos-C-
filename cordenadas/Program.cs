using System;
					
public class Program
{
	public static void Main(){
		double p,x1,x2,y1,y2;
		double d;
		Console.WriteLine("escreva as cordenadas ponto 1 ");
		x1=int.Parse(Console.ReadLine());
		y1=int.Parse(Console.ReadLine());
		Console.WriteLine("digite as cordenadas do ponto 2");
		x2=int.Parse(Console.ReadLine());
		y2=int.Parse(Console.ReadLine());
		d=Math.Sqrt(Math.Pow(x2-x1,2 + Math.Pow(y2-y1,2)));
		Console.WriteLine("o resultado e " + d);
		
	}
}