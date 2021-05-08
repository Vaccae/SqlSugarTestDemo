namespace SqlSugarTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCreateCls = new System.Windows.Forms.Button();
            this.btnconnect = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnquery = new System.Windows.Forms.Button();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnQuery = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmnuqryall = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuqry5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuqrynolock = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuqrykey = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuqryone = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuqryunion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuqryin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuqrynotin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuqrywhere = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuqrysqlfunc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuqrysum = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuqrybetween = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuqryorder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuqryexists = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnInsert = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmnuinsertcount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuinsertident = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuinsertcls = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuinsertcolumn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuinsertignore = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuinsertignorewhere = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuinsertignorelist = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuinsertlock = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuinsertarray = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuinsertdictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuinsertAtoB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnupdate = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmnuupdatecls = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuupdatewhere = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnupdatenotcls = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuupdateunion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuupdatecasewhere = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnusave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtndelete = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmnudeletecls = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnudeletewhere = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnother = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmnuquerypage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuTrans = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuquerysql = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuquerysqlado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnucache = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnucacheinsert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnsqlpackage = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmnuQueue = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmunQueueAsync = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuqueueqry = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuquery = new System.Windows.Forms.ToolStripMenuItem();
            this.测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateCls
            // 
            this.btnCreateCls.Location = new System.Drawing.Point(140, 43);
            this.btnCreateCls.Name = "btnCreateCls";
            this.btnCreateCls.Size = new System.Drawing.Size(98, 48);
            this.btnCreateCls.TabIndex = 0;
            this.btnCreateCls.Text = "生成类";
            this.btnCreateCls.UseVisualStyleBackColor = true;
            this.btnCreateCls.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(12, 43);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(106, 48);
            this.btnconnect.TabIndex = 1;
            this.btnconnect.Text = "连接数据库";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(278, 43);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(98, 48);
            this.btninsert.TabIndex = 2;
            this.btninsert.Text = "插入数据";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(397, 43);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(98, 48);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "修改数据";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(522, 43);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(98, 48);
            this.btndel.TabIndex = 4;
            this.btndel.Text = "删除数据";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnquery
            // 
            this.btnquery.Location = new System.Drawing.Point(643, 43);
            this.btnquery.Name = "btnquery";
            this.btnquery.Size = new System.Drawing.Size(98, 48);
            this.btnquery.TabIndex = 5;
            this.btnquery.Text = "查询数据";
            this.btnquery.UseVisualStyleBackColor = true;
            this.btnquery.Click += new System.EventHandler(this.btnquery_Click);
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(33, 111);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(691, 447);
            this.tbMsg.TabIndex = 6;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnQuery,
            this.toolStripSeparator1,
            this.tsbtnInsert,
            this.toolStripSeparator2,
            this.tsbtnupdate,
            this.toolStripSeparator3,
            this.tsbtndelete,
            this.toolStripSeparator4,
            this.tsbtnother,
            this.toolStripSeparator5,
            this.tsbtnsqlpackage});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 33);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnQuery
            // 
            this.tsbtnQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnQuery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuqryall,
            this.tsmnuqry5,
            this.tsmnuqrynolock,
            this.tsmnuqrykey,
            this.tsmnuqryone,
            this.tsmnuqryunion,
            this.tsmnuqryin,
            this.tsmnuqrynotin,
            this.tsmnuqrywhere,
            this.tsmnuqrysqlfunc,
            this.tsmnuqrysum,
            this.tsmnuqrybetween,
            this.tsmnuqryorder,
            this.tsmnuqryexists});
            this.tsbtnQuery.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnQuery.Image")));
            this.tsbtnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnQuery.Name = "tsbtnQuery";
            this.tsbtnQuery.Size = new System.Drawing.Size(64, 28);
            this.tsbtnQuery.Text = "查询";
            // 
            // tsmnuqryall
            // 
            this.tsmnuqryall.Name = "tsmnuqryall";
            this.tsmnuqryall.Size = new System.Drawing.Size(321, 34);
            this.tsmnuqryall.Text = "查询所有";
            this.tsmnuqryall.Click += new System.EventHandler(this.tsmnuqryall_Click);
            // 
            // tsmnuqry5
            // 
            this.tsmnuqry5.Name = "tsmnuqry5";
            this.tsmnuqry5.Size = new System.Drawing.Size(321, 34);
            this.tsmnuqry5.Text = "查询前5条";
            this.tsmnuqry5.Click += new System.EventHandler(this.tsmnuqry5_Click);
            // 
            // tsmnuqrynolock
            // 
            this.tsmnuqrynolock.Name = "tsmnuqrynolock";
            this.tsmnuqrynolock.Size = new System.Drawing.Size(321, 34);
            this.tsmnuqrynolock.Text = "无锁查询";
            this.tsmnuqrynolock.Click += new System.EventHandler(this.tsmnuqrynolock_Click);
            // 
            // tsmnuqrykey
            // 
            this.tsmnuqrykey.Name = "tsmnuqrykey";
            this.tsmnuqrykey.Size = new System.Drawing.Size(321, 34);
            this.tsmnuqrykey.Text = "根据主键查询";
            this.tsmnuqrykey.Click += new System.EventHandler(this.tsmnuqrykey_Click);
            // 
            // tsmnuqryone
            // 
            this.tsmnuqryone.Name = "tsmnuqryone";
            this.tsmnuqryone.Size = new System.Drawing.Size(321, 34);
            this.tsmnuqryone.Text = "查询单条";
            this.tsmnuqryone.Click += new System.EventHandler(this.tsmnuqryone_Click);
            // 
            // tsmnuqryunion
            // 
            this.tsmnuqryunion.Name = "tsmnuqryunion";
            this.tsmnuqryunion.Size = new System.Drawing.Size(321, 34);
            this.tsmnuqryunion.Text = "联合查询UNION ALL";
            this.tsmnuqryunion.Click += new System.EventHandler(this.tsmnuqryunion_Click);
            // 
            // tsmnuqryin
            // 
            this.tsmnuqryin.Name = "tsmnuqryin";
            this.tsmnuqryin.Size = new System.Drawing.Size(321, 34);
            this.tsmnuqryin.Text = "IN查询";
            this.tsmnuqryin.Click += new System.EventHandler(this.tsmnuqryin_Click);
            // 
            // tsmnuqrynotin
            // 
            this.tsmnuqrynotin.Name = "tsmnuqrynotin";
            this.tsmnuqrynotin.Size = new System.Drawing.Size(321, 34);
            this.tsmnuqrynotin.Text = "NOT IN查询";
            this.tsmnuqrynotin.Click += new System.EventHandler(this.tsmnuqrynotin_Click);
            // 
            // tsmnuqrywhere
            // 
            this.tsmnuqrywhere.Name = "tsmnuqrywhere";
            this.tsmnuqrywhere.Size = new System.Drawing.Size(321, 34);
            this.tsmnuqrywhere.Text = "条件查询";
            this.tsmnuqrywhere.Click += new System.EventHandler(this.tsmnuqrywhere_Click);
            // 
            // tsmnuqrysqlfunc
            // 
            this.tsmnuqrysqlfunc.Name = "tsmnuqrysqlfunc";
            this.tsmnuqrysqlfunc.Size = new System.Drawing.Size(321, 34);
            this.tsmnuqrysqlfunc.Text = "使用函数 SqlFunc类";
            this.tsmnuqrysqlfunc.Click += new System.EventHandler(this.tsmnuqrysqlfunc_Click);
            // 
            // tsmnuqrysum
            // 
            this.tsmnuqrysum.Name = "tsmnuqrysum";
            this.tsmnuqrysum.Size = new System.Drawing.Size(321, 34);
            this.tsmnuqrysum.Text = "SUM MAX MIN AVG查询";
            this.tsmnuqrysum.Click += new System.EventHandler(this.tsmnuqrysum_Click);
            // 
            // tsmnuqrybetween
            // 
            this.tsmnuqrybetween.Name = "tsmnuqrybetween";
            this.tsmnuqrybetween.Size = new System.Drawing.Size(321, 34);
            this.tsmnuqrybetween.Text = "Between查询";
            this.tsmnuqrybetween.Click += new System.EventHandler(this.tsmnuqrybetween_Click);
            // 
            // tsmnuqryorder
            // 
            this.tsmnuqryorder.Name = "tsmnuqryorder";
            this.tsmnuqryorder.Size = new System.Drawing.Size(321, 34);
            this.tsmnuqryorder.Text = "排序";
            this.tsmnuqryorder.Click += new System.EventHandler(this.tsmnuqryorder_Click);
            // 
            // tsmnuqryexists
            // 
            this.tsmnuqryexists.Name = "tsmnuqryexists";
            this.tsmnuqryexists.Size = new System.Drawing.Size(321, 34);
            this.tsmnuqryexists.Text = "是否存在";
            this.tsmnuqryexists.Click += new System.EventHandler(this.tsmnuqryexists_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // tsbtnInsert
            // 
            this.tsbtnInsert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnInsert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuinsertcount,
            this.tsmnuinsertident,
            this.tsmnuinsertcls,
            this.tsmnuinsertcolumn,
            this.tsmnuinsertignore,
            this.tsmnuinsertignorewhere,
            this.tsmnuinsertignorelist,
            this.tsmnuinsertlock,
            this.tsmnuinsertarray,
            this.tsmnuinsertdictionary,
            this.tsmnuinsertAtoB});
            this.tsbtnInsert.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnInsert.Image")));
            this.tsbtnInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnInsert.Name = "tsbtnInsert";
            this.tsbtnInsert.Size = new System.Drawing.Size(64, 28);
            this.tsbtnInsert.Text = "插入";
            // 
            // tsmnuinsertcount
            // 
            this.tsmnuinsertcount.Name = "tsmnuinsertcount";
            this.tsmnuinsertcount.Size = new System.Drawing.Size(362, 34);
            this.tsmnuinsertcount.Text = "插入返回影响行数";
            this.tsmnuinsertcount.Click += new System.EventHandler(this.tsmnuinsertcount_Click);
            // 
            // tsmnuinsertident
            // 
            this.tsmnuinsertident.Name = "tsmnuinsertident";
            this.tsmnuinsertident.Size = new System.Drawing.Size(362, 34);
            this.tsmnuinsertident.Text = "插入返回自增列";
            this.tsmnuinsertident.Click += new System.EventHandler(this.tsmnuinsertident_Click);
            // 
            // tsmnuinsertcls
            // 
            this.tsmnuinsertcls.Name = "tsmnuinsertcls";
            this.tsmnuinsertcls.Size = new System.Drawing.Size(362, 34);
            this.tsmnuinsertcls.Text = "插入返回实体";
            this.tsmnuinsertcls.Click += new System.EventHandler(this.tsmnuinsertcls_Click);
            // 
            // tsmnuinsertcolumn
            // 
            this.tsmnuinsertcolumn.Name = "tsmnuinsertcolumn";
            this.tsmnuinsertcolumn.Size = new System.Drawing.Size(362, 34);
            this.tsmnuinsertcolumn.Text = "只插入对应列";
            this.tsmnuinsertcolumn.Click += new System.EventHandler(this.tsmnuinsertcolumn_Click);
            // 
            // tsmnuinsertignore
            // 
            this.tsmnuinsertignore.Name = "tsmnuinsertignore";
            this.tsmnuinsertignore.Size = new System.Drawing.Size(362, 34);
            this.tsmnuinsertignore.Text = "不插入对应列";
            this.tsmnuinsertignore.Click += new System.EventHandler(this.tsmnuinsertignore_Click);
            // 
            // tsmnuinsertignorewhere
            // 
            this.tsmnuinsertignorewhere.Name = "tsmnuinsertignorewhere";
            this.tsmnuinsertignorewhere.Size = new System.Drawing.Size(362, 34);
            this.tsmnuinsertignorewhere.Text = "根据条件指定不插入列";
            this.tsmnuinsertignorewhere.Click += new System.EventHandler(this.tsmnuinsertignorewhere_Click);
            // 
            // tsmnuinsertignorelist
            // 
            this.tsmnuinsertignorelist.Name = "tsmnuinsertignorelist";
            this.tsmnuinsertignorelist.Size = new System.Drawing.Size(362, 34);
            this.tsmnuinsertignorelist.Text = "List中所有列不插入";
            this.tsmnuinsertignorelist.Click += new System.EventHandler(this.tsmnuinsertignorelist_Click);
            // 
            // tsmnuinsertlock
            // 
            this.tsmnuinsertlock.Name = "tsmnuinsertlock";
            this.tsmnuinsertlock.Size = new System.Drawing.Size(362, 34);
            this.tsmnuinsertlock.Text = "插入使用锁";
            this.tsmnuinsertlock.Click += new System.EventHandler(this.tsmnuinsertlock_Click);
            // 
            // tsmnuinsertarray
            // 
            this.tsmnuinsertarray.Name = "tsmnuinsertarray";
            this.tsmnuinsertarray.Size = new System.Drawing.Size(362, 34);
            this.tsmnuinsertarray.Text = "批量插入（性能很快不用操心）";
            this.tsmnuinsertarray.Click += new System.EventHandler(this.tsmnuinsertarray_Click);
            // 
            // tsmnuinsertdictionary
            // 
            this.tsmnuinsertdictionary.Name = "tsmnuinsertdictionary";
            this.tsmnuinsertdictionary.Size = new System.Drawing.Size(362, 34);
            this.tsmnuinsertdictionary.Text = "匿名对象和字典的支持";
            this.tsmnuinsertdictionary.Click += new System.EventHandler(this.tsmnuinsertdictionary_Click);
            // 
            // tsmnuinsertAtoB
            // 
            this.tsmnuinsertAtoB.Name = "tsmnuinsertAtoB";
            this.tsmnuinsertAtoB.Size = new System.Drawing.Size(362, 34);
            this.tsmnuinsertAtoB.Text = "将A表数据插入B表";
            this.tsmnuinsertAtoB.Click += new System.EventHandler(this.tsmnuinsertAtoB_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // tsbtnupdate
            // 
            this.tsbtnupdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnupdate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuupdatecls,
            this.tsmnuupdatewhere,
            this.tsbtnupdatenotcls,
            this.tsmnuupdateunion,
            this.tsmnuupdatecasewhere,
            this.tsmnusave});
            this.tsbtnupdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnupdate.Image")));
            this.tsbtnupdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnupdate.Name = "tsbtnupdate";
            this.tsbtnupdate.Size = new System.Drawing.Size(64, 28);
            this.tsbtnupdate.Text = "更新";
            // 
            // tsmnuupdatecls
            // 
            this.tsmnuupdatecls.Name = "tsmnuupdatecls";
            this.tsmnuupdatecls.Size = new System.Drawing.Size(362, 34);
            this.tsmnuupdatecls.Text = "传入对象更新";
            this.tsmnuupdatecls.Click += new System.EventHandler(this.tsmnuupdatecls_Click);
            // 
            // tsmnuupdatewhere
            // 
            this.tsmnuupdatewhere.Name = "tsmnuupdatewhere";
            this.tsmnuupdatewhere.Size = new System.Drawing.Size(362, 34);
            this.tsmnuupdatewhere.Text = "伟入对象根据条件更新";
            this.tsmnuupdatewhere.Click += new System.EventHandler(this.tsmnuupdatewhere_Click);
            // 
            // tsbtnupdatenotcls
            // 
            this.tsbtnupdatenotcls.Name = "tsbtnupdatenotcls";
            this.tsbtnupdatenotcls.Size = new System.Drawing.Size(362, 34);
            this.tsbtnupdatenotcls.Text = "不传对象的用法";
            this.tsbtnupdatenotcls.Click += new System.EventHandler(this.tsbtnupdatenotcls_Click);
            // 
            // tsmnuupdateunion
            // 
            this.tsmnuupdateunion.Name = "tsmnuupdateunion";
            this.tsmnuupdateunion.Size = new System.Drawing.Size(362, 34);
            this.tsmnuupdateunion.Text = "联表更新";
            this.tsmnuupdateunion.Click += new System.EventHandler(this.tsmnuupdateunion_Click);
            // 
            // tsmnuupdatecasewhere
            // 
            this.tsmnuupdatecasewhere.Name = "tsmnuupdatecasewhere";
            this.tsmnuupdatecasewhere.Size = new System.Drawing.Size(362, 34);
            this.tsmnuupdatecasewhere.Text = "根据不同条件执行更新不同的列";
            this.tsmnuupdatecasewhere.Click += new System.EventHandler(this.tsmnuupdatecasewhere_Click);
            // 
            // tsmnusave
            // 
            this.tsmnusave.Name = "tsmnusave";
            this.tsmnusave.Size = new System.Drawing.Size(362, 34);
            this.tsmnusave.Text = "保存或者插入功能";
            this.tsmnusave.Click += new System.EventHandler(this.tsmnusave_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // tsbtndelete
            // 
            this.tsbtndelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtndelete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnudeletecls,
            this.tsmnudeletewhere});
            this.tsbtndelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtndelete.Image")));
            this.tsbtndelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtndelete.Name = "tsbtndelete";
            this.tsbtndelete.Size = new System.Drawing.Size(64, 28);
            this.tsbtndelete.Text = "删除";
            // 
            // tsmnudeletecls
            // 
            this.tsmnudeletecls.Name = "tsmnudeletecls";
            this.tsmnudeletecls.Size = new System.Drawing.Size(236, 34);
            this.tsmnudeletecls.Text = "根据实体删除";
            this.tsmnudeletecls.Click += new System.EventHandler(this.tsmnudeletecls_Click);
            // 
            // tsmnudeletewhere
            // 
            this.tsmnudeletewhere.Name = "tsmnudeletewhere";
            this.tsmnudeletewhere.Size = new System.Drawing.Size(236, 34);
            this.tsmnudeletewhere.Text = "根据表达式删除";
            this.tsmnudeletewhere.Click += new System.EventHandler(this.tsmnudeletewhere_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 33);
            // 
            // tsbtnother
            // 
            this.tsbtnother.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnother.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuquerypage,
            this.tsmnuTrans,
            this.tsmnuquerysql,
            this.tsmnuquerysqlado,
            this.tsmnucache});
            this.tsbtnother.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnother.Image")));
            this.tsbtnother.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnother.Name = "tsbtnother";
            this.tsbtnother.Size = new System.Drawing.Size(100, 28);
            this.tsbtnother.Text = "高级应用";
            // 
            // tsmnuquerypage
            // 
            this.tsmnuquerypage.Name = "tsmnuquerypage";
            this.tsmnuquerypage.Size = new System.Drawing.Size(306, 34);
            this.tsmnuquerypage.Text = "分页查询";
            this.tsmnuquerypage.Click += new System.EventHandler(this.tsmnuquerypage_Click);
            // 
            // tsmnuTrans
            // 
            this.tsmnuTrans.Name = "tsmnuTrans";
            this.tsmnuTrans.Size = new System.Drawing.Size(306, 34);
            this.tsmnuTrans.Text = "事务操作";
            this.tsmnuTrans.Click += new System.EventHandler(this.tsmnuTrans_Click);
            // 
            // tsmnuquerysql
            // 
            this.tsmnuquerysql.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.测试ToolStripMenuItem});
            this.tsmnuquerysql.Name = "tsmnuquerysql";
            this.tsmnuquerysql.Size = new System.Drawing.Size(306, 34);
            this.tsmnuquerysql.Text = "执行SQL(Sqlqueryable)";
            this.tsmnuquerysql.Click += new System.EventHandler(this.tsmnuquerysql_Click);
            // 
            // tsmnuquerysqlado
            // 
            this.tsmnuquerysqlado.Name = "tsmnuquerysqlado";
            this.tsmnuquerysqlado.Size = new System.Drawing.Size(306, 34);
            this.tsmnuquerysqlado.Text = "执行SQL(Ado方法）";
            this.tsmnuquerysqlado.Click += new System.EventHandler(this.tsmnuquerysqlado_Click);
            // 
            // tsmnucache
            // 
            this.tsmnucache.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnucacheinsert});
            this.tsmnucache.Name = "tsmnucache";
            this.tsmnucache.Size = new System.Drawing.Size(306, 34);
            this.tsmnucache.Text = "二级缓存功能";
            // 
            // tsmnucacheinsert
            // 
            this.tsmnucacheinsert.Name = "tsmnucacheinsert";
            this.tsmnucacheinsert.Size = new System.Drawing.Size(319, 34);
            this.tsmnucacheinsert.Text = "插入缓存数据bankno有值";
            this.tsmnucacheinsert.Click += new System.EventHandler(this.tsmnucacheinsert_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 33);
            // 
            // tsbtnsqlpackage
            // 
            this.tsbtnsqlpackage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnsqlpackage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuQueue,
            this.tsmunQueueAsync,
            this.tsmnuqueueqry,
            this.tsmnuquery});
            this.tsbtnsqlpackage.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnsqlpackage.Image")));
            this.tsbtnsqlpackage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnsqlpackage.Name = "tsbtnsqlpackage";
            this.tsbtnsqlpackage.Size = new System.Drawing.Size(170, 28);
            this.tsbtnsqlpackage.Text = "批量打包SQL执行";
            // 
            // tsmnuQueue
            // 
            this.tsmnuQueue.Name = "tsmnuQueue";
            this.tsmnuQueue.Size = new System.Drawing.Size(270, 34);
            this.tsmnuQueue.Text = "打包执行";
            this.tsmnuQueue.Click += new System.EventHandler(this.tsmnuQueue_Click);
            // 
            // tsmunQueueAsync
            // 
            this.tsmunQueueAsync.Name = "tsmunQueueAsync";
            this.tsmunQueueAsync.Size = new System.Drawing.Size(270, 34);
            this.tsmunQueueAsync.Text = "打包异步处理";
            this.tsmunQueueAsync.Click += new System.EventHandler(this.tsmunQueueAsync_Click);
            // 
            // tsmnuqueueqry
            // 
            this.tsmnuqueueqry.Name = "tsmnuqueueqry";
            this.tsmnuqueueqry.Size = new System.Drawing.Size(270, 34);
            this.tsmnuqueueqry.Text = "打包查询";
            this.tsmnuqueueqry.Click += new System.EventHandler(this.tsmnuqueueqry_Click);
            // 
            // tsmnuquery
            // 
            this.tsmnuquery.Name = "tsmnuquery";
            this.tsmnuquery.Size = new System.Drawing.Size(270, 34);
            this.tsmnuquery.Text = "手写Sql打包";
            this.tsmnuquery.Click += new System.EventHandler(this.tsmnuquery_Click);
            // 
            // 测试ToolStripMenuItem
            // 
            this.测试ToolStripMenuItem.Name = "测试ToolStripMenuItem";
            this.测试ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.测试ToolStripMenuItem.Text = "测试";
            this.测试ToolStripMenuItem.Click += new System.EventHandler(this.测试ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 578);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tbMsg);
            this.Controls.Add(this.btnquery);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.btnconnect);
            this.Controls.Add(this.btnCreateCls);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateCls;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnquery;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmnuqryall;
        private System.Windows.Forms.ToolStripMenuItem tsmnuqry5;
        private System.Windows.Forms.ToolStripMenuItem tsmnuqrynolock;
        private System.Windows.Forms.ToolStripMenuItem tsmnuqrykey;
        private System.Windows.Forms.ToolStripMenuItem tsmnuqryone;
        private System.Windows.Forms.ToolStripMenuItem tsmnuqryunion;
        private System.Windows.Forms.ToolStripMenuItem tsmnuqryin;
        private System.Windows.Forms.ToolStripMenuItem tsmnuqrynotin;
        private System.Windows.Forms.ToolStripMenuItem tsmnuqrywhere;
        private System.Windows.Forms.ToolStripMenuItem tsmnuqrysqlfunc;
        private System.Windows.Forms.ToolStripMenuItem tsmnuqrysum;
        private System.Windows.Forms.ToolStripMenuItem tsmnuqrybetween;
        private System.Windows.Forms.ToolStripMenuItem tsmnuqryorder;
        private System.Windows.Forms.ToolStripMenuItem tsmnuqryexists;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnInsert;
        private System.Windows.Forms.ToolStripMenuItem tsmnuinsertcount;
        private System.Windows.Forms.ToolStripMenuItem tsmnuinsertident;
        private System.Windows.Forms.ToolStripMenuItem tsmnuinsertcls;
        private System.Windows.Forms.ToolStripMenuItem tsmnuinsertcolumn;
        private System.Windows.Forms.ToolStripMenuItem tsmnuinsertignore;
        private System.Windows.Forms.ToolStripMenuItem tsmnuinsertignorewhere;
        private System.Windows.Forms.ToolStripMenuItem tsmnuinsertignorelist;
        private System.Windows.Forms.ToolStripMenuItem tsmnuinsertlock;
        private System.Windows.Forms.ToolStripMenuItem tsmnuinsertarray;
        private System.Windows.Forms.ToolStripMenuItem tsmnuinsertdictionary;
        private System.Windows.Forms.ToolStripMenuItem tsmnuinsertAtoB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnupdate;
        private System.Windows.Forms.ToolStripMenuItem tsmnuupdatecls;
        private System.Windows.Forms.ToolStripMenuItem tsmnuupdatewhere;
        private System.Windows.Forms.ToolStripMenuItem tsbtnupdatenotcls;
        private System.Windows.Forms.ToolStripMenuItem tsmnuupdateunion;
        private System.Windows.Forms.ToolStripMenuItem tsmnuupdatecasewhere;
        private System.Windows.Forms.ToolStripMenuItem tsmnusave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton tsbtndelete;
        private System.Windows.Forms.ToolStripMenuItem tsmnudeletecls;
        private System.Windows.Forms.ToolStripMenuItem tsmnudeletewhere;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnother;
        private System.Windows.Forms.ToolStripMenuItem tsmnuquerypage;
        private System.Windows.Forms.ToolStripMenuItem tsmnuTrans;
        private System.Windows.Forms.ToolStripMenuItem tsmnuquerysql;
        private System.Windows.Forms.ToolStripMenuItem tsmnuquerysqlado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnsqlpackage;
        private System.Windows.Forms.ToolStripMenuItem tsmnuQueue;
        private System.Windows.Forms.ToolStripMenuItem tsmunQueueAsync;
        private System.Windows.Forms.ToolStripMenuItem tsmnuqueueqry;
        private System.Windows.Forms.ToolStripMenuItem tsmnuquery;
        private System.Windows.Forms.ToolStripMenuItem tsmnucache;
        private System.Windows.Forms.ToolStripMenuItem tsmnucacheinsert;
        private System.Windows.Forms.ToolStripMenuItem 测试ToolStripMenuItem;
    }
}

