namespace Presentacion
{
    partial class Frm_numericupdwon
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
            this.nupNdia = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupNdia)).BeginInit();
            this.SuspendLayout();
            // 
            // nupNdia
            // 
            this.nupNdia.Location = new System.Drawing.Point(43, 80);
            this.nupNdia.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nupNdia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupNdia.Name = "nupNdia";
            this.nupNdia.ReadOnly = true;
            this.nupNdia.Size = new System.Drawing.Size(120, 20);
            this.nupNdia.TabIndex = 0;
            this.nupNdia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupNdia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nro. de día de la semana";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mostrar día en el texto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(248, 80);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(218, 20);
            this.txtResultado.TabIndex = 3;
            // 
            // Frm_numericupdwon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 212);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupNdia);
            this.Name = "Frm_numericupdwon";
            this.Text = "Frm_numericupdwon";
            ((System.ComponentModel.ISupportInitialize)(this.nupNdia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nupNdia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtResultado;
    }
}