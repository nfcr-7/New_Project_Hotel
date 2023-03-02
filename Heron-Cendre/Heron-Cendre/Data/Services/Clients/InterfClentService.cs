namespace Heron_Cendre.Data.Services.Clients
{
    public interface InterfClentService
    {
        Task<IEnumerable<Client>> GetAll();

        Clients GetById(int id); //pour recuperer le client en question
        Task AddAsync(Client clients); // pour l'ajout

        Clients Update(int id, Clients newClient); // pour la moification

        void Delete(int id);   // pour la suppression
    }
}
