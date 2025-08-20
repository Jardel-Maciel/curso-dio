using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso_dio.Models
{
    public class Pessoa
    {
        private string _nome; //Campo
        public string Nome //toda propriedade contem GET e SET ou uma das duas
        {
            get
            {
                return _nome.ToUpper();
            }

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio!");
                }
                _nome = value;
            }

        }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Nome {Nome}, Idade {Idade}");
        }
    }
}