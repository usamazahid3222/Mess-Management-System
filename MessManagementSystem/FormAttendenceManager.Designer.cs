namespace MessManagementSystem
{
    partial class FormAttendenceManager
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
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSignout = new System.Windows.Forms.Button();
            this.dataGridViewBreakFast = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStudentEnter = new System.Windows.Forms.Button();
            this.rdBtnB = new System.Windows.Forms.RadioButton();
            this.rdBtnD = new System.Windows.Forms.RadioButton();
            this.rdBtnA = new System.Windows.Forms.RadioButton();
            this.rdBtnC = new System.Windows.Forms.RadioButton();
            this.txtAdCharges = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpboxMeal = new System.Windows.Forms.GroupBox();
            this.btnMealEnter = new System.Windows.Forms.Button();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.rdBtnDinner = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdBtnLaunch = new System.Windows.Forms.RadioButton();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.rdBtnBreakFast = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewLaunch = new System.Windows.Forms.DataGridView();
            this.dataGridViewDinner = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBreakFast)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grpboxMeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDinner)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(35, 45);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 33;
            this.lblDate.Text = "Date";
            // 
            // btnSignout
            // 
            this.btnSignout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSignout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignout.Location = new System.Drawing.Point(888, 38);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(100, 34);
            this.btnSignout.TabIndex = 37;
            this.btnSignout.Text = "Sign Out";
            this.btnSignout.UseVisualStyleBackColor = false;
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            // 
            // dataGridViewBreakFast
            // 
            this.dataGridViewBreakFast.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBreakFast.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewBreakFast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBreakFast.Location = new System.Drawing.Point(27, 302);
            this.dataGridViewBreakFast.Name = "dataGridViewBreakFast";
            this.dataGridViewBreakFast.Size = new System.Drawing.Size(301, 187);
            this.dataGridViewBreakFast.TabIndex = 38;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(119, 26);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtStudentName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnStudentEnter);
            this.groupBox3.Controls.Add(this.rdBtnB);
            this.groupBox3.Controls.Add(this.rdBtnD);
            this.groupBox3.Controls.Add(this.rdBtnA);
            this.groupBox3.Controls.Add(this.rdBtnC);
            this.groupBox3.Controls.Add(this.txtAdCharges);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtQuantity);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtRoom);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(502, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(512, 125);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(361, 22);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(145, 26);
            this.txtStudentName.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Name";
            // 
            // btnStudentEnter
            // 
            this.btnStudentEnter.BackColor = System.Drawing.Color.GreenYellow;
            this.btnStudentEnter.Location = new System.Drawing.Point(385, 57);
            this.btnStudentEnter.Name = "btnStudentEnter";
            this.btnStudentEnter.Size = new System.Drawing.Size(89, 56);
            this.btnStudentEnter.TabIndex = 22;
            this.btnStudentEnter.Text = "Enter";
            this.btnStudentEnter.UseVisualStyleBackColor = false;
            this.btnStudentEnter.Click += new System.EventHandler(this.btnStudentEnter_Click);
            // 
            // rdBtnB
            // 
            this.rdBtnB.AutoSize = true;
            this.rdBtnB.Location = new System.Drawing.Point(169, 25);
            this.rdBtnB.Name = "rdBtnB";
            this.rdBtnB.Size = new System.Drawing.Size(38, 24);
            this.rdBtnB.TabIndex = 15;
            this.rdBtnB.TabStop = true;
            this.rdBtnB.Text = "B";
            this.rdBtnB.UseVisualStyleBackColor = true;
            // 
            // rdBtnD
            // 
            this.rdBtnD.AutoSize = true;
            this.rdBtnD.Location = new System.Drawing.Point(257, 24);
            this.rdBtnD.Name = "rdBtnD";
            this.rdBtnD.Size = new System.Drawing.Size(39, 24);
            this.rdBtnD.TabIndex = 17;
            this.rdBtnD.TabStop = true;
            this.rdBtnD.Text = "D";
            this.rdBtnD.UseVisualStyleBackColor = true;
            // 
            // rdBtnA
            // 
            this.rdBtnA.AutoSize = true;
            this.rdBtnA.Location = new System.Drawing.Point(127, 25);
            this.rdBtnA.Name = "rdBtnA";
            this.rdBtnA.Size = new System.Drawing.Size(38, 24);
            this.rdBtnA.TabIndex = 14;
            this.rdBtnA.TabStop = true;
            this.rdBtnA.Text = "A";
            this.rdBtnA.UseVisualStyleBackColor = true;
            // 
            // rdBtnC
            // 
            this.rdBtnC.AutoSize = true;
            this.rdBtnC.Location = new System.Drawing.Point(213, 24);
            this.rdBtnC.Name = "rdBtnC";
            this.rdBtnC.Size = new System.Drawing.Size(38, 24);
            this.rdBtnC.TabIndex = 16;
            this.rdBtnC.TabStop = true;
            this.rdBtnC.Text = "C";
            this.rdBtnC.UseVisualStyleBackColor = true;
            // 
            // txtAdCharges
            // 
            this.txtAdCharges.Location = new System.Drawing.Point(285, 77);
            this.txtAdCharges.Name = "txtAdCharges";
            this.txtAdCharges.Size = new System.Drawing.Size(54, 26);
            this.txtAdCharges.TabIndex = 21;
            this.txtAdCharges.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Additional Charges";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(80, 77);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(50, 26);
            this.txtQuantity.TabIndex = 19;
            this.txtQuantity.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Quantity";
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(64, 29);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(57, 26);
            this.txtRoom.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Room";
            // 
            // grpboxMeal
            // 
            this.grpboxMeal.Controls.Add(this.btnMealEnter);
            this.grpboxMeal.Controls.Add(this.txtUnit);
            this.grpboxMeal.Controls.Add(this.rdBtnDinner);
            this.grpboxMeal.Controls.Add(this.label2);
            this.grpboxMeal.Controls.Add(this.rdBtnLaunch);
            this.grpboxMeal.Controls.Add(this.txtFoodName);
            this.grpboxMeal.Controls.Add(this.rdBtnBreakFast);
            this.grpboxMeal.Controls.Add(this.label1);
            this.grpboxMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxMeal.Location = new System.Drawing.Point(27, 88);
            this.grpboxMeal.Name = "grpboxMeal";
            this.grpboxMeal.Size = new System.Drawing.Size(469, 125);
            this.grpboxMeal.TabIndex = 40;
            this.grpboxMeal.TabStop = false;
            this.grpboxMeal.Text = "Meal / Food";
            // 
            // btnMealEnter
            // 
            this.btnMealEnter.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMealEnter.Location = new System.Drawing.Point(371, 33);
            this.btnMealEnter.Name = "btnMealEnter";
            this.btnMealEnter.Size = new System.Drawing.Size(89, 56);
            this.btnMealEnter.TabIndex = 23;
            this.btnMealEnter.Text = "Enter";
            this.btnMealEnter.UseVisualStyleBackColor = false;
            this.btnMealEnter.Click += new System.EventHandler(this.btnMealEnter_Click);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(187, 75);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(157, 26);
            this.txtUnit.TabIndex = 10;
            // 
            // rdBtnDinner
            // 
            this.rdBtnDinner.AutoSize = true;
            this.rdBtnDinner.Location = new System.Drawing.Point(6, 89);
            this.rdBtnDinner.Name = "rdBtnDinner";
            this.rdBtnDinner.Size = new System.Drawing.Size(74, 24);
            this.rdBtnDinner.TabIndex = 5;
            this.rdBtnDinner.TabStop = true;
            this.rdBtnDinner.Text = "Dinner";
            this.rdBtnDinner.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Unit";
            // 
            // rdBtnLaunch
            // 
            this.rdBtnLaunch.AutoSize = true;
            this.rdBtnLaunch.Location = new System.Drawing.Point(6, 59);
            this.rdBtnLaunch.Name = "rdBtnLaunch";
            this.rdBtnLaunch.Size = new System.Drawing.Size(80, 24);
            this.rdBtnLaunch.TabIndex = 4;
            this.rdBtnLaunch.TabStop = true;
            this.rdBtnLaunch.Text = "Launch";
            this.rdBtnLaunch.UseVisualStyleBackColor = true;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(187, 30);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(157, 26);
            this.txtFoodName.TabIndex = 8;
            // 
            // rdBtnBreakFast
            // 
            this.rdBtnBreakFast.AutoSize = true;
            this.rdBtnBreakFast.Location = new System.Drawing.Point(6, 29);
            this.rdBtnBreakFast.Name = "rdBtnBreakFast";
            this.rdBtnBreakFast.Size = new System.Drawing.Size(105, 24);
            this.rdBtnBreakFast.TabIndex = 3;
            this.rdBtnBreakFast.TabStop = true;
            this.rdBtnBreakFast.Text = "Break Fast";
            this.rdBtnBreakFast.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // dataGridViewLaunch
            // 
            this.dataGridViewLaunch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLaunch.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewLaunch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLaunch.Location = new System.Drawing.Point(352, 302);
            this.dataGridViewLaunch.Name = "dataGridViewLaunch";
            this.dataGridViewLaunch.Size = new System.Drawing.Size(315, 187);
            this.dataGridViewLaunch.TabIndex = 42;
            // 
            // dataGridViewDinner
            // 
            this.dataGridViewDinner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDinner.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewDinner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDinner.Location = new System.Drawing.Point(696, 302);
            this.dataGridViewDinner.Name = "dataGridViewDinner";
            this.dataGridViewDinner.Size = new System.Drawing.Size(312, 187);
            this.dataGridViewDinner.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 44;
            this.label7.Text = "Breakfast";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(349, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 45;
            this.label8.Text = "Launch";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(693, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 46;
            this.label9.Text = "Dinner";
            // 
            // FormAttendenceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1037, 518);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewDinner);
            this.Controls.Add(this.dataGridViewLaunch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpboxMeal);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnSignout);
            this.Controls.Add(this.dataGridViewBreakFast);
            this.Name = "FormAttendenceManager";
            this.Text = "FormAttendenceManager";
            this.Load += new System.EventHandler(this.FormAttendenceManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBreakFast)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpboxMeal.ResumeLayout(false);
            this.grpboxMeal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSignout;
        private System.Windows.Forms.DataGridView dataGridViewBreakFast;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStudentEnter;
        private System.Windows.Forms.RadioButton rdBtnB;
        private System.Windows.Forms.RadioButton rdBtnD;
        private System.Windows.Forms.RadioButton rdBtnA;
        private System.Windows.Forms.RadioButton rdBtnC;
        private System.Windows.Forms.TextBox txtAdCharges;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpboxMeal;
        private System.Windows.Forms.Button btnMealEnter;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.RadioButton rdBtnDinner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdBtnLaunch;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.RadioButton rdBtnBreakFast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLaunch;
        private System.Windows.Forms.DataGridView dataGridViewDinner;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}