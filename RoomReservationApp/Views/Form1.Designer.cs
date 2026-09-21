namespace RoomReservationApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            reservationsControl1 = new ReservationsControl();
            tabPage2 = new TabPage();
            roomsControl1 = new RoomsControl();
            tabPage3 = new TabPage();
            managementControl1 = new ManagementControl();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(8, 8);
            tabControl1.Margin = new Padding(3, 0, 3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(768, 445);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(reservationsControl1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(760, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Rezerwacje";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // reservationsControl1
            // 
            reservationsControl1.Dock = DockStyle.Fill;
            reservationsControl1.Location = new Point(3, 3);
            reservationsControl1.Name = "reservationsControl1";
            reservationsControl1.Padding = new Padding(16);
            reservationsControl1.Size = new Size(754, 411);
            reservationsControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(roomsControl1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sale";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // roomsControl1
            // 
            roomsControl1.Dock = DockStyle.Fill;
            roomsControl1.Location = new Point(3, 3);
            roomsControl1.Name = "roomsControl1";
            roomsControl1.Padding = new Padding(16);
            roomsControl1.Size = new Size(186, 66);
            roomsControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(managementControl1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(192, 72);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Administracja";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // managementControl1
            // 
            managementControl1.Dock = DockStyle.Fill;
            managementControl1.Location = new Point(0, 0);
            managementControl1.Name = "managementControl1";
            managementControl1.Padding = new Padding(16);
            managementControl1.Size = new Size(192, 72);
            managementControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(tabControl1);
            Name = "Form1";
            Padding = new Padding(8);
            Text = "Rezerwacja sal";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ReservationsControl reservationsControl1;
        private RoomsControl roomsControl1;
        private ManagementControl managementControl1;
    }
}
