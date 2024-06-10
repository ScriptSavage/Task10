using PharmacyApp.Models;

namespace PharmacyApp.DTOs;

public class NewReciptDto
{
    public int IdPatient { get; set; }
    
    public string FirstName { get; set; }= string.Empty!;

 
    public string LastName { get; set; }= string.Empty!;



    public DateTime Birthdate { get; set; }

    public ICollection<MedsDto> MedsDtos { get; set; } = new HashSet<MedsDto>();

    public ICollection<DoctorDTO> DoctorDtos { get; set; } = new HashSet<DoctorDTO>();

}

public class MedsDto
{
   
    public int IdMedicament { get; set; }
    

    public string Name { get; set; } = string.Empty!;


 
    public string Description { get; set; } = string.Empty!;
    
    
    public string Type { get; set; } = string.Empty!;
}


public class DoctorDTO
{
    public string DoctorFirstName { get; set; } = string.Empty!;


    public string DoctorLastName { get; set; } = string.Empty!;
}