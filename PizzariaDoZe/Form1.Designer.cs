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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            CadastroFuncionarios = new Button();
            panel2 = new Panel();
            FormaPagamento = new Label();
            panel3 = new Panel();
            InfoPedido = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(CadastroFuncionarios);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 56);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(630, 16);
            button4.Name = "button4";
            button4.Size = new Size(132, 23);
            button4.TabIndex = 3;
            button4.Text = "Pizzas";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(354, 16);
            button3.Name = "button3";
            button3.Size = new Size(132, 23);
            button3.TabIndex = 2;
            button3.Text = "Pedidos";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(492, 16);
            button2.Name = "button2";
            button2.Size = new Size(132, 23);
            button2.TabIndex = 1;
            button2.Text = "Clientes";
            button2.UseVisualStyleBackColor = true;
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
            panel2.Controls.Add(FormaPagamento);
            panel2.Location = new Point(12, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 353);
            panel2.TabIndex = 1;
            // 
            // FormaPagamento
            // 
            FormaPagamento.AutoSize = true;
            FormaPagamento.Location = new Point(82, 22);
            FormaPagamento.Name = "FormaPagamento";
            FormaPagamento.Size = new Size(138, 15);
            FormaPagamento.TabIndex = 3;
            FormaPagamento.Text = "FORMA DE PAGAMENTO";
            // 
            // panel3
            // 
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
        private Label FormaPagamento;
        private Panel panel3;
        private Label InfoPedido;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button CadastroFuncionarios;
    }
}