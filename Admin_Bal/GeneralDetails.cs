using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TT.DataAccess.Component;

namespace UpGrow.Admin_Bal
{
    public class GeneralDetails
    {


        public string LevelincomeInsert()
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            return dataAdap.GetData<string>("Sp_LevelJoining", dataParameter);
        }

        public string RoiincomeInsert()
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            return dataAdap.GetData<string>("SP_Roimonthly", dataParameter);
        }

        public string WeeklyPayoutInsert(string FromDate, string ToDate)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@FromDate", SqlDbType.VarChar, FromDate);
            dataParameter.Add(param);
            param = new DataParameter("@ToDate", SqlDbType.VarChar, ToDate);
            dataParameter.Add(param);
            return dataAdap.GetData<string>("Sp_InsertWeeklyPayout", dataParameter);
        }

        public DataSet AdminDashboard()
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var dtResult = dataAdap.GetData<DataSet>("Sp_AdminDashBoard", dataParameter);
            return dtResult;

        }

        public DataSet AdminDashBoard()
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            return dataAdap.GetData<DataSet>("Sp_AdminDashboard", dataParameter);
        }
        public DataSet CustomerDashBoard(string UserId)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@UserId", SqlDbType.BigInt, UserId);
            dataParameter.Add(param);
            return dataAdap.GetData<DataSet>("Sp_UserDashboard", dataParameter);
        }
    }
}