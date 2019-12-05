using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassandraDataLayer;
using CassandraDataLayer.Entity;

namespace RentCarForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetCars_onClick(object sender, EventArgs e)
        {
            List<Cars> cars = DataProvider.GetCars();

            foreach (Cars c in cars)
                MessageBox.Show(c.id+"_"+c.naziv +"_"+ c.model);
        }

        private void AddCar_onClick(object sender, EventArgs e)
        {
            DataProvider.AddCars(id_txt.Text, naziv_txt.Text, model_txt.Text);
            MessageBox.Show("Car added succesfully!");
        }

        private void Del_Car_Click(object sender, EventArgs e)
        {
            DataProvider.DeleteCars(Del_id_txt.Text);
            MessageBox.Show("Car deleted succesfully!");
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {

            DataProvider.AddEmployee(empId_txt.Text, empName_txt.Text, empLName_txt.Text);
            MessageBox.Show("Employee added succesfully!");
        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            DataProvider.DeleteEmployee(empIdDel_txt.Text);
            MessageBox.Show("Employee deleted succesfully!");
        }

        private void GetEmployee_Click(object sender, EventArgs e)
        {
            List<Employee> employees = DataProvider.GetEmployees();

            foreach (Employee em in employees)
                MessageBox.Show(em.EmployeeId+"_"+em.EmployeeName + "_" + em.EmployeeLname);
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            DataProvider.AddClient(jmbg_txt.Text, cliName_txt.Text, cliLName_txt.Text);
            MessageBox.Show("Client added succesfully!");
        }

        private void DeleteClient_Click(object sender, EventArgs e)
        {
            DataProvider.DeleteClient(delJMBG_txt.Text);
            MessageBox.Show("Client deleted succesfully!");
        }

        private void GetClient_Click(object sender, EventArgs e)
        {
            List<Client> clients = DataProvider.GetClients();

            foreach (Client c in clients)
                MessageBox.Show(c.jmbg + "_" + c.ime + "_" + c.prezime);
        }
    }
}
