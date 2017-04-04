using System;
using System.Collections.Generic;
using AIRCRM.BLL.Organization;
using AIRCRM.MODEL;

namespace AIRCRM.TEST
{
    class ModelTest
    {
        private static void Main(string[] args)
        {
            //ObjectHandle obj = Activator.CreateInstance("AIRCRM.MODEL", "AIRCRM.MODEL.CRM_Person");
            //object p = obj.Unwrap();
            //Type t = p.GetType();
            //foreach (MemberInfo mi in t.GetMembers())
            //{
            //    Console.WriteLine(mi.Module + " : " + mi.Name + "->" + mi.MemberType);
            //}
            //Console.ReadKey();
            CRM_Person _person = new CRM_Person
            {
                PersonGUID = Guid.NewGuid(),
                PersonName = "林宏权",
                PersonAliasName = "MetroX",
                PersonStatus = 0,
                PersonMobile = "13229542876",
                PersonIDCardNumber = "440882198401044416",
                PersonIDCardType = 0,
                PersonGender = 0,
                PersonAddress = "广东省深圳市福田区岗夏村",
                PersonHomeAddress = "广东省湛江雷州州",
                PersonDiplomaOrDegree = "技工",
                PersonGraduateSchool = "湛江一技",
                PersonMajor = "计算机编程",
                PersonPosition = ".Net软件工程师",
                PersonSalary = 8000,
                PersonJoinDate = Convert.ToDateTime("2015-03-21"),
                PersonQQ = "2968191063",
                PersonEmail = "lin_hong_quan_msn1@hotmail.com",
                PersonDepartmentGUID = null,
                PersonEmergencyContact = "'阮小姐'",
                PersonEmergencyContactMobile = "13428137645",
                PersonSpecialty = "Coding",
                PersonUserGUID = null,
                PersonWorkAddress = "广东省深圳市福田区岗夏村",
                PersonWorkingAge = 1
            };

            //IPersonDAL _personDal = new PersonDAL();
            //_personDal.Add(_person);

            //IPersonDAL _personDal = new PersonDAL();

            PersonBLL _personBll = new PersonBLL();
            _personBll.Add(_person);
            List<CRM_Person> list = _personBll.SelectAll();
            foreach (CRM_Person s in list)
            {
                Console.WriteLine(s.PersonGUID + ":" + s.PersonName);
            }
            Console.ReadKey();

            //Guid pid = Guid.Parse("41764ee6-3455-4a55-a1a3-3a49eeb8adb5");
            //CRM_Person p = _personDal.Select(pid);
            //Console.WriteLine(p.PersonEmail);
            //Console.ReadKey();

            //bool isdelete = _personDal.Delete(pid);
            //Console.WriteLine(isdelete);
            //Console.ReadKey();
           
           
        }
    }
}
