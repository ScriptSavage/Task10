using Microsoft.EntityFrameworkCore;
using PharmacyApp.Data;
using PharmacyApp.DTOs;
using PharmacyApp.Models;

namespace PharmacyApp.Services;

public class DbService : IDbService
{

    private readonly DrugStoreContext _context;

    public DbService(DrugStoreContext context)
    {
        _context = context;
    }




    public async Task<ICollection<Prescription>> GetPatientsInfo()
    {


        var x = await _context.Prescriptions
            .Include(e=>e.Patient)
            .Include(e=>e.Doctor)
            .Include(e=>e.PrescriptionMedicaments)
            .ThenInclude(e=>e.Medicament)
            .ToListAsync();
           

        return x;


    }

    public async Task<bool> DoesPacientExist(int id)
    {
        var x =  _context.Patients.Any(e => e.IdPatient == id);

        return x;
        
    }

    public async Task<bool> DoesDrugExists(int id)
    {

        var x = _context.Medicaments
            .Include(e => e.PrescriptionMedicaments)
            .Any(e => e.PrescriptionMedicaments.Any(e => e.IdMedicament == id));
        

        return x;
        
    }

    public async Task AddPacient(Patient patient)
    {
        await _context.AddAsync(patient);
        await _context.SaveChangesAsync();
        
    }

    public async Task<bool> CheckReciptValid()
    {
        var x = _context.Prescriptions.Any(e => e.DueDate >= e.Date);

        return x;
    }
}