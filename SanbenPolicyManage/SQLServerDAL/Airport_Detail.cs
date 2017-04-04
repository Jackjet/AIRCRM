using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:Airport_Detail
	/// </summary>
	public partial class Airport_Detail:IAirport_Detail
	{
		public Airport_Detail()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Airport_Detail"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Airport_Detail");
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
		public int Add(Sanben.Model.Airport_Detail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Airport_Detail(");
			strSql.Append("Date,From_Code,To_Code,StartCity,ArriveCity,Mileage,Fule_Adult,Fule_Child,Line_Number,Share_Line,Company,StartCode,StartAirport,ArriveCode,ArriveAirport,StartTime,ArriveTime,AirRax,FuleRax,FuelAdu,FuelChd,Food,Food_Detail,Direct_Flight,Type,Electronic_Ticket,Start_Terminal,Arrive_Terminal,Cabin,ChildCabin,Discount,Price,Surplus_Seat_Qty,Cabin_Status,Cabin_Point,Validity_Period,Return_Date,Valid_Date,AddTime)");
			strSql.Append(" values (");
			strSql.Append("@Date,@From_Code,@To_Code,@StartCity,@ArriveCity,@Mileage,@Fule_Adult,@Fule_Child,@Line_Number,@Share_Line,@Company,@StartCode,@StartAirport,@ArriveCode,@ArriveAirport,@StartTime,@ArriveTime,@AirRax,@FuleRax,@FuelAdu,@FuelChd,@Food,@Food_Detail,@Direct_Flight,@Type,@Electronic_Ticket,@Start_Terminal,@Arrive_Terminal,@Cabin,@ChildCabin,@Discount,@Price,@Surplus_Seat_Qty,@Cabin_Status,@Cabin_Point,@Validity_Period,@Return_Date,@Valid_Date,@AddTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Date", SqlDbType.NVarChar,255),
					new SqlParameter("@From_Code", SqlDbType.NVarChar,255),
					new SqlParameter("@To_Code", SqlDbType.NVarChar,255),
					new SqlParameter("@StartCity", SqlDbType.NVarChar,255),
					new SqlParameter("@ArriveCity", SqlDbType.NVarChar,255),
					new SqlParameter("@Mileage", SqlDbType.Int,4),
					new SqlParameter("@Fule_Adult", SqlDbType.Int,4),
					new SqlParameter("@Fule_Child", SqlDbType.Int,4),
					new SqlParameter("@Line_Number", SqlDbType.NVarChar,255),
					new SqlParameter("@Share_Line", SqlDbType.NVarChar,255),
					new SqlParameter("@Company", SqlDbType.NVarChar,255),
					new SqlParameter("@StartCode", SqlDbType.NVarChar,255),
					new SqlParameter("@StartAirport", SqlDbType.NVarChar,255),
					new SqlParameter("@ArriveCode", SqlDbType.NVarChar,255),
					new SqlParameter("@ArriveAirport", SqlDbType.NVarChar,255),
					new SqlParameter("@StartTime", SqlDbType.NVarChar,255),
					new SqlParameter("@ArriveTime", SqlDbType.NVarChar,255),
					new SqlParameter("@AirRax", SqlDbType.Int,4),
					new SqlParameter("@FuleRax", SqlDbType.Int,4),
					new SqlParameter("@FuelAdu", SqlDbType.Int,4),
					new SqlParameter("@FuelChd", SqlDbType.Int,4),
					new SqlParameter("@Food", SqlDbType.Int,4),
					new SqlParameter("@Food_Detail", SqlDbType.NVarChar,255),
					new SqlParameter("@Direct_Flight", SqlDbType.Int,4),
					new SqlParameter("@Type", SqlDbType.NVarChar,255),
					new SqlParameter("@Electronic_Ticket", SqlDbType.Int,4),
					new SqlParameter("@Start_Terminal", SqlDbType.NVarChar,255),
					new SqlParameter("@Arrive_Terminal", SqlDbType.NVarChar,255),
					new SqlParameter("@Cabin", SqlDbType.NVarChar,255),
					new SqlParameter("@ChildCabin", SqlDbType.Int,4),
					new SqlParameter("@Discount", SqlDbType.NVarChar,255),
					new SqlParameter("@Price", SqlDbType.Int,4),
					new SqlParameter("@Surplus_Seat_Qty", SqlDbType.NVarChar,255),
					new SqlParameter("@Cabin_Status", SqlDbType.NVarChar,255),
					new SqlParameter("@Cabin_Point", SqlDbType.NVarChar,50),
					new SqlParameter("@Validity_Period", SqlDbType.NVarChar,255),
					new SqlParameter("@Return_Date", SqlDbType.NVarChar,255),
					new SqlParameter("@Valid_Date", SqlDbType.NVarChar,255),
					new SqlParameter("@AddTime", SqlDbType.DateTime)};
			parameters[0].Value = model.Date;
			parameters[1].Value = model.From_Code;
			parameters[2].Value = model.To_Code;
			parameters[3].Value = model.StartCity;
			parameters[4].Value = model.ArriveCity;
			parameters[5].Value = model.Mileage;
			parameters[6].Value = model.Fule_Adult;
			parameters[7].Value = model.Fule_Child;
			parameters[8].Value = model.Line_Number;
			parameters[9].Value = model.Share_Line;
			parameters[10].Value = model.Company;
			parameters[11].Value = model.StartCode;
			parameters[12].Value = model.StartAirport;
			parameters[13].Value = model.ArriveCode;
			parameters[14].Value = model.ArriveAirport;
			parameters[15].Value = model.StartTime;
			parameters[16].Value = model.ArriveTime;
			parameters[17].Value = model.AirRax;
			parameters[18].Value = model.FuleRax;
			parameters[19].Value = model.FuelAdu;
			parameters[20].Value = model.FuelChd;
			parameters[21].Value = model.Food;
			parameters[22].Value = model.Food_Detail;
			parameters[23].Value = model.Direct_Flight;
			parameters[24].Value = model.Type;
			parameters[25].Value = model.Electronic_Ticket;
			parameters[26].Value = model.Start_Terminal;
			parameters[27].Value = model.Arrive_Terminal;
			parameters[28].Value = model.Cabin;
			parameters[29].Value = model.ChildCabin;
			parameters[30].Value = model.Discount;
			parameters[31].Value = model.Price;
			parameters[32].Value = model.Surplus_Seat_Qty;
			parameters[33].Value = model.Cabin_Status;
			parameters[34].Value = model.Cabin_Point;
			parameters[35].Value = model.Validity_Period;
			parameters[36].Value = model.Return_Date;
			parameters[37].Value = model.Valid_Date;
			parameters[38].Value = model.AddTime;

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
		public bool Update(Sanben.Model.Airport_Detail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Airport_Detail set ");
			strSql.Append("Date=@Date,");
			strSql.Append("From_Code=@From_Code,");
			strSql.Append("To_Code=@To_Code,");
			strSql.Append("StartCity=@StartCity,");
			strSql.Append("ArriveCity=@ArriveCity,");
			strSql.Append("Mileage=@Mileage,");
			strSql.Append("Fule_Adult=@Fule_Adult,");
			strSql.Append("Fule_Child=@Fule_Child,");
			strSql.Append("Line_Number=@Line_Number,");
			strSql.Append("Share_Line=@Share_Line,");
			strSql.Append("Company=@Company,");
			strSql.Append("StartCode=@StartCode,");
			strSql.Append("StartAirport=@StartAirport,");
			strSql.Append("ArriveCode=@ArriveCode,");
			strSql.Append("ArriveAirport=@ArriveAirport,");
			strSql.Append("StartTime=@StartTime,");
			strSql.Append("ArriveTime=@ArriveTime,");
			strSql.Append("AirRax=@AirRax,");
			strSql.Append("FuleRax=@FuleRax,");
			strSql.Append("FuelAdu=@FuelAdu,");
			strSql.Append("FuelChd=@FuelChd,");
			strSql.Append("Food=@Food,");
			strSql.Append("Food_Detail=@Food_Detail,");
			strSql.Append("Direct_Flight=@Direct_Flight,");
			strSql.Append("Type=@Type,");
			strSql.Append("Electronic_Ticket=@Electronic_Ticket,");
			strSql.Append("Start_Terminal=@Start_Terminal,");
			strSql.Append("Arrive_Terminal=@Arrive_Terminal,");
			strSql.Append("Cabin=@Cabin,");
			strSql.Append("ChildCabin=@ChildCabin,");
			strSql.Append("Discount=@Discount,");
			strSql.Append("Price=@Price,");
			strSql.Append("Surplus_Seat_Qty=@Surplus_Seat_Qty,");
			strSql.Append("Cabin_Status=@Cabin_Status,");
			strSql.Append("Cabin_Point=@Cabin_Point,");
			strSql.Append("Validity_Period=@Validity_Period,");
			strSql.Append("Return_Date=@Return_Date,");
			strSql.Append("Valid_Date=@Valid_Date,");
			strSql.Append("AddTime=@AddTime");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Date", SqlDbType.NVarChar,255),
					new SqlParameter("@From_Code", SqlDbType.NVarChar,255),
					new SqlParameter("@To_Code", SqlDbType.NVarChar,255),
					new SqlParameter("@StartCity", SqlDbType.NVarChar,255),
					new SqlParameter("@ArriveCity", SqlDbType.NVarChar,255),
					new SqlParameter("@Mileage", SqlDbType.Int,4),
					new SqlParameter("@Fule_Adult", SqlDbType.Int,4),
					new SqlParameter("@Fule_Child", SqlDbType.Int,4),
					new SqlParameter("@Line_Number", SqlDbType.NVarChar,255),
					new SqlParameter("@Share_Line", SqlDbType.NVarChar,255),
					new SqlParameter("@Company", SqlDbType.NVarChar,255),
					new SqlParameter("@StartCode", SqlDbType.NVarChar,255),
					new SqlParameter("@StartAirport", SqlDbType.NVarChar,255),
					new SqlParameter("@ArriveCode", SqlDbType.NVarChar,255),
					new SqlParameter("@ArriveAirport", SqlDbType.NVarChar,255),
					new SqlParameter("@StartTime", SqlDbType.NVarChar,255),
					new SqlParameter("@ArriveTime", SqlDbType.NVarChar,255),
					new SqlParameter("@AirRax", SqlDbType.Int,4),
					new SqlParameter("@FuleRax", SqlDbType.Int,4),
					new SqlParameter("@FuelAdu", SqlDbType.Int,4),
					new SqlParameter("@FuelChd", SqlDbType.Int,4),
					new SqlParameter("@Food", SqlDbType.Int,4),
					new SqlParameter("@Food_Detail", SqlDbType.NVarChar,255),
					new SqlParameter("@Direct_Flight", SqlDbType.Int,4),
					new SqlParameter("@Type", SqlDbType.NVarChar,255),
					new SqlParameter("@Electronic_Ticket", SqlDbType.Int,4),
					new SqlParameter("@Start_Terminal", SqlDbType.NVarChar,255),
					new SqlParameter("@Arrive_Terminal", SqlDbType.NVarChar,255),
					new SqlParameter("@Cabin", SqlDbType.NVarChar,255),
					new SqlParameter("@ChildCabin", SqlDbType.Int,4),
					new SqlParameter("@Discount", SqlDbType.NVarChar,255),
					new SqlParameter("@Price", SqlDbType.Int,4),
					new SqlParameter("@Surplus_Seat_Qty", SqlDbType.NVarChar,255),
					new SqlParameter("@Cabin_Status", SqlDbType.NVarChar,255),
					new SqlParameter("@Cabin_Point", SqlDbType.NVarChar,50),
					new SqlParameter("@Validity_Period", SqlDbType.NVarChar,255),
					new SqlParameter("@Return_Date", SqlDbType.NVarChar,255),
					new SqlParameter("@Valid_Date", SqlDbType.NVarChar,255),
					new SqlParameter("@AddTime", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Date;
			parameters[1].Value = model.From_Code;
			parameters[2].Value = model.To_Code;
			parameters[3].Value = model.StartCity;
			parameters[4].Value = model.ArriveCity;
			parameters[5].Value = model.Mileage;
			parameters[6].Value = model.Fule_Adult;
			parameters[7].Value = model.Fule_Child;
			parameters[8].Value = model.Line_Number;
			parameters[9].Value = model.Share_Line;
			parameters[10].Value = model.Company;
			parameters[11].Value = model.StartCode;
			parameters[12].Value = model.StartAirport;
			parameters[13].Value = model.ArriveCode;
			parameters[14].Value = model.ArriveAirport;
			parameters[15].Value = model.StartTime;
			parameters[16].Value = model.ArriveTime;
			parameters[17].Value = model.AirRax;
			parameters[18].Value = model.FuleRax;
			parameters[19].Value = model.FuelAdu;
			parameters[20].Value = model.FuelChd;
			parameters[21].Value = model.Food;
			parameters[22].Value = model.Food_Detail;
			parameters[23].Value = model.Direct_Flight;
			parameters[24].Value = model.Type;
			parameters[25].Value = model.Electronic_Ticket;
			parameters[26].Value = model.Start_Terminal;
			parameters[27].Value = model.Arrive_Terminal;
			parameters[28].Value = model.Cabin;
			parameters[29].Value = model.ChildCabin;
			parameters[30].Value = model.Discount;
			parameters[31].Value = model.Price;
			parameters[32].Value = model.Surplus_Seat_Qty;
			parameters[33].Value = model.Cabin_Status;
			parameters[34].Value = model.Cabin_Point;
			parameters[35].Value = model.Validity_Period;
			parameters[36].Value = model.Return_Date;
			parameters[37].Value = model.Valid_Date;
			parameters[38].Value = model.AddTime;
			parameters[39].Value = model.ID;

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
			strSql.Append("delete from Airport_Detail ");
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
			strSql.Append("delete from Airport_Detail ");
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
		public Sanben.Model.Airport_Detail GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Date,From_Code,To_Code,StartCity,ArriveCity,Mileage,Fule_Adult,Fule_Child,Line_Number,Share_Line,Company,StartCode,StartAirport,ArriveCode,ArriveAirport,StartTime,ArriveTime,AirRax,FuleRax,FuelAdu,FuelChd,Food,Food_Detail,Direct_Flight,Type,Electronic_Ticket,Start_Terminal,Arrive_Terminal,Cabin,ChildCabin,Discount,Price,Surplus_Seat_Qty,Cabin_Status,Cabin_Point,Validity_Period,Return_Date,Valid_Date,AddTime from Airport_Detail ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Sanben.Model.Airport_Detail model=new Sanben.Model.Airport_Detail();
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
		public Sanben.Model.Airport_Detail DataRowToModel(DataRow row)
		{
			Sanben.Model.Airport_Detail model=new Sanben.Model.Airport_Detail();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["Date"]!=null)
				{
					model.Date=row["Date"].ToString();
				}
				if(row["From_Code"]!=null)
				{
					model.From_Code=row["From_Code"].ToString();
				}
				if(row["To_Code"]!=null)
				{
					model.To_Code=row["To_Code"].ToString();
				}
				if(row["StartCity"]!=null)
				{
					model.StartCity=row["StartCity"].ToString();
				}
				if(row["ArriveCity"]!=null)
				{
					model.ArriveCity=row["ArriveCity"].ToString();
				}
				if(row["Mileage"]!=null && row["Mileage"].ToString()!="")
				{
					model.Mileage=int.Parse(row["Mileage"].ToString());
				}
				if(row["Fule_Adult"]!=null && row["Fule_Adult"].ToString()!="")
				{
					model.Fule_Adult=int.Parse(row["Fule_Adult"].ToString());
				}
				if(row["Fule_Child"]!=null && row["Fule_Child"].ToString()!="")
				{
					model.Fule_Child=int.Parse(row["Fule_Child"].ToString());
				}
				if(row["Line_Number"]!=null)
				{
					model.Line_Number=row["Line_Number"].ToString();
				}
				if(row["Share_Line"]!=null)
				{
					model.Share_Line=row["Share_Line"].ToString();
				}
				if(row["Company"]!=null)
				{
					model.Company=row["Company"].ToString();
				}
				if(row["StartCode"]!=null)
				{
					model.StartCode=row["StartCode"].ToString();
				}
				if(row["StartAirport"]!=null)
				{
					model.StartAirport=row["StartAirport"].ToString();
				}
				if(row["ArriveCode"]!=null)
				{
					model.ArriveCode=row["ArriveCode"].ToString();
				}
				if(row["ArriveAirport"]!=null)
				{
					model.ArriveAirport=row["ArriveAirport"].ToString();
				}
				if(row["StartTime"]!=null)
				{
					model.StartTime=row["StartTime"].ToString();
				}
				if(row["ArriveTime"]!=null)
				{
					model.ArriveTime=row["ArriveTime"].ToString();
				}
				if(row["AirRax"]!=null && row["AirRax"].ToString()!="")
				{
					model.AirRax=int.Parse(row["AirRax"].ToString());
				}
				if(row["FuleRax"]!=null && row["FuleRax"].ToString()!="")
				{
					model.FuleRax=int.Parse(row["FuleRax"].ToString());
				}
				if(row["FuelAdu"]!=null && row["FuelAdu"].ToString()!="")
				{
					model.FuelAdu=int.Parse(row["FuelAdu"].ToString());
				}
				if(row["FuelChd"]!=null && row["FuelChd"].ToString()!="")
				{
					model.FuelChd=int.Parse(row["FuelChd"].ToString());
				}
				if(row["Food"]!=null && row["Food"].ToString()!="")
				{
					model.Food=int.Parse(row["Food"].ToString());
				}
				if(row["Food_Detail"]!=null)
				{
					model.Food_Detail=row["Food_Detail"].ToString();
				}
				if(row["Direct_Flight"]!=null && row["Direct_Flight"].ToString()!="")
				{
					model.Direct_Flight=int.Parse(row["Direct_Flight"].ToString());
				}
				if(row["Type"]!=null)
				{
					model.Type=row["Type"].ToString();
				}
				if(row["Electronic_Ticket"]!=null && row["Electronic_Ticket"].ToString()!="")
				{
					model.Electronic_Ticket=int.Parse(row["Electronic_Ticket"].ToString());
				}
				if(row["Start_Terminal"]!=null)
				{
					model.Start_Terminal=row["Start_Terminal"].ToString();
				}
				if(row["Arrive_Terminal"]!=null)
				{
					model.Arrive_Terminal=row["Arrive_Terminal"].ToString();
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
				if(row["Cabin_Point"]!=null)
				{
					model.Cabin_Point=row["Cabin_Point"].ToString();
				}
				if(row["Validity_Period"]!=null)
				{
					model.Validity_Period=row["Validity_Period"].ToString();
				}
				if(row["Return_Date"]!=null)
				{
					model.Return_Date=row["Return_Date"].ToString();
				}
				if(row["Valid_Date"]!=null)
				{
					model.Valid_Date=row["Valid_Date"].ToString();
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
			strSql.Append("select ID,Date,From_Code,To_Code,StartCity,ArriveCity,Mileage,Fule_Adult,Fule_Child,Line_Number,Share_Line,Company,StartCode,StartAirport,ArriveCode,ArriveAirport,StartTime,ArriveTime,AirRax,FuleRax,FuelAdu,FuelChd,Food,Food_Detail,Direct_Flight,Type,Electronic_Ticket,Start_Terminal,Arrive_Terminal,Cabin,ChildCabin,Discount,Price,Surplus_Seat_Qty,Cabin_Status,Cabin_Point,Validity_Period,Return_Date,Valid_Date,AddTime ");
			strSql.Append(" FROM Airport_Detail ");
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
			strSql.Append(" ID,Date,From_Code,To_Code,StartCity,ArriveCity,Mileage,Fule_Adult,Fule_Child,Line_Number,Share_Line,Company,StartCode,StartAirport,ArriveCode,ArriveAirport,StartTime,ArriveTime,AirRax,FuleRax,FuelAdu,FuelChd,Food,Food_Detail,Direct_Flight,Type,Electronic_Ticket,Start_Terminal,Arrive_Terminal,Cabin,ChildCabin,Discount,Price,Surplus_Seat_Qty,Cabin_Status,Cabin_Point,Validity_Period,Return_Date,Valid_Date,AddTime ");
			strSql.Append(" FROM Airport_Detail ");
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
			strSql.Append("select count(1) FROM Airport_Detail ");
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
			strSql.Append(")AS Row, T.*  from Airport_Detail T ");
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
			parameters[0].Value = "Airport_Detail";
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

