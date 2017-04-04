using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:ctripPolicyOptions
	/// </summary>
	public partial class ctripPolicyOptions:IctripPolicyOptions
	{
		public ctripPolicyOptions()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "ctripPolicyOptions"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ctripPolicyOptions");
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
		public int Add(Sanben.Model.ctripPolicyOptions model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ctripPolicyOptions(");
			strSql.Append("tolerate_stationary_point,tolerate_leave_money,lowest_rebate,highest_rebate,earliest_advance_days,night_before_days,rebate_class_set,ticket_price_set,workTimeLimit,discount,is_automatic_ticket,is_mail_itinerary,off_number,is_orientate,special_ticketing_instructions,refund_change_rule,platform_type_id,sys_id)");
			strSql.Append(" values (");
			strSql.Append("@tolerate_stationary_point,@tolerate_leave_money,@lowest_rebate,@highest_rebate,@earliest_advance_days,@night_before_days,@rebate_class_set,@ticket_price_set,@workTimeLimit,@discount,@is_automatic_ticket,@is_mail_itinerary,@off_number,@is_orientate,@special_ticketing_instructions,@refund_change_rule,@platform_type_id,@sys_id)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@tolerate_stationary_point", SqlDbType.Float,8),
					new SqlParameter("@tolerate_leave_money", SqlDbType.Float,8),
					new SqlParameter("@lowest_rebate", SqlDbType.Float,8),
					new SqlParameter("@highest_rebate", SqlDbType.Float,8),
					new SqlParameter("@earliest_advance_days", SqlDbType.Int,4),
					new SqlParameter("@night_before_days", SqlDbType.Int,4),
					new SqlParameter("@rebate_class_set", SqlDbType.Int,4),
					new SqlParameter("@ticket_price_set", SqlDbType.Int,4),
					new SqlParameter("@workTimeLimit", SqlDbType.VarChar,50),
					new SqlParameter("@discount", SqlDbType.Float,8),
					new SqlParameter("@is_automatic_ticket", SqlDbType.Bit,1),
					new SqlParameter("@is_mail_itinerary", SqlDbType.Bit,1),
					new SqlParameter("@off_number", SqlDbType.VarChar,50),
					new SqlParameter("@is_orientate", SqlDbType.Bit,1),
					new SqlParameter("@special_ticketing_instructions", SqlDbType.VarChar,255),
					new SqlParameter("@refund_change_rule", SqlDbType.VarChar,255),
					new SqlParameter("@platform_type_id", SqlDbType.Int,4),
					new SqlParameter("@sys_id", SqlDbType.Int,4)};
			parameters[0].Value = model.tolerate_stationary_point;
			parameters[1].Value = model.tolerate_leave_money;
			parameters[2].Value = model.lowest_rebate;
			parameters[3].Value = model.highest_rebate;
			parameters[4].Value = model.earliest_advance_days;
			parameters[5].Value = model.night_before_days;
			parameters[6].Value = model.rebate_class_set;
			parameters[7].Value = model.ticket_price_set;
			parameters[8].Value = model.workTimeLimit;
			parameters[9].Value = model.discount;
			parameters[10].Value = model.is_automatic_ticket;
			parameters[11].Value = model.is_mail_itinerary;
			parameters[12].Value = model.off_number;
			parameters[13].Value = model.is_orientate;
			parameters[14].Value = model.special_ticketing_instructions;
			parameters[15].Value = model.refund_change_rule;
			parameters[16].Value = model.platform_type_id;
			parameters[17].Value = model.sys_id;

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
		public bool Update(Sanben.Model.ctripPolicyOptions model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ctripPolicyOptions set ");
			strSql.Append("tolerate_stationary_point=@tolerate_stationary_point,");
			strSql.Append("tolerate_leave_money=@tolerate_leave_money,");
			strSql.Append("lowest_rebate=@lowest_rebate,");
			strSql.Append("highest_rebate=@highest_rebate,");
			strSql.Append("earliest_advance_days=@earliest_advance_days,");
			strSql.Append("night_before_days=@night_before_days,");
			strSql.Append("rebate_class_set=@rebate_class_set,");
			strSql.Append("ticket_price_set=@ticket_price_set,");
			strSql.Append("workTimeLimit=@workTimeLimit,");
			strSql.Append("discount=@discount,");
			strSql.Append("is_automatic_ticket=@is_automatic_ticket,");
			strSql.Append("is_mail_itinerary=@is_mail_itinerary,");
			strSql.Append("off_number=@off_number,");
			strSql.Append("is_orientate=@is_orientate,");
			strSql.Append("special_ticketing_instructions=@special_ticketing_instructions,");
			strSql.Append("refund_change_rule=@refund_change_rule,");
			strSql.Append("platform_type_id=@platform_type_id,");
			strSql.Append("sys_id=@sys_id");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@tolerate_stationary_point", SqlDbType.Float,8),
					new SqlParameter("@tolerate_leave_money", SqlDbType.Float,8),
					new SqlParameter("@lowest_rebate", SqlDbType.Float,8),
					new SqlParameter("@highest_rebate", SqlDbType.Float,8),
					new SqlParameter("@earliest_advance_days", SqlDbType.Int,4),
					new SqlParameter("@night_before_days", SqlDbType.Int,4),
					new SqlParameter("@rebate_class_set", SqlDbType.Int,4),
					new SqlParameter("@ticket_price_set", SqlDbType.Int,4),
					new SqlParameter("@workTimeLimit", SqlDbType.VarChar,50),
					new SqlParameter("@discount", SqlDbType.Float,8),
					new SqlParameter("@is_automatic_ticket", SqlDbType.Bit,1),
					new SqlParameter("@is_mail_itinerary", SqlDbType.Bit,1),
					new SqlParameter("@off_number", SqlDbType.VarChar,50),
					new SqlParameter("@is_orientate", SqlDbType.Bit,1),
					new SqlParameter("@special_ticketing_instructions", SqlDbType.VarChar,255),
					new SqlParameter("@refund_change_rule", SqlDbType.VarChar,255),
					new SqlParameter("@platform_type_id", SqlDbType.Int,4),
					new SqlParameter("@sys_id", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.tolerate_stationary_point;
			parameters[1].Value = model.tolerate_leave_money;
			parameters[2].Value = model.lowest_rebate;
			parameters[3].Value = model.highest_rebate;
			parameters[4].Value = model.earliest_advance_days;
			parameters[5].Value = model.night_before_days;
			parameters[6].Value = model.rebate_class_set;
			parameters[7].Value = model.ticket_price_set;
			parameters[8].Value = model.workTimeLimit;
			parameters[9].Value = model.discount;
			parameters[10].Value = model.is_automatic_ticket;
			parameters[11].Value = model.is_mail_itinerary;
			parameters[12].Value = model.off_number;
			parameters[13].Value = model.is_orientate;
			parameters[14].Value = model.special_ticketing_instructions;
			parameters[15].Value = model.refund_change_rule;
			parameters[16].Value = model.platform_type_id;
			parameters[17].Value = model.sys_id;
			parameters[18].Value = model.id;

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
			strSql.Append("delete from ctripPolicyOptions ");
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
			strSql.Append("delete from ctripPolicyOptions ");
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
		public Sanben.Model.ctripPolicyOptions GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,tolerate_stationary_point,tolerate_leave_money,lowest_rebate,highest_rebate,earliest_advance_days,night_before_days,rebate_class_set,ticket_price_set,workTimeLimit,discount,is_automatic_ticket,is_mail_itinerary,off_number,is_orientate,special_ticketing_instructions,refund_change_rule,platform_type_id,sys_id from ctripPolicyOptions ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Sanben.Model.ctripPolicyOptions model=new Sanben.Model.ctripPolicyOptions();
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
		public Sanben.Model.ctripPolicyOptions DataRowToModel(DataRow row)
		{
			Sanben.Model.ctripPolicyOptions model=new Sanben.Model.ctripPolicyOptions();
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
				if(row["ticket_price_set"]!=null && row["ticket_price_set"].ToString()!="")
				{
					model.ticket_price_set=int.Parse(row["ticket_price_set"].ToString());
				}
				if(row["workTimeLimit"]!=null)
				{
					model.workTimeLimit=row["workTimeLimit"].ToString();
				}
				if(row["discount"]!=null && row["discount"].ToString()!="")
				{
					model.discount=decimal.Parse(row["discount"].ToString());
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
				if(row["off_number"]!=null)
				{
					model.off_number=row["off_number"].ToString();
				}
				if(row["is_orientate"]!=null && row["is_orientate"].ToString()!="")
				{
					if((row["is_orientate"].ToString()=="1")||(row["is_orientate"].ToString().ToLower()=="true"))
					{
						model.is_orientate=true;
					}
					else
					{
						model.is_orientate=false;
					}
				}
				if(row["special_ticketing_instructions"]!=null)
				{
					model.special_ticketing_instructions=row["special_ticketing_instructions"].ToString();
				}
				if(row["refund_change_rule"]!=null)
				{
					model.refund_change_rule=row["refund_change_rule"].ToString();
				}
				if(row["platform_type_id"]!=null && row["platform_type_id"].ToString()!="")
				{
					model.platform_type_id=int.Parse(row["platform_type_id"].ToString());
				}
				if(row["sys_id"]!=null && row["sys_id"].ToString()!="")
				{
					model.sys_id=int.Parse(row["sys_id"].ToString());
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
			strSql.Append("select id,tolerate_stationary_point,tolerate_leave_money,lowest_rebate,highest_rebate,earliest_advance_days,night_before_days,rebate_class_set,ticket_price_set,workTimeLimit,discount,is_automatic_ticket,is_mail_itinerary,off_number,is_orientate,special_ticketing_instructions,refund_change_rule,platform_type_id,sys_id ");
			strSql.Append(" FROM ctripPolicyOptions ");
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
			strSql.Append(" id,tolerate_stationary_point,tolerate_leave_money,lowest_rebate,highest_rebate,earliest_advance_days,night_before_days,rebate_class_set,ticket_price_set,workTimeLimit,discount,is_automatic_ticket,is_mail_itinerary,off_number,is_orientate,special_ticketing_instructions,refund_change_rule,platform_type_id,sys_id ");
			strSql.Append(" FROM ctripPolicyOptions ");
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
			strSql.Append("select count(1) FROM ctripPolicyOptions ");
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
			strSql.Append(")AS Row, T.*  from ctripPolicyOptions T ");
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
			parameters[0].Value = "ctripPolicyOptions";
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

