using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:policy_zy_leavepoint
	/// </summary>
	public partial class policy_zy_leavepoint:Ipolicy_zy_leavepoint
	{
		public policy_zy_leavepoint()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "policy_zy_leavepoint"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from policy_zy_leavepoint");
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
		public int Add(Sanben.Model.policy_zy_leavepoint model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into policy_zy_leavepoint(");
			strSql.Append("navigation_company,air_line,application_space,rabate_number,leave_point,leave_money,startdate_ticket,enddate_ticket,traveldate,isleavepointandmoney,isSet,remark,changedate,platform_id,sys_id,rabate_class)");
			strSql.Append(" values (");
			strSql.Append("@navigation_company,@air_line,@application_space,@rabate_number,@leave_point,@leave_money,@startdate_ticket,@enddate_ticket,@traveldate,@isleavepointandmoney,@isSet,@remark,@changedate,@platform_id,@sys_id,@rabate_class)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@navigation_company", SqlDbType.VarChar,50),
					new SqlParameter("@air_line", SqlDbType.VarChar,50),
					new SqlParameter("@application_space", SqlDbType.VarChar,255),
					new SqlParameter("@rabate_number", SqlDbType.VarChar,50),
					new SqlParameter("@leave_point", SqlDbType.Float,8),
					new SqlParameter("@leave_money", SqlDbType.Float,8),
					new SqlParameter("@startdate_ticket", SqlDbType.Int,4),
					new SqlParameter("@enddate_ticket", SqlDbType.Int,4),
					new SqlParameter("@traveldate", SqlDbType.DateTime),
					new SqlParameter("@isleavepointandmoney", SqlDbType.Bit,1),
					new SqlParameter("@isSet", SqlDbType.Bit,1),
					new SqlParameter("@remark", SqlDbType.VarChar,255),
					new SqlParameter("@changedate", SqlDbType.DateTime),
					new SqlParameter("@platform_id", SqlDbType.Int,4),
					new SqlParameter("@sys_id", SqlDbType.Int,4),
					new SqlParameter("@rabate_class", SqlDbType.Int,4)};
			parameters[0].Value = model.navigation_company;
			parameters[1].Value = model.air_line;
			parameters[2].Value = model.application_space;
			parameters[3].Value = model.rabate_number;
			parameters[4].Value = model.leave_point;
			parameters[5].Value = model.leave_money;
			parameters[6].Value = model.startdate_ticket;
			parameters[7].Value = model.enddate_ticket;
			parameters[8].Value = model.traveldate;
			parameters[9].Value = model.isleavepointandmoney;
			parameters[10].Value = model.isSet;
			parameters[11].Value = model.remark;
			parameters[12].Value = model.changedate;
			parameters[13].Value = model.platform_id;
			parameters[14].Value = model.sys_id;
			parameters[15].Value = model.rabate_class;

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
		public bool Update(Sanben.Model.policy_zy_leavepoint model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update policy_zy_leavepoint set ");
			strSql.Append("navigation_company=@navigation_company,");
			strSql.Append("air_line=@air_line,");
			strSql.Append("application_space=@application_space,");
			strSql.Append("rabate_number=@rabate_number,");
			strSql.Append("leave_point=@leave_point,");
			strSql.Append("leave_money=@leave_money,");
			strSql.Append("startdate_ticket=@startdate_ticket,");
			strSql.Append("enddate_ticket=@enddate_ticket,");
			strSql.Append("traveldate=@traveldate,");
			strSql.Append("isleavepointandmoney=@isleavepointandmoney,");
			strSql.Append("isSet=@isSet,");
			strSql.Append("remark=@remark,");
			strSql.Append("changedate=@changedate,");
			strSql.Append("platform_id=@platform_id,");
			strSql.Append("sys_id=@sys_id,");
			strSql.Append("rabate_class=@rabate_class");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@navigation_company", SqlDbType.VarChar,50),
					new SqlParameter("@air_line", SqlDbType.VarChar,50),
					new SqlParameter("@application_space", SqlDbType.VarChar,255),
					new SqlParameter("@rabate_number", SqlDbType.VarChar,50),
					new SqlParameter("@leave_point", SqlDbType.Float,8),
					new SqlParameter("@leave_money", SqlDbType.Float,8),
					new SqlParameter("@startdate_ticket", SqlDbType.Int,4),
					new SqlParameter("@enddate_ticket", SqlDbType.Int,4),
					new SqlParameter("@traveldate", SqlDbType.DateTime),
					new SqlParameter("@isleavepointandmoney", SqlDbType.Bit,1),
					new SqlParameter("@isSet", SqlDbType.Bit,1),
					new SqlParameter("@remark", SqlDbType.VarChar,255),
					new SqlParameter("@changedate", SqlDbType.DateTime),
					new SqlParameter("@platform_id", SqlDbType.Int,4),
					new SqlParameter("@sys_id", SqlDbType.Int,4),
					new SqlParameter("@rabate_class", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.navigation_company;
			parameters[1].Value = model.air_line;
			parameters[2].Value = model.application_space;
			parameters[3].Value = model.rabate_number;
			parameters[4].Value = model.leave_point;
			parameters[5].Value = model.leave_money;
			parameters[6].Value = model.startdate_ticket;
			parameters[7].Value = model.enddate_ticket;
			parameters[8].Value = model.traveldate;
			parameters[9].Value = model.isleavepointandmoney;
			parameters[10].Value = model.isSet;
			parameters[11].Value = model.remark;
			parameters[12].Value = model.changedate;
			parameters[13].Value = model.platform_id;
			parameters[14].Value = model.sys_id;
			parameters[15].Value = model.rabate_class;
			parameters[16].Value = model.id;

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
			strSql.Append("delete from policy_zy_leavepoint ");
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
			strSql.Append("delete from policy_zy_leavepoint ");
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
		public Sanben.Model.policy_zy_leavepoint GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,navigation_company,air_line,application_space,rabate_number,leave_point,leave_money,startdate_ticket,enddate_ticket,traveldate,isleavepointandmoney,isSet,remark,changedate,platform_id,sys_id,rabate_class from policy_zy_leavepoint ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Sanben.Model.policy_zy_leavepoint model=new Sanben.Model.policy_zy_leavepoint();
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
		public Sanben.Model.policy_zy_leavepoint DataRowToModel(DataRow row)
		{
			Sanben.Model.policy_zy_leavepoint model=new Sanben.Model.policy_zy_leavepoint();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["navigation_company"]!=null)
				{
					model.navigation_company=row["navigation_company"].ToString();
				}
				if(row["air_line"]!=null)
				{
					model.air_line=row["air_line"].ToString();
				}
				if(row["application_space"]!=null)
				{
					model.application_space=row["application_space"].ToString();
				}
				if(row["rabate_number"]!=null)
				{
					model.rabate_number=row["rabate_number"].ToString();
				}
				if(row["leave_point"]!=null && row["leave_point"].ToString()!="")
				{
					model.leave_point=decimal.Parse(row["leave_point"].ToString());
				}
				if(row["leave_money"]!=null && row["leave_money"].ToString()!="")
				{
					model.leave_money=decimal.Parse(row["leave_money"].ToString());
				}
				if(row["startdate_ticket"]!=null && row["startdate_ticket"].ToString()!="")
				{
					model.startdate_ticket=int.Parse(row["startdate_ticket"].ToString());
				}
				if(row["enddate_ticket"]!=null && row["enddate_ticket"].ToString()!="")
				{
					model.enddate_ticket=int.Parse(row["enddate_ticket"].ToString());
				}
				if(row["traveldate"]!=null && row["traveldate"].ToString()!="")
				{
					model.traveldate=DateTime.Parse(row["traveldate"].ToString());
				}
				if(row["isleavepointandmoney"]!=null && row["isleavepointandmoney"].ToString()!="")
				{
					if((row["isleavepointandmoney"].ToString()=="1")||(row["isleavepointandmoney"].ToString().ToLower()=="true"))
					{
						model.isleavepointandmoney=true;
					}
					else
					{
						model.isleavepointandmoney=false;
					}
				}
				if(row["isSet"]!=null && row["isSet"].ToString()!="")
				{
					if((row["isSet"].ToString()=="1")||(row["isSet"].ToString().ToLower()=="true"))
					{
						model.isSet=true;
					}
					else
					{
						model.isSet=false;
					}
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["changedate"]!=null && row["changedate"].ToString()!="")
				{
					model.changedate=DateTime.Parse(row["changedate"].ToString());
				}
				if(row["platform_id"]!=null && row["platform_id"].ToString()!="")
				{
					model.platform_id=int.Parse(row["platform_id"].ToString());
				}
				if(row["sys_id"]!=null && row["sys_id"].ToString()!="")
				{
					model.sys_id=int.Parse(row["sys_id"].ToString());
				}
				if(row["rabate_class"]!=null && row["rabate_class"].ToString()!="")
				{
					model.rabate_class=int.Parse(row["rabate_class"].ToString());
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
			strSql.Append("select id,navigation_company,air_line,application_space,rabate_number,leave_point,leave_money,startdate_ticket,enddate_ticket,traveldate,isleavepointandmoney,isSet,remark,changedate,platform_id,sys_id,rabate_class ");
			strSql.Append(" FROM policy_zy_leavepoint ");
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
			strSql.Append(" id,navigation_company,air_line,application_space,rabate_number,leave_point,leave_money,startdate_ticket,enddate_ticket,traveldate,isleavepointandmoney,isSet,remark,changedate,platform_id,sys_id,rabate_class ");
			strSql.Append(" FROM policy_zy_leavepoint ");
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
			strSql.Append("select count(1) FROM policy_zy_leavepoint ");
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
			strSql.Append(")AS Row, T.*  from policy_zy_leavepoint T ");
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
			parameters[0].Value = "policy_zy_leavepoint";
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

