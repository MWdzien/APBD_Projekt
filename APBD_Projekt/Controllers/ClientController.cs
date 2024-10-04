using APBD_Projekt1.DTOs;
using APBD_Projekt1.Models;
using APBD_Projekt1.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Projekt1.Controllers;

[Route("api/clients")]
[ApiController]
public class ClientController : ControllerBase
{
    private readonly IClientsService _clientsService;

    public ClientController(IClientsService clientsService)
    {
        _clientsService = clientsService;
    }

    [HttpPost("individualClient")]
    public async Task<IActionResult> AddIndividualClient(AddIndividualClientDTO addIndividualClientDto)
    {
        await _clientsService.AddIndividualClient(addIndividualClientDto);
        return Created();
    }

    [HttpDelete("individualClient/{individualClientId:int}")]
    public async Task<IActionResult> DeleteIndividualClient(int individualClientId)
    {
        await _clientsService.DeleteIndividualClient(individualClientId);
        return NoContent();
    }

    [HttpPut("individualClient/{individualClient:int}")]
    public async Task<IActionResult> UpdateIndividualClient(int individualClientId,
        [FromBody] UpdateIndividualClientDTO updateIndividualClientDto)
    {
        await _clientsService.UpdateIndividualClient(individualClientId, updateIndividualClientDto);
        return NoContent();
    }

    [HttpPost("companyClient")]
    public async Task<IActionResult> AddCompanyClient(AddCompanyClientDTO addCompanyClientDto)
    {
        await _clientsService.AddCompanyClient(addCompanyClientDto);
        return Created();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateCompanyClient(int companyClientId, [FromBody] UpdateCompanyClientDTO updateCompanyClientDto)
    {
        await _clientsService.UpdateCompanyClient(companyClientId, updateCompanyClientDto);
        return NoContent();
    }
}