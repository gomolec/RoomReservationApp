namespace RoomReservationApp
{
    public partial class ReservationsControl
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
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            cmbRoomSelect = new ComboBox();
            label2 = new Label();
            cmbTeacherSelect = new ComboBox();
            label3 = new Label();
            dtpStart = new DateTimePicker();
            label4 = new Label();
            dtpEnd = new DateTimePicker();
            btnAddReservation = new Button();
            dgvReservations = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(dgvReservations, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(16, 16);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(718, 418);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(505, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 6, 3, 3);
            groupBox1.Size = new Size(210, 412);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodaj nową rezerwację";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(cmbRoomSelect);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(cmbTeacherSelect);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(dtpStart);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(dtpEnd);
            flowLayoutPanel1.Controls.Add(btnAddReservation);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 22);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(204, 387);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Wybierz salę";
            // 
            // cmbRoomSelect
            // 
            cmbRoomSelect.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbRoomSelect.FormattingEnabled = true;
            cmbRoomSelect.Location = new Point(3, 18);
            cmbRoomSelect.Margin = new Padding(3, 3, 3, 11);
            cmbRoomSelect.Name = "cmbRoomSelect";
            cmbRoomSelect.Size = new Size(200, 23);
            cmbRoomSelect.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 52);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 2;
            label2.Text = "Wybierz prowadzącego";
            // 
            // cmbTeacherSelect
            // 
            cmbTeacherSelect.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbTeacherSelect.FormattingEnabled = true;
            cmbTeacherSelect.Location = new Point(3, 70);
            cmbTeacherSelect.Margin = new Padding(3, 3, 3, 11);
            cmbTeacherSelect.Name = "cmbTeacherSelect";
            cmbTeacherSelect.Size = new Size(200, 23);
            cmbTeacherSelect.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 104);
            label3.Name = "label3";
            label3.Size = new Size(134, 15);
            label3.TabIndex = 4;
            label3.Text = "Data i godz. rozpoczęcia";
            // 
            // dtpStart
            // 
            dtpStart.CustomFormat = "dd-MM-yyy HH:mm";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.Location = new Point(3, 122);
            dtpStart.Margin = new Padding(3, 3, 3, 11);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(200, 23);
            dtpStart.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 156);
            label4.Name = "label4";
            label4.Size = new Size(136, 15);
            label4.TabIndex = 6;
            label4.Text = "Data i godz. zakończenia";
            // 
            // dtpEnd
            // 
            dtpEnd.CustomFormat = "dd-MM-yyy HH:mm";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.Location = new Point(3, 174);
            dtpEnd.Margin = new Padding(3, 3, 3, 11);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(200, 23);
            dtpEnd.TabIndex = 7;
            // 
            // btnAddReservation
            // 
            btnAddReservation.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAddReservation.Location = new Point(3, 227);
            btnAddReservation.Margin = new Padding(3, 19, 3, 3);
            btnAddReservation.Name = "btnAddReservation";
            btnAddReservation.Size = new Size(200, 23);
            btnAddReservation.TabIndex = 8;
            btnAddReservation.Text = "Dodaj rezerwację";
            btnAddReservation.UseVisualStyleBackColor = true;
            btnAddReservation.Click += btnAddReservation_Click;
            // 
            // dgvReservations
            // 
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Dock = DockStyle.Fill;
            dgvReservations.Location = new Point(3, 3);
            dgvReservations.Margin = new Padding(3, 3, 11, 3);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.Size = new Size(488, 412);
            dgvReservations.TabIndex = 0;
            // 
            // ReservationsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ReservationsControl";
            Padding = new Padding(16);
            Size = new Size(750, 450);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvReservations;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private ComboBox cmbRoomSelect;
        private Label label2;
        private ComboBox cmbTeacherSelect;
        private Label label3;
        private DateTimePicker dtpStart;
        private Label label4;
        private DateTimePicker dtpEnd;
        private Button btnAddReservation;
    }
}
