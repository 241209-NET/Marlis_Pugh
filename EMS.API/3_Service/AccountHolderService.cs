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
        throw new NotImplementedException();
    }

    public void DeleteAccountHolderById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<AccountHolder> FindAllAccounts()
    {
        var accountsList = _accountHolderRepository.FindAllAccounts();
        return accountsList;
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