namespace PizzariaDoZe
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            Clients = new Button();
            Pizzas = new Button();
            Ingredientes = new Button();
            CadastroFuncionarios = new Button();
            panel2 = new Panel();
            FormaDePagamento = new Label();
            panel3 = new Panel();
            InfoPedido = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlText;
            panel1.Controls.Add(Clients);
            panel1.Controls.Add(Pizzas);
            panel1.Controls.Add(Ingredientes);
            panel1.Controls.Add(CadastroFuncionarios);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 56);
            panel1.TabIndex = 0;
            // 
            // Clients
            // 
            Clients.Location = new Point(492, 16);
            Clients.Name = "Clients";
            Clients.Size = new Size(132, 23);
            Clients.TabIndex = 4;
            Clients.Text = "Clientes";
            Clients.UseVisualStyleBackColor = true;
            Clients.Click += Clients_Click;
            // 
            // Pizzas
            // 
            Pizzas.Location = new Point(630, 16);
            Pizzas.Name = "Pizzas";
            Pizzas.Size = new Size(132, 23);
            Pizzas.TabIndex = 3;
            Pizzas.Text = "Pizzas";
            Pizzas.UseVisualStyleBackColor = true;
            Pizzas.Click += Pizzas_Click;
            // 
            // Ingredientes
            // 
            Ingredientes.Location = new Point(354, 16);
            Ingredientes.Name = "Ingredientes";
            Ingredientes.Size = new Size(132, 23);
            Ingredientes.TabIndex = 2;
            Ingredientes.Text = "Ingredientes";
            Ingredientes.UseVisualStyleBackColor = true;
            Ingredientes.Click += Ingredientes_Click;
            // 
            // CadastroFuncionarios
            // 
            CadastroFuncionarios.Location = new Point(216, 16);
            CadastroFuncionarios.Name = "CadastroFuncionarios";
            CadastroFuncionarios.Size = new Size(132, 23);
            CadastroFuncionarios.TabIndex = 0;
            CadastroFuncionarios.Text = "Funcionários";
            CadastroFuncionarios.UseVisualStyleBackColor = true;
            CadastroFuncionarios.Click += CadastroFuncionarios_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(FormaDePagamento);
            panel2.Location = new Point(12, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 353);
            panel2.TabIndex = 1;
            // 
            // FormaDePagamento
            // 
            FormaDePagamento.AutoSize = true;
            FormaDePagamento.Location = new Point(82, 22);
            FormaDePagamento.Name = "FormaDePagamento";
            FormaDePagamento.Size = new Size(138, 15);
            FormaDePagamento.TabIndex = 3;
            FormaDePagamento.Text = "FORMA DE PAGAMENTO";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.Controls.Add(InfoPedido);
            panel3.Location = new Point(329, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(459, 353);
            panel3.TabIndex = 2;
            // 
            // InfoPedido
            // 
            InfoPedido.AutoSize = true;
            InfoPedido.Location = new Point(154, 22);
            InfoPedido.Name = "InfoPedido";
            InfoPedido.Size = new Size(153, 15);
            InfoPedido.TabIndex = 4;
            InfoPedido.Text = "INFORMAÇÕES DO PEDIDO";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Menu";
            Text = "Menu Principal";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label FormaDePagamento;
        private Panel panel3;
        private Label InfoPedido;
        private Button Pizzas;
        private Button Ingredientes;
        private Button CadastroFuncionarios;
        private Button Clients;
    }
}