using System;
using System.Text;

namespace IRPF.Models
{
    public class Deduction
    {
        public int DeductionID { get; set; }
      //  public TaxCalculationType type { get; set; }
        public double Value { get; set; }

        public int DeclarationID { get; set; }
        public Declaration Declaration { get; set; }
    }
}