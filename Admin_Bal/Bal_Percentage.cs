using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TT.DataAccess.Component;

namespace UpGrow.Admin_Bal
{
    public class Bal_Percentage
    {
        public string AddPercentage(string Percentage,int Months, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Percentage", SqlDbType.NVarChar, Percentage);
            dataParameter.Add(param);
            param = new DataParameter("@Months", SqlDbType.Int, Months);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            return dataAdap.GetData<string>("Sp_AddPercentage", dataParameter);
        }

        public DataTable Percentageview(int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Type", SqlDbType.Int,Type);
            dataParameter.Add(param);
            var dtresult = dataAdap.GetData<DataTable>("Sp_AddPercentage", dataParameter);
            return dtresult;

        }
        public DataSet PercentageEdit(int PercentageId, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Id", SqlDbType.Int, PercentageId);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataSet>("Sp_AddPercentage", dataParameter);
            return dtResult;
        }

        public string PercentageUpdate(int Id, string Percentage,int Months, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Id", SqlDbType.Int, Id);
            dataParameter.Add(param);
            param = new DataParameter("@Percentage", SqlDbType.NVarChar, Percentage);
            dataParameter.Add(param);
            param = new DataParameter("@Months", SqlDbType.Int, Months);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            return dataAdap.GetData<string>("Sp_AddPercentage", dataParameter);
        }


        public string AddPassword(string Password,int Userid, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Password", SqlDbType.NVarChar, Password);
            dataParameter.Add(param);
            param = new DataParameter("@Userid", SqlDbType.Int, Userid);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            return dataAdap.GetData<string>("Sp_GeneratePassword", dataParameter);
        }

        public DataTable passwordview(int Userid,int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Userid", SqlDbType.Int, Userid);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtresult = dataAdap.GetData<DataTable>("Sp_GeneratePassword", dataParameter);
            return dtresult;

        }
             public DataTable passwordcheck(int Userid,string password,int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Userid", SqlDbType.Int, Userid);
            dataParameter.Add(param);
            param = new DataParameter("@password", SqlDbType.Int, password);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtresult = dataAdap.GetData<DataTable>("Sp_GeneratePassword", dataParameter);
            return dtresult;

        }

        public DataSet PasswordEdit(int Userid, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Userid" , SqlDbType.Int, Userid);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataSet>("Sp_GeneratePassword", dataParameter);
            return dtResult;
        }

        public string passwordUpdate(int Userid, string Password, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Userid", SqlDbType.Int, Userid);
            dataParameter.Add(param);
            param = new DataParameter("@Password", SqlDbType.NVarChar, Password);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            return dataAdap.GetData<string>("Sp_GeneratePassword", dataParameter);
        }

    }
}