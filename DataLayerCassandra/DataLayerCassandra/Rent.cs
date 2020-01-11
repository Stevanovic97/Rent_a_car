using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayerCassandra.Entiteti;

namespace DataLayerCassandra
{
    public partial class Rent : Form
    {
        public Rent()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            listVozila("Automobil");
        }
        public void listVozila(string tip)
        {
            List<Vozila> vozila = new List<Vozila>();
            DataTable dt = new DataTable();

            vozila = DataProvider.GetVozilaTip(tip);
            dt.Columns.Add("id");
            dt.Columns.Add("stanje");
            dt.Columns.Add("naziv");
            dt.Columns.Add("model");

            foreach (Vozila v in vozila)
            {
                dt.Rows.Add(v.id_vozila, v.isrent, v.naziv, v.model);
            }
            dataGridView1.DataSource = dt;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                listVozila("Automobil");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listVozila("Motor");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                listVozila("Bicikl");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }

        private void iznajmi_btn_Click(object sender, EventArgs e)
        {
            ClientForm cf = new ClientForm();
            cf.ShowDialog();
            string jmbg = cf.getJMBG();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();

                if(row.Cells[1].Value.ToString() == "Slobodno")
                DataProvider.updateState("Zauzeto", id);
                Random r = new Random();
                string rentID = r.Next(0, 10000).ToString();
                DataProvider.addRent(rentID, id, jmbg);
            }
            listVozila(comboBox1.SelectedItem.ToString());
        }


        private void Oslobodi_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();

                DataProvider.updateState("Slobodno", id);
                DataProvider.removeRent(id);
            }
            listVozila(comboBox1.SelectedItem.ToString());
        }
    }
}
