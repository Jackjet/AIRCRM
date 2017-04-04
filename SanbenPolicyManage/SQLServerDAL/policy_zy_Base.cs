using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:policy_zy_Base
	/// </summary>
	public partial class policy_zy_Base:Ipolicy_zy_Base
	{
		public policy_zy_Base()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "policy_zy_Base"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from policy_zy_Base");
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
		public int Add(Sanben.Model.policy_zy_Base model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into policy_zy_Base(");
			strSql.Append("leavepoint,leavemoney,is_filter,starttime,endtime,lowest_rebate,highest_rebate,earliest_advance_days,night_before_days,pointSetType,isuploadfirstclass,isuploadchildclass,NFDpolicy,flylimittime,platfromPolicy,GWpolicy,uploadway,isuploadsharefight,addpricejisuan,addpriceCovertType,addPriceSet,limitSit,saleSit,is_autoticket,is_Need,isMail,isPay,AuthorizeOffice,refund_rule,changedate_rule,is_allowed_sign,is_provide_regular_passenger_integral,document_type,maxage,minage,class_description,special_ticketing_instructions,lowest_price,highest_price,lastupdatetime,sysuser_id,platform_id)");
			strSql.Append(" values (");
			strSql.Append("@leavepoint,@leavemoney,@is_filter,@starttime,@endtime,@lowest_rebate,@highest_rebate,@earliest_advance_days,@night_before_days,@pointSetType,@isuploadfirstclass,@isuploadchildclass,@NFDpolicy,@flylimittime,@platfromPolicy,@GWpolicy,@uploadway,@isuploadsharefight,@addpricejisuan,@addpriceCovertType,@addPriceSet,@limitSit,@saleSit,@is_autoticket,@is_Need,@isMail,@isPay,@AuthorizeOffice,@refund_rule,@changedate_rule,@is_allowed_sign,@is_provide_regular_passenger_integral,@document_type,@maxage,@minage,@class_description,@special_ticketing_instructions,@lowest_price,@highest_price,@lastupdatetime,@sysuser_id,@platform_id)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@leavepoint", SqlDbType.Float,8),
					new SqlParameter("@leavemoney", SqlDbType.Float,8),
					new SqlParameter("@is_filter", SqlDbType.Bit,1),
					new SqlParameter("@starttime", SqlDbType.DateTime),
					new SqlParameter("@endtime", SqlDbType.DateTime),
					new SqlParameter("@lowest_rebate", SqlDbType.Float,8),
					new SqlParameter("@highest_rebate", SqlDbType.Float,8),
					new SqlParameter("@earliest_advance_days", SqlDbType.Int,4),
					new SqlParameter("@night_before_days", SqlDbType.Int,4),
					new SqlParameter("@pointSetType", SqlDbType.Int,4),
					new SqlParameter("@isuploadfirstclass", SqlDbType.Bit,1),
					new SqlParameter("@isuploadchildclass", SqlDbType.Bit,1),
					new SqlParameter("@NFDpolicy", SqlDbType.Bit,1),
					new SqlParameter("@flylimittime", SqlDbType.NVarChar,50),
					new SqlParameter("@platfromPolicy", SqlDbType.NVarChar,50),
					new SqlParameter("@GWpolicy", SqlDbType.NVarChar,50),
					new SqlParameter("@uploadway", SqlDbType.Bit,1),
					new SqlParameter("@isuploadsharefight", SqlDbType.Bit,1),
					new SqlParameter("@addpricejisuan", SqlDbType.Bit,1),
					new SqlParameter("@addpriceCovertType", SqlDbType.Int,4),
					new SqlParameter("@addPriceSet", SqlDbType.Int,4),
					new SqlParameter("@limitSit", SqlDbType.Int,4),
					new SqlParameter("@saleSit", SqlDbType.Int,4),
					new SqlParameter("@is_autoticket", SqlDbType.Bit,1),
					new SqlParameter("@is_Need", SqlDbType.Bit,1),
					new SqlParameter("@isMail", SqlDbType.Int,4),
					new SqlParameter("@isPay", SqlDbType.Bit,1),
					new SqlParameter("@AuthorizeOffice", SqlDbType.NVarChar,50),
					new SqlParameter("@refund_rule", SqlDbType.NVarChar,50),
					new SqlParameter("@changedate_rule", SqlDbType.NVarChar,50),
					new SqlParameter("@is_allowed_sign", SqlDbType.Bit,1),
					new SqlParameter("@is_provide_regular_passenger_integral", SqlDbType.Bit,1),
					new SqlParameter("@document_type", SqlDbType.Int,4),
					new SqlParameter("@maxage", SqlDbType.Int,4),
					new SqlParameter("@minage", SqlDbType.Int,4),
					new SqlParameter("@class_description", SqlDbType.NVarChar,255),
					new SqlParameter("@special_ticketing_instructions", SqlDbType.NVarChar,50),
					new SqlParameter("@lowest_price", SqlDbType.Float,8),
					new SqlParameter("@highest_price", SqlDbType.Float,8),
					new SqlParameter("@lastupdatetime", SqlDbType.DateTime),
					new SqlParameter("@sysuser_id", SqlDbType.Int,4),
					new SqlParameter("@platform_id", SqlDbType.Int,4)};
			parameters[0].Value = model.leavepoint;
			parameters[1].Value = model.leavemoney;
			parameters[2].Value = model.is_filter;
			parameters[3].Value = model.starttime;
			parameters[4].Value = model.endtime;
			parameters[5].Value = model.lowest_rebate;
			parameters[6].Value = model.highest_rebate;
			parameters[7].Value = model.earliest_advance_days;
			parameters[8].Value = model.night_before_days;
			parameters[9].Value = model.pointSetType;
			parameters[10].Value = model.isuploadfirstclass;
			parameters[11].Value = model.isuploadchildclass;
			parameters[12].Value = model.NFDpolicy;
			parameters[13].Value = model.flylimittime;
			parameters[14].Value = model.platfromPolicy;
			parameters[15].Value = model.GWpolicy;
			parameters[16].Value = model.uploadway;
			parameters[17].Value = model.isuploadsharefight;
			parameters[18].Value = model.addpricejisuan;
			parameters[19].Value = model.addpriceCovertType;
			parameters[20].Value = model.addPriceSet;
			parameters[21].Value = model.limitSit;
			parameters[22].Value = model.saleSit;
			parameters[23].Value = model.is_autoticket;
			parameters[24].Value = model.is_Need;
			parameters[25].Value = model.isMail;
			parameters[26].Value = model.isPay;
			parameters[27].Value = model.AuthorizeOffice;
			parameters[28].Value = model.refund_rule;
			parameters[29].Value = model.changedate_rule;
			parameters[30].Value = model.is_allowed_sign;
			parameters[31].Value = model.is_provide_regular_passenger_integral;
			parameters[32].Value = model.document_type;
			parameters[33].Value = model.maxage;
			parameters[34].Value = model.minage;
			parameters[35].Value = model.class_description;
			parameters[36].Value = model.special_ticketing_instructions;
			parameters[37].Value = model.lowest_price;
			parameters[38].Value = model.highest_price;
			parameters[39].Value = model.lastupdatetime;
			parameters[40].Value = model.sysuser_id;
			parameters[41].Value = model.platform_id;

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
		public bool Update(Sanben.Model.policy_zy_Base model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update policy_zy_Base set ");
			strSql.Append("leavepoint=@leavepoint,");
			strSql.Append("leavemoney=@leavemoney,");
			strSql.Append("is_filter=@is_filter,");
			strSql.Append("starttime=@starttime,");
			strSql.Append("endtime=@endtime,");
			strSql.Append("lowest_rebate=@lowest_rebate,");
			strSql.Append("highest_rebate=@highest_rebate,");
			strSql.Append("earliest_advance_days=@earliest_advance_days,");
			strSql.Append("night_before_days=@night_before_days,");
			strSql.Append("pointSetType=@pointSetType,");
			strSql.Append("isuploadfirstclass=@isuploadfirstclass,");
			strSql.Append("isuploadchildclass=@isuploadchildclass,");
			strSql.Append("NFDpolicy=@NFDpolicy,");
			strSql.Append("flylimittime=@flylimittime,");
			strSql.Append("platfromPolicy=@platfromPolicy,");
			strSql.Append("GWpolicy=@GWpolicy,");
			strSql.Append("uploadway=@uploadway,");
			strSql.Append("isuploadsharefight=@isuploadsharefight,");
			strSql.Append("addpricejisuan=@addpricejisuan,");
			strSql.Append("addpriceCovertType=@addpriceCovertType,");
			strSql.Append("addPriceSet=@addPriceSet,");
			strSql.Append("limitSit=@limitSit,");
			strSql.Append("saleSit=@saleSit,");
			strSql.Append("is_autoticket=@is_autoticket,");
			strSql.Append("is_Need=@is_Need,");
			strSql.Append("isMail=@isMail,");
			strSql.Append("isPay=@isPay,");
			strSql.Append("AuthorizeOffice=@AuthorizeOffice,");
			strSql.Append("refund_rule=@refund_rule,");
			strSql.Append("changedate_rule=@changedate_rule,");
			strSql.Append("is_allowed_sign=@is_allowed_sign,");
			strSql.Append("is_provide_regular_passenger_integral=@is_provide_regular_passenger_integral,");
			strSql.Append("document_type=@document_type,");
			strSql.Append("maxage=@maxage,");
			strSql.Append("minage=@minage,");
			strSql.Append("class_description=@class_description,");
			strSql.Append("special_ticketing_instructions=@special_ticketing_instructions,");
			strSql.Append("lowest_price=@lowest_price,");
			strSql.Append("highest_price=@highest_price,");
			strSql.Append("lastupdatetime=@lastupdatetime,");
			strSql.Append("sysuser_id=@sysuser_id,");
			strSql.Append("platform_id=@platform_id");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@leavepoint", SqlDbType.Float,8),
					new SqlParameter("@leavemoney", SqlDbType.Float,8),
					new SqlParameter("@is_filter", SqlDbType.Bit,1),
					new SqlParameter("@starttime", SqlDbType.DateTime),
					new SqlParameter("@endtime", SqlDbType.DateTime),
					new SqlParameter("@lowest_rebate", SqlDbType.Float,8),
					new SqlParameter("@highest_rebate", SqlDbType.Float,8),
					new SqlParameter("@earliest_advance_days", SqlDbType.Int,4),
					new SqlParameter("@night_before_days", SqlDbType.Int,4),
					new SqlParameter("@pointSetType", SqlDbType.Int,4),
					new SqlParameter("@isuploadfirstclass", SqlDbType.Bit,1),
					new SqlParameter("@isuploadchildclass", SqlDbType.Bit,1),
					new SqlParameter("@NFDpolicy", SqlDbType.Bit,1),
					new SqlParameter("@flylimittime", SqlDbType.NVarChar,50),
					new SqlParameter("@platfromPolicy", SqlDbType.NVarChar,50),
					new SqlParameter("@GWpolicy", SqlDbType.NVarChar,50),
					new SqlParameter("@uploadway", SqlDbType.Bit,1),
					new SqlParameter("@isuploadsharefight", SqlDbType.Bit,1),
					new SqlParameter("@addpricejisuan", SqlDbType.Bit,1),
					new SqlParameter("@addpriceCovertType", SqlDbType.Int,4),
					new SqlParameter("@addPriceSet", SqlDbType.Int,4),
					new SqlParameter("@limitSit", SqlDbType.Int,4),
					new SqlParameter("@saleSit", SqlDbType.Int,4),
					new SqlParameter("@is_autoticket", SqlDbType.Bit,1),
					new SqlParameter("@is_Need", SqlDbType.Bit,1),
					new SqlParameter("@isMail", SqlDbType.Int,4),
					new SqlParameter("@isPay", SqlDbType.Bit,1),
					new SqlParameter("@AuthorizeOffice", SqlDbType.NVarChar,50),
					new SqlParameter("@refund_rule", SqlDbType.NVarChar,50),
					new SqlParameter("@changedate_rule", SqlDbType.NVarChar,50),
					new SqlParameter("@is_allowed_sign", SqlDbType.Bit,1),
					new SqlParameter("@is_provide_regular_passenger_integral", SqlDbType.Bit,1),
					new SqlParameter("@document_type", SqlDbType.Int,4),
					new SqlParameter("@maxage", SqlDbType.Int,4),
					new SqlParameter("@minage", SqlDbType.Int,4),
					new SqlParameter("@class_description", SqlDbType.NVarChar,255),
					new SqlParameter("@special_ticketing_instructions", SqlDbType.NVarChar,50),
					new SqlParameter("@lowest_price", SqlDbType.Float,8),
					new SqlParameter("@highest_price", SqlDbType.Float,8),
					new SqlParameter("@lastupdatetime", SqlDbType.DateTime),
					new SqlParameter("@sysuser_id", SqlDbType.Int,4),
					new SqlParameter("@platform_id", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.leavepoint;
			parameters[1].Value = model.leavemoney;
			parameters[2].Value = model.is_filter;
			parameters[3].Value = model.starttime;
			parameters[4].Value = model.endtime;
			parameters[5].Value = model.lowest_rebate;
			parameters[6].Value = model.highest_rebate;
			parameters[7].Value = model.earliest_advance_days;
			parameters[8].Value = model.night_before_days;
			parameters[9].Value = model.pointSetType;
			parameters[10].Value = model.isuploadfirstclass;
			parameters[11].Value = model.isuploadchildclass;
			parameters[12].Value = model.NFDpolicy;
			parameters[13].Value = model.flylimittime;
			parameters[14].Value = model.platfromPolicy;
			parameters[15].Value = model.GWpolicy;
			parameters[16].Value = model.uploadway;
			parameters[17].Value = model.isuploadsharefight;
			parameters[18].Value = model.addpricejisuan;
			parameters[19].Value = model.addpriceCovertType;
			parameters[20].Value = model.addPriceSet;
			parameters[21].Value = model.limitSit;
			parameters[22].Value = model.saleSit;
			parameters[23].Value = model.is_autoticket;
			parameters[24].Value = model.is_Need;
			parameters[25].Value = model.isMail;
			parameters[26].Value = model.isPay;
			parameters[27].Value = model.AuthorizeOffice;
			parameters[28].Value = model.refund_rule;
			parameters[29].Value = model.changedate_rule;
			parameters[30].Value = model.is_allowed_sign;
			parameters[31].Value = model.is_provide_regular_passenger_integral;
			parameters[32].Value = model.document_type;
			parameters[33].Value = model.maxage;
			parameters[34].Value = model.minage;
			parameters[35].Value = model.class_description;
			parameters[36].Value = model.special_ticketing_instructions;
			parameters[37].Value = model.lowest_price;
			parameters[38].Value = model.highest_price;
			parameters[39].Value = model.lastupdatetime;
			parameters[40].Value = model.sysuser_id;
			parameters[41].Value = model.platform_id;
			parameters[42].Value = model.id;

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
			strSql.Append("delete from policy_zy_Base ");
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
			strSql.Append("delete from policy_zy_Base ");
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
		public Sanben.Model.policy_zy_Base GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,leavepoint,leavemoney,is_filter,starttime,endtime,lowest_rebate,highest_rebate,earliest_advance_days,night_before_days,pointSetType,isuploadfirstclass,isuploadchildclass,NFDpolicy,flylimittime,platfromPolicy,GWpolicy,uploadway,isuploadsharefight,addpricejisuan,addpriceCovertType,addPriceSet,limitSit,saleSit,is_autoticket,is_Need,isMail,isPay,AuthorizeOffice,refund_rule,changedate_rule,is_allowed_sign,is_provide_regular_passenger_integral,document_type,maxage,minage,class_description,special_ticketing_instructions,lowest_price,highest_price,lastupdatetime,sysuser_id,platform_id from policy_zy_Base ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Sanben.Model.policy_zy_Base model=new Sanben.Model.policy_zy_Base();
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
		public Sanben.Model.policy_zy_Base DataRowToModel(DataRow row)
		{
			Sanben.Model.policy_zy_Base model=new Sanben.Model.policy_zy_Base();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["leavepoint"]!=null && row["leavepoint"].ToString()!="")
				{
					model.leavepoint=decimal.Parse(row["leavepoint"].ToString());
				}
				if(row["leavemoney"]!=null && row["leavemoney"].ToString()!="")
				{
					model.leavemoney=decimal.Parse(row["leavemoney"].ToString());
				}
				if(row["is_filter"]!=null && row["is_filter"].ToString()!="")
				{
					if((row["is_filter"].ToString()=="1")||(row["is_filter"].ToString().ToLower()=="true"))
					{
						model.is_filter=true;
					}
					else
					{
						model.is_filter=false;
					}
				}
				if(row["starttime"]!=null && row["starttime"].ToString()!="")
				{
					model.starttime=DateTime.Parse(row["starttime"].ToString());
				}
				if(row["endtime"]!=null && row["endtime"].ToString()!="")
				{
					model.endtime=DateTime.Parse(row["endtime"].ToString());
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
				if(row["pointSetType"]!=null && row["pointSetType"].ToString()!="")
				{
					model.pointSetType=int.Parse(row["pointSetType"].ToString());
				}
				if(row["isuploadfirstclass"]!=null && row["isuploadfirstclass"].ToString()!="")
				{
					if((row["isuploadfirstclass"].ToString()=="1")||(row["isuploadfirstclass"].ToString().ToLower()=="true"))
					{
						model.isuploadfirstclass=true;
					}
					else
					{
						model.isuploadfirstclass=false;
					}
				}
				if(row["isuploadchildclass"]!=null && row["isuploadchildclass"].ToString()!="")
				{
					if((row["isuploadchildclass"].ToString()=="1")||(row["isuploadchildclass"].ToString().ToLower()=="true"))
					{
						model.isuploadchildclass=true;
					}
					else
					{
						model.isuploadchildclass=false;
					}
				}
				if(row["NFDpolicy"]!=null && row["NFDpolicy"].ToString()!="")
				{
					if((row["NFDpolicy"].ToString()=="1")||(row["NFDpolicy"].ToString().ToLower()=="true"))
					{
						model.NFDpolicy=true;
					}
					else
					{
						model.NFDpolicy=false;
					}
				}
				if(row["flylimittime"]!=null)
				{
					model.flylimittime=row["flylimittime"].ToString();
				}
				if(row["platfromPolicy"]!=null)
				{
					model.platfromPolicy=row["platfromPolicy"].ToString();
				}
				if(row["GWpolicy"]!=null)
				{
					model.GWpolicy=row["GWpolicy"].ToString();
				}
				if(row["uploadway"]!=null && row["uploadway"].ToString()!="")
				{
					if((row["uploadway"].ToString()=="1")||(row["uploadway"].ToString().ToLower()=="true"))
					{
						model.uploadway=true;
					}
					else
					{
						model.uploadway=false;
					}
				}
				if(row["isuploadsharefight"]!=null && row["isuploadsharefight"].ToString()!="")
				{
					if((row["isuploadsharefight"].ToString()=="1")||(row["isuploadsharefight"].ToString().ToLower()=="true"))
					{
						model.isuploadsharefight=true;
					}
					else
					{
						model.isuploadsharefight=false;
					}
				}
				if(row["addpricejisuan"]!=null && row["addpricejisuan"].ToString()!="")
				{
					if((row["addpricejisuan"].ToString()=="1")||(row["addpricejisuan"].ToString().ToLower()=="true"))
					{
						model.addpricejisuan=true;
					}
					else
					{
						model.addpricejisuan=false;
					}
				}
				if(row["addpriceCovertType"]!=null && row["addpriceCovertType"].ToString()!="")
				{
					model.addpriceCovertType=int.Parse(row["addpriceCovertType"].ToString());
				}
				if(row["addPriceSet"]!=null && row["addPriceSet"].ToString()!="")
				{
					model.addPriceSet=int.Parse(row["addPriceSet"].ToString());
				}
				if(row["limitSit"]!=null && row["limitSit"].ToString()!="")
				{
					model.limitSit=int.Parse(row["limitSit"].ToString());
				}
				if(row["saleSit"]!=null && row["saleSit"].ToString()!="")
				{
					model.saleSit=int.Parse(row["saleSit"].ToString());
				}
				if(row["is_autoticket"]!=null && row["is_autoticket"].ToString()!="")
				{
					if((row["is_autoticket"].ToString()=="1")||(row["is_autoticket"].ToString().ToLower()=="true"))
					{
						model.is_autoticket=true;
					}
					else
					{
						model.is_autoticket=false;
					}
				}
				if(row["is_Need"]!=null && row["is_Need"].ToString()!="")
				{
					if((row["is_Need"].ToString()=="1")||(row["is_Need"].ToString().ToLower()=="true"))
					{
						model.is_Need=true;
					}
					else
					{
						model.is_Need=false;
					}
				}
				if(row["isMail"]!=null && row["isMail"].ToString()!="")
				{
					model.isMail=int.Parse(row["isMail"].ToString());
				}
				if(row["isPay"]!=null && row["isPay"].ToString()!="")
				{
					if((row["isPay"].ToString()=="1")||(row["isPay"].ToString().ToLower()=="true"))
					{
						model.isPay=true;
					}
					else
					{
						model.isPay=false;
					}
				}
				if(row["AuthorizeOffice"]!=null)
				{
					model.AuthorizeOffice=row["AuthorizeOffice"].ToString();
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
				if(row["maxage"]!=null && row["maxage"].ToString()!="")
				{
					model.maxage=int.Parse(row["maxage"].ToString());
				}
				if(row["minage"]!=null && row["minage"].ToString()!="")
				{
					model.minage=int.Parse(row["minage"].ToString());
				}
				if(row["class_description"]!=null)
				{
					model.class_description=row["class_description"].ToString();
				}
				if(row["special_ticketing_instructions"]!=null)
				{
					model.special_ticketing_instructions=row["special_ticketing_instructions"].ToString();
				}
				if(row["lowest_price"]!=null && row["lowest_price"].ToString()!="")
				{
					model.lowest_price=decimal.Parse(row["lowest_price"].ToString());
				}
				if(row["highest_price"]!=null && row["highest_price"].ToString()!="")
				{
					model.highest_price=decimal.Parse(row["highest_price"].ToString());
				}
				if(row["lastupdatetime"]!=null && row["lastupdatetime"].ToString()!="")
				{
					model.lastupdatetime=DateTime.Parse(row["lastupdatetime"].ToString());
				}
				if(row["sysuser_id"]!=null && row["sysuser_id"].ToString()!="")
				{
					model.sysuser_id=int.Parse(row["sysuser_id"].ToString());
				}
				if(row["platform_id"]!=null && row["platform_id"].ToString()!="")
				{
					model.platform_id=int.Parse(row["platform_id"].ToString());
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
			strSql.Append("select id,leavepoint,leavemoney,is_filter,starttime,endtime,lowest_rebate,highest_rebate,earliest_advance_days,night_before_days,pointSetType,isuploadfirstclass,isuploadchildclass,NFDpolicy,flylimittime,platfromPolicy,GWpolicy,uploadway,isuploadsharefight,addpricejisuan,addpriceCovertType,addPriceSet,limitSit,saleSit,is_autoticket,is_Need,isMail,isPay,AuthorizeOffice,refund_rule,changedate_rule,is_allowed_sign,is_provide_regular_passenger_integral,document_type,maxage,minage,class_description,special_ticketing_instructions,lowest_price,highest_price,lastupdatetime,sysuser_id,platform_id ");
			strSql.Append(" FROM policy_zy_Base ");
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
			strSql.Append(" id,leavepoint,leavemoney,is_filter,starttime,endtime,lowest_rebate,highest_rebate,earliest_advance_days,night_before_days,pointSetType,isuploadfirstclass,isuploadchildclass,NFDpolicy,flylimittime,platfromPolicy,GWpolicy,uploadway,isuploadsharefight,addpricejisuan,addpriceCovertType,addPriceSet,limitSit,saleSit,is_autoticket,is_Need,isMail,isPay,AuthorizeOffice,refund_rule,changedate_rule,is_allowed_sign,is_provide_regular_passenger_integral,document_type,maxage,minage,class_description,special_ticketing_instructions,lowest_price,highest_price,lastupdatetime,sysuser_id,platform_id ");
			strSql.Append(" FROM policy_zy_Base ");
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
			strSql.Append("select count(1) FROM policy_zy_Base ");
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
			strSql.Append(")AS Row, T.*  from policy_zy_Base T ");
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
			parameters[0].Value = "policy_zy_Base";
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

