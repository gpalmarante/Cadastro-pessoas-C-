
namespace SA2
{
    partial class BuscarUsuario
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
            this.BoxTXTbusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxBusca = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.progressBarBusca = new System.Windows.Forms.ProgressBar();
            this.BTNSairBusca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoxTXTbusca
            // 
            this.BoxTXTbusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxTXTbusca.Location = new System.Drawing.Point(266, 101);
            this.BoxTXTbusca.Name = "BoxTXTbusca";
            this.BoxTXTbusca.Size = new System.Drawing.Size(415, 30);
            this.BoxTXTbusca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Digite Nome , idade ou ID   :";
            // 
            // listBoxBusca
            // 
            this.listBoxBusca.FormattingEnabled = true;
            this.listBoxBusca.Location = new System.Drawing.Point(266, 213);
            this.listBoxBusca.Name = "listBoxBusca";
            this.listBoxBusca.Size = new System.Drawing.Size(415, 147);
            this.listBoxBusca.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado da busca :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(266, 137);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(75, 31);
            this.BTNBuscar.TabIndex = 7;
            this.BTNBuscar.Text = "Buscar";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // progressBarBusca
            // 
            this.progressBarBusca.Location = new System.Drawing.Point(347, 137);
            this.progressBarBusca.Name = "progressBarBusca";
            this.progressBarBusca.Size = new System.Drawing.Size(334, 31);
            this.progressBarBusca.TabIndex = 8;
            // 
            // BTNSairBusca
            // 
            this.BTNSairBusca.Location = new System.Drawing.Point(606, 406);
            this.BTNSairBusca.Name = "BTNSairBusca";
            this.BTNSairBusca.Size = new System.Drawing.Size(75, 23);
            this.BTNSairBusca.TabIndex = 9;
            this.BTNSairBusca.Text = "Sair";
            this.BTNSairBusca.UseVisualStyleBackColor = true;
            this.BTNSairBusca.Click += new System.EventHandler(this.BTNSairBusca_Click);
            // 
            // BuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNSairBusca);
            this.Controls.Add(this.progressBarBusca);
            this.Controls.Add(this.BTNBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxBusca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxTXTbusca);
            this.Name = "BuscarUsuario";
            this.Text = "BuscarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxTXTbusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxBusca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.ProgressBar progressBarBusca;
        private System.Windows.Forms.Button BTNSairBusca;
    }
}