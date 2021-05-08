using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Model
{
    ///<summary>
    ///
    ///</summary>
    public partial class XtMenuAll
    {
           public XtMenuAll(){

            this.mLast =Convert.ToByte("0");
            this.FormType =Convert.ToString("1");
            this.Ver =Convert.ToString("0");
            this.IsCanUse =Convert.ToString("Y");

           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>
           [SugarColumn(IsPrimaryKey = true)] 
           public string FunCode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string FunName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int mClass {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int mLast {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>
           [SugarColumn(ColumnDescription = "DllName")] 
           public string DllName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DllFun {get;set;}

           /// <summary>
           /// Desc:
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public string FormType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string Ver {get;set;}

           /// <summary>
           /// Desc:
           /// Default:Y
           /// Nullable:False
           /// </summary>           
           public string IsCanUse {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

    }
}
