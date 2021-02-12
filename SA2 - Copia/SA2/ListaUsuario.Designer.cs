
namespace SA2
{
    partial class ListaUsuario
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
            this.ListaUsuarios = new System.Windows.Forms.ListBox();
            this.BTNSairLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaUsuarios
            // 
            this.ListaUsuarios.FormattingEnabled = true;
            this.ListaUsuarios.Location = new System.Drawing.Point(155, 49);
            this.ListaUsuarios.Name = "ListaUsuarios";
            this.ListaUsuarios.Size = new System.Drawing.Size(478, 290);
            this.ListaUsuarios.TabIndex = 0;
            this.ListaUsuarios.SelectedIndexChanged += new System.EventHandler(this.ListaUsuarios_SelectedIndexChanged);
            // 
            // BTNSairLista
            // 
            this.BTNSairLista.Location = new System.Drawing.Point(558, 366);
            this.BTNSairLista.Name = "BTNSairLista";
            this.BTNSairLista.Size = new System.Drawing.Size(75, 23);
            this.BTNSairLista.TabIndex = 1;
            this.BTNSairLista.Text = "Sair";
            this.BTNSairLista.UseVisualStyleBackColor = true;
            this.BTNSairLista.Click += new System.EventHandler(this.BTNSairLista_Click);
            // 
            // ListaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNSairLista);
            this.Controls.Add(this.ListaUsuarios);
            this.Name = "ListaUsuario";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListaUsuarios;
        private System.Windows.Forms.Button BTNSairLista;
    }
}