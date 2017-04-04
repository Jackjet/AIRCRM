using System;

namespace AIRCRM.MODEL
{
    /// <summary>
    /// 用户模块
    /// </summary>
    [Serializable]
    public class CRM_User
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 用户GUID
        /// </summary>
        public System.Guid UserGUID { get; set; }
        /// <summary>
        /// 用户组GUID
        /// </summary>
        public Nullable<System.Guid> UserGroupGUID { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPassword { get; set; }
        /// <summary>
        /// 用户类型(0:普通用户,1:客户，2：企业用户，3：系统管理员，4：开发人员，5：测试人员)
        /// </summary>
        public Nullable<int> UserType { get; set; }
        /// <summary>
        /// 用户状态(0:启用，1：禁用，2：新增，3：锁定，4：已过期)
        /// </summary>
        public bool UserStatus { get; set; }
        /// <summary>
        /// 用户通过WEB自己注册
        /// </summary>
        public Nullable<bool> IsUserRegitry { get; set; }
        /// <summary>
        /// 通过系统后台添加
        /// </summary>
        public Nullable<bool> IsSystemAdd { get; set; }
        /// <summary>
        /// 用户注册日期
        /// </summary>
        public System.DateTime RegistryDate { get; set; }
        /// <summary>
        /// 用户注册手机号码
        /// </summary>
        public string RegistryMobile { get; set; }
        /// <summary>
        /// 用户注册邮箱地址
        /// </summary>
        public string RegistryEmail { get; set; }
        /// <summary>
        /// 用户登陆次数
        /// </summary>
        public int UserLoginCounts { get; set; }
        /// <summary>
        /// 用户最后登陆时间
        /// </summary>
        public Nullable<System.DateTime> UserLastLoginDate { get; set; }
        /// <summary>
        /// 用户最后登陆地址
        /// </summary>
        public string UserLastLoginAddress { get; set; }
        /// <summary>
        /// 用户最后登陆IP地址
        /// </summary>
        public string UserLastLoginIP { get; set; }
        /// <summary>
        /// 用户密码错误次数（超过3次自动锁定用户，解锁后才能登陆）
        /// </summary>
        public Nullable<int> UserPasswordErrorCount { get; set; }
        /// <summary>
        /// 用户注册QQ号码
        /// </summary>
        public string UserRegistryQQ { get; set; }
        /// <summary>
        /// 用户权限列表
        /// </summary>
        public string UserPermissionListGUID { get; set; }
        /// <summary>
        /// 用户是否已过期(0:未过期，1：已过期)
        /// </summary>
        public bool IsExpire { get; set; }
        /// <summary>
        /// 用户有效日期(空值为永久有效)
        /// </summary>
        public Nullable<System.DateTime> ValidDate { get; set; }
        /// <summary>
        /// 用户操作日志
        /// </summary>
        public string UserOperationLog { get; set; }
        /// <summary>
        ///用户的角色GUID 
        /// </summary>
        public Nullable<System.Guid> UserRoleGUID { get; set; }
    }
}
