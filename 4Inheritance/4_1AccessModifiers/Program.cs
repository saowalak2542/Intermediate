using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class GoldCustomer : Customer
    {
        public void OfferVouchar()
        {
            var rating = this.CalculateRating(excludeOrders: true);
        }
    }
    class Program
    {
        static void Main(string[] arg)
        {
            var customer = new Customer();
        }

    }
    
    
}
     
