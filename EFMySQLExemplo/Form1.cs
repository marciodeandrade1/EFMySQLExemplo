using EFMySQLExemplo.Contexto;
using EFMySQLExemplo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFMySQLExemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var context = new MeuContexto())
            {
                var cliente = new Cliente
                {
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    DataCadastro = DateTime.Now,
                    Ativo = true
                };
                context.Clientes.Add(cliente);
                context.SaveChanges();

                MessageBox.Show("Cliente salvo com sucesso!");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            using (var context = new MeuContexto())
            {
                var clientes = context.Clientes.ToList();
                dataGridView1.DataSource = clientes;
            }
        }
    }
}
