using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:BaQianYiPolicy
	/// </summary>
	public partial class BaQianYiPolicy:IBaQianYiPolicy
	{
		public BaQianYiPolicy()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Sanben.Model.BaQianYiPolicy model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BaQianYiPolicy(");
			strSql.Append("policy_num,startcity,arrivecity,airline,for_flight_no,ex_flight_no,policy_ratype,point,cabin_discount,startdate,arrivedate,nomal_workday,weekday,vip_policy,return_policy,policy_type,policy_note,supplier_id,or_ticket_t,week_ticket_t,policy_flight,end_state,office_code,salestart_date,saleend_date,support_pay,ticket_efficient,is_cgnum_ticket,is_open_low,addtime,last_modify_time,IsUpload,IsUpdate)");
			strSql.Append(" values (");
			strSql.Append("@policy_num,@startcity,@arrivecity,@airline,@for_flight_no,@ex_flight_no,@policy_ratype,@point,@cabin_discount,@startdate,@arrivedate,@nomal_workday,@weekday,@vip_policy,@return_policy,@policy_type,@policy_note,@supplier_id,@or_ticket_t,@week_ticket_t,@policy_flight,@end_state,@office_code,@salestart_date,@saleend_date,@support_pay,@ticket_efficient,@is_cgnum_ticket,@is_open_low,@addtime,@last_modify_time,@IsUpload,@IsUpdate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@policy_num", SqlDbType.NVarChar,255),
					new SqlParameter("@startcity", SqlDbType.NVarChar,255),
					new SqlParameter("@arrivecity", SqlDbType.NVarChar,255),
					new SqlParameter("@airline", SqlDbType.NVarChar,255),
					new SqlParameter("@for_flight_no", SqlDbType.NVarChar,255),
					new SqlParameter("@ex_flight_no", SqlDbType.NVarChar,255),
					new SqlParameter("@policy_ratype", SqlDbType.NVarChar,255),
					new SqlParameter("@point", SqlDbType.NVarChar,255),
					new SqlParameter("@cabin_discount", SqlDbType.NVarChar,255),
					new SqlParameter("@startdate", SqlDbType.NVarChar,255),
					new SqlParameter("@arrivedate", SqlDbType.NVarChar,255),
					new SqlParameter("@nomal_workday", SqlDbType.NVarChar,255),
					new SqlParameter("@weekday", SqlDbType.NVarChar,255),
					new SqlParameter("@vip_policy", SqlDbType.NVarChar,255),
					new SqlParameter("@return_policy", SqlDbType.NVarChar,255),
					new SqlParameter("@policy_type", SqlDbType.NVarChar,255),
					new SqlParameter("@policy_note", SqlDbType.NVarChar,255),
					new SqlParameter("@supplier_id", SqlDbType.NVarChar,255),
					new SqlParameter("@or_ticket_t", SqlDbType.NVarChar,255),
					new SqlParameter("@week_ticket_t", SqlDbType.NVarChar,255),
					new SqlParameter("@policy_flight", SqlDbType.NVarChar,255),
					new SqlParameter("@end_state", SqlDbType.NVarChar,255),
					new SqlParameter("@office_code", SqlDbType.NVarChar,255),
					new SqlParameter("@salestart_date", SqlDbType.NVarChar,255),
					new SqlParameter("@saleend_date", SqlDbType.NVarChar,255),
					new SqlParameter("@support_pay", SqlDbType.NVarChar,255),
					new SqlParameter("@ticket_efficient", SqlDbType.NVarChar,255),
					new SqlParameter("@is_cgnum_ticket", SqlDbType.NVarChar,255),
					new SqlParameter("@is_open_low", SqlDbType.NVarChar,255),
					new SqlParameter("@addtime", SqlDbType.DateTime),
					new SqlParameter("@last_modify_time", SqlDbType.NVarChar,255),
					new SqlParameter("@IsUpload", SqlDbType.Bit,1),
					new SqlParameter("@IsUpdate", SqlDbType.Bit,1)};
			parameters[0].Value = model.policy_num;
			parameters[1].Value = model.startcity;
			parameters[2].Value = model.arrivecity;
			parameters[3].Value = model.airline;
			parameters[4].Value = model.for_flight_no;
			parameters[5].Value = model.ex_flight_no;
			parameters[6].Value = model.policy_ratype;
			parameters[7].Value = model.point;
			parameters[8].Value = model.cabin_discount;
			parameters[9].Value = model.startdate;
			parameters[10].Value = model.arrivedate;
			parameters[11].Value = model.nomal_workday;
			parameters[12].Value = model.weekday;
			parameters[13].Value = model.vip_policy;
			parameters[14].Value = model.return_policy;
			parameters[15].Value = model.policy_type;
			parameters[16].Value = model.policy_note;
			parameters[17].Value = model.supplier_id;
			parameters[18].Value = model.or_ticket_t;
			parameters[19].Value = model.week_ticket_t;
			parameters[20].Value = model.policy_flight;
			parameters[21].Value = model.end_state;
			parameters[22].Value = model.office_code;
			parameters[23].Value = model.salestart_date;
			parameters[24].Value = model.saleend_date;
			parameters[25].Value = model.support_pay;
			parameters[26].Value = model.ticket_efficient;
			parameters[27].Value = model.is_cgnum_ticket;
			parameters[28].Value = model.is_open_low;
			parameters[29].Value = model.addtime;
			parameters[30].Value = model.last_modify_time;
			parameters[31].Value = model.IsUpload;
			parameters[32].Value = model.IsUpdate;

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
		public bool Update(Sanben.Model.BaQianYiPolicy model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BaQianYiPolicy set ");
			strSql.Append("policy_num=@policy_num,");
			strSql.Append("startcity=@startcity,");
			strSql.Append("arrivecity=@arrivecity,");
			strSql.Append("airline=@airline,");
			strSql.Append("for_flight_no=@for_flight_no,");
			strSql.Append("ex_flight_no=@ex_flight_no,");
			strSql.Append("policy_ratype=@policy_ratype,");
			strSql.Append("point=@point,");
			strSql.Append("cabin_discount=@cabin_discount,");
			strSql.Append("startdate=@startdate,");
			strSql.Append("arrivedate=@arrivedate,");
			strSql.Append("nomal_workday=@nomal_workday,");
			strSql.Append("weekday=@weekday,");
			strSql.Append("vip_policy=@vip_policy,");
			strSql.Append("return_policy=@return_policy,");
			strSql.Append("policy_type=@policy_type,");
			strSql.Append("policy_note=@policy_note,");
			strSql.Append("supplier_id=@supplier_id,");
			strSql.Append("or_ticket_t=@or_ticket_t,");
			strSql.Append("week_ticket_t=@week_ticket_t,");
			strSql.Append("policy_flight=@policy_flight,");
			strSql.Append("end_state=@end_state,");
			strSql.Append("office_code=@office_code,");
			strSql.Append("salestart_date=@salestart_date,");
			strSql.Append("saleend_date=@saleend_date,");
			strSql.Append("support_pay=@support_pay,");
			strSql.Append("ticket_efficient=@ticket_efficient,");
			strSql.Append("is_cgnum_ticket=@is_cgnum_ticket,");
			strSql.Append("is_open_low=@is_open_low,");
			strSql.Append("addtime=@addtime,");
			strSql.Append("last_modify_time=@last_modify_time,");
			strSql.Append("IsUpload=@IsUpload,");
			strSql.Append("IsUpdate=@IsUpdate");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@policy_num", SqlDbType.NVarChar,255),
					new SqlParameter("@startcity", SqlDbType.NVarChar,255),
					new SqlParameter("@arrivecity", SqlDbType.NVarChar,255),
					new SqlParameter("@airline", SqlDbType.NVarChar,255),
					new SqlParameter("@for_flight_no", SqlDbType.NVarChar,255),
					new SqlParameter("@ex_flight_no", SqlDbType.NVarChar,255),
					new SqlParameter("@policy_ratype", SqlDbType.NVarChar,255),
					new SqlParameter("@point", SqlDbType.NVarChar,255),
					new SqlParameter("@cabin_discount", SqlDbType.NVarChar,255),
					new SqlParameter("@startdate", SqlDbType.NVarChar,255),
					new SqlParameter("@arrivedate", SqlDbType.NVarChar,255),
					new SqlParameter("@nomal_workday", SqlDbType.NVarChar,255),
					new SqlParameter("@weekday", SqlDbType.NVarChar,255),
					new SqlParameter("@vip_policy", SqlDbType.NVarChar,255),
					new SqlParameter("@return_policy", SqlDbType.NVarChar,255),
					new SqlParameter("@policy_type", SqlDbType.NVarChar,255),
					new SqlParameter("@policy_note", SqlDbType.NVarChar,255),
					new SqlParameter("@supplier_id", SqlDbType.NVarChar,255),
					new SqlParameter("@or_ticket_t", SqlDbType.NVarChar,255),
					new SqlParameter("@week_ticket_t", SqlDbType.NVarChar,255),
					new SqlParameter("@policy_flight", SqlDbType.NVarChar,255),
					new SqlParameter("@end_state", SqlDbType.NVarChar,255),
					new SqlParameter("@office_code", SqlDbType.NVarChar,255),
					new SqlParameter("@salestart_date", SqlDbType.NVarChar,255),
					new SqlParameter("@saleend_date", SqlDbType.NVarChar,255),
					new SqlParameter("@support_pay", SqlDbType.NVarChar,255),
					new SqlParameter("@ticket_efficient", SqlDbType.NVarChar,255),
					new SqlParameter("@is_cgnum_ticket", SqlDbType.NVarChar,255),
					new SqlParameter("@is_open_low", SqlDbType.NVarChar,255),
					new SqlParameter("@addtime", SqlDbType.DateTime),
					new SqlParameter("@last_modify_time", SqlDbType.NVarChar,255),
					new SqlParameter("@IsUpload", SqlDbType.Bit,1),
					new SqlParameter("@IsUpdate", SqlDbType.Bit,1),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.policy_num;
			parameters[1].Value = model.startcity;
			parameters[2].Value = model.arrivecity;
			parameters[3].Value = model.airline;
			parameters[4].Value = model.for_flight_no;
			parameters[5].Value = model.ex_flight_no;
			parameters[6].Value = model.policy_ratype;
			parameters[7].Value = model.point;
			parameters[8].Value = model.cabin_discount;
			parameters[9].Value = model.startdate;
			parameters[10].Value = model.arrivedate;
			parameters[11].Value = model.nomal_workday;
			parameters[12].Value = model.weekday;
			parameters[13].Value = model.vip_policy;
			parameters[14].Value = model.return_policy;
			parameters[15].Value = model.policy_type;
			parameters[16].Value = model.policy_note;
			parameters[17].Value = model.supplier_id;
			parameters[18].Value = model.or_ticket_t;
			parameters[19].Value = model.week_ticket_t;
			parameters[20].Value = model.policy_flight;
			parameters[21].Value = model.end_state;
			parameters[22].Value = model.office_code;
			parameters[23].Value = model.salestart_date;
			parameters[24].Value = model.saleend_date;
			parameters[25].Value = model.support_pay;
			parameters[26].Value = model.ticket_efficient;
			parameters[27].Value = model.is_cgnum_ticket;
			parameters[28].Value = model.is_open_low;
			parameters[29].Value = model.addtime;
			parameters[30].Value = model.last_modify_time;
			parameters[31].Value = model.IsUpload;
			parameters[32].Value = model.IsUpdate;
			parameters[33].Value = model.ID;

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
			strSql.Append("delete from BaQianYiPolicy ");
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
			strSql.Append("delete from BaQianYiPolicy ");
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
		public Sanben.Model.BaQianYiPolicy GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,policy_num,startcity,arrivecity,airline,for_flight_no,ex_flight_no,policy_ratype,point,cabin_discount,startdate,arrivedate,nomal_workday,weekday,vip_policy,return_policy,policy_type,policy_note,supplier_id,or_ticket_t,week_ticket_t,policy_flight,end_state,office_code,salestart_date,saleend_date,support_pay,ticket_efficient,is_cgnum_ticket,is_open_low,addtime,last_modify_time,IsUpload,IsUpdate from BaQianYiPolicy ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Sanben.Model.BaQianYiPolicy model=new Sanben.Model.BaQianYiPolicy();
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
		public Sanben.Model.BaQianYiPolicy DataRowToModel(DataRow row)
		{
			Sanben.Model.BaQianYiPolicy model=new Sanben.Model.BaQianYiPolicy();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["policy_num"]!=null)
				{
					model.policy_num=row["policy_num"].ToString();
				}
				if(row["startcity"]!=null)
				{
					model.startcity=row["startcity"].ToString();
				}
				if(row["arrivecity"]!=null)
				{
					model.arrivecity=row["arrivecity"].ToString();
				}
				if(row["airline"]!=null)
				{
					model.airline=row["airline"].ToString();
				}
				if(row["for_flight_no"]!=null)
				{
					model.for_flight_no=row["for_flight_no"].ToString();
				}
				if(row["ex_flight_no"]!=null)
				{
					model.ex_flight_no=row["ex_flight_no"].ToString();
				}
				if(row["policy_ratype"]!=null)
				{
					model.policy_ratype=row["policy_ratype"].ToString();
				}
				if(row["point"]!=null)
				{
					model.point=row["point"].ToString();
				}
				if(row["cabin_discount"]!=null)
				{
					model.cabin_discount=row["cabin_discount"].ToString();
				}
				if(row["startdate"]!=null)
				{
					model.startdate=row["startdate"].ToString();
				}
				if(row["arrivedate"]!=null)
				{
					model.arrivedate=row["arrivedate"].ToString();
				}
				if(row["nomal_workday"]!=null)
				{
					model.nomal_workday=row["nomal_workday"].ToString();
				}
				if(row["weekday"]!=null)
				{
					model.weekday=row["weekday"].ToString();
				}
				if(row["vip_policy"]!=null)
				{
					model.vip_policy=row["vip_policy"].ToString();
				}
				if(row["return_policy"]!=null)
				{
					model.return_policy=row["return_policy"].ToString();
				}
				if(row["policy_type"]!=null)
				{
					model.policy_type=row["policy_type"].ToString();
				}
				if(row["policy_note"]!=null)
				{
					model.policy_note=row["policy_note"].ToString();
				}
				if(row["supplier_id"]!=null)
				{
					model.supplier_id=row["supplier_id"].ToString();
				}
				if(row["or_ticket_t"]!=null)
				{
					model.or_ticket_t=row["or_ticket_t"].ToString();
				}
				if(row["week_ticket_t"]!=null)
				{
					model.week_ticket_t=row["week_ticket_t"].ToString();
				}
				if(row["policy_flight"]!=null)
				{
					model.policy_flight=row["policy_flight"].ToString();
				}
				if(row["end_state"]!=null)
				{
					model.end_state=row["end_state"].ToString();
				}
				if(row["office_code"]!=null)
				{
					model.office_code=row["office_code"].ToString();
				}
				if(row["salestart_date"]!=null)
				{
					model.salestart_date=row["salestart_date"].ToString();
				}
				if(row["saleend_date"]!=null)
				{
					model.saleend_date=row["saleend_date"].ToString();
				}
				if(row["support_pay"]!=null)
				{
					model.support_pay=row["support_pay"].ToString();
				}
				if(row["ticket_efficient"]!=null)
				{
					model.ticket_efficient=row["ticket_efficient"].ToString();
				}
				if(row["is_cgnum_ticket"]!=null)
				{
					model.is_cgnum_ticket=row["is_cgnum_ticket"].ToString();
				}
				if(row["is_open_low"]!=null)
				{
					model.is_open_low=row["is_open_low"].ToString();
				}
				if(row["addtime"]!=null && row["addtime"].ToString()!="")
				{
					model.addtime=DateTime.Parse(row["addtime"].ToString());
				}
				if(row["last_modify_time"]!=null)
				{
					model.last_modify_time=row["last_modify_time"].ToString();
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
			strSql.Append("select ID,policy_num,startcity,arrivecity,airline,for_flight_no,ex_flight_no,policy_ratype,point,cabin_discount,startdate,arrivedate,nomal_workday,weekday,vip_policy,return_policy,policy_type,policy_note,supplier_id,or_ticket_t,week_ticket_t,policy_flight,end_state,office_code,salestart_date,saleend_date,support_pay,ticket_efficient,is_cgnum_ticket,is_open_low,addtime,last_modify_time,IsUpload,IsUpdate ");
			strSql.Append(" FROM BaQianYiPolicy ");
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
			strSql.Append(" ID,policy_num,startcity,arrivecity,airline,for_flight_no,ex_flight_no,policy_ratype,point,cabin_discount,startdate,arrivedate,nomal_workday,weekday,vip_policy,return_policy,policy_type,policy_note,supplier_id,or_ticket_t,week_ticket_t,policy_flight,end_state,office_code,salestart_date,saleend_date,support_pay,ticket_efficient,is_cgnum_ticket,is_open_low,addtime,last_modify_time,IsUpload,IsUpdate ");
			strSql.Append(" FROM BaQianYiPolicy ");
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
			strSql.Append("select count(1) FROM BaQianYiPolicy ");
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
			strSql.Append(")AS Row, T.*  from BaQianYiPolicy T ");
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
			parameters[0].Value = "BaQianYiPolicy";
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

