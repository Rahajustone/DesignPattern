using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SOLIDNEW.ISP
{
    internal interface FlatInterfaceForValidating
    {
        public abstract bool ValidatePaymentInfo();
        public abstract bool ValidateShippingAddress();
        public abstract void ProcessOrder();
        public abstract void ProcessPaymentInfo();
    }

    public class OnlineOrder : FlatInterfaceForValidating
    {
        void FlatInterfaceForValidating.ProcessOrder()
        {
            throw new NotImplementedException();
        }

        void FlatInterfaceForValidating.ProcessPaymentInfo()
        {
            throw new NotImplementedException();
        }

        bool FlatInterfaceForValidating.ValidatePaymentInfo()
        {
            throw new NotImplementedException();
        }

        bool FlatInterfaceForValidating.ValidateShippingAddress()
        {
            throw new NotImplementedException();
        }
    }
}
