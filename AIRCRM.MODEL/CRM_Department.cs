using System;

namespace AIRCRM.MODEL
{
    
    /// <summary>
    /// 部门模块
    /// </summary>
    [Serializable]
    public class CRM_Department
    {
        /// <summary>
        /// 组织机构-部门编号
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 组织机构-部门GUID
        /// </summary>
        public System.Guid DepartmentGUID { get; set; }
        /// <summary>
        /// 组织机构-部门名称
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// 组织机构-部门别名
        /// </summary>
        public string DepartmentAliasName { get; set; }
        /// <summary>
        /// 组织机构-状态(0:启用，1：禁用)
        /// </summary>
        public bool DepartmentStatus { get; set; }
        /// <summary>
        /// 上一级部门GUID
        /// </summary>
        public Nullable<System.Guid> DepartmentParentGUID { get; set; }
        /// <summary>
        /// 组织机构-部门说明
        /// </summary>
        public string DepartmentDescription { get; set; }
        /// <summary>
        /// 部门管理者GUID
        /// </summary>
        public Nullable<System.Guid> DepartmentManagerGUID { get; set; }
        /// <summary>
        ///组织机构-部门类型GUID 
        /// </summary>
        public Nullable<System.Guid> DepartmentTypeGUID { get; set; }
        /// <summary>
        ///部门所属组织机构GUID 
        /// </summary>
        public Nullable<System.Guid> DepartmetnOrganizationGUID { get; set; }
    }
}
