using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:orderInterfaceConfig
	/// </summary>
	public partial class orderInterfaceConfig:IorderInterfaceConfig
	{
		public orderInterfaceConfig()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "orderInterfaceConfig"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from orderInterfaceConfig");
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
		public int Add(Sanben.Model.orderInterfaceConfig model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into orderInterfaceConfig(");
			strSql.Append("username,password,orderAddress,interfaceAddress,startDate,orderStatus,isAutomaticGainOrder,isAutomaticTicket,flightCompany,startAirport,endAirport,maxDeficit,linkPhone,automaticTicketPlat,sys_id,platform_type_id,rt_user,rt_pwd,EtermRT,EtermRTuser,EtermRTpwd)");
			strSql.Append(" values (");
			strSql.Append("@username,@password,@orderAddress,@interfaceAddress,@startDate,@orderStatus,@isAutomaticGainOrder,@isAutomaticTicket,@flightCompany,@startAirport,@endAirport,@maxDeficit,@linkPhone,@automaticTicketPlat,@sys_id,@platform_type_id,@rt_user,@rt_pwd,@EtermRT,@EtermRTuser,@EtermRTpwd)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@username", SqlDbType.VarChar,50),
					new SqlParameter("@password", SqlDbType.VarChar,50),
					new SqlParameter("@orderAddress", SqlDbType.VarChar,255),
					new SqlParameter("@interfaceAddress", SqlDbType.VarChar,255),
					new SqlParameter("@startDate", SqlDbType.DateTime),
					new SqlParameter("@orderStatus", SqlDbType.VarChar,50),
					new SqlParameter("@isAutomaticGainOrder", SqlDbType.Bit,1),
					new SqlParameter("@isAutomaticTicket", SqlDbType.Bit,1),
					new SqlParameter("@flightCompany", SqlDbType.VarChar,20),
					new SqlParameter("@startAirport", SqlDbType.VarChar,50),
					new SqlParameter("@endAirport", SqlDbType.VarChar,50),
					new SqlParameter("@maxDeficit", SqlDbType.Float,8),
					new SqlParameter("@linkPhone", SqlDbType.Char,11),
					new SqlParameter("@automaticTicketPlat", SqlDbType.VarChar,50),
					new SqlParameter("@sys_id", SqlDbType.Int,4),
					new SqlParameter("@platform_type_id", SqlDbType.Int,4),
					new SqlParameter("@rt_user", SqlDbType.VarChar,50),
					new SqlParameter("@rt_pwd", SqlDbType.VarChar,50),
					new SqlParameter("@EtermRT", SqlDbType.VarChar,50),
					new SqlParameter("@EtermRTuser", SqlDbType.VarChar,50),
					new SqlParameter("@EtermRTpwd", SqlDbType.VarChar,50)};
			parameters[0].Value = model.username;
			parameters[1].Value = model.password;
			parameters[2].Value = model.orderAddress;
			parameters[3].Value = model.interfaceAddress;
			parameters[4].Value = model.startDate;
			parameters[5].Value = model.orderStatus;
			parameters[6].Value = model.isAutomaticGainOrder;
			parameters[7].Value = model.isAutomaticTicket;
			parameters[8].Value = model.flightCompany;
			parameters[9].Value = model.startAirport;
			parameters[10].Value = model.endAirport;
			parameters[11].Value = model.maxDeficit;
			parameters[12].Value = model.linkPhone;
			parameters[13].Value = model.automaticTicketPlat;
			parameters[14].Value = model.sys_id;
			parameters[15].Value = model.platform_type_id;
			parameters[16].Value = model.rt_user;
			parameters[17].Value = model.rt_pwd;
			parameters[18].Value = model.EtermRT;
			parameters[19].Value = model.EtermRTuser;
			parameters[20].Value = model.EtermRTpwd;

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
		public bool Update(Sanben.Model.orderInterfaceConfig model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update orderInterfaceConfig set ");
			strSql.Append("username=@username,");
			strSql.Append("password=@password,");
			strSql.Append("orderAddress=@orderAddress,");
			strSql.Append("interfaceAddress=@interfaceAddress,");
			strSql.Append("startDate=@startDate,");
			strSql.Append("orderStatus=@orderStatus,");
			strSql.Append("isAutomaticGainOrder=@isAutomaticGainOrder,");
			strSql.Append("isAutomaticTicket=@isAutomaticTicket,");
			strSql.Append("flightCompany=@flightCompany,");
			strSql.Append("startAirport=@startAirport,");
			strSql.Append("endAirport=@endAirport,");
			strSql.Append("maxDeficit=@maxDeficit,");
			strSql.Append("linkPhone=@linkPhone,");
			strSql.Append("automaticTicketPlat=@automaticTicketPlat,");
			strSql.Append("sys_id=@sys_id,");
			strSql.Append("platform_type_id=@platform_type_id,");
			strSql.Append("rt_user=@rt_user,");
			strSql.Append("rt_pwd=@rt_pwd,");
			strSql.Append("EtermRT=@EtermRT,");
			strSql.Append("EtermRTuser=@EtermRTuser,");
			strSql.Append("EtermRTpwd=@EtermRTpwd");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@username", SqlDbType.VarChar,50),
					new SqlParameter("@password", SqlDbType.VarChar,50),
					new SqlParameter("@orderAddress", SqlDbType.VarChar,255),
					new SqlParameter("@interfaceAddress", SqlDbType.VarChar,255),
					new SqlParameter("@startDate", SqlDbType.DateTime),
					new SqlParameter("@orderStatus", SqlDbType.VarChar,50),
					new SqlParameter("@isAutomaticGainOrder", SqlDbType.Bit,1),
					new SqlParameter("@isAutomaticTicket", SqlDbType.Bit,1),
					new SqlParameter("@flightCompany", SqlDbType.VarChar,20),
					new SqlParameter("@startAirport", SqlDbType.VarChar,50),
					new SqlParameter("@endAirport", SqlDbType.VarChar,50),
					new SqlParameter("@maxDeficit", SqlDbType.Float,8),
					new SqlParameter("@linkPhone", SqlDbType.Char,11),
					new SqlParameter("@automaticTicketPlat", SqlDbType.VarChar,50),
					new SqlParameter("@sys_id", SqlDbType.Int,4),
					new SqlParameter("@platform_type_id", SqlDbType.Int,4),
					new SqlParameter("@rt_user", SqlDbType.VarChar,50),
					new SqlParameter("@rt_pwd", SqlDbType.VarChar,50),
					new SqlParameter("@EtermRT", SqlDbType.VarChar,50),
					new SqlParameter("@EtermRTuser", SqlDbType.VarChar,50),
					new SqlParameter("@EtermRTpwd", SqlDbType.VarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.username;
			parameters[1].Value = model.password;
			parameters[2].Value = model.orderAddress;
			parameters[3].Value = model.interfaceAddress;
			parameters[4].Value = model.startDate;
			parameters[5].Value = model.orderStatus;
			parameters[6].Value = model.isAutomaticGainOrder;
			parameters[7].Value = model.isAutomaticTicket;
			parameters[8].Value = model.flightCompany;
			parameters[9].Value = model.startAirport;
			parameters[10].Value = model.endAirport;
			parameters[11].Value = model.maxDeficit;
			parameters[12].Value = model.linkPhone;
			parameters[13].Value = model.automaticTicketPlat;
			parameters[14].Value = model.sys_id;
			parameters[15].Value = model.platform_type_id;
			parameters[16].Value = model.rt_user;
			parameters[17].Value = model.rt_pwd;
			parameters[18].Value = model.EtermRT;
			parameters[19].Value = model.EtermRTuser;
			parameters[20].Value = model.EtermRTpwd;
			parameters[21].Value = model.id;

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
			strSql.Append("delete from orderInterfaceConfig ");
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
			strSql.Append("delete from orderInterfaceConfig ");
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
		public Sanben.Model.orderInterfaceConfig GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,username,password,orderAddress,interfaceAddress,startDate,orderStatus,isAutomaticGainOrder,isAutomaticTicket,flightCompany,startAirport,endAirport,maxDeficit,linkPhone,automaticTicketPlat,sys_id,platform_type_id,rt_user,rt_pwd,EtermRT,EtermRTuser,EtermRTpwd from orderInterfaceConfig ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Sanben.Model.orderInterfaceConfig model=new Sanben.Model.orderInterfaceConfig();
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
		public Sanben.Model.orderInterfaceConfig DataRowToModel(DataRow row)
		{
			Sanben.Model.orderInterfaceConfig model=new Sanben.Model.orderInterfaceConfig();
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
				if(row["orderAddress"]!=null)
				{
					model.orderAddress=row["orderAddress"].ToString();
				}
				if(row["interfaceAddress"]!=null)
				{
					model.interfaceAddress=row["interfaceAddress"].ToString();
				}
				if(row["startDate"]!=null && row["startDate"].ToString()!="")
				{
					model.startDate=DateTime.Parse(row["startDate"].ToString());
				}
				if(row["orderStatus"]!=null)
				{
					model.orderStatus=row["orderStatus"].ToString();
				}
				if(row["isAutomaticGainOrder"]!=null && row["isAutomaticGainOrder"].ToString()!="")
				{
					if((row["isAutomaticGainOrder"].ToString()=="1")||(row["isAutomaticGainOrder"].ToString().ToLower()=="true"))
					{
						model.isAutomaticGainOrder=true;
					}
					else
					{
						model.isAutomaticGainOrder=false;
					}
				}
				if(row["isAutomaticTicket"]!=null && row["isAutomaticTicket"].ToString()!="")
				{
					if((row["isAutomaticTicket"].ToString()=="1")||(row["isAutomaticTicket"].ToString().ToLower()=="true"))
					{
						model.isAutomaticTicket=true;
					}
					else
					{
						model.isAutomaticTicket=false;
					}
				}
				if(row["flightCompany"]!=null)
				{
					model.flightCompany=row["flightCompany"].ToString();
				}
				if(row["startAirport"]!=null)
				{
					model.startAirport=row["startAirport"].ToString();
				}
				if(row["endAirport"]!=null)
				{
					model.endAirport=row["endAirport"].ToString();
				}
				if(row["maxDeficit"]!=null && row["maxDeficit"].ToString()!="")
				{
					model.maxDeficit=decimal.Parse(row["maxDeficit"].ToString());
				}
				if(row["linkPhone"]!=null)
				{
					model.linkPhone=row["linkPhone"].ToString();
				}
				if(row["automaticTicketPlat"]!=null)
				{
					model.automaticTicketPlat=row["automaticTicketPlat"].ToString();
				}
				if(row["sys_id"]!=null && row["sys_id"].ToString()!="")
				{
					model.sys_id=int.Parse(row["sys_id"].ToString());
				}
				if(row["platform_type_id"]!=null && row["platform_type_id"].ToString()!="")
				{
					model.platform_type_id=int.Parse(row["platform_type_id"].ToString());
				}
				if(row["rt_user"]!=null)
				{
					model.rt_user=row["rt_user"].ToString();
				}
				if(row["rt_pwd"]!=null)
				{
					model.rt_pwd=row["rt_pwd"].ToString();
				}
				if(row["EtermRT"]!=null)
				{
					model.EtermRT=row["EtermRT"].ToString();
				}
				if(row["EtermRTuser"]!=null)
				{
					model.EtermRTuser=row["EtermRTuser"].ToString();
				}
				if(row["EtermRTpwd"]!=null)
				{
					model.EtermRTpwd=row["EtermRTpwd"].ToString();
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
			strSql.Append("select id,username,password,orderAddress,interfaceAddress,startDate,orderStatus,isAutomaticGainOrder,isAutomaticTicket,flightCompany,startAirport,endAirport,maxDeficit,linkPhone,automaticTicketPlat,sys_id,platform_type_id,rt_user,rt_pwd,EtermRT,EtermRTuser,EtermRTpwd ");
			strSql.Append(" FROM orderInterfaceConfig ");
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
			strSql.Append(" id,username,password,orderAddress,interfaceAddress,startDate,orderStatus,isAutomaticGainOrder,isAutomaticTicket,flightCompany,startAirport,endAirport,maxDeficit,linkPhone,automaticTicketPlat,sys_id,platform_type_id,rt_user,rt_pwd,EtermRT,EtermRTuser,EtermRTpwd ");
			strSql.Append(" FROM orderInterfaceConfig ");
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
			strSql.Append("select count(1) FROM orderInterfaceConfig ");
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
			strSql.Append(")AS Row, T.*  from orderInterfaceConfig T ");
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
			parameters[0].Value = "orderInterfaceConfig";
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

