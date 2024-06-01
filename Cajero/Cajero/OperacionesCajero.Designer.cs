namespace Cajero
{
    partial class OperacionesCajero
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_consultaSaldo = new System.Windows.Forms.Button();
            this.btn_retiro = new System.Windows.Forms.Button();
            this.btn_deposito = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Que operación desea realizar...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 35);
            this.label4.TabIndex = 16;
            this.label4.Text = "Consulta de Saldo ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 35);
            this.label3.TabIndex = 15;
            this.label3.Text = "Retiro";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "Deposito";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_consultaSaldo
            // 
            this.btn_consultaSaldo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_consultaSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultaSaldo.Location = new System.Drawing.Point(372, 544);
            this.btn_consultaSaldo.Name = "btn_consultaSaldo";
            this.btn_consultaSaldo.Size = new System.Drawing.Size(191, 86);
            this.btn_consultaSaldo.TabIndex = 13;
            this.btn_consultaSaldo.UseVisualStyleBackColor = true;
            // 
            // btn_retiro
            // 
            this.btn_retiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_retiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retiro.Location = new System.Drawing.Point(372, 360);
            this.btn_retiro.Name = "btn_retiro";
            this.btn_retiro.Size = new System.Drawing.Size(191, 86);
            this.btn_retiro.TabIndex = 12;
            this.btn_retiro.UseVisualStyleBackColor = true;
            // 
            // btn_deposito
            // 
            this.btn_deposito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_deposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deposito.Location = new System.Drawing.Point(372, 182);
            this.btn_deposito.Name = "btn_deposito";
            this.btn_deposito.Size = new System.Drawing.Size(191, 86);
            this.btn_deposito.TabIndex = 11;
            this.btn_deposito.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(899, 630);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 58);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OperacionesCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 700);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_consultaSaldo);
            this.Controls.Add(this.btn_retiro);
            this.Controls.Add(this.btn_deposito);
            this.Controls.Add(this.label1);
            this.Name = "OperacionesCajero";
            this.Text = "OperacionesCajero";
            this.Load += new System.EventHandler(this.OperacionesCajero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_consultaSaldo;
        private System.Windows.Forms.Button btn_retiro;
        private System.Windows.Forms.Button btn_deposito;
        private System.Windows.Forms.Button button1;
    }
}