
using Microsoft.EntityFrameworkCore;
using PatientsForm.models;
using PatientsForm.Models;
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

        private void materialButton1_Click(object sender, EventArgs e)
        {
            ReportFrm.printType = ReportFrm.printMedCert;

            using (var context = new PatientContext())
            {
                var patient = context.PatientsInformation.Where(p => p.PatientId == patientIdSelected).FirstOrDefault();
                if (patient != null)
                {
                    _Filleds.PatientFullName = patient.FirstName + " " + patient.MiddleName + " " + patient.LastName;
                    _Filleds.PatientResAddress = patient.Address;
                    _Filleds.Age = patient.Age;
                }
            }

            var pres = dbContext.Prescriptions.Where(p => p.PatientId == patientIdSelected).FirstOrDefault();
            if (pres != null)
            {
                _Filleds.Physician = pres.Clinician;
                _Filleds.PatientDiagnosis = pres.Diagnosis;
            }

            var examTreat = dbContext.ExaminationTreatments.Where(p => p.PatientId == patientIdSelected).FirstOrDefault();
            if (examTreat != null)
            {
                _Filleds.ExaminationDate = examTreat.Date.ToString();
            }

            ReportFrm reportFrm = new ReportFrm();
            reportFrm.ShowDialog();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            ReportFrm.printType = ReportFrm.printMedRecord;
            using (var context = new PatientContext())
            {
                var patient = context.PatientsInformation.Where(p => p.PatientId == patientIdSelected).FirstOrDefault();
                if (patient != null)
                {
                    _Filleds.PatientID = patient.PatientId;
                    _Filleds.PatientFullName = patient.FirstName + " " + patient.MiddleName + " " + patient.LastName;
                    _Filleds.PatientResAddress = patient.Address;
                    string date = patient.Birthday.Value.Date.ToString("dd/MM/yyyy");
                    _Filleds.PatientBirthDate = date;
                   _Filleds.PatientBirthPlace = "hgggh";
                    _Filleds.PatientGender = patient.Sex;
                    _Filleds.CivilStatus = patient.CivilStatus;
                    _Filleds.Age = patient.Age;
                }

                var pres = dbContext.Prescriptions.Where(p => p.PatientId == patientIdSelected).FirstOrDefault();
                if (pres != null)
                {
                    _Filleds.DiagnosisNumber = pres.PrescriptionId;
                    _Filleds.Physician = pres.Clinician;
                    _Filleds.PatientDiagnosis = pres.Diagnosis;
                    _Filleds.plan_treatment = pres.Instructions;
                }

                var examTreat = dbContext.ExaminationTreatments.Where(p => p.PatientId == patientIdSelected).FirstOrDefault();
                if (examTreat != null)
                {
                    _Filleds.ExaminationDate = examTreat.Date.ToString();
                    _Filleds.height = examTreat.Height;
                    _Filleds.BP = examTreat.BloodPressure;
                    _Filleds.BT = examTreat.Temperature;
                    _Filleds.weight = examTreat.Weight;
                    _Filleds.PR = "565";
                    _Filleds.MedicalNumber = examTreat.ExaminationTreatmentId;
                }
            }





            ReportFrm reportFrm = new ReportFrm();
            reportFrm.ShowDialog();
        }
    }
}

