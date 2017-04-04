using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:BackupPassenger
	/// </summary>
	public partial class BackupPassenger:IBackupPassenger
	{
		public BackupPassenger()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "BackupPassenger"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BackupPassenger");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Sanben.Model.BackupPassenger model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BackupPassenger(");
			strSql.Append("id,name,ageType,cardType,price,priceType,cardNum,eticketNum,insuranceCount,bxSource,bxName,o_id)");
			strSql.Append(" values (");
			strSql.Append("@id,@name,@ageType,@cardType,@price,@priceType,@cardNum,@eticketNum,@insuranceCount,@bxSource,@bxName,@o_id)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@ageType", SqlDbType.VarChar,50),
					new SqlParameter("@cardType", SqlDbType.VarChar,50),
					new SqlParameter("@price", SqlDbType.VarChar,50),
					new SqlParameter("@priceType", SqlDbType.VarChar,50),
					new SqlParameter("@cardNum", SqlDbType.VarChar,-1),
					new SqlParameter("@eticketNum", SqlDbType.VarChar,-1),
					new SqlParameter("@insuranceCount", SqlDbType.VarChar,50),
					new SqlParameter("@bxSource", SqlDbType.VarChar,255),
					new SqlParameter("@bxName", SqlDbType.VarChar,255),
					new SqlParameter("@o_id", SqlDbType.Int,4)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.name;
			parameters[2].Value = model.ageType;
			parameters[3].Value = model.cardType;
			parameters[4].Value = model.price;
			parameters[5].Value = model.priceType;
			parameters[6].Value = model.cardNum;
			parameters[7].Value = model.eticketNum;
			parameters[8].Value = model.insuranceCount;
			parameters[9].Value = model.bxSource;
			parameters[10].Value = model.bxName;
			parameters[11].Value = model.o_id;

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
		public bool Update(Sanben.Model.BackupPassenger model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BackupPassenger set ");
			strSql.Append("name=@name,");
			strSql.Append("ageType=@ageType,");
			strSql.Append("cardType=@cardType,");
			strSql.Append("price=@price,");
			strSql.Append("priceType=@priceType,");
			strSql.Append("cardNum=@cardNum,");
			strSql.Append("eticketNum=@eticketNum,");
			strSql.Append("insuranceCount=@insuranceCount,");
			strSql.Append("bxSource=@bxSource,");
			strSql.Append("bxName=@bxName,");
			strSql.Append("o_id=@o_id");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@ageType", SqlDbType.VarChar,50),
					new SqlParameter("@cardType", SqlDbType.VarChar,50),
					new SqlParameter("@price", SqlDbType.VarChar,50),
					new SqlParameter("@priceType", SqlDbType.VarChar,50),
					new SqlParameter("@cardNum", SqlDbType.VarChar,-1),
					new SqlParameter("@eticketNum", SqlDbType.VarChar,-1),
					new SqlParameter("@insuranceCount", SqlDbType.VarChar,50),
					new SqlParameter("@bxSource", SqlDbType.VarChar,255),
					new SqlParameter("@bxName", SqlDbType.VarChar,255),
					new SqlParameter("@o_id", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.ageType;
			parameters[2].Value = model.cardType;
			parameters[3].Value = model.price;
			parameters[4].Value = model.priceType;
			parameters[5].Value = model.cardNum;
			parameters[6].Value = model.eticketNum;
			parameters[7].Value = model.insuranceCount;
			parameters[8].Value = model.bxSource;
			parameters[9].Value = model.bxName;
			parameters[10].Value = model.o_id;
			parameters[11].Value = model.id;

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
			strSql.Append("delete from BackupPassenger ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)			};
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
			strSql.Append("delete from BackupPassenger ");
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
		public Sanben.Model.BackupPassenger GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,name,ageType,cardType,price,priceType,cardNum,eticketNum,insuranceCount,bxSource,bxName,o_id from BackupPassenger ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)			};
			parameters[0].Value = id;

			Sanben.Model.BackupPassenger model=new Sanben.Model.BackupPassenger();
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
		public Sanben.Model.BackupPassenger DataRowToModel(DataRow row)
		{
			Sanben.Model.BackupPassenger model=new Sanben.Model.BackupPassenger();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["ageType"]!=null)
				{
					model.ageType=row["ageType"].ToString();
				}
				if(row["cardType"]!=null)
				{
					model.cardType=row["cardType"].ToString();
				}
				if(row["price"]!=null)
				{
					model.price=row["price"].ToString();
				}
				if(row["priceType"]!=null)
				{
					model.priceType=row["priceType"].ToString();
				}
				if(row["cardNum"]!=null)
				{
					model.cardNum=row["cardNum"].ToString();
				}
				if(row["eticketNum"]!=null)
				{
					model.eticketNum=row["eticketNum"].ToString();
				}
				if(row["insuranceCount"]!=null)
				{
					model.insuranceCount=row["insuranceCount"].ToString();
				}
				if(row["bxSource"]!=null)
				{
					model.bxSource=row["bxSource"].ToString();
				}
				if(row["bxName"]!=null)
				{
					model.bxName=row["bxName"].ToString();
				}
				if(row["o_id"]!=null && row["o_id"].ToString()!="")
				{
					model.o_id=int.Parse(row["o_id"].ToString());
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
			strSql.Append("select id,name,ageType,cardType,price,priceType,cardNum,eticketNum,insuranceCount,bxSource,bxName,o_id ");
			strSql.Append(" FROM BackupPassenger ");
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
			strSql.Append(" id,name,ageType,cardType,price,priceType,cardNum,eticketNum,insuranceCount,bxSource,bxName,o_id ");
			strSql.Append(" FROM BackupPassenger ");
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
			strSql.Append("select count(1) FROM BackupPassenger ");
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
			strSql.Append(")AS Row, T.*  from BackupPassenger T ");
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
			parameters[0].Value = "BackupPassenger";
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

