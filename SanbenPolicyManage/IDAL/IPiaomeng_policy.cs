using System;
using System.Data;
namespace Sanben.IDAL
{
	/// <summary>
	/// �ӿڲ�Piaomeng_policy
	/// </summary>
	public interface IPiaomeng_policy
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(int id);
		/// <summary>
		/// ����һ������
		/// </summary>
		int Add(Sanben.Model.Piaomeng_policy model);
		/// <summary>
		/// ����һ������
		/// </summary>
		bool Update(Sanben.Model.Piaomeng_policy model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		bool Delete(int id);
		bool DeleteList(string idlist );
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		Sanben.Model.Piaomeng_policy GetModel(int id);
		Sanben.Model.Piaomeng_policy DataRowToModel(DataRow row);
		/// <summary>
		/// ��������б�
		/// </summary>
		DataSet GetList(string strWhere);
		/// <summary>
		/// ���ǰ��������
		/// </summary>
		DataSet GetList(int Top,string strWhere,string filedOrder);
		int GetRecordCount(string strWhere);
		DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
		/// <summary>
		/// ���ݷ�ҳ��������б�
		/// </summary>
		//DataSet GetList(int PageSize,int PageIndex,string strWhere);
		#endregion  ��Ա����
		#region  MethodEx

		#endregion  MethodEx
	} 
}
