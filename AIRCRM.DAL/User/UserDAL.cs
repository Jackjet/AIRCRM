using System;
using System.Collections.Generic;
using AIRCRM.IDAL.User;
using AIRCRM.MODEL;

namespace AIRCRM.DAL.User
{
    class UserDAL : IUserDAL
    {
        public int Add(CRM_User model)
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

        public bool Update(CRM_User model)
        {
            throw new NotImplementedException();
        }

        public CRM_User Select(int id)
        {
            throw new NotImplementedException();
        }

        public CRM_User Select(Guid guid)
        {
            throw new NotImplementedException();
        }

        public List<CRM_User> GetList(string idList)
        {
            throw new NotImplementedException();
        }

        public List<CRM_User> GetList(List<Guid> guidList)
        {
            throw new NotImplementedException();
        }

        public List<CRM_User> GetPageList(int pageSize, int pageIndex, string strWhere)
        {
            throw new NotImplementedException();
        }


        public List<CRM_User> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
