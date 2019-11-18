using System;
using System.Text;

namespace IRPF.Models
{
    public class User
    {
        public String Name { get; set; }
        public String Cpf { get; set; }
        public int Age { get; set; }
        public int NumberDep { get; set; }
        public double Prev { get; set; }

 
        public double TotalIncome { get; set; }
      //  public SimpleTaxCalculous Tax { get; set; }
        public int UserID { get; set; }
  
        public Declaration Declaration { get; set; }

     

      //  public void DefineCalculous(SimpleTaxCalculous calc)
      // {
      //      Tax = calc;
      //  }
    }
}
