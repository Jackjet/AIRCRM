using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:BackupOrderInfo
	/// </summary>
	public partial class BackupOrderInfo:IBackupOrderInfo
	{
		public BackupOrderInfo()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Sanben.Model.BackupOrderInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BackupOrderInfo(");
			strSql.Append("pk_id,id,orderNo,allPrice,noPay,childPrintPrice,childFaceValue,source,policySource,ticketMode,policyFriendly,payChannel,payStatus,insuranceUnitPrice,backnote,insuranceCuttingPrice,cabinnote,xcdPrice,xcd,sjr,contactTel,address,company,expType,ordernumber,sendtime,viewPrice,price,pnr,cpnr,pnrText,childPnrText,pataText,childPataText,constructionFee,fuelTax,childFuelTax,policyType,status,contact,contactMob,contactEmail,createTime,needPS,username,orderFrom,lockStatus,updateTime,userid,orderDesc)");
			strSql.Append(" values (");
			strSql.Append("@pk_id,@id,@orderNo,@allPrice,@noPay,@childPrintPrice,@childFaceValue,@source,@policySource,@ticketMode,@policyFriendly,@payChannel,@payStatus,@insuranceUnitPrice,@backnote,@insuranceCuttingPrice,@cabinnote,@xcdPrice,@xcd,@sjr,@contactTel,@address,@company,@expType,@ordernumber,@sendtime,@viewPrice,@price,@pnr,@cpnr,@pnrText,@childPnrText,@pataText,@childPataText,@constructionFee,@fuelTax,@childFuelTax,@policyType,@status,@contact,@contactMob,@contactEmail,@createTime,@needPS,@username,@orderFrom,@lockStatus,@updateTime,@userid,@orderDesc)");
			SqlParameter[] parameters = {
					new SqlParameter("@pk_id", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@orderNo", SqlDbType.VarChar,255),
					new SqlParameter("@allPrice", SqlDbType.VarChar,100),
					new SqlParameter("@noPay", SqlDbType.VarChar,100),
					new SqlParameter("@childPrintPrice", SqlDbType.VarChar,100),
					new SqlParameter("@childFaceValue", SqlDbType.VarChar,100),
					new SqlParameter("@source", SqlDbType.VarChar,50),
					new SqlParameter("@policySource", SqlDbType.VarChar,100),
					new SqlParameter("@ticketMode", SqlDbType.VarChar,100),
					new SqlParameter("@policyFriendly", SqlDbType.VarChar,-1),
					new SqlParameter("@payChannel", SqlDbType.VarChar,50),
					new SqlParameter("@payStatus", SqlDbType.VarChar,50),
					new SqlParameter("@insuranceUnitPrice", SqlDbType.VarChar,50),
					new SqlParameter("@backnote", SqlDbType.VarChar,-1),
					new SqlParameter("@insuranceCuttingPrice", SqlDbType.VarChar,100),
					new SqlParameter("@cabinnote", SqlDbType.VarChar,50),
					new SqlParameter("@xcdPrice", SqlDbType.VarChar,100),
					new SqlParameter("@xcd", SqlDbType.VarChar,50),
					new SqlParameter("@sjr", SqlDbType.VarChar,50),
					new SqlParameter("@contactTel", SqlDbType.VarChar,50),
					new SqlParameter("@address", SqlDbType.VarChar,50),
					new SqlParameter("@company", SqlDbType.VarChar,50),
					new SqlParameter("@expType", SqlDbType.VarChar,50),
					new SqlParameter("@ordernumber", SqlDbType.VarChar,50),
					new SqlParameter("@sendtime", SqlDbType.VarChar,50),
					new SqlParameter("@viewPrice", SqlDbType.VarChar,100),
					new SqlParameter("@price", SqlDbType.VarChar,100),
					new SqlParameter("@pnr", SqlDbType.VarChar,255),
					new SqlParameter("@cpnr", SqlDbType.VarChar,50),
					new SqlParameter("@pnrText", SqlDbType.VarChar,-1),
					new SqlParameter("@childPnrText", SqlDbType.VarChar,-1),
					new SqlParameter("@pataText", SqlDbType.VarChar,-1),
					new SqlParameter("@childPataText", SqlDbType.VarChar,-1),
					new SqlParameter("@constructionFee", SqlDbType.VarChar,50),
					new SqlParameter("@fuelTax", SqlDbType.VarChar,50),
					new SqlParameter("@childFuelTax", SqlDbType.VarChar,50),
					new SqlParameter("@policyType", SqlDbType.VarChar,50),
					new SqlParameter("@status", SqlDbType.VarChar,50),
					new SqlParameter("@contact", SqlDbType.VarChar,50),
					new SqlParameter("@contactMob", SqlDbType.VarChar,-1),
					new SqlParameter("@contactEmail", SqlDbType.VarChar,-1),
					new SqlParameter("@createTime", SqlDbType.DateTime),
					new SqlParameter("@needPS", SqlDbType.VarChar,50),
					new SqlParameter("@username", SqlDbType.VarChar,50),
					new SqlParameter("@orderFrom", SqlDbType.VarChar,50),
					new SqlParameter("@lockStatus", SqlDbType.VarChar,50),
					new SqlParameter("@updateTime", SqlDbType.DateTime),
					new SqlParameter("@userid", SqlDbType.Int,4),
					new SqlParameter("@orderDesc", SqlDbType.VarChar,255)};
			parameters[0].Value = model.pk_id;
			parameters[1].Value = model.id;
			parameters[2].Value = model.orderNo;
			parameters[3].Value = model.allPrice;
			parameters[4].Value = model.noPay;
			parameters[5].Value = model.childPrintPrice;
			parameters[6].Value = model.childFaceValue;
			parameters[7].Value = model.source;
			parameters[8].Value = model.policySource;
			parameters[9].Value = model.ticketMode;
			parameters[10].Value = model.policyFriendly;
			parameters[11].Value = model.payChannel;
			parameters[12].Value = model.payStatus;
			parameters[13].Value = model.insuranceUnitPrice;
			parameters[14].Value = model.backnote;
			parameters[15].Value = model.insuranceCuttingPrice;
			parameters[16].Value = model.cabinnote;
			parameters[17].Value = model.xcdPrice;
			parameters[18].Value = model.xcd;
			parameters[19].Value = model.sjr;
			parameters[20].Value = model.contactTel;
			parameters[21].Value = model.address;
			parameters[22].Value = model.company;
			parameters[23].Value = model.expType;
			parameters[24].Value = model.ordernumber;
			parameters[25].Value = model.sendtime;
			parameters[26].Value = model.viewPrice;
			parameters[27].Value = model.price;
			parameters[28].Value = model.pnr;
			parameters[29].Value = model.cpnr;
			parameters[30].Value = model.pnrText;
			parameters[31].Value = model.childPnrText;
			parameters[32].Value = model.pataText;
			parameters[33].Value = model.childPataText;
			parameters[34].Value = model.constructionFee;
			parameters[35].Value = model.fuelTax;
			parameters[36].Value = model.childFuelTax;
			parameters[37].Value = model.policyType;
			parameters[38].Value = model.status;
			parameters[39].Value = model.contact;
			parameters[40].Value = model.contactMob;
			parameters[41].Value = model.contactEmail;
			parameters[42].Value = model.createTime;
			parameters[43].Value = model.needPS;
			parameters[44].Value = model.username;
			parameters[45].Value = model.orderFrom;
			parameters[46].Value = model.lockStatus;
			parameters[47].Value = model.updateTime;
			parameters[48].Value = model.userid;
			parameters[49].Value = model.orderDesc;

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
		public bool Update(Sanben.Model.BackupOrderInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BackupOrderInfo set ");
			strSql.Append("pk_id=@pk_id,");
			strSql.Append("id=@id,");
			strSql.Append("orderNo=@orderNo,");
			strSql.Append("allPrice=@allPrice,");
			strSql.Append("noPay=@noPay,");
			strSql.Append("childPrintPrice=@childPrintPrice,");
			strSql.Append("childFaceValue=@childFaceValue,");
			strSql.Append("source=@source,");
			strSql.Append("policySource=@policySource,");
			strSql.Append("ticketMode=@ticketMode,");
			strSql.Append("policyFriendly=@policyFriendly,");
			strSql.Append("payChannel=@payChannel,");
			strSql.Append("payStatus=@payStatus,");
			strSql.Append("insuranceUnitPrice=@insuranceUnitPrice,");
			strSql.Append("backnote=@backnote,");
			strSql.Append("insuranceCuttingPrice=@insuranceCuttingPrice,");
			strSql.Append("cabinnote=@cabinnote,");
			strSql.Append("xcdPrice=@xcdPrice,");
			strSql.Append("xcd=@xcd,");
			strSql.Append("sjr=@sjr,");
			strSql.Append("contactTel=@contactTel,");
			strSql.Append("address=@address,");
			strSql.Append("company=@company,");
			strSql.Append("expType=@expType,");
			strSql.Append("ordernumber=@ordernumber,");
			strSql.Append("sendtime=@sendtime,");
			strSql.Append("viewPrice=@viewPrice,");
			strSql.Append("price=@price,");
			strSql.Append("pnr=@pnr,");
			strSql.Append("cpnr=@cpnr,");
			strSql.Append("pnrText=@pnrText,");
			strSql.Append("childPnrText=@childPnrText,");
			strSql.Append("pataText=@pataText,");
			strSql.Append("childPataText=@childPataText,");
			strSql.Append("constructionFee=@constructionFee,");
			strSql.Append("fuelTax=@fuelTax,");
			strSql.Append("childFuelTax=@childFuelTax,");
			strSql.Append("policyType=@policyType,");
			strSql.Append("status=@status,");
			strSql.Append("contact=@contact,");
			strSql.Append("contactMob=@contactMob,");
			strSql.Append("contactEmail=@contactEmail,");
			strSql.Append("createTime=@createTime,");
			strSql.Append("needPS=@needPS,");
			strSql.Append("username=@username,");
			strSql.Append("orderFrom=@orderFrom,");
			strSql.Append("lockStatus=@lockStatus,");
			strSql.Append("updateTime=@updateTime,");
			strSql.Append("userid=@userid,");
			strSql.Append("orderDesc=@orderDesc");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@pk_id", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@orderNo", SqlDbType.VarChar,255),
					new SqlParameter("@allPrice", SqlDbType.VarChar,100),
					new SqlParameter("@noPay", SqlDbType.VarChar,100),
					new SqlParameter("@childPrintPrice", SqlDbType.VarChar,100),
					new SqlParameter("@childFaceValue", SqlDbType.VarChar,100),
					new SqlParameter("@source", SqlDbType.VarChar,50),
					new SqlParameter("@policySource", SqlDbType.VarChar,100),
					new SqlParameter("@ticketMode", SqlDbType.VarChar,100),
					new SqlParameter("@policyFriendly", SqlDbType.VarChar,-1),
					new SqlParameter("@payChannel", SqlDbType.VarChar,50),
					new SqlParameter("@payStatus", SqlDbType.VarChar,50),
					new SqlParameter("@insuranceUnitPrice", SqlDbType.VarChar,50),
					new SqlParameter("@backnote", SqlDbType.VarChar,-1),
					new SqlParameter("@insuranceCuttingPrice", SqlDbType.VarChar,100),
					new SqlParameter("@cabinnote", SqlDbType.VarChar,50),
					new SqlParameter("@xcdPrice", SqlDbType.VarChar,100),
					new SqlParameter("@xcd", SqlDbType.VarChar,50),
					new SqlParameter("@sjr", SqlDbType.VarChar,50),
					new SqlParameter("@contactTel", SqlDbType.VarChar,50),
					new SqlParameter("@address", SqlDbType.VarChar,50),
					new SqlParameter("@company", SqlDbType.VarChar,50),
					new SqlParameter("@expType", SqlDbType.VarChar,50),
					new SqlParameter("@ordernumber", SqlDbType.VarChar,50),
					new SqlParameter("@sendtime", SqlDbType.VarChar,50),
					new SqlParameter("@viewPrice", SqlDbType.VarChar,100),
					new SqlParameter("@price", SqlDbType.VarChar,100),
					new SqlParameter("@pnr", SqlDbType.VarChar,255),
					new SqlParameter("@cpnr", SqlDbType.VarChar,50),
					new SqlParameter("@pnrText", SqlDbType.VarChar,-1),
					new SqlParameter("@childPnrText", SqlDbType.VarChar,-1),
					new SqlParameter("@pataText", SqlDbType.VarChar,-1),
					new SqlParameter("@childPataText", SqlDbType.VarChar,-1),
					new SqlParameter("@constructionFee", SqlDbType.VarChar,50),
					new SqlParameter("@fuelTax", SqlDbType.VarChar,50),
					new SqlParameter("@childFuelTax", SqlDbType.VarChar,50),
					new SqlParameter("@policyType", SqlDbType.VarChar,50),
					new SqlParameter("@status", SqlDbType.VarChar,50),
					new SqlParameter("@contact", SqlDbType.VarChar,50),
					new SqlParameter("@contactMob", SqlDbType.VarChar,-1),
					new SqlParameter("@contactEmail", SqlDbType.VarChar,-1),
					new SqlParameter("@createTime", SqlDbType.DateTime),
					new SqlParameter("@needPS", SqlDbType.VarChar,50),
					new SqlParameter("@username", SqlDbType.VarChar,50),
					new SqlParameter("@orderFrom", SqlDbType.VarChar,50),
					new SqlParameter("@lockStatus", SqlDbType.VarChar,50),
					new SqlParameter("@updateTime", SqlDbType.DateTime),
					new SqlParameter("@userid", SqlDbType.Int,4),
					new SqlParameter("@orderDesc", SqlDbType.VarChar,255)};
			parameters[0].Value = model.pk_id;
			parameters[1].Value = model.id;
			parameters[2].Value = model.orderNo;
			parameters[3].Value = model.allPrice;
			parameters[4].Value = model.noPay;
			parameters[5].Value = model.childPrintPrice;
			parameters[6].Value = model.childFaceValue;
			parameters[7].Value = model.source;
			parameters[8].Value = model.policySource;
			parameters[9].Value = model.ticketMode;
			parameters[10].Value = model.policyFriendly;
			parameters[11].Value = model.payChannel;
			parameters[12].Value = model.payStatus;
			parameters[13].Value = model.insuranceUnitPrice;
			parameters[14].Value = model.backnote;
			parameters[15].Value = model.insuranceCuttingPrice;
			parameters[16].Value = model.cabinnote;
			parameters[17].Value = model.xcdPrice;
			parameters[18].Value = model.xcd;
			parameters[19].Value = model.sjr;
			parameters[20].Value = model.contactTel;
			parameters[21].Value = model.address;
			parameters[22].Value = model.company;
			parameters[23].Value = model.expType;
			parameters[24].Value = model.ordernumber;
			parameters[25].Value = model.sendtime;
			parameters[26].Value = model.viewPrice;
			parameters[27].Value = model.price;
			parameters[28].Value = model.pnr;
			parameters[29].Value = model.cpnr;
			parameters[30].Value = model.pnrText;
			parameters[31].Value = model.childPnrText;
			parameters[32].Value = model.pataText;
			parameters[33].Value = model.childPataText;
			parameters[34].Value = model.constructionFee;
			parameters[35].Value = model.fuelTax;
			parameters[36].Value = model.childFuelTax;
			parameters[37].Value = model.policyType;
			parameters[38].Value = model.status;
			parameters[39].Value = model.contact;
			parameters[40].Value = model.contactMob;
			parameters[41].Value = model.contactEmail;
			parameters[42].Value = model.createTime;
			parameters[43].Value = model.needPS;
			parameters[44].Value = model.username;
			parameters[45].Value = model.orderFrom;
			parameters[46].Value = model.lockStatus;
			parameters[47].Value = model.updateTime;
			parameters[48].Value = model.userid;
			parameters[49].Value = model.orderDesc;

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
			strSql.Append("delete from BackupOrderInfo ");
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
		public Sanben.Model.BackupOrderInfo GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 pk_id,id,orderNo,allPrice,noPay,childPrintPrice,childFaceValue,source,policySource,ticketMode,policyFriendly,payChannel,payStatus,insuranceUnitPrice,backnote,insuranceCuttingPrice,cabinnote,xcdPrice,xcd,sjr,contactTel,address,company,expType,ordernumber,sendtime,viewPrice,price,pnr,cpnr,pnrText,childPnrText,pataText,childPataText,constructionFee,fuelTax,childFuelTax,policyType,status,contact,contactMob,contactEmail,createTime,needPS,username,orderFrom,lockStatus,updateTime,userid,orderDesc from BackupOrderInfo ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Sanben.Model.BackupOrderInfo model=new Sanben.Model.BackupOrderInfo();
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
		public Sanben.Model.BackupOrderInfo DataRowToModel(DataRow row)
		{
			Sanben.Model.BackupOrderInfo model=new Sanben.Model.BackupOrderInfo();
			if (row != null)
			{
				if(row["pk_id"]!=null && row["pk_id"].ToString()!="")
				{
					model.pk_id=int.Parse(row["pk_id"].ToString());
				}
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["orderNo"]!=null)
				{
					model.orderNo=row["orderNo"].ToString();
				}
				if(row["allPrice"]!=null)
				{
					model.allPrice=row["allPrice"].ToString();
				}
				if(row["noPay"]!=null)
				{
					model.noPay=row["noPay"].ToString();
				}
				if(row["childPrintPrice"]!=null)
				{
					model.childPrintPrice=row["childPrintPrice"].ToString();
				}
				if(row["childFaceValue"]!=null)
				{
					model.childFaceValue=row["childFaceValue"].ToString();
				}
				if(row["source"]!=null)
				{
					model.source=row["source"].ToString();
				}
				if(row["policySource"]!=null)
				{
					model.policySource=row["policySource"].ToString();
				}
				if(row["ticketMode"]!=null)
				{
					model.ticketMode=row["ticketMode"].ToString();
				}
				if(row["policyFriendly"]!=null)
				{
					model.policyFriendly=row["policyFriendly"].ToString();
				}
				if(row["payChannel"]!=null)
				{
					model.payChannel=row["payChannel"].ToString();
				}
				if(row["payStatus"]!=null)
				{
					model.payStatus=row["payStatus"].ToString();
				}
				if(row["insuranceUnitPrice"]!=null)
				{
					model.insuranceUnitPrice=row["insuranceUnitPrice"].ToString();
				}
				if(row["backnote"]!=null)
				{
					model.backnote=row["backnote"].ToString();
				}
				if(row["insuranceCuttingPrice"]!=null)
				{
					model.insuranceCuttingPrice=row["insuranceCuttingPrice"].ToString();
				}
				if(row["cabinnote"]!=null)
				{
					model.cabinnote=row["cabinnote"].ToString();
				}
				if(row["xcdPrice"]!=null)
				{
					model.xcdPrice=row["xcdPrice"].ToString();
				}
				if(row["xcd"]!=null)
				{
					model.xcd=row["xcd"].ToString();
				}
				if(row["sjr"]!=null)
				{
					model.sjr=row["sjr"].ToString();
				}
				if(row["contactTel"]!=null)
				{
					model.contactTel=row["contactTel"].ToString();
				}
				if(row["address"]!=null)
				{
					model.address=row["address"].ToString();
				}
				if(row["company"]!=null)
				{
					model.company=row["company"].ToString();
				}
				if(row["expType"]!=null)
				{
					model.expType=row["expType"].ToString();
				}
				if(row["ordernumber"]!=null)
				{
					model.ordernumber=row["ordernumber"].ToString();
				}
				if(row["sendtime"]!=null)
				{
					model.sendtime=row["sendtime"].ToString();
				}
				if(row["viewPrice"]!=null)
				{
					model.viewPrice=row["viewPrice"].ToString();
				}
				if(row["price"]!=null)
				{
					model.price=row["price"].ToString();
				}
				if(row["pnr"]!=null)
				{
					model.pnr=row["pnr"].ToString();
				}
				if(row["cpnr"]!=null)
				{
					model.cpnr=row["cpnr"].ToString();
				}
				if(row["pnrText"]!=null)
				{
					model.pnrText=row["pnrText"].ToString();
				}
				if(row["childPnrText"]!=null)
				{
					model.childPnrText=row["childPnrText"].ToString();
				}
				if(row["pataText"]!=null)
				{
					model.pataText=row["pataText"].ToString();
				}
				if(row["childPataText"]!=null)
				{
					model.childPataText=row["childPataText"].ToString();
				}
				if(row["constructionFee"]!=null)
				{
					model.constructionFee=row["constructionFee"].ToString();
				}
				if(row["fuelTax"]!=null)
				{
					model.fuelTax=row["fuelTax"].ToString();
				}
				if(row["childFuelTax"]!=null)
				{
					model.childFuelTax=row["childFuelTax"].ToString();
				}
				if(row["policyType"]!=null)
				{
					model.policyType=row["policyType"].ToString();
				}
				if(row["status"]!=null)
				{
					model.status=row["status"].ToString();
				}
				if(row["contact"]!=null)
				{
					model.contact=row["contact"].ToString();
				}
				if(row["contactMob"]!=null)
				{
					model.contactMob=row["contactMob"].ToString();
				}
				if(row["contactEmail"]!=null)
				{
					model.contactEmail=row["contactEmail"].ToString();
				}
				if(row["createTime"]!=null && row["createTime"].ToString()!="")
				{
					model.createTime=DateTime.Parse(row["createTime"].ToString());
				}
				if(row["needPS"]!=null)
				{
					model.needPS=row["needPS"].ToString();
				}
				if(row["username"]!=null)
				{
					model.username=row["username"].ToString();
				}
				if(row["orderFrom"]!=null)
				{
					model.orderFrom=row["orderFrom"].ToString();
				}
				if(row["lockStatus"]!=null)
				{
					model.lockStatus=row["lockStatus"].ToString();
				}
				if(row["updateTime"]!=null && row["updateTime"].ToString()!="")
				{
					model.updateTime=DateTime.Parse(row["updateTime"].ToString());
				}
				if(row["userid"]!=null && row["userid"].ToString()!="")
				{
					model.userid=int.Parse(row["userid"].ToString());
				}
				if(row["orderDesc"]!=null)
				{
					model.orderDesc=row["orderDesc"].ToString();
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
			strSql.Append("select pk_id,id,orderNo,allPrice,noPay,childPrintPrice,childFaceValue,source,policySource,ticketMode,policyFriendly,payChannel,payStatus,insuranceUnitPrice,backnote,insuranceCuttingPrice,cabinnote,xcdPrice,xcd,sjr,contactTel,address,company,expType,ordernumber,sendtime,viewPrice,price,pnr,cpnr,pnrText,childPnrText,pataText,childPataText,constructionFee,fuelTax,childFuelTax,policyType,status,contact,contactMob,contactEmail,createTime,needPS,username,orderFrom,lockStatus,updateTime,userid,orderDesc ");
			strSql.Append(" FROM BackupOrderInfo ");
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
			strSql.Append(" pk_id,id,orderNo,allPrice,noPay,childPrintPrice,childFaceValue,source,policySource,ticketMode,policyFriendly,payChannel,payStatus,insuranceUnitPrice,backnote,insuranceCuttingPrice,cabinnote,xcdPrice,xcd,sjr,contactTel,address,company,expType,ordernumber,sendtime,viewPrice,price,pnr,cpnr,pnrText,childPnrText,pataText,childPataText,constructionFee,fuelTax,childFuelTax,policyType,status,contact,contactMob,contactEmail,createTime,needPS,username,orderFrom,lockStatus,updateTime,userid,orderDesc ");
			strSql.Append(" FROM BackupOrderInfo ");
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
			strSql.Append("select count(1) FROM BackupOrderInfo ");
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
			strSql.Append(")AS Row, T.*  from BackupOrderInfo T ");
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
			parameters[0].Value = "BackupOrderInfo";
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

