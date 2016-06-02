using Gradera.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradera.Core.DAL
{
    internal static class ContactDAL
    {
        internal static List<Contact> GetContacts(int clubId, bool unsubscribed)
        {
            List<Contact> contacts = new List<Contact>();
            try
            {
                using (CoreModel db = new CoreModel())
                {
                    contacts = db.Contact.Where(c => c.ClubId == clubId && c.IsUnsubscribed == unsubscribed && (bool)c.IsDeleted).ToList();
                }
            }
            catch (Exception ex)
            {
                LogHelper.LogError(string.Format("Couldn't get contacts"), ex, clubId);
            }

            return contacts;
        }

        internal static Contact GetContact(int id)
        {
            using (CoreModel db = new CoreModel())
            {
                return db.Contact.Where(c => c.Id == id).FirstOrDefault();
            }
        }
    }
}
