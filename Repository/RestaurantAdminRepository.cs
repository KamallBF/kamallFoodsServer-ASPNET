using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data.Context;
using Kamall_foods_server_aspNetCore.Data.Models;
using Kamall_foods_server_aspNetCore.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Kamall_foods_server_aspNetCore.Repository
{
    public class RestaurantAdminRepository : IRestaurantAdminRepository
    {
        private readonly DatabaseContext _context;

        public RestaurantAdminRepository(DbContextOptions<DatabaseContext> optionsBuilder)
        {
            _context = new DatabaseContext(optionsBuilder);
        }

        public Task Create(RestaurantAdminCreateRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task CreationValidation(RestaurantAdminCreateRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}