namespace imgTimeFix1
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.scanBtn1 = new System.Windows.Forms.Button();
            this.editBtn1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pathInput1 = new System.Windows.Forms.TextBox();
            this.typeInput1 = new System.Windows.Forms.TextBox();
            this.newName = new System.Windows.Forms.TextBox();
            this.newCreation = new System.Windows.Forms.TextBox();
            this.newType = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.creationTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.switchBtn1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.54656F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.45344F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1034, 569);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.scanBtn1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.editBtn1, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.switchBtn1, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(833, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.43781F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.43781F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.43781F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.43781F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.43781F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.43781F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.68657F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.68657F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(198, 543);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // scanBtn1
            // 
            this.scanBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanBtn1.Location = new System.Drawing.Point(3, 3);
            this.scanBtn1.Name = "scanBtn1";
            this.scanBtn1.Size = new System.Drawing.Size(192, 53);
            this.scanBtn1.TabIndex = 2;
            this.scanBtn1.Text = "SCAN";
            this.scanBtn1.UseVisualStyleBackColor = true;
            this.scanBtn1.Click += new System.EventHandler(this.scanBtn1_Click);
            // 
            // editBtn1
            // 
            this.editBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn1.Location = new System.Drawing.Point(3, 271);
            this.editBtn1.Name = "editBtn1";
            this.editBtn1.Size = new System.Drawing.Size(192, 53);
            this.editBtn1.TabIndex = 2;
            this.editBtn1.Text = "EDIT";
            this.editBtn1.UseVisualStyleBackColor = true;
            this.editBtn1.Click += new System.EventHandler(this.editBtn1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pathInput1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.typeInput1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.newName, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.newCreation, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.newType, 0, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(589, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(238, 563);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // pathInput1
            // 
            this.pathInput1.Location = new System.Drawing.Point(3, 3);
            this.pathInput1.Name = "pathInput1";
            this.pathInput1.Size = new System.Drawing.Size(232, 25);
            this.pathInput1.TabIndex = 1;
            this.pathInput1.Text = "Folder Path 1";
            // 
            // typeInput1
            // 
            this.typeInput1.Location = new System.Drawing.Point(3, 65);
            this.typeInput1.Name = "typeInput1";
            this.typeInput1.Size = new System.Drawing.Size(232, 25);
            this.typeInput1.TabIndex = 2;
            this.typeInput1.Text = "File Type";
            // 
            // newName
            // 
            this.newName.Location = new System.Drawing.Point(3, 189);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(232, 25);
            this.newName.TabIndex = 3;
            this.newName.Text = "Change Name";
            // 
            // newCreation
            // 
            this.newCreation.Location = new System.Drawing.Point(3, 251);
            this.newCreation.Name = "newCreation";
            this.newCreation.Size = new System.Drawing.Size(232, 25);
            this.newCreation.TabIndex = 4;
            this.newCreation.Text = "Change Creation Time";
            // 
            // newType
            // 
            this.newType.Location = new System.Drawing.Point(3, 313);
            this.newType.Name = "newType";
            this.newType.Size = new System.Drawing.Size(232, 25);
            this.newType.TabIndex = 5;
            this.newType.Text = "Change File Type";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.creationTime,
            this.type,
            this.imgTime});
            this.listView1.FullRowSelect = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(580, 563);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Tag = "";
            this.name.Text = "Name";
            this.name.Width = 114;
            // 
            // creationTime
            // 
            this.creationTime.Text = "Creation Time";
            this.creationTime.Width = 150;
            // 
            // type
            // 
            this.type.Text = "File Type";
            this.type.Width = 113;
            // 
            // imgTime
            // 
            this.imgTime.Text = "Image Taken Time";
            this.imgTime.Width = 149;
            // 
            // switchBtn1
            // 
            this.switchBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchBtn1.Location = new System.Drawing.Point(3, 70);
            this.switchBtn1.Name = "switchBtn1";
            this.switchBtn1.Size = new System.Drawing.Size(192, 51);
            this.switchBtn1.TabIndex = 3;
            this.switchBtn1.Text = "Switch";
            this.switchBtn1.UseVisualStyleBackColor = true;
            this.switchBtn1.Click += new System.EventHandler(this.switchBtn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 593);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox pathInput1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button scanBtn1;
        private System.Windows.Forms.Button editBtn1;
        private System.Windows.Forms.TextBox typeInput1;
        private System.Windows.Forms.TextBox newName;
        private System.Windows.Forms.TextBox newCreation;
        private System.Windows.Forms.TextBox newType;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader creationTime;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader imgTime;
        private System.Windows.Forms.Button switchBtn1;
    }
}

