using System; 

public class Program {

  public static void Main(string[] args) {

    
    Console.WriteLine("digite o primeiro numero:");
    string nota1 = Console.ReadLine();
    double N1 = double.Parse(nota1);
    Console.WriteLine("digite o segundo numero:");
    string nota2 = Console.ReadLine();
    double N2 = double.Parse(nota2);
    
    if(N1 > N2){
      Console.WriteLine("Maior =" + N1);
    } else {
      Console.WriteLine("Maior =" + N2);
      
    }
  }
}