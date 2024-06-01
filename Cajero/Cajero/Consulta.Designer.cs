namespace Cajero
{
    partial class Consulta
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
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_saldo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_saldo
            // 
            this.txt_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_saldo.Location = new System.Drawing.Point(386, 403);
            this.txt_saldo.Multiline = true;
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(228, 35);
            this.txt_saldo.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 35);
            this.label2.TabIndex = 46;
            this.label2.Text = "Saldo Actual ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 74);
            this.label1.TabIndex = 45;
            this.label1.Text = "Consulta de Saldo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_saldo
            // 
            this.btn_saldo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_saldo.BackgroundImage = global::Cajero.Properties.Resources.saldo2;
            this.btn_saldo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_saldo.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_saldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saldo.Location = new System.Drawing.Point(441, 463);
            this.btn_saldo.Name = "btn_saldo";
            this.btn_saldo.Size = new System.Drawing.Size(127, 73);
            this.btn_saldo.TabIndex = 48;
            this.btn_saldo.UseVisualStyleBackColor = false;
            this.btn_saldo.Click += new System.EventHandler(this.btn_saldo_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.btn_saldo);
            this.Controls.Add(this.txt_saldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_saldo;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}