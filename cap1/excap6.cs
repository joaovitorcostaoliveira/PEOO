//1. Ler a data de nascimento de uma pessoa (no formato “dd/mm/aaaa”) e mostrar quantos anos ela terá até o final do ano de 2022.


using System; 

public class Program {

  public static void Main(string[] args) {
    
    Console.WriteLine("Digite sua data de nascimento: ");
    string[] data = Console.ReadLine().Split('/');
    int anoNasc= int.Parse(data[2]);
    Console.WriteLine(anoNasc);
    Console.WriteLine($"voce tem {2022 - anoNasc}");
  }
}