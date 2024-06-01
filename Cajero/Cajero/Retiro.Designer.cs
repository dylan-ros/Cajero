namespace Cajero
{
    partial class Retiro
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
            this.txt_retiro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cincuenta = new System.Windows.Forms.Button();
            this.btn_doscientos = new System.Windows.Forms.Button();
            this.btn_seiscientos = new System.Windows.Forms.Button();
            this.btn_cien = new System.Windows.Forms.Button();
            this.btn_cuatrocientos = new System.Windows.Forms.Button();
            this.btn_mil = new System.Windows.Forms.Button();
            this.btn_retiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_retiro
            // 
            this.txt_retiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_retiro.Location = new System.Drawing.Point(386, 359);
            this.txt_retiro.Multiline = true;
            this.txt_retiro.Name = "txt_retiro";
            this.txt_retiro.Size = new System.Drawing.Size(228, 35);
            this.txt_retiro.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 35);
            this.label2.TabIndex = 46;
            this.label2.Text = "¿Cuánto quiere Retirar?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 74);
            this.label1.TabIndex = 45;
            this.label1.Text = "Realizar Retiro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_cincuenta
            // 
            this.btn_cincuenta.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cincuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cincuenta.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_cincuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cincuenta.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cincuenta.Location = new System.Drawing.Point(31, 186);
            this.btn_cincuenta.Name = "btn_cincuenta";
            this.btn_cincuenta.Size = new System.Drawing.Size(165, 88);
            this.btn_cincuenta.TabIndex = 49;
            this.btn_cincuenta.Text = "50.00";
            this.btn_cincuenta.UseVisualStyleBackColor = false;
            this.btn_cincuenta.Click += new System.EventHandler(this.OpcionRapida);
            // 
            // btn_doscientos
            // 
            this.btn_doscientos.BackColor = System.Drawing.SystemColors.Control;
            this.btn_doscientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_doscientos.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_doscientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doscientos.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doscientos.Location = new System.Drawing.Point(31, 369);
            this.btn_doscientos.Name = "btn_doscientos";
            this.btn_doscientos.Size = new System.Drawing.Size(165, 88);
            this.btn_doscientos.TabIndex = 50;
            this.btn_doscientos.Text = "200.00";
            this.btn_doscientos.UseVisualStyleBackColor = false;
            this.btn_doscientos.Click += new System.EventHandler(this.OpcionRapida);
            // 
            // btn_seiscientos
            // 
            this.btn_seiscientos.BackColor = System.Drawing.SystemColors.Control;
            this.btn_seiscientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_seiscientos.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_seiscientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seiscientos.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seiscientos.Location = new System.Drawing.Point(31, 565);
            this.btn_seiscientos.Name = "btn_seiscientos";
            this.btn_seiscientos.Size = new System.Drawing.Size(165, 88);
            this.btn_seiscientos.TabIndex = 51;
            this.btn_seiscientos.Text = "600.00";
            this.btn_seiscientos.UseVisualStyleBackColor = false;
            this.btn_seiscientos.Click += new System.EventHandler(this.OpcionRapida);
            // 
            // btn_cien
            // 
            this.btn_cien.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cien.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_cien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cien.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cien.Location = new System.Drawing.Point(823, 186);
            this.btn_cien.Name = "btn_cien";
            this.btn_cien.Size = new System.Drawing.Size(165, 88);
            this.btn_cien.TabIndex = 52;
            this.btn_cien.Text = "100.00";
            this.btn_cien.UseVisualStyleBackColor = false;
            this.btn_cien.Click += new System.EventHandler(this.OpcionRapida);
            // 
            // btn_cuatrocientos
            // 
            this.btn_cuatrocientos.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cuatrocientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cuatrocientos.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_cuatrocientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cuatrocientos.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cuatrocientos.Location = new System.Drawing.Point(823, 369);
            this.btn_cuatrocientos.Name = "btn_cuatrocientos";
            this.btn_cuatrocientos.Size = new System.Drawing.Size(165, 88);
            this.btn_cuatrocientos.TabIndex = 53;
            this.btn_cuatrocientos.Text = "400.00";
            this.btn_cuatrocientos.UseVisualStyleBackColor = false;
            this.btn_cuatrocientos.Click += new System.EventHandler(this.OpcionRapida);
            // 
            // btn_mil
            // 
            this.btn_mil.BackColor = System.Drawing.SystemColors.Control;
            this.btn_mil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_mil.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_mil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mil.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mil.Location = new System.Drawing.Point(823, 565);
            this.btn_mil.Name = "btn_mil";
            this.btn_mil.Size = new System.Drawing.Size(165, 88);
            this.btn_mil.TabIndex = 54;
            this.btn_mil.Text = "1000.00";
            this.btn_mil.UseVisualStyleBackColor = false;
            this.btn_mil.Click += new System.EventHandler(this.OpcionRapida);
            // 
            // btn_retiro
            // 
            this.btn_retiro.BackColor = System.Drawing.SystemColors.Control;
            this.btn_retiro.BackgroundImage = global::Cajero.Properties.Resources.retiro2;
            this.btn_retiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_retiro.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_retiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retiro.Location = new System.Drawing.Point(441, 419);
            this.btn_retiro.Name = "btn_retiro";
            this.btn_retiro.Size = new System.Drawing.Size(127, 73);
            this.btn_retiro.TabIndex = 48;
            this.btn_retiro.UseVisualStyleBackColor = false;
            this.btn_retiro.Click += new System.EventHandler(this.btn_retiro_Click);
            // 
            // Retiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 706);
            this.Controls.Add(this.btn_mil);
            this.Controls.Add(this.btn_cuatrocientos);
            this.Controls.Add(this.btn_cien);
            this.Controls.Add(this.btn_seiscientos);
            this.Controls.Add(this.btn_doscientos);
            this.Controls.Add(this.btn_cincuenta);
            this.Controls.Add(this.btn_retiro);
            this.Controls.Add(this.txt_retiro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Retiro";
            this.Text = "Retiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_retiro;
        private System.Windows.Forms.TextBox txt_retiro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cincuenta;
        private System.Windows.Forms.Button btn_doscientos;
        private System.Windows.Forms.Button btn_seiscientos;
        private System.Windows.Forms.Button btn_cien;
        private System.Windows.Forms.Button btn_cuatrocientos;
        private System.Windows.Forms.Button btn_mil;
    }
}