namespace LojaDoce
{
    partial class Form1
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
            lblNomeDoce = new Label();
            lblPrecoUnitario = new Label();
            lblQuantidade = new Label();
            butCalcular = new Button();
            lblIdadeCliente = new Label();
            textNomeDoce = new TextBox();
            textIdadeCliente = new TextBox();
            textQuantidade = new TextBox();
            textPrecoUnitario = new TextBox();
            lblNome = new Label();
            lblDesconto = new Label();
            lblParcela = new Label();
            lblValorFinal = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblNomeDoce
            // 
            lblNomeDoce.AutoSize = true;
            lblNomeDoce.Location = new Point(326, 9);
            lblNomeDoce.Name = "lblNomeDoce";
            lblNomeDoce.Size = new Size(70, 15);
            lblNomeDoce.TabIndex = 0;
            lblNomeDoce.Text = "Nome Doce";
            // 
            // lblPrecoUnitario
            // 
            lblPrecoUnitario.AutoSize = true;
            lblPrecoUnitario.Location = new Point(326, 50);
            lblPrecoUnitario.Name = "lblPrecoUnitario";
            lblPrecoUnitario.Size = new Size(82, 15);
            lblPrecoUnitario.TabIndex = 1;
            lblPrecoUnitario.Text = "Preço Unitário";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(326, 90);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 2;
            lblQuantidade.Text = "Quantidade";
            // 
            // butCalcular
            // 
            butCalcular.Location = new Point(366, 384);
            butCalcular.Name = "butCalcular";
            butCalcular.Size = new Size(75, 23);
            butCalcular.TabIndex = 3;
            butCalcular.Text = "Calcular";
            butCalcular.UseVisualStyleBackColor = true;
            // 
            // lblIdadeCliente
            // 
            lblIdadeCliente.AutoSize = true;
            lblIdadeCliente.Location = new Point(326, 138);
            lblIdadeCliente.Name = "lblIdadeCliente";
            lblIdadeCliente.Size = new Size(76, 15);
            lblIdadeCliente.TabIndex = 4;
            lblIdadeCliente.Text = "Idade Cliente";
            // 
            // textNomeDoce
            // 
            textNomeDoce.Location = new Point(420, 1);
            textNomeDoce.Name = "textNomeDoce";
            textNomeDoce.Size = new Size(100, 23);
            textNomeDoce.TabIndex = 5;
            // 
            // textIdadeCliente
            // 
            textIdadeCliente.Location = new Point(420, 130);
            textIdadeCliente.Name = "textIdadeCliente";
            textIdadeCliente.Size = new Size(100, 23);
            textIdadeCliente.TabIndex = 6;
            // 
            // textQuantidade
            // 
            textQuantidade.Location = new Point(420, 82);
            textQuantidade.Name = "textQuantidade";
            textQuantidade.Size = new Size(100, 23);
            textQuantidade.TabIndex = 7;
            // 
            // textPrecoUnitario
            // 
            textPrecoUnitario.Location = new Point(420, 42);
            textPrecoUnitario.Name = "textPrecoUnitario";
            textPrecoUnitario.Size = new Size(100, 23);
            textPrecoUnitario.TabIndex = 8;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(326, 186);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 9;
            lblNome.Text = "Nome";
            lblNome.Click += label1_Click;
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(326, 220);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(57, 15);
            lblDesconto.TabIndex = 10;
            lblDesconto.Text = "Desconto";
            lblDesconto.Click += label2_Click;
            // 
            // lblParcela
            // 
            lblParcela.AutoSize = true;
            lblParcela.Location = new Point(326, 296);
            lblParcela.Name = "lblParcela";
            lblParcela.Size = new Size(45, 15);
            lblParcela.TabIndex = 11;
            lblParcela.Text = "Parcela";
            // 
            // lblValorFinal
            // 
            lblValorFinal.AutoSize = true;
            lblValorFinal.Location = new Point(322, 254);
            lblValorFinal.Name = "lblValorFinal";
            lblValorFinal.Size = new Size(61, 15);
            lblValorFinal.TabIndex = 12;
            lblValorFinal.Text = "Valor Final";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(326, 326);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Status";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(lblValorFinal);
            Controls.Add(lblParcela);
            Controls.Add(lblDesconto);
            Controls.Add(lblNome);
            Controls.Add(textPrecoUnitario);
            Controls.Add(textQuantidade);
            Controls.Add(textIdadeCliente);
            Controls.Add(textNomeDoce);
            Controls.Add(lblIdadeCliente);
            Controls.Add(butCalcular);
            Controls.Add(lblQuantidade);
            Controls.Add(lblPrecoUnitario);
            Controls.Add(lblNomeDoce);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeDoce;
        private Label lblPrecoUnitario;
        private Label lblQuantidade;
        private Button butCalcular;
        private Label lblIdadeCliente;
        private TextBox textNomeDoce;
        private TextBox textIdadeCliente;
        private TextBox textQuantidade;
        private TextBox textPrecoUnitario;
        private Label lblNome;
        private Label lblDesconto;
        private Label lblParcela;
        private Label lblValorFinal;
        private Label lblStatus;
    }
}
