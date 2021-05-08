using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using SqlSugar;
using SqlSugarTest.Model;
using DbType = System.Data.DbType;

namespace SqlSugarTest
{
    public partial class Form1 : Form
    {
        #region 文本框操作

        //定义文本框
        private static TextBox _tbMsg;

        //定义Action
        private Action<string> TextShowAction = new Action<string>(TextShow);

        //定义更新UI函数
        private static void TextShow(string sMsg)
        {
            //当文本行数大于500后清空
            if (_tbMsg.Lines.Length > 500)
            {
                _tbMsg.Clear();
            }

            string ShowMsg = DateTime.Now + "  " + sMsg + "\r\n";
            _tbMsg.AppendText(ShowMsg);

            //让文本框获取焦点 
            _tbMsg.Focus();
            //设置光标的位置到文本尾 
            _tbMsg.Select(_tbMsg.TextLength, 0);
            //滚动到控件光标处 
            _tbMsg.ScrollToCaret();
        }

        #endregion

        #region 数据库连接

        /// <summary>
        /// 数据库实例
        /// </summary>
        private SqlSugarClient _db;

        //数据库连接字符串
        private string _connstr = "server=.;uid=sa;pwd=sumsoft;database=SysDb";

        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <param name="connstr"></param>
        private void ConnectDb(string connstr)
        {
            _db = new SqlSugarClient(
                new ConnectionConfig()
                {
                    ConnectionString = _connstr,
                    DbType = SqlSugar.DbType.SqlServer, //设置数据库类型
                    IsAutoCloseConnection = true, //自动释放数据务，如果存在事务，在事务结束后释放
                    InitKeyType = InitKeyType.Attribute, //从实体特性中读取主键自增列信息
                    ConfigureExternalServices = new ConfigureExternalServices()
                    {
                        DataInfoCacheService = new HttpRuntimeCache() //RedisCache是继承ICacheService自已实现的一个类
                    }
                });

            //用来打印Sql方便你调式    
            _db.Aop.OnLogExecuting = (sql, pars) =>
            {
                TextShow(sql);
                TextShow(_db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
            };
        }

        #endregion

        public Form1()
        {
            InitializeComponent();

            _tbMsg = tbMsg;
        }


        /// <summary>
        /// 根据数据库表生成实体类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _db.DbFirst.IsCreateDefaultValue()
                    .CreateClassFile("D:\\Business\\DemoTEST\\CSharp\\SqlSugarTest\\SqlSugarTest\\Model", "Model");
                TextShow("类生成成功");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnconnect_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(_connstr);
                sqlConnection.Open();

                string serverVersion = sqlConnection.ServerVersion;
                string[] serverVersionDetails = serverVersion.Split(new string[] { "." }, StringSplitOptions.None);

                int versionNumber = int.Parse(serverVersionDetails[0]);

                switch (versionNumber)
                {
                    case 8:
                        TextShow("版本号：SQL Server 2000！");
                        break;
                    case 9:
                        TextShow("版本号：SQL Server 2005！");
                        break;
                    case 10:
                        TextShow("版本号：SQL Server 2008！");
              
                        break;
                    default:
                        TextShow($"SQL Server {versionNumber}");
                        break;
                }


                ConnectDb(_connstr);
                TextShow("数据库连接成功！");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                POS pos = new POS();
                pos.Posno = "0001";
                pos.Posname = "款台号01";
                pos.OrgCode = "9999";
                pos.status = "1";

                _db.Insertable(pos).ExecuteCommand();
                TextShow(pos.Posno + "数据插入成功");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnquery_Click(object sender, EventArgs e)
        {
            try
            {
                //            //返回所有数据
                //            List<POS> poss = _db.Queryable<POS>().ToList();
                //            foreach (POS item in poss)
                //            {
                //                TextShow(item.Posno + " " + item.Posname + " "
                //                         + item.OrgCode + " " + item.status);
                //            }

                //根据条件查询
                List<POS> poss = _db.Queryable<POS>().Where(t =>
                    t.Posno == "0001").ToList();
                foreach (POS item in poss)
                {
                    TextShow(item.Posno + " " + item.Posname + " "
                             + item.OrgCode + " " + item.status);
                }
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                POS pos = new POS();
                pos.Posno = "0001";
                pos.Posname = "修改后02";

                _db.Updateable(pos).ExecuteCommand();
                TextShow("修改完成");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                _db.Deleteable<POS>(t => t.Posno == "0001").ExecuteCommand();
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        /// <summary>
        /// 查询所有
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmnuqryall_Click(object sender, EventArgs e)
        {
            try
            {
                List<XtMenuAll> menuAlls = _db.Queryable<XtMenuAll>().ToList();
                foreach (var menu in menuAlls)
                {
                    TextShow("FunCode:" + menu.FunCode + " FunName:" + menu.FunName);
                }

                TextShow("查询所有完成");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        /// <summary>
        /// 查询前5条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmnuqry5_Click(object sender, EventArgs e)
        {
            try
            {
                List<XtMenuAll> menuAlls = _db.Queryable<XtMenuAll>().Take(5).ToList();
                foreach (var menu in menuAlls)
                {
                    TextShow("FunCode:" + menu.FunCode + " FunName:" + menu.FunName);
                }

                TextShow("查询前5条完成");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        /// <summary>
        /// 无锁查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmnuqrynolock_Click(object sender, EventArgs e)
        {
            try
            {
//                List<XtMenuAll> menuAlls = _db.Queryable<XtMenuAll>().With(SqlWith.NoLock).ToList();
//                foreach (var menu in menuAlls)
//                {
//                    TextShow("FunCode:" + menu.FunCode + " FunName:" + menu.FunName);
//                }
//
//                TextShow("无锁查询完成");
//
//                string signstr = SignApi.GetClassSignStr<List<XtMenuAll>>(menuAlls);
//                TextShow(signstr);

                var list = _db.Queryable<XtMenuUser, XtMenuAll>(
                    (a, b) => new object[]
                    {
                        JoinType.Left, a.FunCode == b.FunCode
                    }).Where(a=>a.UserCode=="0101")
                    .Select<XtMenuUser>().ToList();

                foreach (var item in list)
                {
                    TextShow(item.UserCode + "  " + item.FunCode
                             + "  " + item.FunName);
                }
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        /// <summary>
        /// 根据主键查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmnuqrykey_Click(object sender, EventArgs e)
        {
            try
            {
                XtMenuAll menu = _db.Queryable<XtMenuAll>().InSingle("0104");
                TextShow("FunCode:" + menu.FunCode + " FunName:" + menu.FunName);
                TextShow("根据主键查询完成");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        /// <summary>
        /// 单条查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmnuqryone_Click(object sender, EventArgs e)
        {
            try
            {
                XtMenuAll menu = _db.Queryable<XtMenuAll>().Single();
                TextShow("FunCode:" + menu.FunCode + " FunName:" + menu.FunName);
                TextShow("单条查询完成");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }

            try
            {
                XtMenuAll menu = _db.Queryable<XtMenuAll>()
                     .First();
                string signstr = SignApi.GetClassSignStr<XtMenuAll>(menu);
                TextShow("FunCode:" + menu.FunCode + " FunName:" + menu.FunName);
                TextShow("单条查询完成");
                TextShow(signstr);
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        /// <summary>
        /// 联合查询UNION ALL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmnuqryunion_Click(object sender, EventArgs e)
        {
            try
            {
                List<XtMenuAll> menuAlls =
                    _db.UnionAll<XtMenuAll>(_db.Queryable<XtMenuAll>(),
                        _db.Queryable<XtMenuAll>()).ToList();
                foreach (var menu in menuAlls)
                {
                    TextShow("FunCode:" + menu.FunCode + " FunName:" + menu.FunName);
                }

                TextShow("联合查询UNION ALL完成");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        /// <summary>
        /// IN查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmnuqryin_Click(object sender, EventArgs e)
        {
            try
            {
                List<XtMenuAll> menuAlls =
                    _db.Queryable<XtMenuAll>()
                        .In(t => t.FunCode, new string[] { "0101", "0103" })
                        .ToList();
                foreach (var menu in menuAlls)
                {
                    TextShow("FunCode:" + menu.FunCode + " FunName:" + menu.FunName);
                }

                TextShow("IN查询完成");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        /// <summary>
        /// NOT IN 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmnuqrynotin_Click(object sender, EventArgs e)
        {
            try
            {
                string[] array = { "0101", "0103" };
                List<XtMenuAll> menuAlls =
                    _db.Queryable<XtMenuAll>()
                        .Where(t => !array.Contains(t.FunCode))
                        .ToList();
                foreach (var menu in menuAlls)
                {
                    TextShow("FunCode:" + menu.FunCode + " FunName:" + menu.FunName);
                }

                TextShow("NOT IN查询完成");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        /// <summary>
        /// 条件查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmnuqrywhere_Click(object sender, EventArgs e)
        {
            try
            {
//                List<XtMenuAll> menuAlls =
//                    _db.Queryable<XtMenuAll>()
//                        .Where(t => t.FunCode == "0101"
//                                    || t.FunCode == "90")
//                        .ToList();
//                foreach (var menu in menuAlls)
//                {
//                    TextShow("FunCode:" + menu.FunCode + " FunName:" + menu.FunName);
//                }

                XtMenuAll menu = _db.Queryable<XtMenuAll>()
                    .Where(t => t.FunCode == "9893").First();
                TextShow("FunCode:" + menu.FunCode + " FunName:" + menu.FunName);
                TextShow("条件查询完成");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        /// <summary>
        /// 使用函数SqlFunc类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmnuqrysqlfunc_Click(object sender, EventArgs e)
        {
            try
            {
                List<XtMenuAll> menuAlls =
                    _db.Queryable<XtMenuAll>()
                        .Where(t => SqlFunc.StartsWith(t.FunCode, "01"))
                        .ToList();
                foreach (var menu in menuAlls)
                {
                    TextShow("FunCode:" + menu.FunCode + " FunName:" + menu.FunName);
                }
                TextShow("使用SqlFunc查询开始为01的数据");

                menuAlls =
                    _db.Queryable<XtMenuAll>()
                        .Where(t => SqlFunc.Contains(t.FunName, "卡"))
                        .ToList();
                foreach (var menu in menuAlls)
                {
                    TextShow("FunCode:" + menu.FunCode + " FunName:" + menu.FunName);
                }
                TextShow("使用SqlFunc查询名称包含《卡》的完成");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        /// <summary>
        /// SUM AVG MAX MIN的查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmnuqrysum_Click(object sender, EventArgs e)
        {
            try
            {
                int sum = _db.Queryable<XtMenuAll>().Sum(t => t.mClass);
                TextShow("mClass求合:" + sum);

                int avg = _db.Queryable<XtMenuAll>().Avg(t => t.mClass);
                TextShow("mClass平均:" + avg);

                int max = _db.Queryable<XtMenuAll>().Max(t => t.mClass);
                TextShow("mClass最大:" + max);

                int min = _db.Queryable<XtMenuAll>().Min(t => t.mClass);
                TextShow("mClass最小:" + min);
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        /// <summary>
        /// Between查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmnuqrybetween_Click(object sender, EventArgs e)
        {
            try
            {
                List<XtMenuAll> menuAlls =
                    _db.Queryable<XtMenuAll>()
                        .Where(t => SqlFunc.Between(t.FunCode, "0101", "0104"))
                        .ToList();
                foreach (var menu in menuAlls)
                {
                    TextShow("FunCode:" + menu.FunCode + " FunName:" + menu.FunName);
                }
                TextShow("使用SqlFunc查询0101和0104之间");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        /// <summary>
        /// 查询排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmnuqryorder_Click(object sender, EventArgs e)
        {
            try
            {
                List<XtMenuAll> menuAlls =
                    _db.Queryable<XtMenuAll>()
                        .OrderBy(t => t.FunName, OrderByType.Desc)
                        .ToList();
                foreach (var menu in menuAlls)
                {
                    TextShow("FunCode:" + menu.FunCode + " FunName:" + menu.FunName);
                }
                TextShow("按FunName的降序查询");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmnuqryexists_Click(object sender, EventArgs e)
        {
            try
            {
                bool isexists =
                    _db.Queryable<XtMenuAll>()
                        .Where(t => t.FunCode == "02")
                        .Any();
                string msg = isexists ? "存在" : "不存在";
                TextShow("查询FunCode是否存在02:" + msg);

                isexists =
                    _db.Queryable<XtMenuAll>()
                        .Any(t => t.FunCode == "01");
                msg = isexists ? "存在" : "不存在";
                TextShow("查询FunCode是否存在01:" + msg);
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnuinsertcount_Click(object sender, EventArgs e)
        {
            try
            {
                POSTemp pos = new POSTemp();
                pos.Posno = "0001";
                pos.Posname = "01款台";
                pos.OrgCode = "001";
                pos.status = "1";

                int count = _db.Insertable(pos).ExecuteCommand();
                TextShow("插入了" + count + "条数据");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnuinsertident_Click(object sender, EventArgs e)
        {
            try
            {
                POSTemp pos = new POSTemp();
                pos.Posno = "0002";
                pos.Posname = "02款台";
                pos.OrgCode = "001";
                pos.status = "1";

                int count = _db.Insertable(pos).ExecuteReturnIdentity();
                TextShow("插入数据成功，自增列序号为：" + count);
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnuinsertcls_Click(object sender, EventArgs e)
        {
            try
            {
                POSTemp pos = new POSTemp();
                pos.Posno = "0003";
                pos.Posname = "03款台";
                pos.OrgCode = "001";
                pos.status = "1";

                POSTemp retPosTemp = _db.Insertable(pos).ExecuteReturnEntity();
                TextShow("插入数据成功");
                TextShow("sn:" + retPosTemp.sn + "  Posno:" + retPosTemp.Posno + " PosName:" + retPosTemp.Posname);
                TextShow("OrgCode:" + retPosTemp.OrgCode + " status:" + retPosTemp.status);
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnuinsertcolumn_Click(object sender, EventArgs e)
        {
            try
            {
                POSTemp pos = new POSTemp();
                pos.Posno = "0004";
                pos.Posname = "04款台";
                pos.OrgCode = "001";
                pos.status = "1";

                int count = _db.Insertable(pos)
                    .InsertColumns(t => new { t.Posno, t.Posname })
                    .ExecuteReturnIdentity();
                TextShow("只插对应列数据成功，自增列序号为：" + count);
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnuinsertignore_Click(object sender, EventArgs e)
        {
            try
            {
                POSTemp pos = new POSTemp();
                pos.Posno = "0005";
                pos.Posname = "05款台";
                pos.OrgCode = "001";
                pos.status = "1";

                int count = _db.Insertable(pos)
                    .IgnoreColumns(t => new { t.OrgCode })
                    .ExecuteReturnIdentity();
                TextShow("不插对应列数据成功，自增列序号为：" + count);
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnuinsertignorewhere_Click(object sender, EventArgs e)
        {
            try
            {
                POSTemp pos = new POSTemp();
                pos.Posno = "0006";
                pos.Posname = "06款台";
                pos.OrgCode = "001";
                pos.status = "1";

                int count = _db.Insertable(pos)
                    .IgnoreColumns(t => t == "status")
                    .ExecuteReturnIdentity();
                TextShow("根据条件不插对应列数据成功，自增列序号为：" + count);
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnuinsertignorelist_Click(object sender, EventArgs e)
        {
            try
            {
                POSTemp pos = new POSTemp();
                pos.Posno = "0007";
                pos.Posname = "07款台";
                pos.OrgCode = "001";
                pos.status = "1";

                List<string> list = new List<string>();
                list.Add("OrgCode");
                list.Add("status");

                int count = _db.Insertable(pos)
                    .IgnoreColumns(t => list.Contains(t))
                    .ExecuteReturnIdentity();
                TextShow("根据条件不插对应列数据成功，自增列序号为：" + count);
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnuinsertlock_Click(object sender, EventArgs e)
        {
            try
            {
                POSTemp pos = new POSTemp();
                pos.Posno = "0008";
                pos.Posname = "08款台";
                pos.OrgCode = "001";
                pos.status = "1";

                int count = _db.Insertable(pos)
                    .With(SqlWith.UpdLock)
                    .ExecuteReturnIdentity();
                TextShow("插入使用锁数据成功，自增列序号为：" + count);
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnuinsertarray_Click(object sender, EventArgs e)
        {
            try
            {
                List<POSTemp> listpos = new List<POSTemp>();
                for (int i = 0; i < 3; i++)
                {
                    POSTemp pos = new POSTemp();
                    pos.Posno = "001" + i;
                    pos.Posname = pos.Posno + "款台";
                    pos.OrgCode = "001";
                    pos.status = "1";
                    listpos.Add(pos);
                }

                int count = _db.Insertable(listpos.ToArray())
                    .ExecuteCommand();
                TextShow("List插入数据，成功插入" + count + "条数据");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnuinsertdictionary_Click(object sender, EventArgs e)
        {
            try
            {
                int count = _db.Insertable<POSTemp>(
                        new { Posno = "0013", Posname = "13款台" })
                    .ExecuteReturnIdentity();
                TextShow("匿名对插成功插入成功，自增序号为：" + count);

                count = _db.Insertable<POSTemp>(
                        new Dictionary<string, object>()
                        {
                            { "Posno","0014"},
                            {"Posname","14款台" }
                        })
                    .ExecuteReturnIdentity();
                TextShow("字典方式插成功插入成功，自增序号为：" + count);
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnuinsertAtoB_Click(object sender, EventArgs e)
        {
            try
            {
                int count = _db.Insertable(_db.Queryable<POSTemp>()
                     .Select<POS>().ToList()).ExecuteCommand();
                TextShow("从POSTemp表中向POS表中成功插入了" + count + "条数据");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnuupdatecls_Click(object sender, EventArgs e)
        {
            try
            {
                POSTemp pos = _db.Queryable<POSTemp>()
                    .Where(t => t.Posno == "0001").First();
                pos.OrgCode = "002";
                pos.status = "0";

                int count = _db.Updateable(pos).ExecuteCommand();
                TextShow("更新了" + count + "条数据");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnuupdatewhere_Click(object sender, EventArgs e)
        {
            try
            {
//                POSTemp pos = _db.Queryable<POSTemp>()
//                    .Where(t => t.Posno == "0002").First();
                POSTemp pos= new POSTemp();
                pos.Posno = "0002";
                pos.Posname = "02款台";
                pos.OrgCode = "003";
                pos.status = "2";

                int count = _db.Updateable(pos)
                    .UpdateColumns(p => new { p.OrgCode, p.status, p.Posno })
                    .WhereColumns(t => new { t.Posno })
                    .ExecuteCommand();
                TextShow("更新了" + count + "条数据");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsbtnupdatenotcls_Click(object sender, EventArgs e)
        {
            try
            {
                int count = _db.Updateable<POSTemp>()
                    .SetColumns(p => new POSTemp() { status = "3" })
                    .Where(t => t.OrgCode == "001")
                    .ExecuteCommand();
                TextShow("更新了" + count + "条数据");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnuupdateunion_Click(object sender, EventArgs e)
        {
            try
            {
                int count = _db.Updateable<POSTemp>()
                    .SetColumns(p => new POSTemp()
                    {
                        status = SqlFunc.Subqueryable<POS>()
                            .Where(x => x.Posno == p.Posno)
                            .Select(x => x.status)
                    })
                    .Where(t => t.OrgCode == "003")
                    .ExecuteCommand();
                TextShow("更新了" + count + "条数据");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnuupdatecasewhere_Click(object sender, EventArgs e)
        {
            try
            {
                POSTemp pos = _db.Queryable<POSTemp>()
                    .Where(t => t.Posno == "0001").First();
                int count = _db.Updateable(pos)
                    .SetColumnsIF(pos.status == "0", t =>
                        new POSTemp() { status = "5" })
                    .SetColumnsIF(pos.status == "5", t =>
                        new POSTemp() { status = "9" })
                    .ExecuteCommand();
                TextShow("更新了" + count + "条数据");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnusave_Click(object sender, EventArgs e)
        {
            try
            {
                POSTemp pos = new POSTemp();
                pos.sn = 16;
                pos.Posno = "0015";
                pos.Posname = "15款台";
                pos.OrgCode = "001";
                pos.status = "1";

                int count = _db.Saveable(pos).ExecuteCommand();
                TextShow("更新了" + count + "条数据");

                pos.Posname = "15款台1";
                count = _db.Saveable(pos).ExecuteCommand();
                TextShow("更新了" + count + "条数据");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnudeletecls_Click(object sender, EventArgs e)
        {
            try
            {
                List<XtMenuUser> user = _db.Queryable<XtMenuUser>().ToList();

                TextShow("查询" + user.Count + "条数据");

                int count = _db.Deleteable(user).ExecuteCommand();
                TextShow("删除了" + count + "条数据");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnudeletewhere_Click(object sender, EventArgs e)
        {
            try
            {
                int count = _db.Deleteable<POSTemp>()
                    .Where(t => t.Posno == "0014")
                    .ExecuteCommand();
                TextShow("删除了" + count + "条数据");

                //删除status为3和9的数据
                List<string> statList = new List<string>();
                statList.Add("3");
                statList.Add("9");
                count = _db.Deleteable<POSTemp>()
                    .Where(t => statList.Contains(t.status))
                    .ExecuteCommand();
                TextShow("删除了" + count + "条数据");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnuquerypage_Click(object sender, EventArgs e)
        {
            //定义显示第几页
            int pageidx = 1;
            //定义每页获取多少行
            int pagesize = 2000;
            //总行数，输出返回值
            int totalsize = 0;

            try
            {
                List<product> flows = _db.SqlQueryable<dynamic>(
                        "select incode,fname from tbspxinxi").Select<product>()
                    .OrderBy(" incode")
                    .ToPageList(pageidx, pagesize);

                
                //输出显示
                TextShow("总共有：" + totalsize + "条数据");
                foreach (product item in flows)
                {
                    TextShow("编码：" + item.incode + " 名称：" + item.fname);
                }

                List<product> xinXis = _db.Queryable<tbSpXinXi>()
                    .Select(t=>new product(){incode = t.incode,fname = t.fname} )
                    .OrderBy(t=>t.incode)
                    .ToPageList(pageidx, pagesize,ref totalsize);
            
                //输出显示
                TextShow("总共有：" + totalsize + "条数据");
                foreach (product item in xinXis)
                {
                    TextShow("编码：" + item.incode + " 名称：" + item.fname);
                }

            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnuTrans_Click(object sender, EventArgs e)
        {
            try
            {
                POS pos = new POS();
                pos.Posno = "0030";
                pos.Posname = "30款台";
                pos.OrgCode = "001";
                pos.status = "1";

                _db.Ado.BeginTran();
                int count = _db.Insertable(pos).ExecuteCommand();
                TextShow("插入了" + count + "条数据");

                _db.Ado.CommitTran();
            }
            catch (Exception ex)
            {
                _db.Ado.RollbackTran();
                TextShow(ex.Message);
            }
        }

        private void tsmnuquerysql_Click(object sender, EventArgs e)
        {
            try
            {
                int totalsize = 0;
                List<tVipPayFlow> flows =
                    //                    _db.SqlQueryable<tVipPayFlow>(
                    //                            "select * from tVipPayFlow ")
                    //                        .Where(t => t.sa_date == DateTime.Parse("2019-08-05"))
                    //                        .ToPageList(1, 3, ref totalsize);                List<tVipPayFlow> flows =
                    _db.SqlQueryable<tVipPayFlow>(
                            "select * from tVipPayFlow where sa_date='2019-08-05'")
                        .ToPageList(1, 3, ref totalsize);
                //输出显示
                TextShow("总共有：" + totalsize + "条数据");
                foreach (tVipPayFlow item in flows)
                {
                    TextShow("销售日期：" + item.sa_date + " 时间：" + item.sa_time
                             + " 销售额：" + item.Amount + " 流水号：" + item.SerialNo);
                }
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnuquerysqlado_Click(object sender, EventArgs e)
        {
            //Ado方法不能使用ToPageList
            string sql = "select * from tVipPayflow " +
                         "where sa_date=@sa_date";

            try
            {
                List<tVipPayFlow> flows =
                    _db.Ado.SqlQuery<tVipPayFlow>(sql,
                        new List<SugarParameter>()
                        {
                            new SugarParameter("@sa_date",
                                DateTime.Parse("2019-08-06"))
                        });

                //输出显示
                foreach (tVipPayFlow item in flows)
                {
                    TextShow("销售日期：" + item.sa_date + " 时间：" + item.sa_time
                             + " 销售额：" + item.Amount + " 流水号：" + item.SerialNo);
                }
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnuQueue_Click(object sender, EventArgs e)
        {
            try
            {
                _db.Insertable(new POS()
                {
                    Posno = "0031",
                    Posname = "31款台"
                }).AddQueue();
                _db.Insertable(new POS()
                {
                    Posno = "0032",
                    Posname = "32款台"
                }).AddQueue();

                //将2条插入一起执行带有事务，
                //如果外部有事务会走外部事务，外部没事务会走内部事务
                int count = _db.SaveQueues();
                TextShow("插入了" + count + "条数据");

            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private async void tsmunQueueAsync_Click(object sender, EventArgs e)
        {
            try
            {
                _db.Insertable(new POS()
                {
                    Posno = "0033",
                    Posname = "33款台"
                }).AddQueue();
                _db.Insertable(new POS()
                {
                    Posno = "0034",
                    Posname = "34款台"
                }).AddQueue();

                int count = await _db.SaveQueuesAsync();
                //                ar.Wait();
                TextShow("插入了" + count + "条数据");

            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnuqueueqry_Click(object sender, EventArgs e)
        {
            try
            {
                _db.Queryable<POS>().AddQueue();
                _db.Queryable<POSTemp>().AddQueue();

                var result = _db.SaveQueues<POS, POSTemp>();
                for (int i = 0; i < 2; i++)
                {
                    POS tmPos = result.Item1[i];
                    TextShow("POS:" + tmPos.Posno + " " + tmPos.Posname);

                    POSTemp lPosTemp = result.Item2[i];
                    TextShow("POSTemp:" + lPosTemp.Posno + " " + lPosTemp.Posname);
                }

            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnuquery_Click(object sender, EventArgs e)
        {
            try
            {
                _db.Queryable<POS>().AddQueue();

                _db.AddQueue("select top 2 * from tVipPayFlow");

                var result = _db.SaveQueues<POS, tVipPayFlow>();
                for (int i = 0; i < 2; i++)
                {
                    POS tmPos = result.Item1[i];
                    TextShow("POS:" + tmPos.Posno + " " + tmPos.Posname);

                    tVipPayFlow payFlow = result.Item2[i];
                    TextShow("tVipPayFlow:" + payFlow.SerialNo + " "
                             + payFlow.sa_date + " " + payFlow.Vipno
                             + " " + payFlow.Amount);
                }

            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void tsmnucacheinsert_Click(object sender, EventArgs e)
        {
            try
            {
                //将​tVipPayFlow表中和Pos表中Posno字段相等的数据
                //取出来存入缓存中
                List<tVipPayFlow> list = _db.Queryable<POS, tVipPayFlow>(
                        (t1, t2) => t1.Posno == t2.PosNo)
                    .Select((t1, t2) => t2)
                    .WithCache()
                    .ToList();
                TextShow("缓存了" + list.Count + "条数据");

                //把缓存中数据的bankno字段原来为空的
                //改为Posno的值加上Serialno的值
                list.ForEach(p=>p.bankno=p.PosNo+p.SerialNo);
                TextShow("更新了bankno的值");

                //改完后的数据重新插入进tVipPayFlow中
                int count = _db.Insertable(list)
                    .RemoveDataCache()
                    .ExecuteCommand();
                TextShow("插入了" + count + "条带有bankno数据");
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }

        private void 测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int totalsize = 0;
                List<CProductInfo> flows =
                    _db.SqlQueryable<CProductInfo>(
                            $" select a.incode,b.BarCode,a.fname,a.specs,a.iprc,a.rprc,a.kcqty,a.pfrprc,a.hyrprc,a.Unit,a.origin,a.enterpriseid from " +
                            $"(select x.PluCode as incode, x.BarCode, x.PluName as fname, x.Spec as specs, k.JPrice as iprc, (case when isnull(k.Price, 0) = 0 then x.Price else k.Price end) as rprc," +
                            $"k.GCount + k.CCount as kcqty,(case when isnull(k.PFPrice,0)= 0 then x.PFPrice else k.PFPrice end) as pfrprc,(case when isnull(k.OJPrice,0)= 0 then x.JPrice else k.OJPrice end) as hyrprc," +
                            $"x.Unit,x.ProdArea as origin,x.VendorCode as enterpriseid from Goods x,GoodsOrg k where x.PluCode = k.PluCode " +
                            $"and x.PLuType = '0' and x.PluStatus != '2' and k.orgcode = '001' and k.isRight = '1') a," +
                            $"(select PluCode, BarCode from Goods union select PluCode,BarCode from BarCodeRef) b where a.incode = b.PluCode")
                        .ToPageList(2, 5000, ref totalsize);
                //输出显示
                TextShow("总共有：" + totalsize + "条数据");
                //foreach (CProductInfo item in flows)
                //{
                //    TextShow("编码：" + item.incode + " 条码：" + item.barcode
                //             + " 名称：" + item.fname + " 进价：" + item.iprc
                //             + " 售价：" + item.rprc);
                //}
            }
            catch (Exception ex)
            {
                TextShow(ex.Message);
            }
        }
    }
}