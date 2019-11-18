using System;
namespace IRPF.Models
{
    public class TaxCalculation
    {
        public interface TaxCalculous
        {
            double calculous(User user);
        }

        internal double calculous(User user)
        {
            throw new NotImplementedException();
        }
    }
}
