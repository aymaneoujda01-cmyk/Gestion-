namespace gestion_d_entreprise
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(188, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(188, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 31);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 30);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 2;
            label1.Text = "nom de produit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 138);
            label2.Name = "label2";
            label2.Size = new Size(41, 25);
            label2.TabIndex = 3;
            label2.Text = "prix";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 192);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 4;
            label3.Text = "quantity";
            // 
            // button1
            // 
            button1.Location = new Point(667, 289);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(796, 289);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "modifier";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(667, 355);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 7;
            button3.Text = "supprimer";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(796, 355);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 8;
            button4.Text = "rechercher";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(190, 186);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(243, 31);
            numericUpDown1.TabIndex = 9;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(524, 63);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 10;
            label4.Text = "discription";
            label4.Click += label4_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(641, 57);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(245, 144);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 265);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(633, 193);
            dataGridView1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 71);
            label5.Name = "label5";
            label5.Size = new Size(30, 25);
            label5.TabIndex = 14;
            label5.Text = "ID";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(188, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 33);
            comboBox1.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 503);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(numericUpDown1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private RichTextBox richTextBox1;
        private DataGridView dataGridView1;
        private Label label5;
        private ComboBox comboBox1;
    }
}
