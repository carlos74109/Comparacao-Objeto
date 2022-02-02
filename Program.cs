using ComparacaoObjeto.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparacaoObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\cSharpDelloite\arquivo1.txt";
            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<Funcionario> list = new List<Funcionario>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Funcionario(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach(Funcionario s in list)
                    {
                        Console.WriteLine(s);
                    }
                }
            }catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
