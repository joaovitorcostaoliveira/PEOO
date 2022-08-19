//1. Ler o primeiro nome de uma pessoa e mostrar a mensagem: “Olá, <xxx>, tudo bem?”, onde <xxx> é o nome informado pela pessoa.


using System; 

public class Program {

  public static void Main(string[] args) {
    
    Console.WriteLine("digite seu primeiro nome: ");
    string A = Console.ReadLine();
    Console.WriteLine($"Olá, {A}, tudo bem?");
  }
}