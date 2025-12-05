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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private TableLayoutPanel tblBotones;
    }
}
