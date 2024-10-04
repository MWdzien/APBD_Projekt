using APBD_Projekt1.Context;
using APBD_Projekt1.DTOs;
using APBD_Projekt1.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_Projekt1.Repositories;

public class ClientsRepository : IClientsRepository
{
    private readonly DatabaseContext _databaseContext;

    public ClientsRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public async Task AddIndividualClient(IndividualClient individualClient)
    {
        await _databaseContext.IndividualClients.AddAsync(individualClient);
        await _databaseContext.SaveChangesAsync();
    }

    public async Task DeleteIndividualClient(IndividualClient individualClient)
    {
        individualClient.IsDeleted = true;
        await _databaseContext.SaveChangesAsync();
    }

    public async Task UpdateIndividualClient(IndividualClient individualClient, UpdateIndividualClientDTO updateIndividualClientDto)
    {
        individualClient.FirstName = updateIndividualClientDto.FirstName;
        individualClient.LastName = updateIndividualClientDto.LastName;
        individualClient.Adress = updateIndividualClientDto.Adress;
        individualClient.Email = updateIndividualClientDto.Email;
        individualClient.PhoneNumber = updateIndividualClientDto.PhoneNumber;
        await _databaseContext.SaveChangesAsync();
    }

    public async Task AddCompanyClient(CompanyClient companyClient)
    {
        await _databaseContext.CompanyClients.AddAsync(companyClient);
        await _databaseContext.SaveChangesAsync();
    }

    public async Task UpdateCompanyClient(CompanyClient companyClient, UpdateCompanyClientDTO updateCompanyClientDto)
    {
        companyClient.Name = updateCompanyClientDto.Name;
        companyClient.Adress = updateCompanyClientDto.Adress;
        companyClient.Email = updateCompanyClientDto.Email;
        companyClient.PhoneNumber = updateCompanyClientDto.PhoneNumber;
        await _databaseContext.SaveChangesAsync();
    }

    public async Task<IndividualClient> GetIndividualClientByPesel(string pesel)
    {
        return await _databaseContext.IndividualClients.FirstOrDefaultAsync(c => c.PESEL == pesel);
    }

    public async Task<IndividualClient> GetIndividualClientById(int individualClientId)
    {
        return await _databaseContext.IndividualClients.FirstOrDefaultAsync(c => c.IndividualClientId == individualClientId);
    }

    public async Task<CompanyClient> GetCompanyClientByKRS(string krs)
    {
        return await _databaseContext.CompanyClients.FirstOrDefaultAsync(c => c.KRSNumber == krs);
    }

    public async Task<CompanyClient> GetCompanyClientById(int companyClientId)
    {
        return await _databaseContext.CompanyClients.FirstOrDefaultAsync(c => c.CompanyClientId == companyClientId);
    }
}