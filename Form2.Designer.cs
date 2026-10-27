namespace gestion_d_entreprise
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button6 = new Button();
            LAST = new Button();
            SUIVANT = new Button();
            PRECEDENT = new Button();
            button1 = new Button();
            button5 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Location = new Point(769, 376);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 41;
            button6.Text = "ENREGISTRER";
            button6.UseVisualStyleBackColor = true;
            // 
            // LAST
            // 
            LAST.Location = new Point(559, 482);
            LAST.Name = "LAST";
            LAST.Size = new Size(112, 34);
            LAST.TabIndex = 38;
            LAST.Text = "LAST";
            LAST.UseVisualStyleBackColor = true;
            // 
            // SUIVANT
            // 
            SUIVANT.Location = new Point(408, 482);
            SUIVANT.Name = "SUIVANT";
            SUIVANT.Size = new Size(112, 34);
            SUIVANT.TabIndex = 40;
            SUIVANT.Text = "suivant";
            SUIVANT.UseVisualStyleBackColor = true;
            // 
            // PRECEDENT
            // 
            PRECEDENT.Location = new Point(188, 482);
            PRECEDENT.Name = "PRECEDENT";
            PRECEDENT.Size = new Size(112, 34);
            PRECEDENT.TabIndex = 39;
            PRECEDENT.Text = "précédent";
            PRECEDENT.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(65, 482);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 37;
            button1.Text = "FIRST";
            button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(784, 187);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 44;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(225, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 33);
            comboBox1.TabIndex = 35;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 56);
            label5.Name = "label5";
            label5.Size = new Size(30, 25);
            label5.TabIndex = 34;
            label5.Text = "ID";
            label5.Click += label5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 283);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(633, 193);
            dataGridView1.TabIndex = 33;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(676, 21);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(245, 144);
            richTextBox1.TabIndex = 32;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(559, 27);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 31;
            label4.Text = "discription";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(225, 150);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(243, 31);
            numericUpDown1.TabIndex = 30;
            // 
            // button4
            // 
            button4.Location = new Point(831, 319);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 29;
            button4.Text = "rechercher";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(702, 319);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 28;
            button3.Text = "supprimer";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(831, 253);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 27;
            button2.Text = "modifier";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 156);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 26;
            label3.Text = "quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 102);
            label2.Name = "label2";
            label2.Size = new Size(41, 25);
            label2.TabIndex = 25;
            label2.Text = "prix";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 24;
            label1.Text = "nom de produit";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(223, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 31);
            textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(223, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 31);
            textBox1.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 221);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 42;
            label6.Text = "categore";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(225, 213);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 43;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button7
            // 
            button7.Location = new Point(702, 253);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 45;
            button7.Text = "ajouter";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 560);
            Controls.Add(button7);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(button6);
            Controls.Add(LAST);
            Controls.Add(SUIVANT);
            Controls.Add(PRECEDENT);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(numericUpDown1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Button LAST;
        private Button SUIVANT;
        private Button PRECEDENT;
        private Button button1;
        private Button button5;
        private ComboBox comboBox1;
        private Label label5;
        private DataGridView dataGridView1;
        private RichTextBox richTextBox1;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private ComboBox comboBox2;
        private Button button7;
    }
}