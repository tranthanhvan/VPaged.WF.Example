namespace VPaged.WF.Example
{
    partial class FrmEmployee
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
            this.BtnLoad = new System.Windows.Forms.Button();
            this.ContainerPaging = new System.Windows.Forms.GroupBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.GridMaster = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.numOnePage = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.GridMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOnePage)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(515, 42);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 16;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // ContainerPaging
            // 
            this.ContainerPaging.Location = new System.Drawing.Point(12, 277);
            this.ContainerPaging.Name = "ContainerPaging";
            this.ContainerPaging.Size = new System.Drawing.Size(497, 57);
            this.ContainerPaging.TabIndex = 15;
            this.ContainerPaging.TabStop = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(699, 231);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(83, 28);
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(610, 231);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(518, 137);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 16);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID :";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(518, 178);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 16);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(580, 175);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 22);
            this.txtName.TabIndex = 10;
            // 
            // GridMaster
            // 
            this.GridMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMaster.Location = new System.Drawing.Point(12, 12);
            this.GridMaster.Name = "GridMaster";
            this.GridMaster.RowHeadersWidth = 51;
            this.GridMaster.RowTemplate.Height = 24;
            this.GridMaster.Size = new System.Drawing.Size(497, 248);
            this.GridMaster.TabIndex = 9;
            this.GridMaster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMaster_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Number on page  :";
            // 
            // numOnePage
            // 
            this.numOnePage.Location = new System.Drawing.Point(638, 13);
            this.numOnePage.Name = "numOnePage";
            this.numOnePage.Size = new System.Drawing.Size(120, 22);
            this.numOnePage.TabIndex = 19;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 346);
            this.Controls.Add(this.numOnePage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.ContainerPaging);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.GridMaster);
            this.Name = "FrmEmployee";
            this.Text = "FrmEmployee";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOnePage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.GroupBox ContainerPaging;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView GridMaster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numOnePage;
    }
}