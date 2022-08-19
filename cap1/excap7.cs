//2. Ler a data de nascimento de uma pessoa (no formato “dd/mm/aaaa”) e mostrar a faixa etária de acordo com as faixas: 0 a 19 anos – Jovem, 20 a 59 anos – Adulto e 60 ou mais anos – Idoso. Considere o final de 2022 para cálculo da idade.


using System; 

public class Program {

  public static void Main(string[] args) {
    
    Console.WriteLine("Digite sua data de nascimento: ");
    string[] data = Console.ReadLine().Split('/');
    int anoNasc= int.Parse(data[2]);
    int idade = 2022 - anoNasc;
    if(idade > 0 && idade < 19){
      Console.WriteLine("voce é jovem");
    if(idade => 20 && idade <= 59){
      Console.WriteLine("voce é adulto");
    if(idade => 60){
      Console.WriteLine("voce é idoso");
    }
  }
}