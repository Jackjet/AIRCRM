using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:SYS_MenuList
	/// </summary>
	public partial class SYS_MenuList:ISYS_MenuList
	{
		public SYS_MenuList()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SYS_MenuList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SYS_MenuList");
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
		public int Add(Sanben.Model.SYS_MenuList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SYS_MenuList(");
			strSql.Append("Text,TabID,NavigateUrl,ParentID,SingleClickExpand,Icon,IsModule,IsFuntion,Ordering,Stop,Remark,Version,sort)");
			strSql.Append(" values (");
			strSql.Append("@Text,@TabID,@NavigateUrl,@ParentID,@SingleClickExpand,@Icon,@IsModule,@IsFuntion,@Ordering,@Stop,@Remark,@Version,@sort)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Text", SqlDbType.VarChar,100),
					new SqlParameter("@TabID", SqlDbType.VarChar,100),
					new SqlParameter("@NavigateUrl", SqlDbType.VarChar,500),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@SingleClickExpand", SqlDbType.Bit,1),
					new SqlParameter("@Icon", SqlDbType.VarChar,50),
					new SqlParameter("@IsModule", SqlDbType.Bit,1),
					new SqlParameter("@IsFuntion", SqlDbType.Bit,1),
					new SqlParameter("@Ordering", SqlDbType.Int,4),
					new SqlParameter("@Stop", SqlDbType.Bit,1),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@Version", SqlDbType.Timestamp,8),
					new SqlParameter("@sort", SqlDbType.Int,4)};
			parameters[0].Value = model.Text;
			parameters[1].Value = model.TabID;
			parameters[2].Value = model.NavigateUrl;
			parameters[3].Value = model.ParentID;
			parameters[4].Value = model.SingleClickExpand;
			parameters[5].Value = model.Icon;
			parameters[6].Value = model.IsModule;
			parameters[7].Value = model.IsFuntion;
			parameters[8].Value = model.Ordering;
			parameters[9].Value = model.Stop;
			parameters[10].Value = model.Remark;
			parameters[11].Value = model.Version;
			parameters[12].Value = model.sort;

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
		public bool Update(Sanben.Model.SYS_MenuList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SYS_MenuList set ");
			strSql.Append("Text=@Text,");
			strSql.Append("TabID=@TabID,");
			strSql.Append("NavigateUrl=@NavigateUrl,");
			strSql.Append("ParentID=@ParentID,");
			strSql.Append("SingleClickExpand=@SingleClickExpand,");
			strSql.Append("Icon=@Icon,");
			strSql.Append("IsModule=@IsModule,");
			strSql.Append("IsFuntion=@IsFuntion,");
			strSql.Append("Ordering=@Ordering,");
			strSql.Append("Stop=@Stop,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("sort=@sort");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Text", SqlDbType.VarChar,100),
					new SqlParameter("@TabID", SqlDbType.VarChar,100),
					new SqlParameter("@NavigateUrl", SqlDbType.VarChar,500),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@SingleClickExpand", SqlDbType.Bit,1),
					new SqlParameter("@Icon", SqlDbType.VarChar,50),
					new SqlParameter("@IsModule", SqlDbType.Bit,1),
					new SqlParameter("@IsFuntion", SqlDbType.Bit,1),
					new SqlParameter("@Ordering", SqlDbType.Int,4),
					new SqlParameter("@Stop", SqlDbType.Bit,1),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@sort", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Text;
			parameters[1].Value = model.TabID;
			parameters[2].Value = model.NavigateUrl;
			parameters[3].Value = model.ParentID;
			parameters[4].Value = model.SingleClickExpand;
			parameters[5].Value = model.Icon;
			parameters[6].Value = model.IsModule;
			parameters[7].Value = model.IsFuntion;
			parameters[8].Value = model.Ordering;
			parameters[9].Value = model.Stop;
			parameters[10].Value = model.Remark;
			parameters[11].Value = model.sort;
			parameters[12].Value = model.ID;

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
			strSql.Append("delete from SYS_MenuList ");
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
			strSql.Append("delete from SYS_MenuList ");
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
		public Sanben.Model.SYS_MenuList GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Text,TabID,NavigateUrl,ParentID,SingleClickExpand,Icon,IsModule,IsFuntion,Ordering,Stop,Remark,Version,sort from SYS_MenuList ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Sanben.Model.SYS_MenuList model=new Sanben.Model.SYS_MenuList();
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
		public Sanben.Model.SYS_MenuList DataRowToModel(DataRow row)
		{
			Sanben.Model.SYS_MenuList model=new Sanben.Model.SYS_MenuList();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["Text"]!=null)
				{
					model.Text=row["Text"].ToString();
				}
				if(row["TabID"]!=null)
				{
					model.TabID=row["TabID"].ToString();
				}
				if(row["NavigateUrl"]!=null)
				{
					model.NavigateUrl=row["NavigateUrl"].ToString();
				}
				if(row["ParentID"]!=null && row["ParentID"].ToString()!="")
				{
					model.ParentID=int.Parse(row["ParentID"].ToString());
				}
				if(row["SingleClickExpand"]!=null && row["SingleClickExpand"].ToString()!="")
				{
					if((row["SingleClickExpand"].ToString()=="1")||(row["SingleClickExpand"].ToString().ToLower()=="true"))
					{
						model.SingleClickExpand=true;
					}
					else
					{
						model.SingleClickExpand=false;
					}
				}
				if(row["Icon"]!=null)
				{
					model.Icon=row["Icon"].ToString();
				}
				if(row["IsModule"]!=null && row["IsModule"].ToString()!="")
				{
					if((row["IsModule"].ToString()=="1")||(row["IsModule"].ToString().ToLower()=="true"))
					{
						model.IsModule=true;
					}
					else
					{
						model.IsModule=false;
					}
				}
				if(row["IsFuntion"]!=null && row["IsFuntion"].ToString()!="")
				{
					if((row["IsFuntion"].ToString()=="1")||(row["IsFuntion"].ToString().ToLower()=="true"))
					{
						model.IsFuntion=true;
					}
					else
					{
						model.IsFuntion=false;
					}
				}
				if(row["Ordering"]!=null && row["Ordering"].ToString()!="")
				{
					model.Ordering=int.Parse(row["Ordering"].ToString());
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
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["Version"]!=null && row["Version"].ToString()!="")
				{
					model.Version=DateTime.Parse(row["Version"].ToString());
				}
				if(row["sort"]!=null && row["sort"].ToString()!="")
				{
					model.sort=int.Parse(row["sort"].ToString());
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
			strSql.Append("select ID,Text,TabID,NavigateUrl,ParentID,SingleClickExpand,Icon,IsModule,IsFuntion,Ordering,Stop,Remark,Version,sort ");
			strSql.Append(" FROM SYS_MenuList ");
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
			strSql.Append(" ID,Text,TabID,NavigateUrl,ParentID,SingleClickExpand,Icon,IsModule,IsFuntion,Ordering,Stop,Remark,Version,sort ");
			strSql.Append(" FROM SYS_MenuList ");
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
			strSql.Append("select count(1) FROM SYS_MenuList ");
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
			strSql.Append(")AS Row, T.*  from SYS_MenuList T ");
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
			parameters[0].Value = "SYS_MenuList";
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

