namespace Heron_Cendre.Data.Services.Clients
{
    public class ClientServices : InterfClentService
    {

        private readonly AppDbContext _context;

        public ClientServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Client client)
        {
            await _context.Client.AddAsync(client);
            await _context.SaveChangesAsync();
                
        }

        public async Task<IEnumerable<Client>> GetAll()
        {
            var result = await _context.clients.ToListAsync();
            return result;
        }

        public Client GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Client Update(int id, Actor newClient)
        {
            throw new NotImplementedException();
        }
    }
}
