using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data.Models;

namespace Kamall_foods_server_aspNetCore.Repository.IRepository
{
    public interface IRestaurantAdminRepository
    {
        public Task Create(RestaurantAdminCreateRequest request);
        public Task CreationValidation(RestaurantAdminCreateRequest request);
    }
}