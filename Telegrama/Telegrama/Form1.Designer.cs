namespace Telegrama
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
            button1 = new Button();
            label2 = new Label();
            text = new Label();
            chkUrgente = new CheckBox();
            txtPrecio = new TextBox();
            txt = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(573, 330);
            button1.Name = "button1";
            button1.Size = new Size(137, 53);
            button1.TabIndex = 11;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalcularPrecio_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 368);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 10;
            label2.Text = "Coste:";
            // 
            // text
            // 
            text.AutoSize = true;
            text.BackColor = Color.Transparent;
            text.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text.Location = new Point(91, 62);
            text.Name = "text";
            text.Size = new Size(39, 15);
            text.TabIndex = 9;
            text.Text = "Texto";
            // 
            // chkUrgente
            // 
            chkUrgente.AutoSize = true;
            chkUrgente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkUrgente.Location = new Point(91, 305);
            chkUrgente.Name = "chkUrgente";
            chkUrgente.Size = new Size(73, 19);
            chkUrgente.TabIndex = 8;
            chkUrgente.Text = "Urgente?";
            chkUrgente.UseVisualStyleBackColor = true;
            chkUrgente.CheckedChanged += chkUrgente_CheckedChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(157, 365);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(183, 23);
            txtPrecio.TabIndex = 7;
            // 
            // txt
            // 
            txt.Location = new Point(91, 96);
            txt.Multiline = true;
            txt.Name = "txt";
            txt.Size = new Size(619, 165);
            txt.TabIndex = 6;
            txt.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(text);
            Controls.Add(chkUrgente);
            Controls.Add(txtPrecio);
            Controls.Add(txt);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label text;
        private CheckBox chkUrgente;
        private TextBox txtPrecio;
        private TextBox txt;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    

}
