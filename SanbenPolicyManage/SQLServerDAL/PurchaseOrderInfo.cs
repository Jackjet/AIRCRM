using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:PurchaseOrderInfo
	/// </summary>
	public partial class PurchaseOrderInfo:IPurchaseOrderInfo
	{
		public PurchaseOrderInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "PurchaseOrderInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PurchaseOrderInfo");
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
		public int Add(Sanben.Model.PurchaseOrderInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PurchaseOrderInfo(");
			strSql.Append("price,issue_ticket_type,issue_ticket_platform_code,source_transaction_id,source_order_no,tpp_type,status,pay_commercial_no,offline_pay_type,offline_pay_cardno,platform_mem_id,operator,refund_price,o_id)");
			strSql.Append(" values (");
			strSql.Append("@price,@issue_ticket_type,@issue_ticket_platform_code,@source_transaction_id,@source_order_no,@tpp_type,@status,@pay_commercial_no,@offline_pay_type,@offline_pay_cardno,@platform_mem_id,@operator,@refund_price,@o_id)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@price", SqlDbType.VarChar,50),
					new SqlParameter("@issue_ticket_type", SqlDbType.VarChar,50),
					new SqlParameter("@issue_ticket_platform_code", SqlDbType.VarChar,50),
					new SqlParameter("@source_transaction_id", SqlDbType.VarChar,50),
					new SqlParameter("@source_order_no", SqlDbType.VarChar,50),
					new SqlParameter("@tpp_type", SqlDbType.VarChar,50),
					new SqlParameter("@status", SqlDbType.VarChar,50),
					new SqlParameter("@pay_commercial_no", SqlDbType.VarChar,50),
					new SqlParameter("@offline_pay_type", SqlDbType.VarChar,50),
					new SqlParameter("@offline_pay_cardno", SqlDbType.VarChar,50),
					new SqlParameter("@platform_mem_id", SqlDbType.VarChar,50),
					new SqlParameter("@operator", SqlDbType.VarChar,50),
					new SqlParameter("@refund_price", SqlDbType.VarChar,50),
					new SqlParameter("@o_id", SqlDbType.Int,4)};
			parameters[0].Value = model.price;
			parameters[1].Value = model.issue_ticket_type;
			parameters[2].Value = model.issue_ticket_platform_code;
			parameters[3].Value = model.source_transaction_id;
			parameters[4].Value = model.source_order_no;
			parameters[5].Value = model.tpp_type;
			parameters[6].Value = model.status;
			parameters[7].Value = model.pay_commercial_no;
			parameters[8].Value = model.offline_pay_type;
			parameters[9].Value = model.offline_pay_cardno;
			parameters[10].Value = model.platform_mem_id;
			parameters[11].Value = model.PurchaseOperator;
			parameters[12].Value = model.refund_price;
			parameters[13].Value = model.o_id;

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
		public bool Update(Sanben.Model.PurchaseOrderInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PurchaseOrderInfo set ");
			strSql.Append("price=@price,");
			strSql.Append("issue_ticket_type=@issue_ticket_type,");
			strSql.Append("issue_ticket_platform_code=@issue_ticket_platform_code,");
			strSql.Append("source_transaction_id=@source_transaction_id,");
			strSql.Append("source_order_no=@source_order_no,");
			strSql.Append("tpp_type=@tpp_type,");
			strSql.Append("status=@status,");
			strSql.Append("pay_commercial_no=@pay_commercial_no,");
			strSql.Append("offline_pay_type=@offline_pay_type,");
			strSql.Append("offline_pay_cardno=@offline_pay_cardno,");
			strSql.Append("platform_mem_id=@platform_mem_id,");
			strSql.Append("operator=@operator,");
			strSql.Append("refund_price=@refund_price,");
			strSql.Append("o_id=@o_id");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@price", SqlDbType.VarChar,50),
					new SqlParameter("@issue_ticket_type", SqlDbType.VarChar,50),
					new SqlParameter("@issue_ticket_platform_code", SqlDbType.VarChar,50),
					new SqlParameter("@source_transaction_id", SqlDbType.VarChar,50),
					new SqlParameter("@source_order_no", SqlDbType.VarChar,50),
					new SqlParameter("@tpp_type", SqlDbType.VarChar,50),
					new SqlParameter("@status", SqlDbType.VarChar,50),
					new SqlParameter("@pay_commercial_no", SqlDbType.VarChar,50),
					new SqlParameter("@offline_pay_type", SqlDbType.VarChar,50),
					new SqlParameter("@offline_pay_cardno", SqlDbType.VarChar,50),
					new SqlParameter("@platform_mem_id", SqlDbType.VarChar,50),
					new SqlParameter("@operator", SqlDbType.VarChar,50),
					new SqlParameter("@refund_price", SqlDbType.VarChar,50),
					new SqlParameter("@o_id", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.price;
			parameters[1].Value = model.issue_ticket_type;
			parameters[2].Value = model.issue_ticket_platform_code;
			parameters[3].Value = model.source_transaction_id;
			parameters[4].Value = model.source_order_no;
			parameters[5].Value = model.tpp_type;
			parameters[6].Value = model.status;
			parameters[7].Value = model.pay_commercial_no;
			parameters[8].Value = model.offline_pay_type;
			parameters[9].Value = model.offline_pay_cardno;
			parameters[10].Value = model.platform_mem_id;
			parameters[11].Value = model.PurchaseOperator;
			parameters[12].Value = model.refund_price;
			parameters[13].Value = model.o_id;
			parameters[14].Value = model.id;

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
			strSql.Append("delete from PurchaseOrderInfo ");
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
			strSql.Append("delete from PurchaseOrderInfo ");
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
		public Sanben.Model.PurchaseOrderInfo GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,price,issue_ticket_type,issue_ticket_platform_code,source_transaction_id,source_order_no,tpp_type,status,pay_commercial_no,offline_pay_type,offline_pay_cardno,platform_mem_id,operator,refund_price,o_id from PurchaseOrderInfo ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Sanben.Model.PurchaseOrderInfo model=new Sanben.Model.PurchaseOrderInfo();
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
		public Sanben.Model.PurchaseOrderInfo DataRowToModel(DataRow row)
		{
			Sanben.Model.PurchaseOrderInfo model=new Sanben.Model.PurchaseOrderInfo();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["price"]!=null)
				{
					model.price=row["price"].ToString();
				}
				if(row["issue_ticket_type"]!=null)
				{
					model.issue_ticket_type=row["issue_ticket_type"].ToString();
				}
				if(row["issue_ticket_platform_code"]!=null)
				{
					model.issue_ticket_platform_code=row["issue_ticket_platform_code"].ToString();
				}
				if(row["source_transaction_id"]!=null)
				{
					model.source_transaction_id=row["source_transaction_id"].ToString();
				}
				if(row["source_order_no"]!=null)
				{
					model.source_order_no=row["source_order_no"].ToString();
				}
				if(row["tpp_type"]!=null)
				{
					model.tpp_type=row["tpp_type"].ToString();
				}
				if(row["status"]!=null)
				{
					model.status=row["status"].ToString();
				}
				if(row["pay_commercial_no"]!=null)
				{
					model.pay_commercial_no=row["pay_commercial_no"].ToString();
				}
				if(row["offline_pay_type"]!=null)
				{
					model.offline_pay_type=row["offline_pay_type"].ToString();
				}
				if(row["offline_pay_cardno"]!=null)
				{
					model.offline_pay_cardno=row["offline_pay_cardno"].ToString();
				}
				if(row["platform_mem_id"]!=null)
				{
					model.platform_mem_id=row["platform_mem_id"].ToString();
				}
				if(row["operator"]!=null)
				{
					model.PurchaseOperator =row["operator"].ToString();
				}
				if(row["refund_price"]!=null)
				{
					model.refund_price=row["refund_price"].ToString();
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
			strSql.Append("select id,price,issue_ticket_type,issue_ticket_platform_code,source_transaction_id,source_order_no,tpp_type,status,pay_commercial_no,offline_pay_type,offline_pay_cardno,platform_mem_id,operator,refund_price,o_id ");
			strSql.Append(" FROM PurchaseOrderInfo ");
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
			strSql.Append(" id,price,issue_ticket_type,issue_ticket_platform_code,source_transaction_id,source_order_no,tpp_type,status,pay_commercial_no,offline_pay_type,offline_pay_cardno,platform_mem_id,operator,refund_price,o_id ");
			strSql.Append(" FROM PurchaseOrderInfo ");
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
			strSql.Append("select count(1) FROM PurchaseOrderInfo ");
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
			strSql.Append(")AS Row, T.*  from PurchaseOrderInfo T ");
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
			parameters[0].Value = "PurchaseOrderInfo";
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

