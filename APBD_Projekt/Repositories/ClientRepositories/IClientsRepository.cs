using APBD_Projekt1.DTOs;
using APBD_Projekt1.Models;

namespace APBD_Projekt1.Repositories;

public interface IClientsRepository
{
    public Task AddIndividualClient(IndividualClient individualClient);
    public Task DeleteIndividualClient(IndividualClient individualClient);

    public Task UpdateIndividualClient(IndividualClient individualClient,
        UpdateIndividualClientDTO updateIndividualClientDto);

    public Task AddCompanyClient(CompanyClient companyClient);
    public Task UpdateCompanyClient(CompanyClient companyClient, UpdateCompanyClientDTO updateCompanyClientDto);
    public Task<IndividualClient> GetIndividualClientByPesel(string pesel);
    public Task<IndividualClient> GetIndividualClientById(int individualClientId);
    public Task<CompanyClient> GetCompanyClientByKRS(string krs);
    public Task<CompanyClient> GetCompanyClientById(int companyClientId);
}