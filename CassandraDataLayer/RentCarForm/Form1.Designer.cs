namespace RentCarForm
{
    partial class Form1
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
            this.GetCars = new System.Windows.Forms.Button();
            this.GetCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.naziv_txt = new System.Windows.Forms.TextBox();
            this.model_txt = new System.Windows.Forms.TextBox();
            this.Del_id_txt = new System.Windows.Forms.TextBox();
            this.delCar_Click = new System.Windows.Forms.Button();
            this.DeleteEmployee = new System.Windows.Forms.Button();
            this.empIdDel_txt = new System.Windows.Forms.TextBox();
            this.empLName_txt = new System.Windows.Forms.TextBox();
            this.empName_txt = new System.Windows.Forms.TextBox();
            this.empId_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DeleteClient = new System.Windows.Forms.Button();
            this.delJMBG_txt = new System.Windows.Forms.TextBox();
            this.cliLName_txt = new System.Windows.Forms.TextBox();
            this.cliName_txt = new System.Windows.Forms.TextBox();
            this.jmbg_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AddClient = new System.Windows.Forms.Button();
            this.GetClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetCars
            // 
            this.GetCars.Location = new System.Drawing.Point(12, 209);
            this.GetCars.Name = "GetCars";
            this.GetCars.Size = new System.Drawing.Size(169, 49);
            this.GetCars.TabIndex = 0;
            this.GetCars.Text = "GetCars";
            this.GetCars.UseVisualStyleBackColor = true;
            this.GetCars.Click += new System.EventHandler(this.GetCars_onClick);
            // 
            // GetCar
            // 
            this.GetCar.Location = new System.Drawing.Point(12, 145);
            this.GetCar.Name = "GetCar";
            this.GetCar.Size = new System.Drawing.Size(169, 49);
            this.GetCar.TabIndex = 1;
            this.GetCar.Text = "AddCars";
            this.GetCar.UseVisualStyleBackColor = true;
            this.GetCar.Click += new System.EventHandler(this.AddCar_onClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model";
            // 
            // id_txt
            // 
            this.id_txt.ForeColor = System.Drawing.SystemColors.InfoText;
            this.id_txt.Location = new System.Drawing.Point(81, 17);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(100, 22);
            this.id_txt.TabIndex = 5;
            // 
            // naziv_txt
            // 
            this.naziv_txt.Location = new System.Drawing.Point(81, 56);
            this.naziv_txt.Name = "naziv_txt";
            this.naziv_txt.Size = new System.Drawing.Size(100, 22);
            this.naziv_txt.TabIndex = 6;
            // 
            // model_txt
            // 
            this.model_txt.Location = new System.Drawing.Point(81, 100);
            this.model_txt.Name = "model_txt";
            this.model_txt.Size = new System.Drawing.Size(100, 22);
            this.model_txt.TabIndex = 7;
            // 
            // Del_id_txt
            // 
            this.Del_id_txt.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Del_id_txt.Location = new System.Drawing.Point(256, 17);
            this.Del_id_txt.Name = "Del_id_txt";
            this.Del_id_txt.Size = new System.Drawing.Size(100, 22);
            this.Del_id_txt.TabIndex = 8;
            // 
            // delCar_Click
            // 
            this.delCar_Click.Location = new System.Drawing.Point(256, 56);
            this.delCar_Click.Name = "delCar_Click";
            this.delCar_Click.Size = new System.Drawing.Size(100, 202);
            this.delCar_Click.TabIndex = 9;
            this.delCar_Click.Text = "Delete Cars";
            this.delCar_Click.UseVisualStyleBackColor = true;
            this.delCar_Click.Click += new System.EventHandler(this.Del_Car_Click);
            // 
            // DeleteEmployee
            // 
            this.DeleteEmployee.Location = new System.Drawing.Point(256, 384);
            this.DeleteEmployee.Name = "DeleteEmployee";
            this.DeleteEmployee.Size = new System.Drawing.Size(100, 202);
            this.DeleteEmployee.TabIndex = 19;
            this.DeleteEmployee.Text = "Delete Employee";
            this.DeleteEmployee.UseVisualStyleBackColor = true;
            this.DeleteEmployee.Click += new System.EventHandler(this.DeleteEmployee_Click);
            // 
            // empIdDel_txt
            // 
            this.empIdDel_txt.ForeColor = System.Drawing.SystemColors.InfoText;
            this.empIdDel_txt.Location = new System.Drawing.Point(256, 345);
            this.empIdDel_txt.Name = "empIdDel_txt";
            this.empIdDel_txt.Size = new System.Drawing.Size(100, 22);
            this.empIdDel_txt.TabIndex = 18;
            // 
            // empLName_txt
            // 
            this.empLName_txt.Location = new System.Drawing.Point(81, 428);
            this.empLName_txt.Name = "empLName_txt";
            this.empLName_txt.Size = new System.Drawing.Size(100, 22);
            this.empLName_txt.TabIndex = 17;
            // 
            // empName_txt
            // 
            this.empName_txt.Location = new System.Drawing.Point(81, 384);
            this.empName_txt.Name = "empName_txt";
            this.empName_txt.Size = new System.Drawing.Size(100, 22);
            this.empName_txt.TabIndex = 16;
            // 
            // empId_txt
            // 
            this.empId_txt.ForeColor = System.Drawing.SystemColors.InfoText;
            this.empId_txt.Location = new System.Drawing.Point(81, 345);
            this.empId_txt.Name = "empId_txt";
            this.empId_txt.Size = new System.Drawing.Size(100, 22);
            this.empId_txt.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "LName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID";
            // 
            // AddEmployee
            // 
            this.AddEmployee.Location = new System.Drawing.Point(12, 473);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(169, 49);
            this.AddEmployee.TabIndex = 11;
            this.AddEmployee.Text = "AddEmployee";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 537);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 49);
            this.button3.TabIndex = 10;
            this.button3.Text = "GetEmployees";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GetEmployee_Click);
            // 
            // DeleteClient
            // 
            this.DeleteClient.Location = new System.Drawing.Point(647, 56);
            this.DeleteClient.Name = "DeleteClient";
            this.DeleteClient.Size = new System.Drawing.Size(100, 202);
            this.DeleteClient.TabIndex = 29;
            this.DeleteClient.Text = "Delete Client";
            this.DeleteClient.UseVisualStyleBackColor = true;
            this.DeleteClient.Click += new System.EventHandler(this.DeleteClient_Click);
            // 
            // delJMBG_txt
            // 
            this.delJMBG_txt.ForeColor = System.Drawing.SystemColors.InfoText;
            this.delJMBG_txt.Location = new System.Drawing.Point(647, 17);
            this.delJMBG_txt.Name = "delJMBG_txt";
            this.delJMBG_txt.Size = new System.Drawing.Size(100, 22);
            this.delJMBG_txt.TabIndex = 28;
            // 
            // cliLName_txt
            // 
            this.cliLName_txt.Location = new System.Drawing.Point(472, 100);
            this.cliLName_txt.Name = "cliLName_txt";
            this.cliLName_txt.Size = new System.Drawing.Size(100, 22);
            this.cliLName_txt.TabIndex = 27;
            // 
            // cliName_txt
            // 
            this.cliName_txt.Location = new System.Drawing.Point(472, 56);
            this.cliName_txt.Name = "cliName_txt";
            this.cliName_txt.Size = new System.Drawing.Size(100, 22);
            this.cliName_txt.TabIndex = 26;
            // 
            // jmbg_txt
            // 
            this.jmbg_txt.ForeColor = System.Drawing.SystemColors.InfoText;
            this.jmbg_txt.Location = new System.Drawing.Point(472, 17);
            this.jmbg_txt.Name = "jmbg_txt";
            this.jmbg_txt.Size = new System.Drawing.Size(100, 22);
            this.jmbg_txt.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "LName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "JMBG";
            // 
            // AddClient
            // 
            this.AddClient.Location = new System.Drawing.Point(403, 145);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(169, 49);
            this.AddClient.TabIndex = 21;
            this.AddClient.Text = "AddClient";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // GetClient
            // 
            this.GetClient.Location = new System.Drawing.Point(403, 209);
            this.GetClient.Name = "GetClient";
            this.GetClient.Size = new System.Drawing.Size(169, 49);
            this.GetClient.TabIndex = 20;
            this.GetClient.Text = "GetClients";
            this.GetClient.UseVisualStyleBackColor = true;
            this.GetClient.Click += new System.EventHandler(this.GetClient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 691);
            this.Controls.Add(this.DeleteClient);
            this.Controls.Add(this.delJMBG_txt);
            this.Controls.Add(this.cliLName_txt);
            this.Controls.Add(this.cliName_txt);
            this.Controls.Add(this.jmbg_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AddClient);
            this.Controls.Add(this.GetClient);
            this.Controls.Add(this.DeleteEmployee);
            this.Controls.Add(this.empIdDel_txt);
            this.Controls.Add(this.empLName_txt);
            this.Controls.Add(this.empName_txt);
            this.Controls.Add(this.empId_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.delCar_Click);
            this.Controls.Add(this.Del_id_txt);
            this.Controls.Add(this.model_txt);
            this.Controls.Add(this.naziv_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetCar);
            this.Controls.Add(this.GetCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetCars;
        private System.Windows.Forms.Button GetCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox naziv_txt;
        private System.Windows.Forms.TextBox model_txt;
        private System.Windows.Forms.TextBox Del_id_txt;
        private System.Windows.Forms.Button delCar_Click;
        private System.Windows.Forms.Button DeleteEmployee;
        private System.Windows.Forms.TextBox empIdDel_txt;
        private System.Windows.Forms.TextBox empLName_txt;
        private System.Windows.Forms.TextBox empName_txt;
        private System.Windows.Forms.TextBox empId_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button DeleteClient;
        private System.Windows.Forms.TextBox delJMBG_txt;
        private System.Windows.Forms.TextBox cliLName_txt;
        private System.Windows.Forms.TextBox cliName_txt;
        private System.Windows.Forms.TextBox jmbg_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.Button GetClient;
    }
}

