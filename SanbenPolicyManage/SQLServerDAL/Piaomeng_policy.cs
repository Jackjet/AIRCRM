using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:Piaomeng_policy
	/// </summary>
	public partial class Piaomeng_policy:IPiaomeng_policy
	{
		public Piaomeng_policy()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Piaomeng_policy");
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
		public int Add(Sanben.Model.Piaomeng_policy model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Piaomeng_policy(");
			strSql.Append("policyID,fromPlace,toPlace,flightNo,fromTime,toTime,discountMax,discountMin,rate,remarks,flightScope,printTickFromTime,printTickToTime,publisherId,status,lastUserName,submitTime,lastUpdateTime,routeType,applyClass,specMark,specNote,policyType,airCom,type,changePNR,bookingRemarks,bounceRemarks,ticketChangingRemarks,openRemarks,policyWay,providerId,worktimeto,worktimeFrom,payType)");
			strSql.Append(" values (");
			strSql.Append("@policyID,@fromPlace,@toPlace,@flightNo,@fromTime,@toTime,@discountMax,@discountMin,@rate,@remarks,@flightScope,@printTickFromTime,@printTickToTime,@publisherId,@status,@lastUserName,@submitTime,@lastUpdateTime,@routeType,@applyClass,@specMark,@specNote,@policyType,@airCom,@type,@changePNR,@bookingRemarks,@bounceRemarks,@ticketChangingRemarks,@openRemarks,@policyWay,@providerId,@worktimeto,@worktimeFrom,@payType)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@policyID", SqlDbType.Char,36),
					new SqlParameter("@fromPlace", SqlDbType.VarChar,2000),
					new SqlParameter("@toPlace", SqlDbType.VarChar,2000),
					new SqlParameter("@flightNo", SqlDbType.VarChar,3800),
					new SqlParameter("@fromTime", SqlDbType.DateTime),
					new SqlParameter("@toTime", SqlDbType.DateTime),
					new SqlParameter("@discountMax", SqlDbType.Decimal,5),
					new SqlParameter("@discountMin", SqlDbType.Decimal,5),
					new SqlParameter("@rate", SqlDbType.Decimal,5),
					new SqlParameter("@remarks", SqlDbType.VarChar,300),
					new SqlParameter("@flightScope", SqlDbType.VarChar,10),
					new SqlParameter("@printTickFromTime", SqlDbType.DateTime),
					new SqlParameter("@printTickToTime", SqlDbType.DateTime),
					new SqlParameter("@publisherId", SqlDbType.VarChar,32),
					new SqlParameter("@status", SqlDbType.VarChar,10),
					new SqlParameter("@lastUserName", SqlDbType.VarChar,50),
					new SqlParameter("@submitTime", SqlDbType.DateTime),
					new SqlParameter("@lastUpdateTime", SqlDbType.DateTime),
					new SqlParameter("@routeType", SqlDbType.VarChar,10),
					new SqlParameter("@applyClass", SqlDbType.VarChar,100),
					new SqlParameter("@specMark", SqlDbType.VarChar,300),
					new SqlParameter("@specNote", SqlDbType.VarChar,300),
					new SqlParameter("@policyType", SqlDbType.VarChar,20),
					new SqlParameter("@airCom", SqlDbType.VarChar,20),
					new SqlParameter("@type", SqlDbType.VarChar,2),
					new SqlParameter("@changePNR", SqlDbType.VarChar,2),
					new SqlParameter("@bookingRemarks", SqlDbType.VarChar,300),
					new SqlParameter("@bounceRemarks", SqlDbType.VarChar,300),
					new SqlParameter("@ticketChangingRemarks", SqlDbType.VarChar,300),
					new SqlParameter("@openRemarks", SqlDbType.VarChar,300),
					new SqlParameter("@policyWay", SqlDbType.VarChar,2),
					new SqlParameter("@providerId", SqlDbType.VarChar,32),
					new SqlParameter("@worktimeto", SqlDbType.Int,4),
					new SqlParameter("@worktimeFrom", SqlDbType.Int,4),
					new SqlParameter("@payType", SqlDbType.VarChar,10)};
			parameters[0].Value = model.policyID;
			parameters[1].Value = model.fromPlace;
			parameters[2].Value = model.toPlace;
			parameters[3].Value = model.flightNo;
			parameters[4].Value = model.fromTime;
			parameters[5].Value = model.toTime;
			parameters[6].Value = model.discountMax;
			parameters[7].Value = model.discountMin;
			parameters[8].Value = model.rate;
			parameters[9].Value = model.remarks;
			parameters[10].Value = model.flightScope;
			parameters[11].Value = model.printTickFromTime;
			parameters[12].Value = model.printTickToTime;
			parameters[13].Value = model.publisherId;
			parameters[14].Value = model.status;
			parameters[15].Value = model.lastUserName;
			parameters[16].Value = model.submitTime;
			parameters[17].Value = model.lastUpdateTime;
			parameters[18].Value = model.routeType;
			parameters[19].Value = model.applyClass;
			parameters[20].Value = model.specMark;
			parameters[21].Value = model.specNote;
			parameters[22].Value = model.policyType;
			parameters[23].Value = model.airCom;
			parameters[24].Value = model.type;
			parameters[25].Value = model.changePNR;
			parameters[26].Value = model.bookingRemarks;
			parameters[27].Value = model.bounceRemarks;
			parameters[28].Value = model.ticketChangingRemarks;
			parameters[29].Value = model.openRemarks;
			parameters[30].Value = model.policyWay;
			parameters[31].Value = model.providerId;
			parameters[32].Value = model.worktimeto;
			parameters[33].Value = model.worktimeFrom;
			parameters[34].Value = model.payType;

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
		public bool Update(Sanben.Model.Piaomeng_policy model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Piaomeng_policy set ");
			strSql.Append("policyID=@policyID,");
			strSql.Append("fromPlace=@fromPlace,");
			strSql.Append("toPlace=@toPlace,");
			strSql.Append("flightNo=@flightNo,");
			strSql.Append("fromTime=@fromTime,");
			strSql.Append("toTime=@toTime,");
			strSql.Append("discountMax=@discountMax,");
			strSql.Append("discountMin=@discountMin,");
			strSql.Append("rate=@rate,");
			strSql.Append("remarks=@remarks,");
			strSql.Append("flightScope=@flightScope,");
			strSql.Append("printTickFromTime=@printTickFromTime,");
			strSql.Append("printTickToTime=@printTickToTime,");
			strSql.Append("publisherId=@publisherId,");
			strSql.Append("status=@status,");
			strSql.Append("lastUserName=@lastUserName,");
			strSql.Append("submitTime=@submitTime,");
			strSql.Append("lastUpdateTime=@lastUpdateTime,");
			strSql.Append("routeType=@routeType,");
			strSql.Append("applyClass=@applyClass,");
			strSql.Append("specMark=@specMark,");
			strSql.Append("specNote=@specNote,");
			strSql.Append("policyType=@policyType,");
			strSql.Append("airCom=@airCom,");
			strSql.Append("type=@type,");
			strSql.Append("changePNR=@changePNR,");
			strSql.Append("bookingRemarks=@bookingRemarks,");
			strSql.Append("bounceRemarks=@bounceRemarks,");
			strSql.Append("ticketChangingRemarks=@ticketChangingRemarks,");
			strSql.Append("openRemarks=@openRemarks,");
			strSql.Append("policyWay=@policyWay,");
			strSql.Append("providerId=@providerId,");
			strSql.Append("worktimeto=@worktimeto,");
			strSql.Append("worktimeFrom=@worktimeFrom,");
			strSql.Append("payType=@payType");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@policyID", SqlDbType.Char,36),
					new SqlParameter("@fromPlace", SqlDbType.VarChar,2000),
					new SqlParameter("@toPlace", SqlDbType.VarChar,2000),
					new SqlParameter("@flightNo", SqlDbType.VarChar,3800),
					new SqlParameter("@fromTime", SqlDbType.DateTime),
					new SqlParameter("@toTime", SqlDbType.DateTime),
					new SqlParameter("@discountMax", SqlDbType.Decimal,5),
					new SqlParameter("@discountMin", SqlDbType.Decimal,5),
					new SqlParameter("@rate", SqlDbType.Decimal,5),
					new SqlParameter("@remarks", SqlDbType.VarChar,300),
					new SqlParameter("@flightScope", SqlDbType.VarChar,10),
					new SqlParameter("@printTickFromTime", SqlDbType.DateTime),
					new SqlParameter("@printTickToTime", SqlDbType.DateTime),
					new SqlParameter("@publisherId", SqlDbType.VarChar,32),
					new SqlParameter("@status", SqlDbType.VarChar,10),
					new SqlParameter("@lastUserName", SqlDbType.VarChar,50),
					new SqlParameter("@submitTime", SqlDbType.DateTime),
					new SqlParameter("@lastUpdateTime", SqlDbType.DateTime),
					new SqlParameter("@routeType", SqlDbType.VarChar,10),
					new SqlParameter("@applyClass", SqlDbType.VarChar,100),
					new SqlParameter("@specMark", SqlDbType.VarChar,300),
					new SqlParameter("@specNote", SqlDbType.VarChar,300),
					new SqlParameter("@policyType", SqlDbType.VarChar,20),
					new SqlParameter("@airCom", SqlDbType.VarChar,20),
					new SqlParameter("@type", SqlDbType.VarChar,2),
					new SqlParameter("@changePNR", SqlDbType.VarChar,2),
					new SqlParameter("@bookingRemarks", SqlDbType.VarChar,300),
					new SqlParameter("@bounceRemarks", SqlDbType.VarChar,300),
					new SqlParameter("@ticketChangingRemarks", SqlDbType.VarChar,300),
					new SqlParameter("@openRemarks", SqlDbType.VarChar,300),
					new SqlParameter("@policyWay", SqlDbType.VarChar,2),
					new SqlParameter("@providerId", SqlDbType.VarChar,32),
					new SqlParameter("@worktimeto", SqlDbType.Int,4),
					new SqlParameter("@worktimeFrom", SqlDbType.Int,4),
					new SqlParameter("@payType", SqlDbType.VarChar,10),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.policyID;
			parameters[1].Value = model.fromPlace;
			parameters[2].Value = model.toPlace;
			parameters[3].Value = model.flightNo;
			parameters[4].Value = model.fromTime;
			parameters[5].Value = model.toTime;
			parameters[6].Value = model.discountMax;
			parameters[7].Value = model.discountMin;
			parameters[8].Value = model.rate;
			parameters[9].Value = model.remarks;
			parameters[10].Value = model.flightScope;
			parameters[11].Value = model.printTickFromTime;
			parameters[12].Value = model.printTickToTime;
			parameters[13].Value = model.publisherId;
			parameters[14].Value = model.status;
			parameters[15].Value = model.lastUserName;
			parameters[16].Value = model.submitTime;
			parameters[17].Value = model.lastUpdateTime;
			parameters[18].Value = model.routeType;
			parameters[19].Value = model.applyClass;
			parameters[20].Value = model.specMark;
			parameters[21].Value = model.specNote;
			parameters[22].Value = model.policyType;
			parameters[23].Value = model.airCom;
			parameters[24].Value = model.type;
			parameters[25].Value = model.changePNR;
			parameters[26].Value = model.bookingRemarks;
			parameters[27].Value = model.bounceRemarks;
			parameters[28].Value = model.ticketChangingRemarks;
			parameters[29].Value = model.openRemarks;
			parameters[30].Value = model.policyWay;
			parameters[31].Value = model.providerId;
			parameters[32].Value = model.worktimeto;
			parameters[33].Value = model.worktimeFrom;
			parameters[34].Value = model.payType;
			parameters[35].Value = model.id;

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
			strSql.Append("delete from Piaomeng_policy ");
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
			strSql.Append("delete from Piaomeng_policy ");
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
		public Sanben.Model.Piaomeng_policy GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,policyID,fromPlace,toPlace,flightNo,fromTime,toTime,discountMax,discountMin,rate,remarks,flightScope,printTickFromTime,printTickToTime,publisherId,status,lastUserName,submitTime,lastUpdateTime,routeType,applyClass,specMark,specNote,policyType,airCom,type,changePNR,bookingRemarks,bounceRemarks,ticketChangingRemarks,openRemarks,policyWay,providerId,worktimeto,worktimeFrom,payType from Piaomeng_policy ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Sanben.Model.Piaomeng_policy model=new Sanben.Model.Piaomeng_policy();
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
		public Sanben.Model.Piaomeng_policy DataRowToModel(DataRow row)
		{
			Sanben.Model.Piaomeng_policy model=new Sanben.Model.Piaomeng_policy();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["policyID"]!=null)
				{
					model.policyID=row["policyID"].ToString();
				}
				if(row["fromPlace"]!=null)
				{
					model.fromPlace=row["fromPlace"].ToString();
				}
				if(row["toPlace"]!=null)
				{
					model.toPlace=row["toPlace"].ToString();
				}
				if(row["flightNo"]!=null)
				{
					model.flightNo=row["flightNo"].ToString();
				}
				if(row["fromTime"]!=null && row["fromTime"].ToString()!="")
				{
					model.fromTime=DateTime.Parse(row["fromTime"].ToString());
				}
				if(row["toTime"]!=null && row["toTime"].ToString()!="")
				{
					model.toTime=DateTime.Parse(row["toTime"].ToString());
				}
				if(row["discountMax"]!=null && row["discountMax"].ToString()!="")
				{
					model.discountMax=decimal.Parse(row["discountMax"].ToString());
				}
				if(row["discountMin"]!=null && row["discountMin"].ToString()!="")
				{
					model.discountMin=decimal.Parse(row["discountMin"].ToString());
				}
				if(row["rate"]!=null && row["rate"].ToString()!="")
				{
					model.rate=decimal.Parse(row["rate"].ToString());
				}
				if(row["remarks"]!=null)
				{
					model.remarks=row["remarks"].ToString();
				}
				if(row["flightScope"]!=null)
				{
					model.flightScope=row["flightScope"].ToString();
				}
				if(row["printTickFromTime"]!=null && row["printTickFromTime"].ToString()!="")
				{
					model.printTickFromTime=DateTime.Parse(row["printTickFromTime"].ToString());
				}
				if(row["printTickToTime"]!=null && row["printTickToTime"].ToString()!="")
				{
					model.printTickToTime=DateTime.Parse(row["printTickToTime"].ToString());
				}
				if(row["publisherId"]!=null)
				{
					model.publisherId=row["publisherId"].ToString();
				}
				if(row["status"]!=null)
				{
					model.status=row["status"].ToString();
				}
				if(row["lastUserName"]!=null)
				{
					model.lastUserName=row["lastUserName"].ToString();
				}
				if(row["submitTime"]!=null && row["submitTime"].ToString()!="")
				{
					model.submitTime=DateTime.Parse(row["submitTime"].ToString());
				}
				if(row["lastUpdateTime"]!=null && row["lastUpdateTime"].ToString()!="")
				{
					model.lastUpdateTime=DateTime.Parse(row["lastUpdateTime"].ToString());
				}
				if(row["routeType"]!=null)
				{
					model.routeType=row["routeType"].ToString();
				}
				if(row["applyClass"]!=null)
				{
					model.applyClass=row["applyClass"].ToString();
				}
				if(row["specMark"]!=null)
				{
					model.specMark=row["specMark"].ToString();
				}
				if(row["specNote"]!=null)
				{
					model.specNote=row["specNote"].ToString();
				}
				if(row["policyType"]!=null)
				{
					model.policyType=row["policyType"].ToString();
				}
				if(row["airCom"]!=null)
				{
					model.airCom=row["airCom"].ToString();
				}
				if(row["type"]!=null)
				{
					model.type=row["type"].ToString();
				}
				if(row["changePNR"]!=null)
				{
					model.changePNR=row["changePNR"].ToString();
				}
				if(row["bookingRemarks"]!=null)
				{
					model.bookingRemarks=row["bookingRemarks"].ToString();
				}
				if(row["bounceRemarks"]!=null)
				{
					model.bounceRemarks=row["bounceRemarks"].ToString();
				}
				if(row["ticketChangingRemarks"]!=null)
				{
					model.ticketChangingRemarks=row["ticketChangingRemarks"].ToString();
				}
				if(row["openRemarks"]!=null)
				{
					model.openRemarks=row["openRemarks"].ToString();
				}
				if(row["policyWay"]!=null)
				{
					model.policyWay=row["policyWay"].ToString();
				}
				if(row["providerId"]!=null)
				{
					model.providerId=row["providerId"].ToString();
				}
				if(row["worktimeto"]!=null && row["worktimeto"].ToString()!="")
				{
					model.worktimeto=int.Parse(row["worktimeto"].ToString());
				}
				if(row["worktimeFrom"]!=null && row["worktimeFrom"].ToString()!="")
				{
					model.worktimeFrom=int.Parse(row["worktimeFrom"].ToString());
				}
				if(row["payType"]!=null)
				{
					model.payType=row["payType"].ToString();
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
			strSql.Append("select id,policyID,fromPlace,toPlace,flightNo,fromTime,toTime,discountMax,discountMin,rate,remarks,flightScope,printTickFromTime,printTickToTime,publisherId,status,lastUserName,submitTime,lastUpdateTime,routeType,applyClass,specMark,specNote,policyType,airCom,type,changePNR,bookingRemarks,bounceRemarks,ticketChangingRemarks,openRemarks,policyWay,providerId,worktimeto,worktimeFrom,payType ");
			strSql.Append(" FROM Piaomeng_policy ");
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
			strSql.Append(" id,policyID,fromPlace,toPlace,flightNo,fromTime,toTime,discountMax,discountMin,rate,remarks,flightScope,printTickFromTime,printTickToTime,publisherId,status,lastUserName,submitTime,lastUpdateTime,routeType,applyClass,specMark,specNote,policyType,airCom,type,changePNR,bookingRemarks,bounceRemarks,ticketChangingRemarks,openRemarks,policyWay,providerId,worktimeto,worktimeFrom,payType ");
			strSql.Append(" FROM Piaomeng_policy ");
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
			strSql.Append("select count(1) FROM Piaomeng_policy ");
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
			strSql.Append(")AS Row, T.*  from Piaomeng_policy T ");
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
			parameters[0].Value = "Piaomeng_policy";
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

