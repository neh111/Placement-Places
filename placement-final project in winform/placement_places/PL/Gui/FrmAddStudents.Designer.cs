
namespace placement_places.Gui
{
    partial class FrmAddStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddStudents));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_coulmnPlacement = new System.Windows.Forms.Label();
            this.lbl_rowPlacement = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_idStudent = new System.Windows.Forms.TextBox();
            this.txt_placementRow = new System.Windows.Forms.TextBox();
            this.txt_placementCoulmn = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeric_talkingDegree = new System.Windows.Forms.NumericUpDown();
            this.numeric_recommendedRow = new System.Windows.Forms.NumericUpDown();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.cmb_className = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_talkingDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_recommendedRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(652, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "תלמידות";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(1155, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "מזהה תלמידה";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(1153, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "דרגת פטפוט";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(1216, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "כתה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(1169, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "שם משפחה";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(1195, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "שם פרטי";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(1135, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "שורה מומלצת";
            // 
            // lbl_coulmnPlacement
            // 
            this.lbl_coulmnPlacement.AutoSize = true;
            this.lbl_coulmnPlacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_coulmnPlacement.Location = new System.Drawing.Point(1163, 458);
            this.lbl_coulmnPlacement.Name = "lbl_coulmnPlacement";
            this.lbl_coulmnPlacement.Size = new System.Drawing.Size(130, 29);
            this.lbl_coulmnPlacement.TabIndex = 7;
            this.lbl_coulmnPlacement.Text = "טור השיבוץ";
            // 
            // lbl_rowPlacement
            // 
            this.lbl_rowPlacement.AutoSize = true;
            this.lbl_rowPlacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_rowPlacement.Location = new System.Drawing.Point(1153, 512);
            this.lbl_rowPlacement.Name = "lbl_rowPlacement";
            this.lbl_rowPlacement.Size = new System.Drawing.Size(140, 29);
            this.lbl_rowPlacement.TabIndex = 8;
            this.lbl_rowPlacement.Text = "שורת השבוץ";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(1017, 251);
            this.txt_lastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(100, 22);
            this.txt_lastName.TabIndex = 11;
            this.txt_lastName.TextChanged += new System.EventHandler(this.txt_lastName_TextChanged);
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(1017, 199);
            this.txt_firstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(100, 22);
            this.txt_firstName.TabIndex = 12;
            this.txt_firstName.TextChanged += new System.EventHandler(this.txt_firstName_TextChanged);
            // 
            // txt_idStudent
            // 
            this.txt_idStudent.AcceptsTab = true;
            this.txt_idStudent.Location = new System.Drawing.Point(1017, 144);
            this.txt_idStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_idStudent.Name = "txt_idStudent";
            this.txt_idStudent.Size = new System.Drawing.Size(100, 22);
            this.txt_idStudent.TabIndex = 13;
            this.txt_idStudent.TextChanged += new System.EventHandler(this.txt_idStudent_TextChanged);
            // 
            // txt_placementRow
            // 
            this.txt_placementRow.Location = new System.Drawing.Point(1015, 512);
            this.txt_placementRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_placementRow.Name = "txt_placementRow";
            this.txt_placementRow.Size = new System.Drawing.Size(100, 22);
            this.txt_placementRow.TabIndex = 14;
            // 
            // txt_placementCoulmn
            // 
            this.txt_placementCoulmn.Location = new System.Drawing.Point(1015, 458);
            this.txt_placementCoulmn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_placementCoulmn.Name = "txt_placementCoulmn";
            this.txt_placementCoulmn.Size = new System.Drawing.Size(100, 22);
            this.txt_placementCoulmn.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(256, 144);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(451, 313);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numeric_talkingDegree
            // 
            this.numeric_talkingDegree.Location = new System.Drawing.Point(1015, 345);
            this.numeric_talkingDegree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeric_talkingDegree.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numeric_talkingDegree.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_talkingDegree.Name = "numeric_talkingDegree";
            this.numeric_talkingDegree.Size = new System.Drawing.Size(64, 22);
            this.numeric_talkingDegree.TabIndex = 18;
            this.numeric_talkingDegree.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numeric_recommendedRow
            // 
            this.numeric_recommendedRow.Location = new System.Drawing.Point(1015, 400);
            this.numeric_recommendedRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeric_recommendedRow.Name = "numeric_recommendedRow";
            this.numeric_recommendedRow.Size = new System.Drawing.Size(64, 22);
            this.numeric_recommendedRow.TabIndex = 20;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_save.Location = new System.Drawing.Point(383, 496);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 63);
            this.btn_save.TabIndex = 25;
            this.btn_save.Text = "שמור";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_new.Location = new System.Drawing.Point(491, 496);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(100, 63);
            this.btn_new.TabIndex = 26;
            this.btn_new.Text = "הוספת תלמידה";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // cmb_className
            // 
            this.cmb_className.FormattingEnabled = true;
            this.cmb_className.Location = new System.Drawing.Point(1015, 300);
            this.cmb_className.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_className.Name = "cmb_className";
            this.cmb_className.Size = new System.Drawing.Size(100, 24);
            this.cmb_className.TabIndex = 28;
            this.cmb_className.SelectedIndexChanged += new System.EventHandler(this.cmb_className_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(865, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 29);
            this.label8.TabIndex = 29;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBack.Location = new System.Drawing.Point(1140, 36);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(160, 55);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "חזרה לטופס קודם";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmAddStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 786);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_className);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.numeric_recommendedRow);
            this.Controls.Add(this.numeric_talkingDegree);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_placementCoulmn);
            this.Controls.Add(this.txt_placementRow);
            this.Controls.Add(this.txt_idStudent);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.lbl_rowPlacement);
            this.Controls.Add(this.lbl_coulmnPlacement);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAddStudents";
            this.Text = "FrmAddStudents";
            this.Load += new System.EventHandler(this.FrmAddStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_talkingDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_recommendedRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_coulmnPlacement;
        private System.Windows.Forms.Label lbl_rowPlacement;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_idStudent;
        private System.Windows.Forms.TextBox txt_placementRow;
        private System.Windows.Forms.TextBox txt_placementCoulmn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numeric_talkingDegree;
        private System.Windows.Forms.NumericUpDown numeric_recommendedRow;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.ComboBox cmb_className;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBack;
    }
}