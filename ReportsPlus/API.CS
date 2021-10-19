using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportsPlus
{
    class API
    {
        public static string getName
        {
            get;
            set;
        }
        public static string getSecondName
        {
            get;
            set;
        }
        public static string getThirdName
        {
            get;
            set;
        }
        public static string getAddress
        {
            get;
            set;
        }
        public static string getEgn
        {
            get;
            set;
        }
        public static string education_type
        {
            get
                ;
            set
                ;
        }
        public static string education_status
        {
            get;
            set;
        }
        public static string knownNicknames
        {
            get
                ;
            set;
        }
        public static string photo
        {
            get;
            set;
        }
        public static string phoneNum
        {
            get;
            set;
        }
        public static string signature
        {
            get;
            set;
        }
        public static string workplace
        {
            get;
            set;
        }
        public static double workplace_salary
        {
            get;
            set;
        }
        public static string workplace_role
        {
            get;
            set;
        }
        public static double yearSalary
        {
            get;
            set;
        }
        public static void DoCalc(double monthlySalary)
        {
            var doCalc = monthlySalary * 12;
            yearSalary = doCalc;
        }
    }
}
