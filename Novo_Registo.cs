using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Registo_Colaboradores
{
    public partial class Novo_Registo : Form
    {
        public event Action Carregar_DataGrid;

        public int ID { get; set; }

        public Novo_Registo()
        {
           
            InitializeComponent();

            this.Load += new EventHandler(Novo_Registro_Load);
            // Associa o evento de clique do formulário principal (this) ao método Novo_Registro_Click
            this.Click += new EventHandler(Novo_Registro_Click);

            // Associa o clique no painel principal "panel_NovoRegisto" ao método que trata o clique
            panel_NovoRegisto.Click += panel_NovoRegisto_Click;         

            //-----------------------------------------------------------------
            // Define o foco inicial para o label25 (provavelmente o primeiro campo visual do formulário)
            label25.Select();

        }

        private void Eventos_Controles_Formulario()
        {
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
            textBoxApelido.TextChanged += TextBoxApelido_TextChanged;
            textBoxApelido.Click += TextBoxApelido_Click;
            textBoxApelido.Leave += TextBoxApelido_Leave;
            textBoxApelido.Enter += TextBoxApelido_Enter;
            labelApelido.Click += LabelApelido_Click;
            pictureBoxApelido.Click += PictureBoxApelido_Click;

            //-----------------------------------------------------------------
            // EVENTOS DO TEXTBOX "CARGO"
            txtCargo.TextChanged += TextBoxCargo_TextChanged;
            txtCargo.Click += TextBoxCargo_Click;
            txtCargo.Leave += TextBoxCargo_Leave;
            txtCargo.Enter += TextBoxCargo_Enter;
            labelCargo.Click += LabelCargo_Click;
            pictureBoxCargo.Click += PictureBoxCargo_Click;

            //-----------------------------------------------------------------
            // EVENTOS DO TEXTBOX "TELEFONE"
            txtTelemovel.TextChanged += txtTelefone_TextChanged;
            txtTelemovel.KeyPress += txtTelefone_KeyPress;
            txtTelemovel.Click += TextBoxTelefone_Click;
            txtTelemovel.Leave += TextBoxTelefone_Leave;
            txtTelemovel.Enter += TextBoxTelefone_Enter;
            labelTelefone.Click += LabelTelefone_Click;
            pictureBoxTelefone.Click += PictureBoxTelefone_Click;

            //-----------------------------------------------------------------
            // EVENTOS DO TEXTBOX "EMAIL"
            txtEmail.TextChanged += TextBoxEmail_TextChanged;
            txtEmail.Click += TextBoxEmail_Click;
            txtEmail.Leave += TextBoxEmail_Leave;
            txtEmail.Enter += TextBoxEmail_Enter;
            labelEmail.Click += LabelEmail_Click;
            pictureBoxEmail.Click += PictureBoxEmail_Click;

            //-----------------------------------------------------------------
            // EVENTOS DO TEXTBOX "MORADA" (Endereço)
            txtMorada.TextChanged += TextBoxMorada_TextChanged;
            txtMorada.Click += TextBoxMorada_Click;
            txtMorada.Leave += TextBoxMorada_Leave;
            txtMorada.Enter += TextBoxMorada_Enter;
            labelMorada.Click += LabelMorada_Click;
            pictureBoxMorada.Click += PictureBoxMorada_Click;

            //-----------------------------------------------------------------
            // EVENTOS DO TEXTBOX "CIDADE"
            txtCidade.TextChanged += TextBoxCidade_TextChanged;
            txtCidade.Click += TextBoxCidade_Click;
            txtCidade.Leave += TextBoxCidade_Leave;
            txtCidade.Enter += TextBoxCidade_Enter;
            labelCidade.Click += LabelCidade_Click;
            pictureBoxCidade.Click += PictureBoxCidade_Click;

            //-----------------------------------------------------------------
            // EVENTOS DO TEXTBOX "DISTRITO"
            txtDistrito.TextChanged += TextBoxDistrito_TextChanged;
            txtDistrito.Click += TextBoxDistrito_Click;
            txtDistrito.Leave += TextBoxDistrito_Leave;
            txtDistrito.Enter += TextBoxDistrito_Enter;
            labelDistrito.Click += LabelDistrito_Click;
            pictureBoxDistrito.Click += PictureBoxDistrito_Click;

            //-----------------------------------------------------------------
            // EVENTOS DO TEXTBOX "CÓDIGO POSTAL" (CP)
            txtCP.TextChanged += TextBoxCP_TextChanged;
            txtCP.Click += TextBoxCP_Click;
            txtCP.Leave += TextBoxCP_Leave;
            txtCP.Enter += TextBoxCP_Enter;
            labelCP.Click += LabelCP_Click;
            pictureBoxCP.Click += PictureBoxCP_Click;
            txtCP.KeyPress += txtCP_KeyPress;

            //-----------------------------------------------------------------
            // EVENTOS DO TEXTBOX "PAÍS"
            txtPais.TextChanged += TextBoxPais_TextChanged;
            txtPais.Click += TextBoxPais_Click;
            txtPais.Leave += TextBoxPais_Leave;
            txtPais.Enter += TextBoxPais_Enter;
            labelPais.Click += LabelPais_Click;
            pictureBoxPais.Click += PictureBoxPais_Click;
            #endregion

        }

        private void Novo_Registro_Load(object sender, EventArgs e)
        {
            Eventos_Controles_Formulario();
        }

        // Evento chamado quando o usuário clica em alguma parte do formulário principal
        // (por exemplo, em uma área vazia ou botão que dispara "Novo_Registro_Click")
        private void Novo_Registro_Click(object sender, EventArgs e)
        {
            // Verifica se o campo "Nome" está vazio
            if (textBoxNome.Text == string.Empty)
            {
                labelNome.Visible = true;    // Mostra o label "Nome" (placeholder)
                label25.Select();            // Define o foco em label25 (provavelmente para evitar cursor piscando no campo)
            }

            // Verifica se o campo "Apelido" está vazio
            if (textBoxApelido.Text == string.Empty)
            {
                labelApelido.Visible = true;
                label25.Select();
            }

            // Verifica se o campo "Cargo" está vazio
            if (txtCargo.Text == string.Empty)
            {
                labelCargo.Visible = true;
                label25.Select();
            }

            // Verifica se o campo "Telefone" está vazio
            if (txtTelemovel.Text == string.Empty)
            {
                labelTelefone.Visible = true;
                label25.Select();
            }

            // Verifica se o campo "Email" está vazio
            if (txtEmail.Text == string.Empty)
            {
                labelEmail.Visible = true;
                label25.Select();
            }

            // Verifica se o campo "Morada" (Endereço) está vazio
            if (txtMorada.Text == string.Empty)
            {
                labelMorada.Visible = true;
                label25.Select();
            }

            // Verifica se o campo "Cidade" está vazio
            if (txtCidade.Text == string.Empty)
            {
                labelCidade.Visible = true;
                label25.Select();
            }

            // Verifica se o campo "Distrito" está vazio
            if (txtDistrito.Text == string.Empty)
            {
                labelDistrito.Visible = true;
                label25.Select();
            }

            // Verifica se o campo "Código Postal" está vazio
            if (txtCP.Text == string.Empty)
            {
                labelCP.Visible = true;
                label25.Select();
            }

            // Verifica se o campo "País" está vazio
            if (txtPais.Text == string.Empty)
            {
                labelPais.Visible = true;
                label25.Select();
            }
        }

        // Evento chamado quando o usuário clica no painel "panel_NovoRegisto"
        // (provavelmente área de fundo da tela de novo registro)
        private void panel_NovoRegisto_Click(object sender, EventArgs e)
        {
            // As mesmas verificações feitas no evento acima:
            // Se qualquer campo estiver vazio, o respectivo label é exibido.

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

            if (txtTelemovel.Text == string.Empty)
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

        #region METODOS DOS TEXTBOX

        #region-------------------------------TEXTBOX NOME -----------------------------------

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

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Impede digitar mais que 9 dígitos
            if (!char.IsControl(e.KeyChar) && txtTelemovel.Text.Length >= 9)
            {
                e.Handled = true;
            }
        }

        // Esconde o label se o campo estiver vazio
        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            // Esconde o label se estiver vazio
            if (txtTelemovel.Text == "") 
            { 
                labelTelefone.Visible = false;       
            }

            // Remove qualquer caractere não numérico (caso algo seja colado)
            string texto = new string(txtTelemovel.Text.Where(char.IsDigit).ToArray());

            // Limita a 9 dígitos
            if (texto.Length > 9)
                texto = texto.Substring(0, 9);

            // Atualiza o texto formatado, se houve alteração
            if (txtTelemovel.Text != texto)
            {
                int pos = txtTelemovel.SelectionStart;
                txtTelemovel.Text = texto;
                txtTelemovel.SelectionStart = Math.Min(pos, txtTelemovel.Text.Length);
            }
        }


        // Esconde o label ao clicar no campo se estiver vazio
        private void TextBoxTelefone_Click(object sender, EventArgs e)
        {
            if (txtTelemovel.Text == "")
            {
                labelTelefone.Visible = false;
            }
        }

        // Esconde o label e foca no campo ao clicar no label
        private void LabelTelefone_Click(object sender, EventArgs e)
        {
            labelTelefone.Visible = false;
            txtTelemovel.Select();
        }

        // Mostra o label se o campo estiver vazio ao perder o foco
        private void TextBoxTelefone_Leave(object sender, EventArgs e)
        {
            if (txtTelemovel.Text == "")
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
            txtTelemovel.Select();
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
            // Verifica se o campo não está vazio
            if (!string.IsNullOrEmpty(txtMorada.Text))
            {
                string nome = txtMorada.Text;

                // Converte todo o texto para minúsculo e capitaliza a primeira letra de cada palavra
                nome = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());

                // Atualiza o conteúdo do TextBox com o texto formatado
                txtMorada.Text = nome;

                // Posiciona o cursor no final do texto
                txtMorada.SelectionStart = txtMorada.Text.Length;
            }

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
            // Verifica se o campo não está vazio
            if (!string.IsNullOrEmpty(txtCidade.Text))
            {
                string nome = txtCidade.Text;

                // Converte todo o texto para minúsculo e capitaliza a primeira letra de cada palavra
                nome = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());

                // Atualiza o conteúdo do TextBox com o texto formatado
                txtCidade.Text = nome;

                // Posiciona o cursor no final do texto
                txtCidade.SelectionStart = txtCidade.Text.Length;
            }

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
            // Verifica se o campo não está vazio
            if (!string.IsNullOrEmpty(txtDistrito.Text))
            {
                string nome = txtDistrito.Text;

                // Converte todo o texto para minúsculo e capitaliza a primeira letra de cada palavra
                nome = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());

                // Atualiza o conteúdo do TextBox com o texto formatado
                txtDistrito.Text = nome;

                // Posiciona o cursor no final do texto
                txtDistrito.SelectionStart = txtDistrito.Text.Length;
            }

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

            // Remove temporariamente o evento para evitar loop
            txtCP.TextChanged -= TextBoxCP_TextChanged;

            string texto = txtCP.Text.Replace("-", ""); // Remove o traço, caso já tenha
            if (texto.Length > 4)
            {
                texto = texto.Insert(4, "-"); // Insere o traço depois do 4º dígito
            }

            txtCP.Text = texto;
            txtCP.SelectionStart = txtCP.Text.Length; // Mantém o cursor no final

            // Reassocia o evento
            txtCP.TextChanged += TextBoxCP_TextChanged;
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Impede digitar mais que 7 dígitos (sem contar o traço)
            string texto = txtCP.Text.Replace("-", "");
            if (!char.IsControl(e.KeyChar) && texto.Length >= 7)
            {
                e.Handled = true;
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
            // Verifica se o campo não está vazio
            if (!string.IsNullOrEmpty(txtPais.Text))
            {
                string nome = txtPais.Text;

                // Converte todo o texto para minúsculo e capitaliza a primeira letra de cada palavra
                nome = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());

                // Atualiza o conteúdo do TextBox com o texto formatado
                txtPais.Text = nome;

                // Posiciona o cursor no final do texto
                txtPais.SelectionStart = txtPais.Text.Length;
            }

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

        #endregion

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            if (email.Contains("@"))
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        // Comando SQL com parâmetros
                        string sql = @"
                    INSERT INTO [Colaboradores].[dbo].[Colaboradores]
                    (Colaborador, Apelido, Cargo, Telemóvel, Email, Morada, Cidade, Distrito, [Código Postal], País)
                    VALUES
                    (@Colaborador, @Apelido, @Cargo, @Telemovel, @Email, @Morada, @Cidade, @Distrito, @CodigoPostal, @Pais);
                    SELECT SCOPE_IDENTITY();";

                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            // Substitua os valores pelos campos do seu formulário
                            cmd.Parameters.AddWithValue("@Colaborador", textBoxNome.Text);
                            cmd.Parameters.AddWithValue("@Apelido", textBoxApelido.Text);
                            cmd.Parameters.AddWithValue("@Cargo", txtCargo.Text);
                            cmd.Parameters.AddWithValue("@Telemovel", txtTelemovel.Text);
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@Morada", txtMorada.Text);
                            cmd.Parameters.AddWithValue("@Cidade", txtCidade.Text);
                            cmd.Parameters.AddWithValue("@Distrito", txtDistrito.Text);
                            cmd.Parameters.AddWithValue("@CodigoPostal", txtCP.Text);
                            cmd.Parameters.AddWithValue("@Pais", txtPais.Text);

                            // Executa e captura o ID gerado
                            int newId = Convert.ToInt32(cmd.ExecuteScalar());

                            Carregar_DataGrid?.Invoke();
                            this.Close();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar o colaborador: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Insira um E-mail Válido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        #region Editar Dados

        private void bt_Editar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            if (email.Contains("@"))
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();

                        string sql = @"UPDATE Colaboradores
                           SET Colaborador = @Colaborador,
                               Apelido = @Apelido,
                               Cargo = @Cargo,
                               Telemóvel = @Telemovel,
                               Email = @Email,
                               Morada = @Morada,
                               Cidade = @Cidade,
                               Distrito = @Distrito,
                               [Código Postal] = @CodigoPostal,
                               País = @Pais
                           WHERE ID = @ID";

                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            // Supondo que você tem TextBox para cada campo
                            cmd.Parameters.AddWithValue("@ID", ID);
                            cmd.Parameters.AddWithValue("@Colaborador", textBoxNome.Text);
                            cmd.Parameters.AddWithValue("@Apelido", textBoxApelido.Text);
                            cmd.Parameters.AddWithValue("@Cargo", txtCargo.Text);
                            cmd.Parameters.AddWithValue("@Telemovel", txtTelemovel.Text);
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@Morada", txtMorada.Text);
                            cmd.Parameters.AddWithValue("@Cidade", txtCidade.Text);
                            cmd.Parameters.AddWithValue("@Distrito", txtDistrito.Text);
                            cmd.Parameters.AddWithValue("@CodigoPostal", txtCP.Text);
                            cmd.Parameters.AddWithValue("@Pais", txtPais.Text);

                            cmd.ExecuteNonQuery();

                            Carregar_DataGrid?.Invoke();
                            this.Close();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Insira um E-mail Válido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}
