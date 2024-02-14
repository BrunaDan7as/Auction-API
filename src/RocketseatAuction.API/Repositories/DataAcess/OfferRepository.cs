using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories.DataAcess;

public class OfferRepository : IOfferRepository
{
    private readonly RocketseatAuctionDbContext _dbcontext;

    public OfferRepository(RocketseatAuctionDbContext dbContext) => _dbcontext = dbContext;
    public void Add(Offer offer)
    {
        _dbcontext.Offers.Add(offer);
        _dbcontext.SaveChanges(); 
    }
}
