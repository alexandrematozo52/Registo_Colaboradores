using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registo_Colaboradores
{
    public partial class Novo_Registo : Form
    {
        public Novo_Registo()
        {
            InitializeComponent();

            //-----------------------------------------------------------------
            textBoxNome.Click += TextBoxNome_Click;
            textBoxNome.Leave += TextBoxNome_Leave;
            textBoxNome.Enter += TextBoxNome_Enter;
            labelNome.Click += LabelNome_Click;
            pictureBoxNome.Click += PictureBoxNome_Click;
            textBoxNome.TextChanged += TextBoxNome_TextChanged;

            //-----------------------------------------------------------------
            textBoxApelido.TextChanged += TextBoxApelido_TextChanged;
            textBoxApelido.Click += TextBoxApelido_Click;
            textBoxApelido.Leave += TextBoxApelido_Leave;
            textBoxApelido.Enter += TextBoxApelido_Enter;
            labelApelido.Click += LabelApelido_Click;
            pictureBoxApelido.Click += PictureBoxApelido_Click;
        }

        #region-------------------------------TEXTBOX NOME DO CLIENTE-----------------------------------

        private void TextBoxNome_TextChanged(object sender, EventArgs e)
        {
            // Verifica se o TextBox não está vazio
            if (!string.IsNullOrEmpty(textBoxNome.Text))
            {
                string nome = textBoxNome.Text;

                // Capitaliza a primeira letra de cada palavra
                nome = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());

                // Define o texto modificado de volta ao TextBox
                textBoxNome.Text = nome;

                // Define o cursor para o final do texto
                textBoxNome.SelectionStart = textBoxNome.Text.Length;
            }

            if (textBoxNome.Text == "")
            {
                labelNome.Visible = false;
            }
        }

        private void TextBoxNome_Click(object sender, EventArgs e)
        {

            if (textBoxNome.Text == "")
            {
                labelNome.Visible = false;
                //labelNomeMensagem.Visible = false;
            }
        }

        private void LabelNome_Click(object sender, EventArgs e)
        {
            labelNome.Visible = false;
            textBoxNome.Select();
        }

        private void LabelNomeMensagem_Click(object sender, EventArgs e)
        {
            labelNome.Visible = false;
            textBoxNome.Select();
        }

        private void TextBoxNome_Leave(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "")
            {
                labelNome.Visible = true;
                //BtPreenchimentoAutomatico.Visible = false;
            }
        }

        private void TextBoxNome_Enter(object sender, EventArgs e)
        {
            labelNome.Visible = false;
        }

        private void PictureBoxNome_Click(object sender, EventArgs e)
        {

            textBoxNome.Select();
        }
        #endregion

        #region ----------------------------------- TEXTBOX APELIDO -------------------------------------

        private void TextBoxApelido_TextChanged(object sender, EventArgs e)
        {
            // Verifica se o TextBox não está vazio
            if (!string.IsNullOrEmpty(textBoxApelido.Text))
            {
                string nome = textBoxApelido.Text;

                // Capitaliza a primeira letra de cada palavra
                nome = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());

                // Define o texto modificado de volta ao TextBox
                textBoxApelido.Text = nome;

                // Define o cursor para o final do texto
                textBoxApelido.SelectionStart = textBoxApelido.Text.Length;
            }

            if (textBoxApelido.Text == "")
            {
                labelApelido.Visible = false;
            }
        }

        private void TextBoxApelido_Click(object sender, EventArgs e)
        {
            if (textBoxApelido.Text == "")
            {
                labelApelido.Visible = false;

            }
        }

        private void LabelApelido_Click(object sender, EventArgs e)
        {
            labelApelido.Visible = false;
            textBoxApelido.Select();
        }

        private void LabelApelidoMensagem_Click(object sender, EventArgs e)
        {
            labelApelido.Visible = false;
            textBoxApelido.Select();
        }

        private void TextBoxApelido_Leave(object sender, EventArgs e)
        {
            if (textBoxApelido.Text == "")
            {
                labelApelido.Visible = true;
            }
        }

        private void TextBoxApelido_Enter(object sender, EventArgs e)
        {
            labelApelido.Visible = false;
        }

        private void PictureBoxApelido_Click(object sender, EventArgs e)
        {
            textBoxApelido.Select();
        }

        #endregion


    }
}
