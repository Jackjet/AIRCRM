using System;

namespace AIRCRM.MODEL
{
    /// <summary>
    /// 人员模块
    /// </summary>
    [Serializable]
    public class CRM_Person
    {
        /// <summary>
        /// 人员编号
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 人员GUID
        /// </summary>
        public System.Guid PersonGUID { get; set; }
        /// <summary>
        /// 人员姓名
        /// </summary>
        public string PersonName { get; set; }
        /// <summary>
        ///人员别名 
        /// </summary>
        public string PersonAliasName { get; set; }
        /// <summary>
        /// 人员状态(0:正常，1：请假，2：旷工，3：休假，4：离职，5.自离，6：其他)
        /// </summary>
        public Nullable<int> PersonStatus { get; set; }
        /// <summary>
        /// 人员手机号码
        /// </summary>
        public string PersonMobile { get; set; }
        /// <summary>
        ///人员证件号码(默认身份证号码) 
        /// </summary>
        public string PersonIDCardNumber { get; set; }
        /// <summary>
        /// 人员证件类型(0:身份证，1：驾驶证，2：军官证，3 : 港澳台护照，4: 国际护照)
        /// </summary>
        public Nullable<int> PersonIDCardType { get; set; }
        /// <summary>
        ///人员性别(0:男，1：女) 
        /// </summary>
        public int PersonGender { get; set; }
        /// <summary>
        /// 人员住址
        /// </summary>
        public string PersonAddress { get; set; }
        /// <summary>
        ///人员家庭住址 
        /// </summary>
        public string PersonHomeAddress { get; set; }
        /// <summary>
        /// 个人文凭或学位
        /// </summary>
        public string PersonDiplomaOrDegree { get; set; }
        /// <summary>
        /// 毕业学院
        /// </summary>
        public string PersonGraduateSchool { get; set; }
        /// <summary>
        /// 所学专业
        /// </summary>
        public string PersonMajor { get; set; }
        /// <summary>
        /// 职位
        /// </summary>
        public string PersonPosition { get; set; }
        /// <summary>
        ///个人薪水 
        /// </summary>
        public Nullable<decimal> PersonSalary { get; set; }
        /// <summary>
        /// 人员入职日期
        /// </summary>
        public Nullable<System.DateTime> PersonJoinDate { get; set; }
        /// <summary>
        /// 人员QQ
        /// </summary>
        public string PersonQQ { get; set; }
        /// <summary>
        /// 人员邮箱地址
        /// </summary>
        public string PersonEmail { get; set; }
        /// <summary>
        /// 人员部门GUID
        /// </summary>
        public Nullable<System.Guid> PersonDepartmentGUID { get; set; }
        /// <summary>
        /// 人员紧急联系人姓名
        /// </summary>
        public string PersonEmergencyContact { get; set; }
        /// <summary>
        /// 人员紧急联系人手机号码
        /// </summary>
        public string PersonEmergencyContactMobile { get; set; }
        /// <summary>
        /// 人员特长
        /// </summary>
        public string PersonSpecialty { get; set; }
        /// <summary>
        /// 人员角色GUID
        /// </summary>
        public Nullable<System.Guid> PersonUserGUID { get; set; }
        /// <summary>
        /// 人员工作地址
        /// </summary>
        public string PersonWorkAddress { get; set; }
        /// <summary>
        /// 人员工龄
        /// </summary>
        public Nullable<int> PersonWorkingAge { get; set; }
    }
}
