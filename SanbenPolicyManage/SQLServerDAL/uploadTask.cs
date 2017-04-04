using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:uploadTask
	/// </summary>
	public partial class uploadTask:IuploadTask
	{
		public uploadTask()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "uploadTask"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from uploadTask");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Sanben.Model.uploadTask model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into uploadTask(");
            strSql.Append("execution_frequency, execution_time,upload_platFrom,policy_class,upload_class,uploadPlatFrom_specialPolicies,policySource,tripType,execute_number,condition,sys_id,uploadType,NextFullTime,NextAddTime,Uploading)");
			strSql.Append(" values (");
			strSql.Append("@execution_frequency,@execution_time,@upload_platFrom,@policy_class,@upload_class,@uploadPlatFrom_specialPolicies,@policySource,@tripType,@execute_number,@condition,@sys_id,@uploadType,@NextFullTime,@NextAddTime,@Uploading)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@execution_frequency", SqlDbType.VarChar,150),
					new SqlParameter("@execution_time", SqlDbType.DateTime),
					new SqlParameter("@upload_platFrom", SqlDbType.VarChar,50),
					new SqlParameter("@policy_class", SqlDbType.VarChar,50),
					new SqlParameter("@upload_class", SqlDbType.Int,4),
					new SqlParameter("@uploadPlatFrom_specialPolicies", SqlDbType.Bit,1),
					new SqlParameter("@policySource", SqlDbType.VarChar,255),
					new SqlParameter("@tripType", SqlDbType.Int,4),
					new SqlParameter("@execute_number", SqlDbType.Int,4),
					new SqlParameter("@condition", SqlDbType.Bit,1),
					new SqlParameter("@sys_id", SqlDbType.Int,4),
					new SqlParameter("@uploadType", SqlDbType.Int,4),
					new SqlParameter("@NextFullTime", SqlDbType.DateTime),
					new SqlParameter("@NextAddTime", SqlDbType.DateTime),
					new SqlParameter("@Uploading", SqlDbType.Bit,1)};
			parameters[0].Value = model.execution_frequency;
			parameters[1].Value = model.execution_time;
			parameters[2].Value = model.upload_platFrom;
			parameters[3].Value = model.policy_class;
			parameters[4].Value = model.upload_class;
			parameters[5].Value = model.uploadPlatFrom_specialPolicies;
			parameters[6].Value = model.policySource;
			parameters[7].Value = model.tripType;
			parameters[8].Value = model.execute_number;
			parameters[9].Value = model.condition;
			parameters[10].Value = model.sys_id;
			parameters[11].Value = model.uploadType;
			parameters[12].Value = model.NextFullTime;
			parameters[13].Value = model.NextAddTime;
			parameters[14].Value = model.Uploading;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Sanben.Model.uploadTask model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update uploadTask set ");
			strSql.Append("execution_frequency=@execution_frequency,");
			strSql.Append("execution_time=@execution_time,");
			strSql.Append("upload_platFrom=@upload_platFrom,");
			strSql.Append("policy_class=@policy_class,");
			strSql.Append("upload_class=@upload_class,");
			strSql.Append("uploadPlatFrom_specialPolicies=@uploadPlatFrom_specialPolicies,");
			strSql.Append("policySource=@policySource,");
			strSql.Append("tripType=@tripType,");
			strSql.Append("execute_number=@execute_number,");
			strSql.Append("condition=@condition,");
			strSql.Append("sys_id=@sys_id,");
			strSql.Append("uploadType=@uploadType,");
			strSql.Append("NextFullTime=@NextFullTime,");
			strSql.Append("NextAddTime=@NextAddTime,");
			strSql.Append("Uploading=@Uploading");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@execution_frequency", SqlDbType.VarChar,150),
					new SqlParameter("@execution_time", SqlDbType.DateTime),
					new SqlParameter("@upload_platFrom", SqlDbType.VarChar,50),
					new SqlParameter("@policy_class", SqlDbType.VarChar,50),
					new SqlParameter("@upload_class", SqlDbType.Int,4),
					new SqlParameter("@uploadPlatFrom_specialPolicies", SqlDbType.Bit,1),
					new SqlParameter("@policySource", SqlDbType.VarChar,255),
					new SqlParameter("@tripType", SqlDbType.Int,4),
					new SqlParameter("@execute_number", SqlDbType.Int,4),
					new SqlParameter("@condition", SqlDbType.Bit,1),
					new SqlParameter("@sys_id", SqlDbType.Int,4),
					new SqlParameter("@uploadType", SqlDbType.Int,4),
					new SqlParameter("@NextFullTime", SqlDbType.DateTime),
					new SqlParameter("@NextAddTime", SqlDbType.DateTime),
					new SqlParameter("@Uploading", SqlDbType.Bit,1),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.execution_frequency;
			parameters[1].Value = model.execution_time;
			parameters[2].Value = model.upload_platFrom;
			parameters[3].Value = model.policy_class;
			parameters[4].Value = model.upload_class;
			parameters[5].Value = model.uploadPlatFrom_specialPolicies;
			parameters[6].Value = model.policySource;
			parameters[7].Value = model.tripType;
			parameters[8].Value = model.execute_number;
			parameters[9].Value = model.condition;
			parameters[10].Value = model.sys_id;
			parameters[11].Value = model.uploadType;
			parameters[12].Value = model.NextFullTime;
			parameters[13].Value = model.NextAddTime;
			parameters[14].Value = model.Uploading;
			parameters[15].Value = model.id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from uploadTask ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from uploadTask ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Sanben.Model.uploadTask GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,execution_frequency,execution_time,upload_platFrom,policy_class,upload_class,uploadPlatFrom_specialPolicies,policySource,tripType,execute_number,condition,sys_id,uploadType,NextFullTime,NextAddTime,Uploading from uploadTask ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Sanben.Model.uploadTask model=new Sanben.Model.uploadTask();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Sanben.Model.uploadTask DataRowToModel(DataRow row)
		{
			Sanben.Model.uploadTask model=new Sanben.Model.uploadTask();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["execution_frequency"]!=null)
				{
					model.execution_frequency=row["execution_frequency"].ToString();
				}
				if(row["execution_time"]!=null && row["execution_time"].ToString()!="")
				{
					model.execution_time=DateTime.Parse(row["execution_time"].ToString());
				}
				if(row["upload_platFrom"]!=null)
				{
					model.upload_platFrom=row["upload_platFrom"].ToString();
				}
				if(row["policy_class"]!=null)
				{
					model.policy_class=row["policy_class"].ToString();
				}
				if(row["upload_class"]!=null && row["upload_class"].ToString()!="")
				{
					model.upload_class=int.Parse(row["upload_class"].ToString());
				}
				if(row["uploadPlatFrom_specialPolicies"]!=null && row["uploadPlatFrom_specialPolicies"].ToString()!="")
				{
					if((row["uploadPlatFrom_specialPolicies"].ToString()=="1")||(row["uploadPlatFrom_specialPolicies"].ToString().ToLower()=="true"))
					{
						model.uploadPlatFrom_specialPolicies=true;
					}
					else
					{
						model.uploadPlatFrom_specialPolicies=false;
					}
				}
				if(row["policySource"]!=null)
				{
					model.policySource=row["policySource"].ToString();
				}
				if(row["tripType"]!=null && row["tripType"].ToString()!="")
				{
					model.tripType=int.Parse(row["tripType"].ToString());
				}
				if(row["execute_number"]!=null && row["execute_number"].ToString()!="")
				{
					model.execute_number=int.Parse(row["execute_number"].ToString());
				}
				if(row["condition"]!=null && row["condition"].ToString()!="")
				{
					if((row["condition"].ToString()=="1")||(row["condition"].ToString().ToLower()=="true"))
					{
						model.condition=true;
					}
					else
					{
						model.condition=false;
					}
				}
				if(row["sys_id"]!=null && row["sys_id"].ToString()!="")
				{
					model.sys_id=int.Parse(row["sys_id"].ToString());
				}
				if(row["uploadType"]!=null && row["uploadType"].ToString()!="")
				{
					model.uploadType=int.Parse(row["uploadType"].ToString());
				}
				if(row["NextFullTime"]!=null && row["NextFullTime"].ToString()!="")
				{
					model.NextFullTime=DateTime.Parse(row["NextFullTime"].ToString());
				}
				if(row["NextAddTime"]!=null && row["NextAddTime"].ToString()!="")
				{
					model.NextAddTime=DateTime.Parse(row["NextAddTime"].ToString());
				}
				if(row["Uploading"]!=null && row["Uploading"].ToString()!="")
				{
					if((row["Uploading"].ToString()=="1")||(row["Uploading"].ToString().ToLower()=="true"))
					{
						model.Uploading=true;
					}
					else
					{
						model.Uploading=false;
					}
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select id,execution_frequency,convert(nvarchar(100),execution_time,24) as execution_time,upload_platFrom,policy_class,upload_class,uploadPlatFrom_specialPolicies,policySource,tripType,execute_number,condition,sys_id,uploadType,convert(nvarchar(100),NextFullTime,24) as NextFullTime,convert(nvarchar(100),NextAddTime,24) as NextAddTime,Uploading ");
			strSql.Append(" FROM uploadTask ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" id,execution_frequency,execution_time,upload_platFrom,policy_class,upload_class,uploadPlatFrom_specialPolicies,policySource,tripType,execute_number,condition,sys_id,uploadType,NextFullTime,NextAddTime,Uploading ");
			strSql.Append(" FROM uploadTask ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM uploadTask ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from uploadTask T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "uploadTask";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int UpdateAll()
        {
            StringBuilder strSql = new StringBuilder(" UPDATE [air_man].[dbo].[uploadTask] SET NextFullTime = NULL,NextAddTime = NULL; ");
            int result = DbHelperSQL.ExecuteSql(strSql.ToString());
            return result;
        }
    }
}

