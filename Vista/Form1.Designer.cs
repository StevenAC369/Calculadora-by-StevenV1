namespace Vista
{
    partial class CalculadoraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraForm));
            this.ListaBoxHistorial = new System.Windows.Forms.ListBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.btn_igual_resultado = new System.Windows.Forms.Button();
            this.btn_punto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.btn_restar = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn_sumar = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.bttn_dividir = new System.Windows.Forms.Button();
            this.btn_residuo = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.operacione = new System.Windows.Forms.TextBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaBoxHistorial
            // 
            this.ListaBoxHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ListaBoxHistorial.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaBoxHistorial.FormattingEnabled = true;
            this.ListaBoxHistorial.ItemHeight = 22;
            this.ListaBoxHistorial.Location = new System.Drawing.Point(285, 26);
            this.ListaBoxHistorial.Name = "ListaBoxHistorial";
            this.ListaBoxHistorial.Size = new System.Drawing.Size(381, 356);
            this.ListaBoxHistorial.TabIndex = 93;
            // 
            // resultado
            // 
            this.resultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(27)))));
            this.resultado.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.resultado.ForeColor = System.Drawing.SystemColors.Menu;
            this.resultado.Location = new System.Drawing.Point(17, 17);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(244, 32);
            this.resultado.TabIndex = 92;
            // 
            // btn_igual_resultado
            // 
            this.btn_igual_resultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.btn_igual_resultado.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.btn_igual_resultado.Location = new System.Drawing.Point(205, 333);
            this.btn_igual_resultado.Name = "btn_igual_resultado";
            this.btn_igual_resultado.Size = new System.Drawing.Size(56, 49);
            this.btn_igual_resultado.TabIndex = 91;
            this.btn_igual_resultado.Text = "=";
            this.btn_igual_resultado.UseVisualStyleBackColor = false;
            this.btn_igual_resultado.Click += new System.EventHandler(this.btn_igual_resultado_Click);
            // 
            // btn_punto
            // 
            this.btn_punto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(175)))));
            this.btn_punto.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.btn_punto.Location = new System.Drawing.Point(143, 333);
            this.btn_punto.Name = "btn_punto";
            this.btn_punto.Size = new System.Drawing.Size(56, 49);
            this.btn_punto.TabIndex = 90;
            this.btn_punto.Text = ".";
            this.btn_punto.UseVisualStyleBackColor = false;
            this.btn_punto.Click += new System.EventHandler(this.btn_punto_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(227)))), ((int)(((byte)(161)))));
            this.btn0.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.btn0.Location = new System.Drawing.Point(79, 333);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(56, 49);
            this.btn0.TabIndex = 89;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.button18.Location = new System.Drawing.Point(17, 333);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(56, 49);
            this.button18.TabIndex = 88;
            this.button18.Text = "+/-";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // btn_restar
            // 
            this.btn_restar.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.btn_restar.Location = new System.Drawing.Point(205, 278);
            this.btn_restar.Name = "btn_restar";
            this.btn_restar.Size = new System.Drawing.Size(56, 49);
            this.btn_restar.TabIndex = 87;
            this.btn_restar.Text = "-";
            this.btn_restar.UseVisualStyleBackColor = true;
            this.btn_restar.Click += new System.EventHandler(this.btn_restar_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(227)))), ((int)(((byte)(161)))));
            this.btn3.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.btn3.Location = new System.Drawing.Point(143, 278);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(56, 49);
            this.btn3.TabIndex = 86;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(227)))), ((int)(((byte)(161)))));
            this.btn2.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.btn2.Location = new System.Drawing.Point(79, 278);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(56, 49);
            this.btn2.TabIndex = 85;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(227)))), ((int)(((byte)(161)))));
            this.btn1.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.btn1.Location = new System.Drawing.Point(17, 278);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(56, 49);
            this.btn1.TabIndex = 84;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn_sumar
            // 
            this.btn_sumar.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.btn_sumar.Location = new System.Drawing.Point(205, 223);
            this.btn_sumar.Name = "btn_sumar";
            this.btn_sumar.Size = new System.Drawing.Size(56, 49);
            this.btn_sumar.TabIndex = 83;
            this.btn_sumar.Text = "+";
            this.btn_sumar.UseVisualStyleBackColor = true;
            this.btn_sumar.Click += new System.EventHandler(this.btn_sumar_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(227)))), ((int)(((byte)(161)))));
            this.btn6.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.btn6.Location = new System.Drawing.Point(143, 223);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(56, 49);
            this.btn6.TabIndex = 82;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(227)))), ((int)(((byte)(161)))));
            this.btn5.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.btn5.Location = new System.Drawing.Point(79, 223);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(56, 49);
            this.btn5.TabIndex = 81;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(227)))), ((int)(((byte)(161)))));
            this.btn4.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.btn4.Location = new System.Drawing.Point(17, 223);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(56, 49);
            this.btn4.TabIndex = 80;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplicar.Location = new System.Drawing.Point(205, 168);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(56, 49);
            this.btn_multiplicar.TabIndex = 79;
            this.btn_multiplicar.Text = "*";
            this.btn_multiplicar.UseVisualStyleBackColor = true;
            this.btn_multiplicar.Click += new System.EventHandler(this.btn_multiplicar_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(227)))), ((int)(((byte)(161)))));
            this.btn9.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(143, 168);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(56, 49);
            this.btn9.TabIndex = 78;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(227)))), ((int)(((byte)(161)))));
            this.btn8.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(79, 168);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(56, 49);
            this.btn8.TabIndex = 77;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(227)))), ((int)(((byte)(161)))));
            this.btn7.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(17, 168);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(56, 49);
            this.btn7.TabIndex = 76;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // bttn_dividir
            // 
            this.bttn_dividir.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_dividir.Location = new System.Drawing.Point(205, 113);
            this.bttn_dividir.Name = "bttn_dividir";
            this.bttn_dividir.Size = new System.Drawing.Size(56, 49);
            this.bttn_dividir.TabIndex = 75;
            this.bttn_dividir.Text = "/";
            this.bttn_dividir.UseVisualStyleBackColor = true;
            this.bttn_dividir.Click += new System.EventHandler(this.bttn_dividir_Click);
            // 
            // btn_residuo
            // 
            this.btn_residuo.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_residuo.Location = new System.Drawing.Point(143, 113);
            this.btn_residuo.Name = "btn_residuo";
            this.btn_residuo.Size = new System.Drawing.Size(56, 49);
            this.btn_residuo.TabIndex = 74;
            this.btn_residuo.Text = "%";
            this.btn_residuo.UseVisualStyleBackColor = true;
            this.btn_residuo.Click += new System.EventHandler(this.btn_residuo_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(139)))), ((int)(((byte)(168)))));
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(79, 113);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(56, 49);
            this.btn_clear.TabIndex = 73;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // operacione
            // 
            this.operacione.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operacione.Location = new System.Drawing.Point(17, 66);
            this.operacione.Name = "operacione";
            this.operacione.Size = new System.Drawing.Size(244, 32);
            this.operacione.TabIndex = 72;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.btn_eliminar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(17, 113);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(56, 49);
            this.btn_eliminar.TabIndex = 71;
            this.btn_eliminar.Text = "<<";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // CalculadoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(695, 401);
            this.Controls.Add(this.ListaBoxHistorial);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.btn_igual_resultado);
            this.Controls.Add(this.btn_punto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.btn_restar);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn_sumar);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn_multiplicar);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.bttn_dividir);
            this.Controls.Add(this.btn_residuo);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.operacione);
            this.Controls.Add(this.btn_eliminar);
            this.Name = "CalculadoraForm";
            this.Text = "Calculadora by Steven";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListaBoxHistorial;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button btn_igual_resultado;
        private System.Windows.Forms.Button btn_punto;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button btn_restar;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn_sumar;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn_multiplicar;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button bttn_dividir;
        private System.Windows.Forms.Button btn_residuo;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox operacione;
        private System.Windows.Forms.Button btn_eliminar;
    }
}

