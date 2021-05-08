namespace SqlSugarTest.Model
{
    /// <summary>
    /// 产品信息
    /// </summary>
    public class CProductInfo
    {
        public CProductInfo()
        {
            incode = "";
            barcode = "";
            fname = "";
            specs = "";
            iprc = 0;
            rprc = 0;
            kcqty = 0;
            pfrprc = 0;
            hyrprc = 0;
            unit = "";
            origin = "";
        }

        /// <summary>
        /// 商品编码
        /// </summary>
        public string incode { get; set; }
        //商品条码
        public string barcode { get; set; }
        //商品名称
        public string fname { get; set; }
        //商品规格
        public string specs { get; set; }
        //进价
        public float iprc { get; set; }
        //售价
        public float rprc { get; set; }
        //库存
        public float kcqty { get; set; }
        //批发价
        public float pfrprc { get; set; }
        //会员价
        public float hyrprc { get; set; }
        //单位
        public string unit { get; set; }
        //产地
        public string origin { get; set; }

    }
}
