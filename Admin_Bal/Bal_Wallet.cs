using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TT.DataAccess.Component;

namespace UpGrow.Admin_Bal
{
    public class Bal_Wallet
    {

        public DataSet LevelGridVieww(int UserId, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@UserId", SqlDbType.Int, UserId);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataSet>("Sp_WalletRequest", dataParameter);
            return dtResult;
        }
        public DataTable LevelGridViewww(int UserId, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@UserId", SqlDbType.Int, UserId);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_WalletRequest", dataParameter);
            return dtResult;
        }

        public DataTable LevelGridView(int UserId, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@UserId", SqlDbType.Int, UserId);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_WalletRequest", dataParameter);
            return dtResult;
        }

        public DataTable GridView(int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_WalletRequest", dataParameter);
            return dtResult;
        }

        public DataTable MonthRoiGridView(int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_WalletRequest", dataParameter);
            return dtResult;
        }

        public DataTable MonthRoiGridVieww(int UserId, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@UserId", SqlDbType.Int, UserId);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_WalletRequest", dataParameter);
            return dtResult;
        }
    }
}