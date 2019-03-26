namespace Sistema
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(13, 31);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(115, 43);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cadastro de Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Location = new System.Drawing.Point(178, 30);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(102, 44);
            this.btnFuncionario.TabIndex = 1;
            this.btnFuncionario.Text = "Cadastro Funcionario";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(12, 113);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(116, 40);
            this.btnProduto.TabIndex = 2;
            this.btnProduto.Text = "Cadastro de Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(197, 113);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 40);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnCliente);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnSair;
    }
}