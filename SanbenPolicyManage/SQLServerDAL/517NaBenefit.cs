using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:517NaBenefit
	/// </summary>
	public partial class a517NaBenefit:I517NaBenefit
	{
		public a517NaBenefit()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Sanben.Model.a517NaBenefit model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into 517NaBenefit(");
			strSql.Append("ID,PolicyNum,Airline,Scity,Acity,AirType,Flight,Cabin,TripType,PolicyType,PolicyPoint,ScheduleRestr,TicketCondition,AvaDate,EndDate,SupplierTimeDay,SupplierTimeWeek,IsSpeciPolicy,IsChange,ChildPolicyNum,PayPrice,Ticket,Airrax,Fuel,SupplierDelDay,SupplierDelWeek,TicketEffic,UpgradeChange,OfficeCode,AddTime,IsUpload,IsUpdate)");
			strSql.Append(" values (");
			strSql.Append("@ID,@PolicyNum,@Airline,@Scity,@Acity,@AirType,@Flight,@Cabin,@TripType,@PolicyType,@PolicyPoint,@ScheduleRestr,@TicketCondition,@AvaDate,@EndDate,@SupplierTimeDay,@SupplierTimeWeek,@IsSpeciPolicy,@IsChange,@ChildPolicyNum,@PayPrice,@Ticket,@Airrax,@Fuel,@SupplierDelDay,@SupplierDelWeek,@TicketEffic,@UpgradeChange,@OfficeCode,@AddTime,@IsUpload,@IsUpdate)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@PolicyNum", SqlDbType.NVarChar,255),
					new SqlParameter("@Airline", SqlDbType.NVarChar,255),
					new SqlParameter("@Scity", SqlDbType.NVarChar,255),
					new SqlParameter("@Acity", SqlDbType.NVarChar,255),
					new SqlParameter("@AirType", SqlDbType.NVarChar,255),
					new SqlParameter("@Flight", SqlDbType.NVarChar,255),
					new SqlParameter("@Cabin", SqlDbType.NVarChar,255),
					new SqlParameter("@TripType", SqlDbType.NVarChar,255),
					new SqlParameter("@PolicyType", SqlDbType.NVarChar,255),
					new SqlParameter("@PolicyPoint", SqlDbType.NVarChar,255),
					new SqlParameter("@ScheduleRestr", SqlDbType.NVarChar,255),
					new SqlParameter("@TicketCondition", SqlDbType.NVarChar,255),
					new SqlParameter("@AvaDate", SqlDbType.NVarChar,255),
					new SqlParameter("@EndDate", SqlDbType.NVarChar,255),
					new SqlParameter("@SupplierTimeDay", SqlDbType.NVarChar,255),
					new SqlParameter("@SupplierTimeWeek", SqlDbType.NVarChar,255),
					new SqlParameter("@IsSpeciPolicy", SqlDbType.NVarChar,255),
					new SqlParameter("@IsChange", SqlDbType.NVarChar,255),
					new SqlParameter("@ChildPolicyNum", SqlDbType.NVarChar,255),
					new SqlParameter("@PayPrice", SqlDbType.NVarChar,255),
					new SqlParameter("@Ticket", SqlDbType.NVarChar,255),
					new SqlParameter("@Airrax", SqlDbType.NVarChar,255),
					new SqlParameter("@Fuel", SqlDbType.NVarChar,255),
					new SqlParameter("@SupplierDelDay", SqlDbType.NVarChar,255),
					new SqlParameter("@SupplierDelWeek", SqlDbType.NVarChar,255),
					new SqlParameter("@TicketEffic", SqlDbType.NVarChar,255),
					new SqlParameter("@UpgradeChange", SqlDbType.NVarChar,255),
					new SqlParameter("@OfficeCode", SqlDbType.NVarChar,255),
					new SqlParameter("@AddTime", SqlDbType.DateTime),
					new SqlParameter("@IsUpload", SqlDbType.Bit,1),
					new SqlParameter("@IsUpdate", SqlDbType.Bit,1)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.PolicyNum;
			parameters[2].Value = model.Airline;
			parameters[3].Value = model.Scity;
			parameters[4].Value = model.Acity;
			parameters[5].Value = model.AirType;
			parameters[6].Value = model.Flight;
			parameters[7].Value = model.Cabin;
			parameters[8].Value = model.TripType;
			parameters[9].Value = model.PolicyType;
			parameters[10].Value = model.PolicyPoint;
			parameters[11].Value = model.ScheduleRestr;
			parameters[12].Value = model.TicketCondition;
			parameters[13].Value = model.AvaDate;
			parameters[14].Value = model.EndDate;
			parameters[15].Value = model.SupplierTimeDay;
			parameters[16].Value = model.SupplierTimeWeek;
			parameters[17].Value = model.IsSpeciPolicy;
			parameters[18].Value = model.IsChange;
			parameters[19].Value = model.ChildPolicyNum;
			parameters[20].Value = model.PayPrice;
			parameters[21].Value = model.Ticket;
			parameters[22].Value = model.Airrax;
			parameters[23].Value = model.Fuel;
			parameters[24].Value = model.SupplierDelDay;
			parameters[25].Value = model.SupplierDelWeek;
			parameters[26].Value = model.TicketEffic;
			parameters[27].Value = model.UpgradeChange;
			parameters[28].Value = model.OfficeCode;
			parameters[29].Value = model.AddTime;
			parameters[30].Value = model.IsUpload;
			parameters[31].Value = model.IsUpdate;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(Sanben.Model.a517NaBenefit model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update 517NaBenefit set ");
			strSql.Append("ID=@ID,");
			strSql.Append("PolicyNum=@PolicyNum,");
			strSql.Append("Airline=@Airline,");
			strSql.Append("Scity=@Scity,");
			strSql.Append("Acity=@Acity,");
			strSql.Append("AirType=@AirType,");
			strSql.Append("Flight=@Flight,");
			strSql.Append("Cabin=@Cabin,");
			strSql.Append("TripType=@TripType,");
			strSql.Append("PolicyType=@PolicyType,");
			strSql.Append("PolicyPoint=@PolicyPoint,");
			strSql.Append("ScheduleRestr=@ScheduleRestr,");
			strSql.Append("TicketCondition=@TicketCondition,");
			strSql.Append("AvaDate=@AvaDate,");
			strSql.Append("EndDate=@EndDate,");
			strSql.Append("SupplierTimeDay=@SupplierTimeDay,");
			strSql.Append("SupplierTimeWeek=@SupplierTimeWeek,");
			strSql.Append("IsSpeciPolicy=@IsSpeciPolicy,");
			strSql.Append("IsChange=@IsChange,");
			strSql.Append("ChildPolicyNum=@ChildPolicyNum,");
			strSql.Append("PayPrice=@PayPrice,");
			strSql.Append("Ticket=@Ticket,");
			strSql.Append("Airrax=@Airrax,");
			strSql.Append("Fuel=@Fuel,");
			strSql.Append("SupplierDelDay=@SupplierDelDay,");
			strSql.Append("SupplierDelWeek=@SupplierDelWeek,");
			strSql.Append("TicketEffic=@TicketEffic,");
			strSql.Append("UpgradeChange=@UpgradeChange,");
			strSql.Append("OfficeCode=@OfficeCode,");
			strSql.Append("AddTime=@AddTime,");
			strSql.Append("IsUpload=@IsUpload,");
			strSql.Append("IsUpdate=@IsUpdate");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@PolicyNum", SqlDbType.NVarChar,255),
					new SqlParameter("@Airline", SqlDbType.NVarChar,255),
					new SqlParameter("@Scity", SqlDbType.NVarChar,255),
					new SqlParameter("@Acity", SqlDbType.NVarChar,255),
					new SqlParameter("@AirType", SqlDbType.NVarChar,255),
					new SqlParameter("@Flight", SqlDbType.NVarChar,255),
					new SqlParameter("@Cabin", SqlDbType.NVarChar,255),
					new SqlParameter("@TripType", SqlDbType.NVarChar,255),
					new SqlParameter("@PolicyType", SqlDbType.NVarChar,255),
					new SqlParameter("@PolicyPoint", SqlDbType.NVarChar,255),
					new SqlParameter("@ScheduleRestr", SqlDbType.NVarChar,255),
					new SqlParameter("@TicketCondition", SqlDbType.NVarChar,255),
					new SqlParameter("@AvaDate", SqlDbType.NVarChar,255),
					new SqlParameter("@EndDate", SqlDbType.NVarChar,255),
					new SqlParameter("@SupplierTimeDay", SqlDbType.NVarChar,255),
					new SqlParameter("@SupplierTimeWeek", SqlDbType.NVarChar,255),
					new SqlParameter("@IsSpeciPolicy", SqlDbType.NVarChar,255),
					new SqlParameter("@IsChange", SqlDbType.NVarChar,255),
					new SqlParameter("@ChildPolicyNum", SqlDbType.NVarChar,255),
					new SqlParameter("@PayPrice", SqlDbType.NVarChar,255),
					new SqlParameter("@Ticket", SqlDbType.NVarChar,255),
					new SqlParameter("@Airrax", SqlDbType.NVarChar,255),
					new SqlParameter("@Fuel", SqlDbType.NVarChar,255),
					new SqlParameter("@SupplierDelDay", SqlDbType.NVarChar,255),
					new SqlParameter("@SupplierDelWeek", SqlDbType.NVarChar,255),
					new SqlParameter("@TicketEffic", SqlDbType.NVarChar,255),
					new SqlParameter("@UpgradeChange", SqlDbType.NVarChar,255),
					new SqlParameter("@OfficeCode", SqlDbType.NVarChar,255),
					new SqlParameter("@AddTime", SqlDbType.DateTime),
					new SqlParameter("@IsUpload", SqlDbType.Bit,1),
					new SqlParameter("@IsUpdate", SqlDbType.Bit,1)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.PolicyNum;
			parameters[2].Value = model.Airline;
			parameters[3].Value = model.Scity;
			parameters[4].Value = model.Acity;
			parameters[5].Value = model.AirType;
			parameters[6].Value = model.Flight;
			parameters[7].Value = model.Cabin;
			parameters[8].Value = model.TripType;
			parameters[9].Value = model.PolicyType;
			parameters[10].Value = model.PolicyPoint;
			parameters[11].Value = model.ScheduleRestr;
			parameters[12].Value = model.TicketCondition;
			parameters[13].Value = model.AvaDate;
			parameters[14].Value = model.EndDate;
			parameters[15].Value = model.SupplierTimeDay;
			parameters[16].Value = model.SupplierTimeWeek;
			parameters[17].Value = model.IsSpeciPolicy;
			parameters[18].Value = model.IsChange;
			parameters[19].Value = model.ChildPolicyNum;
			parameters[20].Value = model.PayPrice;
			parameters[21].Value = model.Ticket;
			parameters[22].Value = model.Airrax;
			parameters[23].Value = model.Fuel;
			parameters[24].Value = model.SupplierDelDay;
			parameters[25].Value = model.SupplierDelWeek;
			parameters[26].Value = model.TicketEffic;
			parameters[27].Value = model.UpgradeChange;
			parameters[28].Value = model.OfficeCode;
			parameters[29].Value = model.AddTime;
			parameters[30].Value = model.IsUpload;
			parameters[31].Value = model.IsUpdate;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from 517NaBenefit ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public Sanben.Model.a517NaBenefit GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,PolicyNum,Airline,Scity,Acity,AirType,Flight,Cabin,TripType,PolicyType,PolicyPoint,ScheduleRestr,TicketCondition,AvaDate,EndDate,SupplierTimeDay,SupplierTimeWeek,IsSpeciPolicy,IsChange,ChildPolicyNum,PayPrice,Ticket,Airrax,Fuel,SupplierDelDay,SupplierDelWeek,TicketEffic,UpgradeChange,OfficeCode,AddTime,IsUpload,IsUpdate from 517NaBenefit ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Sanben.Model.a517NaBenefit model=new Sanben.Model.a517NaBenefit();
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
		public Sanben.Model.a517NaBenefit DataRowToModel(DataRow row)
		{
			Sanben.Model.a517NaBenefit model=new Sanben.Model.a517NaBenefit();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["PolicyNum"]!=null)
				{
					model.PolicyNum=row["PolicyNum"].ToString();
				}
				if(row["Airline"]!=null)
				{
					model.Airline=row["Airline"].ToString();
				}
				if(row["Scity"]!=null)
				{
					model.Scity=row["Scity"].ToString();
				}
				if(row["Acity"]!=null)
				{
					model.Acity=row["Acity"].ToString();
				}
				if(row["AirType"]!=null)
				{
					model.AirType=row["AirType"].ToString();
				}
				if(row["Flight"]!=null)
				{
					model.Flight=row["Flight"].ToString();
				}
				if(row["Cabin"]!=null)
				{
					model.Cabin=row["Cabin"].ToString();
				}
				if(row["TripType"]!=null)
				{
					model.TripType=row["TripType"].ToString();
				}
				if(row["PolicyType"]!=null)
				{
					model.PolicyType=row["PolicyType"].ToString();
				}
				if(row["PolicyPoint"]!=null)
				{
					model.PolicyPoint=row["PolicyPoint"].ToString();
				}
				if(row["ScheduleRestr"]!=null)
				{
					model.ScheduleRestr=row["ScheduleRestr"].ToString();
				}
				if(row["TicketCondition"]!=null)
				{
					model.TicketCondition=row["TicketCondition"].ToString();
				}
				if(row["AvaDate"]!=null)
				{
					model.AvaDate=row["AvaDate"].ToString();
				}
				if(row["EndDate"]!=null)
				{
					model.EndDate=row["EndDate"].ToString();
				}
				if(row["SupplierTimeDay"]!=null)
				{
					model.SupplierTimeDay=row["SupplierTimeDay"].ToString();
				}
				if(row["SupplierTimeWeek"]!=null)
				{
					model.SupplierTimeWeek=row["SupplierTimeWeek"].ToString();
				}
				if(row["IsSpeciPolicy"]!=null)
				{
					model.IsSpeciPolicy=row["IsSpeciPolicy"].ToString();
				}
				if(row["IsChange"]!=null)
				{
					model.IsChange=row["IsChange"].ToString();
				}
				if(row["ChildPolicyNum"]!=null)
				{
					model.ChildPolicyNum=row["ChildPolicyNum"].ToString();
				}
				if(row["PayPrice"]!=null)
				{
					model.PayPrice=row["PayPrice"].ToString();
				}
				if(row["Ticket"]!=null)
				{
					model.Ticket=row["Ticket"].ToString();
				}
				if(row["Airrax"]!=null)
				{
					model.Airrax=row["Airrax"].ToString();
				}
				if(row["Fuel"]!=null)
				{
					model.Fuel=row["Fuel"].ToString();
				}
				if(row["SupplierDelDay"]!=null)
				{
					model.SupplierDelDay=row["SupplierDelDay"].ToString();
				}
				if(row["SupplierDelWeek"]!=null)
				{
					model.SupplierDelWeek=row["SupplierDelWeek"].ToString();
				}
				if(row["TicketEffic"]!=null)
				{
					model.TicketEffic=row["TicketEffic"].ToString();
				}
				if(row["UpgradeChange"]!=null)
				{
					model.UpgradeChange=row["UpgradeChange"].ToString();
				}
				if(row["OfficeCode"]!=null)
				{
					model.OfficeCode=row["OfficeCode"].ToString();
				}
				if(row["AddTime"]!=null && row["AddTime"].ToString()!="")
				{
					model.AddTime=DateTime.Parse(row["AddTime"].ToString());
				}
				if(row["IsUpload"]!=null && row["IsUpload"].ToString()!="")
				{
					if((row["IsUpload"].ToString()=="1")||(row["IsUpload"].ToString().ToLower()=="true"))
					{
						model.IsUpload=true;
					}
					else
					{
						model.IsUpload=false;
					}
				}
				if(row["IsUpdate"]!=null && row["IsUpdate"].ToString()!="")
				{
					if((row["IsUpdate"].ToString()=="1")||(row["IsUpdate"].ToString().ToLower()=="true"))
					{
						model.IsUpdate=true;
					}
					else
					{
						model.IsUpdate=false;
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
			strSql.Append("select ID,PolicyNum,Airline,Scity,Acity,AirType,Flight,Cabin,TripType,PolicyType,PolicyPoint,ScheduleRestr,TicketCondition,AvaDate,EndDate,SupplierTimeDay,SupplierTimeWeek,IsSpeciPolicy,IsChange,ChildPolicyNum,PayPrice,Ticket,Airrax,Fuel,SupplierDelDay,SupplierDelWeek,TicketEffic,UpgradeChange,OfficeCode,AddTime,IsUpload,IsUpdate ");
			strSql.Append(" FROM 517NaBenefit ");
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
			strSql.Append(" ID,PolicyNum,Airline,Scity,Acity,AirType,Flight,Cabin,TripType,PolicyType,PolicyPoint,ScheduleRestr,TicketCondition,AvaDate,EndDate,SupplierTimeDay,SupplierTimeWeek,IsSpeciPolicy,IsChange,ChildPolicyNum,PayPrice,Ticket,Airrax,Fuel,SupplierDelDay,SupplierDelWeek,TicketEffic,UpgradeChange,OfficeCode,AddTime,IsUpload,IsUpdate ");
			strSql.Append(" FROM 517NaBenefit ");
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
			strSql.Append("select count(1) FROM 517NaBenefit ");
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
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from 517NaBenefit T ");
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
			parameters[0].Value = "517NaBenefit";
			parameters[1].Value = "";
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

