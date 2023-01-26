using Microsoft.EntityFrameworkCore.ChangeTracking;
using PatientsForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientsForm.models
{
    public class PatientInformation
    {
        public int PatientId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Age { get; set; }
        public string? Sex { get; set; }
        public string? CivilStatus { get; set; }

       
        public virtual ObservableCollectionListSource<ExaminationTreatment> ExaminationTreatments { get; } = new();
        public virtual ObservableCollectionListSource<Prescription> Prescriptions { get; } = new();

    }
}
