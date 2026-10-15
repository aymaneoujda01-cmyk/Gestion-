using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace gestion_d_entreprise
{
    public partial class Form1 : Form
    {
        public int ProductRowCount { get; private set; }

        public Form1()
        {
            InitializeComponent();

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
            string A = comboBox1.Text;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null && row.Cells[4].Value.ToString() == A)
                {
                    textBox1.Text = row.Cells[0].Value.ToString();
                    textBox2.Text = row.Cells[1].Value.ToString();
                    numericUpDown1.Value = Convert.ToDecimal(row.Cells[2].Value);
                    richTextBox1.Text = row.Cells[3].Value.ToString();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedValue = comboBox1.SelectedItem.ToString();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[4].Value != null && row.Cells[4].Value.ToString() == selectedValue)
                    {
                        textBox1.Text = row.Cells[0].Value.ToString();
                        textBox2.Text = row.Cells[1].Value.ToString();
                        numericUpDown1.Value = Convert.ToDecimal(row.Cells[2].Value);
                        richTextBox1.Text = row.Cells[3].Value.ToString();
                        dataGridView1.ClearSelection(); // Désélectionner toutes les lignes
                        dataGridView1.CurrentCell = row.Cells[4]; // Sélectionner la ligne correspondante
                        row.Selected = true;
                        break;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var champsManquants = new List<string>();

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                champsManquants.Add("Nom du produit");
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text) || !float.TryParse(textBox2.Text, out float prix) || prix <= 0f)
            {
                champsManquants.Add("Prix");
            }

            if (numericUpDown1.Value <= 0)
            {
                champsManquants.Add("Quantité");
            }

            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                champsManquants.Add("Description");
            }

            if (champsManquants.Count > 0)
            {
                MessageBox.Show(
                    $"Veuillez remplir les champs suivants : {string.Join(", ", champsManquants)}.",
                    "Champs manquants",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                ClearInputs();
                return;
            }

            int cont = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    cont++;
                }
            }

            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, numericUpDown1.Value, richTextBox1.Text, cont);
            ClearInputs();
            comboBox1.Items.Add(cont);
            comboBox1.SelectedIndex = -1; // ne pas réaffecter Text pour éviter de remplir les champs via SelectedIndexChanged
            MessageBox.Show("Produit ajouté.");
        }

        private void ClearInputs()
        {
            textBox1.Clear();
            textBox2.Clear();
            decimal cible = 0M;
            if (cible < numericUpDown1.Minimum) cible = numericUpDown1.Minimum;
            if (cible > numericUpDown1.Maximum) cible = numericUpDown1.Maximum;
            numericUpDown1.Value = cible;
            richTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[4].Value != null)
                {
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                    dataGridView1.Rows.Remove(row);
                    if (true)
                    {
                        comboBox1.Text = string.Empty;
                    }
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
        }

        private void LAST_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0];
        }

        private void PRECEDENT_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int currentIndex = row.Index;
                int ligne = dataGridView1.Rows.Count - 1;
                if (currentIndex > 0)
                {
                    dataGridView1.Rows[currentIndex - 1].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[currentIndex - 1].Cells[0];
                }
            }
        }

        private void SUIVANT_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int currentIndex = row.Index;
                int ligne = dataGridView1.Rows.Count - 1;
                if (currentIndex < ligne - 1)
                {
                    dataGridView1.Rows[currentIndex + 1].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[currentIndex + 1].Cells[0];
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string shemin = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "gestion_d_entreprise");
            if (!File.Exists(shemin)) 
            {
                MessageBox.Show("veuie crier d'abord le fichie.txt");
                FileStream fileStream = File.Create(shemin);
                MessageBox.Show("bien crier le fichier");
                return;
                    }
            try
            {
                using (StreamWriter fichier = new StreamWriter(shemin, false))

                { foreach (DataGridViewRow row in dataGridView1.Rows) 
                    {
                        string[] valeur = new string[dataGridView1.Columns.Count];
                        for (int i = 0; i> row.Cells.Count; i++)
                        {
                            valeur[i] = Convert.ToString(row.Cells[i].Value);
                        }
                        fichier.WriteLine(string.Join("/t", valeur));

                    }
                    MessageBox.Show("les données enrigister");
                }

            }
            catch
            {

            }


                    
        }
          
     
    }
}








 
