using PatientsForm.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientsForm.Models
{
    public class ExaminationTreatment
    {
        public int ExaminationTreatmentId { get; set; }

        public DateTime? Date { get; set; }
        public string? Weight { get; set; }
        public string? Height { get; set; }
        public string? BloodPressure { get; set; }
        public string? HeartRate { get; set; }
        public string? Temperature { get; set; }
        public string? FastingBlood { get; set; }
        public string? RandomBlood { get; set; }
        public string? Smoking { get; set; }
        public string? IllicitDrug { get; set; }
        public string? Alcohol { get; set; }



        public int? PatientId { get; internal set; }

        public virtual PatientInformation PatientInformation { get; set; } = null!;

        //public PatientInformation PatientInformation { get; internal set; }
    }
}
