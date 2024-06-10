using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PharmacyApp.Data;
using PharmacyApp.DTOs;
using PharmacyApp.Models;
using PharmacyApp.Services;

namespace PharmacyApp.Controllers;


[ApiController]
[Route("/api/[controller]")]
public class PharmacyController : ControllerBase
{

    private readonly IDbService _service;

    public PharmacyController(IDbService service)
    {
        _service = service;
    }


    [HttpPost]
    public async Task<IActionResult> AddRecipt(NewReciptDto newReciptDto, int IdPatient)
    {

        var x = await _service.DoesPacientExist(IdPatient);


        var y = await _service.DoesDrugExists(1);


        var pat = new Patient()
        {
            IdPatient = newReciptDto.IdPatient,
            FirstName = newReciptDto.FirstName,
            LastName = newReciptDto.LastName
            
        };

        if (newReciptDto.MedsDtos.Count > 10)
        {
            return StatusCode(StatusCodes.Status403Forbidden);
        }

        var valid = await _service.CheckReciptValid();

        if (!valid)
        {
            return StatusCode(StatusCodes.Status403Forbidden);
        }

        if (!x)
        {
       await _service.AddPacient(pat);
        }


    return Created();
    
    
    
    
    }


    [HttpGet]
    public async Task<IActionResult> GetPatients()
    {

        var x = await _service.GetPatientsInfo();
        
        
        
        return Ok(x.Select(e=> new PatientDto()
        {
            IdPatient = e.Patient.IdPatient,
            FirstName = e.Patient.FirstName,
            Prescription  = e.PrescriptionMedicaments.Select(e=>new PrescriptionDto()
            {
                IdPrescription = e.IdPrescription,
                Date = e.Prescription.Date,
                DueDate = e.Prescription.DueDate,
                
                
            }).ToList(),
        }).ToList());

    }


}