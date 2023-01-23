﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using PatientsForm.models;
using PatientsForm.Models;
using ReaLTaiizor.Forms;

namespace PatientsForm
{
    public partial class DashboardForm : MaterialForm
    {

        private PatientContext? dbContext;
        private int patientIdSelected;
        public static Boolean isLogin = false;

        public DashboardForm()
        {
            InitializeComponent();



          
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);



            this.dbContext = new PatientContext();

            // Uncomment the line below to start fresh with a new database.
            //this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.PatientsInformation.Load();

            this.patientInformationBindingSource.DataSource = dbContext.PatientsInformation.Local.ToBindingList();

            this.userAccountBindingSource.DataSource = dbContext.UserAccounts.Local.ToBindingList();

            if (isLogin)
            {

               
            } else
            {
                //foreach (Control control in this.Controls)
                //{
                //    control.Enabled = false;
                //}

                LoginForm loginForm =  new LoginForm();
                loginForm.TopMost = true;
                loginForm.ShowDialog();
                loginForm.BringToFront();
                loginForm.Activate();
            }

        }


       
      

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }


        private void materialTextBoxEdit1_Click(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void cb_Fasting_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_RandomBlood_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialCard3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_savePatient_Click(object sender, EventArgs e)
        {
            using (var context = new PatientContext())
            {
                var patient = new PatientInformation { FirstName = tb_FirstName.Text,
                MiddleName = tb_MiddleName.Text,
                LastName = tb_LastName.Text,
                Address = tb_Address.Text,
                ContactNumber= tb_ContactNumber.Text,
                Birthday= tb_Birthday.Text,
                Age= tb_Age.Text,
                Sex = cb_Sex.Text,
                CivilStatus= cb_CivilStatus.Text,
               };
                context.PatientsInformation.Add(patient);
                context.SaveChanges();
            }


            ClearText();

            this.dbContext.PatientsInformation.Load();

            this.patientInformationBindingSource.DataSource = dbContext.PatientsInformation.Local.ToBindingList();

            this.dataGridView1.Refresh();

        }

        private void ClearText ()
        {
            tb_FirstName.ResetText();
            tb_MiddleName.ResetText();
            tb_LastName.ResetText();
            tb_Address.ResetText();
            tb_ContactNumber.ResetText();
            tb_Birthday.ResetText();
            tb_Age.ResetText();

     
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           patientIdSelected = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()); 

        }

        private void bt_SaveExaminationTreatment_Click(object sender, EventArgs e)
        {
            using (var context = new PatientContext())
            {
                var examinationTreatment = new ExaminationTreatment
               {
                    PatientId = patientIdSelected,
                    Date = tb_DateExamination.Text,
                    Weight = tb_Weight.Text,
                    Height = tb_Height.Text,
                    BloodPressure = tb_BloodPressure.Text,
                    HeartRate = tb_HeartRate.Text,
                    Temperature= tb_Temperature.Text,

                };
                context.ExaminationTreatments.Add(examinationTreatment);
                context.SaveChanges();

                var prescription = new Prescription
                {
                    PatientId = patientIdSelected,
                    Diagnosis = tb_Diagnosis.Text,
                    Clinician = tb_Clinician.Text,
                    Medecine = tb_Medicine.Text,
                    Instructions= tb_Instructions.Text,
                };
                context.Prescriptions.Add(prescription);  
                context.SaveChanges();
            }



        }

        private void bt_SaveUser_Click(object sender, EventArgs e)
        {
            using (var context = new PatientContext())
            {
                var user = new UserAccount
                {
                    FirstName = tb_uFirstName.Text, 
                    LastName = tb_uLastName.Text,
                    Username = tb_uUserName.Text,
                    Password = tb_uPassword.Text,
                    Usertype = cb_Usertype.Text,
                   
                };
                context.UserAccounts.Add(user);
                context.SaveChanges();

                this.dbContext.UserAccounts.Load();

                this.patientInformationBindingSource.DataSource = dbContext.UserAccounts.Local.ToBindingList();

                this.dataGridView1.Refresh();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PatientProfileForm patientProfileForm = new PatientProfileForm(patientIdSelected);

            patientProfileForm.ShowDialog();
        }

        private void materialTextBoxEdit1_Click_1(object sender, EventArgs e)
        {

        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            string searchText = tb_Search.Text;

            var patients = this.dbContext.PatientsInformation.Where(p => p.FirstName.Contains(searchText) || p.LastName.Contains(searchText) || p.PatientId.ToString().Contains(searchText)).ToList();

            if (patients.Count() > 0)
            {
             
                dataGridView1.DataSource = patients;
            }
            else
            {
                // Handle the case when no patients are found
            }
        }
    }
}
