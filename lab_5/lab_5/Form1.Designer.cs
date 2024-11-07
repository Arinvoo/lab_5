namespace lab_5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очищення ресурсів.
        /// </summary>
        /// <param name="disposing">Чи потрібно очистити керовані ресурси</param>
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
        /// Обов'язковий метод для підтримки конструктора - не змінюйте 
        /// вміст цього методу за допомогою редактора коду.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFlourType = new System.Windows.Forms.TextBox();
            this.chkSeeds = new System.Windows.Forms.CheckBox();
            this.chkGlutenFree = new System.Windows.Forms.CheckBox();
            this.btnCreateBread = new System.Windows.Forms.Button();
            this.btnCloneBread = new System.Windows.Forms.Button();
            this.lblBreadInfo = new System.Windows.Forms.Label();
            this.lblClonedBreadInfo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFlourType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtFlourType
            // 
            this.txtFlourType.Location = new System.Drawing.Point(130, 60);
            this.txtFlourType.Name = "txtFlourType";
            this.txtFlourType.Size = new System.Drawing.Size(100, 20);
            this.txtFlourType.TabIndex = 1;
            // 
            // chkSeeds
            // 
            this.chkSeeds.AutoSize = true;
            this.chkSeeds.Location = new System.Drawing.Point(130, 95);
            this.chkSeeds.Name = "chkSeeds";
            this.chkSeeds.Size = new System.Drawing.Size(57, 17);
            this.chkSeeds.TabIndex = 2;
            this.chkSeeds.Text = "Seeds";
            this.chkSeeds.UseVisualStyleBackColor = true;
            // 
            // chkGlutenFree
            // 
            this.chkGlutenFree.AutoSize = true;
            this.chkGlutenFree.Location = new System.Drawing.Point(130, 130);
            this.chkGlutenFree.Name = "chkGlutenFree";
            this.chkGlutenFree.Size = new System.Drawing.Size(80, 17);
            this.chkGlutenFree.TabIndex = 3;
            this.chkGlutenFree.Text = "Gluten Free";
            this.chkGlutenFree.UseVisualStyleBackColor = true;
            // 
            // btnCreateBread
            // 
            this.btnCreateBread.Location = new System.Drawing.Point(30, 170);
            this.btnCreateBread.Name = "btnCreateBread";
            this.btnCreateBread.Size = new System.Drawing.Size(100, 23);
            this.btnCreateBread.TabIndex = 4;
            this.btnCreateBread.Text = "Create Bread";
            this.btnCreateBread.UseVisualStyleBackColor = true;
            this.btnCreateBread.Click += new System.EventHandler(this.btnCreateBread_Click);
            // 
            // btnCloneBread
            // 
            this.btnCloneBread.Location = new System.Drawing.Point(150, 170);
            this.btnCloneBread.Name = "btnCloneBread";
            this.btnCloneBread.Size = new System.Drawing.Size(100, 23);
            this.btnCloneBread.TabIndex = 5;
            this.btnCloneBread.Text = "Clone Bread";
            this.btnCloneBread.UseVisualStyleBackColor = true;
            this.btnCloneBread.Click += new System.EventHandler(this.btnCloneBread_Click);
            // 
            // lblBreadInfo
            // 
            this.lblBreadInfo.AutoSize = true;
            this.lblBreadInfo.Location = new System.Drawing.Point(30, 210);
            this.lblBreadInfo.Name = "lblBreadInfo";
            this.lblBreadInfo.Size = new System.Drawing.Size(61, 13);
            this.lblBreadInfo.TabIndex = 6;
            this.lblBreadInfo.Text = "Bread Info:";
            // 
            // lblClonedBreadInfo
            // 
            this.lblClonedBreadInfo.AutoSize = true;
            this.lblClonedBreadInfo.Location = new System.Drawing.Point(30, 240);
            this.lblClonedBreadInfo.Name = "lblClonedBreadInfo";
            this.lblClonedBreadInfo.Size = new System.Drawing.Size(90, 13);
            this.lblClonedBreadInfo.TabIndex = 7;
            this.lblClonedBreadInfo.Text = "Cloned Bread Info";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // lblFlourType
            // 
            this.lblFlourType.AutoSize = true;
            this.lblFlourType.Location = new System.Drawing.Point(30, 63);
            this.lblFlourType.Name = "lblFlourType";
            this.lblFlourType.Size = new System.Drawing.Size(59, 13);
            this.lblFlourType.TabIndex = 9;
            this.lblFlourType.Text = "Flour Type";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblFlourType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblClonedBreadInfo);
            this.Controls.Add(this.lblBreadInfo);
            this.Controls.Add(this.btnCloneBread);
            this.Controls.Add(this.btnCreateBread);
            this.Controls.Add(this.chkGlutenFree);
            this.Controls.Add(this.chkSeeds);
            this.Controls.Add(this.txtFlourType);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Bakery Prototype";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFlourType;
        private System.Windows.Forms.CheckBox chkSeeds;
        private System.Windows.Forms.CheckBox chkGlutenFree;
        private System.Windows.Forms.Button btnCreateBread;
        private System.Windows.Forms.Button btnCloneBread;
        private System.Windows.Forms.Label lblBreadInfo;
        private System.Windows.Forms.Label lblClonedBreadInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFlourType;
    }
}

