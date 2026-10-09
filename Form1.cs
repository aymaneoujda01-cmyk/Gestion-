using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace gestion_d_entreprise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            var champsManquants = new List<string>();

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                champsManquants.Add("Nom du produit");
                textBox1.Clear();
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text) || !float.TryParse(textBox2.Text, out float prix) || prix <= 0f)
            {
                champsManquants.Add("Prix");
                textBox2.Clear();
            }

            if (numericUpDown1.Value <= 0)
            {
                champsManquants.Add("Quantité");
                numericUpDown1.Value = 0;
            }

            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                champsManquants.Add("Description");
                richTextBox1.Clear();
            }
          


            if (champsManquants.Count > 0)
            {
                MessageBox.Show(
                    $"Veuillez remplir les champs suivants : {string.Join(", ", champsManquants)}.",
                    "Champs manquants",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;

            }
            int cont = 0;
           /* foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    cont++;
                }
            }*/
           if (dataGridView1.Rows.Count > 0)
            {
                cont = dataGridView1.Rows.Count;
            }
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, numericUpDown1.Value, richTextBox1.Text, cont  );

            textBox1.Clear();
            textBox2.Clear();
            numericUpDown1.Value = 0;
            richTextBox1.Clear();
            comboBox1.Items.Add(cont );
            comboBox1.Text = (cont ).ToString();

        } 




        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("nom", "nom");
            dataGridView1.Columns.Add("prix", "prix");
            dataGridView1.Columns.Add("quantite", "quntite");
            dataGridView1.Columns.Add("description", "description");
            dataGridView1.Columns.Add("ID", "ID");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
             
        }
    }
}
