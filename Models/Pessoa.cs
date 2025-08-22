using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso_dio.Models
{
    public class Pessoa
    {
        private int _idade;
        private string _nome; //Campo
        public string Nome //toda propriedade contem GET e SET ou uma das duas
        {
            get => _nome.ToUpper();
            

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio!");
                }
                _nome = value;
            }

        }
        
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A Idade não pode ser menor que zero");
                }
                _idade = value;
            }

        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome {NomeCompleto}, Idade {Idade}");
        }
    }
}