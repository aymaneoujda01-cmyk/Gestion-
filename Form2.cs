using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace gestion_d_entreprise
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlConnection CNX = new SqlConnection(connectionString);
            CNX.Open();
            SqlCommand cmd = new SqlCommand("SELECT   p.id_product," +
                "p.name_product, p.price, p.quantity, p.descriptions, c.name_category AS name_category" +
                " FROM products AS p INNER JOIN category AS c   ON p.id_category = c.id_category;", CNX);
            //  SqlCommand cmd2 = new SqlCommand("SELECT * FROM products", CNX);

            SqlDataReader reader = cmd.ExecuteReader();
            /*while (reader.Read())
            {
                comboBox2.Items.Add(reader["name_category"].ToString());
                comboBox2.SelectedIndex = 0;
                DataTable dt = new DataTable();
                dt.Load(reader);
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "name_category";
                comboBox2.ValueMember = "id_category";

            }*/
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable;
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "id_product";
            comboBox1.ValueMember = "id_product";

            reader.Close();

            DataTable dt_categorie = new DataTable();
            SqlCommand cmd2 = new SqlCommand("SELECT * from category", CNX);

            SqlDataReader reader2 = cmd2.ExecuteReader();
            dt_categorie.Load(reader2);
            comboBox2.DataSource = dt_categorie;
            comboBox2.DisplayMember = "name_category";
            comboBox2.ValueMember = "id_category";

            reader2.Close();
            CNX.Close();


        }
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog= gestionprouduit;Integrated Security=True;";

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    MessageBox.Show("Connexion réussie !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Selected Value: " + comboBox2.SelectedValue.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == comboBox1.SelectedValue.ToString())
                {
                    comboBox1.SelectedValue = row.Cells[0].Value.ToString();
                    textBox1.Text = row.Cells[1].Value.ToString();
                    textBox2.Text = row.Cells[2].Value.ToString();
                    richTextBox1.Text = row.Cells[4].Value.ToString();
                    numericUpDown1.Value = Convert.ToDecimal(row.Cells[3].Value);
                 for (int i = 0; i < comboBox2.Items.Count; i++)
                    {
                        DataRowView rowView = comboBox2.Items[i] as DataRowView;
                        if (rowView != null && rowView["name_category"].ToString() == row.Cells[5].Value.ToString())
                        {
                            comboBox2.SelectedIndex = i;
                            break;
                        }
                    }


                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
