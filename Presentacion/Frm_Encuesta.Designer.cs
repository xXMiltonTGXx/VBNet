namespace Presentacion
{
    partial class Frm_Encuesta
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
            this.chkVF = new System.Windows.Forms.CheckBox();
            this.chkCsharp = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnProcesar = new System.Windows.Forms.Button();
            this.chkJava = new System.Windows.Forms.CheckBox();
            this.chkVBN = new System.Windows.Forms.CheckBox();
            this.rdbPresencial = new System.Windows.Forms.RadioButton();
            this.rdbVirtual = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkVF
            // 
            this.chkVF.AutoSize = true;
            this.chkVF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVF.Location = new System.Drawing.Point(54, 145);
            this.chkVF.Name = "chkVF";
            this.chkVF.Size = new System.Drawing.Size(149, 26);
            this.chkVF.TabIndex = 0;
            this.chkVF.Text = "Visual Fox Pro";
            this.chkVF.UseVisualStyleBackColor = true;
            // 
            // chkCsharp
            // 
            this.chkCsharp.AutoSize = true;
            this.chkCsharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCsharp.Location = new System.Drawing.Point(54, 191);
            this.chkCsharp.Name = "chkCsharp";
            this.chkCsharp.Size = new System.Drawing.Size(55, 26);
            this.chkCsharp.TabIndex = 1;
            this.chkCsharp.Text = "C#";
            this.chkCsharp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(49, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "CURSOS DISPONIBLES EN PROMOCION";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(338, 389);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(503, 152);
            this.txtResultado.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "RESULTADO CURSOS SELECCIONADOS:";
            // 
            // BtnProcesar
            // 
            this.BtnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProcesar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BtnProcesar.Location = new System.Drawing.Point(54, 400);
            this.BtnProcesar.Name = "BtnProcesar";
            this.BtnProcesar.Size = new System.Drawing.Size(222, 125);
            this.BtnProcesar.TabIndex = 7;
            this.BtnProcesar.Text = "PROCESAR";
            this.BtnProcesar.UseVisualStyleBackColor = true;
            this.BtnProcesar.Click += new System.EventHandler(this.BtnProcesar_Click);
            // 
            // chkJava
            // 
            this.chkJava.AutoSize = true;
            this.chkJava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJava.Location = new System.Drawing.Point(54, 279);
            this.chkJava.Name = "chkJava";
            this.chkJava.Size = new System.Drawing.Size(70, 26);
            this.chkJava.TabIndex = 9;
            this.chkJava.Text = "Java";
            this.chkJava.UseVisualStyleBackColor = true;
            // 
            // chkVBN
            // 
            this.chkVBN.AutoSize = true;
            this.chkVBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVBN.Location = new System.Drawing.Point(54, 233);
            this.chkVBN.Name = "chkVBN";
            this.chkVBN.Size = new System.Drawing.Size(89, 26);
            this.chkVBN.TabIndex = 8;
            this.chkVBN.Text = "VB Net";
            this.chkVBN.UseVisualStyleBackColor = true;
            // 
            // rdbPresencial
            // 
            this.rdbPresencial.AutoSize = true;
            this.rdbPresencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPresencial.Location = new System.Drawing.Point(425, 245);
            this.rdbPresencial.Name = "rdbPresencial";
            this.rdbPresencial.Size = new System.Drawing.Size(115, 26);
            this.rdbPresencial.TabIndex = 10;
            this.rdbPresencial.TabStop = true;
            this.rdbPresencial.Text = "Presencial";
            this.rdbPresencial.UseVisualStyleBackColor = true;
            // 
            // rdbVirtual
            // 
            this.rdbVirtual.AutoSize = true;
            this.rdbVirtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVirtual.Location = new System.Drawing.Point(641, 245);
            this.rdbVirtual.Name = "rdbVirtual";
            this.rdbVirtual.Size = new System.Drawing.Size(82, 26);
            this.rdbVirtual.TabIndex = 11;
            this.rdbVirtual.TabStop = true;
            this.rdbVirtual.Text = "Virtual";
            this.rdbVirtual.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(398, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(403, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "¿En que escenario de aprendizaje te gusta?";
            // 
            // Frm_Encuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbVirtual);
            this.Controls.Add(this.rdbPresencial);
            this.Controls.Add(this.chkJava);
            this.Controls.Add(this.chkVBN);
            this.Controls.Add(this.BtnProcesar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkCsharp);
            this.Controls.Add(this.chkVF);
            this.Name = "Frm_Encuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENCUESTA DE CURSOS DISPONIBLES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkVF;
        private System.Windows.Forms.CheckBox chkCsharp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnProcesar;
        private System.Windows.Forms.CheckBox chkJava;
        private System.Windows.Forms.CheckBox chkVBN;
        private System.Windows.Forms.RadioButton rdbPresencial;
        private System.Windows.Forms.RadioButton rdbVirtual;
        private System.Windows.Forms.Label label3;
    }
}