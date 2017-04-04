using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIRCRM.IDAL;
using AIRCRM.IDAL.Permission;
using AIRCRM.MODEL;

namespace AIRCRM.DAL.Permission
{
    class MenuDAL : IMenuDAL
    {
        public int Add(CRM_Menu model)
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

        public bool Update(CRM_Menu model)
        {
            throw new NotImplementedException();
        }

        public CRM_Menu Select(int id)
        {
            throw new NotImplementedException();
        }

        public CRM_Menu Select(Guid guid)
        {
            throw new NotImplementedException();
        }

        public List<CRM_Menu> GetList(string idList)
        {
            throw new NotImplementedException();
        }

        public List<CRM_Menu> GetList(List<Guid> guidList)
        {
            throw new NotImplementedException();
        }

        public List<CRM_Menu> GetPageList(int pageSize, int pageIndex, string strWhere)
        {
            throw new NotImplementedException();
        }


        public List<CRM_Menu> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
