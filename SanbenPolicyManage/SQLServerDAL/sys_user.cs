﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sys_user
	/// </summary>
	public partial class sys_user:Isys_user
	{
		public sys_user()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "sys_user"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string username,int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_user");
			strSql.Append(" where username=@username and id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@username", SqlDbType.VarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4)			};
			parameters[0].Value = username;
			parameters[1].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Sanben.Model.sys_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_user(");
			strSql.Append("username,password,CreateDate,RoleList,CheckAuthority,Stop,IsModify,Remark,RealName,Code,Gender,Mobile,Telephone,QQ,Emaile,Company,CompanyAddress,ParentID)");
			strSql.Append(" values (");
			strSql.Append("@username,@password,@CreateDate,@RoleList,@CheckAuthority,@Stop,@IsModify,@Remark,@RealName,@Code,@Gender,@Mobile,@Telephone,@QQ,@Emaile,@Company,@CompanyAddress,@ParentID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@username", SqlDbType.VarChar,50),
					new SqlParameter("@password", SqlDbType.VarChar,255),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@RoleList", SqlDbType.VarChar,500),
					new SqlParameter("@CheckAuthority", SqlDbType.VarChar,1000),
					new SqlParameter("@Stop", SqlDbType.Bit,1),
					new SqlParameter("@IsModify", SqlDbType.Bit,1),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@RealName", SqlDbType.VarChar,50),
					new SqlParameter("@Code", SqlDbType.VarChar,50),
					new SqlParameter("@Gender", SqlDbType.VarChar,50),
					new SqlParameter("@Mobile", SqlDbType.VarChar,50),
					new SqlParameter("@Telephone", SqlDbType.VarChar,50),
					new SqlParameter("@QQ", SqlDbType.VarChar,50),
					new SqlParameter("@Emaile", SqlDbType.VarChar,50),
					new SqlParameter("@Company", SqlDbType.VarChar,50),
					new SqlParameter("@CompanyAddress", SqlDbType.VarChar,1000),
					new SqlParameter("@ParentID", SqlDbType.Int,4)};
			parameters[0].Value = model.username;
			parameters[1].Value = model.password;
			parameters[2].Value = model.CreateDate;
			parameters[3].Value = model.RoleList;
			parameters[4].Value = model.CheckAuthority;
			parameters[5].Value = model.Stop;
			parameters[6].Value = model.IsModify;
			parameters[7].Value = model.Remark;
			parameters[8].Value = model.RealName;
			parameters[9].Value = model.Code;
			parameters[10].Value = model.Gender;
			parameters[11].Value = model.Mobile;
			parameters[12].Value = model.Telephone;
			parameters[13].Value = model.QQ;
			parameters[14].Value = model.Emaile;
			parameters[15].Value = model.Company;
			parameters[16].Value = model.CompanyAddress;
			parameters[17].Value = model.ParentID;

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
		public bool Update(Sanben.Model.sys_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_user set ");
			strSql.Append("password=@password,");
			strSql.Append("CreateDate=@CreateDate,");
			strSql.Append("RoleList=@RoleList,");
			strSql.Append("CheckAuthority=@CheckAuthority,");
			strSql.Append("Stop=@Stop,");
			strSql.Append("IsModify=@IsModify,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("RealName=@RealName,");
			strSql.Append("Code=@Code,");
			strSql.Append("Gender=@Gender,");
			strSql.Append("Mobile=@Mobile,");
			strSql.Append("Telephone=@Telephone,");
			strSql.Append("QQ=@QQ,");
			strSql.Append("Emaile=@Emaile,");
			strSql.Append("Company=@Company,");
			strSql.Append("CompanyAddress=@CompanyAddress,");
			strSql.Append("ParentID=@ParentID");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@password", SqlDbType.VarChar,255),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@RoleList", SqlDbType.VarChar,500),
					new SqlParameter("@CheckAuthority", SqlDbType.VarChar,1000),
					new SqlParameter("@Stop", SqlDbType.Bit,1),
					new SqlParameter("@IsModify", SqlDbType.Bit,1),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@RealName", SqlDbType.VarChar,50),
					new SqlParameter("@Code", SqlDbType.VarChar,50),
					new SqlParameter("@Gender", SqlDbType.VarChar,50),
					new SqlParameter("@Mobile", SqlDbType.VarChar,50),
					new SqlParameter("@Telephone", SqlDbType.VarChar,50),
					new SqlParameter("@QQ", SqlDbType.VarChar,50),
					new SqlParameter("@Emaile", SqlDbType.VarChar,50),
					new SqlParameter("@Company", SqlDbType.VarChar,50),
					new SqlParameter("@CompanyAddress", SqlDbType.VarChar,1000),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@username", SqlDbType.VarChar,50)};
			parameters[0].Value = model.password;
			parameters[1].Value = model.CreateDate;
			parameters[2].Value = model.RoleList;
			parameters[3].Value = model.CheckAuthority;
			parameters[4].Value = model.Stop;
			parameters[5].Value = model.IsModify;
			parameters[6].Value = model.Remark;
			parameters[7].Value = model.RealName;
			parameters[8].Value = model.Code;
			parameters[9].Value = model.Gender;
			parameters[10].Value = model.Mobile;
			parameters[11].Value = model.Telephone;
			parameters[12].Value = model.QQ;
			parameters[13].Value = model.Emaile;
			parameters[14].Value = model.Company;
			parameters[15].Value = model.CompanyAddress;
			parameters[16].Value = model.ParentID;
			parameters[17].Value = model.id;
			parameters[18].Value = model.username;

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
			strSql.Append("delete from sys_user ");
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
		/// 删除一条数据
		/// </summary>
		public bool Delete(string username,int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_user ");
			strSql.Append(" where username=@username and id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@username", SqlDbType.VarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4)			};
			parameters[0].Value = username;
			parameters[1].Value = id;

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
			strSql.Append("delete from sys_user ");
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
		public Sanben.Model.sys_user GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,username,password,CreateDate,RoleList,CheckAuthority,Stop,IsModify,Remark,RealName,Code,Gender,Mobile,Telephone,QQ,Emaile,Company,CompanyAddress,ParentID from sys_user ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Sanben.Model.sys_user model=new Sanben.Model.sys_user();
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
		public Sanben.Model.sys_user DataRowToModel(DataRow row)
		{
			Sanben.Model.sys_user model=new Sanben.Model.sys_user();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["username"]!=null)
				{
					model.username=row["username"].ToString();
				}
				if(row["password"]!=null)
				{
					model.password=row["password"].ToString();
				}
				if(row["CreateDate"]!=null && row["CreateDate"].ToString()!="")
				{
					model.CreateDate=DateTime.Parse(row["CreateDate"].ToString());
				}
				if(row["RoleList"]!=null)
				{
					model.RoleList=row["RoleList"].ToString();
				}
				if(row["CheckAuthority"]!=null)
				{
					model.CheckAuthority=row["CheckAuthority"].ToString();
				}
				if(row["Stop"]!=null && row["Stop"].ToString()!="")
				{
					if((row["Stop"].ToString()=="1")||(row["Stop"].ToString().ToLower()=="true"))
					{
						model.Stop=true;
					}
					else
					{
						model.Stop=false;
					}
				}
				if(row["IsModify"]!=null && row["IsModify"].ToString()!="")
				{
					if((row["IsModify"].ToString()=="1")||(row["IsModify"].ToString().ToLower()=="true"))
					{
						model.IsModify=true;
					}
					else
					{
						model.IsModify=false;
					}
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["RealName"]!=null)
				{
					model.RealName=row["RealName"].ToString();
				}
				if(row["Code"]!=null)
				{
					model.Code=row["Code"].ToString();
				}
				if(row["Gender"]!=null)
				{
					model.Gender=row["Gender"].ToString();
				}
				if(row["Mobile"]!=null)
				{
					model.Mobile=row["Mobile"].ToString();
				}
				if(row["Telephone"]!=null)
				{
					model.Telephone=row["Telephone"].ToString();
				}
				if(row["QQ"]!=null)
				{
					model.QQ=row["QQ"].ToString();
				}
				if(row["Emaile"]!=null)
				{
					model.Emaile=row["Emaile"].ToString();
				}
				if(row["Company"]!=null)
				{
					model.Company=row["Company"].ToString();
				}
				if(row["CompanyAddress"]!=null)
				{
					model.CompanyAddress=row["CompanyAddress"].ToString();
				}
				if(row["ParentID"]!=null && row["ParentID"].ToString()!="")
				{
					model.ParentID=int.Parse(row["ParentID"].ToString());
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
			strSql.Append("select id,username,password,CreateDate,RoleList,CheckAuthority,Stop,IsModify,Remark,RealName,Code,Gender,Mobile,Telephone,QQ,Emaile,Company,CompanyAddress,ParentID ");
			strSql.Append(" FROM sys_user ");
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
			strSql.Append(" id,username,password,CreateDate,RoleList,CheckAuthority,Stop,IsModify,Remark,RealName,Code,Gender,Mobile,Telephone,QQ,Emaile,Company,CompanyAddress,ParentID ");
			strSql.Append(" FROM sys_user ");
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
			strSql.Append("select count(1) FROM sys_user ");
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
			strSql.Append(")AS Row, T.*  from sys_user T ");
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
			parameters[0].Value = "sys_user";
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
	}
}

