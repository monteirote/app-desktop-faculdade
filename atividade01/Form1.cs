using System;
using System.Windows.Forms;

namespace atividade01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private Livro livroSalvo = null;

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            var livro = new Livro();
            livro.SetTitulo(textBox1.Text.Trim());
            livro.SetAutor(textBox2.Text.Trim());
            livro.SetEditora(textBox3.Text.Trim());
            livro.SetAno(textBox4.Text.Trim());
            livro.SetLocal(textBox5.Text.Trim());

            LivroBLL.ValidaDados(livro);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            } else
            {
                LimparCampos();
                livroSalvo = livro;
            }
        }

        private void botaoMostrar_Click(object sender, EventArgs e)
        {
            textBox1.Text = this.livroSalvo.GetTitulo();
            textBox2.Text = this.livroSalvo.GetAutor();
            textBox3.Text = this.livroSalvo.GetEditora();
            textBox4.Text = this.livroSalvo.GetAno();
            textBox5.Text = this.livroSalvo.GetLocal();
        }

        private void LimparCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        
    }
}
