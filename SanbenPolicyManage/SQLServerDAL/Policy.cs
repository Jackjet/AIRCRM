using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:Policy
	/// </summary>
	public partial class Policy:IPolicy
	{
		public Policy()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "Policy"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Policy");
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
		public int Add(Sanben.Model.Policy model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Policy(");
			strSql.Append("flightcode,policyCode,dpt,arr,flightNumLimit,flightcondition,daycondition,cabin,discountType,discountValue,returnpoint,returnprice,startdate_ticket,enfdate_ticket,startdate,enddate,beforeValidDay,backnote,cabinnote,autoTicket,shared,officeno,ktype,checkCycleTime,autoCheckOverTime,manualCheckOverTime,policy,downDiscount,pata,specialRule,allCabin,canPay,deptTimeSlot,needPnr,one_flightlimit,one_limitnum,two_flightlimit,two_limitnum,one_daylimit,two_daylimit,gocabin,backcabin,one_startdate,one_enddate,two_startdate,two_enddate,short_stoptime,long_stoptime,costtype,costPrice,proxyPrice,backPrice,policySource,xcd,returnRule,changeRule,endorsement,flyerpoints,cardType,maxAge,minAge,sys_id,uploadPolicyType,earliestBeforeValidDay,isUpload,importTime,uploadPlat,uploadResult)");
			strSql.Append(" values (");
			strSql.Append("@flightcode,@policyCode,@dpt,@arr,@flightNumLimit,@flightcondition,@daycondition,@cabin,@discountType,@discountValue,@returnpoint,@returnprice,@startdate_ticket,@enfdate_ticket,@startdate,@enddate,@beforeValidDay,@backnote,@cabinnote,@autoTicket,@shared,@officeno,@ktype,@checkCycleTime,@autoCheckOverTime,@manualCheckOverTime,@policy,@downDiscount,@pata,@specialRule,@allCabin,@canPay,@deptTimeSlot,@needPnr,@one_flightlimit,@one_limitnum,@two_flightlimit,@two_limitnum,@one_daylimit,@two_daylimit,@gocabin,@backcabin,@one_startdate,@one_enddate,@two_startdate,@two_enddate,@short_stoptime,@long_stoptime,@costtype,@costPrice,@proxyPrice,@backPrice,@policySource,@xcd,@returnRule,@changeRule,@endorsement,@flyerpoints,@cardType,@maxAge,@minAge,@sys_id,@uploadPolicyType,@earliestBeforeValidDay,@isUpload,@importTime,@uploadPlat,@uploadResult)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@flightcode", SqlDbType.Char,2),
					new SqlParameter("@policyCode", SqlDbType.VarChar,50),
					new SqlParameter("@dpt", SqlDbType.Char,3),
					new SqlParameter("@arr", SqlDbType.NVarChar,255),
					new SqlParameter("@flightNumLimit", SqlDbType.VarChar,50),
					new SqlParameter("@flightcondition", SqlDbType.VarChar,255),
					new SqlParameter("@daycondition", SqlDbType.VarChar,20),
					new SqlParameter("@cabin", SqlDbType.VarChar,100),
					new SqlParameter("@discountType", SqlDbType.VarChar,30),
					new SqlParameter("@discountValue", SqlDbType.VarChar,10),
					new SqlParameter("@returnpoint", SqlDbType.Float,8),
					new SqlParameter("@returnprice", SqlDbType.Int,4),
					new SqlParameter("@startdate_ticket", SqlDbType.Date,3),
					new SqlParameter("@enfdate_ticket", SqlDbType.Date,3),
					new SqlParameter("@startdate", SqlDbType.Date,3),
					new SqlParameter("@enddate", SqlDbType.Date,3),
					new SqlParameter("@beforeValidDay", SqlDbType.Int,4),
					new SqlParameter("@backnote", SqlDbType.VarChar,255),
					new SqlParameter("@cabinnote", SqlDbType.VarChar,255),
					new SqlParameter("@autoTicket", SqlDbType.Bit,1),
					new SqlParameter("@shared", SqlDbType.Bit,1),
					new SqlParameter("@officeno", SqlDbType.VarChar,100),
					new SqlParameter("@ktype", SqlDbType.VarChar,10),
					new SqlParameter("@checkCycleTime", SqlDbType.Int,4),
					new SqlParameter("@autoCheckOverTime", SqlDbType.Int,4),
					new SqlParameter("@manualCheckOverTime", SqlDbType.Int,4),
					new SqlParameter("@policy", SqlDbType.VarChar,30),
					new SqlParameter("@downDiscount", SqlDbType.Float,8),
					new SqlParameter("@pata", SqlDbType.Bit,1),
					new SqlParameter("@specialRule", SqlDbType.VarChar,255),
					new SqlParameter("@allCabin", SqlDbType.Int,4),
					new SqlParameter("@canPay", SqlDbType.Bit,1),
					new SqlParameter("@deptTimeSlot", SqlDbType.VarChar,50),
					new SqlParameter("@needPnr", SqlDbType.Bit,1),
					new SqlParameter("@one_flightlimit", SqlDbType.VarChar,20),
					new SqlParameter("@one_limitnum", SqlDbType.VarChar,20),
					new SqlParameter("@two_flightlimit", SqlDbType.VarChar,20),
					new SqlParameter("@two_limitnum", SqlDbType.VarChar,20),
					new SqlParameter("@one_daylimit", SqlDbType.VarChar,20),
					new SqlParameter("@two_daylimit", SqlDbType.VarChar,20),
					new SqlParameter("@gocabin", SqlDbType.VarChar,20),
					new SqlParameter("@backcabin", SqlDbType.VarChar,20),
					new SqlParameter("@one_startdate", SqlDbType.Date,3),
					new SqlParameter("@one_enddate", SqlDbType.Date,3),
					new SqlParameter("@two_startdate", SqlDbType.Date,3),
					new SqlParameter("@two_enddate", SqlDbType.Date,3),
					new SqlParameter("@short_stoptime", SqlDbType.Int,4),
					new SqlParameter("@long_stoptime", SqlDbType.Int,4),
					new SqlParameter("@costtype", SqlDbType.VarChar,100),
					new SqlParameter("@costPrice", SqlDbType.Float,8),
					new SqlParameter("@proxyPrice", SqlDbType.Float,8),
					new SqlParameter("@backPrice", SqlDbType.Float,8),
					new SqlParameter("@policySource", SqlDbType.VarChar,50),
					new SqlParameter("@xcd", SqlDbType.NVarChar,50),
					new SqlParameter("@returnRule", SqlDbType.VarChar,50),
					new SqlParameter("@changeRule", SqlDbType.VarChar,50),
					new SqlParameter("@endorsement", SqlDbType.Bit,1),
					new SqlParameter("@flyerpoints", SqlDbType.Bit,1),
					new SqlParameter("@cardType", SqlDbType.Int,4),
					new SqlParameter("@maxAge", SqlDbType.Int,4),
					new SqlParameter("@minAge", SqlDbType.Int,4),
					new SqlParameter("@sys_id", SqlDbType.Int,4),
					new SqlParameter("@uploadPolicyType", SqlDbType.VarChar,50),
					new SqlParameter("@earliestBeforeValidDay", SqlDbType.Int,4),
					new SqlParameter("@isUpload", SqlDbType.Int,4),
					new SqlParameter("@importTime", SqlDbType.Date,3),
					new SqlParameter("@uploadPlat", SqlDbType.VarChar,255),
					new SqlParameter("@uploadResult", SqlDbType.Int,4)};
			parameters[0].Value = model.flightcode;
			parameters[1].Value = model.policyCode;
			parameters[2].Value = model.dpt;
			parameters[3].Value = model.arr;
			parameters[4].Value = model.flightNumLimit;
			parameters[5].Value = model.flightcondition;
			parameters[6].Value = model.daycondition;
			parameters[7].Value = model.cabin;
			parameters[8].Value = model.discountType;
			parameters[9].Value = model.discountValue;
			parameters[10].Value = model.returnpoint;
			parameters[11].Value = model.returnprice;
			parameters[12].Value = model.startdate_ticket;
			parameters[13].Value = model.enfdate_ticket;
			parameters[14].Value = model.startdate;
			parameters[15].Value = model.enddate;
			parameters[16].Value = model.beforeValidDay;
			parameters[17].Value = model.backnote;
			parameters[18].Value = model.cabinnote;
			parameters[19].Value = model.autoTicket;
			parameters[20].Value = model.shared;
			parameters[21].Value = model.officeno;
			parameters[22].Value = model.ktype;
			parameters[23].Value = model.checkCycleTime;
			parameters[24].Value = model.autoCheckOverTime;
			parameters[25].Value = model.manualCheckOverTime;
			parameters[26].Value = model.policy;
			parameters[27].Value = model.downDiscount;
			parameters[28].Value = model.pata;
			parameters[29].Value = model.specialRule;
			parameters[30].Value = model.allCabin;
			parameters[31].Value = model.canPay;
			parameters[32].Value = model.deptTimeSlot;
			parameters[33].Value = model.needPnr;
			parameters[34].Value = model.one_flightlimit;
			parameters[35].Value = model.one_limitnum;
			parameters[36].Value = model.two_flightlimit;
			parameters[37].Value = model.two_limitnum;
			parameters[38].Value = model.one_daylimit;
			parameters[39].Value = model.two_daylimit;
			parameters[40].Value = model.gocabin;
			parameters[41].Value = model.backcabin;
			parameters[42].Value = model.one_startdate;
			parameters[43].Value = model.one_enddate;
			parameters[44].Value = model.two_startdate;
			parameters[45].Value = model.two_enddate;
			parameters[46].Value = model.short_stoptime;
			parameters[47].Value = model.long_stoptime;
			parameters[48].Value = model.costtype;
			parameters[49].Value = model.costPrice;
			parameters[50].Value = model.proxyPrice;
			parameters[51].Value = model.backPrice;
			parameters[52].Value = model.policySource;
			parameters[53].Value = model.xcd;
			parameters[54].Value = model.returnRule;
			parameters[55].Value = model.changeRule;
			parameters[56].Value = model.endorsement;
			parameters[57].Value = model.flyerpoints;
			parameters[58].Value = model.cardType;
			parameters[59].Value = model.maxAge;
			parameters[60].Value = model.minAge;
			parameters[61].Value = model.sys_id;
			parameters[62].Value = model.uploadPolicyType;
			parameters[63].Value = model.earliestBeforeValidDay;
			parameters[64].Value = model.isUpload;
			parameters[65].Value = model.importTime;
			parameters[66].Value = model.uploadPlat;
			parameters[67].Value = model.uploadResult;

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
		public bool Update(Sanben.Model.Policy model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Policy set ");
			strSql.Append("flightcode=@flightcode,");
			strSql.Append("policyCode=@policyCode,");
			strSql.Append("dpt=@dpt,");
			strSql.Append("arr=@arr,");
			strSql.Append("flightNumLimit=@flightNumLimit,");
			strSql.Append("flightcondition=@flightcondition,");
			strSql.Append("daycondition=@daycondition,");
			strSql.Append("cabin=@cabin,");
			strSql.Append("discountType=@discountType,");
			strSql.Append("discountValue=@discountValue,");
			strSql.Append("returnpoint=@returnpoint,");
			strSql.Append("returnprice=@returnprice,");
			strSql.Append("startdate_ticket=@startdate_ticket,");
			strSql.Append("enfdate_ticket=@enfdate_ticket,");
			strSql.Append("startdate=@startdate,");
			strSql.Append("enddate=@enddate,");
			strSql.Append("beforeValidDay=@beforeValidDay,");
			strSql.Append("backnote=@backnote,");
			strSql.Append("cabinnote=@cabinnote,");
			strSql.Append("autoTicket=@autoTicket,");
			strSql.Append("shared=@shared,");
			strSql.Append("officeno=@officeno,");
			strSql.Append("ktype=@ktype,");
			strSql.Append("checkCycleTime=@checkCycleTime,");
			strSql.Append("autoCheckOverTime=@autoCheckOverTime,");
			strSql.Append("manualCheckOverTime=@manualCheckOverTime,");
			strSql.Append("policy=@policy,");
			strSql.Append("downDiscount=@downDiscount,");
			strSql.Append("pata=@pata,");
			strSql.Append("specialRule=@specialRule,");
			strSql.Append("allCabin=@allCabin,");
			strSql.Append("canPay=@canPay,");
			strSql.Append("deptTimeSlot=@deptTimeSlot,");
			strSql.Append("needPnr=@needPnr,");
			strSql.Append("one_flightlimit=@one_flightlimit,");
			strSql.Append("one_limitnum=@one_limitnum,");
			strSql.Append("two_flightlimit=@two_flightlimit,");
			strSql.Append("two_limitnum=@two_limitnum,");
			strSql.Append("one_daylimit=@one_daylimit,");
			strSql.Append("two_daylimit=@two_daylimit,");
			strSql.Append("gocabin=@gocabin,");
			strSql.Append("backcabin=@backcabin,");
			strSql.Append("one_startdate=@one_startdate,");
			strSql.Append("one_enddate=@one_enddate,");
			strSql.Append("two_startdate=@two_startdate,");
			strSql.Append("two_enddate=@two_enddate,");
			strSql.Append("short_stoptime=@short_stoptime,");
			strSql.Append("long_stoptime=@long_stoptime,");
			strSql.Append("costtype=@costtype,");
			strSql.Append("costPrice=@costPrice,");
			strSql.Append("proxyPrice=@proxyPrice,");
			strSql.Append("backPrice=@backPrice,");
			strSql.Append("policySource=@policySource,");
			strSql.Append("xcd=@xcd,");
			strSql.Append("returnRule=@returnRule,");
			strSql.Append("changeRule=@changeRule,");
			strSql.Append("endorsement=@endorsement,");
			strSql.Append("flyerpoints=@flyerpoints,");
			strSql.Append("cardType=@cardType,");
			strSql.Append("maxAge=@maxAge,");
			strSql.Append("minAge=@minAge,");
			strSql.Append("sys_id=@sys_id,");
			strSql.Append("uploadPolicyType=@uploadPolicyType,");
			strSql.Append("earliestBeforeValidDay=@earliestBeforeValidDay,");
			strSql.Append("isUpload=@isUpload,");
			strSql.Append("importTime=@importTime,");
			strSql.Append("uploadPlat=@uploadPlat,");
			strSql.Append("uploadResult=@uploadResult");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@flightcode", SqlDbType.Char,2),
					new SqlParameter("@policyCode", SqlDbType.VarChar,50),
					new SqlParameter("@dpt", SqlDbType.Char,3),
					new SqlParameter("@arr", SqlDbType.NVarChar,255),
					new SqlParameter("@flightNumLimit", SqlDbType.VarChar,50),
					new SqlParameter("@flightcondition", SqlDbType.VarChar,255),
					new SqlParameter("@daycondition", SqlDbType.VarChar,20),
					new SqlParameter("@cabin", SqlDbType.VarChar,100),
					new SqlParameter("@discountType", SqlDbType.VarChar,30),
					new SqlParameter("@discountValue", SqlDbType.VarChar,10),
					new SqlParameter("@returnpoint", SqlDbType.Float,8),
					new SqlParameter("@returnprice", SqlDbType.Int,4),
					new SqlParameter("@startdate_ticket", SqlDbType.Date,3),
					new SqlParameter("@enfdate_ticket", SqlDbType.Date,3),
					new SqlParameter("@startdate", SqlDbType.Date,3),
					new SqlParameter("@enddate", SqlDbType.Date,3),
					new SqlParameter("@beforeValidDay", SqlDbType.Int,4),
					new SqlParameter("@backnote", SqlDbType.VarChar,255),
					new SqlParameter("@cabinnote", SqlDbType.VarChar,255),
					new SqlParameter("@autoTicket", SqlDbType.Bit,1),
					new SqlParameter("@shared", SqlDbType.Bit,1),
					new SqlParameter("@officeno", SqlDbType.VarChar,100),
					new SqlParameter("@ktype", SqlDbType.VarChar,10),
					new SqlParameter("@checkCycleTime", SqlDbType.Int,4),
					new SqlParameter("@autoCheckOverTime", SqlDbType.Int,4),
					new SqlParameter("@manualCheckOverTime", SqlDbType.Int,4),
					new SqlParameter("@policy", SqlDbType.VarChar,30),
					new SqlParameter("@downDiscount", SqlDbType.Float,8),
					new SqlParameter("@pata", SqlDbType.Bit,1),
					new SqlParameter("@specialRule", SqlDbType.VarChar,255),
					new SqlParameter("@allCabin", SqlDbType.Int,4),
					new SqlParameter("@canPay", SqlDbType.Bit,1),
					new SqlParameter("@deptTimeSlot", SqlDbType.VarChar,50),
					new SqlParameter("@needPnr", SqlDbType.Bit,1),
					new SqlParameter("@one_flightlimit", SqlDbType.VarChar,20),
					new SqlParameter("@one_limitnum", SqlDbType.VarChar,20),
					new SqlParameter("@two_flightlimit", SqlDbType.VarChar,20),
					new SqlParameter("@two_limitnum", SqlDbType.VarChar,20),
					new SqlParameter("@one_daylimit", SqlDbType.VarChar,20),
					new SqlParameter("@two_daylimit", SqlDbType.VarChar,20),
					new SqlParameter("@gocabin", SqlDbType.VarChar,20),
					new SqlParameter("@backcabin", SqlDbType.VarChar,20),
					new SqlParameter("@one_startdate", SqlDbType.Date,3),
					new SqlParameter("@one_enddate", SqlDbType.Date,3),
					new SqlParameter("@two_startdate", SqlDbType.Date,3),
					new SqlParameter("@two_enddate", SqlDbType.Date,3),
					new SqlParameter("@short_stoptime", SqlDbType.Int,4),
					new SqlParameter("@long_stoptime", SqlDbType.Int,4),
					new SqlParameter("@costtype", SqlDbType.VarChar,100),
					new SqlParameter("@costPrice", SqlDbType.Float,8),
					new SqlParameter("@proxyPrice", SqlDbType.Float,8),
					new SqlParameter("@backPrice", SqlDbType.Float,8),
					new SqlParameter("@policySource", SqlDbType.VarChar,50),
					new SqlParameter("@xcd", SqlDbType.NVarChar,50),
					new SqlParameter("@returnRule", SqlDbType.VarChar,50),
					new SqlParameter("@changeRule", SqlDbType.VarChar,50),
					new SqlParameter("@endorsement", SqlDbType.Bit,1),
					new SqlParameter("@flyerpoints", SqlDbType.Bit,1),
					new SqlParameter("@cardType", SqlDbType.Int,4),
					new SqlParameter("@maxAge", SqlDbType.Int,4),
					new SqlParameter("@minAge", SqlDbType.Int,4),
					new SqlParameter("@sys_id", SqlDbType.Int,4),
					new SqlParameter("@uploadPolicyType", SqlDbType.VarChar,50),
					new SqlParameter("@earliestBeforeValidDay", SqlDbType.Int,4),
					new SqlParameter("@isUpload", SqlDbType.Int,4),
					new SqlParameter("@importTime", SqlDbType.Date,3),
					new SqlParameter("@uploadPlat", SqlDbType.VarChar,255),
					new SqlParameter("@uploadResult", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.flightcode;
			parameters[1].Value = model.policyCode;
			parameters[2].Value = model.dpt;
			parameters[3].Value = model.arr;
			parameters[4].Value = model.flightNumLimit;
			parameters[5].Value = model.flightcondition;
			parameters[6].Value = model.daycondition;
			parameters[7].Value = model.cabin;
			parameters[8].Value = model.discountType;
			parameters[9].Value = model.discountValue;
			parameters[10].Value = model.returnpoint;
			parameters[11].Value = model.returnprice;
			parameters[12].Value = model.startdate_ticket;
			parameters[13].Value = model.enfdate_ticket;
			parameters[14].Value = model.startdate;
			parameters[15].Value = model.enddate;
			parameters[16].Value = model.beforeValidDay;
			parameters[17].Value = model.backnote;
			parameters[18].Value = model.cabinnote;
			parameters[19].Value = model.autoTicket;
			parameters[20].Value = model.shared;
			parameters[21].Value = model.officeno;
			parameters[22].Value = model.ktype;
			parameters[23].Value = model.checkCycleTime;
			parameters[24].Value = model.autoCheckOverTime;
			parameters[25].Value = model.manualCheckOverTime;
			parameters[26].Value = model.policy;
			parameters[27].Value = model.downDiscount;
			parameters[28].Value = model.pata;
			parameters[29].Value = model.specialRule;
			parameters[30].Value = model.allCabin;
			parameters[31].Value = model.canPay;
			parameters[32].Value = model.deptTimeSlot;
			parameters[33].Value = model.needPnr;
			parameters[34].Value = model.one_flightlimit;
			parameters[35].Value = model.one_limitnum;
			parameters[36].Value = model.two_flightlimit;
			parameters[37].Value = model.two_limitnum;
			parameters[38].Value = model.one_daylimit;
			parameters[39].Value = model.two_daylimit;
			parameters[40].Value = model.gocabin;
			parameters[41].Value = model.backcabin;
			parameters[42].Value = model.one_startdate;
			parameters[43].Value = model.one_enddate;
			parameters[44].Value = model.two_startdate;
			parameters[45].Value = model.two_enddate;
			parameters[46].Value = model.short_stoptime;
			parameters[47].Value = model.long_stoptime;
			parameters[48].Value = model.costtype;
			parameters[49].Value = model.costPrice;
			parameters[50].Value = model.proxyPrice;
			parameters[51].Value = model.backPrice;
			parameters[52].Value = model.policySource;
			parameters[53].Value = model.xcd;
			parameters[54].Value = model.returnRule;
			parameters[55].Value = model.changeRule;
			parameters[56].Value = model.endorsement;
			parameters[57].Value = model.flyerpoints;
			parameters[58].Value = model.cardType;
			parameters[59].Value = model.maxAge;
			parameters[60].Value = model.minAge;
			parameters[61].Value = model.sys_id;
			parameters[62].Value = model.uploadPolicyType;
			parameters[63].Value = model.earliestBeforeValidDay;
			parameters[64].Value = model.isUpload;
			parameters[65].Value = model.importTime;
			parameters[66].Value = model.uploadPlat;
			parameters[67].Value = model.uploadResult;
			parameters[68].Value = model.id;

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
			strSql.Append("delete from Policy ");
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
			strSql.Append("delete from Policy ");
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
		public Sanben.Model.Policy GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,flightcode,policyCode,dpt,arr,flightNumLimit,flightcondition,daycondition,cabin,discountType,discountValue,returnpoint,returnprice,startdate_ticket,enfdate_ticket,startdate,enddate,beforeValidDay,backnote,cabinnote,autoTicket,shared,officeno,ktype,checkCycleTime,autoCheckOverTime,manualCheckOverTime,policy,downDiscount,pata,specialRule,allCabin,canPay,deptTimeSlot,needPnr,one_flightlimit,one_limitnum,two_flightlimit,two_limitnum,one_daylimit,two_daylimit,gocabin,backcabin,one_startdate,one_enddate,two_startdate,two_enddate,short_stoptime,long_stoptime,costtype,costPrice,proxyPrice,backPrice,policySource,xcd,returnRule,changeRule,endorsement,flyerpoints,cardType,maxAge,minAge,sys_id,uploadPolicyType,earliestBeforeValidDay,isUpload,importTime,uploadPlat,uploadResult from Policy ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Sanben.Model.Policy model=new Sanben.Model.Policy();
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
		public Sanben.Model.Policy DataRowToModel(DataRow row)
		{
			Sanben.Model.Policy model=new Sanben.Model.Policy();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["flightcode"]!=null)
				{
					model.flightcode=row["flightcode"].ToString();
				}
				if(row["policyCode"]!=null)
				{
					model.policyCode=row["policyCode"].ToString();
				}
				if(row["dpt"]!=null)
				{
					model.dpt=row["dpt"].ToString();
				}
				if(row["arr"]!=null)
				{
					model.arr=row["arr"].ToString();
				}
				if(row["flightNumLimit"]!=null)
				{
					model.flightNumLimit=row["flightNumLimit"].ToString();
				}
				if(row["flightcondition"]!=null)
				{
					model.flightcondition=row["flightcondition"].ToString();
				}
				if(row["daycondition"]!=null)
				{
					model.daycondition=row["daycondition"].ToString();
				}
				if(row["cabin"]!=null)
				{
					model.cabin=row["cabin"].ToString();
				}
				if(row["discountType"]!=null)
				{
					model.discountType=row["discountType"].ToString();
				}
				if(row["discountValue"]!=null)
				{
					model.discountValue=row["discountValue"].ToString();
				}
				if(row["returnpoint"]!=null && row["returnpoint"].ToString()!="")
				{
					model.returnpoint=decimal.Parse(row["returnpoint"].ToString());
				}
				if(row["returnprice"]!=null && row["returnprice"].ToString()!="")
				{
					model.returnprice=int.Parse(row["returnprice"].ToString());
				}
				if(row["startdate_ticket"]!=null && row["startdate_ticket"].ToString()!="")
				{
					model.startdate_ticket=DateTime.Parse(row["startdate_ticket"].ToString());
				}
				if(row["enfdate_ticket"]!=null && row["enfdate_ticket"].ToString()!="")
				{
					model.enfdate_ticket=DateTime.Parse(row["enfdate_ticket"].ToString());
				}
				if(row["startdate"]!=null && row["startdate"].ToString()!="")
				{
					model.startdate=DateTime.Parse(row["startdate"].ToString());
				}
				if(row["enddate"]!=null && row["enddate"].ToString()!="")
				{
					model.enddate=DateTime.Parse(row["enddate"].ToString());
				}
				if(row["beforeValidDay"]!=null && row["beforeValidDay"].ToString()!="")
				{
					model.beforeValidDay=int.Parse(row["beforeValidDay"].ToString());
				}
				if(row["backnote"]!=null)
				{
					model.backnote=row["backnote"].ToString();
				}
				if(row["cabinnote"]!=null)
				{
					model.cabinnote=row["cabinnote"].ToString();
				}
				if(row["autoTicket"]!=null && row["autoTicket"].ToString()!="")
				{
					if((row["autoTicket"].ToString()=="1")||(row["autoTicket"].ToString().ToLower()=="true"))
					{
						model.autoTicket=true;
					}
					else
					{
						model.autoTicket=false;
					}
				}
				if(row["shared"]!=null && row["shared"].ToString()!="")
				{
					if((row["shared"].ToString()=="1")||(row["shared"].ToString().ToLower()=="true"))
					{
						model.shared=true;
					}
					else
					{
						model.shared=false;
					}
				}
				if(row["officeno"]!=null)
				{
					model.officeno=row["officeno"].ToString();
				}
				if(row["ktype"]!=null)
				{
					model.ktype=row["ktype"].ToString();
				}
				if(row["checkCycleTime"]!=null && row["checkCycleTime"].ToString()!="")
				{
					model.checkCycleTime=int.Parse(row["checkCycleTime"].ToString());
				}
				if(row["autoCheckOverTime"]!=null && row["autoCheckOverTime"].ToString()!="")
				{
					model.autoCheckOverTime=int.Parse(row["autoCheckOverTime"].ToString());
				}
				if(row["manualCheckOverTime"]!=null && row["manualCheckOverTime"].ToString()!="")
				{
					model.manualCheckOverTime=int.Parse(row["manualCheckOverTime"].ToString());
				}
				if(row["policy"]!=null)
				{
					model.policy=row["policy"].ToString();
				}
				if(row["downDiscount"]!=null && row["downDiscount"].ToString()!="")
				{
					model.downDiscount=decimal.Parse(row["downDiscount"].ToString());
				}
				if(row["pata"]!=null && row["pata"].ToString()!="")
				{
					if((row["pata"].ToString()=="1")||(row["pata"].ToString().ToLower()=="true"))
					{
						model.pata=true;
					}
					else
					{
						model.pata=false;
					}
				}
				if(row["specialRule"]!=null)
				{
					model.specialRule=row["specialRule"].ToString();
				}
				if(row["allCabin"]!=null && row["allCabin"].ToString()!="")
				{
					model.allCabin=int.Parse(row["allCabin"].ToString());
				}
				if(row["canPay"]!=null && row["canPay"].ToString()!="")
				{
					if((row["canPay"].ToString()=="1")||(row["canPay"].ToString().ToLower()=="true"))
					{
						model.canPay=true;
					}
					else
					{
						model.canPay=false;
					}
				}
				if(row["deptTimeSlot"]!=null)
				{
					model.deptTimeSlot=row["deptTimeSlot"].ToString();
				}
				if(row["needPnr"]!=null && row["needPnr"].ToString()!="")
				{
					if((row["needPnr"].ToString()=="1")||(row["needPnr"].ToString().ToLower()=="true"))
					{
						model.needPnr=true;
					}
					else
					{
						model.needPnr=false;
					}
				}
				if(row["one_flightlimit"]!=null)
				{
					model.one_flightlimit=row["one_flightlimit"].ToString();
				}
				if(row["one_limitnum"]!=null)
				{
					model.one_limitnum=row["one_limitnum"].ToString();
				}
				if(row["two_flightlimit"]!=null)
				{
					model.two_flightlimit=row["two_flightlimit"].ToString();
				}
				if(row["two_limitnum"]!=null)
				{
					model.two_limitnum=row["two_limitnum"].ToString();
				}
				if(row["one_daylimit"]!=null)
				{
					model.one_daylimit=row["one_daylimit"].ToString();
				}
				if(row["two_daylimit"]!=null)
				{
					model.two_daylimit=row["two_daylimit"].ToString();
				}
				if(row["gocabin"]!=null)
				{
					model.gocabin=row["gocabin"].ToString();
				}
				if(row["backcabin"]!=null)
				{
					model.backcabin=row["backcabin"].ToString();
				}
				if(row["one_startdate"]!=null && row["one_startdate"].ToString()!="")
				{
					model.one_startdate=DateTime.Parse(row["one_startdate"].ToString());
				}
				if(row["one_enddate"]!=null && row["one_enddate"].ToString()!="")
				{
					model.one_enddate=DateTime.Parse(row["one_enddate"].ToString());
				}
				if(row["two_startdate"]!=null && row["two_startdate"].ToString()!="")
				{
					model.two_startdate=DateTime.Parse(row["two_startdate"].ToString());
				}
				if(row["two_enddate"]!=null && row["two_enddate"].ToString()!="")
				{
					model.two_enddate=DateTime.Parse(row["two_enddate"].ToString());
				}
				if(row["short_stoptime"]!=null && row["short_stoptime"].ToString()!="")
				{
					model.short_stoptime=int.Parse(row["short_stoptime"].ToString());
				}
				if(row["long_stoptime"]!=null && row["long_stoptime"].ToString()!="")
				{
					model.long_stoptime=int.Parse(row["long_stoptime"].ToString());
				}
				if(row["costtype"]!=null)
				{
					model.costtype=row["costtype"].ToString();
				}
				if(row["costPrice"]!=null && row["costPrice"].ToString()!="")
				{
					model.costPrice=decimal.Parse(row["costPrice"].ToString());
				}
				if(row["proxyPrice"]!=null && row["proxyPrice"].ToString()!="")
				{
					model.proxyPrice=decimal.Parse(row["proxyPrice"].ToString());
				}
				if(row["backPrice"]!=null && row["backPrice"].ToString()!="")
				{
					model.backPrice=decimal.Parse(row["backPrice"].ToString());
				}
				if(row["policySource"]!=null)
				{
					model.policySource=row["policySource"].ToString();
				}
				if(row["xcd"]!=null)
				{
					model.xcd=row["xcd"].ToString();
				}
				if(row["returnRule"]!=null)
				{
					model.returnRule=row["returnRule"].ToString();
				}
				if(row["changeRule"]!=null)
				{
					model.changeRule=row["changeRule"].ToString();
				}
				if(row["endorsement"]!=null && row["endorsement"].ToString()!="")
				{
					if((row["endorsement"].ToString()=="1")||(row["endorsement"].ToString().ToLower()=="true"))
					{
						model.endorsement=true;
					}
					else
					{
						model.endorsement=false;
					}
				}
				if(row["flyerpoints"]!=null && row["flyerpoints"].ToString()!="")
				{
					if((row["flyerpoints"].ToString()=="1")||(row["flyerpoints"].ToString().ToLower()=="true"))
					{
						model.flyerpoints=true;
					}
					else
					{
						model.flyerpoints=false;
					}
				}
				if(row["cardType"]!=null && row["cardType"].ToString()!="")
				{
					model.cardType=int.Parse(row["cardType"].ToString());
				}
				if(row["maxAge"]!=null && row["maxAge"].ToString()!="")
				{
					model.maxAge=int.Parse(row["maxAge"].ToString());
				}
				if(row["minAge"]!=null && row["minAge"].ToString()!="")
				{
					model.minAge=int.Parse(row["minAge"].ToString());
				}
				if(row["sys_id"]!=null && row["sys_id"].ToString()!="")
				{
					model.sys_id=int.Parse(row["sys_id"].ToString());
				}
				if(row["uploadPolicyType"]!=null)
				{
					model.uploadPolicyType=row["uploadPolicyType"].ToString();
				}
				if(row["earliestBeforeValidDay"]!=null && row["earliestBeforeValidDay"].ToString()!="")
				{
					model.earliestBeforeValidDay=int.Parse(row["earliestBeforeValidDay"].ToString());
				}
				if(row["isUpload"]!=null && row["isUpload"].ToString()!="")
				{
					model.isUpload=int.Parse(row["isUpload"].ToString());
				}
				if(row["importTime"]!=null && row["importTime"].ToString()!="")
				{
					model.importTime=DateTime.Parse(row["importTime"].ToString());
				}
				if(row["uploadPlat"]!=null)
				{
					model.uploadPlat=row["uploadPlat"].ToString();
				}
				if(row["uploadResult"]!=null && row["uploadResult"].ToString()!="")
				{
					model.uploadResult=int.Parse(row["uploadResult"].ToString());
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
			strSql.Append("select id,flightcode,policyCode,dpt,arr,flightNumLimit,flightcondition,daycondition,cabin,discountType,discountValue,returnpoint,returnprice,startdate_ticket,enfdate_ticket,startdate,enddate,beforeValidDay,backnote,cabinnote,autoTicket,shared,officeno,ktype,checkCycleTime,autoCheckOverTime,manualCheckOverTime,policy,downDiscount,pata,specialRule,allCabin,canPay,deptTimeSlot,needPnr,one_flightlimit,one_limitnum,two_flightlimit,two_limitnum,one_daylimit,two_daylimit,gocabin,backcabin,one_startdate,one_enddate,two_startdate,two_enddate,short_stoptime,long_stoptime,costtype,costPrice,proxyPrice,backPrice,policySource,xcd,returnRule,changeRule,endorsement,flyerpoints,cardType,maxAge,minAge,sys_id,uploadPolicyType,earliestBeforeValidDay,isUpload,importTime,uploadPlat,uploadResult ");
			strSql.Append(" FROM Policy ");
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
			strSql.Append(" id,flightcode,policyCode,dpt,arr,flightNumLimit,flightcondition,daycondition,cabin,discountType,discountValue,returnpoint,returnprice,startdate_ticket,enfdate_ticket,startdate,enddate,beforeValidDay,backnote,cabinnote,autoTicket,shared,officeno,ktype,checkCycleTime,autoCheckOverTime,manualCheckOverTime,policy,downDiscount,pata,specialRule,allCabin,canPay,deptTimeSlot,needPnr,one_flightlimit,one_limitnum,two_flightlimit,two_limitnum,one_daylimit,two_daylimit,gocabin,backcabin,one_startdate,one_enddate,two_startdate,two_enddate,short_stoptime,long_stoptime,costtype,costPrice,proxyPrice,backPrice,policySource,xcd,returnRule,changeRule,endorsement,flyerpoints,cardType,maxAge,minAge,sys_id,uploadPolicyType,earliestBeforeValidDay,isUpload,importTime,uploadPlat,uploadResult ");
			strSql.Append(" FROM Policy ");
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
			strSql.Append("select count(1) FROM Policy ");
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
			strSql.Append(")AS Row, T.*  from Policy T ");
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
			parameters[0].Value = "Policy";
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

