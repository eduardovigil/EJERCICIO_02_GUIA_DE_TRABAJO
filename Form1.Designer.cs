
namespace EJERCICIO_02_GUIA_DE_TRABAJO
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.txtisbn = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtmonstar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIBRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo del Libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "ISBN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero de paginas";
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(290, 45);
            this.txttitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(316, 27);
            this.txttitulo.TabIndex = 5;
            // 
            // txtautor
            // 
            this.txtautor.Location = new System.Drawing.Point(290, 108);
            this.txtautor.Margin = new System.Windows.Forms.Padding(4);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(316, 27);
            this.txtautor.TabIndex = 6;
            // 
            // txtisbn
            // 
            this.txtisbn.Location = new System.Drawing.Point(290, 178);
            this.txtisbn.Margin = new System.Windows.Forms.Padding(4);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(316, 27);
            this.txtisbn.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtnumero);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtisbn);
            this.groupBox1.Controls.Add(this.txttitulo);
            this.groupBox1.Controls.Add(this.txtautor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(33, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(922, 298);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del libro";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(705, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 41);
            this.button2.TabIndex = 10;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(705, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(290, 236);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(316, 27);
            this.txtnumero.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 45);
            this.button3.TabIndex = 10;
            this.button3.Text = "Monstar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtmonstar
            // 
            this.txtmonstar.Location = new System.Drawing.Point(278, 363);
            this.txtmonstar.Multiline = true;
            this.txtmonstar.Name = "txtmonstar";
            this.txtmonstar.Size = new System.Drawing.Size(677, 170);
            this.txtmonstar.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 562);
            this.Controls.Add(this.txtmonstar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.TextBox txtisbn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtmonstar;
    }
}

