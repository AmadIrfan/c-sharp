using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.BL
{
    class worker
    {
        public string workername;
        public int workerage;
        public double workersalary;
        public string workerexperience;
        public List<product> productlist;
        public worker(string workername,int workerage,double workersalary,string workerexperience,List<product> productlist)
        {
            this.workername = workername;
            this.workerage = workerage;
            this.workersalary = workersalary;
            this.workerexperience = workerexperience;
            this.productlist = productlist;
        }
        public worker(string workername,int workerage,double workersalary,string workerexperience)
        {
            this.workername = workername;
            this.workerage = workerage;
            this.workersalary = workersalary;
            this.workerexperience = workerexperience;
        }
        public worker(string workername)
        {
            this.workername = workername;
        }
        public worker()
        {

        }
    }
}
