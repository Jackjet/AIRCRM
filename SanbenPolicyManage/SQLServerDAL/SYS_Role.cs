using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:SYS_Role
	/// </summary>
	public partial class SYS_Role:ISYS_Role
	{
		public SYS_Role()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SYS_Role"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SYS_Role");
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
		public int Add(Sanben.Model.SYS_Role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SYS_Role(");
			strSql.Append("RoleName,Stop,Ordering,MenuList,AuthorityList,IsModify,Remark)");
			strSql.Append(" values (");
			strSql.Append("@RoleName,@Stop,@Ordering,@MenuList,@AuthorityList,@IsModify,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@RoleName", SqlDbType.VarChar,50),
					new SqlParameter("@Stop", SqlDbType.Bit,1),
					new SqlParameter("@Ordering", SqlDbType.Int,4),
					new SqlParameter("@MenuList", SqlDbType.VarChar,5000),
					new SqlParameter("@AuthorityList", SqlDbType.VarChar,5000),
					new SqlParameter("@IsModify", SqlDbType.Bit,1),
					new SqlParameter("@Remark", SqlDbType.VarChar,500)};
			parameters[0].Value = model.RoleName;
			parameters[1].Value = model.Stop;
			parameters[2].Value = model.Ordering;
			parameters[3].Value = model.MenuList;
			parameters[4].Value = model.AuthorityList;
			parameters[5].Value = model.IsModify;
			parameters[6].Value = model.Remark;

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
		public bool Update(Sanben.Model.SYS_Role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SYS_Role set ");
			strSql.Append("RoleName=@RoleName,");
			strSql.Append("Stop=@Stop,");
			strSql.Append("Ordering=@Ordering,");
			strSql.Append("MenuList=@MenuList,");
			strSql.Append("AuthorityList=@AuthorityList,");
			strSql.Append("IsModify=@IsModify,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@RoleName", SqlDbType.VarChar,50),
					new SqlParameter("@Stop", SqlDbType.Bit,1),
					new SqlParameter("@Ordering", SqlDbType.Int,4),
					new SqlParameter("@MenuList", SqlDbType.VarChar,5000),
					new SqlParameter("@AuthorityList", SqlDbType.VarChar,5000),
					new SqlParameter("@IsModify", SqlDbType.Bit,1),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.RoleName;
			parameters[1].Value = model.Stop;
			parameters[2].Value = model.Ordering;
			parameters[3].Value = model.MenuList;
			parameters[4].Value = model.AuthorityList;
			parameters[5].Value = model.IsModify;
			parameters[6].Value = model.Remark;
			parameters[7].Value = model.ID;

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
			strSql.Append("delete from SYS_Role ");
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
			strSql.Append("delete from SYS_Role ");
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
		public Sanben.Model.SYS_Role GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,RoleName,Stop,Ordering,MenuList,AuthorityList,IsModify,Remark from SYS_Role ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Sanben.Model.SYS_Role model=new Sanben.Model.SYS_Role();
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
		public Sanben.Model.SYS_Role DataRowToModel(DataRow row)
		{
			Sanben.Model.SYS_Role model=new Sanben.Model.SYS_Role();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["RoleName"]!=null)
				{
					model.RoleName=row["RoleName"].ToString();
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
				if(row["Ordering"]!=null && row["Ordering"].ToString()!="")
				{
					model.Ordering=int.Parse(row["Ordering"].ToString());
				}
				if(row["MenuList"]!=null)
				{
					model.MenuList=row["MenuList"].ToString();
				}
				if(row["AuthorityList"]!=null)
				{
					model.AuthorityList=row["AuthorityList"].ToString();
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,RoleName,Stop,Ordering,MenuList,AuthorityList,IsModify,Remark ");
			strSql.Append(" FROM SYS_Role ");
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
			strSql.Append(" ID,RoleName,Stop,Ordering,MenuList,AuthorityList,IsModify,Remark ");
			strSql.Append(" FROM SYS_Role ");
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
			strSql.Append("select count(1) FROM SYS_Role ");
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
			strSql.Append(")AS Row, T.*  from SYS_Role T ");
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
			parameters[0].Value = "SYS_Role";
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

