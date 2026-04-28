using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace port3_exemplo
{
    public partial class Form1 : Form
    {
        private readonly ClienteRepository _clienteRepository;


        public Form1()
        {
            InitializeComponent();
            _clienteRepository = new ClienteRepository();

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = new Cliente
                {
                    IdClientes = int.Parse(txtId.Text.Trim()),
                    Nome = txtNome.Text.Trim(),
                    Endereco = txtEndereco.Text.Trim(),
                    Telefone = txtTelefone.Text.Trim()
                };

                bool sucesso = _clienteRepository.Inserir(cliente);

                if (!sucesso)
                    MessageBox.Show("Erro ao inserir");
                else
                    MessageBox.Show("Inserido com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro");
            }
        }
    }
}
