using curso_dio.Models;

Pessoa p1 = new Pessoa(nome: "Jardel", sobrenome: "Maciel");
Pessoa p2 = new Pessoa(nome :"Gael", sobrenome: "Maciel");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListaDeAlunos();



























//Pessoa p1 = new Pessoa();
//p1.Nome = "jardel";
//p1.Sobrenome = "Maciel";
//p1.Idade = 29; //sinal de = equivale a set
//p1.Apresentar();