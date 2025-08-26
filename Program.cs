using curso_dio.Models;
using System.Globalization;


try
{

    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);

    }


}
catch (Exception ex)
{
    Console.WriteLine($"O correu uma exeção. {ex.Message}");
}









































//decimal valorMonetario = 82.40M;

///Console.WriteLine($"{valorMonetario:C}");




























//Pessoa p1 = new Pessoa(nome: "Jardel", sobrenome: "Maciel");
//Pessoa p2 = new Pessoa(nome :"Gael", sobrenome: "Maciel");

//Curso cursoDeIngles = new Curso();
//cursoDeIngles.Nome = "Ingles";
//cursoDeIngles.Alunos = new List<Pessoa>();

//cursoDeIngles.AdicionarAluno(p1);
//cursoDeIngles.AdicionarAluno(p2);
//cursoDeIngles.ListaDeAlunos();



























//Pessoa p1 = new Pessoa();
//p1.Nome = "jardel";
//p1.Sobrenome = "Maciel";
//p1.Idade = 29; //sinal de = equivale a set
//p1.Apresentar();