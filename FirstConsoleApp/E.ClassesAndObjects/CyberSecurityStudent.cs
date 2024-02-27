// Multilevel Inheritance
using System;

class CyberSecurityStudent : CSStudent
{
     public CyberSecurityStudent(string name, byte rn, string pTitle,string certification) 
     : base(name, rn,pTitle) // base keyword is used to call class of parent constructor
    {
       SecurityCertification= certification;
    }
    public string EthicalHackingCoursrTitle {get; set;}
     public string SecurityCertification {get; set;}
      public string CertifiedDate{get; set;}
      public override void DisplayInfo()
      {
        base.DisplayInfo();
        Console.WriteLine($"Certification:{SecurityCertification}");
         Console.WriteLine($"Certified Date:{CertifiedDate}");
      }
}