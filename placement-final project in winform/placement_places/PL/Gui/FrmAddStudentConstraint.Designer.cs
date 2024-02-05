
namespace placement_places.Gui
{
    partial class FrmAddStudentConstraint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddStudentConstraint));
            this.lblTatel = new System.Windows.Forms.Label();
            this.lblChooseStudent = new System.Windows.Forms.Label();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.lblChooseConstraint = new System.Windows.Forms.Label();
            this.cmbConstraint = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTatel
            // 
            this.lblTatel.AutoSize = true;
            this.lblTatel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTatel.Location = new System.Drawing.Point(583, 44);
            this.lblTatel.Name = "lblTatel";
            this.lblTatel.Size = new System.Drawing.Size(284, 32);
            this.lblTatel.TabIndex = 0;
            this.lblTatel.Text = "עדכון אילוץ לתלמידה";
            // 
            // lblChooseStudent
            // 
            this.lblChooseStudent.AutoSize = true;
            this.lblChooseStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblChooseStudent.Location = new System.Drawing.Point(843, 161);
            this.lblChooseStudent.Name = "lblChooseStudent";
            this.lblChooseStudent.Size = new System.Drawing.Size(124, 25);
            this.lblChooseStudent.TabIndex = 1;
            this.lblChooseStudent.Text = "בחרי תלמידה";
            // 
            // cmbStudents
            // 
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(848, 225);
            this.cmbStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(121, 24);
            this.cmbStudents.TabIndex = 2;
            this.cmbStudents.SelectedIndexChanged += new System.EventHandler(this.cmbStudents_SelectedIndexChanged);
            // 
            // lblChooseConstraint
            // 
            this.lblChooseConstraint.AutoSize = true;
            this.lblChooseConstraint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblChooseConstraint.Location = new System.Drawing.Point(601, 161);
            this.lblChooseConstraint.Name = "lblChooseConstraint";
            this.lblChooseConstraint.Size = new System.Drawing.Size(115, 24);
            this.lblChooseConstraint.TabIndex = 3;
            this.lblChooseConstraint.Text = "בחר אילוצים";
            this.lblChooseConstraint.Click += new System.EventHandler(this.lblChooseConstraint_Click);
            // 
            // cmbConstraint
            // 
            this.cmbConstraint.FormattingEnabled = true;
            this.cmbConstraint.Location = new System.Drawing.Point(605, 225);
            this.cmbConstraint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbConstraint.Name = "cmbConstraint";
            this.cmbConstraint.Size = new System.Drawing.Size(121, 24);
            this.cmbConstraint.TabIndex = 4;
            this.cmbConstraint.SelectedIndexChanged += new System.EventHandler(this.cmbConstraint_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(1181, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 75);
            this.button1.TabIndex = 5;
            this.button1.Text = "חזרה לטופס קודם";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAddStudentConstraint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbConstraint);
            this.Controls.Add(this.lblChooseConstraint);
            this.Controls.Add(this.cmbStudents);
            this.Controls.Add(this.lblChooseStudent);
            this.Controls.Add(this.lblTatel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAddStudentConstraint";
            this.Text = "FrmAddStudentConstraint";
            this.Load += new System.EventHandler(this.FrmAddStudentConstraint_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTatel;
        private System.Windows.Forms.Label lblChooseStudent;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.Label lblChooseConstraint;
        private System.Windows.Forms.ComboBox cmbConstraint;
        private System.Windows.Forms.Button button1;
    }
}