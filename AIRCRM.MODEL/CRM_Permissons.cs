using System;

namespace AIRCRM.MODEL
{
    /// <summary>
    /// 权限模块
    /// </summary>
    [Serializable]
    public class CRM_Permissons
    {
        /// <summary>
        /// 权限编号
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        ///权限GUID 
        /// </summary>
        public Guid PermissionGUID { get; set; }
        /// <summary>
        /// 权限名称
        /// </summary>
        public string PermissionName { get; set; }
        /// <summary>
        /// 权限说明
        /// </summary>
        public string PermissionDescription { get; set; }
        /// <summary>
        /// 权限状态(0:启用，1:禁用，2：锁定,3:过期)
        /// </summary>
        public bool PermissionStatus { get; set; }
        /// <summary>
        /// 权限拥有者GUID
        /// </summary>
        public string PermissionOwinerGUID { get; set; }
        /// <summary>
        /// 权限是否已过期
        /// </summary>
        public Nullable<bool> PermissionIsExpire { get; set; }
        /// <summary>
        /// 权限有效日期
        /// </summary>
        public Nullable<DateTime> PermissionValidDate { get; set; }
        /// <summary>
        /// 权限对应的菜单GUID
        /// </summary>
        public string PermissionMenuListGUID { get; set; }
    }
}
