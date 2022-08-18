namespace VPaged.Example
{
    partial class Form1
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
            this.GridMaster = new System.Windows.Forms.DataGridView();
            this.ContainerPager = new System.Windows.Forms.GroupBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // GridMaster
            // 
            this.GridMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMaster.Location = new System.Drawing.Point(31, 27);
            this.GridMaster.Name = "GridMaster";
            this.GridMaster.RowHeadersWidth = 51;
            this.GridMaster.RowTemplate.Height = 24;
            this.GridMaster.Size = new System.Drawing.Size(469, 248);
            this.GridMaster.TabIndex = 0;
            // 
            // ContainerPager
            // 
            this.ContainerPager.Location = new System.Drawing.Point(31, 281);
            this.ContainerPager.Name = "ContainerPager";
            this.ContainerPager.Size = new System.Drawing.Size(469, 53);
            this.ContainerPager.TabIndex = 1;
            this.ContainerPager.TabStop = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(522, 27);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(107, 40);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add item";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(522, 87);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(107, 40);
            this.BtnRemove.TabIndex = 3;
            this.BtnRemove.Text = "Delete item";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 355);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.ContainerPager);
            this.Controls.Add(this.GridMaster);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridMaster;
        private System.Windows.Forms.GroupBox ContainerPager;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRemove;
    }
}

