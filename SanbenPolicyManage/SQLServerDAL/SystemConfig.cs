using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:SystemConfig
	/// </summary>
	public partial class SystemConfig:ISystemConfig
	{
		public SystemConfig()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SystemConfig"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SystemConfig");
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
		public int Add(Sanben.Model.SystemConfig model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SystemConfig(");
			strSql.Append("AfterDays,TimingDays,Account,LogPath,JinRiAmount,JinRiBerth,JinRiRateWay,JinRiUserType,JinRiUserName,JinRiVOYAGE,ServerAddress,JinRiTiming,C517natime,C517name,C517pid,C517pidsafe,Yi8000name,Yi8000psword,Yi8000distime,Ticket380partner,Ticket380key,Ticket380time,Ticket380timeadd,Ticket380gettime,C51bookname,C51booktime,C51bookyear)");
			strSql.Append(" values (");
			strSql.Append("@AfterDays,@TimingDays,@Account,@LogPath,@JinRiAmount,@JinRiBerth,@JinRiRateWay,@JinRiUserType,@JinRiUserName,@JinRiVOYAGE,@ServerAddress,@JinRiTiming,@C517natime,@C517name,@C517pid,@C517pidsafe,@Yi8000name,@Yi8000psword,@Yi8000distime,@Ticket380partner,@Ticket380key,@Ticket380time,@Ticket380timeadd,@Ticket380gettime,@C51bookname,@C51booktime,@C51bookyear)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@AfterDays", SqlDbType.NVarChar,255),
					new SqlParameter("@TimingDays", SqlDbType.Int,4),
					new SqlParameter("@Account", SqlDbType.NVarChar,255),
					new SqlParameter("@LogPath", SqlDbType.NVarChar,255),
					new SqlParameter("@JinRiAmount", SqlDbType.Int,4),
					new SqlParameter("@JinRiBerth", SqlDbType.NVarChar,255),
					new SqlParameter("@JinRiRateWay", SqlDbType.NVarChar,255),
					new SqlParameter("@JinRiUserType", SqlDbType.NVarChar,255),
					new SqlParameter("@JinRiUserName", SqlDbType.NVarChar,255),
					new SqlParameter("@JinRiVOYAGE", SqlDbType.NVarChar,255),
					new SqlParameter("@ServerAddress", SqlDbType.NVarChar,255),
					new SqlParameter("@JinRiTiming", SqlDbType.Int,4),
					new SqlParameter("@C517natime", SqlDbType.Int,4),
					new SqlParameter("@C517name", SqlDbType.NVarChar,255),
					new SqlParameter("@C517pid", SqlDbType.NVarChar,255),
					new SqlParameter("@C517pidsafe", SqlDbType.NVarChar,255),
					new SqlParameter("@Yi8000name", SqlDbType.NVarChar,255),
					new SqlParameter("@Yi8000psword", SqlDbType.NVarChar,255),
					new SqlParameter("@Yi8000distime", SqlDbType.Int,4),
					new SqlParameter("@Ticket380partner", SqlDbType.NVarChar,255),
					new SqlParameter("@Ticket380key", SqlDbType.NVarChar,255),
					new SqlParameter("@Ticket380time", SqlDbType.Int,4),
					new SqlParameter("@Ticket380timeadd", SqlDbType.Int,4),
					new SqlParameter("@Ticket380gettime", SqlDbType.NVarChar,255),
					new SqlParameter("@C51bookname", SqlDbType.NVarChar,255),
					new SqlParameter("@C51booktime", SqlDbType.Int,4),
					new SqlParameter("@C51bookyear", SqlDbType.Int,4)};
			parameters[0].Value = model.AfterDays;
			parameters[1].Value = model.TimingDays;
			parameters[2].Value = model.Account;
			parameters[3].Value = model.LogPath;
			parameters[4].Value = model.JinRiAmount;
			parameters[5].Value = model.JinRiBerth;
			parameters[6].Value = model.JinRiRateWay;
			parameters[7].Value = model.JinRiUserType;
			parameters[8].Value = model.JinRiUserName;
			parameters[9].Value = model.JinRiVOYAGE;
			parameters[10].Value = model.ServerAddress;
			parameters[11].Value = model.JinRiTiming;
			parameters[12].Value = model.C517natime;
			parameters[13].Value = model.C517name;
			parameters[14].Value = model.C517pid;
			parameters[15].Value = model.C517pidsafe;
			parameters[16].Value = model.Yi8000name;
			parameters[17].Value = model.Yi8000psword;
			parameters[18].Value = model.Yi8000distime;
			parameters[19].Value = model.Ticket380partner;
			parameters[20].Value = model.Ticket380key;
			parameters[21].Value = model.Ticket380time;
			parameters[22].Value = model.Ticket380timeadd;
			parameters[23].Value = model.Ticket380gettime;
			parameters[24].Value = model.C51bookname;
			parameters[25].Value = model.C51booktime;
			parameters[26].Value = model.C51bookyear;

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
		public bool Update(Sanben.Model.SystemConfig model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SystemConfig set ");
			strSql.Append("AfterDays=@AfterDays,");
			strSql.Append("TimingDays=@TimingDays,");
			strSql.Append("Account=@Account,");
			strSql.Append("LogPath=@LogPath,");
			strSql.Append("JinRiAmount=@JinRiAmount,");
			strSql.Append("JinRiBerth=@JinRiBerth,");
			strSql.Append("JinRiRateWay=@JinRiRateWay,");
			strSql.Append("JinRiUserType=@JinRiUserType,");
			strSql.Append("JinRiUserName=@JinRiUserName,");
			strSql.Append("JinRiVOYAGE=@JinRiVOYAGE,");
			strSql.Append("ServerAddress=@ServerAddress,");
			strSql.Append("JinRiTiming=@JinRiTiming,");
			strSql.Append("C517natime=@C517natime,");
			strSql.Append("C517name=@C517name,");
			strSql.Append("C517pid=@C517pid,");
			strSql.Append("C517pidsafe=@C517pidsafe,");
			strSql.Append("Yi8000name=@Yi8000name,");
			strSql.Append("Yi8000psword=@Yi8000psword,");
			strSql.Append("Yi8000distime=@Yi8000distime,");
			strSql.Append("Ticket380partner=@Ticket380partner,");
			strSql.Append("Ticket380key=@Ticket380key,");
			strSql.Append("Ticket380time=@Ticket380time,");
			strSql.Append("Ticket380timeadd=@Ticket380timeadd,");
			strSql.Append("Ticket380gettime=@Ticket380gettime,");
			strSql.Append("C51bookname=@C51bookname,");
			strSql.Append("C51booktime=@C51booktime,");
			strSql.Append("C51bookyear=@C51bookyear");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@AfterDays", SqlDbType.NVarChar,255),
					new SqlParameter("@TimingDays", SqlDbType.Int,4),
					new SqlParameter("@Account", SqlDbType.NVarChar,255),
					new SqlParameter("@LogPath", SqlDbType.NVarChar,255),
					new SqlParameter("@JinRiAmount", SqlDbType.Int,4),
					new SqlParameter("@JinRiBerth", SqlDbType.NVarChar,255),
					new SqlParameter("@JinRiRateWay", SqlDbType.NVarChar,255),
					new SqlParameter("@JinRiUserType", SqlDbType.NVarChar,255),
					new SqlParameter("@JinRiUserName", SqlDbType.NVarChar,255),
					new SqlParameter("@JinRiVOYAGE", SqlDbType.NVarChar,255),
					new SqlParameter("@ServerAddress", SqlDbType.NVarChar,255),
					new SqlParameter("@JinRiTiming", SqlDbType.Int,4),
					new SqlParameter("@C517natime", SqlDbType.Int,4),
					new SqlParameter("@C517name", SqlDbType.NVarChar,255),
					new SqlParameter("@C517pid", SqlDbType.NVarChar,255),
					new SqlParameter("@C517pidsafe", SqlDbType.NVarChar,255),
					new SqlParameter("@Yi8000name", SqlDbType.NVarChar,255),
					new SqlParameter("@Yi8000psword", SqlDbType.NVarChar,255),
					new SqlParameter("@Yi8000distime", SqlDbType.Int,4),
					new SqlParameter("@Ticket380partner", SqlDbType.NVarChar,255),
					new SqlParameter("@Ticket380key", SqlDbType.NVarChar,255),
					new SqlParameter("@Ticket380time", SqlDbType.Int,4),
					new SqlParameter("@Ticket380timeadd", SqlDbType.Int,4),
					new SqlParameter("@Ticket380gettime", SqlDbType.NVarChar,255),
					new SqlParameter("@C51bookname", SqlDbType.NVarChar,255),
					new SqlParameter("@C51booktime", SqlDbType.Int,4),
					new SqlParameter("@C51bookyear", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.AfterDays;
			parameters[1].Value = model.TimingDays;
			parameters[2].Value = model.Account;
			parameters[3].Value = model.LogPath;
			parameters[4].Value = model.JinRiAmount;
			parameters[5].Value = model.JinRiBerth;
			parameters[6].Value = model.JinRiRateWay;
			parameters[7].Value = model.JinRiUserType;
			parameters[8].Value = model.JinRiUserName;
			parameters[9].Value = model.JinRiVOYAGE;
			parameters[10].Value = model.ServerAddress;
			parameters[11].Value = model.JinRiTiming;
			parameters[12].Value = model.C517natime;
			parameters[13].Value = model.C517name;
			parameters[14].Value = model.C517pid;
			parameters[15].Value = model.C517pidsafe;
			parameters[16].Value = model.Yi8000name;
			parameters[17].Value = model.Yi8000psword;
			parameters[18].Value = model.Yi8000distime;
			parameters[19].Value = model.Ticket380partner;
			parameters[20].Value = model.Ticket380key;
			parameters[21].Value = model.Ticket380time;
			parameters[22].Value = model.Ticket380timeadd;
			parameters[23].Value = model.Ticket380gettime;
			parameters[24].Value = model.C51bookname;
			parameters[25].Value = model.C51booktime;
			parameters[26].Value = model.C51bookyear;
			parameters[27].Value = model.ID;

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
			strSql.Append("delete from SystemConfig ");
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
			strSql.Append("delete from SystemConfig ");
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
		public Sanben.Model.SystemConfig GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,AfterDays,TimingDays,Account,LogPath,JinRiAmount,JinRiBerth,JinRiRateWay,JinRiUserType,JinRiUserName,JinRiVOYAGE,ServerAddress,JinRiTiming,C517natime,C517name,C517pid,C517pidsafe,Yi8000name,Yi8000psword,Yi8000distime,Ticket380partner,Ticket380key,Ticket380time,Ticket380timeadd,Ticket380gettime,C51bookname,C51booktime,C51bookyear from SystemConfig ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Sanben.Model.SystemConfig model=new Sanben.Model.SystemConfig();
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
		public Sanben.Model.SystemConfig DataRowToModel(DataRow row)
		{
			Sanben.Model.SystemConfig model=new Sanben.Model.SystemConfig();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["AfterDays"]!=null)
				{
					model.AfterDays=row["AfterDays"].ToString();
				}
				if(row["TimingDays"]!=null && row["TimingDays"].ToString()!="")
				{
					model.TimingDays=int.Parse(row["TimingDays"].ToString());
				}
				if(row["Account"]!=null)
				{
					model.Account=row["Account"].ToString();
				}
				if(row["LogPath"]!=null)
				{
					model.LogPath=row["LogPath"].ToString();
				}
				if(row["JinRiAmount"]!=null && row["JinRiAmount"].ToString()!="")
				{
					model.JinRiAmount=int.Parse(row["JinRiAmount"].ToString());
				}
				if(row["JinRiBerth"]!=null)
				{
					model.JinRiBerth=row["JinRiBerth"].ToString();
				}
				if(row["JinRiRateWay"]!=null)
				{
					model.JinRiRateWay=row["JinRiRateWay"].ToString();
				}
				if(row["JinRiUserType"]!=null)
				{
					model.JinRiUserType=row["JinRiUserType"].ToString();
				}
				if(row["JinRiUserName"]!=null)
				{
					model.JinRiUserName=row["JinRiUserName"].ToString();
				}
				if(row["JinRiVOYAGE"]!=null)
				{
					model.JinRiVOYAGE=row["JinRiVOYAGE"].ToString();
				}
				if(row["ServerAddress"]!=null)
				{
					model.ServerAddress=row["ServerAddress"].ToString();
				}
				if(row["JinRiTiming"]!=null && row["JinRiTiming"].ToString()!="")
				{
					model.JinRiTiming=int.Parse(row["JinRiTiming"].ToString());
				}
				if(row["C517natime"]!=null && row["C517natime"].ToString()!="")
				{
					model.C517natime=int.Parse(row["C517natime"].ToString());
				}
				if(row["C517name"]!=null)
				{
					model.C517name=row["C517name"].ToString();
				}
				if(row["C517pid"]!=null)
				{
					model.C517pid=row["C517pid"].ToString();
				}
				if(row["C517pidsafe"]!=null)
				{
					model.C517pidsafe=row["C517pidsafe"].ToString();
				}
				if(row["Yi8000name"]!=null)
				{
					model.Yi8000name=row["Yi8000name"].ToString();
				}
				if(row["Yi8000psword"]!=null)
				{
					model.Yi8000psword=row["Yi8000psword"].ToString();
				}
				if(row["Yi8000distime"]!=null && row["Yi8000distime"].ToString()!="")
				{
					model.Yi8000distime=int.Parse(row["Yi8000distime"].ToString());
				}
				if(row["Ticket380partner"]!=null)
				{
					model.Ticket380partner=row["Ticket380partner"].ToString();
				}
				if(row["Ticket380key"]!=null)
				{
					model.Ticket380key=row["Ticket380key"].ToString();
				}
				if(row["Ticket380time"]!=null && row["Ticket380time"].ToString()!="")
				{
					model.Ticket380time=int.Parse(row["Ticket380time"].ToString());
				}
				if(row["Ticket380timeadd"]!=null && row["Ticket380timeadd"].ToString()!="")
				{
					model.Ticket380timeadd=int.Parse(row["Ticket380timeadd"].ToString());
				}
				if(row["Ticket380gettime"]!=null)
				{
					model.Ticket380gettime=row["Ticket380gettime"].ToString();
				}
				if(row["C51bookname"]!=null)
				{
					model.C51bookname=row["C51bookname"].ToString();
				}
				if(row["C51booktime"]!=null && row["C51booktime"].ToString()!="")
				{
					model.C51booktime=int.Parse(row["C51booktime"].ToString());
				}
				if(row["C51bookyear"]!=null && row["C51bookyear"].ToString()!="")
				{
					model.C51bookyear=int.Parse(row["C51bookyear"].ToString());
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
			strSql.Append("select ID,AfterDays,TimingDays,Account,LogPath,JinRiAmount,JinRiBerth,JinRiRateWay,JinRiUserType,JinRiUserName,JinRiVOYAGE,ServerAddress,JinRiTiming,C517natime,C517name,C517pid,C517pidsafe,Yi8000name,Yi8000psword,Yi8000distime,Ticket380partner,Ticket380key,Ticket380time,Ticket380timeadd,Ticket380gettime,C51bookname,C51booktime,C51bookyear ");
			strSql.Append(" FROM SystemConfig ");
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
			strSql.Append(" ID,AfterDays,TimingDays,Account,LogPath,JinRiAmount,JinRiBerth,JinRiRateWay,JinRiUserType,JinRiUserName,JinRiVOYAGE,ServerAddress,JinRiTiming,C517natime,C517name,C517pid,C517pidsafe,Yi8000name,Yi8000psword,Yi8000distime,Ticket380partner,Ticket380key,Ticket380time,Ticket380timeadd,Ticket380gettime,C51bookname,C51booktime,C51bookyear ");
			strSql.Append(" FROM SystemConfig ");
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
			strSql.Append("select count(1) FROM SystemConfig ");
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
			strSql.Append(")AS Row, T.*  from SystemConfig T ");
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
			parameters[0].Value = "SystemConfig";
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

