using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparacaoObjeto.Entidades
{
    internal class Funcionario : IComparable
    {
        public string nome;
        public double salario;

        public Funcionario(string csvFuncionario)
        {
            string [] vetor = csvFuncionario.Split(',');
            nome = vetor[0];
            salario = double.Parse(vetor[1]);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Funcionario))
            {
                throw new ArgumentException("Objeto passado não existe!!!");
            }
            Funcionario outro = obj as Funcionario;
            //Comparar nome
            //return nome.CompareTo(outro.nome);
            return outro.salario.CompareTo(salario);
        }

        public override string ToString()
        {
            return nome + ", " + salario.ToString("F2");
        }
    }
}
