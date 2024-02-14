using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories.DataAcess;

public class UserRepository : IUserRepository
{

    private readonly RocketseatAuctionDbContext _dbcontext;

    public UserRepository(RocketseatAuctionDbContext dbContext) => _dbcontext = dbContext;

    public bool ExistUserWithEmail(string email)
    {
      return  _dbcontext.Users.Any(user => user.Email.Equals(email));
    }

    public User GetUserByEmail(string email) => _dbcontext.Users.First(user => user.Email.Equals(email));
}
