namespace RunTask
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.colTaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSysID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExecutionFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUploadPlatfrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPolicyClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUploadClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUploadPlatfromSpecialPolicies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPolicySource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTripType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUploadType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUploading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartedCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_StartTask = new System.Windows.Forms.Button();
            this.lb_TaskStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTask
            // 
            this.dgvTask.AllowUserToAddRows = false;
            this.dgvTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTask.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTaskID,
            this.colSysID,
            this.colExecutionFrequency,
            this.colUploadPlatfrom,
            this.colPolicyClass,
            this.colUploadClass,
            this.colUploadPlatfromSpecialPolicies,
            this.colPolicySource,
            this.colTripType,
            this.colUploadType,
            this.colUploading,
            this.colPreStartTime,
            this.colStatusName,
            this.colStartedCount,
            this.colAllTime,
            this.colAddTime,
            this.colUserID});
            this.dgvTask.Location = new System.Drawing.Point(0, 0);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.RowHeadersVisible = false;
            this.dgvTask.RowTemplate.Height = 23;
            this.dgvTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTask.Size = new System.Drawing.Size(918, 447);
            this.dgvTask.TabIndex = 0;
            // 
            // colTaskID
            // 
            this.colTaskID.DataPropertyName = "ID";
            this.colTaskID.HeaderText = "任务编号";
            this.colTaskID.Name = "colTaskID";
            this.colTaskID.Visible = false;
            // 
            // colSysID
            // 
            this.colSysID.DataPropertyName = "sys_id";
            this.colSysID.HeaderText = "SYSID";
            this.colSysID.Name = "colSysID";
            this.colSysID.Visible = false;
            // 
            // colExecutionFrequency
            // 
            this.colExecutionFrequency.DataPropertyName = "Frequency";
            this.colExecutionFrequency.HeaderText = "任务执行频率";
            this.colExecutionFrequency.Name = "colExecutionFrequency";
            this.colExecutionFrequency.Width = 65;
            // 
            // colUploadPlatfrom
            // 
            this.colUploadPlatfrom.DataPropertyName = "upload_platFrom";
            this.colUploadPlatfrom.HeaderText = "上传平台";
            this.colUploadPlatfrom.Name = "colUploadPlatfrom";
            this.colUploadPlatfrom.Width = 66;
            // 
            // colPolicyClass
            // 
            this.colPolicyClass.DataPropertyName = "policy_class";
            this.colPolicyClass.HeaderText = "政策类型";
            this.colPolicyClass.Name = "colPolicyClass";
            this.colPolicyClass.Width = 65;
            // 
            // colUploadClass
            // 
            this.colUploadClass.DataPropertyName = "PointAndMoney";
            this.colUploadClass.HeaderText = "返点留钱";
            this.colUploadClass.Name = "colUploadClass";
            this.colUploadClass.Width = 65;
            // 
            // colUploadPlatfromSpecialPolicies
            // 
            this.colUploadPlatfromSpecialPolicies.DataPropertyName = "IsSpecial";
            this.colUploadPlatfromSpecialPolicies.HeaderText = "上传平台特价政策";
            this.colUploadPlatfromSpecialPolicies.Name = "colUploadPlatfromSpecialPolicies";
            this.colUploadPlatfromSpecialPolicies.Width = 66;
            // 
            // colPolicySource
            // 
            this.colPolicySource.DataPropertyName = "policySource";
            this.colPolicySource.HeaderText = "政策来源";
            this.colPolicySource.Name = "colPolicySource";
            this.colPolicySource.Width = 65;
            // 
            // colTripType
            // 
            this.colTripType.DataPropertyName = "TheTripType";
            this.colTripType.HeaderText = "航程类型";
            this.colTripType.Name = "colTripType";
            this.colTripType.Width = 65;
            // 
            // colUploadType
            // 
            this.colUploadType.DataPropertyName = "AllOrAdd";
            this.colUploadType.HeaderText = "上传类型";
            this.colUploadType.Name = "colUploadType";
            this.colUploadType.Width = 66;
            // 
            // colUploading
            // 
            this.colUploading.HeaderText = "待定义字段";
            this.colUploading.Name = "colUploading";
            this.colUploading.Visible = false;
            // 
            // colPreStartTime
            // 
            this.colPreStartTime.DataPropertyName = "execution_time";
            this.colPreStartTime.HeaderText = "准备执行时间";
            this.colPreStartTime.Name = "colPreStartTime";
            this.colPreStartTime.Width = 65;
            // 
            // colStatusName
            // 
            this.colStatusName.DataPropertyName = "StatusName";
            this.colStatusName.HeaderText = "状态";
            this.colStatusName.Name = "colStatusName";
            this.colStatusName.Width = 66;
            // 
            // colStartedCount
            // 
            this.colStartedCount.DataPropertyName = "execute_number";
            this.colStartedCount.HeaderText = "已启动次数";
            this.colStartedCount.Name = "colStartedCount";
            this.colStartedCount.Width = 65;
            // 
            // colAllTime
            // 
            this.colAllTime.DataPropertyName = "NextFullTime";
            this.colAllTime.HeaderText = "全量执行时间间隔";
            this.colAllTime.Name = "colAllTime";
            this.colAllTime.Width = 65;
            // 
            // colAddTime
            // 
            this.colAddTime.DataPropertyName = "NextAddTime";
            this.colAddTime.HeaderText = "增量执行时间间隔";
            this.colAddTime.Name = "colAddTime";
            this.colAddTime.Width = 66;
            // 
            // colUserID
            // 
            this.colUserID.DataPropertyName = "UserName";
            this.colUserID.HeaderText = "创建者";
            this.colUserID.Name = "colUserID";
            this.colUserID.Width = 65;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_StartTask
            // 
            this.btn_StartTask.Location = new System.Drawing.Point(812, 452);
            this.btn_StartTask.Name = "btn_StartTask";
            this.btn_StartTask.Size = new System.Drawing.Size(94, 31);
            this.btn_StartTask.TabIndex = 1;
            this.btn_StartTask.Text = "启动任务(&S)";
            this.btn_StartTask.UseVisualStyleBackColor = true;
            this.btn_StartTask.Click += new System.EventHandler(this.btn_StartTask_Click);
            // 
            // lb_TaskStatus
            // 
            this.lb_TaskStatus.AutoSize = true;
            this.lb_TaskStatus.Location = new System.Drawing.Point(604, 461);
            this.lb_TaskStatus.Name = "lb_TaskStatus";
            this.lb_TaskStatus.Size = new System.Drawing.Size(0, 13);
            this.lb_TaskStatus.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 488);
            this.Controls.Add(this.lb_TaskStatus);
            this.Controls.Add(this.btn_StartTask);
            this.Controls.Add(this.dgvTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "政策任务自动上传监控";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTask;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSysID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExecutionFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUploadPlatfrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPolicyClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUploadClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUploadPlatfromSpecialPolicies;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPolicySource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTripType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUploadType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUploading;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartedCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.Button btn_StartTask;
        private System.Windows.Forms.Label lb_TaskStatus;
    }
}

