using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace SqlSugarTest.Model
{
    public class tbSpXinXi
    {
        [SugarColumn(IsPrimaryKey = true)]
        public string incode { get; set; }

        public string fname { get; set; }
    }
}
