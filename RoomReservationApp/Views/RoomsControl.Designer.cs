namespace RoomReservationApp
{
    public partial class RoomsControl
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
            txtRoomName = new TextBox();
            label2 = new Label();
            numCapacity = new NumericUpDown();
            label5 = new Label();
            cmbRoomType = new ComboBox();
            label6 = new Label();
            cmbDepartmentSelect = new ComboBox();
            btnAddRoom = new Button();
            dgvRooms = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(dgvRooms, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(16, 16);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(718, 418);
            tableLayoutPanel1.TabIndex = 1;
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
            groupBox1.Text = "Dodaj nową salę";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txtRoomName);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(numCapacity);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(cmbRoomType);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(cmbDepartmentSelect);
            flowLayoutPanel1.Controls.Add(btnAddRoom);
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
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Numer/Nazwa sali";
            // 
            // txtRoomName
            // 
            txtRoomName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRoomName.Location = new Point(3, 18);
            txtRoomName.Margin = new Padding(3, 3, 3, 8);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(200, 23);
            txtRoomName.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 49);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "Pojemność";
            // 
            // numCapacity
            // 
            numCapacity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numCapacity.Location = new Point(3, 67);
            numCapacity.Margin = new Padding(3, 3, 3, 8);
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(200, 23);
            numCapacity.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 98);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 11;
            label5.Text = "Rodzaj sali";
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(3, 116);
            cmbRoomType.Margin = new Padding(3, 3, 3, 11);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(200, 23);
            cmbRoomType.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 150);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 12;
            label6.Text = "Wydział";
            // 
            // cmbDepartmentSelect
            // 
            cmbDepartmentSelect.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbDepartmentSelect.FormattingEnabled = true;
            cmbDepartmentSelect.Location = new Point(3, 168);
            cmbDepartmentSelect.Margin = new Padding(3, 3, 3, 11);
            cmbDepartmentSelect.Name = "cmbDepartmentSelect";
            cmbDepartmentSelect.Size = new Size(200, 23);
            cmbDepartmentSelect.TabIndex = 13;
            // 
            // btnAddRoom
            // 
            btnAddRoom.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAddRoom.Location = new Point(3, 221);
            btnAddRoom.Margin = new Padding(3, 19, 3, 3);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(200, 23);
            btnAddRoom.TabIndex = 8;
            btnAddRoom.Text = "Dodaj salę";
            btnAddRoom.UseVisualStyleBackColor = true;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // dgvRooms
            // 
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Dock = DockStyle.Fill;
            dgvRooms.Location = new Point(3, 3);
            dgvRooms.Margin = new Padding(3, 3, 11, 3);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.Size = new Size(488, 412);
            dgvRooms.TabIndex = 0;
            dgvRooms.CellFormatting += dgvRooms_CellFormatting;
            // 
            // RoomsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "RoomsControl";
            Padding = new Padding(16);
            Size = new Size(750, 450);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox txtRoomName;
        private Label label2;
        private NumericUpDown numCapacity;
        private Label label5;
        private ComboBox cmbRoomType;
        private Label label6;
        private ComboBox cmbDepartmentSelect;
        private Button btnAddRoom;
        private DataGridView dgvRooms;
    }
}
