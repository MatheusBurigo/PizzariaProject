using Employees;

using WinFormsApp1;

namespace PizzariaDoZe
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void CadastroFuncionarios_Click(object sender, EventArgs e)
        {
            var func = new Form1();
            func.ShowDialog();
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            var client = new Clients.Clients();
            client.ShowDialog();
        }

        private void Ingredientes_Click(object sender, EventArgs e)
        {
            var ingr = new Ingredientes();
            ingr.ShowDialog();
        }

        private void Pizzas_Click(object sender, EventArgs e)
        {
            var pizza = new Pizzas.CadastroDePizza();
            pizza.ShowDialog();
        }
    }
}