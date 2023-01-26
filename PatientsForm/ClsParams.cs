using System;
using PatientsForm.models;
using PatientsForm.Models;

namespace PatientsForm
{
    public static class _Filleds
    {
        public static string PatientFullName = string.Empty; //
        public static string PatientResAddress = string.Empty;//
        public static string Age = string.Empty;//
        public static string Physician = string.Empty;//
        public static int PatientID = 0;//
        public static string ExaminationDate = string.Empty;
        public static string? PatientBirthDate { get; set; }

        public static string PatientBirthPlace = string.Empty;//
        public static string PatientGender = string.Empty;//
        public static string CivilStatus = string.Empty;//
        public static string PatientDiagnosis = string.Empty;

        public static int MedicalNumber = 0;//
        public static string height = string.Empty;//
        public static string BP = string.Empty;
        public static string BT = string.Empty;
        public static string weight = string.Empty;
        public static string PR = string.Empty;

        public static int DiagnosisNumber = 0;
        public static string plan_treatment = string.Empty;


    }


    //public static class CommonParams
    //{
    //    public static PatientInformation patient = new PatientInformation();
    //    public static Prescription presc = new Prescription();
    //    public static ExaminationTreatment exam = new ExaminationTreatment();

    //    public static string PatientFullName()
    //    {
    //        return patient.FirstName + " " + patient.MiddleName + " " + patient.LastName;
    //    }

    //    public static string PatientResAddress()
    //    {
    //        return patient.Address;
    //    }

    //    public static string Age()
    //    {
    //        return patient.Age;
    //    }

    //    public static string Physician()
    //    {
    //        return presc.Clinician;
    //    }

    //    public static int PatientID()
    //    {
    //        return patient.PatientId;
    //    }
    //}

    //public static class MedCert
    //{
    //    public static ExaminationTreatment exam = new ExaminationTreatment();

    //    public static string ExaminationDate()
    //    {
    //        return exam.Date.ToString();
    //    }

    //    public static string IllnessDiseaseStatus = string.Empty;

    //}

    //public static class MedRecord
    //{
    //    public static PatientInformation patient = new PatientInformation();
    //    public static string PatientBirthDate()
    //    {
    //        return patient.Birthday.ToString();
    //    }

    //    public static string PatientBirthPlace()
    //    {
    //        return patient.Address;
    //    }

    //    public static string PatientGender()
    //    {
    //        return patient.Sex;
    //    }

    //    public static int MedicalNumber(ExaminationTreatment exam)
    //    {
    //        return exam.ExaminationTreatmentId;
    //    }

    //}
}
