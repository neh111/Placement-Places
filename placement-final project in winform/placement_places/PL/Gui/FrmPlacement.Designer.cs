
namespace placement_places.Gui
{
    partial class FrmPlacement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlacement));
            this.lblTatel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSavePlacement = new System.Windows.Forms.Button();
            this.cmbClasses = new System.Windows.Forms.ComboBox();
            this.lblChooseClass = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstStudentsToPLace = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTatel
            // 
            this.lblTatel.AutoSize = true;
            this.lblTatel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTatel.Location = new System.Drawing.Point(490, 48);
            this.lblTatel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTatel.Name = "lblTatel";
            this.lblTatel.Size = new System.Drawing.Size(149, 26);
            this.lblTatel.TabIndex = 0;
            this.lblTatel.Text = "שיבוץ מקומות";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(11, 182);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 342);
            this.panel1.TabIndex = 1;
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSavePlacement
            // 
            this.btnSavePlacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSavePlacement.Location = new System.Drawing.Point(747, 106);
            this.btnSavePlacement.Name = "btnSavePlacement";
            this.btnSavePlacement.Size = new System.Drawing.Size(75, 56);
            this.btnSavePlacement.TabIndex = 2;
            this.btnSavePlacement.Text = "שמור שיבוץ";
            this.btnSavePlacement.UseVisualStyleBackColor = true;
            this.btnSavePlacement.Click += new System.EventHandler(this.btnSavePlacement_Click);
            // 
            // cmbClasses
            // 
            this.cmbClasses.FormattingEnabled = true;
            this.cmbClasses.Location = new System.Drawing.Point(857, 106);
            this.cmbClasses.Name = "cmbClasses";
            this.cmbClasses.Size = new System.Drawing.Size(86, 21);
            this.cmbClasses.TabIndex = 3;
            this.cmbClasses.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblChooseClass
            // 
            this.lblChooseClass.AutoSize = true;
            this.lblChooseClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblChooseClass.Location = new System.Drawing.Point(867, 87);
            this.lblChooseClass.Name = "lblChooseClass";
            this.lblChooseClass.Size = new System.Drawing.Size(65, 16);
            this.lblChooseClass.TabIndex = 4;
            this.lblChooseClass.Text = "בחר כתה";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHelp);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.cmbStudents);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(118, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(286, 140);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "עזרה בשיבוץ";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(34, 77);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(56, 39);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "עזרה";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "מורה יקרה!",
            "לחצי על לחצן עזרה,",
            "ובחרי תלמידה שברצונך לשבץ ",
            "מתוך התיבה המשולבת.",
            "שימי לב שיופיעו סימונים",
            "על השולחנות המתאימים לשיבוץ."});
            this.listBox1.Location = new System.Drawing.Point(120, 35);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(149, 82);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cmbStudents
            // 
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(13, 39);
            this.cmbStudents.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(92, 25);
            this.cmbStudents.TabIndex = 0;
            this.cmbStudents.SelectedIndexChanged += new System.EventHandler(this.cmbStudents_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBack.Location = new System.Drawing.Point(922, 13);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 61);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "חזרה לטופס קודם";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstStudentsToPLace
            // 
            this.lstStudentsToPLace.FormattingEnabled = true;
            this.lstStudentsToPLace.Location = new System.Drawing.Point(857, 208);
            this.lstStudentsToPLace.Margin = new System.Windows.Forms.Padding(2);
            this.lstStudentsToPLace.Name = "lstStudentsToPLace";
            this.lstStudentsToPLace.Size = new System.Drawing.Size(161, 316);
            this.lstStudentsToPLace.TabIndex = 7;
            this.lstStudentsToPLace.SelectedIndexChanged += new System.EventHandler(this.lstStudentsToPLace_SelectedIndexChanged);
            this.lstStudentsToPLace.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstStudentsToPLace_DragEnter);
            this.lstStudentsToPLace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstStudentsToPLace_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(866, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "התלמידות שיש לשבץ";
            // 
            // FrmPlacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 534);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstStudentsToPLace);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblChooseClass);
            this.Controls.Add(this.cmbClasses);
            this.Controls.Add(this.btnSavePlacement);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTatel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPlacement";
            this.Text = "FrmPlacement";
            this.Load += new System.EventHandler(this.FrmPlacement_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FrmPlacement_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTatel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSavePlacement;
        private System.Windows.Forms.ComboBox cmbClasses;
        private System.Windows.Forms.Label lblChooseClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstStudentsToPLace;
        private System.Windows.Forms.Label label1;
    }
}