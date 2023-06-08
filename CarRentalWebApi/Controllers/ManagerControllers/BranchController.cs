using CarRentalBL.BLApi.IManager;
using CarRentalBL.BusinessEntities.Branch;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalWebApi.Controllers.ManagerControllers;

[ApiController]
[Route("[controller]/[action]")]
public class BranchController : ControllerBase
{
    private readonly IBranchForManagerService _branchForManagerService;

    public BranchController(IBranchForManagerService branchForManagerService)
    {
        _branchForManagerService = branchForManagerService;
    }

    [HttpPost]
    public async Task<IActionResult> AddBranch([FromBody] BranchForManager branchForManager)
    {
        await _branchForManagerService.Add(branchForManager);

        return CreatedAtAction(nameof(GetBranch), branchForManager.BranchId);

    }

    [HttpDelete("branchId/{branchId:int}")]
    public async Task<IActionResult> DeleteBranch([FromRoute] int branchId)
    {
        await _branchForManagerService.Delete(branchId);

        return Ok(branchId);

    }

    [HttpPut]
    public async Task<IActionResult> UpdateBranch([FromBody] BranchForManager branchForManager)
    {
        await _branchForManagerService.Update(branchForManager);

        return Ok(branchForManager);
    }

    [HttpGet("branchId/{branchId:int}")]
    public async Task<IActionResult> GetBranch([FromRoute] int branchId)
    {
        var branch = await _branchForManagerService.GetBranchForManager(branchId);

        return Ok(branch);
    }

}
