using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air.Policy.Qunaer.Single.Model
{
    /// <summary>
    /// 机票-政策-去哪儿-普通
    /// </summary>
    public class COMMON : PolicyBase
    {
        /// <summary>
        /// 班期限制，1234567表示周一、周二、周三、周四、周五、周六、周日，不能为空
        /// </summary>
        private string _daycondition;
        /// <summary>
        /// 支持代码共享航班，取值“是”或者“否”，默认为“否” (可选)
        /// </summary>
        private string _shared;

        /// <summary>
        /// 班期限制，1234567表示周一、周二、周三、周四、周五、周六、周日，不能为空
        /// </summary>
        public string daycondition
        {
            get { return _daycondition; }
            set { _daycondition = value; }
        }

        /// <summary>
        /// 支持代码共享航班，取值“是”或者“否”，默认为“否” (可选)
        /// </summary>
        public string shared
        {
            get { return _shared; }
            set { _shared = value; }
        }
    }
}
