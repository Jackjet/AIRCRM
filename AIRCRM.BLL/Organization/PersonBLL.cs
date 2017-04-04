using System;
using System.Collections.Generic;
using AIRCRM.DAL.Organization;
using AIRCRM.IDAL.Organization;
using AIRCRM.MODEL;


namespace AIRCRM.BLL.Organization
{
    public class PersonBLL
    {
        private IPersonDAL _personDal = null;

        public PersonBLL()
        {
           _personDal = new PersonDAL();
        }
        /// <summary>
        /// 添加人员
        /// </summary>
        /// <param name="person">人员对象</param>
        /// <returns></returns>
        public int Add(CRM_Person person)
        {
            return _personDal.Add(person);
        }
        /// <summary>
        /// 删除一个人员
        /// </summary>
        /// <param name="guid">人员GUID</param>
        /// <returns></returns>
        public bool Delete(Guid guid)
        {
            return _personDal.Delete(guid);
        }
        /// <summary>
        /// 删除一个人员
        /// </summary>
        /// <param name="id">人员ID</param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            return _personDal.Delete(id);
        }
        /// <summary>
        /// 更新一个人员
        /// </summary>
        /// <param name="person">人员对象</param>
        /// <returns></returns>
        public bool Update(CRM_Person person)
        {
            return _personDal.Update(person);
        }
        /// <summary>
        /// 查询一个人员信息，并返回该人员信息
        /// </summary>
        /// <param name="guid">人员对象GUID</param>
        /// <returns>返回该人员信息</returns>
        public CRM_Person Select(Guid guid)
        {
            return _personDal.Select(guid);
        }
        /// <summary>
        /// 查询一个人员信息，并返回该人员信息
        /// </summary>
        /// <param name="id">人员对象ID</param>
        /// <returns>返回该人员信息</returns>
        public CRM_Person Select(int id)
        {
            return _personDal.Select(id);
        }
        /// <summary>
        /// 查询并返回所有人员信息
        /// </summary>
        /// <returns>返回所有人员信息</returns>
        public List<CRM_Person> SelectAll()
        {
            return _personDal.SelectAll();
        }
    }
}
