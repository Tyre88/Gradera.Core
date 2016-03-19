﻿using Gradera.Core.DAL;
using Gradera.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradera.Core.BLL
{
    public class AuthenticateBLL
    {
        public static Account Login(string userName, string password)
        {
            string hashedPassword = Sha256Helper.GetHashSha256(password);

            Account acc = AuthenticateDAL.Login(userName, hashedPassword);

            if (acc != null)
                AccountDAL.AddToLoginLog(acc);

            return acc;
        }
    }
}
