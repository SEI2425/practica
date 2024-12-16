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
            txtPrecio = new TextBox();
            txt = new TextBox();
            radOrd = new RadioButton();
            radUrg = new RadioButton();
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
            // radOrd
            // 
            radOrd.AutoSize = true;
            radOrd.Location = new Point(91, 300);
            radOrd.Name = "radOrd";
            radOrd.Size = new Size(75, 19);
            radOrd.TabIndex = 12;
            radOrd.TabStop = true;
            radOrd.Text = "Ordinario";
            radOrd.UseVisualStyleBackColor = true;
            radOrd.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radUrg
            // 
            radUrg.AutoSize = true;
            radUrg.Location = new Point(191, 300);
            radUrg.Name = "radUrg";
            radUrg.Size = new Size(67, 19);
            radUrg.TabIndex = 13;
            radUrg.TabStop = true;
            radUrg.Text = "Urgente";
            radUrg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radUrg);
            Controls.Add(radOrd);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(text);
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
        private TextBox txtPrecio;
        private TextBox txt;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private RadioButton radOrd;
        private RadioButton radUrg;
    }

    

}
