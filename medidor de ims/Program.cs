using System;
					
public class Program
{
	public static void Main(){
	double p,a,imc;
		Console.WriteLine("digite seu peso");
		p=double.Parse(Console.ReadLine());
		Console.WriteLine("digite sua altura");
		a=double.Parse(Console.ReadLine());
		imc=p/Math.Pow(a,2);
		if(imc<18){
		Console.WriteLine("Desnutrido");
		}
		if((imc>=18)&&(imc<=20)){
		Console.WriteLine("Baixo peso");	
		}
		if((imc>20)&&(imc<=24)){
		Console.WriteLine("normal");
		}
		if((imc>24)&&(imc<=27)){
		Console.WriteLine("sobre peso");
		}
		if(imc>27){
		Console.WriteLine("obeso");
		}
	}
}