using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:Airport_Unknown
	/// </summary>
	public partial class Airport_Unknown:IAirport_Unknown
	{
		public Airport_Unknown()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Sanben.Model.Airport_Unknown model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Airport_Unknown(");
			strSql.Append("Cabin,ChildCabin,Discount,Price,Surplus_Seat_Qty,Cabin_Status,Line_Number)");
			strSql.Append(" values (");
			strSql.Append("@Cabin,@ChildCabin,@Discount,@Price,@Surplus_Seat_Qty,@Cabin_Status,@Line_Number)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Cabin", SqlDbType.NVarChar,255),
					new SqlParameter("@ChildCabin", SqlDbType.Int,4),
					new SqlParameter("@Discount", SqlDbType.NVarChar,255),
					new SqlParameter("@Price", SqlDbType.Int,4),
					new SqlParameter("@Surplus_Seat_Qty", SqlDbType.NVarChar,255),
					new SqlParameter("@Cabin_Status", SqlDbType.NVarChar,255),
					new SqlParameter("@Line_Number", SqlDbType.NVarChar,255)};
			parameters[0].Value = model.Cabin;
			parameters[1].Value = model.ChildCabin;
			parameters[2].Value = model.Discount;
			parameters[3].Value = model.Price;
			parameters[4].Value = model.Surplus_Seat_Qty;
			parameters[5].Value = model.Cabin_Status;
			parameters[6].Value = model.Line_Number;

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
		public bool Update(Sanben.Model.Airport_Unknown model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Airport_Unknown set ");
			strSql.Append("Cabin=@Cabin,");
			strSql.Append("ChildCabin=@ChildCabin,");
			strSql.Append("Discount=@Discount,");
			strSql.Append("Price=@Price,");
			strSql.Append("Surplus_Seat_Qty=@Surplus_Seat_Qty,");
			strSql.Append("Cabin_Status=@Cabin_Status,");
			strSql.Append("Line_Number=@Line_Number");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Cabin", SqlDbType.NVarChar,255),
					new SqlParameter("@ChildCabin", SqlDbType.Int,4),
					new SqlParameter("@Discount", SqlDbType.NVarChar,255),
					new SqlParameter("@Price", SqlDbType.Int,4),
					new SqlParameter("@Surplus_Seat_Qty", SqlDbType.NVarChar,255),
					new SqlParameter("@Cabin_Status", SqlDbType.NVarChar,255),
					new SqlParameter("@Line_Number", SqlDbType.NVarChar,255),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Cabin;
			parameters[1].Value = model.ChildCabin;
			parameters[2].Value = model.Discount;
			parameters[3].Value = model.Price;
			parameters[4].Value = model.Surplus_Seat_Qty;
			parameters[5].Value = model.Cabin_Status;
			parameters[6].Value = model.Line_Number;
			parameters[7].Value = model.ID;

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
			strSql.Append("delete from Airport_Unknown ");
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
			strSql.Append("delete from Airport_Unknown ");
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
		public Sanben.Model.Airport_Unknown GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Cabin,ChildCabin,Discount,Price,Surplus_Seat_Qty,Cabin_Status,Line_Number from Airport_Unknown ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Sanben.Model.Airport_Unknown model=new Sanben.Model.Airport_Unknown();
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
		public Sanben.Model.Airport_Unknown DataRowToModel(DataRow row)
		{
			Sanben.Model.Airport_Unknown model=new Sanben.Model.Airport_Unknown();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["Cabin"]!=null)
				{
					model.Cabin=row["Cabin"].ToString();
				}
				if(row["ChildCabin"]!=null && row["ChildCabin"].ToString()!="")
				{
					model.ChildCabin=int.Parse(row["ChildCabin"].ToString());
				}
				if(row["Discount"]!=null)
				{
					model.Discount=row["Discount"].ToString();
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=int.Parse(row["Price"].ToString());
				}
				if(row["Surplus_Seat_Qty"]!=null)
				{
					model.Surplus_Seat_Qty=row["Surplus_Seat_Qty"].ToString();
				}
				if(row["Cabin_Status"]!=null)
				{
					model.Cabin_Status=row["Cabin_Status"].ToString();
				}
				if(row["Line_Number"]!=null)
				{
					model.Line_Number=row["Line_Number"].ToString();
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
			strSql.Append("select ID,Cabin,ChildCabin,Discount,Price,Surplus_Seat_Qty,Cabin_Status,Line_Number ");
			strSql.Append(" FROM Airport_Unknown ");
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
			strSql.Append(" ID,Cabin,ChildCabin,Discount,Price,Surplus_Seat_Qty,Cabin_Status,Line_Number ");
			strSql.Append(" FROM Airport_Unknown ");
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
			strSql.Append("select count(1) FROM Airport_Unknown ");
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
			strSql.Append(")AS Row, T.*  from Airport_Unknown T ");
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
			parameters[0].Value = "Airport_Unknown";
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

