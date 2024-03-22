using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01
{
    public class LivroBLL
    {
        public static void ValidaDados(Livro livro)
        {
            Erro.setErro(false);

            if (livro.GetTitulo().Length < 1 || livro.GetTitulo() == null ||
                livro.GetAutor().Length < 1 || livro.GetAutor() == null ||
                livro.GetEditora().Length < 1 || livro.GetEditora() == null ||
                livro.GetAno().Length < 1 || livro.GetAno() == null ||
                livro.GetLocal().Length < 1 || livro.GetLocal() == null)
            {
                Erro.setErro(true);
                Erro.setErro("Todos os campos devem ser preenchidos.");
                return;
            }

            try
            {
                int ano = int.Parse(livro.GetAno());
            } catch
            {
                Erro.setErro(true);
                Erro.setErro("O ano deve ser um número inteiro.");
                return;
            }

            if (int.Parse(livro.GetAno()) < 0)
            {
                Erro.setErro(true);
                Erro.setErro("O ano não pode ser um número negativo.");
                return;
            }
        }
    }
}
