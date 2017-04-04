using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:Ticket380Policy
	/// </summary>
	public partial class Ticket380Policy:ITicket380Policy
	{
		public Ticket380Policy()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Sanben.Model.Ticket380Policy model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Ticket380Policy(");
			strSql.Append("policy_id,air_comp,start_city,arr_city,flight,cabin,share_line,cabinprice,point,nakednum,is_auto_tic,logtime,deptime,price,remark,fsdate,fedate,sale_sdate,sale_edate,AddTime,IsUpload,IsUpdate)");
			strSql.Append(" values (");
			strSql.Append("@policy_id,@air_comp,@start_city,@arr_city,@flight,@cabin,@share_line,@cabinprice,@point,@nakednum,@is_auto_tic,@logtime,@deptime,@price,@remark,@fsdate,@fedate,@sale_sdate,@sale_edate,@AddTime,@IsUpload,@IsUpdate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@policy_id", SqlDbType.NVarChar,255),
					new SqlParameter("@air_comp", SqlDbType.NVarChar,255),
					new SqlParameter("@start_city", SqlDbType.NVarChar,255),
					new SqlParameter("@arr_city", SqlDbType.NVarChar,255),
					new SqlParameter("@flight", SqlDbType.NVarChar,255),
					new SqlParameter("@cabin", SqlDbType.NVarChar,255),
					new SqlParameter("@share_line", SqlDbType.NVarChar,255),
					new SqlParameter("@cabinprice", SqlDbType.NVarChar,255),
					new SqlParameter("@point", SqlDbType.NVarChar,255),
					new SqlParameter("@nakednum", SqlDbType.NVarChar,255),
					new SqlParameter("@is_auto_tic", SqlDbType.NVarChar,255),
					new SqlParameter("@logtime", SqlDbType.NVarChar,255),
					new SqlParameter("@deptime", SqlDbType.NVarChar,255),
					new SqlParameter("@price", SqlDbType.NVarChar,255),
					new SqlParameter("@remark", SqlDbType.NVarChar,255),
					new SqlParameter("@fsdate", SqlDbType.NVarChar,255),
					new SqlParameter("@fedate", SqlDbType.NVarChar,255),
					new SqlParameter("@sale_sdate", SqlDbType.NVarChar,255),
					new SqlParameter("@sale_edate", SqlDbType.NVarChar,255),
					new SqlParameter("@AddTime", SqlDbType.DateTime),
					new SqlParameter("@IsUpload", SqlDbType.Bit,1),
					new SqlParameter("@IsUpdate", SqlDbType.Bit,1)};
			parameters[0].Value = model.policy_id;
			parameters[1].Value = model.air_comp;
			parameters[2].Value = model.start_city;
			parameters[3].Value = model.arr_city;
			parameters[4].Value = model.flight;
			parameters[5].Value = model.cabin;
			parameters[6].Value = model.share_line;
			parameters[7].Value = model.cabinprice;
			parameters[8].Value = model.point;
			parameters[9].Value = model.nakednum;
			parameters[10].Value = model.is_auto_tic;
			parameters[11].Value = model.logtime;
			parameters[12].Value = model.deptime;
			parameters[13].Value = model.price;
			parameters[14].Value = model.remark;
			parameters[15].Value = model.fsdate;
			parameters[16].Value = model.fedate;
			parameters[17].Value = model.sale_sdate;
			parameters[18].Value = model.sale_edate;
			parameters[19].Value = model.AddTime;
			parameters[20].Value = model.IsUpload;
			parameters[21].Value = model.IsUpdate;

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
		public bool Update(Sanben.Model.Ticket380Policy model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Ticket380Policy set ");
			strSql.Append("policy_id=@policy_id,");
			strSql.Append("air_comp=@air_comp,");
			strSql.Append("start_city=@start_city,");
			strSql.Append("arr_city=@arr_city,");
			strSql.Append("flight=@flight,");
			strSql.Append("cabin=@cabin,");
			strSql.Append("share_line=@share_line,");
			strSql.Append("cabinprice=@cabinprice,");
			strSql.Append("point=@point,");
			strSql.Append("nakednum=@nakednum,");
			strSql.Append("is_auto_tic=@is_auto_tic,");
			strSql.Append("logtime=@logtime,");
			strSql.Append("deptime=@deptime,");
			strSql.Append("price=@price,");
			strSql.Append("remark=@remark,");
			strSql.Append("fsdate=@fsdate,");
			strSql.Append("fedate=@fedate,");
			strSql.Append("sale_sdate=@sale_sdate,");
			strSql.Append("sale_edate=@sale_edate,");
			strSql.Append("AddTime=@AddTime,");
			strSql.Append("IsUpload=@IsUpload,");
			strSql.Append("IsUpdate=@IsUpdate");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@policy_id", SqlDbType.NVarChar,255),
					new SqlParameter("@air_comp", SqlDbType.NVarChar,255),
					new SqlParameter("@start_city", SqlDbType.NVarChar,255),
					new SqlParameter("@arr_city", SqlDbType.NVarChar,255),
					new SqlParameter("@flight", SqlDbType.NVarChar,255),
					new SqlParameter("@cabin", SqlDbType.NVarChar,255),
					new SqlParameter("@share_line", SqlDbType.NVarChar,255),
					new SqlParameter("@cabinprice", SqlDbType.NVarChar,255),
					new SqlParameter("@point", SqlDbType.NVarChar,255),
					new SqlParameter("@nakednum", SqlDbType.NVarChar,255),
					new SqlParameter("@is_auto_tic", SqlDbType.NVarChar,255),
					new SqlParameter("@logtime", SqlDbType.NVarChar,255),
					new SqlParameter("@deptime", SqlDbType.NVarChar,255),
					new SqlParameter("@price", SqlDbType.NVarChar,255),
					new SqlParameter("@remark", SqlDbType.NVarChar,255),
					new SqlParameter("@fsdate", SqlDbType.NVarChar,255),
					new SqlParameter("@fedate", SqlDbType.NVarChar,255),
					new SqlParameter("@sale_sdate", SqlDbType.NVarChar,255),
					new SqlParameter("@sale_edate", SqlDbType.NVarChar,255),
					new SqlParameter("@AddTime", SqlDbType.DateTime),
					new SqlParameter("@IsUpload", SqlDbType.Bit,1),
					new SqlParameter("@IsUpdate", SqlDbType.Bit,1),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.policy_id;
			parameters[1].Value = model.air_comp;
			parameters[2].Value = model.start_city;
			parameters[3].Value = model.arr_city;
			parameters[4].Value = model.flight;
			parameters[5].Value = model.cabin;
			parameters[6].Value = model.share_line;
			parameters[7].Value = model.cabinprice;
			parameters[8].Value = model.point;
			parameters[9].Value = model.nakednum;
			parameters[10].Value = model.is_auto_tic;
			parameters[11].Value = model.logtime;
			parameters[12].Value = model.deptime;
			parameters[13].Value = model.price;
			parameters[14].Value = model.remark;
			parameters[15].Value = model.fsdate;
			parameters[16].Value = model.fedate;
			parameters[17].Value = model.sale_sdate;
			parameters[18].Value = model.sale_edate;
			parameters[19].Value = model.AddTime;
			parameters[20].Value = model.IsUpload;
			parameters[21].Value = model.IsUpdate;
			parameters[22].Value = model.ID;

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
			strSql.Append("delete from Ticket380Policy ");
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
			strSql.Append("delete from Ticket380Policy ");
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
		public Sanben.Model.Ticket380Policy GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,policy_id,air_comp,start_city,arr_city,flight,cabin,share_line,cabinprice,point,nakednum,is_auto_tic,logtime,deptime,price,remark,fsdate,fedate,sale_sdate,sale_edate,AddTime,IsUpload,IsUpdate from Ticket380Policy ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Sanben.Model.Ticket380Policy model=new Sanben.Model.Ticket380Policy();
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
		public Sanben.Model.Ticket380Policy DataRowToModel(DataRow row)
		{
			Sanben.Model.Ticket380Policy model=new Sanben.Model.Ticket380Policy();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["policy_id"]!=null)
				{
					model.policy_id=row["policy_id"].ToString();
				}
				if(row["air_comp"]!=null)
				{
					model.air_comp=row["air_comp"].ToString();
				}
				if(row["start_city"]!=null)
				{
					model.start_city=row["start_city"].ToString();
				}
				if(row["arr_city"]!=null)
				{
					model.arr_city=row["arr_city"].ToString();
				}
				if(row["flight"]!=null)
				{
					model.flight=row["flight"].ToString();
				}
				if(row["cabin"]!=null)
				{
					model.cabin=row["cabin"].ToString();
				}
				if(row["share_line"]!=null)
				{
					model.share_line=row["share_line"].ToString();
				}
				if(row["cabinprice"]!=null)
				{
					model.cabinprice=row["cabinprice"].ToString();
				}
				if(row["point"]!=null)
				{
					model.point=row["point"].ToString();
				}
				if(row["nakednum"]!=null)
				{
					model.nakednum=row["nakednum"].ToString();
				}
				if(row["is_auto_tic"]!=null)
				{
					model.is_auto_tic=row["is_auto_tic"].ToString();
				}
				if(row["logtime"]!=null)
				{
					model.logtime=row["logtime"].ToString();
				}
				if(row["deptime"]!=null)
				{
					model.deptime=row["deptime"].ToString();
				}
				if(row["price"]!=null)
				{
					model.price=row["price"].ToString();
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["fsdate"]!=null)
				{
					model.fsdate=row["fsdate"].ToString();
				}
				if(row["fedate"]!=null)
				{
					model.fedate=row["fedate"].ToString();
				}
				if(row["sale_sdate"]!=null)
				{
					model.sale_sdate=row["sale_sdate"].ToString();
				}
				if(row["sale_edate"]!=null)
				{
					model.sale_edate=row["sale_edate"].ToString();
				}
				if(row["AddTime"]!=null && row["AddTime"].ToString()!="")
				{
					model.AddTime=DateTime.Parse(row["AddTime"].ToString());
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
			strSql.Append("select ID,policy_id,air_comp,start_city,arr_city,flight,cabin,share_line,cabinprice,point,nakednum,is_auto_tic,logtime,deptime,price,remark,fsdate,fedate,sale_sdate,sale_edate,AddTime,IsUpload,IsUpdate ");
			strSql.Append(" FROM Ticket380Policy ");
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
			strSql.Append(" ID,policy_id,air_comp,start_city,arr_city,flight,cabin,share_line,cabinprice,point,nakednum,is_auto_tic,logtime,deptime,price,remark,fsdate,fedate,sale_sdate,sale_edate,AddTime,IsUpload,IsUpdate ");
			strSql.Append(" FROM Ticket380Policy ");
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
			strSql.Append("select count(1) FROM Ticket380Policy ");
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
			strSql.Append(")AS Row, T.*  from Ticket380Policy T ");
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
			parameters[0].Value = "Ticket380Policy";
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

