using PatientsForm.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientsForm.Models
{
    public class Prescription 
    { 


        public int PrescriptionId { get; set; }

        public string? Medecine { get; set; }
        public string? Instructions { get; set; }
        public string? Clinician { get; set; }
        public string? Diagnosis { get; set; }


        public int? PatientId { get; internal set; }

        public virtual PatientInformation PatientInformation { get; set; } = null!;
    }
}
