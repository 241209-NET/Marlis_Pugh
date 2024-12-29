using EMS.API.Model;

namespace EMS.API.Service;


public interface IAccountHolderService
{

AccountHolder CreateAccount(AccountHolder newAccount);
IEnumerable<AccountHolder> FindAllAccounts();
AccountHolder? GetAccountById(int id);
IEnumerable<AccountHolder> GetAccountByName(string name);
AccountHolder? DeleteAccountHolderById(int id);

AccountHolder? UpdateAccountById(int id, string email);
}