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

    public async Task<IActionResult> GetAllBranchForListByCountry([FromHeader] string country)
    {
        // לבדוק מה לעשות עם אין סניפים במדינה.
        var branchesForList = await _branchForCustomerService.GetAllBranchForListByCountry(country);

        return Ok(branchesForList);
    }

    [HttpGet(Name = "branchId/{branchId:int}")]
    public async Task<IActionResult> GetBranchForCustomer([FromHeader]int branchId)
    {
        var branchForCustomer = await _branchForCustomerService.GetBranchForCustomer(branchId);

        return branchForCustomer is null ? NotFound(branchForCustomer) : Ok(branchForCustomer);
    }

}
