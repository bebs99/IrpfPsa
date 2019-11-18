using System;
using System.Collections.Generic;
using System.Text;

namespace IRPF.Models
{
    public class Declaration
    {
        public int DeclarationId { get; set; }
        public double Incomme { get; set; }
        public int Dependents { get; set; }
        public double SocialSecurity { get; set; }
        public bool Status { get; set; }
        public string Date { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public virtual IEnumerable<Deduction> Deducoes { get; set; }
    }
}