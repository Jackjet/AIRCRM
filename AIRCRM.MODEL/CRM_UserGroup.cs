using System;

namespace AIRCRM.MODEL
{
    /// <summary>
    /// 用户组模块
    /// </summary>
    [Serializable]
    public class CRM_UserGroup
    {
        /// <summary>
        /// 用户组编号
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 用户组GUID
        /// </summary>
        public System.Guid UserGroupGUID { get; set; }
        /// <summary>
        /// 用户组名称
        /// </summary>
        public string UserGroupName { get; set; }
        /// <summary>
        /// 用户组创建者
        /// </summary>
        public string UserGroupCreater { get; set; }
        /// <summary>
        /// 用户组创建日期
        /// </summary>
        public System.DateTime UserGroupCreateDate { get; set; }
        /// <summary>
        /// 用户组状态(0:启用，1：禁用，2：新增，3：锁定)
        /// </summary>
        public bool UserGroupStatus { get; set; }
        /// <summary>
        /// 用户组成员列表GUID
        /// </summary>
        public string UserGroupMembersGUID { get; set; }
        /// <summary>
        /// 用户组权限列表GUID
        /// </summary>
        public string UserGroupPermissionListGUID { get; set; }
        /// <summary>
        /// 用户组有效期(空值为永久有效)
        /// </summary>
        public Nullable<System.DateTime> UserGroupValidDate { get; set; }
        /// <summary>
        /// 用户组是否已过期
        /// </summary>
        public Nullable<bool> UserGroupIsExpire { get; set; }
        /// <summary>
        /// 用户组说明
        /// </summary>
        public string UserGroupDescription { get; set; }
        /// <summary>
        /// 用户组的角色GUID
        /// </summary>
        public Nullable<System.Guid> UserGroupRoleGUID { get; set; }
    }
}
