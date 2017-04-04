using System;
using System.Collections.Generic;
using AIRCRM.IDAL.Permission;
using AIRCRM.MODEL;

namespace AIRCRM.DAL.Permission
{
    class PermissionDAL : IPermissionDAL
    {
        public int Add(CRM_Permissons model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid guid)
        {
            throw new NotImplementedException();
        }

        public bool Update(CRM_Permissons model)
        {
            throw new NotImplementedException();
        }

        public CRM_Permissons Select(int id)
        {
            throw new NotImplementedException();
        }

        public CRM_Permissons Select(Guid guid)
        {
            throw new NotImplementedException();
        }

        public List<CRM_Permissons> GetList(string idList)
        {
            throw new NotImplementedException();
        }

        public List<CRM_Permissons> GetList(List<Guid> guidList)
        {
            throw new NotImplementedException();
        }

        public List<CRM_Permissons> GetPageList(int pageSize, int pageIndex, string strWhere)
        {
            throw new NotImplementedException();
        }


        public List<CRM_Permissons> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
