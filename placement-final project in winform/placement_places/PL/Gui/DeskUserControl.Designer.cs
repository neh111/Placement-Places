
namespace placement_places.Gui
{
    partial class DeskUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbStudentA = new System.Windows.Forms.ComboBox();
            this.cmbStudentB = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCheckAdjustment = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblSuitable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStudentA
            // 
            this.cmbStudentA.AllowDrop = true;
            this.cmbStudentA.FormattingEnabled = true;
            this.cmbStudentA.Location = new System.Drawing.Point(0, 3);
            this.cmbStudentA.Name = "cmbStudentA";
            this.cmbStudentA.Size = new System.Drawing.Size(101, 24);
            this.cmbStudentA.TabIndex = 0;
            this.cmbStudentA.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbStudentA.DragDrop += new System.Windows.Forms.DragEventHandler(this.cmbStudentA_DragDrop);
            this.cmbStudentA.DragEnter += new System.Windows.Forms.DragEventHandler(this.cmbStudentA_DragEnter);
            // 
            // cmbStudentB
            // 
            this.cmbStudentB.AllowDrop = true;
            this.cmbStudentB.FormattingEnabled = true;
            this.cmbStudentB.Location = new System.Drawing.Point(140, 3);
            this.cmbStudentB.Name = "cmbStudentB";
            this.cmbStudentB.Size = new System.Drawing.Size(102, 24);
            this.cmbStudentB.TabIndex = 1;
            this.cmbStudentB.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.cmbStudentB.DragDrop += new System.Windows.Forms.DragEventHandler(this.cmbStudentB_DragDrop);
            this.cmbStudentB.DragEnter += new System.Windows.Forms.DragEventHandler(this.cmbStudentB_DragEnter);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCheckAdjustment
            // 
            this.btnCheckAdjustment.BackColor = System.Drawing.Color.Cornsilk;
            this.btnCheckAdjustment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCheckAdjustment.Location = new System.Drawing.Point(20, 33);
            this.btnCheckAdjustment.Name = "btnCheckAdjustment";
            this.btnCheckAdjustment.Size = new System.Drawing.Size(195, 37);
            this.btnCheckAdjustment.TabIndex = 2;
            this.btnCheckAdjustment.Text = "בדוק התאמה";
            this.btnCheckAdjustment.UseVisualStyleBackColor = false;
            this.btnCheckAdjustment.Click += new System.EventHandler(this.btnCheckAdjustment_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // lblSuitable
            // 
            this.lblSuitable.AutoSize = true;
            this.lblSuitable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSuitable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSuitable.ForeColor = System.Drawing.Color.Purple;
            this.lblSuitable.Location = new System.Drawing.Point(107, 5);
            this.lblSuitable.Name = "lblSuitable";
            this.lblSuitable.Size = new System.Drawing.Size(27, 25);
            this.lblSuitable.TabIndex = 3;
            this.lblSuitable.Text = "V";
            // 
            // DeskUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.Controls.Add(this.lblSuitable);
            this.Controls.Add(this.btnCheckAdjustment);
            this.Controls.Add(this.cmbStudentB);
            this.Controls.Add(this.cmbStudentA);
            this.Name = "DeskUserControl";
            this.Size = new System.Drawing.Size(246, 73);
            this.Load += new System.EventHandler(this.DeskUserControl_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DeskUserControl_DragEnter);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.DeskUserControl_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStudentA;
        private System.Windows.Forms.ComboBox cmbStudentB;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCheckAdjustment;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label lblSuitable;
    }
}
