using CrystalDecisions.CrystalReports.Engine;
using Microsoft.EntityFrameworkCore;
using PatientsForm.models;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientsForm
{
    public partial class PatientProfileForm : MaterialForm
    {

        private PatientContext? dbContext;
        private int patientIdSelected;

        public PatientProfileForm(int patientIdSelected)
        {
            this.patientIdSelected = patientIdSelected;
            InitializeComponent();
        }

        private void PatientProfileForm_Load(object sender, EventArgs e)
        {
            
            this.dbContext = new PatientContext();

            populateData();



            this.dbContext.Prescriptions.Where(p => p.PatientId == patientIdSelected).Load();
            this.dbContext.ExaminationTreatments.Where(p => p.PatientId == patientIdSelected).Load();

            this.examinationTreatmentBindingSource.DataSource= dbContext.ExaminationTreatments.Local.ToBindingList();

            this.prescriptionBindingSource.DataSource = dbContext.Prescriptions.Local.ToBindingList();
        }

        private void populateData()
        {
            using (var context = new PatientContext())
            {
                var patient = context.PatientsInformation.Where(p => p.PatientId == patientIdSelected).FirstOrDefault();
                if (patient != null)
                {
                    tb_FirstName.Text = patient.FirstName;
                    tb_MiddleName.Text = patient.MiddleName;
                    tb_LastName.Text = patient.LastName;
                    tb_Address.Text = patient.Address;
                    tb_ContactNumber.Text = patient.ContactNumber;
                    dtp_Birthday.Value = patient.Birthday ?? DateTime.Now;
                    tb_Age.Text = patient.Age;
                    cb_Sex.Text = patient.Sex;
                    cb_CivilStatus.Text = patient.CivilStatus;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
