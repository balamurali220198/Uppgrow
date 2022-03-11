using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UpGrow.Admin_Bal
{
    public class Incomedao
    {
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public string ProductValue { get; set; }
        public string Day { get; set; }
        public string Status { get; set; }
        public string Status1 { get; set; }
        public string Due { get; set; }
        public float Amount { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public class WalletRequestDuo
    {
        public string UserCode { get; set; }
        public string Id { get; set; }
        public string PaymentMode { get; set; }
        public string BankName { get; set; }
        public string ReferenceNo { get; set; }
        public string Status { get; set; }
        public float Amount { get; set; }
        public DateTime Date { get; set; }
    }

    public class WalletLedgerDuo
    {
        public string UserId { get; set; }
        public string Particulars { get; set; }
        public float Debit { get; set; }
        public float Credit { get; set; }
        public DateTime Date { get; set; }
    }
    public class GenealogyDuo
    {
        public string introducer_code { get; set; }
        public string Sno { get; set; }
        public string customer_id { get; set; }
        public string customer_name { get; set; }
        public string customer_code { get; set; }
        public string ProductName { get; set; }
        public string Due { get; set; }
        public string date_of_join { get; set; }
    }
}