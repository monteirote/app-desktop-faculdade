using atividade01;
using System;
using Xunit;

namespace atividade01_testes
{
    public class UnitTest1
    {
        [Fact]
        public void Test_TodosCamposPreenchidos()
        {
            var livro = new Livro();
            livro.SetTitulo("");
            livro.SetAutor("teste");
            livro.SetEditora("");
            livro.SetAno("");
            livro.SetLocal("teste");

            LivroBLL.ValidaDados(livro);

            Assert.True(Erro.getErro());
            Assert.Equal("Todos os campos devem ser preenchidos.", Erro.getMens());

            var livro2 = new Livro();
            livro2.SetTitulo("teste");
            livro2.SetAutor("teste");
            livro2.SetEditora("teste");
            livro2.SetAno("1");
            livro2.SetLocal("teste");
                 
            LivroBLL.ValidaDados(livro2);

            Assert.False(Erro.getErro());
        }

        [Fact]
        public void Teste_AnoNumeroInteiro()
        {
            var livro = new Livro();
            livro.SetTitulo("teste");
            livro.SetAutor("teste");
            livro.SetEditora("teste");
            livro.SetAno("12.5");
            livro.SetLocal("teste");

            LivroBLL.ValidaDados(livro);

            Assert.True(Erro.getErro());
            Assert.Equal("O ano deve ser um número inteiro.", Erro.getMens());

            var livro2 = new Livro();
            livro2.SetTitulo("teste");
            livro2.SetAutor("teste");
            livro2.SetEditora("teste");
            livro2.SetAno("12");
            livro2.SetLocal("teste");

            LivroBLL.ValidaDados(livro2);

            Assert.False(Erro.getErro());
        }

        [Fact]
        public void Teste_AnoNumeroPositivo()
        {
            var livro = new Livro();
            livro.SetTitulo("teste");
            livro.SetAutor("teste");
            livro.SetEditora("teste");
            livro.SetAno("-2024");
            livro.SetLocal("teste");

            LivroBLL.ValidaDados(livro);

            Assert.True(Erro.getErro());
            Assert.Equal("O ano não pode ser um número negativo.", Erro.getMens());

            var livro2 = new Livro();
            livro2.SetTitulo("teste");
            livro2.SetAutor("teste");
            livro2.SetEditora("teste");
            livro2.SetAno("2024");
            livro2.SetLocal("teste");

            LivroBLL.ValidaDados(livro2);

            Assert.False(Erro.getErro());
        }
    }
}
