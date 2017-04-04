using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using AIRCRM.DAL.DBHelper;
using AIRCRM.IDAL.Organization;
using AIRCRM.MODEL;
namespace AIRCRM.DAL.Organization
{
    public class PersonDAL : IPersonDAL
    {
        /// <summary>
        ///增加一条记录到人员表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add(CRM_Person model)
        {
            StringBuilder _sb = new StringBuilder();
            _sb.AppendFormat(@"
            INSERT INTO [dbo].[CRM_Person]
           ([PersonGUID]
           ,[PersonName]
           ,[PersonAliasName]
           ,[PersonStatus]
           ,[PersonMobile]
           ,[PersonIDCardNumber]
           ,[PersonIDCardType]
           ,[PersonGender]
           ,[PersonAddress]
           ,[PersonHomeAddress]
           ,[PersonDiplomaOrDegree]
           ,[PersonGraduateSchool]
           ,[PersonMajor]
           ,[PersonPosition]
           ,[PersonSalary]
           ,[PersonJoinDate]
           ,[PersonQQ]
           ,[PersonEmail]
           ,[PersonEmergencyContact]
           ,[PersonEmergencyContactMobile]
           ,[PersonSpecialty]
           ,[PersonWorkAddress]
           ,[PersonWorkingAge])
           VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}',
            '{13}','{14}','{15}','{16}','{17}',{18},'{19}','{20}','{21}',{22})",
             model.PersonGUID,model.PersonName,model.PersonAliasName,model.PersonStatus,model.PersonMobile,model.PersonIDCardNumber,
             model.PersonIDCardType,model.PersonGender,model.PersonAddress,model.PersonHomeAddress,model.PersonDiplomaOrDegree,model.PersonGraduateSchool,
             model.PersonMajor, model.PersonPosition, model.PersonSalary, model.PersonJoinDate, model.PersonQQ, model.PersonEmail,
             model.PersonEmergencyContact, model.PersonEmergencyContactMobile, model.PersonSpecialty, model.PersonWorkAddress, model.PersonWorkingAge);
            SqlHelper.Open();
            int result = SqlHelper.ExecuteNonQuery(_sb.ToString());
            return result;

        }
        /// <summary>
        /// 从人员表根据指定ID删除一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            StringBuilder _sb = new StringBuilder(" DELETE FROM [dbo].[CRM_Person] ");
             _sb.AppendFormat(@" WHERE ID = {0}",id);
            SqlHelper.Open();
            int result = SqlHelper.ExecuteNonQuery(_sb.ToString());
            return result > 0;
        }

        public bool Delete(Guid guid)
        {
            StringBuilder _sb = new StringBuilder(" DELETE FROM [dbo].[CRM_Person] ");
            _sb.AppendFormat(@" WHERE PersonGUID = '{0}' ", guid);
            SqlHelper.Open();
            int result = SqlHelper.ExecuteNonQuery(_sb.ToString());
            return result > 0;
        }

        public bool Update(CRM_Person model)
        {
            StringBuilder _sb = new StringBuilder();
            _sb.AppendFormat(@"
           UPDATE [dbo].[CRM_Person]  SET 
            [PersonName] = '{0}'
           ,[PersonAliasName] = '{1}'
           ,[PersonStatus] = '{2}'
           ,[PersonMobile] = '{3}'
           ,[PersonIDCardNumber] = '{4}'
           ,[PersonIDCardType] = '{5}'
           ,[PersonGender] = '{6}'
           ,[PersonAddress] = '{7}'
           ,[PersonHomeAddress] = '{8}'
           ,[PersonDiplomaOrDegree] = '{9}'
           ,[PersonGraduateSchool] = '{10}'
           ,[PersonMajor] = '{11}'
           ,[PersonPosition] = '{12}'
           ,[PersonSalary] = '{13}'
           ,[PersonJoinDate] = '{14}'
           ,[PersonQQ] = '{15}'
           ,[PersonEmail] = '{16}'
           ,[PersonDepartmentGUID] = '{17}'
           ,[PersonEmergencyContact] = '{18}'
           ,[PersonEmergencyContactMobile] = '{19}'
           ,[PersonSpecialty] = '{20}'
           ,[PersonUserGUID] = '{21}'
           ,[PersonWorkAddress] = '{22}'
           ,[PersonWorkingAge] = '{23}'
            WHERE [PersonGUID] = '{24}'   ",
             model.PersonName, model.PersonAliasName, model.PersonStatus, model.PersonMobile, model.PersonIDCardNumber,
             model.PersonIDCardType, model.PersonGender, model.PersonAddress, model.PersonHomeAddress, model.PersonDiplomaOrDegree, model.PersonGraduateSchool,
             model.PersonMajor, model.PersonPosition, model.PersonSalary, model.PersonJoinDate, model.PersonQQ, model.PersonEmail, model.PersonDepartmentGUID,
             model.PersonEmergencyContact, model.PersonEmergencyContactMobile, model.PersonSpecialty, model.PersonUserGUID, model.PersonWorkAddress, model.PersonWorkingAge, model.PersonGUID);
            SqlHelper.Open();
            int result = SqlHelper.ExecuteNonQuery(_sb.ToString());
            return result > 0;
        }

        public CRM_Person Select(int id)
        {
            StringBuilder _sb = new StringBuilder();
            _sb.AppendFormat(@" SELECT * FROM [dbo].[CRM_Person] WHERE ID = {0}", id);
            SqlHelper.Open();
            SqlDataReader reader = SqlHelper.ExecuteReader(_sb.ToString());
            CRM_Person model = new CRM_Person();
            while (reader.Read())
            {
                model.PersonName = Convert.IsDBNull(reader["PersonName"]) ? "" : reader["PersonName"].ToString();
                model.PersonAliasName = Convert.IsDBNull(reader["PersonAliasName"]) ? "" : reader["PersonAliasName"].ToString();
                model.PersonStatus = Convert.IsDBNull(reader["PersonStatus"]) ? 0 : Convert.ToInt32(reader["PersonStatus"]);
                model.PersonMobile = Convert.IsDBNull(reader["PersonMobile"]) ? "" : reader["PersonMobile"].ToString();
                model.PersonIDCardNumber = Convert.IsDBNull(reader["PersonIDCardNumber"]) ? "" : reader["PersonIDCardNumber"].ToString();
                model.PersonIDCardType = Convert.IsDBNull(reader["PersonIDCardType"]) ? 0 : Convert.ToInt32(reader["PersonIDCardType"]);
                model.PersonGender = Convert.IsDBNull(reader["PersonGender"]) ? 0 : Convert.ToInt32(reader["PersonGender"]);
                model.PersonAddress = Convert.IsDBNull(reader["PersonAddress"]) ? "" : reader["PersonAddress"].ToString();
                model.PersonHomeAddress = Convert.IsDBNull(reader["PersonHomeAddress"]) ? "" : reader["PersonHomeAddress"].ToString();
                model.PersonDiplomaOrDegree = Convert.IsDBNull(reader["PersonDiplomaOrDegree"]) ? "" : reader["PersonDiplomaOrDegree"].ToString();
                model.PersonGraduateSchool = Convert.IsDBNull(reader["PersonGraduateSchool"]) ? "" : reader["PersonGraduateSchool"].ToString();
                model.PersonMajor = Convert.IsDBNull(reader["PersonMajor"]) ? "" : reader["PersonMajor"].ToString();
                model.PersonPosition = Convert.IsDBNull(reader["PersonPosition"]) ? "" : reader["PersonPosition"].ToString();
                model.PersonSalary = Convert.IsDBNull(reader["PersonSalary"]) ? 0 : decimal.Parse(reader["PersonSalary"].ToString());
                model.PersonJoinDate = Convert.IsDBNull(reader["PersonJoinDate"]) ? new DateTime() : Convert.ToDateTime(reader["PersonJoinDate"]);
                model.PersonQQ = Convert.IsDBNull(reader["PersonQQ"]) ? "" : reader["PersonQQ"].ToString();
                model.PersonEmail = Convert.IsDBNull(reader["PersonEmail"]) ? "" : reader["PersonEmail"].ToString();
                model.PersonDepartmentGUID = Convert.IsDBNull(reader["PersonDepartmentGUID"]) ? new Guid() : Guid.Parse(reader["PersonDepartmentGUID"].ToString());
                model.PersonEmergencyContact = Convert.IsDBNull(reader["PersonEmergencyContact"]) ? "" : reader["PersonEmergencyContact"].ToString();
                model.PersonEmergencyContactMobile = Convert.IsDBNull(reader["PersonEmergencyContactMobile"]) ? "" : reader["PersonEmergencyContactMobile"].ToString();
                model.PersonSpecialty = Convert.IsDBNull(reader["PersonSpecialty"]) ? "" : reader["PersonSpecialty"].ToString();
                model.PersonUserGUID = Convert.IsDBNull(reader["PersonUserGUID"]) ? new Guid() : Guid.Parse(reader["PersonUserGUID"].ToString());
                model.PersonWorkAddress = Convert.IsDBNull(reader["PersonWorkAddress"]) ? "" : reader["PersonWorkAddress"].ToString();
                model.PersonWorkingAge = Convert.IsDBNull(reader["PersonWorkingAge"]) ? 0 : Convert.ToInt32(reader["PersonWorkingAge"]);
                model.PersonGUID = Convert.IsDBNull(reader["PersonGUID"]) ? new Guid() : Guid.Parse(reader["PersonGUID"].ToString());
            }
            return model;
        }

        public CRM_Person Select(Guid guid)
        {
            StringBuilder _sb = new StringBuilder();
            _sb.AppendFormat(@" SELECT * FROM [dbo].[CRM_Person] WHERE PersonGUID = '{0}' ", guid);
            SqlHelper.Open();
            SqlDataReader reader = SqlHelper.ExecuteReader(_sb.ToString());
            CRM_Person model = new CRM_Person();
            while (reader.Read())
            {
                model.PersonName = Convert.IsDBNull(reader["PersonName"]) ? "" : reader["PersonName"].ToString();
                model.PersonAliasName = Convert.IsDBNull(reader["PersonAliasName"]) ? "" : reader["PersonAliasName"].ToString();
                model.PersonStatus = Convert.IsDBNull(reader["PersonStatus"]) ? 0 : Convert.ToInt32(reader["PersonStatus"]);
                model.PersonMobile = Convert.IsDBNull(reader["PersonMobile"]) ? "" : reader["PersonMobile"].ToString();
                model.PersonIDCardNumber = Convert.IsDBNull(reader["PersonIDCardNumber"]) ? "" : reader["PersonIDCardNumber"].ToString();
                model.PersonIDCardType = Convert.IsDBNull(reader["PersonIDCardType"]) ? 0 : Convert.ToInt32(reader["PersonIDCardType"]);
                model.PersonGender = Convert.IsDBNull(reader["PersonGender"]) ? 0 : Convert.ToInt32(reader["PersonGender"]);
                model.PersonAddress = Convert.IsDBNull(reader["PersonAddress"]) ? "" : reader["PersonAddress"].ToString();
                model.PersonHomeAddress = Convert.IsDBNull(reader["PersonHomeAddress"]) ? "" : reader["PersonHomeAddress"].ToString();
                model.PersonDiplomaOrDegree = Convert.IsDBNull(reader["PersonDiplomaOrDegree"]) ? "" : reader["PersonDiplomaOrDegree"].ToString();
                model.PersonGraduateSchool = Convert.IsDBNull(reader["PersonGraduateSchool"]) ? "" : reader["PersonGraduateSchool"].ToString();
                model.PersonMajor = Convert.IsDBNull(reader["PersonMajor"]) ? "" : reader["PersonMajor"].ToString();
                model.PersonPosition = Convert.IsDBNull(reader["PersonPosition"]) ? "" : reader["PersonPosition"].ToString();
                model.PersonSalary = Convert.IsDBNull(reader["PersonSalary"]) ? 0 : decimal.Parse(reader["PersonSalary"].ToString());
                model.PersonJoinDate = Convert.IsDBNull(reader["PersonJoinDate"]) ? new DateTime() : Convert.ToDateTime(reader["PersonJoinDate"]);
                model.PersonQQ = Convert.IsDBNull(reader["PersonQQ"]) ? "" : reader["PersonQQ"].ToString();
                model.PersonEmail = Convert.IsDBNull(reader["PersonEmail"]) ? "" : reader["PersonEmail"].ToString();
                model.PersonDepartmentGUID = Convert.IsDBNull(reader["PersonDepartmentGUID"]) ? new Guid() : Guid.Parse(reader["PersonDepartmentGUID"].ToString());
                model.PersonEmergencyContact = Convert.IsDBNull(reader["PersonEmergencyContact"]) ? "" : reader["PersonEmergencyContact"].ToString();
                model.PersonEmergencyContactMobile = Convert.IsDBNull(reader["PersonEmergencyContactMobile"]) ? "" : reader["PersonEmergencyContactMobile"].ToString();
                model.PersonSpecialty = Convert.IsDBNull(reader["PersonSpecialty"]) ? "" : reader["PersonSpecialty"].ToString();
                model.PersonUserGUID = Convert.IsDBNull(reader["PersonUserGUID"]) ? new Guid() : Guid.Parse(reader["PersonUserGUID"].ToString());
                model.PersonWorkAddress = Convert.IsDBNull(reader["PersonWorkAddress"]) ? "" : reader["PersonWorkAddress"].ToString();
                model.PersonWorkingAge = Convert.IsDBNull(reader["PersonWorkingAge"]) ? 0 : Convert.ToInt32(reader["PersonWorkingAge"]);
                model.PersonGUID = Convert.IsDBNull(reader["PersonGUID"]) ? new Guid() : Guid.Parse(reader["PersonGUID"].ToString());
            }
            return model;
        }

        public List<CRM_Person> GetList(string idList)
        {
            throw new NotImplementedException();
        }

        public List<CRM_Person> GetList(List<Guid> guidList)
        {
            throw new NotImplementedException();
        }

        public List<CRM_Person> GetPageList(int pageSize, int pageIndex, string strWhere)
        {
            throw new NotImplementedException();
        }


        public List<CRM_Person> SelectAll()
        {
            StringBuilder _sb = new StringBuilder();
            _sb.AppendFormat(@" SELECT * FROM [dbo].[CRM_Person]");
            SqlHelper.Open();
            SqlDataReader reader = SqlHelper.ExecuteReader(_sb.ToString());
            List<CRM_Person> persons = new List<CRM_Person>();
            
            while (reader.Read())
            {
                CRM_Person model = new CRM_Person();
                model.PersonName = Convert.IsDBNull(reader["PersonName"]) ? "" : reader["PersonName"].ToString();
                model.PersonAliasName = Convert.IsDBNull(reader["PersonAliasName"]) ? "" : reader["PersonAliasName"].ToString();
                model.PersonStatus = Convert.IsDBNull(reader["PersonStatus"]) ? 0 : Convert.ToInt32(reader["PersonStatus"]);
                model.PersonMobile = Convert.IsDBNull(reader["PersonMobile"]) ? "" : reader["PersonMobile"].ToString();
                model.PersonIDCardNumber = Convert.IsDBNull(reader["PersonIDCardNumber"]) ? "" : reader["PersonIDCardNumber"].ToString();
                model.PersonIDCardType = Convert.IsDBNull(reader["PersonIDCardType"]) ? 0 : Convert.ToInt32(reader["PersonIDCardType"]);
                model.PersonGender = Convert.IsDBNull(reader["PersonGender"]) ? 0 : Convert.ToInt32(reader["PersonGender"]);
                model.PersonAddress = Convert.IsDBNull(reader["PersonAddress"]) ? "" : reader["PersonAddress"].ToString();
                model.PersonHomeAddress = Convert.IsDBNull(reader["PersonHomeAddress"]) ? "" : reader["PersonHomeAddress"].ToString();
                model.PersonDiplomaOrDegree = Convert.IsDBNull(reader["PersonDiplomaOrDegree"]) ? "" : reader["PersonDiplomaOrDegree"].ToString();
                model.PersonGraduateSchool = Convert.IsDBNull(reader["PersonGraduateSchool"]) ? "" : reader["PersonGraduateSchool"].ToString();
                model.PersonMajor = Convert.IsDBNull(reader["PersonMajor"]) ? "" : reader["PersonMajor"].ToString();
                model.PersonPosition = Convert.IsDBNull(reader["PersonPosition"]) ? "" : reader["PersonPosition"].ToString();
                model.PersonSalary = Convert.IsDBNull(reader["PersonSalary"]) ? 0 : decimal.Parse(reader["PersonSalary"].ToString());
                model.PersonJoinDate = Convert.IsDBNull(reader["PersonJoinDate"]) ? new DateTime() : Convert.ToDateTime(reader["PersonJoinDate"]);
                model.PersonQQ = Convert.IsDBNull(reader["PersonQQ"]) ? "" : reader["PersonQQ"].ToString();
                model.PersonEmail = Convert.IsDBNull(reader["PersonEmail"]) ? "" : reader["PersonEmail"].ToString();
                model.PersonDepartmentGUID = Convert.IsDBNull(reader["PersonDepartmentGUID"]) ? new Guid() : Guid.Parse(reader["PersonDepartmentGUID"].ToString());
                model.PersonEmergencyContact = Convert.IsDBNull(reader["PersonEmergencyContact"]) ? "" : reader["PersonEmergencyContact"].ToString();
                model.PersonEmergencyContactMobile = Convert.IsDBNull(reader["PersonEmergencyContactMobile"]) ? "" : reader["PersonEmergencyContactMobile"].ToString();
                model.PersonSpecialty = Convert.IsDBNull(reader["PersonSpecialty"]) ? "" : reader["PersonSpecialty"].ToString();
                model.PersonUserGUID = Convert.IsDBNull(reader["PersonUserGUID"]) ? new Guid() : Guid.Parse(reader["PersonUserGUID"].ToString());
                model.PersonWorkAddress = Convert.IsDBNull(reader["PersonWorkAddress"]) ? "" : reader["PersonWorkAddress"].ToString();
                model.PersonWorkingAge = Convert.IsDBNull(reader["PersonWorkingAge"]) ? 0 : Convert.ToInt32(reader["PersonWorkingAge"]);
                model.PersonGUID = Convert.IsDBNull(reader["PersonGUID"]) ? new Guid() : Guid.Parse(reader["PersonGUID"].ToString());
                persons.Add(model);
            }
            return persons;
            
        }
    }
}
