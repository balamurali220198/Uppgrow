using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TT.DataAccess.Component;

namespace UpGrow.Admin_Bal
{
    public class Bal_InvestmentApproval
    {

        public string InvestmentApprovalinsert(int Coinid, string Coin, string Receiveraddress, string Transactionaddress, string TransactionImage, int status, int Userid, string UserCode, float Amount, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Coinid", SqlDbType.Int, Coinid);
            dataParameter.Add(param);
            param = new DataParameter("@Coin", SqlDbType.NVarChar, Coin);
            dataParameter.Add(param);
            param = new DataParameter("@Receiveraddress", SqlDbType.NVarChar, Receiveraddress);
            dataParameter.Add(param);
            param = new DataParameter("@Transactionaddress", SqlDbType.NVarChar, Transactionaddress);
            dataParameter.Add(param);
            param = new DataParameter("@TransactionImage", SqlDbType.NVarChar, TransactionImage);
            dataParameter.Add(param);
            param = new DataParameter("@status", SqlDbType.NVarChar, status);
            dataParameter.Add(param);
            param = new DataParameter("@Userid", SqlDbType.NVarChar, Userid);
            dataParameter.Add(param);
            param = new DataParameter("@UserCode", SqlDbType.NVarChar, UserCode);
            dataParameter.Add(param);
            param = new DataParameter("@Amount", SqlDbType.Float, Amount);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            return dataAdap.GetData<string>("Sp_AddInvestment", dataParameter);
        }

        public DataSet CheckAddress(int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataSet>("Sp_AddInvestment", dataParameter);
            return dtResult;
        }

        public DataSet Investmentgrid(int Userid, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Userid", SqlDbType.Int, Userid);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataSet>("Sp_AddInvestment", dataParameter);
            return dtResult;
        }
        public DataSet Investmentappgrid(int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataSet>("Sp_AddInvestment", dataParameter);
            return dtResult;
        }

        public DataSet withdrawgrid(int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataSet>("Sp_UserWithdraw", dataParameter);
            return dtResult;
        }


        public string InvestmentAccept(int id, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@id", SqlDbType.Int, id);
            dataParameter.Add(param);


            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            return dataAdap.GetData<string>("Sp_AddInvestment", dataParameter);
        }

        public string WithdrawAccept(int id, int Userid, float WithdrawAmount, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@id", SqlDbType.Int, id);
            dataParameter.Add(param);
            param = new DataParameter("@Userid", SqlDbType.Int, Userid);
            dataParameter.Add(param);
            param = new DataParameter("@WithdrawAmount", SqlDbType.Float, WithdrawAmount);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            return dataAdap.GetData<string>("Sp_UserWithdraw", dataParameter);
        }

        public string InvestmentReject(int id, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@id", SqlDbType.Int, id);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            return dataAdap.GetData<string>("Sp_AddInvestment", dataParameter);
        }


        public string WithdraweReject(int id, int Userid, float WithdrawAmount, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@id", SqlDbType.Int, id);
            dataParameter.Add(param);
            param = new DataParameter("@Userid", SqlDbType.Int, Userid);
            dataParameter.Add(param);
            param = new DataParameter("@WithdrawAmount", SqlDbType.Float, WithdrawAmount);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            return dataAdap.GetData<string>("Sp_UserWithdraw", dataParameter);
        }

        public DataTable AcceptRejectreport(int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            return dataAdap.GetData<DataTable>("Sp_UserWithdraw", dataParameter);
        }

        public DataTable Incomedetails(int Userid, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Userid", SqlDbType.Int, Userid);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            return dataAdap.GetData<DataTable>("Sp_AddInvestment", dataParameter);
        }
        public DataTable withdrawAcceptRejectreport(int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            return dataAdap.GetData<DataTable>("Sp_AddInvestment", dataParameter);
        }

    }
}