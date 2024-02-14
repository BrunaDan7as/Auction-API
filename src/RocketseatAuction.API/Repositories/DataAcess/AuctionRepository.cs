using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories.DataAcess;

public class AuctionRepository : IAuctionRepository
{
    private readonly RocketseatAuctionDbContext _dbcontext;

    public AuctionRepository(RocketseatAuctionDbContext dbContext) => _dbcontext = dbContext;

    public Auction? GetCurrent()
    {
        var today = DateTime.Now;
        return _dbcontext
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }
}
