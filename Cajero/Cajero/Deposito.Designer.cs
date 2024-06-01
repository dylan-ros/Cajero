namespace Cajero
{
    partial class Deposito
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
            this.txt_deposito = new System.Windows.Forms.TextBox();
            this.btn_depositar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 74);
            this.label1.TabIndex = 32;
            this.label1.Text = "Realizar Deposito";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 35);
            this.label2.TabIndex = 37;
            this.label2.Text = "¿Cuánto quiere depositar?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_deposito
            // 
            this.txt_deposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deposito.Location = new System.Drawing.Point(374, 289);
            this.txt_deposito.Multiline = true;
            this.txt_deposito.Name = "txt_deposito";
            this.txt_deposito.Size = new System.Drawing.Size(228, 35);
            this.txt_deposito.TabIndex = 38;
            // 
            // btn_depositar
            // 
            this.btn_depositar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_depositar.BackgroundImage = global::Cajero.Properties.Resources.depo;
            this.btn_depositar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_depositar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_depositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_depositar.Location = new System.Drawing.Point(429, 349);
            this.btn_depositar.Name = "btn_depositar";
            this.btn_depositar.Size = new System.Drawing.Size(127, 73);
            this.btn_depositar.TabIndex = 44;
            this.btn_depositar.UseVisualStyleBackColor = false;
            this.btn_depositar.Click += new System.EventHandler(this.btn_depositar_Click);
            // 
            // Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.btn_depositar);
            this.Controls.Add(this.txt_deposito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Deposito";
            this.Text = "Deposito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_deposito;
        private System.Windows.Forms.Button btn_depositar;
    }
}