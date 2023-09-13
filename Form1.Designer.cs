namespace FormComplejos_G2_2024_1
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
            this.txtbReal1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbImaginario1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSimbolo = new System.Windows.Forms.Label();
            this.txtbReal2 = new System.Windows.Forms.TextBox();
            this.txtbImaginario2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSuma = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnConjugar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbReal1
            // 
            this.txtbReal1.Location = new System.Drawing.Point(46, 164);
            this.txtbReal1.Name = "txtbReal1";
            this.txtbReal1.Size = new System.Drawing.Size(100, 20);
            this.txtbReal1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Complejo1";
            // 
            // txtbImaginario1
            // 
            this.txtbImaginario1.Location = new System.Drawing.Point(189, 164);
            this.txtbImaginario1.Name = "txtbImaginario1";
            this.txtbImaginario1.Size = new System.Drawing.Size(100, 20);
            this.txtbImaginario1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "i";
            // 
            // lbSimbolo
            // 
            this.lbSimbolo.AutoSize = true;
            this.lbSimbolo.Location = new System.Drawing.Point(380, 167);
            this.lbSimbolo.Name = "lbSimbolo";
            this.lbSimbolo.Size = new System.Drawing.Size(13, 13);
            this.lbSimbolo.TabIndex = 1;
            this.lbSimbolo.Text = "+";
            // 
            // txtbReal2
            // 
            this.txtbReal2.Location = new System.Drawing.Point(450, 164);
            this.txtbReal2.Name = "txtbReal2";
            this.txtbReal2.Size = new System.Drawing.Size(100, 20);
            this.txtbReal2.TabIndex = 0;
            // 
            // txtbImaginario2
            // 
            this.txtbImaginario2.Location = new System.Drawing.Point(593, 164);
            this.txtbImaginario2.Name = "txtbImaginario2";
            this.txtbImaginario2.Size = new System.Drawing.Size(100, 20);
            this.txtbImaginario2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(715, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(9, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "i";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(784, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Complejo2";
            // 
            // lbSuma
            // 
            this.lbSuma.AutoSize = true;
            this.lbSuma.Location = new System.Drawing.Point(846, 167);
            this.lbSuma.Name = "lbSuma";
            this.lbSuma.Size = new System.Drawing.Size(27, 13);
            this.lbSuma.TabIndex = 1;
            this.lbSuma.Text = "0+0i";
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(198, 226);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 37);
            this.btnSumar.TabIndex = 2;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnConjugar
            // 
            this.btnConjugar.Location = new System.Drawing.Point(438, 226);
            this.btnConjugar.Name = "btnConjugar";
            this.btnConjugar.Size = new System.Drawing.Size(75, 37);
            this.btnConjugar.TabIndex = 2;
            this.btnConjugar.Text = "Conjugar";
            this.btnConjugar.UseVisualStyleBackColor = true;
            this.btnConjugar.Click += new System.EventHandler(this.btnConjugar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(565, 226);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 37);
            this.btnMultiplicar.TabIndex = 2;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(314, 226);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(75, 37);
            this.btnRestar.TabIndex = 2;
            this.btnRestar.Text = "Restar";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 338);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnConjugar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.lbSuma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbSimbolo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbImaginario2);
            this.Controls.Add(this.txtbImaginario1);
            this.Controls.Add(this.txtbReal2);
            this.Controls.Add(this.txtbReal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbReal1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbImaginario1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSimbolo;
        private System.Windows.Forms.TextBox txtbReal2;
        private System.Windows.Forms.TextBox txtbImaginario2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbSuma;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnConjugar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnRestar;
    }
}

