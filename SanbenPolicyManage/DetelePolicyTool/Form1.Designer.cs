namespace DetelePolicyTool
{
    partial class FormDelelePolicy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Platform = new System.Windows.Forms.Label();
            this.cmb_Platfrom = new System.Windows.Forms.ComboBox();
            this.btn_DeletePolicy = new System.Windows.Forms.Button();
            this.lb_Status = new System.Windows.Forms.Label();
            this.cmb_PolicyType = new System.Windows.Forms.ComboBox();
            this.chk_FULL = new System.Windows.Forms.CheckBox();
            this.chk_ADD = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lb_Platform
            // 
            this.lb_Platform.AutoSize = true;
            this.lb_Platform.Location = new System.Drawing.Point(28, 41);
            this.lb_Platform.Name = "lb_Platform";
            this.lb_Platform.Size = new System.Drawing.Size(46, 13);
            this.lb_Platform.TabIndex = 0;
            this.lb_Platform.Text = "平台 ：";
            // 
            // cmb_Platfrom
            // 
            this.cmb_Platfrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Platfrom.FormattingEnabled = true;
            this.cmb_Platfrom.Items.AddRange(new object[] {
            "qunaerTH",
            "qunaerTTS"});
            this.cmb_Platfrom.Location = new System.Drawing.Point(80, 38);
            this.cmb_Platfrom.Name = "cmb_Platfrom";
            this.cmb_Platfrom.Size = new System.Drawing.Size(136, 21);
            this.cmb_Platfrom.TabIndex = 1;
            // 
            // btn_DeletePolicy
            // 
            this.btn_DeletePolicy.Location = new System.Drawing.Point(378, 37);
            this.btn_DeletePolicy.Name = "btn_DeletePolicy";
            this.btn_DeletePolicy.Size = new System.Drawing.Size(75, 21);
            this.btn_DeletePolicy.TabIndex = 2;
            this.btn_DeletePolicy.Text = "删除(&D)";
            this.btn_DeletePolicy.UseVisualStyleBackColor = true;
            this.btn_DeletePolicy.Click += new System.EventHandler(this.btn_DeletePolicy_Click);
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Location = new System.Drawing.Point(28, 80);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(0, 13);
            this.lb_Status.TabIndex = 0;
            // 
            // cmb_PolicyType
            // 
            this.cmb_PolicyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PolicyType.FormattingEnabled = true;
            this.cmb_PolicyType.Items.AddRange(new object[] {
            "COMMON",
            "PREPAY",
            "APPLY",
            "CUSTOMER",
            "LOWPRICE",
            "ROUNDPREPAY",
            "ROUNDSPECIAL",
            "SINGLEALL",
            "ROUNDALL"});
            this.cmb_PolicyType.Location = new System.Drawing.Point(233, 38);
            this.cmb_PolicyType.Name = "cmb_PolicyType";
            this.cmb_PolicyType.Size = new System.Drawing.Size(121, 21);
            this.cmb_PolicyType.TabIndex = 1;
            // 
            // chk_FULL
            // 
            this.chk_FULL.AutoSize = true;
            this.chk_FULL.Checked = true;
            this.chk_FULL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_FULL.Location = new System.Drawing.Point(302, 76);
            this.chk_FULL.Name = "chk_FULL";
            this.chk_FULL.Size = new System.Drawing.Size(52, 17);
            this.chk_FULL.TabIndex = 3;
            this.chk_FULL.Text = "FULL";
            this.chk_FULL.UseVisualStyleBackColor = true;
            this.chk_FULL.Click += new System.EventHandler(this.chk_FULL_Click);
            // 
            // chk_ADD
            // 
            this.chk_ADD.AutoSize = true;
            this.chk_ADD.Location = new System.Drawing.Point(233, 77);
            this.chk_ADD.Name = "chk_ADD";
            this.chk_ADD.Size = new System.Drawing.Size(49, 17);
            this.chk_ADD.TabIndex = 3;
            this.chk_ADD.Text = "ADD";
            this.chk_ADD.UseVisualStyleBackColor = true;
            this.chk_ADD.Click += new System.EventHandler(this.chk_ADD_Click);
            // 
            // FormDelelePolicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 106);
            this.Controls.Add(this.chk_ADD);
            this.Controls.Add(this.chk_FULL);
            this.Controls.Add(this.btn_DeletePolicy);
            this.Controls.Add(this.cmb_PolicyType);
            this.Controls.Add(this.cmb_Platfrom);
            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.lb_Platform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDelelePolicy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "政策删除工具";
            this.Load += new System.EventHandler(this.FormDelelePolicy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Platform;
        private System.Windows.Forms.ComboBox cmb_Platfrom;
        private System.Windows.Forms.Button btn_DeletePolicy;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.ComboBox cmb_PolicyType;
        private System.Windows.Forms.CheckBox chk_FULL;
        private System.Windows.Forms.CheckBox chk_ADD;
    }
}

