using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo___Aula_141
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manipula arquivo = new Manipula();
            //Aluno a = new Aluno(630222043, "Jao Silva", "1º ADS", "126.502.308-02");
            //arquivo.Gravar(a.RA + ";" + a.Nome + ";" + a.Turma + ";" + a.Cpf);

            List<Aluno> alunos = arquivo.Ler();
            string texto = null;
            foreach(Aluno fulano in alunos)
            {
                texto += "\nRa = " + fulano.RA + " - Nome = " + fulano.Nome + " - Curso = " + fulano.Turma + "" +
                    " - CPF = " + fulano.Cpf;
            }
            Aluno a = new Aluno(630222043, "Jao Silva", "1º ADS", "126.502.308-02");
            arquivo.Alterar(a);

            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}
