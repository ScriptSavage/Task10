using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyApp.Models;



[PrimaryKey(nameof(IdMedicament),nameof(IdPrescription))]
public class PrescriptionMedicament
{
    
    public int Dose { get; set; }

    public string Details { get; set; }

    public int IdPrescription { get; set; }


    public int IdMedicament { get; set; }
    
    
    [ForeignKey(nameof(IdPrescription))]
    public Prescription Prescription { get; set; }


    [ForeignKey(nameof(IdMedicament))]
    public Medicament Medicament { get; set; }
    
    
    
}