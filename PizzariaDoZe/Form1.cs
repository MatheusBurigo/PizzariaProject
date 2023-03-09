using Employees;

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
    }
}