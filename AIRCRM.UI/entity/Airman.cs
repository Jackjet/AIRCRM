using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policy.entity
{
    public class Airman
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String startCode;

        public String StartCode
        {
            get { return startCode; }
            set { startCode = value; }
        }
        private String arriveCode;

        public String ArriveCode
        {
            get { return arriveCode; }
            set { arriveCode = value; }
        }
        private String carrierName;

        public String CarrierName
        {
            get { return carrierName; }
            set { carrierName = value; }
        }
        private String status;

        public String Status
        {
            get { return status; }
            set { status = value; }
        }
        private DateTime addTime;

        public DateTime AddTime
        {
            get { return addTime; }
            set { addTime = value; }
        }
    }
}
