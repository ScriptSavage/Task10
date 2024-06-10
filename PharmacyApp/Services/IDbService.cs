using PharmacyApp.DTOs;
using PharmacyApp.Models;

namespace PharmacyApp.Services;

public interface IDbService
{


    Task<ICollection<Prescription>> GetPatientsInfo();

    Task<bool> DoesPacientExist(int id);

    Task<bool> DoesDrugExists(int id);

    Task AddPacient(Patient patient);

    Task<bool> CheckReciptValid();



}