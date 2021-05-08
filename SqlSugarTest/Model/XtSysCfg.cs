using System;
using System.Linq;
using System.Text;

namespace Model
{
    ///<summary>
    ///
    ///</summary>
    public partial class XtSysCfg
    {
           public XtSysCfg(){

            this.CsValue =Convert.ToString("");

           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Section {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CsName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CsValue {get;set;}

    }
}
