using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradera.Core.DAL
{
    internal class AuthenticateDAL
    {
        internal static Account Login(string userName, string hashedPassword)
        {
            using (CoreModel coreDAL = new CoreModel())
            {
                Account account = coreDAL.Account.Include("Club").Include("AccountAccess")
                    .FirstOrDefault(a => a.UserName == userName && a.Password == hashedPassword);

                account.AccountAccess.ToList().ForEach(a => a.Accessright.Accessright_Right.ToList());

                return account;
            }
        }
    }
}
