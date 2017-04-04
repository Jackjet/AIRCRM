using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:policy_options
	/// </summary>
	public partial class policy_options:Ipolicy_options
	{
		public policy_options()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "policy_options"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from policy_options");
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
		public int Add(Sanben.Model.policy_options model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into policy_options(");
			strSql.Append("Policy_interface_id,tolerate_stationary_point,tolerate_leave_money,is_screening,lowest_rebate,highest_rebate,earliest_advance_days,night_before_days,rebate_class_set,Flight_departure_time_start,is_automatic_ticket,is_mail_itinerary,empower_office_number,refund_rule,changedate_rule,is_allowed_sign,is_provide_regular_passenger_integral,document_type,minimum_age,maximum_age,class_description,special_ticketing_instructions,sys_userId,Flight_departure_time_end)");
			strSql.Append(" values (");
			strSql.Append("@Policy_interface_id,@tolerate_stationary_point,@tolerate_leave_money,@is_screening,@lowest_rebate,@highest_rebate,@earliest_advance_days,@night_before_days,@rebate_class_set,@Flight_departure_time_start,@is_automatic_ticket,@is_mail_itinerary,@empower_office_number,@refund_rule,@changedate_rule,@is_allowed_sign,@is_provide_regular_passenger_integral,@document_type,@minimum_age,@maximum_age,@class_description,@special_ticketing_instructions,@sys_userId,@Flight_departure_time_end)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Policy_interface_id", SqlDbType.Int,4),
					new SqlParameter("@tolerate_stationary_point", SqlDbType.Float,8),
					new SqlParameter("@tolerate_leave_money", SqlDbType.Float,8),
					new SqlParameter("@is_screening", SqlDbType.Bit,1),
					new SqlParameter("@lowest_rebate", SqlDbType.Float,8),
					new SqlParameter("@highest_rebate", SqlDbType.Float,8),
					new SqlParameter("@earliest_advance_days", SqlDbType.Int,4),
					new SqlParameter("@night_before_days", SqlDbType.Int,4),
					new SqlParameter("@rebate_class_set", SqlDbType.Int,4),
					new SqlParameter("@Flight_departure_time_start", SqlDbType.Time,3),
					new SqlParameter("@is_automatic_ticket", SqlDbType.Bit,1),
					new SqlParameter("@is_mail_itinerary", SqlDbType.Bit,1),
					new SqlParameter("@empower_office_number", SqlDbType.NVarChar,255),
					new SqlParameter("@refund_rule", SqlDbType.NVarChar,255),
					new SqlParameter("@changedate_rule", SqlDbType.NVarChar,255),
					new SqlParameter("@is_allowed_sign", SqlDbType.Bit,1),
					new SqlParameter("@is_provide_regular_passenger_integral", SqlDbType.Bit,1),
					new SqlParameter("@document_type", SqlDbType.Int,4),
					new SqlParameter("@minimum_age", SqlDbType.Int,4),
					new SqlParameter("@maximum_age", SqlDbType.Int,4),
					new SqlParameter("@class_description", SqlDbType.NVarChar,255),
					new SqlParameter("@special_ticketing_instructions", SqlDbType.NVarChar,255),
					new SqlParameter("@sys_userId", SqlDbType.Int,4),
					new SqlParameter("@Flight_departure_time_end", SqlDbType.Time,3)};
			parameters[0].Value = model.Policy_interface_id;
			parameters[1].Value = model.tolerate_stationary_point;
			parameters[2].Value = model.tolerate_leave_money;
			parameters[3].Value = model.is_screening;
			parameters[4].Value = model.lowest_rebate;
			parameters[5].Value = model.highest_rebate;
			parameters[6].Value = model.earliest_advance_days;
			parameters[7].Value = model.night_before_days;
			parameters[8].Value = model.rebate_class_set;
			parameters[9].Value = model.Flight_departure_time_start;
			parameters[10].Value = model.is_automatic_ticket;
			parameters[11].Value = model.is_mail_itinerary;
			parameters[12].Value = model.empower_office_number;
			parameters[13].Value = model.refund_rule;
			parameters[14].Value = model.changedate_rule;
			parameters[15].Value = model.is_allowed_sign;
			parameters[16].Value = model.is_provide_regular_passenger_integral;
			parameters[17].Value = model.document_type;
			parameters[18].Value = model.minimum_age;
			parameters[19].Value = model.maximum_age;
			parameters[20].Value = model.class_description;
			parameters[21].Value = model.special_ticketing_instructions;
			parameters[22].Value = model.sys_userId;
			parameters[23].Value = model.Flight_departure_time_end;

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
		public bool Update(Sanben.Model.policy_options model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update policy_options set ");
			strSql.Append("Policy_interface_id=@Policy_interface_id,");
			strSql.Append("tolerate_stationary_point=@tolerate_stationary_point,");
			strSql.Append("tolerate_leave_money=@tolerate_leave_money,");
			strSql.Append("is_screening=@is_screening,");
			strSql.Append("lowest_rebate=@lowest_rebate,");
			strSql.Append("highest_rebate=@highest_rebate,");
			strSql.Append("earliest_advance_days=@earliest_advance_days,");
			strSql.Append("night_before_days=@night_before_days,");
			strSql.Append("rebate_class_set=@rebate_class_set,");
			strSql.Append("Flight_departure_time_start=@Flight_departure_time_start,");
			strSql.Append("is_automatic_ticket=@is_automatic_ticket,");
			strSql.Append("is_mail_itinerary=@is_mail_itinerary,");
			strSql.Append("empower_office_number=@empower_office_number,");
			strSql.Append("refund_rule=@refund_rule,");
			strSql.Append("changedate_rule=@changedate_rule,");
			strSql.Append("is_allowed_sign=@is_allowed_sign,");
			strSql.Append("is_provide_regular_passenger_integral=@is_provide_regular_passenger_integral,");
			strSql.Append("document_type=@document_type,");
			strSql.Append("minimum_age=@minimum_age,");
			strSql.Append("maximum_age=@maximum_age,");
			strSql.Append("class_description=@class_description,");
			strSql.Append("special_ticketing_instructions=@special_ticketing_instructions,");
			strSql.Append("sys_userId=@sys_userId,");
			strSql.Append("Flight_departure_time_end=@Flight_departure_time_end");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@Policy_interface_id", SqlDbType.Int,4),
					new SqlParameter("@tolerate_stationary_point", SqlDbType.Float,8),
					new SqlParameter("@tolerate_leave_money", SqlDbType.Float,8),
					new SqlParameter("@is_screening", SqlDbType.Bit,1),
					new SqlParameter("@lowest_rebate", SqlDbType.Float,8),
					new SqlParameter("@highest_rebate", SqlDbType.Float,8),
					new SqlParameter("@earliest_advance_days", SqlDbType.Int,4),
					new SqlParameter("@night_before_days", SqlDbType.Int,4),
					new SqlParameter("@rebate_class_set", SqlDbType.Int,4),
					new SqlParameter("@Flight_departure_time_start", SqlDbType.Time,3),
					new SqlParameter("@is_automatic_ticket", SqlDbType.Bit,1),
					new SqlParameter("@is_mail_itinerary", SqlDbType.Bit,1),
					new SqlParameter("@empower_office_number", SqlDbType.NVarChar,255),
					new SqlParameter("@refund_rule", SqlDbType.NVarChar,255),
					new SqlParameter("@changedate_rule", SqlDbType.NVarChar,255),
					new SqlParameter("@is_allowed_sign", SqlDbType.Bit,1),
					new SqlParameter("@is_provide_regular_passenger_integral", SqlDbType.Bit,1),
					new SqlParameter("@document_type", SqlDbType.Int,4),
					new SqlParameter("@minimum_age", SqlDbType.Int,4),
					new SqlParameter("@maximum_age", SqlDbType.Int,4),
					new SqlParameter("@class_description", SqlDbType.NVarChar,255),
					new SqlParameter("@special_ticketing_instructions", SqlDbType.NVarChar,255),
					new SqlParameter("@sys_userId", SqlDbType.Int,4),
					new SqlParameter("@Flight_departure_time_end", SqlDbType.Time,3),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.Policy_interface_id;
			parameters[1].Value = model.tolerate_stationary_point;
			parameters[2].Value = model.tolerate_leave_money;
			parameters[3].Value = model.is_screening;
			parameters[4].Value = model.lowest_rebate;
			parameters[5].Value = model.highest_rebate;
			parameters[6].Value = model.earliest_advance_days;
			parameters[7].Value = model.night_before_days;
			parameters[8].Value = model.rebate_class_set;
			parameters[9].Value = model.Flight_departure_time_start;
			parameters[10].Value = model.is_automatic_ticket;
			parameters[11].Value = model.is_mail_itinerary;
			parameters[12].Value = model.empower_office_number;
			parameters[13].Value = model.refund_rule;
			parameters[14].Value = model.changedate_rule;
			parameters[15].Value = model.is_allowed_sign;
			parameters[16].Value = model.is_provide_regular_passenger_integral;
			parameters[17].Value = model.document_type;
			parameters[18].Value = model.minimum_age;
			parameters[19].Value = model.maximum_age;
			parameters[20].Value = model.class_description;
			parameters[21].Value = model.special_ticketing_instructions;
			parameters[22].Value = model.sys_userId;
			parameters[23].Value = model.Flight_departure_time_end;
			parameters[24].Value = model.id;

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
			strSql.Append("delete from policy_options ");
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
			strSql.Append("delete from policy_options ");
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
		public Sanben.Model.policy_options GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,Policy_interface_id,tolerate_stationary_point,tolerate_leave_money,is_screening,lowest_rebate,highest_rebate,earliest_advance_days,night_before_days,rebate_class_set,Flight_departure_time_start,is_automatic_ticket,is_mail_itinerary,empower_office_number,refund_rule,changedate_rule,is_allowed_sign,is_provide_regular_passenger_integral,document_type,minimum_age,maximum_age,class_description,special_ticketing_instructions,sys_userId,Flight_departure_time_end from policy_options ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Sanben.Model.policy_options model=new Sanben.Model.policy_options();
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
		public Sanben.Model.policy_options DataRowToModel(DataRow row)
		{
			Sanben.Model.policy_options model=new Sanben.Model.policy_options();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["Policy_interface_id"]!=null && row["Policy_interface_id"].ToString()!="")
				{
					model.Policy_interface_id=int.Parse(row["Policy_interface_id"].ToString());
				}
				if(row["tolerate_stationary_point"]!=null && row["tolerate_stationary_point"].ToString()!="")
				{
					model.tolerate_stationary_point=decimal.Parse(row["tolerate_stationary_point"].ToString());
				}
				if(row["tolerate_leave_money"]!=null && row["tolerate_leave_money"].ToString()!="")
				{
					model.tolerate_leave_money=decimal.Parse(row["tolerate_leave_money"].ToString());
				}
				if(row["is_screening"]!=null && row["is_screening"].ToString()!="")
				{
					if((row["is_screening"].ToString()=="1")||(row["is_screening"].ToString().ToLower()=="true"))
					{
						model.is_screening=true;
					}
					else
					{
						model.is_screening=false;
					}
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
				if(row["refund_rule"]!=null)
				{
					model.refund_rule=row["refund_rule"].ToString();
				}
				if(row["changedate_rule"]!=null)
				{
					model.changedate_rule=row["changedate_rule"].ToString();
				}
				if(row["is_allowed_sign"]!=null && row["is_allowed_sign"].ToString()!="")
				{
					if((row["is_allowed_sign"].ToString()=="1")||(row["is_allowed_sign"].ToString().ToLower()=="true"))
					{
						model.is_allowed_sign=true;
					}
					else
					{
						model.is_allowed_sign=false;
					}
				}
				if(row["is_provide_regular_passenger_integral"]!=null && row["is_provide_regular_passenger_integral"].ToString()!="")
				{
					if((row["is_provide_regular_passenger_integral"].ToString()=="1")||(row["is_provide_regular_passenger_integral"].ToString().ToLower()=="true"))
					{
						model.is_provide_regular_passenger_integral=true;
					}
					else
					{
						model.is_provide_regular_passenger_integral=false;
					}
				}
				if(row["document_type"]!=null && row["document_type"].ToString()!="")
				{
					model.document_type=int.Parse(row["document_type"].ToString());
				}
				if(row["minimum_age"]!=null && row["minimum_age"].ToString()!="")
				{
					model.minimum_age=int.Parse(row["minimum_age"].ToString());
				}
				if(row["maximum_age"]!=null && row["maximum_age"].ToString()!="")
				{
					model.maximum_age=int.Parse(row["maximum_age"].ToString());
				}
				if(row["class_description"]!=null)
				{
					model.class_description=row["class_description"].ToString();
				}
				if(row["special_ticketing_instructions"]!=null)
				{
					model.special_ticketing_instructions=row["special_ticketing_instructions"].ToString();
				}
				if(row["sys_userId"]!=null && row["sys_userId"].ToString()!="")
				{
					model.sys_userId=int.Parse(row["sys_userId"].ToString());
				}
				if(row["Flight_departure_time_end"]!=null && row["Flight_departure_time_end"].ToString()!="")
				{
					model.Flight_departure_time_end=DateTime.Parse(row["Flight_departure_time_end"].ToString());
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
			strSql.Append("select id,Policy_interface_id,tolerate_stationary_point,tolerate_leave_money,is_screening,lowest_rebate,highest_rebate,earliest_advance_days,night_before_days,rebate_class_set,Flight_departure_time_start,is_automatic_ticket,is_mail_itinerary,empower_office_number,refund_rule,changedate_rule,is_allowed_sign,is_provide_regular_passenger_integral,document_type,minimum_age,maximum_age,class_description,special_ticketing_instructions,sys_userId,Flight_departure_time_end ");
			strSql.Append(" FROM policy_options ");
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
			strSql.Append(" id,Policy_interface_id,tolerate_stationary_point,tolerate_leave_money,is_screening,lowest_rebate,highest_rebate,earliest_advance_days,night_before_days,rebate_class_set,Flight_departure_time_start,is_automatic_ticket,is_mail_itinerary,empower_office_number,refund_rule,changedate_rule,is_allowed_sign,is_provide_regular_passenger_integral,document_type,minimum_age,maximum_age,class_description,special_ticketing_instructions,sys_userId,Flight_departure_time_end ");
			strSql.Append(" FROM policy_options ");
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
			strSql.Append("select count(1) FROM policy_options ");
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
			strSql.Append(")AS Row, T.*  from policy_options T ");
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
			parameters[0].Value = "policy_options";
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

