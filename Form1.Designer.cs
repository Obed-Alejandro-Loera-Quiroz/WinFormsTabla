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
            PanelPrincipal = new Panel();
            label1 = new Label();
            richTextBoxresultados = new RichTextBox();
            buttonver = new Button();
            textBoxnum = new TextBox();
            labelnumero = new Label();
            labelnombre = new Label();
            PanelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // PanelPrincipal
            // 
            PanelPrincipal.BackColor = SystemColors.GradientInactiveCaption;
            PanelPrincipal.Controls.Add(labelnombre);
            PanelPrincipal.Controls.Add(label1);
            PanelPrincipal.Controls.Add(richTextBoxresultados);
            PanelPrincipal.Controls.Add(buttonver);
            PanelPrincipal.Controls.Add(textBoxnum);
            PanelPrincipal.Controls.Add(labelnumero);
            PanelPrincipal.Location = new Point(2, 3);
            PanelPrincipal.Name = "PanelPrincipal";
            PanelPrincipal.Size = new Size(794, 447);
            PanelPrincipal.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Eras Bold ITC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 51);
            label1.Name = "label1";
            label1.Size = new Size(189, 22);
            label1.TabIndex = 5;
            label1.Text = "Tabla de Multiplcar";
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.Font = new Font("Eras Medium ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxresultados.Location = new Point(368, 130);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(218, 238);
            richTextBoxresultados.TabIndex = 4;
            richTextBoxresultados.Text = "";
            // 
            // buttonver
            // 
            buttonver.BackColor = SystemColors.ButtonFace;
            buttonver.Font = new Font("Eras Medium ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonver.Location = new Point(114, 196);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(94, 29);
            buttonver.TabIndex = 3;
            buttonver.Text = "Ver tabla";
            buttonver.UseVisualStyleBackColor = false;
            buttonver.Click += buttonver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Font = new Font("Eras Medium ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxnum.Location = new Point(95, 154);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(140, 25);
            textBoxnum.TabIndex = 2;
            textBoxnum.TextAlign = HorizontalAlignment.Center;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.Font = new Font("Eras Medium ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelnumero.Location = new Point(95, 118);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(140, 18);
            labelnumero.TabIndex = 1;
            labelnumero.Text = "¿Cual tabla quieres?";
            // 
            // labelnombre
            // 
            labelnombre.AutoSize = true;
            labelnombre.Font = new Font("Eras Medium ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelnombre.Location = new Point(23, 400);
            labelnombre.Name = "labelnombre";
            labelnombre.Size = new Size(266, 18);
            labelnombre.TabIndex = 6;
            labelnombre.Text = "Nombre: Obed Alejandro Loera Quiroz";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelPrincipal);
            Name = "Form1";
            Text = "Form1";
            PanelPrincipal.ResumeLayout(false);
            PanelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelPrincipal;
        private Label labelnumero;
        private Button buttonver;
        private TextBox textBoxnum;
        private RichTextBox richTextBoxresultados;
        private Label label1;
        private Label labelnombre;
    }
}
