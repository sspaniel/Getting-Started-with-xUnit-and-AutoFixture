using System.Threading.Tasks;
using xUnitAutoFixture.Abstractions;
using xUnitAutoFixture.Models;

namespace xUnitAutoFixture
{
    public class UserManager
    {
        protected IUserRepository _userRepository { get; set; }

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> AddUser(User user)
        {
            user = await _userRepository.AddUser(user);
            return user;
        }
    }
}
