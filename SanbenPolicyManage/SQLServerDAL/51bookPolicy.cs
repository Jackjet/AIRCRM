using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:51bookPolicy
	/// </summary>
	public partial class a51bookPolicy:I51bookPolicy
	{
		public a51bookPolicy()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "51bookPolicy"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from 51bookPolicy");
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
		public int Add(Sanben.Model.a51bookPolicy model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into 51bookPolicy(");
			strSql.Append("adultAirportTax,adultFuelTax,childAirportTax,childFuelTax,flightNo,adultSettlePrice,airlineCode,comment,commisionPoint,needSwitchPNR,policyId,policyType,productType,routeType,seatType,supplyOfficeNo,ticketSpeed,vtWorkTime,workTime,seatCode,ticketPrice,Addtime,IsUpload,IsUpdate)");
			strSql.Append(" values (");
			strSql.Append("@adultAirportTax,@adultFuelTax,@childAirportTax,@childFuelTax,@flightNo,@adultSettlePrice,@airlineCode,@comment,@commisionPoint,@needSwitchPNR,@policyId,@policyType,@productType,@routeType,@seatType,@supplyOfficeNo,@ticketSpeed,@vtWorkTime,@workTime,@seatCode,@ticketPrice,@Addtime,@IsUpload,@IsUpdate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@adultAirportTax", SqlDbType.NVarChar,255),
					new SqlParameter("@adultFuelTax", SqlDbType.NVarChar,255),
					new SqlParameter("@childAirportTax", SqlDbType.NVarChar,255),
					new SqlParameter("@childFuelTax", SqlDbType.NVarChar,255),
					new SqlParameter("@flightNo", SqlDbType.NVarChar,255),
					new SqlParameter("@adultSettlePrice", SqlDbType.NVarChar,255),
					new SqlParameter("@airlineCode", SqlDbType.NVarChar,255),
					new SqlParameter("@comment", SqlDbType.NVarChar,255),
					new SqlParameter("@commisionPoint", SqlDbType.NVarChar,255),
					new SqlParameter("@needSwitchPNR", SqlDbType.NVarChar,255),
					new SqlParameter("@policyId", SqlDbType.NVarChar,255),
					new SqlParameter("@policyType", SqlDbType.NVarChar,255),
					new SqlParameter("@productType", SqlDbType.NVarChar,255),
					new SqlParameter("@routeType", SqlDbType.NVarChar,255),
					new SqlParameter("@seatType", SqlDbType.NVarChar,255),
					new SqlParameter("@supplyOfficeNo", SqlDbType.NVarChar,255),
					new SqlParameter("@ticketSpeed", SqlDbType.NVarChar,255),
					new SqlParameter("@vtWorkTime", SqlDbType.NVarChar,255),
					new SqlParameter("@workTime", SqlDbType.NVarChar,255),
					new SqlParameter("@seatCode", SqlDbType.NVarChar,255),
					new SqlParameter("@ticketPrice", SqlDbType.NVarChar,255),
					new SqlParameter("@Addtime", SqlDbType.DateTime),
					new SqlParameter("@IsUpload", SqlDbType.Bit,1),
					new SqlParameter("@IsUpdate", SqlDbType.Bit,1)};
			parameters[0].Value = model.adultAirportTax;
			parameters[1].Value = model.adultFuelTax;
			parameters[2].Value = model.childAirportTax;
			parameters[3].Value = model.childFuelTax;
			parameters[4].Value = model.flightNo;
			parameters[5].Value = model.adultSettlePrice;
			parameters[6].Value = model.airlineCode;
			parameters[7].Value = model.comment;
			parameters[8].Value = model.commisionPoint;
			parameters[9].Value = model.needSwitchPNR;
			parameters[10].Value = model.policyId;
			parameters[11].Value = model.policyType;
			parameters[12].Value = model.productType;
			parameters[13].Value = model.routeType;
			parameters[14].Value = model.seatType;
			parameters[15].Value = model.supplyOfficeNo;
			parameters[16].Value = model.ticketSpeed;
			parameters[17].Value = model.vtWorkTime;
			parameters[18].Value = model.workTime;
			parameters[19].Value = model.seatCode;
			parameters[20].Value = model.ticketPrice;
			parameters[21].Value = model.Addtime;
			parameters[22].Value = model.IsUpload;
			parameters[23].Value = model.IsUpdate;

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
		public bool Update(Sanben.Model.a51bookPolicy model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update 51bookPolicy set ");
			strSql.Append("adultAirportTax=@adultAirportTax,");
			strSql.Append("adultFuelTax=@adultFuelTax,");
			strSql.Append("childAirportTax=@childAirportTax,");
			strSql.Append("childFuelTax=@childFuelTax,");
			strSql.Append("flightNo=@flightNo,");
			strSql.Append("adultSettlePrice=@adultSettlePrice,");
			strSql.Append("airlineCode=@airlineCode,");
			strSql.Append("comment=@comment,");
			strSql.Append("commisionPoint=@commisionPoint,");
			strSql.Append("needSwitchPNR=@needSwitchPNR,");
			strSql.Append("policyId=@policyId,");
			strSql.Append("policyType=@policyType,");
			strSql.Append("productType=@productType,");
			strSql.Append("routeType=@routeType,");
			strSql.Append("seatType=@seatType,");
			strSql.Append("supplyOfficeNo=@supplyOfficeNo,");
			strSql.Append("ticketSpeed=@ticketSpeed,");
			strSql.Append("vtWorkTime=@vtWorkTime,");
			strSql.Append("workTime=@workTime,");
			strSql.Append("seatCode=@seatCode,");
			strSql.Append("ticketPrice=@ticketPrice,");
			strSql.Append("Addtime=@Addtime,");
			strSql.Append("IsUpload=@IsUpload,");
			strSql.Append("IsUpdate=@IsUpdate");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@adultAirportTax", SqlDbType.NVarChar,255),
					new SqlParameter("@adultFuelTax", SqlDbType.NVarChar,255),
					new SqlParameter("@childAirportTax", SqlDbType.NVarChar,255),
					new SqlParameter("@childFuelTax", SqlDbType.NVarChar,255),
					new SqlParameter("@flightNo", SqlDbType.NVarChar,255),
					new SqlParameter("@adultSettlePrice", SqlDbType.NVarChar,255),
					new SqlParameter("@airlineCode", SqlDbType.NVarChar,255),
					new SqlParameter("@comment", SqlDbType.NVarChar,255),
					new SqlParameter("@commisionPoint", SqlDbType.NVarChar,255),
					new SqlParameter("@needSwitchPNR", SqlDbType.NVarChar,255),
					new SqlParameter("@policyId", SqlDbType.NVarChar,255),
					new SqlParameter("@policyType", SqlDbType.NVarChar,255),
					new SqlParameter("@productType", SqlDbType.NVarChar,255),
					new SqlParameter("@routeType", SqlDbType.NVarChar,255),
					new SqlParameter("@seatType", SqlDbType.NVarChar,255),
					new SqlParameter("@supplyOfficeNo", SqlDbType.NVarChar,255),
					new SqlParameter("@ticketSpeed", SqlDbType.NVarChar,255),
					new SqlParameter("@vtWorkTime", SqlDbType.NVarChar,255),
					new SqlParameter("@workTime", SqlDbType.NVarChar,255),
					new SqlParameter("@seatCode", SqlDbType.NVarChar,255),
					new SqlParameter("@ticketPrice", SqlDbType.NVarChar,255),
					new SqlParameter("@Addtime", SqlDbType.DateTime),
					new SqlParameter("@IsUpload", SqlDbType.Bit,1),
					new SqlParameter("@IsUpdate", SqlDbType.Bit,1),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.adultAirportTax;
			parameters[1].Value = model.adultFuelTax;
			parameters[2].Value = model.childAirportTax;
			parameters[3].Value = model.childFuelTax;
			parameters[4].Value = model.flightNo;
			parameters[5].Value = model.adultSettlePrice;
			parameters[6].Value = model.airlineCode;
			parameters[7].Value = model.comment;
			parameters[8].Value = model.commisionPoint;
			parameters[9].Value = model.needSwitchPNR;
			parameters[10].Value = model.policyId;
			parameters[11].Value = model.policyType;
			parameters[12].Value = model.productType;
			parameters[13].Value = model.routeType;
			parameters[14].Value = model.seatType;
			parameters[15].Value = model.supplyOfficeNo;
			parameters[16].Value = model.ticketSpeed;
			parameters[17].Value = model.vtWorkTime;
			parameters[18].Value = model.workTime;
			parameters[19].Value = model.seatCode;
			parameters[20].Value = model.ticketPrice;
			parameters[21].Value = model.Addtime;
			parameters[22].Value = model.IsUpload;
			parameters[23].Value = model.IsUpdate;
			parameters[24].Value = model.ID;

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
			strSql.Append("delete from 51bookPolicy ");
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
			strSql.Append("delete from 51bookPolicy ");
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
		public Sanben.Model.a51bookPolicy GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,adultAirportTax,adultFuelTax,childAirportTax,childFuelTax,flightNo,adultSettlePrice,airlineCode,comment,commisionPoint,needSwitchPNR,policyId,policyType,productType,routeType,seatType,supplyOfficeNo,ticketSpeed,vtWorkTime,workTime,seatCode,ticketPrice,Addtime,IsUpload,IsUpdate from 51bookPolicy ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Sanben.Model.a51bookPolicy model=new Sanben.Model.a51bookPolicy();
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
		public Sanben.Model.a51bookPolicy DataRowToModel(DataRow row)
		{
			Sanben.Model.a51bookPolicy model=new Sanben.Model.a51bookPolicy();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["adultAirportTax"]!=null)
				{
					model.adultAirportTax=row["adultAirportTax"].ToString();
				}
				if(row["adultFuelTax"]!=null)
				{
					model.adultFuelTax=row["adultFuelTax"].ToString();
				}
				if(row["childAirportTax"]!=null)
				{
					model.childAirportTax=row["childAirportTax"].ToString();
				}
				if(row["childFuelTax"]!=null)
				{
					model.childFuelTax=row["childFuelTax"].ToString();
				}
				if(row["flightNo"]!=null)
				{
					model.flightNo=row["flightNo"].ToString();
				}
				if(row["adultSettlePrice"]!=null)
				{
					model.adultSettlePrice=row["adultSettlePrice"].ToString();
				}
				if(row["airlineCode"]!=null)
				{
					model.airlineCode=row["airlineCode"].ToString();
				}
				if(row["comment"]!=null)
				{
					model.comment=row["comment"].ToString();
				}
				if(row["commisionPoint"]!=null)
				{
					model.commisionPoint=row["commisionPoint"].ToString();
				}
				if(row["needSwitchPNR"]!=null)
				{
					model.needSwitchPNR=row["needSwitchPNR"].ToString();
				}
				if(row["policyId"]!=null)
				{
					model.policyId=row["policyId"].ToString();
				}
				if(row["policyType"]!=null)
				{
					model.policyType=row["policyType"].ToString();
				}
				if(row["productType"]!=null)
				{
					model.productType=row["productType"].ToString();
				}
				if(row["routeType"]!=null)
				{
					model.routeType=row["routeType"].ToString();
				}
				if(row["seatType"]!=null)
				{
					model.seatType=row["seatType"].ToString();
				}
				if(row["supplyOfficeNo"]!=null)
				{
					model.supplyOfficeNo=row["supplyOfficeNo"].ToString();
				}
				if(row["ticketSpeed"]!=null)
				{
					model.ticketSpeed=row["ticketSpeed"].ToString();
				}
				if(row["vtWorkTime"]!=null)
				{
					model.vtWorkTime=row["vtWorkTime"].ToString();
				}
				if(row["workTime"]!=null)
				{
					model.workTime=row["workTime"].ToString();
				}
				if(row["seatCode"]!=null)
				{
					model.seatCode=row["seatCode"].ToString();
				}
				if(row["ticketPrice"]!=null)
				{
					model.ticketPrice=row["ticketPrice"].ToString();
				}
				if(row["Addtime"]!=null && row["Addtime"].ToString()!="")
				{
					model.Addtime=DateTime.Parse(row["Addtime"].ToString());
				}
				if(row["IsUpload"]!=null && row["IsUpload"].ToString()!="")
				{
					if((row["IsUpload"].ToString()=="1")||(row["IsUpload"].ToString().ToLower()=="true"))
					{
						model.IsUpload=true;
					}
					else
					{
						model.IsUpload=false;
					}
				}
				if(row["IsUpdate"]!=null && row["IsUpdate"].ToString()!="")
				{
					if((row["IsUpdate"].ToString()=="1")||(row["IsUpdate"].ToString().ToLower()=="true"))
					{
						model.IsUpdate=true;
					}
					else
					{
						model.IsUpdate=false;
					}
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
			strSql.Append("select ID,adultAirportTax,adultFuelTax,childAirportTax,childFuelTax,flightNo,adultSettlePrice,airlineCode,comment,commisionPoint,needSwitchPNR,policyId,policyType,productType,routeType,seatType,supplyOfficeNo,ticketSpeed,vtWorkTime,workTime,seatCode,ticketPrice,Addtime,IsUpload,IsUpdate ");
			strSql.Append(" FROM 51bookPolicy ");
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
			strSql.Append(" ID,adultAirportTax,adultFuelTax,childAirportTax,childFuelTax,flightNo,adultSettlePrice,airlineCode,comment,commisionPoint,needSwitchPNR,policyId,policyType,productType,routeType,seatType,supplyOfficeNo,ticketSpeed,vtWorkTime,workTime,seatCode,ticketPrice,Addtime,IsUpload,IsUpdate ");
			strSql.Append(" FROM 51bookPolicy ");
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
			strSql.Append("select count(1) FROM 51bookPolicy ");
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
			strSql.Append(")AS Row, T.*  from 51bookPolicy T ");
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
			parameters[0].Value = "51bookPolicy";
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

