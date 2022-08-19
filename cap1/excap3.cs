//Ler dois números inteiros, calcular a soma e mostrar o resultado conforme abaixo:


using System; 

public class Program {

  public static void Main(string[] args) {
    
    Console.WriteLine("digite dois numeros inteiros: ");
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    Console.WriteLine($"{n1} / {n2} {n1 / n2}");
    Console.WriteLine($"{n1} % {n2} {n1 % n2}");
  }
}