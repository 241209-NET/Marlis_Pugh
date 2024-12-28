using Microsoft.EntityFrameworkCore;
using EMS.API.Model;
using EMS.API.Data;


namespace EMS.API.Repository;



public class AccountHolderRepository : IAccountHolderRepository
{

    private readonly EmployeeContext _empContext;

    public AccountHolderRepository(EmployeeContext empContext)
    {
        _empContext = empContext;
    }
    public AccountHolder CreateAccount(AccountHolder newAccount)
    {
        throw new NotImplementedException();
    }

    public void DeleteAccountHolderById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<AccountHolder> FindAllAccounts()
    {
        return _empContext.AccountHolders.ToList();
    }

    public AccountHolder? GetAccountById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<AccountHolder> GetAccountByName(string name)
    {
        throw new NotImplementedException();
    }
}