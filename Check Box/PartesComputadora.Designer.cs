namespace Check_Box
{
    partial class PartesComputadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxMouseGamer = new System.Windows.Forms.CheckBox();
            this.checkBoxImpreHp = new System.Windows.Forms.CheckBox();
            this.checkBoxCamWeb = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtoni7 = new System.Windows.Forms.RadioButton();
            this.radioButtoni5 = new System.Windows.Forms.RadioButton();
            this.radioButtoni3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton500GB = new System.Windows.Forms.RadioButton();
            this.radioButton300GB = new System.Windows.Forms.RadioButton();
            this.radioButton80GB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton12GB = new System.Windows.Forms.RadioButton();
            this.radioButton8GB = new System.Windows.Forms.RadioButton();
            this.radioButton4GB = new System.Windows.Forms.RadioButton();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(43, 335);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(85, 37);
            this.btnProcesar.TabIndex = 12;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(43, 261);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(715, 68);
            this.txtResultado.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxMouseGamer);
            this.groupBox4.Controls.Add(this.checkBoxImpreHp);
            this.groupBox4.Controls.Add(this.checkBoxCamWeb);
            this.groupBox4.Location = new System.Drawing.Point(595, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 158);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Accesorios";
            // 
            // checkBoxMouseGamer
            // 
            this.checkBoxMouseGamer.AutoSize = true;
            this.checkBoxMouseGamer.Location = new System.Drawing.Point(21, 108);
            this.checkBoxMouseGamer.Name = "checkBoxMouseGamer";
            this.checkBoxMouseGamer.Size = new System.Drawing.Size(92, 17);
            this.checkBoxMouseGamer.TabIndex = 2;
            this.checkBoxMouseGamer.Text = "Mouse Gamer";
            this.checkBoxMouseGamer.UseVisualStyleBackColor = true;
            // 
            // checkBoxImpreHp
            // 
            this.checkBoxImpreHp.AutoSize = true;
            this.checkBoxImpreHp.Location = new System.Drawing.Point(21, 75);
            this.checkBoxImpreHp.Name = "checkBoxImpreHp";
            this.checkBoxImpreHp.Size = new System.Drawing.Size(87, 17);
            this.checkBoxImpreHp.TabIndex = 1;
            this.checkBoxImpreHp.Text = "Impresora hp";
            this.checkBoxImpreHp.UseVisualStyleBackColor = true;
            // 
            // checkBoxCamWeb
            // 
            this.checkBoxCamWeb.AutoSize = true;
            this.checkBoxCamWeb.Location = new System.Drawing.Point(21, 36);
            this.checkBoxCamWeb.Name = "checkBoxCamWeb";
            this.checkBoxCamWeb.Size = new System.Drawing.Size(85, 17);
            this.checkBoxCamWeb.TabIndex = 0;
            this.checkBoxCamWeb.Text = "Camara web";
            this.checkBoxCamWeb.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtoni7);
            this.groupBox3.Controls.Add(this.radioButtoni5);
            this.groupBox3.Controls.Add(this.radioButtoni3);
            this.groupBox3.Location = new System.Drawing.Point(395, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 158);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Procesador";
            // 
            // radioButtoni7
            // 
            this.radioButtoni7.AutoSize = true;
            this.radioButtoni7.Location = new System.Drawing.Point(20, 108);
            this.radioButtoni7.Name = "radioButtoni7";
            this.radioButtoni7.Size = new System.Drawing.Size(97, 17);
            this.radioButtoni7.TabIndex = 2;
            this.radioButtoni7.TabStop = true;
            this.radioButtoni7.Text = "Intel Pentium i7";
            this.radioButtoni7.UseVisualStyleBackColor = true;
            // 
            // radioButtoni5
            // 
            this.radioButtoni5.AutoSize = true;
            this.radioButtoni5.Location = new System.Drawing.Point(20, 75);
            this.radioButtoni5.Name = "radioButtoni5";
            this.radioButtoni5.Size = new System.Drawing.Size(97, 17);
            this.radioButtoni5.TabIndex = 1;
            this.radioButtoni5.TabStop = true;
            this.radioButtoni5.Text = "Intel Pentium i5";
            this.radioButtoni5.UseVisualStyleBackColor = true;
            // 
            // radioButtoni3
            // 
            this.radioButtoni3.AutoSize = true;
            this.radioButtoni3.Location = new System.Drawing.Point(20, 36);
            this.radioButtoni3.Name = "radioButtoni3";
            this.radioButtoni3.Size = new System.Drawing.Size(97, 17);
            this.radioButtoni3.TabIndex = 0;
            this.radioButtoni3.TabStop = true;
            this.radioButtoni3.Text = "Intel Pentium i3";
            this.radioButtoni3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton500GB);
            this.groupBox2.Controls.Add(this.radioButton300GB);
            this.groupBox2.Controls.Add(this.radioButton80GB);
            this.groupBox2.Location = new System.Drawing.Point(207, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 158);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Disco Duro";
            // 
            // radioButton500GB
            // 
            this.radioButton500GB.AutoSize = true;
            this.radioButton500GB.Location = new System.Drawing.Point(20, 108);
            this.radioButton500GB.Name = "radioButton500GB";
            this.radioButton500GB.Size = new System.Drawing.Size(121, 17);
            this.radioButton500GB.TabIndex = 2;
            this.radioButton500GB.TabStop = true;
            this.radioButton500GB.Text = "500 GB Disco solido";
            this.radioButton500GB.UseVisualStyleBackColor = true;
            // 
            // radioButton300GB
            // 
            this.radioButton300GB.AutoSize = true;
            this.radioButton300GB.Location = new System.Drawing.Point(20, 75);
            this.radioButton300GB.Name = "radioButton300GB";
            this.radioButton300GB.Size = new System.Drawing.Size(121, 17);
            this.radioButton300GB.TabIndex = 1;
            this.radioButton300GB.TabStop = true;
            this.radioButton300GB.Text = "300 GB Disco solido";
            this.radioButton300GB.UseVisualStyleBackColor = true;
            // 
            // radioButton80GB
            // 
            this.radioButton80GB.AutoSize = true;
            this.radioButton80GB.Location = new System.Drawing.Point(20, 36);
            this.radioButton80GB.Name = "radioButton80GB";
            this.radioButton80GB.Size = new System.Drawing.Size(115, 17);
            this.radioButton80GB.TabIndex = 0;
            this.radioButton80GB.TabStop = true;
            this.radioButton80GB.Text = "80 GB Disco solido";
            this.radioButton80GB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton12GB);
            this.groupBox1.Controls.Add(this.radioButton8GB);
            this.groupBox1.Controls.Add(this.radioButton4GB);
            this.groupBox1.Location = new System.Drawing.Point(43, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 158);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Memoria RAM";
            // 
            // radioButton12GB
            // 
            this.radioButton12GB.AutoSize = true;
            this.radioButton12GB.Location = new System.Drawing.Point(16, 108);
            this.radioButton12GB.Name = "radioButton12GB";
            this.radioButton12GB.Size = new System.Drawing.Size(52, 17);
            this.radioButton12GB.TabIndex = 2;
            this.radioButton12GB.TabStop = true;
            this.radioButton12GB.Text = "12GB";
            this.radioButton12GB.UseVisualStyleBackColor = true;
            // 
            // radioButton8GB
            // 
            this.radioButton8GB.AutoSize = true;
            this.radioButton8GB.Location = new System.Drawing.Point(16, 75);
            this.radioButton8GB.Name = "radioButton8GB";
            this.radioButton8GB.Size = new System.Drawing.Size(46, 17);
            this.radioButton8GB.TabIndex = 1;
            this.radioButton8GB.TabStop = true;
            this.radioButton8GB.Text = "8GB";
            this.radioButton8GB.UseVisualStyleBackColor = true;
            // 
            // radioButton4GB
            // 
            this.radioButton4GB.AutoSize = true;
            this.radioButton4GB.Location = new System.Drawing.Point(16, 36);
            this.radioButton4GB.Name = "radioButton4GB";
            this.radioButton4GB.Size = new System.Drawing.Size(46, 17);
            this.radioButton4GB.TabIndex = 0;
            this.radioButton4GB.TabStop = true;
            this.radioButton4GB.Text = "4GB";
            this.radioButton4GB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxMouseGamer;
        private System.Windows.Forms.CheckBox checkBoxImpreHp;
        private System.Windows.Forms.CheckBox checkBoxCamWeb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtoni7;
        private System.Windows.Forms.RadioButton radioButtoni5;
        private System.Windows.Forms.RadioButton radioButtoni3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton500GB;
        private System.Windows.Forms.RadioButton radioButton300GB;
        private System.Windows.Forms.RadioButton radioButton80GB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton12GB;
        private System.Windows.Forms.RadioButton radioButton8GB;
        private System.Windows.Forms.RadioButton radioButton4GB;
    }
}

