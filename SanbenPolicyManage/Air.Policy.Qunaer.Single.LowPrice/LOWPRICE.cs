using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air.Policy.Qunaer.Single.Model
{
    /// <summary>
    /// 机票政策-去哪儿-单程-低价
    /// </summary>
    public class LowPrice : PolicyBase
    {
        
        /// <summary>
        /// 政策来源，取标识政策是从什么地方来的，主要是便于出票 (可选)
        /// </summary>
        private string _policySource;
        /// <summary>
        /// 政策来源，取标识政策是从什么地方来的，主要是便于出票 (可选)
        /// </summary>
        public string policySource
        {
            get { return _policySource; }
            set { _policySource = value; }
        }
        
    }
}
