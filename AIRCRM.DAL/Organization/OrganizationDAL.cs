using System;
using System.Collections.Generic;
using AIRCRM.IDAL.Organization;
using AIRCRM.MODEL;

namespace AIRCRM.DAL.Organization
{
    /// <summary>
    /// 组织机构数据访问
    /// </summary>
    public class OrganizationDAL : IOrganizationDAL
    {
        public int Add(CRM_Organization model)
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

        public bool Update(CRM_Organization model)
        {
            throw new NotImplementedException();
        }

        public CRM_Organization Select(int id)
        {
            throw new NotImplementedException();
        }

        public CRM_Organization Select(Guid guid)
        {
            throw new NotImplementedException();
        }

        public List<CRM_Organization> GetList(string idList)
        {
            throw new NotImplementedException();
        }

        public List<CRM_Organization> GetList(List<Guid> guidList)
        {
            throw new NotImplementedException();
        }

        public List<CRM_Organization> GetPageList(int pageSize, int pageIndex, string strWhere)
        {
            throw new NotImplementedException();
        }


        public List<CRM_Organization> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
