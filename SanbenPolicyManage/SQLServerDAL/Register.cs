using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:Register
	/// </summary>
	public partial class Register:IRegister
	{
		public Register()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Register"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Register");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Sanben.Model.Register model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Register(");
			strSql.Append("username,password,company,phone,name,QQ,idcard,login_date)");
			strSql.Append(" values (");
			strSql.Append("@username,@password,@company,@phone,@name,@QQ,@idcard,@login_date)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@username", SqlDbType.NVarChar,255),
					new SqlParameter("@password", SqlDbType.NVarChar,255),
					new SqlParameter("@company", SqlDbType.NVarChar,255),
					new SqlParameter("@phone", SqlDbType.NVarChar,255),
					new SqlParameter("@name", SqlDbType.NVarChar,255),
					new SqlParameter("@QQ", SqlDbType.NVarChar,255),
					new SqlParameter("@idcard", SqlDbType.NVarChar,255),
					new SqlParameter("@login_date", SqlDbType.DateTime)};
			parameters[0].Value = model.username;
			parameters[1].Value = model.password;
			parameters[2].Value = model.company;
			parameters[3].Value = model.phone;
			parameters[4].Value = model.name;
			parameters[5].Value = model.QQ;
			parameters[6].Value = model.idcard;
			parameters[7].Value = model.login_date;

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
		public bool Update(Sanben.Model.Register model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Register set ");
			strSql.Append("username=@username,");
			strSql.Append("password=@password,");
			strSql.Append("company=@company,");
			strSql.Append("phone=@phone,");
			strSql.Append("name=@name,");
			strSql.Append("QQ=@QQ,");
			strSql.Append("idcard=@idcard,");
			strSql.Append("login_date=@login_date");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@username", SqlDbType.NVarChar,255),
					new SqlParameter("@password", SqlDbType.NVarChar,255),
					new SqlParameter("@company", SqlDbType.NVarChar,255),
					new SqlParameter("@phone", SqlDbType.NVarChar,255),
					new SqlParameter("@name", SqlDbType.NVarChar,255),
					new SqlParameter("@QQ", SqlDbType.NVarChar,255),
					new SqlParameter("@idcard", SqlDbType.NVarChar,255),
					new SqlParameter("@login_date", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.username;
			parameters[1].Value = model.password;
			parameters[2].Value = model.company;
			parameters[3].Value = model.phone;
			parameters[4].Value = model.name;
			parameters[5].Value = model.QQ;
			parameters[6].Value = model.idcard;
			parameters[7].Value = model.login_date;
			parameters[8].Value = model.ID;

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
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Register ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Register ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		public Sanben.Model.Register GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,username,password,company,phone,name,QQ,idcard,login_date from Register ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Sanben.Model.Register model=new Sanben.Model.Register();
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
		public Sanben.Model.Register DataRowToModel(DataRow row)
		{
			Sanben.Model.Register model=new Sanben.Model.Register();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["username"]!=null)
				{
					model.username=row["username"].ToString();
				}
				if(row["password"]!=null)
				{
					model.password=row["password"].ToString();
				}
				if(row["company"]!=null)
				{
					model.company=row["company"].ToString();
				}
				if(row["phone"]!=null)
				{
					model.phone=row["phone"].ToString();
				}
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["QQ"]!=null)
				{
					model.QQ=row["QQ"].ToString();
				}
				if(row["idcard"]!=null)
				{
					model.idcard=row["idcard"].ToString();
				}
				if(row["login_date"]!=null && row["login_date"].ToString()!="")
				{
					model.login_date=DateTime.Parse(row["login_date"].ToString());
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
			strSql.Append("select ID,username,password,company,phone,name,QQ,idcard,login_date ");
			strSql.Append(" FROM Register ");
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
			strSql.Append(" ID,username,password,company,phone,name,QQ,idcard,login_date ");
			strSql.Append(" FROM Register ");
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
			strSql.Append("select count(1) FROM Register ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from Register T ");
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
			parameters[0].Value = "Register";
			parameters[1].Value = "ID";
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

