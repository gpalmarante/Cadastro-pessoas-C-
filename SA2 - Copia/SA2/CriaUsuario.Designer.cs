
namespace SA2
{
    partial class CriaUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTnome = new System.Windows.Forms.TextBox();
            this.TXTIdade = new System.Windows.Forms.TextBox();
            this.BtnCriarUsuario = new System.Windows.Forms.Button();
            this.BTNcancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "IDADE:";
            // 
            // TXTnome
            // 
            this.TXTnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTnome.Location = new System.Drawing.Point(97, 46);
            this.TXTnome.Name = "TXTnome";
            this.TXTnome.Size = new System.Drawing.Size(408, 23);
            this.TXTnome.TabIndex = 2;
            // 
            // TXTIdade
            // 
            this.TXTIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTIdade.Location = new System.Drawing.Point(97, 77);
            this.TXTIdade.Name = "TXTIdade";
            this.TXTIdade.Size = new System.Drawing.Size(38, 23);
            this.TXTIdade.TabIndex = 3;
            // 
            // BtnCriarUsuario
            // 
            this.BtnCriarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCriarUsuario.Location = new System.Drawing.Point(97, 106);
            this.BtnCriarUsuario.Name = "BtnCriarUsuario";
            this.BtnCriarUsuario.Size = new System.Drawing.Size(156, 23);
            this.BtnCriarUsuario.TabIndex = 4;
            this.BtnCriarUsuario.Text = "Criar Usuario";
            this.BtnCriarUsuario.UseVisualStyleBackColor = true;
            this.BtnCriarUsuario.Click += new System.EventHandler(this.BtnCriarUsuario_Click);
            // 
            // BTNcancelar
            // 
            this.BTNcancelar.Location = new System.Drawing.Point(430, 106);
            this.BTNcancelar.Name = "BTNcancelar";
            this.BTNcancelar.Size = new System.Drawing.Size(75, 23);
            this.BTNcancelar.TabIndex = 5;
            this.BTNcancelar.Text = "Cancelar";
            this.BTNcancelar.UseVisualStyleBackColor = true;
            this.BTNcancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // CriaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 171);
            this.Controls.Add(this.BTNcancelar);
            this.Controls.Add(this.BtnCriarUsuario);
            this.Controls.Add(this.TXTIdade);
            this.Controls.Add(this.TXTnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CriaUsuario";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTnome;
        private System.Windows.Forms.TextBox TXTIdade;
        private System.Windows.Forms.Button BtnCriarUsuario;
        private System.Windows.Forms.Button BTNcancelar;
    }
}