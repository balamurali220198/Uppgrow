using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TT.DataAccess.Component;

namespace UpGrow.Admin_Bal
{
    public class Bal_Login
    {
        public DataTable AdminLogin(string username, string password, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@username", SqlDbType.VarChar, username);
            dataParameter.Add(param);
            param = new DataParameter("@password", SqlDbType.VarChar, password);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_Login", dataParameter);
            return dtResult;
        }
        public DataTable AdminLog(int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_Login", dataParameter);
            return dtResult;
        }

        public DataTable Levelincome()
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var dtResult = dataAdap.GetData<DataTable>("[Sp_LevelJoining]", dataParameter);
            return dtResult;
        }


        public DataTable ChangePassword(string Password, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Password", SqlDbType.VarChar, Password);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_Login", dataParameter);
            return dtResult;
        }

        public string NewPasswordChange(string password, string newpassword, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@password", SqlDbType.VarChar, password);
            dataParameter.Add(param);
            param = new DataParameter("@newpassword", SqlDbType.VarChar, newpassword);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            return dataAdap.GetData<string>("Sp_Login", dataParameter);
        }

    }
}