using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registo_Colaboradores
{
    public partial class Registar : Form
    {
        private int _hoveredRowIndex = -1;
        private int _selectedRowIndex = -1;

        public Registar()
        {
            InitializeComponent();

            DataGridView_Colaboradores.DataBindingComplete += DataGridView_Colaboradores_DataBindingComplete;
            
            Carregar_Dados();

            ConfigurarDataGridViewHover();

            DataGridView_Colaboradores.CellClick += DataGridView_Colaboradores_CellClick;
        }

        private void Carregar_Dados()
        {
            string connectionString = @"Data Source=AM\SQLEXPRESS; Initial Catalog=AdventureWorks2019; User ID=sa; Password=Flamengo2019";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT
                      [FirstName] as 'Nome'
                      ,[LastName] as 'Apelido' 
                      ,[JobTitle] as 'Cargo'
                      ,[PhoneNumber] as 'Telefone'
                      ,[EmailAddress] as 'Endereço de E-mail'
                      ,[AddressLine1] as 'Morada'
                      ,[City] as 'Cidade'
                      ,[StateProvinceName] as 'Província'
                      ,[PostalCode] as 'Código Postal'
                      ,[CountryRegionName] 'País'
                  FROM [AdventureWorks2019].[HumanResources].[vEmployee]";

                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataGridView_Colaboradores.DataSource = dt;

                DataGridView_Colaboradores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }

        }

        private void DataGridView_Colaboradores_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (DataGridView_Colaboradores.Columns.Contains("Endereço de E-mail"))
            {
                DataGridView_Colaboradores.Columns["Cargo"].Width = 270;
                DataGridView_Colaboradores.Columns["Endereço de E-mail"].Width = 270;
            }
        }

        // Handler separado para clique no botão
        private void DataGridView_Colaboradores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Remove a seleção anterior
                if (_selectedRowIndex >= 0 && _selectedRowIndex < DataGridView_Colaboradores.Rows.Count)
                {
                    DataGridView_Colaboradores.Rows[_selectedRowIndex].Selected = false;
                    DataGridView_Colaboradores.Rows[_selectedRowIndex].DefaultCellStyle.BackColor = Color.White;
                }

                // Seleciona a nova linha
                DataGridView_Colaboradores.Rows[e.RowIndex].Selected = true;
                DataGridView_Colaboradores.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCyan;
                _selectedRowIndex = e.RowIndex;

                // Remove o hover se estiver na mesma linha
                if (e.RowIndex == _hoveredRowIndex)
                {
                    _hoveredRowIndex = -1;
                }
            }
        }

        private void ConfigurarDataGridViewHover()
        {
            // Configuração básica do DataGridView
            DataGridView_Colaboradores.MultiSelect = false;
            DataGridView_Colaboradores.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DataGridView_Colaboradores.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightCyan;
            DataGridView_Colaboradores.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            // Habilita DoubleBuffered para reduzir piscadas
            typeof(DataGridView).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(DataGridView_Colaboradores, true, null);

            // Eventos para hover
            DataGridView_Colaboradores.CellMouseEnter += DataGridView_Colaboradores_CellMouseEnter;
            DataGridView_Colaboradores.CellMouseLeave += DataGridView_Colaboradores_CellMouseLeave;
            DataGridView_Colaboradores.MouseLeave += DataGridView_Colaboradores_MouseLeave;
        }

        private void DataGridView_Colaboradores_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != _selectedRowIndex)
            {
                // Aplica hover apenas se não for a linha selecionada
                DataGridView_Colaboradores.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCyan;
                _hoveredRowIndex = e.RowIndex;
            }
        }

        private void DataGridView_Colaboradores_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != _selectedRowIndex && e.RowIndex == _hoveredRowIndex)
            {
                // Verifica a posição atual do mouse para evitar piscadas
                var mousePos = DataGridView_Colaboradores.PointToClient(Cursor.Position);
                var hitTest = DataGridView_Colaboradores.HitTest(mousePos.X, mousePos.Y);

                // Só remove o hover se o mouse realmente saiu da linha
                if (hitTest.RowIndex != e.RowIndex)
                {
                    DataGridView_Colaboradores.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    _hoveredRowIndex = -1;
                }
            }
        }

        private void DataGridView_Colaboradores_MouseLeave(object sender, EventArgs e)
        {
            // Remove todo o hover quando o mouse sai do controle
            if (_hoveredRowIndex >= 0 && _hoveredRowIndex < DataGridView_Colaboradores.Rows.Count && _hoveredRowIndex != _selectedRowIndex)
            {
                DataGridView_Colaboradores.Rows[_hoveredRowIndex].DefaultCellStyle.BackColor = Color.White;
                _hoveredRowIndex = -1;
            }
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            Novo_Registo _Registo = new Novo_Registo();
            _Registo.ShowDialog();
        }
    }

   
}
