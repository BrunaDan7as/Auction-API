using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.UseCases.Auctions.GetCurrent;

namespace RocketseatAuction.API.Controllers;
// controller: agrupamento de funcionalidades

public class AuctionController : RocketseatAuctionBaseController
{
    // IActionResult = retorno do código  ex 200, 201, 404, 503

    // Precisa passar um atributo pra função virar um endpoint
    [HttpGet]

    // devolve a entidade com o status code
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrentAuction([FromServices] GetCurrentAuctionUseCase useCase)
    {

        var result = useCase.Execute();
        if (result is null)
            return NoContent();

        return Ok(result);
    }

    
}
