using System;
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
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            //this.dbContext.PatientsInformation.Load();
            //this.dbContext.UserAccounts.Load();

            this.patientInformationBindingSource.DataSource = dbContext.PatientsInformation.ToList();

           

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

        private void dataGridView_patient_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_patient.Rows)
            {
                int patientId = (int)row.Cells["PatientId"].Value;
                var diagnosis = dbContext.Prescriptions
                                .Where(p => p.PatientId == patientId)
                                .Select(p => p.Diagnosis)
                                .FirstOrDefault();

                row.Cells["Diagnosis"].Value = diagnosis;
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

            if (dataGridView_patient.SelectedRows.Count > 0)
            {
                using (var context = new PatientContext())
                {
                    // Get the selected row
                    var selectedRow = dataGridView_patient.SelectedRows[0];

                    // Get the patient ID of the selected row
                    int patientId = (int)selectedRow.Cells[0].Value;

                    // Retrieve the patient from the database
                    var patient = context.PatientsInformation.FirstOrDefault(p => p.PatientId == patientId);

                    // Update the patient's information
                    patient.FirstName = tb_FirstName.Text;
                    patient.MiddleName = tb_MiddleName.Text;
                    patient.LastName = tb_LastName.Text;
                    patient.Address = tb_Address.Text;
                    patient.ContactNumber = tb_ContactNumber.Text;
                    patient.Birthday = dtp_Birhtday.Value.Date;
                    patient.Age = tb_Age.Text;
                    patient.Sex = cb_Sex.Text;
                    patient.CivilStatus = cb_CivilStatus.Text;
                    

                    // Save the changes to the database
                    context.SaveChanges();
                }

                MessageBox.Show("Succesfully Update");
            }
            else
            {


            using (var context = new PatientContext())
            {
                var patient = new PatientInformation { FirstName = tb_FirstName.Text,
                MiddleName = tb_MiddleName.Text,
                LastName = tb_LastName.Text,
                Address = tb_Address.Text,
                ContactNumber= tb_ContactNumber.Text,
                    Birthday = dtp_Birhtday.Value.Date,
                    Age = tb_Age.Text,
                Sex = cb_Sex.Text,
                CivilStatus= cb_CivilStatus.Text,
               };
                context.PatientsInformation.Add(patient);
                context.SaveChanges();
                    MessageBox.Show("Succesfully Save");
                }
            }


            ClearText();


            refreshPaintList();

        }

        private void ClearText ()
        {
            tb_FirstName.ResetText();
            tb_MiddleName.ResetText();
            tb_LastName.ResetText();
            tb_Address.ResetText();
            tb_ContactNumber.ResetText();
            dtp_Birhtday.Value = DateTime.Now;
            tb_Age.ResetText();

     
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           patientIdSelected = Convert.ToInt32(dataGridView_patient.Rows[e.RowIndex].Cells[0].Value.ToString());


            tb_FirstName.Text = dataGridView_patient.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_MiddleName.Text = dataGridView_patient.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_LastName.Text = dataGridView_patient.Rows[e.RowIndex].Cells[3].Value.ToString();
            tb_Address.Text = dataGridView_patient.Rows[e.RowIndex].Cells[4].Value.ToString();
            tb_ContactNumber.Text = dataGridView_patient.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtp_Birhtday.Value = Convert.ToDateTime(dataGridView_patient.Rows[e.RowIndex].Cells[6].Value);

            tb_Age.Text = dataGridView_patient.Rows[e.RowIndex].Cells[7].Value.ToString(); 
            cb_Sex.Text = dataGridView_patient.Rows[e.RowIndex].Cells[8].Value.ToString();
            cb_CivilStatus.Text = dataGridView_patient.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void bt_SaveExaminationTreatment_Click(object sender, EventArgs e)
        {
            using (var context = new PatientContext())
            {
                var examinationTreatment = new ExaminationTreatment
               {
                    PatientId = patientIdSelected,
                    Date = dtp_ExamTreat.Value.Date,
                    Weight = tb_Weight.Text,
                    Height = tb_Height.Text,
                    BloodPressure = tb_BloodPressure.Text,
                    HeartRate = tb_HeartRate.Text,
                    Temperature = tb_Temperature.Text,
                    FastingBlood = cb_Fasting.Checked ? "Yes" : "No",
                    RandomBlood = cb_RandomBlood.Checked ? "Yes" : "No",
                    Smoking = cb_Smoking.Checked ? "Yes" : "No",
                    IllicitDrug = cb_IllicitDrug.Checked ? "Yes" : "No",
                    Alcohol = cb_Alcohol.Checked ? "Yes" : "No",

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

            MessageBox.Show("Save Succesfully");


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

                this.dataGridView_patient.Refresh();
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
          
        }


        private void refreshPaintList()
        {

            this.patientInformationBindingSource.DataSource = dbContext.PatientsInformation.ToList();
            patientInformationBindingSource.ResetBindings(false);

            dataGridView_patient.Refresh();


            dataGridView_patient.ClearSelection();



           
        }


        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            dataGridView_patient.ClearSelection();
            ClearText();
         

        }

        private void bt_RemovePatient_Click(object sender, EventArgs e)
        {
            using (PatientContext ctx = new PatientContext())
            {
                var toBeDeleted = ctx.PatientsInformation.Where(u => u.PatientId == patientIdSelected).FirstOrDefault();
                if (toBeDeleted == null)
                    return;

                ctx.PatientsInformation.Remove(toBeDeleted);
                ctx.SaveChanges();
                refreshPaintList();
                MessageBox.Show(this, "Delete Successfull");
            }
        }

        private void dtp_Birhtday_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_Birhtday.Value != null)
            {
                DateTime birthdate = dtp_Birhtday.Value;
                DateTime now = DateTime.Now;
                TimeSpan age = now.Subtract(birthdate);
                int years = (int)(age.TotalDays / 365.25);
                tb_Age.Text = years.ToString();
            }
        }

        private void tb_Search_Enter(object sender, EventArgs e)
        {
          
        }

        private void dataGridView_patient_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void tb_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchText = tb_Search.Text;

                var patients = this.dbContext.PatientsInformation.Where(p => p.FirstName.Contains(searchText) || p.LastName.Contains(searchText) || p.PatientId.ToString().Contains(searchText)).ToList();

                if (patients.Count() > 0)
                {
                    dataGridView_patient.DataSource = patients;
                }
                else
                {
                    // Handle the case when no patients are found
                    MessageBox.Show("No patients found with the search text. Please try again.");
                }
            }
        }
    }
}
