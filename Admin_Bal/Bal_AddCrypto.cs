using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TT.DataAccess.Component;

namespace UpGrow.Admin_Bal
{
    public class Bal_AddCrypto
    {

        public string AddCryptoAddress(string CryptoAddress, string CryptoCoinName, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@CryptoAddress", SqlDbType.NVarChar, CryptoAddress);
            dataParameter.Add(param);
            param = new DataParameter("@CryptoCoinName", SqlDbType.NVarChar, CryptoCoinName);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            return dataAdap.GetData<string>("Sp_AddCryptoAddress", dataParameter);
        }

        public DataTable AddressView(int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_AddCryptoAddress", dataParameter);
            return dtResult;
        }

        public DataSet AddressEdit(int AddressId, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Id", SqlDbType.Int, AddressId);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataSet>("Sp_AddCryptoAddress", dataParameter);
            return dtResult;
        }

        public string AddressUpdate(int Id, string CryptoAddress, string CryptoCoinName, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Id", SqlDbType.Int, Id);
            dataParameter.Add(param);
            param = new DataParameter("@CryptoAddress", SqlDbType.NVarChar, CryptoAddress);
            dataParameter.Add(param);
            param = new DataParameter("@CryptoCoinName", SqlDbType.NVarChar, CryptoCoinName);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            return dataAdap.GetData<string>("Sp_AddCryptoAddress", dataParameter);
        }

        public DataSet BindCoin(int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataSet>("Sp_AddCryptoAddress", dataParameter);
            return dtResult;
        }

        public DataSet Bindnetwork(int userid, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@userid", SqlDbType.Int, userid);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataSet>("Sp_WithdrawDetails", dataParameter);
            return dtResult;
        }

        public DataTable withdrawmethodview(int Userid, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Userid", SqlDbType.Int, Userid);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_WithdrawDetails", dataParameter);
            return dtResult;
        }


        public string AddWithdrawmethoad(int Userid, string Realname, string Email, string Phone, string Address, int coinNetworkid, string cooinnetworknmae, string coinnetworkaddress, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Userid", SqlDbType.Int, Userid);
            dataParameter.Add(param);
            param = new DataParameter("@Realname", SqlDbType.NVarChar, Realname);
            dataParameter.Add(param);
            param = new DataParameter("@Email", SqlDbType.NVarChar, Email);
            dataParameter.Add(param);
            param = new DataParameter("@Phone", SqlDbType.NVarChar, Phone);
            dataParameter.Add(param);
            param = new DataParameter("@Address", SqlDbType.NVarChar, Address);
            dataParameter.Add(param);
            param = new DataParameter("@coinNetworkid", SqlDbType.Int, coinNetworkid);
            dataParameter.Add(param);
            param = new DataParameter("@cooinnetworknmae", SqlDbType.NVarChar, cooinnetworknmae);
            dataParameter.Add(param);
            param = new DataParameter("@coinnetworkaddress", SqlDbType.NVarChar, coinnetworkaddress);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            return dataAdap.GetData<string>("Sp_WithdrawDetails", dataParameter);
        }



        public string AddWithdraw(int Userid, float WithdrawAmount, string ReceiverAddreess, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Userid", SqlDbType.Int, Userid);
            dataParameter.Add(param);
            param = new DataParameter("@WithdrawAmount", SqlDbType.Float, WithdrawAmount);
            dataParameter.Add(param);
            param = new DataParameter("@ReceiverAddreess", SqlDbType.NVarChar, ReceiverAddreess);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            return dataAdap.GetData<string>("Sp_UserWithdraw", dataParameter);
        }


        public DataTable WithdrawGridViewid(int UserId, int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@UserId", SqlDbType.Int, UserId);
            dataParameter.Add(param);
            param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_UserWithdraw", dataParameter);
            return dtResult;
        }

        public DataTable WithdrawGridView(int Type)
        {
            TT.DataAccess.Component.DataAdapter dataAdap = new TT.DataAccess.Component.DataAdapter();
            var dataParameter = new List<DataParameter>();
            var param = new DataParameter("@Type", SqlDbType.Int, Type);
            dataParameter.Add(param);
            var dtResult = dataAdap.GetData<DataTable>("Sp_UserWithdraw", dataParameter);
            return dtResult;
        }

    }
}