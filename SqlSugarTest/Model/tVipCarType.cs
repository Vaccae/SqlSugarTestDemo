using System;
using System.Linq;
using System.Text;

namespace Model
{
    ///<summary>
    ///
    ///</summary>
    public partial class tVipCarType
    {
           public tVipCarType(){

            this.Disc =Convert.ToDecimal("100");
            this.Amount =Convert.ToDecimal("0");

           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string TypeCode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string TypeName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:100
           /// Nullable:False
           /// </summary>           
           public decimal Disc {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal Amount {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remark {get;set;}

    }
}
