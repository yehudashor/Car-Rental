using CarRentalBL.BLApi.ICustomer;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalWebApi.Controllers.CustomersControllers;

[ApiController]
[Route("[controller]/[action]")] 

public class BranchForCustomerController : ControllerBase
{
    private readonly IBranchForCustomerService _branchForCustomerService;

	public BranchForCustomerController(IBranchForCustomerService branchForCustomerService)
	{
       _branchForCustomerService = branchForCustomerService;

    }

    [HttpGet]

    public async Task<IActionResult> GetAllBranchForListByCountry(string country)
    {
        var branchs = await _branchForCustomerService.GetAllBranchForListByCountry(country);

        return Ok(branchs);
    }
}
