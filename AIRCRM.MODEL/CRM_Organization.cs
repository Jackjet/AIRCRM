using System;

namespace AIRCRM.MODEL
{
    /// <summary>
    /// 组织机构模块
    /// </summary>
    [Serializable]
    public class CRM_Organization
    {
        /// <summary>
        /// 组织机构编号
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 组织机构GUID
        /// </summary>
        public System.Guid OrganizationGUID { get; set; }
        /// <summary>
        /// 组织机构名称
        /// </summary>
        public string OrganizationName { get; set; }
        /// <summary>
        ///组织机构别名 
        /// </summary>
        public string OrganizationAliasName { get; set; }
        /// <summary>
        /// 组织机构代码
        /// </summary>
        public string OrganizationCode { get; set; }
        /// <summary>
        /// 组织机构地址
        /// </summary>
        public string OrganizationAddress { get; set; }
        /// <summary>
        /// 组织机构状态(0:启用，1：禁用)
        /// </summary>
        public bool OrganizationStatus { get; set; }
        /// <summary>
        /// 组织机构类型GUID
        /// </summary>
        public Nullable<System.Guid> OrganizationTypeGUID { get; set; }
        /// <summary>
        /// 组织机构说明
        /// </summary>
        public string OrganizationDescription { get; set; }
        /// <summary>
        ///上一级组织机构GUID 
        /// </summary>
        public Nullable<System.Guid> OrganizationParentGUID { get; set; }
    }
}
