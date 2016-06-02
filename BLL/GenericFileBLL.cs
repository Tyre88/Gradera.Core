using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gradera.Core.DAL;
using Gradera.Core.Enums;

namespace Gradera.Core.BLL
{
    public static class GenericFileBLL
    {
        public static GenericFile GetGenericFile(GenericFileType fileType, GenericFileModuleType moduleType, int objectId)
        {
            return GenericFileDAL.GetGenericFile(fileType, moduleType, objectId);
        }

        public static void SaveGenericFile(GenericFile file)
        {
            if (file.Id > 0)
                GenericFileDAL.UpdateGenericFile(file);
            else
                GenericFileDAL.SaveGenericFile(file);
        }

        
    }
}
