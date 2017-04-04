using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:excGetRateList
	/// </summary>
	public partial class excGetRateList:IexcGetRateList
	{
		public excGetRateList()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "excGetRateList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from excGetRateList");
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
		public int Add(Sanben.Model.excGetRateList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into excGetRateList(");
			strSql.Append("PolicyId,RateId,ScityE,EcityE,AirComE,NoAirComE,PolicyType,Cabin,VoyageType,UserType,RateType,Discounts,Sdate,Edate,WorkTimBegin,WorkTImeEnd,Rewards,Remark,ET,WP,SP,XF,PromotionDiscount,NewRateNo,OfficeNum,RefundTimeBegin,RefundTimeEnd,LastModifyTime,LimitModels,RefundRulesWay,TPRemark,ChangeMsg,InvalidMsg,RiseCabin,ForeignMsg,OutTicketPercent,InvoiceMsg,PrintInvoice,SwitchPNR,Change,sed,PlatForm,AddTime)");
			strSql.Append(" values (");
			strSql.Append("@PolicyId,@RateId,@ScityE,@EcityE,@AirComE,@NoAirComE,@PolicyType,@Cabin,@VoyageType,@UserType,@RateType,@Discounts,@Sdate,@Edate,@WorkTimBegin,@WorkTImeEnd,@Rewards,@Remark,@ET,@WP,@SP,@XF,@PromotionDiscount,@NewRateNo,@OfficeNum,@RefundTimeBegin,@RefundTimeEnd,@LastModifyTime,@LimitModels,@RefundRulesWay,@TPRemark,@ChangeMsg,@InvalidMsg,@RiseCabin,@ForeignMsg,@OutTicketPercent,@InvoiceMsg,@PrintInvoice,@SwitchPNR,@Change,@sed,@PlatForm,@AddTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@PolicyId", SqlDbType.NVarChar,255),
					new SqlParameter("@RateId", SqlDbType.NVarChar,255),
					new SqlParameter("@ScityE", SqlDbType.NVarChar,255),
					new SqlParameter("@EcityE", SqlDbType.NVarChar,255),
					new SqlParameter("@AirComE", SqlDbType.NVarChar,255),
					new SqlParameter("@NoAirComE", SqlDbType.NVarChar,255),
					new SqlParameter("@PolicyType", SqlDbType.NVarChar,255),
					new SqlParameter("@Cabin", SqlDbType.NVarChar,255),
					new SqlParameter("@VoyageType", SqlDbType.NVarChar,255),
					new SqlParameter("@UserType", SqlDbType.NVarChar,255),
					new SqlParameter("@RateType", SqlDbType.NVarChar,255),
					new SqlParameter("@Discounts", SqlDbType.Float,8),
					new SqlParameter("@Sdate", SqlDbType.NVarChar,255),
					new SqlParameter("@Edate", SqlDbType.NVarChar,255),
					new SqlParameter("@WorkTimBegin", SqlDbType.NVarChar,255),
					new SqlParameter("@WorkTImeEnd", SqlDbType.NVarChar,255),
					new SqlParameter("@Rewards", SqlDbType.NVarChar,255),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@ET", SqlDbType.NVarChar,255),
					new SqlParameter("@WP", SqlDbType.NVarChar,255),
					new SqlParameter("@SP", SqlDbType.NVarChar,255),
					new SqlParameter("@XF", SqlDbType.NVarChar,255),
					new SqlParameter("@PromotionDiscount", SqlDbType.NVarChar,255),
					new SqlParameter("@NewRateNo", SqlDbType.NVarChar,255),
					new SqlParameter("@OfficeNum", SqlDbType.NVarChar,255),
					new SqlParameter("@RefundTimeBegin", SqlDbType.NVarChar,255),
					new SqlParameter("@RefundTimeEnd", SqlDbType.NVarChar,255),
					new SqlParameter("@LastModifyTime", SqlDbType.NVarChar,255),
					new SqlParameter("@LimitModels", SqlDbType.NVarChar,255),
					new SqlParameter("@RefundRulesWay", SqlDbType.NVarChar,255),
					new SqlParameter("@TPRemark", SqlDbType.NVarChar,255),
					new SqlParameter("@ChangeMsg", SqlDbType.NVarChar,255),
					new SqlParameter("@InvalidMsg", SqlDbType.NVarChar,255),
					new SqlParameter("@RiseCabin", SqlDbType.NVarChar,255),
					new SqlParameter("@ForeignMsg", SqlDbType.NVarChar,255),
					new SqlParameter("@OutTicketPercent", SqlDbType.NVarChar,255),
					new SqlParameter("@InvoiceMsg", SqlDbType.NVarChar,255),
					new SqlParameter("@PrintInvoice", SqlDbType.NVarChar,255),
					new SqlParameter("@SwitchPNR", SqlDbType.NVarChar,255),
					new SqlParameter("@Change", SqlDbType.NVarChar,255),
					new SqlParameter("@sed", SqlDbType.NVarChar,255),
					new SqlParameter("@PlatForm", SqlDbType.NVarChar,255),
					new SqlParameter("@AddTime", SqlDbType.DateTime)};
			parameters[0].Value = model.PolicyId;
			parameters[1].Value = model.RateId;
			parameters[2].Value = model.ScityE;
			parameters[3].Value = model.EcityE;
			parameters[4].Value = model.AirComE;
			parameters[5].Value = model.NoAirComE;
			parameters[6].Value = model.PolicyType;
			parameters[7].Value = model.Cabin;
			parameters[8].Value = model.VoyageType;
			parameters[9].Value = model.UserType;
			parameters[10].Value = model.RateType;
			parameters[11].Value = model.Discounts;
			parameters[12].Value = model.Sdate;
			parameters[13].Value = model.Edate;
			parameters[14].Value = model.WorkTimBegin;
			parameters[15].Value = model.WorkTImeEnd;
			parameters[16].Value = model.Rewards;
			parameters[17].Value = model.Remark;
			parameters[18].Value = model.ET;
			parameters[19].Value = model.WP;
			parameters[20].Value = model.SP;
			parameters[21].Value = model.XF;
			parameters[22].Value = model.PromotionDiscount;
			parameters[23].Value = model.NewRateNo;
			parameters[24].Value = model.OfficeNum;
			parameters[25].Value = model.RefundTimeBegin;
			parameters[26].Value = model.RefundTimeEnd;
			parameters[27].Value = model.LastModifyTime;
			parameters[28].Value = model.LimitModels;
			parameters[29].Value = model.RefundRulesWay;
			parameters[30].Value = model.TPRemark;
			parameters[31].Value = model.ChangeMsg;
			parameters[32].Value = model.InvalidMsg;
			parameters[33].Value = model.RiseCabin;
			parameters[34].Value = model.ForeignMsg;
			parameters[35].Value = model.OutTicketPercent;
			parameters[36].Value = model.InvoiceMsg;
			parameters[37].Value = model.PrintInvoice;
			parameters[38].Value = model.SwitchPNR;
			parameters[39].Value = model.Change;
			parameters[40].Value = model.sed;
			parameters[41].Value = model.PlatForm;
			parameters[42].Value = model.AddTime;

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
		public bool Update(Sanben.Model.excGetRateList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update excGetRateList set ");
			strSql.Append("PolicyId=@PolicyId,");
			strSql.Append("RateId=@RateId,");
			strSql.Append("ScityE=@ScityE,");
			strSql.Append("EcityE=@EcityE,");
			strSql.Append("AirComE=@AirComE,");
			strSql.Append("NoAirComE=@NoAirComE,");
			strSql.Append("PolicyType=@PolicyType,");
			strSql.Append("Cabin=@Cabin,");
			strSql.Append("VoyageType=@VoyageType,");
			strSql.Append("UserType=@UserType,");
			strSql.Append("RateType=@RateType,");
			strSql.Append("Discounts=@Discounts,");
			strSql.Append("Sdate=@Sdate,");
			strSql.Append("Edate=@Edate,");
			strSql.Append("WorkTimBegin=@WorkTimBegin,");
			strSql.Append("WorkTImeEnd=@WorkTImeEnd,");
			strSql.Append("Rewards=@Rewards,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("ET=@ET,");
			strSql.Append("WP=@WP,");
			strSql.Append("SP=@SP,");
			strSql.Append("XF=@XF,");
			strSql.Append("PromotionDiscount=@PromotionDiscount,");
			strSql.Append("NewRateNo=@NewRateNo,");
			strSql.Append("OfficeNum=@OfficeNum,");
			strSql.Append("RefundTimeBegin=@RefundTimeBegin,");
			strSql.Append("RefundTimeEnd=@RefundTimeEnd,");
			strSql.Append("LastModifyTime=@LastModifyTime,");
			strSql.Append("LimitModels=@LimitModels,");
			strSql.Append("RefundRulesWay=@RefundRulesWay,");
			strSql.Append("TPRemark=@TPRemark,");
			strSql.Append("ChangeMsg=@ChangeMsg,");
			strSql.Append("InvalidMsg=@InvalidMsg,");
			strSql.Append("RiseCabin=@RiseCabin,");
			strSql.Append("ForeignMsg=@ForeignMsg,");
			strSql.Append("OutTicketPercent=@OutTicketPercent,");
			strSql.Append("InvoiceMsg=@InvoiceMsg,");
			strSql.Append("PrintInvoice=@PrintInvoice,");
			strSql.Append("SwitchPNR=@SwitchPNR,");
			strSql.Append("Change=@Change,");
			strSql.Append("sed=@sed,");
			strSql.Append("PlatForm=@PlatForm,");
			strSql.Append("AddTime=@AddTime");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@PolicyId", SqlDbType.NVarChar,255),
					new SqlParameter("@RateId", SqlDbType.NVarChar,255),
					new SqlParameter("@ScityE", SqlDbType.NVarChar,255),
					new SqlParameter("@EcityE", SqlDbType.NVarChar,255),
					new SqlParameter("@AirComE", SqlDbType.NVarChar,255),
					new SqlParameter("@NoAirComE", SqlDbType.NVarChar,255),
					new SqlParameter("@PolicyType", SqlDbType.NVarChar,255),
					new SqlParameter("@Cabin", SqlDbType.NVarChar,255),
					new SqlParameter("@VoyageType", SqlDbType.NVarChar,255),
					new SqlParameter("@UserType", SqlDbType.NVarChar,255),
					new SqlParameter("@RateType", SqlDbType.NVarChar,255),
					new SqlParameter("@Discounts", SqlDbType.Float,8),
					new SqlParameter("@Sdate", SqlDbType.NVarChar,255),
					new SqlParameter("@Edate", SqlDbType.NVarChar,255),
					new SqlParameter("@WorkTimBegin", SqlDbType.NVarChar,255),
					new SqlParameter("@WorkTImeEnd", SqlDbType.NVarChar,255),
					new SqlParameter("@Rewards", SqlDbType.NVarChar,255),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@ET", SqlDbType.NVarChar,255),
					new SqlParameter("@WP", SqlDbType.NVarChar,255),
					new SqlParameter("@SP", SqlDbType.NVarChar,255),
					new SqlParameter("@XF", SqlDbType.NVarChar,255),
					new SqlParameter("@PromotionDiscount", SqlDbType.NVarChar,255),
					new SqlParameter("@NewRateNo", SqlDbType.NVarChar,255),
					new SqlParameter("@OfficeNum", SqlDbType.NVarChar,255),
					new SqlParameter("@RefundTimeBegin", SqlDbType.NVarChar,255),
					new SqlParameter("@RefundTimeEnd", SqlDbType.NVarChar,255),
					new SqlParameter("@LastModifyTime", SqlDbType.NVarChar,255),
					new SqlParameter("@LimitModels", SqlDbType.NVarChar,255),
					new SqlParameter("@RefundRulesWay", SqlDbType.NVarChar,255),
					new SqlParameter("@TPRemark", SqlDbType.NVarChar,255),
					new SqlParameter("@ChangeMsg", SqlDbType.NVarChar,255),
					new SqlParameter("@InvalidMsg", SqlDbType.NVarChar,255),
					new SqlParameter("@RiseCabin", SqlDbType.NVarChar,255),
					new SqlParameter("@ForeignMsg", SqlDbType.NVarChar,255),
					new SqlParameter("@OutTicketPercent", SqlDbType.NVarChar,255),
					new SqlParameter("@InvoiceMsg", SqlDbType.NVarChar,255),
					new SqlParameter("@PrintInvoice", SqlDbType.NVarChar,255),
					new SqlParameter("@SwitchPNR", SqlDbType.NVarChar,255),
					new SqlParameter("@Change", SqlDbType.NVarChar,255),
					new SqlParameter("@sed", SqlDbType.NVarChar,255),
					new SqlParameter("@PlatForm", SqlDbType.NVarChar,255),
					new SqlParameter("@AddTime", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.PolicyId;
			parameters[1].Value = model.RateId;
			parameters[2].Value = model.ScityE;
			parameters[3].Value = model.EcityE;
			parameters[4].Value = model.AirComE;
			parameters[5].Value = model.NoAirComE;
			parameters[6].Value = model.PolicyType;
			parameters[7].Value = model.Cabin;
			parameters[8].Value = model.VoyageType;
			parameters[9].Value = model.UserType;
			parameters[10].Value = model.RateType;
			parameters[11].Value = model.Discounts;
			parameters[12].Value = model.Sdate;
			parameters[13].Value = model.Edate;
			parameters[14].Value = model.WorkTimBegin;
			parameters[15].Value = model.WorkTImeEnd;
			parameters[16].Value = model.Rewards;
			parameters[17].Value = model.Remark;
			parameters[18].Value = model.ET;
			parameters[19].Value = model.WP;
			parameters[20].Value = model.SP;
			parameters[21].Value = model.XF;
			parameters[22].Value = model.PromotionDiscount;
			parameters[23].Value = model.NewRateNo;
			parameters[24].Value = model.OfficeNum;
			parameters[25].Value = model.RefundTimeBegin;
			parameters[26].Value = model.RefundTimeEnd;
			parameters[27].Value = model.LastModifyTime;
			parameters[28].Value = model.LimitModels;
			parameters[29].Value = model.RefundRulesWay;
			parameters[30].Value = model.TPRemark;
			parameters[31].Value = model.ChangeMsg;
			parameters[32].Value = model.InvalidMsg;
			parameters[33].Value = model.RiseCabin;
			parameters[34].Value = model.ForeignMsg;
			parameters[35].Value = model.OutTicketPercent;
			parameters[36].Value = model.InvoiceMsg;
			parameters[37].Value = model.PrintInvoice;
			parameters[38].Value = model.SwitchPNR;
			parameters[39].Value = model.Change;
			parameters[40].Value = model.sed;
			parameters[41].Value = model.PlatForm;
			parameters[42].Value = model.AddTime;
			parameters[43].Value = model.ID;

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
			strSql.Append("delete from excGetRateList ");
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
			strSql.Append("delete from excGetRateList ");
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
		public Sanben.Model.excGetRateList GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,PolicyId,RateId,ScityE,EcityE,AirComE,NoAirComE,PolicyType,Cabin,VoyageType,UserType,RateType,Discounts,Sdate,Edate,WorkTimBegin,WorkTImeEnd,Rewards,Remark,ET,WP,SP,XF,PromotionDiscount,NewRateNo,OfficeNum,RefundTimeBegin,RefundTimeEnd,LastModifyTime,LimitModels,RefundRulesWay,TPRemark,ChangeMsg,InvalidMsg,RiseCabin,ForeignMsg,OutTicketPercent,InvoiceMsg,PrintInvoice,SwitchPNR,Change,sed,PlatForm,AddTime from excGetRateList ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Sanben.Model.excGetRateList model=new Sanben.Model.excGetRateList();
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
		public Sanben.Model.excGetRateList DataRowToModel(DataRow row)
		{
			Sanben.Model.excGetRateList model=new Sanben.Model.excGetRateList();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["PolicyId"]!=null)
				{
					model.PolicyId=row["PolicyId"].ToString();
				}
				if(row["RateId"]!=null)
				{
					model.RateId=row["RateId"].ToString();
				}
				if(row["ScityE"]!=null)
				{
					model.ScityE=row["ScityE"].ToString();
				}
				if(row["EcityE"]!=null)
				{
					model.EcityE=row["EcityE"].ToString();
				}
				if(row["AirComE"]!=null)
				{
					model.AirComE=row["AirComE"].ToString();
				}
				if(row["NoAirComE"]!=null)
				{
					model.NoAirComE=row["NoAirComE"].ToString();
				}
				if(row["PolicyType"]!=null)
				{
					model.PolicyType=row["PolicyType"].ToString();
				}
				if(row["Cabin"]!=null)
				{
					model.Cabin=row["Cabin"].ToString();
				}
				if(row["VoyageType"]!=null)
				{
					model.VoyageType=row["VoyageType"].ToString();
				}
				if(row["UserType"]!=null)
				{
					model.UserType=row["UserType"].ToString();
				}
				if(row["RateType"]!=null)
				{
					model.RateType=row["RateType"].ToString();
				}
				if(row["Discounts"]!=null && row["Discounts"].ToString()!="")
				{
					model.Discounts=decimal.Parse(row["Discounts"].ToString());
				}
				if(row["Sdate"]!=null)
				{
					model.Sdate=row["Sdate"].ToString();
				}
				if(row["Edate"]!=null)
				{
					model.Edate=row["Edate"].ToString();
				}
				if(row["WorkTimBegin"]!=null)
				{
					model.WorkTimBegin=row["WorkTimBegin"].ToString();
				}
				if(row["WorkTImeEnd"]!=null)
				{
					model.WorkTImeEnd=row["WorkTImeEnd"].ToString();
				}
				if(row["Rewards"]!=null)
				{
					model.Rewards=row["Rewards"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["ET"]!=null)
				{
					model.ET=row["ET"].ToString();
				}
				if(row["WP"]!=null)
				{
					model.WP=row["WP"].ToString();
				}
				if(row["SP"]!=null)
				{
					model.SP=row["SP"].ToString();
				}
				if(row["XF"]!=null)
				{
					model.XF=row["XF"].ToString();
				}
				if(row["PromotionDiscount"]!=null)
				{
					model.PromotionDiscount=row["PromotionDiscount"].ToString();
				}
				if(row["NewRateNo"]!=null)
				{
					model.NewRateNo=row["NewRateNo"].ToString();
				}
				if(row["OfficeNum"]!=null)
				{
					model.OfficeNum=row["OfficeNum"].ToString();
				}
				if(row["RefundTimeBegin"]!=null)
				{
					model.RefundTimeBegin=row["RefundTimeBegin"].ToString();
				}
				if(row["RefundTimeEnd"]!=null)
				{
					model.RefundTimeEnd=row["RefundTimeEnd"].ToString();
				}
				if(row["LastModifyTime"]!=null)
				{
					model.LastModifyTime=row["LastModifyTime"].ToString();
				}
				if(row["LimitModels"]!=null)
				{
					model.LimitModels=row["LimitModels"].ToString();
				}
				if(row["RefundRulesWay"]!=null)
				{
					model.RefundRulesWay=row["RefundRulesWay"].ToString();
				}
				if(row["TPRemark"]!=null)
				{
					model.TPRemark=row["TPRemark"].ToString();
				}
				if(row["ChangeMsg"]!=null)
				{
					model.ChangeMsg=row["ChangeMsg"].ToString();
				}
				if(row["InvalidMsg"]!=null)
				{
					model.InvalidMsg=row["InvalidMsg"].ToString();
				}
				if(row["RiseCabin"]!=null)
				{
					model.RiseCabin=row["RiseCabin"].ToString();
				}
				if(row["ForeignMsg"]!=null)
				{
					model.ForeignMsg=row["ForeignMsg"].ToString();
				}
				if(row["OutTicketPercent"]!=null)
				{
					model.OutTicketPercent=row["OutTicketPercent"].ToString();
				}
				if(row["InvoiceMsg"]!=null)
				{
					model.InvoiceMsg=row["InvoiceMsg"].ToString();
				}
				if(row["PrintInvoice"]!=null)
				{
					model.PrintInvoice=row["PrintInvoice"].ToString();
				}
				if(row["SwitchPNR"]!=null)
				{
					model.SwitchPNR=row["SwitchPNR"].ToString();
				}
				if(row["Change"]!=null)
				{
					model.Change=row["Change"].ToString();
				}
				if(row["sed"]!=null)
				{
					model.sed=row["sed"].ToString();
				}
				if(row["PlatForm"]!=null)
				{
					model.PlatForm=row["PlatForm"].ToString();
				}
				if(row["AddTime"]!=null && row["AddTime"].ToString()!="")
				{
					model.AddTime=DateTime.Parse(row["AddTime"].ToString());
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
			strSql.Append("select ID,PolicyId,RateId,ScityE,EcityE,AirComE,NoAirComE,PolicyType,Cabin,VoyageType,UserType,RateType,Discounts,Sdate,Edate,WorkTimBegin,WorkTImeEnd,Rewards,Remark,ET,WP,SP,XF,PromotionDiscount,NewRateNo,OfficeNum,RefundTimeBegin,RefundTimeEnd,LastModifyTime,LimitModels,RefundRulesWay,TPRemark,ChangeMsg,InvalidMsg,RiseCabin,ForeignMsg,OutTicketPercent,InvoiceMsg,PrintInvoice,SwitchPNR,Change,sed,PlatForm,AddTime ");
			strSql.Append(" FROM excGetRateList ");
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
			strSql.Append(" ID,PolicyId,RateId,ScityE,EcityE,AirComE,NoAirComE,PolicyType,Cabin,VoyageType,UserType,RateType,Discounts,Sdate,Edate,WorkTimBegin,WorkTImeEnd,Rewards,Remark,ET,WP,SP,XF,PromotionDiscount,NewRateNo,OfficeNum,RefundTimeBegin,RefundTimeEnd,LastModifyTime,LimitModels,RefundRulesWay,TPRemark,ChangeMsg,InvalidMsg,RiseCabin,ForeignMsg,OutTicketPercent,InvoiceMsg,PrintInvoice,SwitchPNR,Change,sed,PlatForm,AddTime ");
			strSql.Append(" FROM excGetRateList ");
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
			strSql.Append("select count(1) FROM excGetRateList ");
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
			strSql.Append(")AS Row, T.*  from excGetRateList T ");
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
			parameters[0].Value = "excGetRateList";
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

