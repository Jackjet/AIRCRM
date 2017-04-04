using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:API380Ticket
	/// </summary>
	public partial class API380Ticket:IAPI380Ticket
	{
		public API380Ticket()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "API380Ticket"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from API380Ticket");
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
		public int Add(Sanben.Model.API380Ticket model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into API380Ticket(");
			strSql.Append("code,message,bigpnr,air,pnr,paystatus,totaltax,ticketprice,orderno,platformB2B_name_id)");
			strSql.Append(" values (");
			strSql.Append("@code,@message,@bigpnr,@air,@pnr,@paystatus,@totaltax,@ticketprice,@orderno,@platformB2B_name_id)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@code", SqlDbType.Int,4),
					new SqlParameter("@message", SqlDbType.VarChar,50),
					new SqlParameter("@bigpnr", SqlDbType.VarChar,50),
					new SqlParameter("@air", SqlDbType.VarChar,50),
					new SqlParameter("@pnr", SqlDbType.VarChar,50),
					new SqlParameter("@paystatus", SqlDbType.VarChar,50),
					new SqlParameter("@totaltax", SqlDbType.VarChar,50),
					new SqlParameter("@ticketprice", SqlDbType.VarChar,50),
					new SqlParameter("@orderno", SqlDbType.VarChar,50),
					new SqlParameter("@platformB2B_name_id", SqlDbType.Int,4)};
			parameters[0].Value = model.code;
			parameters[1].Value = model.message;
			parameters[2].Value = model.bigpnr;
			parameters[3].Value = model.air;
			parameters[4].Value = model.pnr;
			parameters[5].Value = model.paystatus;
			parameters[6].Value = model.totaltax;
			parameters[7].Value = model.ticketprice;
			parameters[8].Value = model.orderno;
			parameters[9].Value = model.platformB2B_name_id;

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
		public bool Update(Sanben.Model.API380Ticket model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update API380Ticket set ");
			strSql.Append("code=@code,");
			strSql.Append("message=@message,");
			strSql.Append("bigpnr=@bigpnr,");
			strSql.Append("air=@air,");
			strSql.Append("pnr=@pnr,");
			strSql.Append("paystatus=@paystatus,");
			strSql.Append("totaltax=@totaltax,");
			strSql.Append("ticketprice=@ticketprice,");
			strSql.Append("orderno=@orderno,");
			strSql.Append("platformB2B_name_id=@platformB2B_name_id");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@code", SqlDbType.Int,4),
					new SqlParameter("@message", SqlDbType.VarChar,50),
					new SqlParameter("@bigpnr", SqlDbType.VarChar,50),
					new SqlParameter("@air", SqlDbType.VarChar,50),
					new SqlParameter("@pnr", SqlDbType.VarChar,50),
					new SqlParameter("@paystatus", SqlDbType.VarChar,50),
					new SqlParameter("@totaltax", SqlDbType.VarChar,50),
					new SqlParameter("@ticketprice", SqlDbType.VarChar,50),
					new SqlParameter("@orderno", SqlDbType.VarChar,50),
					new SqlParameter("@platformB2B_name_id", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.code;
			parameters[1].Value = model.message;
			parameters[2].Value = model.bigpnr;
			parameters[3].Value = model.air;
			parameters[4].Value = model.pnr;
			parameters[5].Value = model.paystatus;
			parameters[6].Value = model.totaltax;
			parameters[7].Value = model.ticketprice;
			parameters[8].Value = model.orderno;
			parameters[9].Value = model.platformB2B_name_id;
			parameters[10].Value = model.id;

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
			strSql.Append("delete from API380Ticket ");
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
			strSql.Append("delete from API380Ticket ");
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
		public Sanben.Model.API380Ticket GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,code,message,bigpnr,air,pnr,paystatus,totaltax,ticketprice,orderno,platformB2B_name_id from API380Ticket ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Sanben.Model.API380Ticket model=new Sanben.Model.API380Ticket();
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
		public Sanben.Model.API380Ticket DataRowToModel(DataRow row)
		{
			Sanben.Model.API380Ticket model=new Sanben.Model.API380Ticket();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["code"]!=null && row["code"].ToString()!="")
				{
					model.code=int.Parse(row["code"].ToString());
				}
				if(row["message"]!=null)
				{
					model.message=row["message"].ToString();
				}
				if(row["bigpnr"]!=null)
				{
					model.bigpnr=row["bigpnr"].ToString();
				}
				if(row["air"]!=null)
				{
					model.air=row["air"].ToString();
				}
				if(row["pnr"]!=null)
				{
					model.pnr=row["pnr"].ToString();
				}
				if(row["paystatus"]!=null)
				{
					model.paystatus=row["paystatus"].ToString();
				}
				if(row["totaltax"]!=null)
				{
					model.totaltax=row["totaltax"].ToString();
				}
				if(row["ticketprice"]!=null)
				{
					model.ticketprice=row["ticketprice"].ToString();
				}
				if(row["orderno"]!=null)
				{
					model.orderno=row["orderno"].ToString();
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
			strSql.Append("select id,code,message,bigpnr,air,pnr,paystatus,totaltax,ticketprice,orderno,platformB2B_name_id ");
			strSql.Append(" FROM API380Ticket ");
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
			strSql.Append(" id,code,message,bigpnr,air,pnr,paystatus,totaltax,ticketprice,orderno,platformB2B_name_id ");
			strSql.Append(" FROM API380Ticket ");
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
			strSql.Append("select count(1) FROM API380Ticket ");
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
			strSql.Append(")AS Row, T.*  from API380Ticket T ");
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
			parameters[0].Value = "API380Ticket";
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

