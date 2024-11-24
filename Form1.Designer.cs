namespace WinFormsTabla
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
            panelPrincipal = new Panel();
            richTextBoxresultados = new RichTextBox();
            buttonver = new Button();
            textBoxnum = new TextBox();
            labelnumero = new Label();
            labelTitulo = new Label();
            label1 = new Label();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(0, 192, 192);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(richTextBoxresultados);
            panelPrincipal.Controls.Add(buttonver);
            panelPrincipal.Controls.Add(textBoxnum);
            panelPrincipal.Controls.Add(labelnumero);
            panelPrincipal.Controls.Add(labelTitulo);
            panelPrincipal.Location = new Point(2, 6);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(792, 432);
            panelPrincipal.TabIndex = 0;
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.Location = new Point(213, 75);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(179, 224);
            richTextBoxresultados.TabIndex = 4;
            richTextBoxresultados.Text = "";
            // 
            // buttonver
            // 
            buttonver.Location = new Point(63, 143);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(80, 25);
            buttonver.TabIndex = 3;
            buttonver.Text = "ver tabla";
            buttonver.UseVisualStyleBackColor = true;
            buttonver.Click += buttonver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Location = new Point(61, 110);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(105, 23);
            textBoxnum.TabIndex = 2;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.Location = new Point(61, 82);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(111, 15);
            labelnumero.TabIndex = 1;
            labelnumero.Text = "¿Cual tabla quieres?";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(59, 42);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(110, 15);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Tabla de Multiplicar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 21);
            label1.Name = "label1";
            label1.Size = new Size(271, 23);
            label1.TabIndex = 5;
            label1.Text = "HUGO VAZQUEZ HERNANDEZ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = "Form1";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelnumero;
        private Label labelTitulo;
        private RichTextBox richTextBoxresultados;
        private Button buttonver;
        private TextBox textBoxnum;
        private Label label1;
    }
}
