using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatientsForm.Models;
using ReaLTaiizor.Forms;

namespace PatientsForm
{
    public partial class ReportFrm : MaterialForm
    {
        public static string printType = string.Empty, printMedCert = "medcert", printMedRecord = "medrecord";
        public ReportFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(printType == printMedCert)
            {
                reportViewer.LocalReport.ReportEmbeddedResource = "PatientsForm.Reports.RptMedCert.rdlc";

                ReportParameter[] parameters = new ReportParameter[7];
                parameters[0] = new ReportParameter("PatientFullName", _Filleds.PatientFullName);
                parameters[1] = new ReportParameter("PatientAge", _Filleds.Age);
                parameters[2] = new ReportParameter("PatientResidentialAddress", _Filleds.PatientResAddress);
                parameters[3] = new ReportParameter("PatientExamDate", _Filleds.ExaminationDate);
                parameters[4] = new ReportParameter("PatientDiagnosis", _Filleds.PatientDiagnosis);
                parameters[5] = new ReportParameter("Physician", _Filleds.Physician);
                parameters[6] = new ReportParameter("PrintDate", DateTime.Now.ToString("dd/MM/yyyy"));



                reportViewer.LocalReport.SetParameters(parameters);
                reportViewer.RefreshReport();
            }
            else if(printType == printMedRecord)
            {
                reportViewer.LocalReport.ReportEmbeddedResource = "PatientsForm.Reports.RptMedRecord.rdlc";

                ReportParameter[] parameters = new ReportParameter[17];
                parameters[0] = new ReportParameter("PatientFullName", _Filleds.PatientFullName);
                parameters[1] = new ReportParameter("PatientAge", _Filleds.Age);
                parameters[2] = new ReportParameter("PatientResidentialAddress", _Filleds.PatientResAddress);
                parameters[3] = new ReportParameter("BirthDate", _Filleds.PatientBirthDate.ToString());
                parameters[4] = new ReportParameter("BirthPlace", _Filleds.PatientBirthPlace);
                parameters[5] = new ReportParameter("Gender", _Filleds.PatientGender);
                parameters[6] = new ReportParameter("CivilStatus", _Filleds.CivilStatus);
                parameters[7] = new ReportParameter("MedicalNumber", _Filleds.MedicalNumber.ToString());
                parameters[8] = new ReportParameter("Height", _Filleds.height);
                parameters[9] = new ReportParameter("BP", _Filleds.BP);
                parameters[10] = new ReportParameter("BT", _Filleds.BT);
                parameters[11] = new ReportParameter("Weight", _Filleds.weight);
                parameters[12] = new ReportParameter("PR", _Filleds.PR);
                parameters[13] = new ReportParameter("DiagnosisNumber", _Filleds.DiagnosisNumber.ToString());
                parameters[14] = new ReportParameter("PlanTreatment", _Filleds.plan_treatment);
                parameters[15] = new ReportParameter("PersonNumber", _Filleds.PatientID.ToString());
                parameters[16] = new ReportParameter("Physician", _Filleds.Physician);



                reportViewer.LocalReport.SetParameters(parameters);
                reportViewer.RefreshReport();
            }
        }
    }
}
