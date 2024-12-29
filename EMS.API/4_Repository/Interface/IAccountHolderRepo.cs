using EMS.API.Model;

namespace EMS.API.Repository;


public interface IAccountHolderRepository
{

AccountHolder CreateAccount(AccountHolder newAccount);
IEnumerable<AccountHolder> FindAllAccounts();
AccountHolder? GetAccountById(int id);
IEnumerable<AccountHolder> GetAccountByName(string name);
void DeleteAccountHolderById(int id);

AccountHolder? UpdateAccountHolderById(int id, string name);







}