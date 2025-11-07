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

            this.Click += new EventHandler(Novo_Registro_Click);

            panel_NovoRegisto.Click += panel_NovoRegisto_Click;

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

            //-----------------------------------------------------------------
            txtCargo.TextChanged += TextBoxCargo_TextChanged;
            txtCargo.Click += TextBoxCargo_Click;
            txtCargo.Leave += TextBoxCargo_Leave;
            txtCargo.Enter += TextBoxCargo_Enter;
            labelCargo.Click += LabelCargo_Click;
            pictureBoxCargo.Click += PictureBoxCargo_Click;

            //-----------------------------------------------------------------
            txtTelefone.TextChanged += TextBoxTelefone_TextChanged;
            txtTelefone.Click += TextBoxTelefone_Click;
            txtTelefone.Leave += TextBoxTelefone_Leave;
            txtTelefone.Enter += TextBoxTelefone_Enter;
            labelTelefone.Click += LabelTelefone_Click;
            pictureBoxTelefone.Click += PictureBoxTelefone_Click;

            label25.Select();
        }

        private void Novo_Registro_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == string.Empty)
            {
                labelNome.Visible = true;
                label25.Select();
            }

            if (textBoxApelido.Text == string.Empty)
            {
                labelApelido.Visible = true;
                label25.Select();
            }

            if (txtCargo.Text == string.Empty)
            {
                labelCargo.Visible = true;
                label25.Select();
            }

            if (txtTelefone.Text == string.Empty)
            {
                labelTelefone.Visible = true;
                label25.Select();
            }
        }

        private void panel_NovoRegisto_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == string.Empty)
            {
                labelNome.Visible = true;
                label25.Select();
            }

            if (textBoxApelido.Text == string.Empty)
            {
                labelApelido.Visible = true;
                label25.Select();
            }

            if (txtCargo.Text == string.Empty)
            {
                labelCargo.Visible = true;
                label25.Select();
            }

            if (txtTelefone.Text == string.Empty)
            {
                labelTelefone.Visible = true;
                label25.Select();
            }
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

        #region ----------------------------------- TEXTBOX CARGO -------------------------------------

        private void TextBoxCargo_TextChanged(object sender, EventArgs e)
        {
            // Verifica se o TextBox não está vazio
            if (!string.IsNullOrEmpty(textBoxApelido.Text))
            {
                string nome = txtCargo.Text;

                // Capitaliza a primeira letra de cada palavra
                nome = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());

                // Define o texto modificado de volta ao TextBox
                txtCargo.Text = nome;

                // Define o cursor para o final do texto
                txtCargo.SelectionStart = txtCargo.Text.Length;
            }

            if (txtCargo.Text == "")
            {
                labelCargo.Visible = false;
            }
        }

        private void TextBoxCargo_Click(object sender, EventArgs e)
        {
            if (txtCargo.Text == "")
            {
                labelCargo.Visible = false;

            }
        }

        private void LabelCargo_Click(object sender, EventArgs e)
        {
            labelCargo.Visible = false;
            txtCargo.Select();
        }

        private void TextBoxCargo_Leave(object sender, EventArgs e)
        {
            if (txtCargo.Text == "")
            {
                labelCargo.Visible = true;
            }
        }

        private void TextBoxCargo_Enter(object sender, EventArgs e)
        {
            labelCargo.Visible = false;
        }

        private void PictureBoxCargo_Click(object sender, EventArgs e)
        {
            txtCargo.Select();
        }


        #endregion

        #region ----------------------------------- TEXTBOX TELEFONE -------------------------------------

        private void TextBoxTelefone_TextChanged(object sender, EventArgs e)
        {

            if (txtTelefone.Text == "")
            {
                labelTelefone.Visible = false;
            }
        }

        private void TextBoxTelefone_Click(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "")
            {
                labelTelefone.Visible = false;

            }
        }

        private void LabelTelefone_Click(object sender, EventArgs e)
        {
            labelTelefone.Visible = false;
            txtTelefone.Select();
        }

        private void TextBoxTelefone_Leave(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "")
            {
                labelTelefone.Visible = true;
            }
        }

        private void TextBoxTelefone_Enter(object sender, EventArgs e)
        {
            labelTelefone.Visible = false;
        }

        private void PictureBoxTelefone_Click(object sender, EventArgs e)
        {
            txtTelefone.Select();
        }


        #endregion

    }
}
