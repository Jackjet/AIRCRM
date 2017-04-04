using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:Jinri_Order_Response
	/// </summary>
	public partial class Jinri_Order_Response:IJinri_Order_Response
	{
		public Jinri_Order_Response()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "Jinri_Order_Response"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Jinri_Order_Response");
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
		public int Add(Sanben.Model.Jinri_Order_Response model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Jinri_Order_Response(");
			strSql.Append("OrderNo,PNR,GrowDiscount,StayDiscount,PayMoney,Profit,Status,Date,Scity,Ecity,Flight,Stime,Etime,Cabin,Price,Tax,PCount,PName,PCard,JouneryInfo,IsBuyInsurance,remark,ticket_no,refund_type,amount,pay_type,trade_no,pay_time,OrderInfo_id,platformB2B_name_id)");
			strSql.Append(" values (");
			strSql.Append("@OrderNo,@PNR,@GrowDiscount,@StayDiscount,@PayMoney,@Profit,@Status,@Date,@Scity,@Ecity,@Flight,@Stime,@Etime,@Cabin,@Price,@Tax,@PCount,@PName,@PCard,@JouneryInfo,@IsBuyInsurance,@remark,@ticket_no,@refund_type,@amount,@pay_type,@trade_no,@pay_time,@OrderInfo_id,@platformB2B_name_id)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@PNR", SqlDbType.VarChar,50),
					new SqlParameter("@GrowDiscount", SqlDbType.VarChar,50),
					new SqlParameter("@StayDiscount", SqlDbType.VarChar,50),
					new SqlParameter("@PayMoney", SqlDbType.VarChar,50),
					new SqlParameter("@Profit", SqlDbType.VarChar,50),
					new SqlParameter("@Status", SqlDbType.VarChar,50),
					new SqlParameter("@Date", SqlDbType.VarChar,50),
					new SqlParameter("@Scity", SqlDbType.VarChar,50),
					new SqlParameter("@Ecity", SqlDbType.VarChar,50),
					new SqlParameter("@Flight", SqlDbType.VarChar,50),
					new SqlParameter("@Stime", SqlDbType.VarChar,50),
					new SqlParameter("@Etime", SqlDbType.VarChar,50),
					new SqlParameter("@Cabin", SqlDbType.VarChar,50),
					new SqlParameter("@Price", SqlDbType.Float,8),
					new SqlParameter("@Tax", SqlDbType.Float,8),
					new SqlParameter("@PCount", SqlDbType.Int,4),
					new SqlParameter("@PName", SqlDbType.VarChar,50),
					new SqlParameter("@PCard", SqlDbType.VarChar,50),
					new SqlParameter("@JouneryInfo", SqlDbType.VarChar,50),
					new SqlParameter("@IsBuyInsurance", SqlDbType.VarChar,50),
					new SqlParameter("@remark", SqlDbType.VarChar,50),
					new SqlParameter("@ticket_no", SqlDbType.VarChar,50),
					new SqlParameter("@refund_type", SqlDbType.Int,4),
					new SqlParameter("@amount", SqlDbType.Float,8),
					new SqlParameter("@pay_type", SqlDbType.VarChar,50),
					new SqlParameter("@trade_no", SqlDbType.VarChar,50),
					new SqlParameter("@pay_time", SqlDbType.VarChar,50),
					new SqlParameter("@OrderInfo_id", SqlDbType.Int,4),
					new SqlParameter("@platformB2B_name_id", SqlDbType.Int,4)};
			parameters[0].Value = model.OrderNo;
			parameters[1].Value = model.PNR;
			parameters[2].Value = model.GrowDiscount;
			parameters[3].Value = model.StayDiscount;
			parameters[4].Value = model.PayMoney;
			parameters[5].Value = model.Profit;
			parameters[6].Value = model.Status;
			parameters[7].Value = model.Date;
			parameters[8].Value = model.Scity;
			parameters[9].Value = model.Ecity;
			parameters[10].Value = model.Flight;
			parameters[11].Value = model.Stime;
			parameters[12].Value = model.Etime;
			parameters[13].Value = model.Cabin;
			parameters[14].Value = model.Price;
			parameters[15].Value = model.Tax;
			parameters[16].Value = model.PCount;
			parameters[17].Value = model.PName;
			parameters[18].Value = model.PCard;
			parameters[19].Value = model.JouneryInfo;
			parameters[20].Value = model.IsBuyInsurance;
			parameters[21].Value = model.remark;
			parameters[22].Value = model.ticket_no;
			parameters[23].Value = model.refund_type;
			parameters[24].Value = model.amount;
			parameters[25].Value = model.pay_type;
			parameters[26].Value = model.trade_no;
			parameters[27].Value = model.pay_time;
			parameters[28].Value = model.OrderInfo_id;
			parameters[29].Value = model.platformB2B_name_id;

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
		public bool Update(Sanben.Model.Jinri_Order_Response model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Jinri_Order_Response set ");
			strSql.Append("OrderNo=@OrderNo,");
			strSql.Append("PNR=@PNR,");
			strSql.Append("GrowDiscount=@GrowDiscount,");
			strSql.Append("StayDiscount=@StayDiscount,");
			strSql.Append("PayMoney=@PayMoney,");
			strSql.Append("Profit=@Profit,");
			strSql.Append("Status=@Status,");
			strSql.Append("Date=@Date,");
			strSql.Append("Scity=@Scity,");
			strSql.Append("Ecity=@Ecity,");
			strSql.Append("Flight=@Flight,");
			strSql.Append("Stime=@Stime,");
			strSql.Append("Etime=@Etime,");
			strSql.Append("Cabin=@Cabin,");
			strSql.Append("Price=@Price,");
			strSql.Append("Tax=@Tax,");
			strSql.Append("PCount=@PCount,");
			strSql.Append("PName=@PName,");
			strSql.Append("PCard=@PCard,");
			strSql.Append("JouneryInfo=@JouneryInfo,");
			strSql.Append("IsBuyInsurance=@IsBuyInsurance,");
			strSql.Append("remark=@remark,");
			strSql.Append("ticket_no=@ticket_no,");
			strSql.Append("refund_type=@refund_type,");
			strSql.Append("amount=@amount,");
			strSql.Append("pay_type=@pay_type,");
			strSql.Append("trade_no=@trade_no,");
			strSql.Append("pay_time=@pay_time,");
			strSql.Append("OrderInfo_id=@OrderInfo_id,");
			strSql.Append("platformB2B_name_id=@platformB2B_name_id");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@OrderNo", SqlDbType.VarChar,50),
					new SqlParameter("@PNR", SqlDbType.VarChar,50),
					new SqlParameter("@GrowDiscount", SqlDbType.VarChar,50),
					new SqlParameter("@StayDiscount", SqlDbType.VarChar,50),
					new SqlParameter("@PayMoney", SqlDbType.VarChar,50),
					new SqlParameter("@Profit", SqlDbType.VarChar,50),
					new SqlParameter("@Status", SqlDbType.VarChar,50),
					new SqlParameter("@Date", SqlDbType.VarChar,50),
					new SqlParameter("@Scity", SqlDbType.VarChar,50),
					new SqlParameter("@Ecity", SqlDbType.VarChar,50),
					new SqlParameter("@Flight", SqlDbType.VarChar,50),
					new SqlParameter("@Stime", SqlDbType.VarChar,50),
					new SqlParameter("@Etime", SqlDbType.VarChar,50),
					new SqlParameter("@Cabin", SqlDbType.VarChar,50),
					new SqlParameter("@Price", SqlDbType.Float,8),
					new SqlParameter("@Tax", SqlDbType.Float,8),
					new SqlParameter("@PCount", SqlDbType.Int,4),
					new SqlParameter("@PName", SqlDbType.VarChar,50),
					new SqlParameter("@PCard", SqlDbType.VarChar,50),
					new SqlParameter("@JouneryInfo", SqlDbType.VarChar,50),
					new SqlParameter("@IsBuyInsurance", SqlDbType.VarChar,50),
					new SqlParameter("@remark", SqlDbType.VarChar,50),
					new SqlParameter("@ticket_no", SqlDbType.VarChar,50),
					new SqlParameter("@refund_type", SqlDbType.Int,4),
					new SqlParameter("@amount", SqlDbType.Float,8),
					new SqlParameter("@pay_type", SqlDbType.VarChar,50),
					new SqlParameter("@trade_no", SqlDbType.VarChar,50),
					new SqlParameter("@pay_time", SqlDbType.VarChar,50),
					new SqlParameter("@OrderInfo_id", SqlDbType.Int,4),
					new SqlParameter("@platformB2B_name_id", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.OrderNo;
			parameters[1].Value = model.PNR;
			parameters[2].Value = model.GrowDiscount;
			parameters[3].Value = model.StayDiscount;
			parameters[4].Value = model.PayMoney;
			parameters[5].Value = model.Profit;
			parameters[6].Value = model.Status;
			parameters[7].Value = model.Date;
			parameters[8].Value = model.Scity;
			parameters[9].Value = model.Ecity;
			parameters[10].Value = model.Flight;
			parameters[11].Value = model.Stime;
			parameters[12].Value = model.Etime;
			parameters[13].Value = model.Cabin;
			parameters[14].Value = model.Price;
			parameters[15].Value = model.Tax;
			parameters[16].Value = model.PCount;
			parameters[17].Value = model.PName;
			parameters[18].Value = model.PCard;
			parameters[19].Value = model.JouneryInfo;
			parameters[20].Value = model.IsBuyInsurance;
			parameters[21].Value = model.remark;
			parameters[22].Value = model.ticket_no;
			parameters[23].Value = model.refund_type;
			parameters[24].Value = model.amount;
			parameters[25].Value = model.pay_type;
			parameters[26].Value = model.trade_no;
			parameters[27].Value = model.pay_time;
			parameters[28].Value = model.OrderInfo_id;
			parameters[29].Value = model.platformB2B_name_id;
			parameters[30].Value = model.id;

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
			strSql.Append("delete from Jinri_Order_Response ");
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
			strSql.Append("delete from Jinri_Order_Response ");
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
		public Sanben.Model.Jinri_Order_Response GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,OrderNo,PNR,GrowDiscount,StayDiscount,PayMoney,Profit,Status,Date,Scity,Ecity,Flight,Stime,Etime,Cabin,Price,Tax,PCount,PName,PCard,JouneryInfo,IsBuyInsurance,remark,ticket_no,refund_type,amount,pay_type,trade_no,pay_time,OrderInfo_id,platformB2B_name_id from Jinri_Order_Response ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Sanben.Model.Jinri_Order_Response model=new Sanben.Model.Jinri_Order_Response();
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
		public Sanben.Model.Jinri_Order_Response DataRowToModel(DataRow row)
		{
			Sanben.Model.Jinri_Order_Response model=new Sanben.Model.Jinri_Order_Response();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["OrderNo"]!=null)
				{
					model.OrderNo=row["OrderNo"].ToString();
				}
				if(row["PNR"]!=null)
				{
					model.PNR=row["PNR"].ToString();
				}
				if(row["GrowDiscount"]!=null)
				{
					model.GrowDiscount=row["GrowDiscount"].ToString();
				}
				if(row["StayDiscount"]!=null)
				{
					model.StayDiscount=row["StayDiscount"].ToString();
				}
				if(row["PayMoney"]!=null)
				{
					model.PayMoney=row["PayMoney"].ToString();
				}
				if(row["Profit"]!=null)
				{
					model.Profit=row["Profit"].ToString();
				}
				if(row["Status"]!=null)
				{
					model.Status=row["Status"].ToString();
				}
				if(row["Date"]!=null)
				{
					model.Date=row["Date"].ToString();
				}
				if(row["Scity"]!=null)
				{
					model.Scity=row["Scity"].ToString();
				}
				if(row["Ecity"]!=null)
				{
					model.Ecity=row["Ecity"].ToString();
				}
				if(row["Flight"]!=null)
				{
					model.Flight=row["Flight"].ToString();
				}
				if(row["Stime"]!=null)
				{
					model.Stime=row["Stime"].ToString();
				}
				if(row["Etime"]!=null)
				{
					model.Etime=row["Etime"].ToString();
				}
				if(row["Cabin"]!=null)
				{
					model.Cabin=row["Cabin"].ToString();
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["Tax"]!=null && row["Tax"].ToString()!="")
				{
					model.Tax=decimal.Parse(row["Tax"].ToString());
				}
				if(row["PCount"]!=null && row["PCount"].ToString()!="")
				{
					model.PCount=int.Parse(row["PCount"].ToString());
				}
				if(row["PName"]!=null)
				{
					model.PName=row["PName"].ToString();
				}
				if(row["PCard"]!=null)
				{
					model.PCard=row["PCard"].ToString();
				}
				if(row["JouneryInfo"]!=null)
				{
					model.JouneryInfo=row["JouneryInfo"].ToString();
				}
				if(row["IsBuyInsurance"]!=null)
				{
					model.IsBuyInsurance=row["IsBuyInsurance"].ToString();
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["ticket_no"]!=null)
				{
					model.ticket_no=row["ticket_no"].ToString();
				}
				if(row["refund_type"]!=null && row["refund_type"].ToString()!="")
				{
					model.refund_type=int.Parse(row["refund_type"].ToString());
				}
				if(row["amount"]!=null && row["amount"].ToString()!="")
				{
					model.amount=decimal.Parse(row["amount"].ToString());
				}
				if(row["pay_type"]!=null)
				{
					model.pay_type=row["pay_type"].ToString();
				}
				if(row["trade_no"]!=null)
				{
					model.trade_no=row["trade_no"].ToString();
				}
				if(row["pay_time"]!=null)
				{
					model.pay_time=row["pay_time"].ToString();
				}
				if(row["OrderInfo_id"]!=null && row["OrderInfo_id"].ToString()!="")
				{
					model.OrderInfo_id=int.Parse(row["OrderInfo_id"].ToString());
				}
				if(row["platformB2B_name_id"]!=null && row["platformB2B_name_id"].ToString()!="")
				{
					model.platformB2B_name_id=int.Parse(row["platformB2B_name_id"].ToString());
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
			strSql.Append("select id,OrderNo,PNR,GrowDiscount,StayDiscount,PayMoney,Profit,Status,Date,Scity,Ecity,Flight,Stime,Etime,Cabin,Price,Tax,PCount,PName,PCard,JouneryInfo,IsBuyInsurance,remark,ticket_no,refund_type,amount,pay_type,trade_no,pay_time,OrderInfo_id,platformB2B_name_id ");
			strSql.Append(" FROM Jinri_Order_Response ");
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
			strSql.Append(" id,OrderNo,PNR,GrowDiscount,StayDiscount,PayMoney,Profit,Status,Date,Scity,Ecity,Flight,Stime,Etime,Cabin,Price,Tax,PCount,PName,PCard,JouneryInfo,IsBuyInsurance,remark,ticket_no,refund_type,amount,pay_type,trade_no,pay_time,OrderInfo_id,platformB2B_name_id ");
			strSql.Append(" FROM Jinri_Order_Response ");
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
			strSql.Append("select count(1) FROM Jinri_Order_Response ");
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
			strSql.Append(")AS Row, T.*  from Jinri_Order_Response T ");
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
			parameters[0].Value = "Jinri_Order_Response";
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

