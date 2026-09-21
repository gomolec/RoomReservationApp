namespace RoomReservationApp
{
    public partial class ManagementControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            txtDeptCity = new TextBox();
            label5 = new Label();
            txtDeptZipCode = new TextBox();
            btnAddDepartment = new Button();
            txtDeptStreetAndNumber = new TextBox();
            labeltxt2 = new Label();
            txtDeptName = new TextBox();
            label3 = new Label();
            dgvDepartments = new DataGridView();
            groupBox1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            txtTeacherLastName = new TextBox();
            label2 = new Label();
            txtTeacherFirstName = new TextBox();
            label1 = new Label();
            btnAddTeacher = new Button();
            dgvTeachers = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel4);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(362, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(353, 412);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Wydziały";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel4.Controls.Add(dgvDepartments, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 19);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.Size = new Size(347, 390);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel1, 0, 2);
            tableLayoutPanel6.Controls.Add(btnAddDepartment, 0, 5);
            tableLayoutPanel6.Controls.Add(txtDeptStreetAndNumber, 0, 4);
            tableLayoutPanel6.Controls.Add(labeltxt2, 0, 3);
            tableLayoutPanel6.Controls.Add(txtDeptName, 0, 1);
            tableLayoutPanel6.Controls.Add(label3, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 159);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 6;
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(341, 228);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(txtDeptCity, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 1, 0);
            tableLayoutPanel1.Controls.Add(txtDeptZipCode, 1, 1);
            tableLayoutPanel1.Location = new Point(3, 55);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(335, 52);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Miasto";
            // 
            // txtDeptCity
            // 
            txtDeptCity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDeptCity.Location = new Point(3, 18);
            txtDeptCity.Margin = new Padding(3, 3, 3, 11);
            txtDeptCity.Name = "txtDeptCity";
            txtDeptCity.Size = new Size(161, 23);
            txtDeptCity.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(170, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 5;
            label5.Text = "Kod pocztowy";
            // 
            // txtDeptZipCode
            // 
            txtDeptZipCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDeptZipCode.Location = new Point(170, 18);
            txtDeptZipCode.Margin = new Padding(3, 3, 3, 11);
            txtDeptZipCode.Name = "txtDeptZipCode";
            txtDeptZipCode.Size = new Size(162, 23);
            txtDeptZipCode.TabIndex = 6;
            // 
            // btnAddDepartment
            // 
            btnAddDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAddDepartment.AutoSize = true;
            btnAddDepartment.Location = new Point(3, 165);
            btnAddDepartment.Name = "btnAddDepartment";
            btnAddDepartment.Size = new Size(335, 25);
            btnAddDepartment.TabIndex = 7;
            btnAddDepartment.Text = "Dodaj wydział";
            btnAddDepartment.UseVisualStyleBackColor = true;
            btnAddDepartment.Click += btnAddDepartment_Click;
            // 
            // txtDeptStreetAndNumber
            // 
            txtDeptStreetAndNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDeptStreetAndNumber.Location = new Point(3, 128);
            txtDeptStreetAndNumber.Margin = new Padding(3, 3, 3, 11);
            txtDeptStreetAndNumber.Name = "txtDeptStreetAndNumber";
            txtDeptStreetAndNumber.Size = new Size(335, 23);
            txtDeptStreetAndNumber.TabIndex = 6;
            // 
            // labeltxt2
            // 
            labeltxt2.AutoSize = true;
            labeltxt2.Location = new Point(3, 110);
            labeltxt2.Name = "labeltxt2";
            labeltxt2.Size = new Size(77, 15);
            labeltxt2.TabIndex = 5;
            labeltxt2.Text = "Ulica i numer";
            // 
            // txtDeptName
            // 
            txtDeptName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDeptName.Location = new Point(3, 18);
            txtDeptName.Margin = new Padding(3, 3, 3, 11);
            txtDeptName.Name = "txtDeptName";
            txtDeptName.Size = new Size(335, 23);
            txtDeptName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 0;
            label3.Text = "Nazwa wydziału";
            // 
            // dgvDepartments
            // 
            dgvDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartments.Dock = DockStyle.Fill;
            dgvDepartments.Location = new Point(3, 3);
            dgvDepartments.Name = "dgvDepartments";
            dgvDepartments.Size = new Size(341, 150);
            dgvDepartments.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 412);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prowadzący";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Controls.Add(dgvTeachers, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.Size = new Size(347, 390);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(txtTeacherLastName, 0, 3);
            tableLayoutPanel5.Controls.Add(label2, 0, 2);
            tableLayoutPanel5.Controls.Add(txtTeacherFirstName, 0, 1);
            tableLayoutPanel5.Controls.Add(label1, 0, 0);
            tableLayoutPanel5.Controls.Add(btnAddTeacher, 0, 4);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 159);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 5;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(341, 228);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // txtTeacherLastName
            // 
            txtTeacherLastName.Anchor = AnchorStyles.None;
            txtTeacherLastName.Location = new Point(3, 70);
            txtTeacherLastName.Margin = new Padding(3, 3, 3, 11);
            txtTeacherLastName.Name = "txtTeacherLastName";
            txtTeacherLastName.Size = new Size(335, 23);
            txtTeacherLastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 52);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 2;
            label2.Text = "Nazwisko prowadzącego";
            // 
            // txtTeacherFirstName
            // 
            txtTeacherFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTeacherFirstName.Location = new Point(3, 18);
            txtTeacherFirstName.Margin = new Padding(3, 3, 3, 11);
            txtTeacherFirstName.Name = "txtTeacherFirstName";
            txtTeacherFirstName.Size = new Size(335, 23);
            txtTeacherFirstName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Imię prowadzącego";
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAddTeacher.Location = new Point(3, 107);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(335, 23);
            btnAddTeacher.TabIndex = 4;
            btnAddTeacher.Text = "Dodaj prowadzącego";
            btnAddTeacher.UseVisualStyleBackColor = true;
            btnAddTeacher.Click += btnAddTeacher_Click;
            // 
            // dgvTeachers
            // 
            dgvTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeachers.Dock = DockStyle.Fill;
            dgvTeachers.Location = new Point(3, 3);
            dgvTeachers.Name = "dgvTeachers";
            dgvTeachers.Size = new Size(341, 150);
            dgvTeachers.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(16, 16);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(718, 418);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // ManagementControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "ManagementControl";
            Padding = new Padding(16);
            Size = new Size(750, 450);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtTeacherFirstName;
        private Label label2;
        private TextBox txtTeacherLastName;
        private Label label3;
        private TextBox txtDeptName;
        private Label labeltxt2;
        private TextBox txtDeptStreetAndNumber;
        private Button btnAddDepartment;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnAddTeacher;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private TextBox txtDeptCity;
        private Label label5;
        private TextBox txtDeptZipCode;
        private DataGridView dgvDepartments;
        private DataGridView dgvTeachers;
    }
}
