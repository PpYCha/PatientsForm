using System;
using PatientsForm.models;
using PatientsForm.Models;

namespace PatientsForm
{

    public static class CommonParams
    {
        public static PatientInformation patient = new PatientInformation();
        public static Prescription presc = new Prescription();
        public static ExaminationTreatment exam = new ExaminationTreatment();

        public static string PatientFullName()
        {
            return patient.FirstName + " " + patient.MiddleName + " " + patient.LastName;
        }

        public static string PatientResAddress()
        {
            return patient.Address;
        }

        public static string Age()
        {
            return patient.Age;
        }

        public static string Physician()
        {
            return presc.Clinician;
        }

        public static int PatientID()
        {
            return patient.PatientId;
        }
    }

    public static class MedCert
    {
        public static ExaminationTreatment exam = new ExaminationTreatment();

        public static string ExaminationDate()
        {
            return exam.Date;
        }

        public static string IllnessDiseaseStatus = string.Empty;

    }

    public static class MedRecord
    {
        public static PatientInformation patient = new PatientInformation();
        public static string PatientBirthDate()
        {
            return patient.Birthday;
        }

        public static string PatientBirthPlace()
        {
            return patient.Address;
        }

        public static string PatientGender()
        {
            return patient.Sex;
        }

        public static int MedicalNumber(ExaminationTreatment exam)
        {
            return exam.ExaminationTreatmentId;
        }

    }
}
