namespace FinalProject
{
    partial class FService
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.dtpDayBooking = new System.Windows.Forms.DateTimePicker();
            this.btnBook = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblService = new System.Windows.Forms.Label();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnCleaning = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblServiceBooking = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tTimeBooking = new DevExpress.XtraEditors.TimeEdit();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDayBooking = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnCart = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvInCart = new System.Windows.Forms.DataGridView();
            this.dtpDayBook = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTimeBooking.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInCart)).BeginInit();
            this.dtpDayBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 567);
            this.panel1.TabIndex = 0;
            // 
            // dtpDayBooking
            // 
            this.dtpDayBooking.Location = new System.Drawing.Point(121, 63);
            this.dtpDayBooking.Name = "dtpDayBooking";
            this.dtpDayBooking.Size = new System.Drawing.Size(256, 22);
            this.dtpDayBooking.TabIndex = 2;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.LightSalmon;
            this.btnBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBook.Location = new System.Drawing.Point(383, 63);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(102, 47);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "BOOK";
            this.btnBook.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblService);
            this.panel2.Controls.Add(this.btnVehicle);
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
            // btnVehicle
            // 
            this.btnVehicle.BackgroundImage = global::FinalProject.Properties.Resources.electric_scooter;
            this.btnVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVehicle.Location = new System.Drawing.Point(95, 33);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(40, 40);
            this.btnVehicle.TabIndex = 4;
            this.btnVehicle.UseVisualStyleBackColor = true;
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
            // tTimeBooking
            // 
            this.tTimeBooking.EditValue = new System.DateTime(2024, 3, 3, 0, 0, 0, 0);
            this.tTimeBooking.Location = new System.Drawing.Point(154, 91);
            this.tTimeBooking.Name = "tTimeBooking";
            this.tTimeBooking.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tTimeBooking.Size = new System.Drawing.Size(125, 24);
            this.tTimeBooking.TabIndex = 3;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lblServiceBooking);
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Controls.Add(this.tTimeBooking);
            this.panel3.Controls.Add(this.dtpDayBooking);
            this.panel3.Controls.Add(this.btnBook);
            this.panel3.Controls.Add(this.lblDayBooking);
            this.panel3.Location = new System.Drawing.Point(263, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(695, 126);
            this.panel3.TabIndex = 3;
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
            // dtpDayBook
            // 
            this.dtpDayBook.Controls.Add(this.btnCart);
            this.dtpDayBook.Controls.Add(this.flowLayoutPanel2);
            this.dtpDayBook.Controls.Add(this.dgvInCart);
            this.dtpDayBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpDayBook.Location = new System.Drawing.Point(200, 132);
            this.dtpDayBook.Name = "dtpDayBook";
            this.dtpDayBook.Size = new System.Drawing.Size(797, 435);
            this.dtpDayBook.TabIndex = 2;
            // 
            // FService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(997, 567);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dtpDayBook);
            this.Controls.Add(this.panel1);
            this.Name = "FService";
            this.Text = "FormService";
            this.Load += new System.EventHandler(this.FService_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTimeBooking.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInCart)).EndInit();
            this.dtpDayBook.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DateTimePicker dtpDayBooking;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnCleaning;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblServiceBooking;
        private System.Windows.Forms.Label lblTime;
        private DevExpress.XtraEditors.TimeEdit tTimeBooking;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDayBooking;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvInCart;
        private System.Windows.Forms.Panel dtpDayBook;
    }
}

