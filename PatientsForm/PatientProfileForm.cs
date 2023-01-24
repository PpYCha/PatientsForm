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



            this.dbContext.Prescriptions.Where(p => p.PatientId == patientIdSelected).Load();
            this.dbContext.ExaminationTreatments.Where(p => p.PatientId == patientIdSelected).Load();

            this.examinationTreatmentBindingSource.DataSource= dbContext.ExaminationTreatments.Local.ToBindingList();

            this.prescriptionBindingSource.DataSource = dbContext.Prescriptions.Local.ToBindingList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            ReportFrm reportFrm = new ReportFrm();
            reportFrm.ShowDialog();
        }

        private void bt_savePatient_Click(object sender, EventArgs e)
        {

        }
    }
}
