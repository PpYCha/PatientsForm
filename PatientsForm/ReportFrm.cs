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
        public ReportFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reportViewer.LocalReport.ReportEmbeddedResource = "PatientsForm.Reports.RptMedCert.rdlc";

            ReportParameter[] parameters = new ReportParameter[7];
            parameters[0] = new ReportParameter("PatientFullName", CommonParams.PatientFullName());
            parameters[1] = new ReportParameter("PatientAge", "123");
            parameters[2] = new ReportParameter("PatientResidentialAddress", "123");
            parameters[3] = new ReportParameter("PatientExamDate", "123");
            parameters[4] = new ReportParameter("PatientIllnessDiseaseStatus", "123");
            parameters[5] = new ReportParameter("Physician", "123");
            parameters[6] = new ReportParameter("PrintDate", DateTime.Now.ToShortDateString());



            reportViewer.LocalReport.SetParameters(parameters);
            reportViewer.RefreshReport();
        }
    }
}
