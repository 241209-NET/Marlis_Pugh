using Microsoft.AspNetCore.Authorization;
using EMS.API.Model;
using EMS.API.Service;
using Microsoft.AspNetCore.Mvc;


namespace EMS.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class AccountHolderController : ControllerBase
{
    
    private readonly IAccountHolderService _accountHolderService;

    public AccountHolderController (IAccountHolderService accountHolderService)
    {
        _accountHolderService = accountHolderService;
    }

    [HttpGet]
    public IActionResult GetAllAccounts() 
    {
        var accountHolderList = _accountHolderService.FindAllAccounts();
        IActionResult VerbStatus = Ok(accountHolderList);
        
        return VerbStatus;
    }

    [HttpPost]
    public IActionResult CreateAccount(AccountHolder newAccountHolder)
    {
        var acc = _accountHolderService.CreateAccount(newAccountHolder);
        var VerbStatus = Ok(acc);
        return VerbStatus;
    }

    [HttpDelete]
    public IActionResult DeleteAccount(int id)
    {
        var deleteAcc = _accountHolderService.DeleteAccountHolderById(id);

        if(deleteAcc is null) return NotFound();
        var VerbStatus = Ok(deleteAcc);

        return VerbStatus;
    }

     [HttpPut]
    public IActionResult UpdateAccount(int id, string email)
    {
        var updateAcc = _accountHolderService.UpdateAccountById(id, email);

        if(updateAcc is null) return NotFound();
        var VerbStatus = Ok(updateAcc);

        return VerbStatus;
    }






}