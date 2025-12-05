namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            tblBotones = new TableLayoutPanel();
            btnSuma = new Button();
            btnResultado = new Button();
            btnPunto = new Button();
            btnCero = new Button();
            btnResta = new Button();
            btnTres = new Button();
            btnDos = new Button();
            btnUno = new Button();
            btnMultiplicacion = new Button();
            btnSeis = new Button();
            btnCinco = new Button();
            btnCuatro = new Button();
            btnDivision = new Button();
            btnNueve = new Button();
            btnOcho = new Button();
            btnSiete = new Button();
            btnPorcentaje = new Button();
            btnBorrarTodo = new Button();
            btnCierre = new Button();
            btnApertura = new Button();
            tblBotones.SuspendLayout();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Dock = DockStyle.Top;
            txtDisplay.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(0, 0);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(690, 168);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // tblBotones
            // 
            tblBotones.ColumnCount = 4;
            tblBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblBotones.Controls.Add(btnSuma, 3, 4);
            tblBotones.Controls.Add(btnResultado, 2, 4);
            tblBotones.Controls.Add(btnPunto, 1, 4);
            tblBotones.Controls.Add(btnCero, 0, 4);
            tblBotones.Controls.Add(btnResta, 3, 3);
            tblBotones.Controls.Add(btnTres, 2, 3);
            tblBotones.Controls.Add(btnDos, 1, 3);
            tblBotones.Controls.Add(btnUno, 0, 3);
            tblBotones.Controls.Add(btnMultiplicacion, 3, 2);
            tblBotones.Controls.Add(btnSeis, 2, 2);
            tblBotones.Controls.Add(btnCinco, 1, 2);
            tblBotones.Controls.Add(btnCuatro, 0, 2);
            tblBotones.Controls.Add(btnDivision, 3, 1);
            tblBotones.Controls.Add(btnNueve, 2, 1);
            tblBotones.Controls.Add(btnOcho, 1, 1);
            tblBotones.Controls.Add(btnSiete, 0, 1);
            tblBotones.Controls.Add(btnPorcentaje, 3, 0);
            tblBotones.Controls.Add(btnBorrarTodo, 2, 0);
            tblBotones.Controls.Add(btnCierre, 1, 0);
            tblBotones.Controls.Add(btnApertura, 0, 0);
            tblBotones.Dock = DockStyle.Fill;
            tblBotones.Location = new Point(0, 168);
            tblBotones.Name = "tblBotones";
            tblBotones.RowCount = 5;
            tblBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblBotones.Size = new Size(690, 645);
            tblBotones.TabIndex = 1;
            // 
            // btnSuma
            // 
            btnSuma.Dock = DockStyle.Fill;
            btnSuma.Location = new Point(519, 519);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(168, 123);
            btnSuma.TabIndex = 19;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            // 
            // btnResultado
            // 
            btnResultado.Dock = DockStyle.Fill;
            btnResultado.Location = new Point(347, 519);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(166, 123);
            btnResultado.TabIndex = 18;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            // 
            // btnPunto
            // 
            btnPunto.Dock = DockStyle.Fill;
            btnPunto.Location = new Point(175, 519);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(166, 123);
            btnPunto.TabIndex = 17;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            // 
            // btnCero
            // 
            btnCero.Dock = DockStyle.Fill;
            btnCero.Location = new Point(3, 519);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(166, 123);
            btnCero.TabIndex = 16;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = true;
            // 
            // btnResta
            // 
            btnResta.Dock = DockStyle.Fill;
            btnResta.Location = new Point(519, 390);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(168, 123);
            btnResta.TabIndex = 15;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            // 
            // btnTres
            // 
            btnTres.Dock = DockStyle.Fill;
            btnTres.Location = new Point(347, 390);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(166, 123);
            btnTres.TabIndex = 14;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            // 
            // btnDos
            // 
            btnDos.Dock = DockStyle.Fill;
            btnDos.Location = new Point(175, 390);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(166, 123);
            btnDos.TabIndex = 13;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = true;
            // 
            // btnUno
            // 
            btnUno.Dock = DockStyle.Fill;
            btnUno.Location = new Point(3, 390);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(166, 123);
            btnUno.TabIndex = 12;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.Dock = DockStyle.Fill;
            btnMultiplicacion.Location = new Point(519, 261);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(168, 123);
            btnMultiplicacion.TabIndex = 11;
            btnMultiplicacion.Text = "x";
            btnMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // btnSeis
            // 
            btnSeis.Dock = DockStyle.Fill;
            btnSeis.Location = new Point(347, 261);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(166, 123);
            btnSeis.TabIndex = 10;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            // 
            // btnCinco
            // 
            btnCinco.Dock = DockStyle.Fill;
            btnCinco.Location = new Point(175, 261);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(166, 123);
            btnCinco.TabIndex = 9;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            // 
            // btnCuatro
            // 
            btnCuatro.Dock = DockStyle.Fill;
            btnCuatro.Location = new Point(3, 261);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(166, 123);
            btnCuatro.TabIndex = 8;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = true;
            // 
            // btnDivision
            // 
            btnDivision.Dock = DockStyle.Fill;
            btnDivision.Location = new Point(519, 132);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(168, 123);
            btnDivision.TabIndex = 7;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            // 
            // btnNueve
            // 
            btnNueve.Dock = DockStyle.Fill;
            btnNueve.Location = new Point(347, 132);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(166, 123);
            btnNueve.TabIndex = 6;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = true;
            // 
            // btnOcho
            // 
            btnOcho.Dock = DockStyle.Fill;
            btnOcho.Location = new Point(175, 132);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(166, 123);
            btnOcho.TabIndex = 5;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = true;
            // 
            // btnSiete
            // 
            btnSiete.Dock = DockStyle.Fill;
            btnSiete.Location = new Point(3, 132);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(166, 123);
            btnSiete.TabIndex = 4;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = true;
            // 
            // btnPorcentaje
            // 
            btnPorcentaje.Dock = DockStyle.Fill;
            btnPorcentaje.Location = new Point(519, 3);
            btnPorcentaje.Name = "btnPorcentaje";
            btnPorcentaje.Size = new Size(168, 123);
            btnPorcentaje.TabIndex = 3;
            btnPorcentaje.Text = "%";
            btnPorcentaje.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Dock = DockStyle.Fill;
            btnBorrarTodo.Location = new Point(347, 3);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(166, 123);
            btnBorrarTodo.TabIndex = 2;
            btnBorrarTodo.Text = "C";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // btnCierre
            // 
            btnCierre.Dock = DockStyle.Fill;
            btnCierre.Location = new Point(175, 3);
            btnCierre.Name = "btnCierre";
            btnCierre.Size = new Size(166, 123);
            btnCierre.TabIndex = 1;
            btnCierre.Text = ")";
            btnCierre.UseVisualStyleBackColor = true;
            // 
            // btnApertura
            // 
            btnApertura.Dock = DockStyle.Fill;
            btnApertura.Location = new Point(3, 3);
            btnApertura.Name = "btnApertura";
            btnApertura.Size = new Size(166, 123);
            btnApertura.TabIndex = 0;
            btnApertura.Text = "(";
            btnApertura.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 813);
            Controls.Add(tblBotones);
            Controls.Add(txtDisplay);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            tblBotones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private TableLayoutPanel tblBotones;
        private Button btnSuma;
        private Button btnResultado;
        private Button btnPunto;
        private Button btnCero;
        private Button btnResta;
        private Button btnTres;
        private Button btnDos;
        private Button btnUno;
        private Button btnMultiplicacion;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnCuatro;
        private Button btnDivision;
        private Button btnNueve;
        private Button btnOcho;
        private Button btnSiete;
        private Button btnPorcentaje;
        private Button btnBorrarTodo;
        private Button btnCierre;
        private Button btnApertura;
    }
}
