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
         _empContext.AccountHolders.Add(newAccount);
            _empContext.SaveChanges();

            return newAccount; 
    }

    public void DeleteAccountHolderById(int id)
    {
        AccountHolder? acc = GetAccountById(id);
        
            _empContext.AccountHolders.Remove(acc!);
            _empContext.SaveChanges();

            
    }

    public IEnumerable<AccountHolder> FindAllAccounts()
    {
        return _empContext.AccountHolders.ToList();
    }

    public AccountHolder? GetAccountById(int id)
    {
        return _empContext.AccountHolders.Find(id);
    }

    public IEnumerable<AccountHolder> GetAccountByName(string name)
    {
        throw new NotImplementedException();
    }

    public AccountHolder? UpdateAccountHolderById(int id, string email)
    {
        
        AccountHolder? acc = GetAccountById(id);
        acc!.email = email; 
        _empContext.AccountHolders.Update(acc);
        _empContext.SaveChanges();

        return acc;
    }
}