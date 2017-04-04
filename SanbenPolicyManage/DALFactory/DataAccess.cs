using System;
using System.Reflection;
using System.Configuration;
namespace Sanben.DALFactory
{
	/// <summary>
    /// Abstract Factory pattern to create the DAL。
    /// 如果在这里创建对象报错，请检查web.config里是否修改了<add key="DAL" value="Maticsoft.SQLServerDAL" />。
	/// </summary>
	public sealed class DataAccess 
	{
        private static readonly string AssemblyPath = ConfigurationManager.AppSettings["DAL"];        
		public DataAccess()
		{ }

        #region CreateObject 

		//不使用缓存
        private static object CreateObjectNoCache(string AssemblyPath,string classNamespace)
		{		
			try
			{
				object objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);	
				return objType;
			}
			catch//(System.Exception ex)
			{
				//string str=ex.Message;// 记录错误日志
				return null;
			}			
			
        }
		//使用缓存
		private static object CreateObject(string AssemblyPath,string classNamespace)
		{			
			object objType = DataCache.GetCache(classNamespace);
			if (objType == null)
			{
				try
				{
					objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);					
					DataCache.SetCache(classNamespace, objType);// 写入缓存
				}
				catch//(System.Exception ex)
				{
					//string str=ex.Message;// 记录错误日志
				}
			}
			return objType;
		}
        #endregion

        #region 泛型生成
        ///// <summary>
        ///// 创建数据层接口。
        ///// </summary>
        //public static t Create(string ClassName)
        //{

        //    string ClassNamespace = AssemblyPath +"."+ ClassName;
        //    object objType = CreateObject(AssemblyPath, ClassNamespace);
        //    return (t)objType;
        //}
        #endregion

        #region CreateSysManage
        public static Sanben.IDAL.ISysManage CreateSysManage()
		{
			//方式1			
			//return (Sanben.IDAL.ISysManage)Assembly.Load(AssemblyPath).CreateInstance(AssemblyPath+".SysManage");

			//方式2 			
			string classNamespace = AssemblyPath+".SysManage";	
			object objType=CreateObject(AssemblyPath,classNamespace);
            return (Sanben.IDAL.ISysManage)objType;		
		}
		#endregion
             
        
   
		/// <summary>
		/// 创建517NaBenefit数据层接口。
		/// </summary>
		public static Sanben.IDAL.I517NaBenefit Create517NaBenefit()
		{

			string ClassNamespace = AssemblyPath +".517NaBenefit";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.I517NaBenefit)objType;
		}


		/// <summary>
		/// 创建51bookPolicy数据层接口。
		/// </summary>
		public static Sanben.IDAL.I51bookPolicy Create51bookPolicy()
		{

			string ClassNamespace = AssemblyPath +".51bookPolicy";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.I51bookPolicy)objType;
		}


		/// <summary>
		/// 创建AirComMan数据层接口。
		/// </summary>
		public static Sanben.IDAL.IAirComMan CreateAirComMan()
		{

			string ClassNamespace = AssemblyPath +".AirComMan";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IAirComMan)objType;
		}


		/// <summary>
		/// 创建AirMan数据层接口。
		/// </summary>
		public static Sanben.IDAL.IAirMan CreateAirMan()
		{

			string ClassNamespace = AssemblyPath +".AirMan";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IAirMan)objType;
		}


		/// <summary>
		/// 创建Airport_Detail数据层接口。
		/// </summary>
		public static Sanben.IDAL.IAirport_Detail CreateAirport_Detail()
		{

			string ClassNamespace = AssemblyPath +".Airport_Detail";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IAirport_Detail)objType;
		}


		/// <summary>
		/// 创建Airport_Unknown数据层接口。
		/// </summary>
		public static Sanben.IDAL.IAirport_Unknown CreateAirport_Unknown()
		{

			string ClassNamespace = AssemblyPath +".Airport_Unknown";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IAirport_Unknown)objType;
		}


		/// <summary>
		/// 创建API380Ticket数据层接口。
		/// </summary>
		public static Sanben.IDAL.IAPI380Ticket CreateAPI380Ticket()
		{

			string ClassNamespace = AssemblyPath +".API380Ticket";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IAPI380Ticket)objType;
		}


		/// <summary>
		/// 创建BackupFlight数据层接口。
		/// </summary>
		public static Sanben.IDAL.IBackupFlight CreateBackupFlight()
		{

			string ClassNamespace = AssemblyPath +".BackupFlight";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IBackupFlight)objType;
		}


		/// <summary>
		/// 创建BackupInsurance数据层接口。
		/// </summary>
		public static Sanben.IDAL.IBackupInsurance CreateBackupInsurance()
		{

			string ClassNamespace = AssemblyPath +".BackupInsurance";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IBackupInsurance)objType;
		}


		/// <summary>
		/// 创建BackupLog_Opera数据层接口。
		/// </summary>
		public static Sanben.IDAL.IBackupLog_Opera CreateBackupLog_Opera()
		{

			string ClassNamespace = AssemblyPath +".BackupLog_Opera";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IBackupLog_Opera)objType;
		}


		/// <summary>
		/// 创建BackupOrderInfo数据层接口。
		/// </summary>
		public static Sanben.IDAL.IBackupOrderInfo CreateBackupOrderInfo()
		{

			string ClassNamespace = AssemblyPath +".BackupOrderInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IBackupOrderInfo)objType;
		}


		/// <summary>
		/// 创建BackupPassenger数据层接口。
		/// </summary>
		public static Sanben.IDAL.IBackupPassenger CreateBackupPassenger()
		{

			string ClassNamespace = AssemblyPath +".BackupPassenger";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IBackupPassenger)objType;
		}


		/// <summary>
		/// 创建BackupPurchaseOrderInfo数据层接口。
		/// </summary>
		public static Sanben.IDAL.IBackupPurchaseOrderInfo CreateBackupPurchaseOrderInfo()
		{

			string ClassNamespace = AssemblyPath +".BackupPurchaseOrderInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IBackupPurchaseOrderInfo)objType;
		}


		/// <summary>
		/// 创建BackupRefund数据层接口。
		/// </summary>
		public static Sanben.IDAL.IBackupRefund CreateBackupRefund()
		{

			string ClassNamespace = AssemblyPath +".BackupRefund";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IBackupRefund)objType;
		}


		/// <summary>
		/// 创建BaQianYiPolicy数据层接口。
		/// </summary>
		public static Sanben.IDAL.IBaQianYiPolicy CreateBaQianYiPolicy()
		{

			string ClassNamespace = AssemblyPath +".BaQianYiPolicy";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IBaQianYiPolicy)objType;
		}


		/// <summary>
		/// 创建cabin_description数据层接口。
		/// </summary>
		public static Sanben.IDAL.Icabin_description Createcabin_description()
		{

			string ClassNamespace = AssemblyPath +".cabin_description";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Icabin_description)objType;
		}


		/// <summary>
		/// 创建City_Man数据层接口。
		/// </summary>
		public static Sanben.IDAL.ICity_Man CreateCity_Man()
		{

			string ClassNamespace = AssemblyPath +".City_Man";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.ICity_Man)objType;
		}


		/// <summary>
		/// 创建City_Man1数据层接口。
		/// </summary>
		public static Sanben.IDAL.ICity_Man1 CreateCity_Man1()
		{

			string ClassNamespace = AssemblyPath +".City_Man1";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.ICity_Man1)objType;
		}


		/// <summary>
		/// 创建ctripPolicyGaiqian数据层接口。
		/// </summary>
		public static Sanben.IDAL.IctripPolicyGaiqian CreatectripPolicyGaiqian()
		{

			string ClassNamespace = AssemblyPath +".ctripPolicyGaiqian";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IctripPolicyGaiqian)objType;
		}


		/// <summary>
		/// 创建ctripPolicyOptions数据层接口。
		/// </summary>
		public static Sanben.IDAL.IctripPolicyOptions CreatectripPolicyOptions()
		{

			string ClassNamespace = AssemblyPath +".ctripPolicyOptions";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IctripPolicyOptions)objType;
		}


		/// <summary>
		/// 创建ctripPolicyRebate数据层接口。
		/// </summary>
		public static Sanben.IDAL.IctripPolicyRebate CreatectripPolicyRebate()
		{

			string ClassNamespace = AssemblyPath +".ctripPolicyRebate";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IctripPolicyRebate)objType;
		}


		/// <summary>
		/// 创建DeletePolicy数据层接口。
		/// </summary>
		public static Sanben.IDAL.IDeletePolicy CreateDeletePolicy()
		{

			string ClassNamespace = AssemblyPath +".DeletePolicy";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IDeletePolicy)objType;
		}


		/// <summary>
		/// 创建EtermRT数据层接口。
		/// </summary>
		public static Sanben.IDAL.IEtermRT CreateEtermRT()
		{

			string ClassNamespace = AssemblyPath +".EtermRT";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IEtermRT)objType;
		}


		/// <summary>
		/// 创建excGetRateList数据层接口。
		/// </summary>
		public static Sanben.IDAL.IexcGetRateList CreateexcGetRateList()
		{

			string ClassNamespace = AssemblyPath +".excGetRateList";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IexcGetRateList)objType;
		}


		/// <summary>
		/// 创建Flight数据层接口。
		/// </summary>
		public static Sanben.IDAL.IFlight CreateFlight()
		{

			string ClassNamespace = AssemblyPath +".Flight";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IFlight)objType;
		}


		/// <summary>
		/// 创建gaiqian_retirement数据层接口。
		/// </summary>
		public static Sanben.IDAL.Igaiqian_retirement Creategaiqian_retirement()
		{

			string ClassNamespace = AssemblyPath +".gaiqian_retirement";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Igaiqian_retirement)objType;
		}


		/// <summary>
		/// 创建GaiQianWangFanRetirement数据层接口。
		/// </summary>
		public static Sanben.IDAL.IGaiQianWangFanRetirement CreateGaiQianWangFanRetirement()
		{

			string ClassNamespace = AssemblyPath +".GaiQianWangFanRetirement";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IGaiQianWangFanRetirement)objType;
		}


		/// <summary>
		/// 创建GetRateList数据层接口。
		/// </summary>
		public static Sanben.IDAL.IGetRateList CreateGetRateList()
		{

			string ClassNamespace = AssemblyPath +".GetRateList";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IGetRateList)objType;
		}


		/// <summary>
		/// 创建Insurance数据层接口。
		/// </summary>
		public static Sanben.IDAL.IInsurance CreateInsurance()
		{

			string ClassNamespace = AssemblyPath +".Insurance";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IInsurance)objType;
		}


		/// <summary>
		/// 创建Jinri_Order_Response数据层接口。
		/// </summary>
		public static Sanben.IDAL.IJinri_Order_Response CreateJinri_Order_Response()
		{

			string ClassNamespace = AssemblyPath +".Jinri_Order_Response";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IJinri_Order_Response)objType;
		}


		/// <summary>
		/// 创建JinRiOrderByPnr数据层接口。
		/// </summary>
		public static Sanben.IDAL.IJinRiOrderByPnr CreateJinRiOrderByPnr()
		{

			string ClassNamespace = AssemblyPath +".JinRiOrderByPnr";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IJinRiOrderByPnr)objType;
		}


		/// <summary>
		/// 创建kuXunPolicyOptions数据层接口。
		/// </summary>
		public static Sanben.IDAL.IkuXunPolicyOptions CreatekuXunPolicyOptions()
		{

			string ClassNamespace = AssemblyPath +".kuXunPolicyOptions";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IkuXunPolicyOptions)objType;
		}


		/// <summary>
		/// 创建Log_Opera数据层接口。
		/// </summary>
		public static Sanben.IDAL.ILog_Opera CreateLog_Opera()
		{

			string ClassNamespace = AssemblyPath +".Log_Opera";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.ILog_Opera)objType;
		}


		/// <summary>
		/// 创建menu数据层接口。
		/// </summary>
		public static Sanben.IDAL.Imenu Createmenu()
		{

			string ClassNamespace = AssemblyPath +".menu";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Imenu)objType;
		}


		/// <summary>
		/// 创建NewOrderInfo数据层接口。
		/// </summary>
		public static Sanben.IDAL.INewOrderInfo CreateNewOrderInfo()
		{

			string ClassNamespace = AssemblyPath +".NewOrderInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.INewOrderInfo)objType;
		}


		/// <summary>
		/// 创建Orderinfo数据层接口。
		/// </summary>
		public static Sanben.IDAL.IOrderinfo CreateOrderinfo()
		{

			string ClassNamespace = AssemblyPath +".Orderinfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IOrderinfo)objType;
		}


		/// <summary>
		/// 创建OrderInfo2数据层接口。
		/// </summary>
		public static Sanben.IDAL.IOrderInfo2 CreateOrderInfo2()
		{

			string ClassNamespace = AssemblyPath +".OrderInfo2";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IOrderInfo2)objType;
		}


		/// <summary>
		/// 创建orderInterfaceConfig数据层接口。
		/// </summary>
		public static Sanben.IDAL.IorderInterfaceConfig CreateorderInterfaceConfig()
		{

			string ClassNamespace = AssemblyPath +".orderInterfaceConfig";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IorderInterfaceConfig)objType;
		}


		/// <summary>
		/// 创建orderUser数据层接口。
		/// </summary>
		public static Sanben.IDAL.IorderUser CreateorderUser()
		{

			string ClassNamespace = AssemblyPath +".orderUser";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IorderUser)objType;
		}


		/// <summary>
		/// 创建Passenger数据层接口。
		/// </summary>
		public static Sanben.IDAL.IPassenger CreatePassenger()
		{

			string ClassNamespace = AssemblyPath +".Passenger";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IPassenger)objType;
		}


		/// <summary>
		/// 创建platform_config数据层接口。
		/// </summary>
		public static Sanben.IDAL.Iplatform_config Createplatform_config()
		{

			string ClassNamespace = AssemblyPath +".platform_config";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Iplatform_config)objType;
		}


		/// <summary>
		/// 创建Platform_type数据层接口。
		/// </summary>
		public static Sanben.IDAL.IPlatform_type CreatePlatform_type()
		{

			string ClassNamespace = AssemblyPath +".Platform_type";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IPlatform_type)objType;
		}


		/// <summary>
		/// 创建platformB2B_name数据层接口。
		/// </summary>
		public static Sanben.IDAL.IplatformB2B_name CreateplatformB2B_name()
		{

			string ClassNamespace = AssemblyPath +".platformB2B_name";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IplatformB2B_name)objType;
		}


		/// <summary>
		/// 创建platformB2B_ticket_account数据层接口。
		/// </summary>
		public static Sanben.IDAL.IplatformB2B_ticket_account CreateplatformB2B_ticket_account()
		{

			string ClassNamespace = AssemblyPath +".platformB2B_ticket_account";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IplatformB2B_ticket_account)objType;
		}


		/// <summary>
		/// 创建Platfrom_ZY_type数据层接口。
		/// </summary>
		public static Sanben.IDAL.IPlatfrom_ZY_type CreatePlatfrom_ZY_type()
		{

			string ClassNamespace = AssemblyPath +".Platfrom_ZY_type";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IPlatfrom_ZY_type)objType;
		}


		/// <summary>
		/// 创建Policy数据层接口。
		/// </summary>
		public static Sanben.IDAL.IPolicy CreatePolicy()
		{

			string ClassNamespace = AssemblyPath +".Policy";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IPolicy)objType;
		}


		/// <summary>
		/// 创建Policy_filter数据层接口。
		/// </summary>
		public static Sanben.IDAL.IPolicy_filter CreatePolicy_filter()
		{

			string ClassNamespace = AssemblyPath +".Policy_filter";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IPolicy_filter)objType;
		}


		/// <summary>
		/// 创建Policy_filter_wangfan数据层接口。
		/// </summary>
		public static Sanben.IDAL.IPolicy_filter_wangfan CreatePolicy_filter_wangfan()
		{

			string ClassNamespace = AssemblyPath +".Policy_filter_wangfan";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IPolicy_filter_wangfan)objType;
		}


		/// <summary>
		/// 创建Policy_Mission数据层接口。
		/// </summary>
		public static Sanben.IDAL.IPolicy_Mission CreatePolicy_Mission()
		{

			string ClassNamespace = AssemblyPath +".Policy_Mission";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IPolicy_Mission)objType;
		}


		/// <summary>
		/// 创建policy_options数据层接口。
		/// </summary>
		public static Sanben.IDAL.Ipolicy_options Createpolicy_options()
		{

			string ClassNamespace = AssemblyPath +".policy_options";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Ipolicy_options)objType;
		}


		/// <summary>
		/// 创建policy_options_wangfan数据层接口。
		/// </summary>
		public static Sanben.IDAL.Ipolicy_options_wangfan Createpolicy_options_wangfan()
		{

			string ClassNamespace = AssemblyPath +".policy_options_wangfan";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Ipolicy_options_wangfan)objType;
		}


		/// <summary>
		/// 创建policy_zy_addPrice数据层接口。
		/// </summary>
		public static Sanben.IDAL.Ipolicy_zy_addPrice Createpolicy_zy_addPrice()
		{

			string ClassNamespace = AssemblyPath +".policy_zy_addPrice";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Ipolicy_zy_addPrice)objType;
		}


		/// <summary>
		/// 创建policy_zy_Base数据层接口。
		/// </summary>
		public static Sanben.IDAL.Ipolicy_zy_Base Createpolicy_zy_Base()
		{

			string ClassNamespace = AssemblyPath +".policy_zy_Base";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Ipolicy_zy_Base)objType;
		}


		/// <summary>
		/// 创建policy_zy_filter数据层接口。
		/// </summary>
		public static Sanben.IDAL.Ipolicy_zy_filter Createpolicy_zy_filter()
		{

			string ClassNamespace = AssemblyPath +".policy_zy_filter";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Ipolicy_zy_filter)objType;
		}


		/// <summary>
		/// 创建policy_zy_leavepoint数据层接口。
		/// </summary>
		public static Sanben.IDAL.Ipolicy_zy_leavepoint Createpolicy_zy_leavepoint()
		{

			string ClassNamespace = AssemblyPath +".policy_zy_leavepoint";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Ipolicy_zy_leavepoint)objType;
		}


		/// <summary>
		/// 创建policy_zy_pat数据层接口。
		/// </summary>
		public static Sanben.IDAL.Ipolicy_zy_pat Createpolicy_zy_pat()
		{

			string ClassNamespace = AssemblyPath +".policy_zy_pat";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Ipolicy_zy_pat)objType;
		}


		/// <summary>
		/// 创建policy_zy_space数据层接口。
		/// </summary>
		public static Sanben.IDAL.Ipolicy_zy_space Createpolicy_zy_space()
		{

			string ClassNamespace = AssemblyPath +".policy_zy_space";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Ipolicy_zy_space)objType;
		}


		/// <summary>
		/// 创建policy_zy_ticket数据层接口。
		/// </summary>
		public static Sanben.IDAL.Ipolicy_zy_ticket Createpolicy_zy_ticket()
		{

			string ClassNamespace = AssemblyPath +".policy_zy_ticket";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Ipolicy_zy_ticket)objType;
		}


		/// <summary>
		/// 创建policy_zy_tuigaiqian数据层接口。
		/// </summary>
		public static Sanben.IDAL.Ipolicy_zy_tuigaiqian Createpolicy_zy_tuigaiqian()
		{

			string ClassNamespace = AssemblyPath +".policy_zy_tuigaiqian";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Ipolicy_zy_tuigaiqian)objType;
		}


		/// <summary>
		/// 创建PurchaseOrderInfo数据层接口。
		/// </summary>
		public static Sanben.IDAL.IPurchaseOrderInfo CreatePurchaseOrderInfo()
		{

			string ClassNamespace = AssemblyPath +".PurchaseOrderInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IPurchaseOrderInfo)objType;
		}


		/// <summary>
		/// 创建rebate数据层接口。
		/// </summary>
		public static Sanben.IDAL.Irebate Createrebate()
		{

			string ClassNamespace = AssemblyPath +".rebate";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Irebate)objType;
		}


		/// <summary>
		/// 创建rebate_wangfan数据层接口。
		/// </summary>
		public static Sanben.IDAL.Irebate_wangfan Createrebate_wangfan()
		{

			string ClassNamespace = AssemblyPath +".rebate_wangfan";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Irebate_wangfan)objType;
		}


		/// <summary>
		/// 创建refund数据层接口。
		/// </summary>
		public static Sanben.IDAL.Irefund Createrefund()
		{

			string ClassNamespace = AssemblyPath +".refund";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Irefund)objType;
		}


		/// <summary>
		/// 创建Register数据层接口。
		/// </summary>
		public static Sanben.IDAL.IRegister CreateRegister()
		{

			string ClassNamespace = AssemblyPath +".Register";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IRegister)objType;
		}


		/// <summary>
		/// 创建ROUTE数据层接口。
		/// </summary>
		public static Sanben.IDAL.IROUTE CreateROUTE()
		{

			string ClassNamespace = AssemblyPath +".ROUTE";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IROUTE)objType;
		}


		/// <summary>
		/// 创建status数据层接口。
		/// </summary>
		public static Sanben.IDAL.Istatus Createstatus()
		{

			string ClassNamespace = AssemblyPath +".status";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Istatus)objType;
		}


		/// <summary>
		/// 创建Syonline数据层接口。
		/// </summary>
		public static Sanben.IDAL.ISyonline CreateSyonline()
		{

			string ClassNamespace = AssemblyPath +".Syonline";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.ISyonline)objType;
		}


		/// <summary>
		/// 创建SYS_MenuList数据层接口。
		/// </summary>
		public static Sanben.IDAL.ISYS_MenuList CreateSYS_MenuList()
		{

			string ClassNamespace = AssemblyPath +".SYS_MenuList";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.ISYS_MenuList)objType;
		}


		/// <summary>
		/// 创建SYS_Role数据层接口。
		/// </summary>
		public static Sanben.IDAL.ISYS_Role CreateSYS_Role()
		{

			string ClassNamespace = AssemblyPath +".SYS_Role";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.ISYS_Role)objType;
		}


		/// <summary>
		/// 创建sys_user数据层接口。
		/// </summary>
		public static Sanben.IDAL.Isys_user Createsys_user()
		{

			string ClassNamespace = AssemblyPath +".sys_user";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Isys_user)objType;
		}


		/// <summary>
		/// 创建SYSAdminRole数据层接口。
		/// </summary>
		public static Sanben.IDAL.ISYSAdminRole CreateSYSAdminRole()
		{

			string ClassNamespace = AssemblyPath +".SYSAdminRole";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.ISYSAdminRole)objType;
		}


		/// <summary>
		/// 创建sysAdminUser数据层接口。
		/// </summary>
		public static Sanben.IDAL.IsysAdminUser CreatesysAdminUser()
		{

			string ClassNamespace = AssemblyPath +".sysAdminUser";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IsysAdminUser)objType;
		}


		/// <summary>
		/// 创建sysdiagrams数据层接口。1
		/// </summary>
		public static Sanben.IDAL.Isysdiagrams Createsysdiagrams()
		{

			string ClassNamespace = AssemblyPath +".sysdiagrams";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Isysdiagrams)objType;
		}


		/// <summary>
		/// 创建SystemConfig数据层接口。1
		/// </summary>
		public static Sanben.IDAL.ISystemConfig CreateSystemConfig()
		{

			string ClassNamespace = AssemblyPath +".SystemConfig";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.ISystemConfig)objType;
		}


		/// <summary>
		/// 创建T_Airport数据层接口。1
		/// </summary>
		public static Sanben.IDAL.IT_Airport CreateT_Airport()
		{

			string ClassNamespace = AssemblyPath +".T_Airport";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IT_Airport)objType;
		}


		/// <summary>
		/// 创建T_Airport2数据层接口。1
		/// </summary>
		public static Sanben.IDAL.IT_Airport2 CreateT_Airport2()
		{

			string ClassNamespace = AssemblyPath +".T_Airport2";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IT_Airport2)objType;
		}


		/// <summary>
		/// 创建T_Carrier数据层接口。1
		/// </summary>
		public static Sanben.IDAL.IT_Carrier CreateT_Carrier()
		{

			string ClassNamespace = AssemblyPath +".T_Carrier";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IT_Carrier)objType;
		}


		/// <summary>
		/// 创建Table_1数据层接口。1
		/// </summary>
		public static Sanben.IDAL.ITable_1 CreateTable_1()
		{

			string ClassNamespace = AssemblyPath +".Table_1";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.ITable_1)objType;
		}


		/// <summary>
		/// 创建test_ado数据层接口。1
		/// </summary>
		public static Sanben.IDAL.Itest_ado Createtest_ado()
		{

			string ClassNamespace = AssemblyPath +".test_ado";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Itest_ado)objType;
		}


		/// <summary>
		/// 创建testforpolicy数据层接口。1
		/// </summary>
		public static Sanben.IDAL.Itestforpolicy Createtestforpolicy()
		{

			string ClassNamespace = AssemblyPath +".testforpolicy";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Itestforpolicy)objType;
		}


		/// <summary>
		/// 创建Thtest数据层接口。1
		/// </summary>
		public static Sanben.IDAL.IThtest CreateThtest()
		{

			string ClassNamespace = AssemblyPath +".Thtest";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IThtest)objType;
		}


		/// <summary>
		/// 创建Ticket380Policy数据层接口。1
		/// </summary>
		public static Sanben.IDAL.ITicket380Policy CreateTicket380Policy()
		{

			string ClassNamespace = AssemblyPath +".Ticket380Policy";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.ITicket380Policy)objType;
		}


		/// <summary>
		/// 创建time_limit数据层接口。1
		/// </summary>
		public static Sanben.IDAL.Itime_limit Createtime_limit()
		{

			string ClassNamespace = AssemblyPath +".time_limit";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.Itime_limit)objType;
		}


		/// <summary>
		/// 创建UploadPolicyResult数据层接口。1
		/// </summary>
		public static Sanben.IDAL.IUploadPolicyResult CreateUploadPolicyResult()
		{

			string ClassNamespace = AssemblyPath +".UploadPolicyResult";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IUploadPolicyResult)objType;
		}


		/// <summary>
		/// 创建uploadTask数据层接口。
		/// </summary>
		public static Sanben.IDAL.IuploadTask CreateuploadTask()
		{

			string ClassNamespace = AssemblyPath +".uploadTask";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.IuploadTask)objType;
		}


		/// <summary>
		/// 创建查询数据层接口。1
		/// </summary>
		public static Sanben.IDAL.I查询 Create查询()
		{

			string ClassNamespace = AssemblyPath +".查询";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Sanben.IDAL.I查询)objType;
		}

        /// <summary>
        /// 创建uploadTask数据层接口。
        /// </summary>
        public static Sanben.IDAL.IPiaomeng_policy CreatePiaomeng_policy()
        {

            string ClassNamespace = AssemblyPath + ".Piaomeng_policy";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (Sanben.IDAL.IPiaomeng_policy)objType;
        }

}
}