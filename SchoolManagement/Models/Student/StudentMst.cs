using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagement.Models.Student
{
    public class StudentMst
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string College { get; set; }
        public string Course { get; set; }
        public int Fees { get; set; }
        public int FeesPaid { get; set; }
        public int FeesRem { get; set; }
        public string Project { get; set; }
        public string Teacher { get; set; }
        public string Year { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}