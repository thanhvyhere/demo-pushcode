namespace FinalProject
{
    partial class UC_Service
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
            this.dtpDayBook = new System.Windows.Forms.Panel();
            this.btnCart = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblService = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCleaning = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dgvInCart = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblServiceBooking = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDayBooking = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.dtpDayBook.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInCart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDayBook
            // 
            this.dtpDayBook.Controls.Add(this.btnCart);
            this.dtpDayBook.Controls.Add(this.flowLayoutPanel2);
            this.dtpDayBook.Controls.Add(this.dgvInCart);
            this.dtpDayBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpDayBook.Location = new System.Drawing.Point(0, 135);
            this.dtpDayBook.Name = "dtpDayBook";
            this.dtpDayBook.Size = new System.Drawing.Size(804, 435);
            this.dtpDayBook.TabIndex = 0;
            // 
            // btnCart
            // 
            this.btnCart.BackgroundImage = global::FinalProject.Properties.Resources.shopping_cart;
            this.btnCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCart.Location = new System.Drawing.Point(736, 3);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(40, 40);
            this.btnCart.TabIndex = 5;
            this.btnCart.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.dgvService);
            this.flowLayoutPanel2.Controls.Add(this.dataGridView3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(400, 435);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblService);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btnCleaning);
            this.panel2.Controls.Add(this.btnFood);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 74);
            this.panel2.TabIndex = 0;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(29, 9);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(76, 19);
            this.lblService.TabIndex = 5;
            this.lblService.Text = "SERVICE";
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::FinalProject.Properties.Resources.electric_scooter;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(95, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnCleaning
            // 
            this.btnCleaning.BackgroundImage = global::FinalProject.Properties.Resources.cleaning;
            this.btnCleaning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCleaning.Location = new System.Drawing.Point(49, 31);
            this.btnCleaning.Name = "btnCleaning";
            this.btnCleaning.Size = new System.Drawing.Size(40, 40);
            this.btnCleaning.TabIndex = 3;
            this.btnCleaning.UseVisualStyleBackColor = true;
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.SystemColors.Control;
            this.btnFood.BackgroundImage = global::FinalProject.Properties.Resources.dish;
            this.btnFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFood.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.Location = new System.Drawing.Point(3, 31);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(40, 40);
            this.btnFood.TabIndex = 2;
            this.btnFood.UseVisualStyleBackColor = false;
            // 
            // dgvService
            // 
            this.dgvService.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Location = new System.Drawing.Point(3, 83);
            this.dgvService.Name = "dgvService";
            this.dgvService.RowHeadersWidth = 51;
            this.dgvService.RowTemplate.Height = 24;
            this.dgvService.Size = new System.Drawing.Size(397, 349);
            this.dgvService.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 438);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(8, 8);
            this.dataGridView3.TabIndex = 3;
            // 
            // dgvInCart
            // 
            this.dgvInCart.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInCart.Location = new System.Drawing.Point(406, 49);
            this.dgvInCart.Name = "dgvInCart";
            this.dgvInCart.RowHeadersWidth = 51;
            this.dgvInCart.RowTemplate.Height = 24;
            this.dgvInCart.Size = new System.Drawing.Size(395, 383);
            this.dgvInCart.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblServiceBooking);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.timeEdit1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblDayBooking);
            this.panel1.Location = new System.Drawing.Point(52, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 126);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(507, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 103);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblServiceBooking
            // 
            this.lblServiceBooking.AutoSize = true;
            this.lblServiceBooking.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceBooking.Location = new System.Drawing.Point(215, 9);
            this.lblServiceBooking.Name = "lblServiceBooking";
            this.lblServiceBooking.Size = new System.Drawing.Size(192, 27);
            this.lblServiceBooking.TabIndex = 5;
            this.lblServiceBooking.Text = "Service Booking";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(71, 95);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 17);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time:";
            // 
            // timeEdit1
            // 
            this.timeEdit1.EditValue = new System.DateTime(2024, 3, 3, 0, 0, 0, 0);
            this.timeEdit1.Location = new System.Drawing.Point(154, 91);
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit1.Size = new System.Drawing.Size(125, 24);
            this.timeEdit1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(383, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "BOOK";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblDayBooking
            // 
            this.lblDayBooking.AutoSize = true;
            this.lblDayBooking.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayBooking.Location = new System.Drawing.Point(22, 63);
            this.lblDayBooking.Name = "lblDayBooking";
            this.lblDayBooking.Size = new System.Drawing.Size(93, 17);
            this.lblDayBooking.TabIndex = 0;
            this.lblDayBooking.Text = "DayBooking: ";
            // 
            // UC_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpDayBook);
            this.Name = "UC_Service";
            this.Size = new System.Drawing.Size(804, 570);
            this.dtpDayBook.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInCart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dtpDayBook;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCleaning;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dgvInCart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDayBooking;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label lblTime;
        private DevExpress.XtraEditors.TimeEdit timeEdit1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblServiceBooking;
    }
}
