//Ler a quantidade de alunos de uma turma, ler as notas de cada aluno, calcular e mostrar a média das notas conforme abaixo:


using System; 

public class Program {

  public static void Main(string[] args) {
    
    Console.WriteLine("Digite o numero de alunos: ");
    int numAlunos = int.Parse(Console.ReadLine());
    int totalNota = 0;
    int i = 0;
    while(i<numAlunos){
      int nota = int.Parse(Console.ReadLine());
      totalNota+= nota;
      i++;
    }
    Console.WriteLine($"A média dos alunos é {totalNota / numAlunos}");
  }
}