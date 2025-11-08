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

            // Associa o evento de clique do formulário principal (this) ao método Novo_Registro_Click
            this.Click += new EventHandler(Novo_Registro_Click);

            // Associa o clique no painel principal "panel_NovoRegisto" ao método que trata o clique
            panel_NovoRegisto.Click += panel_NovoRegisto_Click;

            #region Eventos dos TextBoxs 
            //-----------------------------------------------------------------
            // EVENTOS DO TEXTBOX "NOME"
            textBoxNome.Click += TextBoxNome_Click;           // Quando o usuário clica no campo
            textBoxNome.Leave += TextBoxNome_Leave;           // Quando o campo perde o foco
            textBoxNome.Enter += TextBoxNome_Enter;           // Quando o campo ganha o foco
            labelNome.Click += LabelNome_Click;               // Quando o usuário clica no label (para focar o campo)
            pictureBoxNome.Click += PictureBoxNome_Click;     // Quando o usuário clica no ícone ao lado do campo
            textBoxNome.TextChanged += TextBoxNome_TextChanged; // Quando o texto do campo é alterado

            //-----------------------------------------------------------------
            // EVENTOS DO TEXTBOX "APELIDO"
            textBoxApelido.TextChanged += TextBoxApelido_TextChanged; // Quando o texto é alterado
            textBoxApelido.Click += TextBoxApelido_Click;             // Clique no campo
            textBoxApelido.Leave += TextBoxApelido_Leave;             // Perde o foco
            textBoxApelido.Enter += TextBoxApelido_Enter;             // Ganha o foco
            labelApelido.Click += LabelApelido_Click;                 // Clique no label
            pictureBoxApelido.Click += PictureBoxApelido_Click;       // Clique no ícone

            //-----------------------------------------------------------------
            // EVENTOS DO TEXTBOX "CARGO"
            txtCargo.TextChanged += TextBoxCargo_TextChanged; // Quando o texto muda
            txtCargo.Click += TextBoxCargo_Click;             // Clique no campo
            txtCargo.Leave += TextBoxCargo_Leave;             // Quando perde o foco
            txtCargo.Enter += TextBoxCargo_Enter;             // Quando ganha o foco
            labelCargo.Click += LabelCargo_Click;             // Clique no label
            pictureBoxCargo.Click += PictureBoxCargo_Click;   // Clique no ícone

            //-----------------------------------------------------------------
            // EVENTOS DO TEXTBOX "TELEFONE"
            txtTelefone.TextChanged += TextBoxTelefone_TextChanged; // Texto alterado
            txtTelefone.Click += TextBoxTelefone_Click;             // Clique no campo
            txtTelefone.Leave += TextBoxTelefone_Leave;             // Perde foco
            txtTelefone.Enter += TextBoxTelefone_Enter;             // Ganha foco
            labelTelefone.Click += LabelTelefone_Click;             // Clique no label
            pictureBoxTelefone.Click += PictureBoxTelefone_Click;   // Clique no ícone

            //-----------------------------------------------------------------
            // EVENTOS DO TEXTBOX "EMAIL"
            txtEmail.TextChanged += TextBoxEmail_TextChanged;   // Texto alterado
            txtEmail.Click += TextBoxEmail_Click;               // Clique no campo
            txtEmail.Leave += TextBoxEmail_Leave;               // Perde foco
            txtEmail.Enter += TextBoxEmail_Enter;               // Ganha foco
            labelEmail.Click += LabelEmail_Click;               // Clique no label
            pictureBoxEmail.Click += PictureBoxEmail_Click;     // Clique no ícone

            //-----------------------------------------------------------------
            // EVENTOS DO TEXTBOX "MORADA" (Endereço)
            txtMorada.TextChanged += TextBoxMorada_TextChanged; // Texto alterado
            txtMorada.Click += TextBoxMorada_Click;             // Clique no campo
            txtMorada.Leave += TextBoxMorada_Leave;             // Perde foco
            txtMorada.Enter += TextBoxMorada_Enter;             // Ganha foco
            labelMorada.Click += LabelMorada_Click;             // Clique no label
            pictureBoxMorada.Click += PictureBoxMorada_Click;   // Clique no ícone

            //-----------------------------------------------------------------
            // EVENTOS DO TEXTBOX "CIDADE"
            txtCidade.TextChanged += TextBoxCidade_TextChanged; // Texto alterado
            txtCidade.Click += TextBoxCidade_Click;             // Clique no campo
            txtCidade.Leave += TextBoxCidade_Leave;             // Perde foco
            txtCidade.Enter += TextBoxCidade_Enter;             // Ganha foco
            labelCidade.Click += LabelCidade_Click;             // Clique no label
            pictureBoxCidade.Click += PictureBoxCidade_Click;   // Clique no ícone

            //-----------------------------------------------------------------
            // EVENTOS DO TEXTBOX "DISTRITO"
            txtDistrito.TextChanged += TextBoxDistrito_TextChanged; // Texto alterado
            txtDistrito.Click += TextBoxDistrito_Click;             // Clique no campo
            txtDistrito.Leave += TextBoxDistrito_Leave;             // Perde foco
            txtDistrito.Enter += TextBoxDistrito_Enter;             // Ganha foco
            labelDistrito.Click += LabelDistrito_Click;             // Clique no label
            pictureBoxDistrito.Click += PictureBoxDistrito_Click;   // Clique no ícone

            //-----------------------------------------------------------------
            // EVENTOS DO TEXTBOX "CÓDIGO POSTAL" (CP)
            txtCP.TextChanged += TextBoxCP_TextChanged;         // Texto alterado
            txtCP.Click += TextBoxCP_Click;                     // Clique no campo
            txtCP.Leave += TextBoxCP_Leave;                     // Perde foco
            txtCP.Enter += TextBoxCP_Enter;                     // Ganha foco
            labelCP.Click += LabelCP_Click;                     // Clique no label
            pictureBoxCP.Click += PictureBoxCP_Click;           // Clique no ícone

            //-----------------------------------------------------------------
            // EVENTOS DO TEXTBOX "PAÍS"
            txtPais.TextChanged += TextBoxPais_TextChanged;     // Texto alterado
            txtPais.Click += TextBoxPais_Click;                 // Clique no campo
            txtPais.Leave += TextBoxPais_Leave;                 // Perde foco
            txtPais.Enter += TextBoxPais_Enter;                 // Ganha foco
            labelPais.Click += LabelPais_Click;                 // Clique no label
            pictureBoxPais.Click += PictureBoxPais_Click;       // Clique no ícone
            #endregion
            //-----------------------------------------------------------------
            // Define o foco inicial para o label25 (provavelmente o primeiro campo visual do formulário)
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

            if (txtEmail.Text == string.Empty)
            {
                labelEmail.Visible = true;
                label25.Select();
            }

            if (txtMorada.Text == string.Empty)
            {
                labelMorada.Visible = true;
                label25.Select();
            }

            if (txtCidade.Text == string.Empty)
            {
                labelCidade.Visible = true;
                label25.Select();
            }

            if (txtDistrito.Text == string.Empty)
            {
                labelDistrito.Visible = true;
                label25.Select();
            }

            if (txtCP.Text == string.Empty)
            {
                labelCP.Visible = true;
                label25.Select();
            }

            if (txtPais.Text == string.Empty)
            {
                labelPais.Visible = true;
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

            if (txtEmail.Text == string.Empty)
            {
                labelEmail.Visible = true;
                label25.Select();
            }

            if (txtMorada.Text == string.Empty)
            {
                labelMorada.Visible = true;
                label25.Select();
            }

            if (txtCidade.Text == string.Empty)
            {
                labelCidade.Visible = true;
                label25.Select();
            }

            if (txtDistrito.Text == string.Empty)
            {
                labelDistrito.Visible = true;
                label25.Select();
            }

            if (txtCP.Text == string.Empty)
            {
                labelCP.Visible = true;
                label25.Select();
            }

            if (txtPais.Text == string.Empty)
            {
                labelPais.Visible = true;
                label25.Select();
            }
        }

        #region-------------------------------TEXTBOX NOME DO CLIENTE-----------------------------------

        // Evento disparado sempre que o texto do TextBox é alterado
        private void TextBoxNome_TextChanged(object sender, EventArgs e)
        {
            // Verifica se o campo não está vazio
            if (!string.IsNullOrEmpty(textBoxNome.Text))
            {
                string nome = textBoxNome.Text;

                // Converte todo o texto para minúsculo e capitaliza a primeira letra de cada palavra
                nome = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());

                // Atualiza o conteúdo do TextBox com o texto formatado
                textBoxNome.Text = nome;

                // Posiciona o cursor no final do texto
                textBoxNome.SelectionStart = textBoxNome.Text.Length;
            }

            // Caso o TextBox esteja vazio, esconde o label
            if (textBoxNome.Text == "")
            {
                labelNome.Visible = false;
            }
        }

        // Evento disparado ao clicar dentro do TextBox
        private void TextBoxNome_Click(object sender, EventArgs e)
        {
            // Esconde o label se o TextBox estiver vazio
            if (textBoxNome.Text == "")
            {
                labelNome.Visible = false;
            }
        }

        // Evento disparado ao clicar no label sobre o campo
        private void LabelNome_Click(object sender, EventArgs e)
        {
            // Esconde o label e move o foco para o TextBox
            labelNome.Visible = false;
            textBoxNome.Select();
        }

        // Evento disparado ao clicar no label de mensagem (caso exista)
        private void LabelNomeMensagem_Click(object sender, EventArgs e)
        {
            // Esconde o label e move o foco para o TextBox
            labelNome.Visible = false;
            textBoxNome.Select();
        }

        // Evento disparado quando o TextBox perde o foco
        private void TextBoxNome_Leave(object sender, EventArgs e)
        {
            // Se o campo estiver vazio, o label volta a aparecer
            if (textBoxNome.Text == "")
            {
                labelNome.Visible = true;
            }
        }

        // Evento disparado quando o TextBox ganha o foco
        private void TextBoxNome_Enter(object sender, EventArgs e)
        {
            // Esconde o label ao entrar no campo
            labelNome.Visible = false;
        }

        // Evento disparado ao clicar no ícone (PictureBox) do campo
        private void PictureBoxNome_Click(object sender, EventArgs e)
        {
            // Move o foco para o TextBox
            textBoxNome.Select();
        }

        #endregion

        #region ----------------------------------- TEXTBOX APELIDO -------------------------------------

        // Evento disparado quando o texto é alterado
        private void TextBoxApelido_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxApelido.Text))
            {
                string nome = textBoxApelido.Text;

                // Formata o texto para ter a primeira letra maiúscula de cada palavra
                nome = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());

                textBoxApelido.Text = nome;
                textBoxApelido.SelectionStart = textBoxApelido.Text.Length;
            }

            // Se o campo estiver vazio, esconde o label
            if (textBoxApelido.Text == "")
            {
                labelApelido.Visible = false;
            }
        }

        // Esconde o label ao clicar no campo, se estiver vazio
        private void TextBoxApelido_Click(object sender, EventArgs e)
        {
            if (textBoxApelido.Text == "")
            {
                labelApelido.Visible = false;
            }
        }

        // Esconde o label e foca no campo ao clicar no label
        private void LabelApelido_Click(object sender, EventArgs e)
        {
            labelApelido.Visible = false;
            textBoxApelido.Select();
        }

        // Mostra o label novamente se o campo estiver vazio ao perder o foco
        private void TextBoxApelido_Leave(object sender, EventArgs e)
        {
            if (textBoxApelido.Text == "")
            {
                labelApelido.Visible = true;
            }
        }

        // Esconde o label ao entrar no campo
        private void TextBoxApelido_Enter(object sender, EventArgs e)
        {
            labelApelido.Visible = false;
        }

        // Foca no campo ao clicar na imagem
        private void PictureBoxApelido_Click(object sender, EventArgs e)
        {
            textBoxApelido.Select();
        }

        #endregion

        #region ----------------------------------- TEXTBOX CARGO -------------------------------------

        // Evento disparado ao alterar o texto do campo Cargo
        private void TextBoxCargo_TextChanged(object sender, EventArgs e)
        {
            // ⚠️ Correção sugerida: o "textBoxApelido.Text" aqui está incorreto — deve ser "txtCargo.Text".
            if (!string.IsNullOrEmpty(txtCargo.Text))
            {
                string nome = txtCargo.Text;

                // Capitaliza cada palavra
                nome = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());

                txtCargo.Text = nome;
                txtCargo.SelectionStart = txtCargo.Text.Length;
            }

            // Esconde o label se o campo estiver vazio
            if (txtCargo.Text == "")
            {
                labelCargo.Visible = false;
            }
        }

        // Esconde o label ao clicar no campo
        private void TextBoxCargo_Click(object sender, EventArgs e)
        {
            if (txtCargo.Text == "")
            {
                labelCargo.Visible = false;
            }
        }

        // Esconde o label e foca no campo ao clicar no label
        private void LabelCargo_Click(object sender, EventArgs e)
        {
            labelCargo.Visible = false;
            txtCargo.Select();
        }

        // Mostra o label se o campo estiver vazio ao perder o foco
        private void TextBoxCargo_Leave(object sender, EventArgs e)
        {
            if (txtCargo.Text == "")
            {
                labelCargo.Visible = true;
            }
        }

        // Esconde o label ao entrar no campo
        private void TextBoxCargo_Enter(object sender, EventArgs e)
        {
            labelCargo.Visible = false;
        }

        // Foca no campo ao clicar na imagem
        private void PictureBoxCargo_Click(object sender, EventArgs e)
        {
            txtCargo.Select();
        }

        #endregion

        #region ----------------------------------- TEXTBOX TELEFONE -------------------------------------

        // Esconde o label se o campo estiver vazio
        private void TextBoxTelefone_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "")
            {
                labelTelefone.Visible = false;
            }
        }

        // Esconde o label ao clicar no campo se estiver vazio
        private void TextBoxTelefone_Click(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "")
            {
                labelTelefone.Visible = false;
            }
        }

        // Esconde o label e foca no campo ao clicar no label
        private void LabelTelefone_Click(object sender, EventArgs e)
        {
            labelTelefone.Visible = false;
            txtTelefone.Select();
        }

        // Mostra o label se o campo estiver vazio ao perder o foco
        private void TextBoxTelefone_Leave(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "")
            {
                labelTelefone.Visible = true;
            }
        }

        // Esconde o label ao entrar no campo
        private void TextBoxTelefone_Enter(object sender, EventArgs e)
        {
            labelTelefone.Visible = false;
        }

        // Foca no campo ao clicar na imagem
        private void PictureBoxTelefone_Click(object sender, EventArgs e)
        {
            txtTelefone.Select();
        }

        #endregion

        #region ----------------------------------- TEXTBOX EMAIL -------------------------------------

        // Esconde o label se o campo estiver vazio
        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                labelEmail.Visible = false;
            }
        }

        // Esconde o label ao clicar no campo
        private void TextBoxEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                labelEmail.Visible = false;
            }
        }

        // Esconde o label e foca no campo ao clicar no label
        private void LabelEmail_Click(object sender, EventArgs e)
        {
            labelEmail.Visible = false;
            txtEmail.Select();
        }

        // Mostra o label se o campo estiver vazio ao perder o foco
        private void TextBoxEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                labelEmail.Visible = true;
            }
        }

        // Esconde o label ao entrar no campo
        private void TextBoxEmail_Enter(object sender, EventArgs e)
        {
            labelEmail.Visible = false;
        }

        // Foca no campo ao clicar na imagem
        private void PictureBoxEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Select();
        }

        #endregion

        #region ----------------------------------- TEXTBOX MORADA -------------------------------------

        // Esconde o label se o campo estiver vazio
        private void TextBoxMorada_TextChanged(object sender, EventArgs e)
        {
            if (txtMorada.Text == "")
            {
                labelMorada.Visible = false;
            }
        }

        // Esconde o label ao clicar no campo
        private void TextBoxMorada_Click(object sender, EventArgs e)
        {
            if (txtMorada.Text == "")
            {
                labelMorada.Visible = false;
            }
        }

        // Esconde o label e foca no campo ao clicar no label
        private void LabelMorada_Click(object sender, EventArgs e)
        {
            labelMorada.Visible = false;
            txtMorada.Select();
        }

        // Mostra o label se o campo estiver vazio ao perder o foco
        private void TextBoxMorada_Leave(object sender, EventArgs e)
        {
            if (txtMorada.Text == "")
            {
                labelMorada.Visible = true;
            }
        }

        // Esconde o label ao entrar no campo
        private void TextBoxMorada_Enter(object sender, EventArgs e)
        {
            labelMorada.Visible = false;
        }

        // Foca no campo ao clicar na imagem
        private void PictureBoxMorada_Click(object sender, EventArgs e)
        {
            txtMorada.Select();
        }

        #endregion

        #region ----------------------------------- TEXTBOX CIDADE -------------------------------------

        // Esconde o label se o campo estiver vazio
        private void TextBoxCidade_TextChanged(object sender, EventArgs e)
        {
            if (txtCidade.Text == "")
            {
                labelCidade.Visible = false;
            }
        }

        // Esconde o label ao clicar no campo
        private void TextBoxCidade_Click(object sender, EventArgs e)
        {
            if (txtCidade.Text == "")
            {
                labelCidade.Visible = false;
            }
        }

        // Esconde o label e foca no campo ao clicar no label
        private void LabelCidade_Click(object sender, EventArgs e)
        {
            labelCidade.Visible = false;
            txtCidade.Select();
        }

        // Mostra o label se o campo estiver vazio ao perder o foco
        private void TextBoxCidade_Leave(object sender, EventArgs e)
        {
            if (txtCidade.Text == "")
            {
                labelCidade.Visible = true;
            }
        }

        // Esconde o label ao entrar no campo
        private void TextBoxCidade_Enter(object sender, EventArgs e)
        {
            labelCidade.Visible = false;
        }

        // Foca no campo ao clicar na imagem
        private void PictureBoxCidade_Click(object sender, EventArgs e)
        {
            txtCidade.Select();
        }

        #endregion

        #region ----------------------------------- TEXTBOX DISTRITO -------------------------------------

        // Esconde o label se o campo estiver vazio
        private void TextBoxDistrito_TextChanged(object sender, EventArgs e)
        {
            if (txtDistrito.Text == "")
            {
                labelDistrito.Visible = false;
            }
        }

        // Esconde o label ao clicar no campo
        private void TextBoxDistrito_Click(object sender, EventArgs e)
        {
            if (txtDistrito.Text == "")
            {
                labelDistrito.Visible = false;
            }
        }

        // Esconde o label e foca no campo ao clicar no label
        private void LabelDistrito_Click(object sender, EventArgs e)
        {
            labelDistrito.Visible = false;
            txtDistrito.Select();
        }

        // Mostra o label se o campo estiver vazio ao perder o foco
        private void TextBoxDistrito_Leave(object sender, EventArgs e)
        {
            if (txtDistrito.Text == "")
            {
                labelDistrito.Visible = true;
            }
        }

        // Esconde o label ao entrar no campo
        private void TextBoxDistrito_Enter(object sender, EventArgs e)
        {
            labelDistrito.Visible = false;
        }

        // Foca no campo ao clicar na imagem
        private void PictureBoxDistrito_Click(object sender, EventArgs e)
        {
            txtDistrito.Select();
        }

        #endregion

        #region ----------------------------------- TEXTBOX CODIGO POSTAL -------------------------------------

        // Esconde o label se o campo estiver vazio
        private void TextBoxCP_TextChanged(object sender, EventArgs e)
        {
            if (txtCP.Text == "")
            {
                labelCP.Visible = false;
            }
        }

        // Esconde o label ao clicar no campo
        private void TextBoxCP_Click(object sender, EventArgs e)
        {
            if (txtCP.Text == "")
            {
                labelCP.Visible = false;
            }
        }

        // Esconde o label e foca no campo ao clicar no label
        private void LabelCP_Click(object sender, EventArgs e)
        {
            labelCP.Visible = false;
            txtCP.Select();
        }

        // Mostra o label se o campo estiver vazio ao perder o foco
        private void TextBoxCP_Leave(object sender, EventArgs e)
        {
            if (txtCP.Text == "")
            {
                labelCP.Visible = true;
            }
        }

        // Esconde o label ao entrar no campo
        private void TextBoxCP_Enter(object sender, EventArgs e)
        {
            labelCP.Visible = false;
        }

        // Foca no campo ao clicar na imagem
        private void PictureBoxCP_Click(object sender, EventArgs e)
        {
            txtCP.Select();
        }

        #endregion

        #region ----------------------------------- TEXTBOX PAÍS -------------------------------------

        // Esconde o label se o campo estiver vazio
        private void TextBoxPais_TextChanged(object sender, EventArgs e)
        {
            if (txtPais.Text == "")
            {
                labelPais.Visible = false;
            }
        }

        // Esconde o label ao clicar no campo
        private void TextBoxPais_Click(object sender, EventArgs e)
        {
            if (txtPais.Text == "")
            {
                labelPais.Visible = false;
            }
        }

        // Esconde o label e foca no campo ao clicar no label
        private void LabelPais_Click(object sender, EventArgs e)
        {
            labelPais.Visible = false;
            txtPais.Select();
        }

        // Mostra o label se o campo estiver vazio ao perder o foco
        private void TextBoxPais_Leave(object sender, EventArgs e)
        {
            if (txtPais.Text == "")
            {
                labelPais.Visible = true;
            }
        }

        // Esconde o label ao entrar no campo
        private void TextBoxPais_Enter(object sender, EventArgs e)
        {
            labelPais.Visible = false;
        }

        // Foca no campo ao clicar na imagem
        private void PictureBoxPais_Click(object sender, EventArgs e)
        {
            txtPais.Select();
        }

        #endregion

    }
}
