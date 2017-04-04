using System.Data;
//政策库
namespace PolicyAutoUploadLib.Policy
{
    /// <summary>
    /// 政策自动上传接口
    /// </summary>
    public interface IPolicyAutoUpload
    {
        /// <summary>
        /// 获取政策来源
        /// </summary>
        /// <param name="policySourcesName">政策来源名称</param>
        /// <returns>政策来源数据集</returns>
       DataSet GetPolicySource(string policySourcesName);
       /// <summary>
       /// 根据数据集和平台名生成XML文件
       /// </summary>
       /// <param name="policySet">政策来源数据集</param>
       /// <param name="platformName">上传平台名称</param>
       /// <returns>xml文件名</returns>
       string BuildXmlFile(DataSet policySet ,string platformName);
       /// <summary>
       /// 上传Gzip压缩后的XML文件到对应平台
       /// </summary>
       /// <param name="fileGzip">Gzip压缩后的XML文件名</param>
       /// <param name="platformName">上传平台名称</param>
       void UploadPolicyGzip(string fileGzip,string platformName);
       /// <summary>
       /// 获取任务列表
       /// </summary>
       /// <returns>任务数据集</returns>
       DataSet GetTaskList();
        /// <summary>
        /// 启动任务
        /// </summary>
        void StartTask();
    }
}
