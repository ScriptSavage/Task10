using PharmacyApp.Models;

namespace PharmacyApp.DTOs;

public class PatientDto
{
    public int IdPatient { get; set; }
    public string FirstName { get; set; }


    public ICollection<PrescriptionDto> Prescription { get; set; }
    public ICollection<DoctorDto> Doctor { get; set; }

}


public class PrescriptionDto
{
    public int IdPrescription { get; set; }
    
    public DateTime Date { get; set; }

    public DateTime DueDate { get; set; }

}



public class DoctorDto
{
    public int IdDoctor { get; set; }
    
    public string FirstName { get; set; }
}




