using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registo_Colaboradores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataGridView_Colaboradores.DataBindingComplete += DataGridView_Colaboradores_DataBindingComplete;
            Carregar_Dados();

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

    }

   
}
