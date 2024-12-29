using EMS.API.Repository;
using EMS.API.Model;

namespace EMS.API.Service;

public class AccountHolderService : IAccountHolderService
{

    private readonly IAccountHolderRepository _accountHolderRepository;

    public AccountHolderService(IAccountHolderRepository accountHolderRepository)
    {
        _accountHolderRepository = accountHolderRepository;
    }

    public AccountHolder CreateAccount(AccountHolder newAccount)
    {
        return _accountHolderRepository.CreateAccount(newAccount);
    }

    public AccountHolder? DeleteAccountHolderById(int id)
    {
         var p = GetAccountById(id);
        if(p is not null) _accountHolderRepository.DeleteAccountHolderById(id);
        return p;
    }

    public IEnumerable<AccountHolder> FindAllAccounts()
    {
        var accountsList = _accountHolderRepository.FindAllAccounts();
        return accountsList;
    }

    public AccountHolder? GetAccountById(int id)
    {
        if(id < 1) return null;
        return _accountHolderRepository.GetAccountById(id);
    }

    public IEnumerable<AccountHolder> GetAccountByName(string name)
    {
        throw new NotImplementedException();
    }

    public AccountHolder? UpdateAccountById(int id, string email)
    {

        AccountHolder? acc = GetAccountById(id);
        if(acc is not null) _accountHolderRepository.UpdateAccountHolderById(id, email);
        return acc;
       
    }
}