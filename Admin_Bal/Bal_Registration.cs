using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TT.DataAccess.Component;

namespace UpGrow.Admin_Bal
{
    public class Bal_Registration
    {


        public DataSet UserCodeRead(string UserCode, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@UserCode", SqlDbType.VarChar, UserCode);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataSet>("Sp_Registration", dataParameter);
            return dtResult;
        }

        public DataSet SponsorCodeRead(string Sponsorcode, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Sponsorcode", SqlDbType.VarChar, Sponsorcode);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataSet>("Sp_Registration", dataParameter);
            return dtResult;
        }
        public DataTable RankHolder(int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_Registration", dataParameter);
            return dtResult;
        }

        public DataSet UserNameRead(string UserName, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@UserName", SqlDbType.VarChar, UserName);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataSet>("Sp_Registration", dataParameter);
            return dtResult;
        }

        public DataSet CodeRegistration(int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataSet>("Sp_Registration", dataParameter);
            return dtResult;
        }

        public DataSet MaxNo(int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataSet>("Sp_Registration", dataParameter);
            return dtResult;
        }


        public DataTable RegistrationInsert(string UserName, string UserCode, int SponsorId, string PhoneNumber, string Password, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@UserName", SqlDbType.VarChar, UserName);
            dataParameter.Add(param);
            param = new DataParameter("@UserCode", SqlDbType.VarChar, UserCode);
            dataParameter.Add(param);
            param = new DataParameter("@SponsorId", SqlDbType.Int, SponsorId);
            dataParameter.Add(param);
            param = new DataParameter("@PhoneNumber", SqlDbType.VarChar, PhoneNumber);
            dataParameter.Add(param);
            param = new DataParameter("@Password", SqlDbType.VarChar, Password);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            return dataAdap.GetData<DataTable>("Sp_Registration", dataParameter);
        }

        public DataTable CusDetailss(int userid, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@userid", SqlDbType.Int, userid);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_Registration", dataParameter);
            return dtResult;
        }

        public DataTable Scopeidentity(int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_Registration", dataParameter);
            return dtResult;
        }

        public DataTable UserPanelView(int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_Registration", dataParameter);
            return dtResult;
        }

        public string TopUpInsert(int UserId, int SponsorId, float Amount, int Due, int PostStatus, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@UserId", SqlDbType.Int, UserId);
            dataParameter.Add(param);
            param = new DataParameter("@SponsorId", SqlDbType.Int, SponsorId);
            dataParameter.Add(param);
            param = new DataParameter("@Amount", SqlDbType.Float, Amount);
            dataParameter.Add(param);
            param = new DataParameter("@Due", SqlDbType.Int, Due);
            dataParameter.Add(param);
            param = new DataParameter("@PostStatus", SqlDbType.Int, PostStatus);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            return dataAdap.GetData<string>("Sp_Registration", dataParameter);
        }
        public string SponsorChange(int UserId, int SponsorId, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@UserId", SqlDbType.Int, UserId);
            dataParameter.Add(param);
            param = new DataParameter("@SponsorId", SqlDbType.Int, SponsorId);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            return dataAdap.GetData<string>("Sp_Registration", dataParameter);
        }

        public DataTable UserMobileno(string username, string PhoneNumber, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@username", SqlDbType.VarChar, username);
            dataParameter.Add(param);
            param = new DataParameter("@PhoneNumber", SqlDbType.VarChar, PhoneNumber);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_Registration", dataParameter);
            return dtResult;
        }

        public DataTable CusChangepwd(string Usercode, string Password, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Usercode", SqlDbType.VarChar, Usercode);
            dataParameter.Add(param);
            param = new DataParameter("@Password", SqlDbType.VarChar, Password);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_Registration", dataParameter);
            return dtResult;
        }


        public string CusChangepassword(string Usercode, string Password, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Usercode", SqlDbType.VarChar, Usercode);
            dataParameter.Add(param);
            param = new DataParameter("@Password", SqlDbType.VarChar, Password);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            return dataAdap.GetData<string>("Sp_Registration", dataParameter);
        }

        public DataTable SponEditView(int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_Registration", dataParameter);
            return dtResult;
        }

    }
}