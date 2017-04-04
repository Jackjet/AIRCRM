using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air.Policy.Qunaer.Single.Model
{
    /// <summary>
    /// 机票-政策-去哪儿-预付
    /// </summary>
    public class PREPAY : PolicyBase
    {
        /// <summary>
        /// 是否可以支付，取值“是”或“否”
        /// </summary>
        private string _canPay;
        /// <summary>
        /// 是否生成PNR，取值“是”或“否”
        /// </summary>
        private string _needPnr;
        /// <summary>
        ///是否进行PAT：A校验，取值“是”或“否” 
        /// </summary>
        private string _pata;
        /// <summary>
        /// 最小购买年龄，大于13的整数；允许购买机票的最小年龄；默认为空表示无年龄下限限制(可选)
        /// </summary>
        private int _minAge;
        /// <summary>
        /// 最大购买年龄，小于70的整数；允许购买机票的最大年龄；默认为空表示无年龄上限限制(可选)
        /// </summary>
        private int _maxAge;
        /// <summary>
        /// 特殊票务说明，填写如下中括号内序号,最多支持4
        //个，中间使用逗号分隔符。
        //【1002】机场无法打印行程单，如需
        // 报销请选择快递行程单。
        //【1004】姓名不能超过6个字。
        //【1005】不支持外宾预定。
        //【1006】不支持英文名字或中文名字
        // 中含字母的乘客预定。
        // 【1007】特殊产品，出票慢，最晚起
        //飞前两小时出票
        /// </summary>
        private string _specialRule;

        /// <summary>
        /// 是否可以支付，取值“是”或“否”
        /// </summary>
        public string canPay
        {
            get { return _canPay; }
            set { _canPay = value; }
        }

        /// <summary>
        /// 是否生成PNR，取值“是”或“否”
        /// </summary>
        public string needPnr
        {
            get { return _needPnr; }
            set { _needPnr = value; }
        }

        /// <summary>
        ///是否进行PAT：A校验，取值“是”或“否” 
        /// </summary>
        public string pata
        {
            get { return _pata; }
            set { _pata = value; }
        }

        /// <summary>
        /// 最小购买年龄，大于13的整数；允许购买机票的最小年龄；默认为空表示无年龄下限限制(可选)
        /// </summary>
        public int minAge
        {
            get { return _minAge; }
            set { _minAge = value; }
        }

        /// <summary>
        /// 最大购买年龄，小于70的整数；允许购买机票的最大年龄；默认为空表示无年龄上限限制(可选)
        /// </summary>
        public int maxAge
        {
            get { return _maxAge; }
            set { _maxAge = value; }
        }

        /// <summary>
        /// 特殊票务说明，填写如下中括号内序号,最多支持4
//个，中间使用逗号分隔符。
//【1002】机场无法打印行程单，如需
// 报销请选择快递行程单。
//【1004】姓名不能超过6个字。
//【1005】不支持外宾预定。
//【1006】不支持英文名字或中文名字
// 中含字母的乘客预定。
// 【1007】特殊产品，出票慢，最晚起
//飞前两小时出票
        /// </summary>
        public string specialRule
        {
            get { return _specialRule; }
            set { _specialRule = value; }
        }
    }
}
