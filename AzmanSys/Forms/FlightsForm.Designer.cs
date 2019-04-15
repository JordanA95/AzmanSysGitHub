namespace AzmanSys
{
    partial class FlightsForm
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
            this.tbDepartureCity = new System.Windows.Forms.TextBox();
            this.tbFlightID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtArrivalDateTime = new System.Windows.Forms.DateTimePicker();
            this.dtDepartureDateTime = new System.Windows.Forms.DateTimePicker();
            this.tbArrivalCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Flights_title = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.Searchflightbtn = new System.Windows.Forms.Button();
            this.flightsearchtxb = new System.Windows.Forms.TextBox();
            this.Pricingexplainedlbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.calculatepricesbtn = new System.Windows.Forms.Button();
            this.adultpricelbl = new System.Windows.Forms.Label();
            this.childpricelbl = new System.Windows.Forms.Label();
            this.infantpricelbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numberofadulttxb = new System.Windows.Forms.TextBox();
            this.numberofchildtxb = new System.Windows.Forms.TextBox();
            this.numberofinfanttxb = new System.Windows.Forms.TextBox();
            this.numberofinfantlbl = new System.Windows.Forms.Label();
            this.numberofchildlbl = new System.Windows.Forms.Label();
            this.numberofadultlbl = new System.Windows.Forms.Label();
            this.totalinfantlbl = new System.Windows.Forms.Label();
            this.totalchildlbl = new System.Windows.Forms.Label();
            this.totaladultlbl = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printflightsbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDepartureCity
            // 
            this.tbDepartureCity.Location = new System.Drawing.Point(492, 98);
            this.tbDepartureCity.Name = "tbDepartureCity";
            this.tbDepartureCity.Size = new System.Drawing.Size(100, 20);
            this.tbDepartureCity.TabIndex = 24;
            // 
            // tbFlightID
            // 
            this.tbFlightID.Enabled = false;
            this.tbFlightID.Location = new System.Drawing.Point(188, 71);
            this.tbFlightID.Name = "tbFlightID";
            this.tbFlightID.ReadOnly = true;
            this.tbFlightID.Size = new System.Drawing.Size(100, 20);
            this.tbFlightID.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Departure City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Arrival Date and Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Depature Date and time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Flight ID";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(290, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.Location = new System.Drawing.Point(200, 222);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Location = new System.Drawing.Point(107, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 251);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(665, 206);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(492, 66);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 23;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Price for Adult";
            // 
            // dtArrivalDateTime
            // 
            this.dtArrivalDateTime.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.dtArrivalDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtArrivalDateTime.Location = new System.Drawing.Point(188, 142);
            this.dtArrivalDateTime.Name = "dtArrivalDateTime";
            this.dtArrivalDateTime.Size = new System.Drawing.Size(200, 20);
            this.dtArrivalDateTime.TabIndex = 22;
            // 
            // dtDepartureDateTime
            // 
            this.dtDepartureDateTime.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.dtDepartureDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDepartureDateTime.Location = new System.Drawing.Point(188, 110);
            this.dtDepartureDateTime.Name = "dtDepartureDateTime";
            this.dtDepartureDateTime.Size = new System.Drawing.Size(200, 20);
            this.dtDepartureDateTime.TabIndex = 21;
            // 
            // tbArrivalCity
            // 
            this.tbArrivalCity.Location = new System.Drawing.Point(492, 134);
            this.tbArrivalCity.Name = "tbArrivalCity";
            this.tbArrivalCity.Size = new System.Drawing.Size(100, 20);
            this.tbArrivalCity.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Arrival City";
            // 
            // Flights_title
            // 
            this.Flights_title.AutoSize = true;
            this.Flights_title.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flights_title.ForeColor = System.Drawing.Color.Blue;
            this.Flights_title.Location = new System.Drawing.Point(337, 9);
            this.Flights_title.Name = "Flights_title";
            this.Flights_title.Size = new System.Drawing.Size(59, 38);
            this.Flights_title.TabIndex = 33;
            this.Flights_title.Text = "???";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMainMenu.Location = new System.Drawing.Point(12, 9);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(136, 23);
            this.btnMainMenu.TabIndex = 34;
            this.btnMainMenu.Text = "Back to Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click_1);
            // 
            // Searchflightbtn
            // 
            this.Searchflightbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Searchflightbtn.Location = new System.Drawing.Point(306, 175);
            this.Searchflightbtn.Name = "Searchflightbtn";
            this.Searchflightbtn.Size = new System.Drawing.Size(108, 23);
            this.Searchflightbtn.TabIndex = 36;
            this.Searchflightbtn.Text = "Search for Flight";
            this.Searchflightbtn.UseVisualStyleBackColor = false;
            this.Searchflightbtn.Click += new System.EventHandler(this.Searchflightbtn_Click);
            // 
            // flightsearchtxb
            // 
            this.flightsearchtxb.Location = new System.Drawing.Point(200, 177);
            this.flightsearchtxb.Name = "flightsearchtxb";
            this.flightsearchtxb.Size = new System.Drawing.Size(100, 20);
            this.flightsearchtxb.TabIndex = 37;
            this.flightsearchtxb.TextChanged += new System.EventHandler(this.flightsearchtxb_TextChanged);
            // 
            // Pricingexplainedlbl
            // 
            this.Pricingexplainedlbl.AutoSize = true;
            this.Pricingexplainedlbl.Location = new System.Drawing.Point(602, 34);
            this.Pricingexplainedlbl.Name = "Pricingexplainedlbl";
            this.Pricingexplainedlbl.Size = new System.Drawing.Size(193, 13);
            this.Pricingexplainedlbl.TabIndex = 38;
            this.Pricingexplainedlbl.Text = "Please Note price displayed is for Adult.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Children get a 20% discount, and Infants get a 30% discount.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(671, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Price for One Child:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(664, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Price for One Infant:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(634, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Ticket Price for One Adult:";
            // 
            // calculatepricesbtn
            // 
            this.calculatepricesbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.calculatepricesbtn.Location = new System.Drawing.Point(793, 246);
            this.calculatepricesbtn.Name = "calculatepricesbtn";
            this.calculatepricesbtn.Size = new System.Drawing.Size(100, 23);
            this.calculatepricesbtn.TabIndex = 48;
            this.calculatepricesbtn.Text = "Calculate Prices";
            this.calculatepricesbtn.UseVisualStyleBackColor = false;
            this.calculatepricesbtn.Click += new System.EventHandler(this.calculatepricesbtn_Click);
            // 
            // adultpricelbl
            // 
            this.adultpricelbl.AutoSize = true;
            this.adultpricelbl.Location = new System.Drawing.Point(772, 71);
            this.adultpricelbl.Name = "adultpricelbl";
            this.adultpricelbl.Size = new System.Drawing.Size(16, 13);
            this.adultpricelbl.TabIndex = 49;
            this.adultpricelbl.Text = "...";
            // 
            // childpricelbl
            // 
            this.childpricelbl.AutoSize = true;
            this.childpricelbl.Location = new System.Drawing.Point(772, 98);
            this.childpricelbl.Name = "childpricelbl";
            this.childpricelbl.Size = new System.Drawing.Size(16, 13);
            this.childpricelbl.TabIndex = 50;
            this.childpricelbl.Text = "...";
            // 
            // infantpricelbl
            // 
            this.infantpricelbl.AutoSize = true;
            this.infantpricelbl.Location = new System.Drawing.Point(772, 117);
            this.infantpricelbl.Name = "infantpricelbl";
            this.infantpricelbl.Size = new System.Drawing.Size(16, 13);
            this.infantpricelbl.TabIndex = 51;
            this.infantpricelbl.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(604, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Please enter the number of passengers:";
            // 
            // numberofadulttxb
            // 
            this.numberofadulttxb.Location = new System.Drawing.Point(793, 175);
            this.numberofadulttxb.Name = "numberofadulttxb";
            this.numberofadulttxb.Size = new System.Drawing.Size(100, 20);
            this.numberofadulttxb.TabIndex = 53;
            this.numberofadulttxb.Text = "1";
            // 
            // numberofchildtxb
            // 
            this.numberofchildtxb.Location = new System.Drawing.Point(793, 197);
            this.numberofchildtxb.Name = "numberofchildtxb";
            this.numberofchildtxb.Size = new System.Drawing.Size(100, 20);
            this.numberofchildtxb.TabIndex = 54;
            this.numberofchildtxb.Text = "1";
            // 
            // numberofinfanttxb
            // 
            this.numberofinfanttxb.Location = new System.Drawing.Point(793, 220);
            this.numberofinfanttxb.Name = "numberofinfanttxb";
            this.numberofinfanttxb.Size = new System.Drawing.Size(100, 20);
            this.numberofinfanttxb.TabIndex = 55;
            this.numberofinfanttxb.Text = "1";
            // 
            // numberofinfantlbl
            // 
            this.numberofinfantlbl.AutoSize = true;
            this.numberofinfantlbl.Location = new System.Drawing.Point(702, 223);
            this.numberofinfantlbl.Name = "numberofinfantlbl";
            this.numberofinfantlbl.Size = new System.Drawing.Size(89, 13);
            this.numberofinfantlbl.TabIndex = 56;
            this.numberofinfantlbl.Text = "Number of Infant:";
            // 
            // numberofchildlbl
            // 
            this.numberofchildlbl.AutoSize = true;
            this.numberofchildlbl.Location = new System.Drawing.Point(702, 197);
            this.numberofchildlbl.Name = "numberofchildlbl";
            this.numberofchildlbl.Size = new System.Drawing.Size(85, 13);
            this.numberofchildlbl.TabIndex = 57;
            this.numberofchildlbl.Text = "Number of Child:";
            // 
            // numberofadultlbl
            // 
            this.numberofadultlbl.AutoSize = true;
            this.numberofadultlbl.Location = new System.Drawing.Point(702, 175);
            this.numberofadultlbl.Name = "numberofadultlbl";
            this.numberofadultlbl.Size = new System.Drawing.Size(86, 13);
            this.numberofadultlbl.TabIndex = 58;
            this.numberofadultlbl.Text = "Number of Adult:";
            // 
            // totalinfantlbl
            // 
            this.totalinfantlbl.AutoSize = true;
            this.totalinfantlbl.Location = new System.Drawing.Point(840, 341);
            this.totalinfantlbl.Name = "totalinfantlbl";
            this.totalinfantlbl.Size = new System.Drawing.Size(16, 13);
            this.totalinfantlbl.TabIndex = 64;
            this.totalinfantlbl.Text = "...";
            // 
            // totalchildlbl
            // 
            this.totalchildlbl.AutoSize = true;
            this.totalchildlbl.Location = new System.Drawing.Point(840, 322);
            this.totalchildlbl.Name = "totalchildlbl";
            this.totalchildlbl.Size = new System.Drawing.Size(16, 13);
            this.totalchildlbl.TabIndex = 63;
            this.totalchildlbl.Text = "...";
            // 
            // totaladultlbl
            // 
            this.totaladultlbl.AutoSize = true;
            this.totaladultlbl.Location = new System.Drawing.Point(840, 295);
            this.totaladultlbl.Name = "totaladultlbl";
            this.totaladultlbl.Size = new System.Drawing.Size(16, 13);
            this.totaladultlbl.TabIndex = 62;
            this.totaladultlbl.Text = "...";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(702, 295);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 13);
            this.label15.TabIndex = 61;
            this.label15.Text = "Total Price for All Adults:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(699, 341);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "Total Price for All Infants:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(693, 322);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(131, 13);
            this.label17.TabIndex = 59;
            this.label17.Text = "Total Price for All Children:";
            // 
            // printflightsbtn
            // 
            this.printflightsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.printflightsbtn.Location = new System.Drawing.Point(775, 396);
            this.printflightsbtn.Name = "printflightsbtn";
            this.printflightsbtn.Size = new System.Drawing.Size(75, 23);
            this.printflightsbtn.TabIndex = 65;
            this.printflightsbtn.Text = "Print";
            this.printflightsbtn.UseVisualStyleBackColor = false;
            this.printflightsbtn.Click += new System.EventHandler(this.printflightsbtn_Click);
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(911, 469);
            this.Controls.Add(this.printflightsbtn);
            this.Controls.Add(this.totalinfantlbl);
            this.Controls.Add(this.totalchildlbl);
            this.Controls.Add(this.totaladultlbl);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.numberofadultlbl);
            this.Controls.Add(this.numberofchildlbl);
            this.Controls.Add(this.numberofinfantlbl);
            this.Controls.Add(this.numberofinfanttxb);
            this.Controls.Add(this.numberofchildtxb);
            this.Controls.Add(this.numberofadulttxb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.infantpricelbl);
            this.Controls.Add(this.childpricelbl);
            this.Controls.Add(this.adultpricelbl);
            this.Controls.Add(this.calculatepricesbtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Pricingexplainedlbl);
            this.Controls.Add(this.flightsearchtxb);
            this.Controls.Add(this.Searchflightbtn);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.Flights_title);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbArrivalCity);
            this.Controls.Add(this.dtDepartureDateTime);
            this.Controls.Add(this.dtArrivalDateTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbDepartureCity);
            this.Controls.Add(this.tbFlightID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "FlightsForm";
            this.Text = "Flights";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDepartureCity;
        private System.Windows.Forms.TextBox tbFlightID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtArrivalDateTime;
        private System.Windows.Forms.DateTimePicker dtDepartureDateTime;
        private System.Windows.Forms.TextBox tbArrivalCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Flights_title;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button Searchflightbtn;
        private System.Windows.Forms.TextBox flightsearchtxb;
        private System.Windows.Forms.Label Pricingexplainedlbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button calculatepricesbtn;
        private System.Windows.Forms.Label adultpricelbl;
        private System.Windows.Forms.Label childpricelbl;
        private System.Windows.Forms.Label infantpricelbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox numberofadulttxb;
        private System.Windows.Forms.TextBox numberofchildtxb;
        private System.Windows.Forms.TextBox numberofinfanttxb;
        private System.Windows.Forms.Label numberofinfantlbl;
        private System.Windows.Forms.Label numberofchildlbl;
        private System.Windows.Forms.Label numberofadultlbl;
        private System.Windows.Forms.Label totalinfantlbl;
        private System.Windows.Forms.Label totalchildlbl;
        private System.Windows.Forms.Label totaladultlbl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button printflightsbtn;
    }
}