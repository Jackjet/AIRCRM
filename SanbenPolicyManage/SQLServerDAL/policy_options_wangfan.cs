using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:policy_options_wangfan
	/// </summary>
	public partial class policy_options_wangfan:Ipolicy_options_wangfan
	{
		public policy_options_wangfan()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "policy_options_wangfan"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from policy_options_wangfan");
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
		public int Add(Sanben.Model.policy_options_wangfan model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into policy_options_wangfan(");
			strSql.Append("tolerate_stationary_point,tolerate_leave_money,lowest_rebate,highest_rebate,earliest_advance_days,night_before_days,rebate_class_set,Flight_departure_time_start,Flight_departure_time_end,is_automatic_ticket,is_mail_itinerary,empower_office_number,tolerate_refund_change_rule,class_description,special_ticketing_instructions,Policy_interface_id,sys_userId)");
			strSql.Append(" values (");
			strSql.Append("@tolerate_stationary_point,@tolerate_leave_money,@lowest_rebate,@highest_rebate,@earliest_advance_days,@night_before_days,@rebate_class_set,@Flight_departure_time_start,@Flight_departure_time_end,@is_automatic_ticket,@is_mail_itinerary,@empower_office_number,@tolerate_refund_change_rule,@class_description,@special_ticketing_instructions,@Policy_interface_id,@sys_userId)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@tolerate_stationary_point", SqlDbType.Float,8),
					new SqlParameter("@tolerate_leave_money", SqlDbType.Float,8),
					new SqlParameter("@lowest_rebate", SqlDbType.Float,8),
					new SqlParameter("@highest_rebate", SqlDbType.Float,8),
					new SqlParameter("@earliest_advance_days", SqlDbType.Int,4),
					new SqlParameter("@night_before_days", SqlDbType.Int,4),
					new SqlParameter("@rebate_class_set", SqlDbType.Int,4),
					new SqlParameter("@Flight_departure_time_start", SqlDbType.Time,3),
					new SqlParameter("@Flight_departure_time_end", SqlDbType.Time,3),
					new SqlParameter("@is_automatic_ticket", SqlDbType.Bit,1),
					new SqlParameter("@is_mail_itinerary", SqlDbType.Bit,1),
					new SqlParameter("@empower_office_number", SqlDbType.NVarChar,255),
					new SqlParameter("@tolerate_refund_change_rule", SqlDbType.NVarChar,255),
					new SqlParameter("@class_description", SqlDbType.NVarChar,255),
					new SqlParameter("@special_ticketing_instructions", SqlDbType.NVarChar,255),
					new SqlParameter("@Policy_interface_id", SqlDbType.Int,4),
					new SqlParameter("@sys_userId", SqlDbType.Int,4)};
			parameters[0].Value = model.tolerate_stationary_point;
			parameters[1].Value = model.tolerate_leave_money;
			parameters[2].Value = model.lowest_rebate;
			parameters[3].Value = model.highest_rebate;
			parameters[4].Value = model.earliest_advance_days;
			parameters[5].Value = model.night_before_days;
			parameters[6].Value = model.rebate_class_set;
			parameters[7].Value = model.Flight_departure_time_start;
			parameters[8].Value = model.Flight_departure_time_end;
			parameters[9].Value = model.is_automatic_ticket;
			parameters[10].Value = model.is_mail_itinerary;
			parameters[11].Value = model.empower_office_number;
			parameters[12].Value = model.tolerate_refund_change_rule;
			parameters[13].Value = model.class_description;
			parameters[14].Value = model.special_ticketing_instructions;
			parameters[15].Value = model.Policy_interface_id;
			parameters[16].Value = model.sys_userId;

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
		public bool Update(Sanben.Model.policy_options_wangfan model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update policy_options_wangfan set ");
			strSql.Append("tolerate_stationary_point=@tolerate_stationary_point,");
			strSql.Append("tolerate_leave_money=@tolerate_leave_money,");
			strSql.Append("lowest_rebate=@lowest_rebate,");
			strSql.Append("highest_rebate=@highest_rebate,");
			strSql.Append("earliest_advance_days=@earliest_advance_days,");
			strSql.Append("night_before_days=@night_before_days,");
			strSql.Append("rebate_class_set=@rebate_class_set,");
			strSql.Append("Flight_departure_time_start=@Flight_departure_time_start,");
			strSql.Append("Flight_departure_time_end=@Flight_departure_time_end,");
			strSql.Append("is_automatic_ticket=@is_automatic_ticket,");
			strSql.Append("is_mail_itinerary=@is_mail_itinerary,");
			strSql.Append("empower_office_number=@empower_office_number,");
			strSql.Append("tolerate_refund_change_rule=@tolerate_refund_change_rule,");
			strSql.Append("class_description=@class_description,");
			strSql.Append("special_ticketing_instructions=@special_ticketing_instructions,");
			strSql.Append("Policy_interface_id=@Policy_interface_id,");
			strSql.Append("sys_userId=@sys_userId");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@tolerate_stationary_point", SqlDbType.Float,8),
					new SqlParameter("@tolerate_leave_money", SqlDbType.Float,8),
					new SqlParameter("@lowest_rebate", SqlDbType.Float,8),
					new SqlParameter("@highest_rebate", SqlDbType.Float,8),
					new SqlParameter("@earliest_advance_days", SqlDbType.Int,4),
					new SqlParameter("@night_before_days", SqlDbType.Int,4),
					new SqlParameter("@rebate_class_set", SqlDbType.Int,4),
					new SqlParameter("@Flight_departure_time_start", SqlDbType.Time,3),
					new SqlParameter("@Flight_departure_time_end", SqlDbType.Time,3),
					new SqlParameter("@is_automatic_ticket", SqlDbType.Bit,1),
					new SqlParameter("@is_mail_itinerary", SqlDbType.Bit,1),
					new SqlParameter("@empower_office_number", SqlDbType.NVarChar,255),
					new SqlParameter("@tolerate_refund_change_rule", SqlDbType.NVarChar,255),
					new SqlParameter("@class_description", SqlDbType.NVarChar,255),
					new SqlParameter("@special_ticketing_instructions", SqlDbType.NVarChar,255),
					new SqlParameter("@Policy_interface_id", SqlDbType.Int,4),
					new SqlParameter("@sys_userId", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.tolerate_stationary_point;
			parameters[1].Value = model.tolerate_leave_money;
			parameters[2].Value = model.lowest_rebate;
			parameters[3].Value = model.highest_rebate;
			parameters[4].Value = model.earliest_advance_days;
			parameters[5].Value = model.night_before_days;
			parameters[6].Value = model.rebate_class_set;
			parameters[7].Value = model.Flight_departure_time_start;
			parameters[8].Value = model.Flight_departure_time_end;
			parameters[9].Value = model.is_automatic_ticket;
			parameters[10].Value = model.is_mail_itinerary;
			parameters[11].Value = model.empower_office_number;
			parameters[12].Value = model.tolerate_refund_change_rule;
			parameters[13].Value = model.class_description;
			parameters[14].Value = model.special_ticketing_instructions;
			parameters[15].Value = model.Policy_interface_id;
			parameters[16].Value = model.sys_userId;
			parameters[17].Value = model.id;

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
			strSql.Append("delete from policy_options_wangfan ");
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
			strSql.Append("delete from policy_options_wangfan ");
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
		public Sanben.Model.policy_options_wangfan GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,tolerate_stationary_point,tolerate_leave_money,lowest_rebate,highest_rebate,earliest_advance_days,night_before_days,rebate_class_set,Flight_departure_time_start,Flight_departure_time_end,is_automatic_ticket,is_mail_itinerary,empower_office_number,tolerate_refund_change_rule,class_description,special_ticketing_instructions,Policy_interface_id,sys_userId from policy_options_wangfan ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Sanben.Model.policy_options_wangfan model=new Sanben.Model.policy_options_wangfan();
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
		public Sanben.Model.policy_options_wangfan DataRowToModel(DataRow row)
		{
			Sanben.Model.policy_options_wangfan model=new Sanben.Model.policy_options_wangfan();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["tolerate_stationary_point"]!=null && row["tolerate_stationary_point"].ToString()!="")
				{
					model.tolerate_stationary_point=decimal.Parse(row["tolerate_stationary_point"].ToString());
				}
				if(row["tolerate_leave_money"]!=null && row["tolerate_leave_money"].ToString()!="")
				{
					model.tolerate_leave_money=decimal.Parse(row["tolerate_leave_money"].ToString());
				}
				if(row["lowest_rebate"]!=null && row["lowest_rebate"].ToString()!="")
				{
					model.lowest_rebate=decimal.Parse(row["lowest_rebate"].ToString());
				}
				if(row["highest_rebate"]!=null && row["highest_rebate"].ToString()!="")
				{
					model.highest_rebate=decimal.Parse(row["highest_rebate"].ToString());
				}
				if(row["earliest_advance_days"]!=null && row["earliest_advance_days"].ToString()!="")
				{
					model.earliest_advance_days=int.Parse(row["earliest_advance_days"].ToString());
				}
				if(row["night_before_days"]!=null && row["night_before_days"].ToString()!="")
				{
					model.night_before_days=int.Parse(row["night_before_days"].ToString());
				}
				if(row["rebate_class_set"]!=null && row["rebate_class_set"].ToString()!="")
				{
					model.rebate_class_set=int.Parse(row["rebate_class_set"].ToString());
				}
				if(row["Flight_departure_time_start"]!=null && row["Flight_departure_time_start"].ToString()!="")
				{
					model.Flight_departure_time_start=DateTime.Parse(row["Flight_departure_time_start"].ToString());
				}
				if(row["Flight_departure_time_end"]!=null && row["Flight_departure_time_end"].ToString()!="")
				{
					model.Flight_departure_time_end=DateTime.Parse(row["Flight_departure_time_end"].ToString());
				}
				if(row["is_automatic_ticket"]!=null && row["is_automatic_ticket"].ToString()!="")
				{
					if((row["is_automatic_ticket"].ToString()=="1")||(row["is_automatic_ticket"].ToString().ToLower()=="true"))
					{
						model.is_automatic_ticket=true;
					}
					else
					{
						model.is_automatic_ticket=false;
					}
				}
				if(row["is_mail_itinerary"]!=null && row["is_mail_itinerary"].ToString()!="")
				{
					if((row["is_mail_itinerary"].ToString()=="1")||(row["is_mail_itinerary"].ToString().ToLower()=="true"))
					{
						model.is_mail_itinerary=true;
					}
					else
					{
						model.is_mail_itinerary=false;
					}
				}
				if(row["empower_office_number"]!=null)
				{
					model.empower_office_number=row["empower_office_number"].ToString();
				}
				if(row["tolerate_refund_change_rule"]!=null)
				{
					model.tolerate_refund_change_rule=row["tolerate_refund_change_rule"].ToString();
				}
				if(row["class_description"]!=null)
				{
					model.class_description=row["class_description"].ToString();
				}
				if(row["special_ticketing_instructions"]!=null)
				{
					model.special_ticketing_instructions=row["special_ticketing_instructions"].ToString();
				}
				if(row["Policy_interface_id"]!=null && row["Policy_interface_id"].ToString()!="")
				{
					model.Policy_interface_id=int.Parse(row["Policy_interface_id"].ToString());
				}
				if(row["sys_userId"]!=null && row["sys_userId"].ToString()!="")
				{
					model.sys_userId=int.Parse(row["sys_userId"].ToString());
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
			strSql.Append("select id,tolerate_stationary_point,tolerate_leave_money,lowest_rebate,highest_rebate,earliest_advance_days,night_before_days,rebate_class_set,Flight_departure_time_start,Flight_departure_time_end,is_automatic_ticket,is_mail_itinerary,empower_office_number,tolerate_refund_change_rule,class_description,special_ticketing_instructions,Policy_interface_id,sys_userId ");
			strSql.Append(" FROM policy_options_wangfan ");
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
			strSql.Append(" id,tolerate_stationary_point,tolerate_leave_money,lowest_rebate,highest_rebate,earliest_advance_days,night_before_days,rebate_class_set,Flight_departure_time_start,Flight_departure_time_end,is_automatic_ticket,is_mail_itinerary,empower_office_number,tolerate_refund_change_rule,class_description,special_ticketing_instructions,Policy_interface_id,sys_userId ");
			strSql.Append(" FROM policy_options_wangfan ");
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
			strSql.Append("select count(1) FROM policy_options_wangfan ");
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
			strSql.Append(")AS Row, T.*  from policy_options_wangfan T ");
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
			parameters[0].Value = "policy_options_wangfan";
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

