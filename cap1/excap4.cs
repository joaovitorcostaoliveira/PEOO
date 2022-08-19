//Ler dois números inteiros, calcular o quociente e o resto, mostrar o resultado conforme abaixo:


using System; 

public class Program {

  public static void Main(string[] args) {
    
    Console.WriteLine("digite dois numeros inteiros: ");
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    int n3 = int.Parse(Console.ReadLine());
    int maior = 0;
    if (n1 > n2 && n2 > n3){
      maior = n1+n2;
    }
    if (n1 > n2 && n3 > n2){
      maior = n1+n3;
    }
    if(n2 > n1 && n3 > n1){
      maior = n2+n3;
    }

    Console.WriteLine($"Soma dos dois maiores = {maior}");
  }
}