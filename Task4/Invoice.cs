using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;
        string article;
        int quantity;

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public double WithPdv()
        {
            return account + ((account + (account / 5)) * 0.20f);
        }
        public double WithoutPdv()
        {
            return (account + (account / 5));
        }
    }
}
