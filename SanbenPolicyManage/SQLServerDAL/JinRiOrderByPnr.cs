using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:JinRiOrderByPnr
	/// </summary>
	public partial class JinRiOrderByPnr:IJinRiOrderByPnr
	{
		public JinRiOrderByPnr()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "JinRiOrderByPnr"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from JinRiOrderByPnr");
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
		public int Add(Sanben.Model.JinRiOrderByPnr model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into JinRiOrderByPnr(");
			strSql.Append("orderNo,pnr,growDiscount,stayDiscount,payMoney,profit,status,date,scity,ecity,flight,stime,etime,cabin,price,tax,pcount,pName,pCard,jouneryInfo,isBuyInsurance,orderinfo_id)");
			strSql.Append(" values (");
			strSql.Append("@orderNo,@pnr,@growDiscount,@stayDiscount,@payMoney,@profit,@status,@date,@scity,@ecity,@flight,@stime,@etime,@cabin,@price,@tax,@pcount,@pName,@pCard,@jouneryInfo,@isBuyInsurance,@orderinfo_id)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@orderNo", SqlDbType.VarChar,50),
					new SqlParameter("@pnr", SqlDbType.VarChar,50),
					new SqlParameter("@growDiscount", SqlDbType.Float,8),
					new SqlParameter("@stayDiscount", SqlDbType.Float,8),
					new SqlParameter("@payMoney", SqlDbType.Float,8),
					new SqlParameter("@profit", SqlDbType.Float,8),
					new SqlParameter("@status", SqlDbType.Int,4),
					new SqlParameter("@date", SqlDbType.VarChar,50),
					new SqlParameter("@scity", SqlDbType.VarChar,50),
					new SqlParameter("@ecity", SqlDbType.VarChar,50),
					new SqlParameter("@flight", SqlDbType.VarChar,50),
					new SqlParameter("@stime", SqlDbType.VarChar,50),
					new SqlParameter("@etime", SqlDbType.VarChar,50),
					new SqlParameter("@cabin", SqlDbType.VarChar,50),
					new SqlParameter("@price", SqlDbType.Float,8),
					new SqlParameter("@tax", SqlDbType.Float,8),
					new SqlParameter("@pcount", SqlDbType.Int,4),
					new SqlParameter("@pName", SqlDbType.VarChar,50),
					new SqlParameter("@pCard", SqlDbType.VarChar,50),
					new SqlParameter("@jouneryInfo", SqlDbType.VarChar,50),
					new SqlParameter("@isBuyInsurance", SqlDbType.VarChar,50),
					new SqlParameter("@orderinfo_id", SqlDbType.Int,4)};
			parameters[0].Value = model.orderNo;
			parameters[1].Value = model.pnr;
			parameters[2].Value = model.growDiscount;
			parameters[3].Value = model.stayDiscount;
			parameters[4].Value = model.payMoney;
			parameters[5].Value = model.profit;
			parameters[6].Value = model.status;
			parameters[7].Value = model.date;
			parameters[8].Value = model.scity;
			parameters[9].Value = model.ecity;
			parameters[10].Value = model.flight;
			parameters[11].Value = model.stime;
			parameters[12].Value = model.etime;
			parameters[13].Value = model.cabin;
			parameters[14].Value = model.price;
			parameters[15].Value = model.tax;
			parameters[16].Value = model.pcount;
			parameters[17].Value = model.pName;
			parameters[18].Value = model.pCard;
			parameters[19].Value = model.jouneryInfo;
			parameters[20].Value = model.isBuyInsurance;
			parameters[21].Value = model.orderinfo_id;

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
		public bool Update(Sanben.Model.JinRiOrderByPnr model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update JinRiOrderByPnr set ");
			strSql.Append("orderNo=@orderNo,");
			strSql.Append("pnr=@pnr,");
			strSql.Append("growDiscount=@growDiscount,");
			strSql.Append("stayDiscount=@stayDiscount,");
			strSql.Append("payMoney=@payMoney,");
			strSql.Append("profit=@profit,");
			strSql.Append("status=@status,");
			strSql.Append("date=@date,");
			strSql.Append("scity=@scity,");
			strSql.Append("ecity=@ecity,");
			strSql.Append("flight=@flight,");
			strSql.Append("stime=@stime,");
			strSql.Append("etime=@etime,");
			strSql.Append("cabin=@cabin,");
			strSql.Append("price=@price,");
			strSql.Append("tax=@tax,");
			strSql.Append("pcount=@pcount,");
			strSql.Append("pName=@pName,");
			strSql.Append("pCard=@pCard,");
			strSql.Append("jouneryInfo=@jouneryInfo,");
			strSql.Append("isBuyInsurance=@isBuyInsurance,");
			strSql.Append("orderinfo_id=@orderinfo_id");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@orderNo", SqlDbType.VarChar,50),
					new SqlParameter("@pnr", SqlDbType.VarChar,50),
					new SqlParameter("@growDiscount", SqlDbType.Float,8),
					new SqlParameter("@stayDiscount", SqlDbType.Float,8),
					new SqlParameter("@payMoney", SqlDbType.Float,8),
					new SqlParameter("@profit", SqlDbType.Float,8),
					new SqlParameter("@status", SqlDbType.Int,4),
					new SqlParameter("@date", SqlDbType.VarChar,50),
					new SqlParameter("@scity", SqlDbType.VarChar,50),
					new SqlParameter("@ecity", SqlDbType.VarChar,50),
					new SqlParameter("@flight", SqlDbType.VarChar,50),
					new SqlParameter("@stime", SqlDbType.VarChar,50),
					new SqlParameter("@etime", SqlDbType.VarChar,50),
					new SqlParameter("@cabin", SqlDbType.VarChar,50),
					new SqlParameter("@price", SqlDbType.Float,8),
					new SqlParameter("@tax", SqlDbType.Float,8),
					new SqlParameter("@pcount", SqlDbType.Int,4),
					new SqlParameter("@pName", SqlDbType.VarChar,50),
					new SqlParameter("@pCard", SqlDbType.VarChar,50),
					new SqlParameter("@jouneryInfo", SqlDbType.VarChar,50),
					new SqlParameter("@isBuyInsurance", SqlDbType.VarChar,50),
					new SqlParameter("@orderinfo_id", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.orderNo;
			parameters[1].Value = model.pnr;
			parameters[2].Value = model.growDiscount;
			parameters[3].Value = model.stayDiscount;
			parameters[4].Value = model.payMoney;
			parameters[5].Value = model.profit;
			parameters[6].Value = model.status;
			parameters[7].Value = model.date;
			parameters[8].Value = model.scity;
			parameters[9].Value = model.ecity;
			parameters[10].Value = model.flight;
			parameters[11].Value = model.stime;
			parameters[12].Value = model.etime;
			parameters[13].Value = model.cabin;
			parameters[14].Value = model.price;
			parameters[15].Value = model.tax;
			parameters[16].Value = model.pcount;
			parameters[17].Value = model.pName;
			parameters[18].Value = model.pCard;
			parameters[19].Value = model.jouneryInfo;
			parameters[20].Value = model.isBuyInsurance;
			parameters[21].Value = model.orderinfo_id;
			parameters[22].Value = model.id;

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
			strSql.Append("delete from JinRiOrderByPnr ");
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
			strSql.Append("delete from JinRiOrderByPnr ");
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
		public Sanben.Model.JinRiOrderByPnr GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,orderNo,pnr,growDiscount,stayDiscount,payMoney,profit,status,date,scity,ecity,flight,stime,etime,cabin,price,tax,pcount,pName,pCard,jouneryInfo,isBuyInsurance,orderinfo_id from JinRiOrderByPnr ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Sanben.Model.JinRiOrderByPnr model=new Sanben.Model.JinRiOrderByPnr();
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
		public Sanben.Model.JinRiOrderByPnr DataRowToModel(DataRow row)
		{
			Sanben.Model.JinRiOrderByPnr model=new Sanben.Model.JinRiOrderByPnr();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["orderNo"]!=null)
				{
					model.orderNo=row["orderNo"].ToString();
				}
				if(row["pnr"]!=null)
				{
					model.pnr=row["pnr"].ToString();
				}
				if(row["growDiscount"]!=null && row["growDiscount"].ToString()!="")
				{
					model.growDiscount=decimal.Parse(row["growDiscount"].ToString());
				}
				if(row["stayDiscount"]!=null && row["stayDiscount"].ToString()!="")
				{
					model.stayDiscount=decimal.Parse(row["stayDiscount"].ToString());
				}
				if(row["payMoney"]!=null && row["payMoney"].ToString()!="")
				{
					model.payMoney=decimal.Parse(row["payMoney"].ToString());
				}
				if(row["profit"]!=null && row["profit"].ToString()!="")
				{
					model.profit=decimal.Parse(row["profit"].ToString());
				}
				if(row["status"]!=null && row["status"].ToString()!="")
				{
					model.status=int.Parse(row["status"].ToString());
				}
				if(row["date"]!=null)
				{
					model.date=row["date"].ToString();
				}
				if(row["scity"]!=null)
				{
					model.scity=row["scity"].ToString();
				}
				if(row["ecity"]!=null)
				{
					model.ecity=row["ecity"].ToString();
				}
				if(row["flight"]!=null)
				{
					model.flight=row["flight"].ToString();
				}
				if(row["stime"]!=null)
				{
					model.stime=row["stime"].ToString();
				}
				if(row["etime"]!=null)
				{
					model.etime=row["etime"].ToString();
				}
				if(row["cabin"]!=null)
				{
					model.cabin=row["cabin"].ToString();
				}
				if(row["price"]!=null && row["price"].ToString()!="")
				{
					model.price=decimal.Parse(row["price"].ToString());
				}
				if(row["tax"]!=null && row["tax"].ToString()!="")
				{
					model.tax=decimal.Parse(row["tax"].ToString());
				}
				if(row["pcount"]!=null && row["pcount"].ToString()!="")
				{
					model.pcount=int.Parse(row["pcount"].ToString());
				}
				if(row["pName"]!=null)
				{
					model.pName=row["pName"].ToString();
				}
				if(row["pCard"]!=null)
				{
					model.pCard=row["pCard"].ToString();
				}
				if(row["jouneryInfo"]!=null)
				{
					model.jouneryInfo=row["jouneryInfo"].ToString();
				}
				if(row["isBuyInsurance"]!=null)
				{
					model.isBuyInsurance=row["isBuyInsurance"].ToString();
				}
				if(row["orderinfo_id"]!=null && row["orderinfo_id"].ToString()!="")
				{
					model.orderinfo_id=int.Parse(row["orderinfo_id"].ToString());
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
			strSql.Append("select id,orderNo,pnr,growDiscount,stayDiscount,payMoney,profit,status,date,scity,ecity,flight,stime,etime,cabin,price,tax,pcount,pName,pCard,jouneryInfo,isBuyInsurance,orderinfo_id ");
			strSql.Append(" FROM JinRiOrderByPnr ");
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
			strSql.Append(" id,orderNo,pnr,growDiscount,stayDiscount,payMoney,profit,status,date,scity,ecity,flight,stime,etime,cabin,price,tax,pcount,pName,pCard,jouneryInfo,isBuyInsurance,orderinfo_id ");
			strSql.Append(" FROM JinRiOrderByPnr ");
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
			strSql.Append("select count(1) FROM JinRiOrderByPnr ");
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
			strSql.Append(")AS Row, T.*  from JinRiOrderByPnr T ");
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
			parameters[0].Value = "JinRiOrderByPnr";
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

