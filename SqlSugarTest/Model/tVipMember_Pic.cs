using System;
using System.Linq;
using System.Text;

namespace Model
{
    ///<summary>
    ///
    ///</summary>
    public partial class tVipMember_Pic
    {
           public tVipMember_Pic(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string VipNO {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Photoidx {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public byte[] Photo {get;set;}

    }
}
