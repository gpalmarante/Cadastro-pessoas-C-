namespace SA2
{
    partial class principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXTCriar = new System.Windows.Forms.Label();
            this.TXTListar = new System.Windows.Forms.Label();
            this.TXTBuscar = new System.Windows.Forms.Label();
            this.CaixaOpcao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTSair = new System.Windows.Forms.Label();
            this.TXTExcluir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTCriar
            // 
            this.TXTCriar.AutoSize = true;
            this.TXTCriar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TXTCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCriar.Location = new System.Drawing.Point(279, 121);
            this.TXTCriar.Name = "TXTCriar";
            this.TXTCriar.Size = new System.Drawing.Size(199, 25);
            this.TXTCriar.TabIndex = 0;
            this.TXTCriar.Text = "1 - Criar novo usuario";
            this.TXTCriar.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXTListar
            // 
            this.TXTListar.AutoSize = true;
            this.TXTListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TXTListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTListar.Location = new System.Drawing.Point(279, 146);
            this.TXTListar.Name = "TXTListar";
            this.TXTListar.Size = new System.Drawing.Size(169, 25);
            this.TXTListar.TabIndex = 1;
            this.TXTListar.Text = "2 - Listar Usuarios";
            this.TXTListar.Click += new System.EventHandler(this.label2_Click);
            // 
            // TXTBuscar
            // 
            this.TXTBuscar.AutoSize = true;
            this.TXTBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TXTBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBuscar.Location = new System.Drawing.Point(279, 171);
            this.TXTBuscar.Name = "TXTBuscar";
            this.TXTBuscar.Size = new System.Drawing.Size(173, 25);
            this.TXTBuscar.TabIndex = 2;
            this.TXTBuscar.Text = "3 - Buscar Usuario";
            this.TXTBuscar.Click += new System.EventHandler(this.label3_Click);
            // 
            // CaixaOpcao
            // 
            this.CaixaOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaixaOpcao.Location = new System.Drawing.Point(284, 282);
            this.CaixaOpcao.Name = "CaixaOpcao";
            this.CaixaOpcao.Size = new System.Drawing.Size(48, 35);
            this.CaixaOpcao.TabIndex = 3;
            this.CaixaOpcao.TextChanged += new System.EventHandler(this.CaixaOpcao_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(397, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Digite ou clique na opção desejada ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(426, 53);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cadastro de Usuarios";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TXTSair
            // 
            this.TXTSair.AutoSize = true;
            this.TXTSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TXTSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTSair.Location = new System.Drawing.Point(279, 244);
            this.TXTSair.Name = "TXTSair";
            this.TXTSair.Size = new System.Drawing.Size(75, 25);
            this.TXTSair.TabIndex = 6;
            this.TXTSair.Text = "5 - Sair";
            this.TXTSair.Click += new System.EventHandler(this.label6_Click);
            // 
            // TXTExcluir
            // 
            this.TXTExcluir.AutoSize = true;
            this.TXTExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TXTExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTExcluir.Location = new System.Drawing.Point(279, 196);
            this.TXTExcluir.Name = "TXTExcluir";
            this.TXTExcluir.Size = new System.Drawing.Size(170, 25);
            this.TXTExcluir.TabIndex = 7;
            this.TXTExcluir.Text = "4 - Excluir Usuario";
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXTExcluir);
            this.Controls.Add(this.TXTSair);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CaixaOpcao);
            this.Controls.Add(this.TXTBuscar);
            this.Controls.Add(this.TXTListar);
            this.Controls.Add(this.TXTCriar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TXTCriar;
        private System.Windows.Forms.Label TXTListar;
        private System.Windows.Forms.Label TXTBuscar;
        private System.Windows.Forms.TextBox CaixaOpcao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TXTSair;
        private System.Windows.Forms.Label TXTExcluir;
    }
}

