using System;
namespace AIRCRM.MODEL
{
    /// <summary>
    /// 角色模块
    /// </summary>
    [Serializable]
    public class CRM_Role
    {
        /// <summary>
        /// 角色编号
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 角色GUID
        /// </summary>
        public System.Guid RoleGUID { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// 角色别名
        /// </summary>
        public string RoleAliasName { get; set; }
        /// <summary>
        /// 角色说明
        /// </summary>
        public string RoleDescription { get; set; }
        /// <summary>
        /// 角色级别
        /// </summary>
        public int RoleLevel { get; set; }
        /// <summary>
        /// 上一级角色GUID
        /// </summary>
        public System.Guid RoleParentGUID { get; set; }
        /// <summary>
        ///角色权限清单GUID 
        /// </summary>
        public string RolePermissionListGUID { get; set; }
    }
}
