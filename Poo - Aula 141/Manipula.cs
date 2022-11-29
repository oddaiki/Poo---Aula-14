using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Poo___Aula_141
{
    public class Manipula
    {
        private string caminho = "C:\\Users\\curso.ads2\\Documents\\Dados.txt";

        public void Gravar(string texto)
        {
            StreamWriter sw = new StreamWriter(caminho);
            sw.WriteLine(texto);
            sw.Close();
        }
        public List<Aluno> Ler()
        {
            var list = new List<Aluno>();
            if(File.Exists(caminho))
            {
                StreamReader sr = File.OpenText(caminho);
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    var arquivo = linha.Split(';');
                    Aluno alguem = new Aluno(int.Parse(arquivo[0]), arquivo[1], arquivo[2], arquivo[3]);
                    list.Add(alguem);
                }
                sr.Close();
            }
            return list;
        }
        public void Alterar(Aluno a)
        {
            string texto = null;
            if (File.Exists(caminho))
            {
                using(StreamReader sr = new StreamReader(caminho))
                {
                    String linha;
                    while((linha = sr.ReadLine()) != null)
                    {
                        var arquivo = linha.Split(';');
                        if (int.Parse(arquivo[0]) != a.RA)
                        {
                            string nova = a.RA + ";" + a.Nome + ";" + a.Turma + ";" + a.Cpf + "\n";
                            texto += nova;
                        }
                        else
                        {
                            texto += linha + "\n";
                        }
                    }
                    sr.Close();
                    File.Delete(caminho);
                    StreamWriter sw = new StreamWriter(caminho);
                    sw.WriteLine(texto);
                    sw.Close();
                }
            }
        }
    }
}
