using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradera.Core.DAL
{
    internal class ClubDAL
    {
        internal static Club GetClub(int clubId)
        {
            using (CoreModel coreDAL = new CoreModel())
            {
                return coreDAL.Club.FirstOrDefault(c => c.Id == clubId);
            }
        }

        internal static void SaveClub(Club club)
        {
            using (CoreModel coreDAL = new CoreModel())
            {
                coreDAL.Entry(club).State = System.Data.Entity.EntityState.Modified;
                coreDAL.SaveChanges();
            }
        }

        internal static Club GetClubByShortName(string shortName)
        {
            using (CoreModel coreDAL = new CoreModel())
            {
                return coreDAL.Club.FirstOrDefault(c => c.ShortName == shortName);
            }
        }

        internal static List<ModuleLink> GetModuleLinks(int clubId)
        {
            using (CoreModel coreDAL = new CoreModel())
            {
                return coreDAL.ModuleLink.Include("Module")
                    .Where(m => m.Module.ClubLinkModule.Any(c => c.ClubId == clubId) 
                        && (m.SpecificClubId == null || m.SpecificClubId == clubId)).ToList();
            }
        }
    }
}
