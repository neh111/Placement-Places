
namespace placement_places.Gui
{
    partial class FrmAddClass
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddClass));
            this.lblTatel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCodeClass = new System.Windows.Forms.Label();
            this.lblNameGrade = new System.Windows.Forms.Label();
            this.txtNameGrade = new System.Windows.Forms.TextBox();
            this.txtCodeClass = new System.Windows.Forms.TextBox();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblNumClass = new System.Windows.Forms.Label();
            this.txtNumClass = new System.Windows.Forms.TextBox();
            this.btnToSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTatel
            // 
            this.lblTatel.AutoSize = true;
            this.lblTatel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTatel.Location = new System.Drawing.Point(600, 46);
            this.lblTatel.Name = "lblTatel";
            this.lblTatel.Size = new System.Drawing.Size(155, 36);
            this.lblTatel.TabIndex = 0;
            this.lblTatel.Text = "הוספת כתה";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(296, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(328, 231);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblCodeClass
            // 
            this.lblCodeClass.AutoSize = true;
            this.lblCodeClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCodeClass.Location = new System.Drawing.Point(1133, 145);
            this.lblCodeClass.Name = "lblCodeClass";
            this.lblCodeClass.Size = new System.Drawing.Size(82, 25);
            this.lblCodeClass.TabIndex = 2;
            this.lblCodeClass.Text = "קוד כתה";
            // 
            // lblNameGrade
            // 
            this.lblNameGrade.AutoSize = true;
            this.lblNameGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNameGrade.Location = new System.Drawing.Point(1123, 200);
            this.lblNameGrade.Name = "lblNameGrade";
            this.lblNameGrade.Size = new System.Drawing.Size(92, 25);
            this.lblNameGrade.TabIndex = 3;
            this.lblNameGrade.Text = "שם שנתון";
            this.lblNameGrade.Click += new System.EventHandler(this.lblNameClass_Click);
            // 
            // txtNameGrade
            // 
            this.txtNameGrade.Location = new System.Drawing.Point(988, 200);
            this.txtNameGrade.Name = "txtNameGrade";
            this.txtNameGrade.Size = new System.Drawing.Size(100, 22);
            this.txtNameGrade.TabIndex = 4;
            this.txtNameGrade.TextChanged += new System.EventHandler(this.txtNameGrade_TextChanged);
            // 
            // txtCodeClass
            // 
            this.txtCodeClass.Location = new System.Drawing.Point(988, 148);
            this.txtCodeClass.Name = "txtCodeClass";
            this.txtCodeClass.Size = new System.Drawing.Size(100, 22);
            this.txtCodeClass.TabIndex = 5;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddClass.Location = new System.Drawing.Point(447, 413);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(177, 58);
            this.btnAddClass.TabIndex = 6;
            this.btnAddClass.Text = "הוספת כתה חדשה";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSave.Location = new System.Drawing.Point(366, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 58);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "שמור";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRefresh.Location = new System.Drawing.Point(285, 413);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 58);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "רענן";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblNumClass
            // 
            this.lblNumClass.AutoSize = true;
            this.lblNumClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNumClass.Location = new System.Drawing.Point(1123, 249);
            this.lblNumClass.Name = "lblNumClass";
            this.lblNumClass.Size = new System.Drawing.Size(95, 25);
            this.lblNumClass.TabIndex = 9;
            this.lblNumClass.Text = "מספר כתה";
            // 
            // txtNumClass
            // 
            this.txtNumClass.Location = new System.Drawing.Point(988, 249);
            this.txtNumClass.Name = "txtNumClass";
            this.txtNumClass.Size = new System.Drawing.Size(100, 22);
            this.txtNumClass.TabIndex = 10;
            // 
            // btnToSettings
            // 
            this.btnToSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnToSettings.Location = new System.Drawing.Point(1212, 31);
            this.btnToSettings.Name = "btnToSettings";
            this.btnToSettings.Size = new System.Drawing.Size(124, 73);
            this.btnToSettings.TabIndex = 11;
            this.btnToSettings.Text = "חזרה לטופס הגדרות";
            this.btnToSettings.UseVisualStyleBackColor = true;
            this.btnToSettings.Click += new System.EventHandler(this.btnToSettings_Click);
            // 
            // FrmAddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 598);
            this.Controls.Add(this.btnToSettings);
            this.Controls.Add(this.txtNumClass);
            this.Controls.Add(this.lblNumClass);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.txtCodeClass);
            this.Controls.Add(this.txtNameGrade);
            this.Controls.Add(this.lblNameGrade);
            this.Controls.Add(this.lblCodeClass);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTatel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddClass";
            this.Text = "FrmAddClass";
            this.Load += new System.EventHandler(this.FrmAddClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTatel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCodeClass;
        private System.Windows.Forms.Label lblNameGrade;
        private System.Windows.Forms.TextBox txtNameGrade;
        private System.Windows.Forms.TextBox txtCodeClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtNumClass;
        private System.Windows.Forms.Label lblNumClass;
        private System.Windows.Forms.Button btnToSettings;
    }
}