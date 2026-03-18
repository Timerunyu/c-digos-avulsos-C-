using System; // faz varias somas doidas 16/08/2023
class Program {
  public static void Main (string[] args) {
   int x,y,res,u,d,c,iver;
    char ai = 'f';
    float meth = 3;
    double elev,some,doble = 7.7;
    string test = "hello peaple";
    Console.WriteLine(test);
    Console.WriteLine ("digite um numero");
    x=int.Parse(Console.ReadLine());
    Console.WriteLine(" digite outro numero");
    y=int.Parse(Console.ReadLine());
    res= x+y;
    Console.WriteLine("{0}",res);
    c=res/100;
    d=(res%100)/10;
    u=res % 10;
    iver=u*100+d*10+c;
    some = meth*doble;
    elev=Math.Pow(meth,8); 
    Console.WriteLine("o inverso e  "+ iver);
    Console.WriteLine("outros resultado " + ai + " "+some );
    Console.WriteLine(" o valor elevado e "+ elev);
  }
}