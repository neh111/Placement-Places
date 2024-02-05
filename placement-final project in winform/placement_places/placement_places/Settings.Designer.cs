
namespace placement_places
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lbl_tatel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGrades = new System.Windows.Forms.ComboBox();
            this.lblNumCoulmns = new System.Windows.Forms.Label();
            this.lblNumRows = new System.Windows.Forms.Label();
            this.btnNoClass = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnToPlacement = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numericNumCoulmns = new System.Windows.Forms.NumericUpDown();
            this.numericNumLines = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumCoulmns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumLines)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tatel
            // 
            this.lbl_tatel.AutoSize = true;
            this.lbl_tatel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_tatel.Location = new System.Drawing.Point(624, 50);
            this.lbl_tatel.Name = "lbl_tatel";
            this.lbl_tatel.Size = new System.Drawing.Size(165, 36);
            this.lbl_tatel.TabIndex = 0;
            this.lbl_tatel.Text = "הגדרות כתה";
            this.lbl_tatel.Click += new System.EventHandler(this.lbl_tatel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(981, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "בחרי איזה כתה ברצונך לשבץ";
            // 
            // cmbGrades
            // 
            this.cmbGrades.FormattingEnabled = true;
            this.cmbGrades.Location = new System.Drawing.Point(1039, 190);
            this.cmbGrades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGrades.Name = "cmbGrades";
            this.cmbGrades.Size = new System.Drawing.Size(121, 24);
            this.cmbGrades.TabIndex = 2;
            // 
            // lblNumCoulmns
            // 
            this.lblNumCoulmns.AutoSize = true;
            this.lblNumCoulmns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNumCoulmns.Location = new System.Drawing.Point(627, 156);
            this.lblNumCoulmns.Name = "lblNumCoulmns";
            this.lblNumCoulmns.Size = new System.Drawing.Size(119, 25);
            this.lblNumCoulmns.TabIndex = 5;
            this.lblNumCoulmns.Text = ":מספר טורים";
            // 
            // lblNumRows
            // 
            this.lblNumRows.AutoSize = true;
            this.lblNumRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNumRows.Location = new System.Drawing.Point(625, 235);
            this.lblNumRows.Name = "lblNumRows";
            this.lblNumRows.Size = new System.Drawing.Size(120, 25);
            this.lblNumRows.TabIndex = 6;
            this.lblNumRows.Text = ":מספר שורות";
            // 
            // btnNoClass
            // 
            this.btnNoClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNoClass.Location = new System.Drawing.Point(1044, 235);
            this.btnNoClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNoClass.Name = "btnNoClass";
            this.btnNoClass.Size = new System.Drawing.Size(116, 78);
            this.btnNoClass.TabIndex = 9;
            this.btnNoClass.Text = "הכיתה לא קיימת במאגר";
            this.btnNoClass.UseVisualStyleBackColor = true;
            this.btnNoClass.Click += new System.EventHandler(this.btnNoClass_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOK.Location = new System.Drawing.Point(364, 175);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 46);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(25, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 481);
            this.panel1.TabIndex = 11;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnToPlacement
            // 
            this.btnToPlacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnToPlacement.Location = new System.Drawing.Point(83, 33);
            this.btnToPlacement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToPlacement.Name = "btnToPlacement";
            this.btnToPlacement.Size = new System.Drawing.Size(200, 54);
            this.btnToPlacement.TabIndex = 12;
            this.btnToPlacement.Text = "שמור הגדרות";
            this.btnToPlacement.UseVisualStyleBackColor = true;
            this.btnToPlacement.Click += new System.EventHandler(this.btnToPlacement_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(1131, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "חזרה לטופס קודם";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericNumCoulmns
            // 
            this.numericNumCoulmns.Location = new System.Drawing.Point(512, 159);
            this.numericNumCoulmns.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericNumCoulmns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumCoulmns.Name = "numericNumCoulmns";
            this.numericNumCoulmns.Size = new System.Drawing.Size(100, 22);
            this.numericNumCoulmns.TabIndex = 14;
            this.numericNumCoulmns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumCoulmns.ValueChanged += new System.EventHandler(this.numericNumCoulmns_ValueChanged);
            // 
            // numericNumLines
            // 
            this.numericNumLines.Location = new System.Drawing.Point(512, 235);
            this.numericNumLines.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericNumLines.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumLines.Name = "numericNumLines";
            this.numericNumLines.Size = new System.Drawing.Size(100, 22);
            this.numericNumLines.TabIndex = 15;
            this.numericNumLines.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 615);
            this.Controls.Add(this.numericNumLines);
            this.Controls.Add(this.numericNumCoulmns);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnToPlacement);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnNoClass);
            this.Controls.Add(this.lblNumRows);
            this.Controls.Add(this.lblNumCoulmns);
            this.Controls.Add(this.cmbGrades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_tatel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericNumCoulmns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tatel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGrades;
        private System.Windows.Forms.Label lblNumCoulmns;
        private System.Windows.Forms.Label lblNumRows;
        private System.Windows.Forms.Button btnNoClass;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnToPlacement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericNumCoulmns;
        private System.Windows.Forms.NumericUpDown numericNumLines;
    }
}