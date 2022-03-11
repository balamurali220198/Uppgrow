using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TT.DataAccess.Component;

namespace UpGrow.Admin_Bal
{
    public class TeamDetailsCls
    {
        public List<CustomerDao> TeamCustomer(string UserId)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@UserId", SqlDbType.BigInt, UserId);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_TeamCustomer", dataParameter);
            return Details(dtResult);
        }

        public List<CustomerDao> TeamCustomer(string UserId, string ReferalId)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@UserId", SqlDbType.BigInt, UserId);
            dataParameter.Add(param);
            param = new DataParameter("@ReferalId", SqlDbType.VarChar, ReferalId);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_TeamCustomerReferal", dataParameter);
            return Details(dtResult);
        }
        private List<CustomerDao> Details(DataTable dtResult)
        {
            List<CustomerDao> list = new List<CustomerDao>();
            foreach (DataRow item in dtResult.Rows)
            {
                var customerDao = new CustomerDao();
                customerDao.Code = item["UserCode"].ToString();
                customerDao.Name = item["UserName"].ToString();
                customerDao.Level = item["Level"].ToString();
                customerDao.Timestamp = DateTime.Parse(item["TimeStamp"].ToString());
                customerDao.Deposit = item["Amount"].ToString();
                //customerDao.Due = item["Due"].ToString();
                customerDao.SponsorId = item["SponsorId"].ToString();
                list.Add(customerDao);
            }
            return list;
        }

        public List<CustomerDao> TeamDirectCustomer(string UserId)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@UserId", SqlDbType.BigInt, UserId);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_TeamDirectCustomer", dataParameter);
            return Details(dtResult);
        }
    }

    public class CustomerDao
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string SponsorId { get; set; }
        public string Level { get; set; }
        public string Deposit { get; set; }
        public string Due { get; set; }
        public DateTime Timestamp { get; set; }
    }
}