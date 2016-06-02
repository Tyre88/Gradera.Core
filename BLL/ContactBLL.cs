using Gradera.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradera.Core.BLL
{
    public static class ContactBLL
    {
        public static List<Contact> GetContacts(int clubId, bool unsubscribed = false)
        {
            return ContactDAL.GetContacts(clubId, unsubscribed);
        }

        public static Contact GetContact(int id)
        {
            return ContactDAL.GetContact(id);
        }
    }
}
