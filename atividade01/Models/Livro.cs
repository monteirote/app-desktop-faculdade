using System;

namespace atividade01
{
    public class Livro
    {
        private string titulo;
        private string autor;
        private string editora;
        private string ano_edicao;
        private string local;

        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public void SetAutor(string autor)
        {
            this.autor = autor;
        }
        public void SetEditora(string editora)
        {
            this.editora = editora;
        }
        public void SetAno(string ano)
        {
            this.ano_edicao = ano;
        }
        public void SetLocal(string local)
        {
            this.local = local;
        }

        public String GetTitulo() { return this.titulo; }
        public String GetAutor() { return this.autor; }
        public String GetEditora() { return this.editora; }
        public string GetAno() { return this.ano_edicao; }
        public String GetLocal() { return this.local; }
    }
}
