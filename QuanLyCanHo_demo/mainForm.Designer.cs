namespace QuanLyCanHo_demo
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCardManage = new System.Windows.Forms.TabPage();
            this.boxCardStatus = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCardIDClear = new System.Windows.Forms.Button();
            this.btnDelCardID = new System.Windows.Forms.Button();
            this.btnChangeCardID = new System.Windows.Forms.Button();
            this.btnAddCardID = new System.Windows.Forms.Button();
            this.btnSearchAllCardID = new System.Windows.Forms.Button();
            this.boxCardsGuest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxCardsRoom = new System.Windows.Forms.TextBox();
            this.CardGridView = new System.Windows.Forms.DataGridView();
            this.boxCardID = new System.Windows.Forms.TextBox();
            this.cardidroom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchCardId = new System.Windows.Forms.Button();
            this.tabRoomManage = new System.Windows.Forms.TabPage();
            this.btnRoomTSearch = new System.Windows.Forms.Button();
            this.btnRoomIDSearch = new System.Windows.Forms.Button();
            this.boxRoomType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.boxRoomID = new System.Windows.Forms.ComboBox();
            this.btnRoomCancel = new System.Windows.Forms.Button();
            this.btnRoomUpdate = new System.Windows.Forms.Button();
            this.boxRoomsCardV = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.boxDateRoomE = new System.Windows.Forms.TextBox();
            this.boxDateRoomS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.boxRoomStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RoomGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tabGuestManage = new System.Windows.Forms.TabPage();
            this.btnClearGuest = new System.Windows.Forms.Button();
            this.btnSearchAllGuest = new System.Windows.Forms.Button();
            this.btnGuestSearch = new System.Windows.Forms.Button();
            this.boxLastName = new System.Windows.Forms.TextBox();
            this.boxFirstName = new System.Windows.Forms.TextBox();
            this.boxCMND = new System.Windows.Forms.TextBox();
            this.GuestGridView = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.tabLogCheck = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.boxRoomSelect = new System.Windows.Forms.ComboBox();
            this.btnBikeSearch = new System.Windows.Forms.Button();
            this.btnDoorSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BikeDoorGridView = new System.Windows.Forms.DataGridView();
            this.RoomLogGridView = new System.Windows.Forms.DataGridView();
            this.tabAddGuest = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.boxGuestsRoom = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.btnCancelAddG = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabCardManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardGridView)).BeginInit();
            this.tabRoomManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).BeginInit();
            this.tabGuestManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuestGridView)).BeginInit();
            this.tabLogCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BikeDoorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomLogGridView)).BeginInit();
            this.tabAddGuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCardManage);
            this.tabControl1.Controls.Add(this.tabRoomManage);
            this.tabControl1.Controls.Add(this.tabGuestManage);
            this.tabControl1.Controls.Add(this.tabLogCheck);
            this.tabControl1.Controls.Add(this.tabAddGuest);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabCardManage
            // 
            this.tabCardManage.BackColor = System.Drawing.Color.Silver;
            this.tabCardManage.Controls.Add(this.boxCardStatus);
            this.tabCardManage.Controls.Add(this.label13);
            this.tabCardManage.Controls.Add(this.btnCardIDClear);
            this.tabCardManage.Controls.Add(this.btnDelCardID);
            this.tabCardManage.Controls.Add(this.btnChangeCardID);
            this.tabCardManage.Controls.Add(this.btnAddCardID);
            this.tabCardManage.Controls.Add(this.btnSearchAllCardID);
            this.tabCardManage.Controls.Add(this.boxCardsGuest);
            this.tabCardManage.Controls.Add(this.label4);
            this.tabCardManage.Controls.Add(this.boxCardsRoom);
            this.tabCardManage.Controls.Add(this.CardGridView);
            this.tabCardManage.Controls.Add(this.boxCardID);
            this.tabCardManage.Controls.Add(this.cardidroom);
            this.tabCardManage.Controls.Add(this.label3);
            this.tabCardManage.Controls.Add(this.btnSearchCardId);
            resources.ApplyResources(this.tabCardManage, "tabCardManage");
            this.tabCardManage.Name = "tabCardManage";
            // 
            // boxCardStatus
            // 
            resources.ApplyResources(this.boxCardStatus, "boxCardStatus");
            this.boxCardStatus.Name = "boxCardStatus";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // btnCardIDClear
            // 
            resources.ApplyResources(this.btnCardIDClear, "btnCardIDClear");
            this.btnCardIDClear.Name = "btnCardIDClear";
            this.btnCardIDClear.UseVisualStyleBackColor = true;
            this.btnCardIDClear.Click += new System.EventHandler(this.btnCardIDClear_Click);
            // 
            // btnDelCardID
            // 
            resources.ApplyResources(this.btnDelCardID, "btnDelCardID");
            this.btnDelCardID.Name = "btnDelCardID";
            this.btnDelCardID.UseVisualStyleBackColor = true;
            // 
            // btnChangeCardID
            // 
            resources.ApplyResources(this.btnChangeCardID, "btnChangeCardID");
            this.btnChangeCardID.Name = "btnChangeCardID";
            this.btnChangeCardID.UseVisualStyleBackColor = true;
            // 
            // btnAddCardID
            // 
            resources.ApplyResources(this.btnAddCardID, "btnAddCardID");
            this.btnAddCardID.Name = "btnAddCardID";
            this.btnAddCardID.UseVisualStyleBackColor = true;
            // 
            // btnSearchAllCardID
            // 
            resources.ApplyResources(this.btnSearchAllCardID, "btnSearchAllCardID");
            this.btnSearchAllCardID.Name = "btnSearchAllCardID";
            this.btnSearchAllCardID.UseVisualStyleBackColor = true;
            // 
            // boxCardsGuest
            // 
            resources.ApplyResources(this.boxCardsGuest, "boxCardsGuest");
            this.boxCardsGuest.Name = "boxCardsGuest";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // boxCardsRoom
            // 
            resources.ApplyResources(this.boxCardsRoom, "boxCardsRoom");
            this.boxCardsRoom.Name = "boxCardsRoom";
            // 
            // CardGridView
            // 
            this.CardGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.CardGridView, "CardGridView");
            this.CardGridView.Name = "CardGridView";
            this.CardGridView.RowTemplate.Height = 24;
            // 
            // boxCardID
            // 
            resources.ApplyResources(this.boxCardID, "boxCardID");
            this.boxCardID.Name = "boxCardID";
            // 
            // cardidroom
            // 
            resources.ApplyResources(this.cardidroom, "cardidroom");
            this.cardidroom.Name = "cardidroom";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnSearchCardId
            // 
            resources.ApplyResources(this.btnSearchCardId, "btnSearchCardId");
            this.btnSearchCardId.Name = "btnSearchCardId";
            this.btnSearchCardId.UseVisualStyleBackColor = true;
            // 
            // tabRoomManage
            // 
            this.tabRoomManage.BackColor = System.Drawing.Color.Silver;
            this.tabRoomManage.Controls.Add(this.btnRoomTSearch);
            this.tabRoomManage.Controls.Add(this.btnRoomIDSearch);
            this.tabRoomManage.Controls.Add(this.boxRoomType);
            this.tabRoomManage.Controls.Add(this.label12);
            this.tabRoomManage.Controls.Add(this.boxRoomID);
            this.tabRoomManage.Controls.Add(this.btnRoomCancel);
            this.tabRoomManage.Controls.Add(this.btnRoomUpdate);
            this.tabRoomManage.Controls.Add(this.boxRoomsCardV);
            this.tabRoomManage.Controls.Add(this.label9);
            this.tabRoomManage.Controls.Add(this.boxDateRoomE);
            this.tabRoomManage.Controls.Add(this.boxDateRoomS);
            this.tabRoomManage.Controls.Add(this.label8);
            this.tabRoomManage.Controls.Add(this.label7);
            this.tabRoomManage.Controls.Add(this.boxRoomStatus);
            this.tabRoomManage.Controls.Add(this.label6);
            this.tabRoomManage.Controls.Add(this.RoomGridView);
            this.tabRoomManage.Controls.Add(this.label5);
            resources.ApplyResources(this.tabRoomManage, "tabRoomManage");
            this.tabRoomManage.Name = "tabRoomManage";
            // 
            // btnRoomTSearch
            // 
            resources.ApplyResources(this.btnRoomTSearch, "btnRoomTSearch");
            this.btnRoomTSearch.Name = "btnRoomTSearch";
            this.btnRoomTSearch.UseVisualStyleBackColor = true;
            // 
            // btnRoomIDSearch
            // 
            resources.ApplyResources(this.btnRoomIDSearch, "btnRoomIDSearch");
            this.btnRoomIDSearch.Name = "btnRoomIDSearch";
            this.btnRoomIDSearch.UseVisualStyleBackColor = true;
            // 
            // boxRoomType
            // 
            this.boxRoomType.FormattingEnabled = true;
            resources.ApplyResources(this.boxRoomType, "boxRoomType");
            this.boxRoomType.Name = "boxRoomType";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // boxRoomID
            // 
            this.boxRoomID.FormattingEnabled = true;
            resources.ApplyResources(this.boxRoomID, "boxRoomID");
            this.boxRoomID.Name = "boxRoomID";
            // 
            // btnRoomCancel
            // 
            resources.ApplyResources(this.btnRoomCancel, "btnRoomCancel");
            this.btnRoomCancel.Name = "btnRoomCancel";
            this.btnRoomCancel.UseVisualStyleBackColor = true;
            // 
            // btnRoomUpdate
            // 
            resources.ApplyResources(this.btnRoomUpdate, "btnRoomUpdate");
            this.btnRoomUpdate.Name = "btnRoomUpdate";
            this.btnRoomUpdate.UseVisualStyleBackColor = true;
            // 
            // boxRoomsCardV
            // 
            resources.ApplyResources(this.boxRoomsCardV, "boxRoomsCardV");
            this.boxRoomsCardV.Name = "boxRoomsCardV";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // boxDateRoomE
            // 
            resources.ApplyResources(this.boxDateRoomE, "boxDateRoomE");
            this.boxDateRoomE.Name = "boxDateRoomE";
            // 
            // boxDateRoomS
            // 
            resources.ApplyResources(this.boxDateRoomS, "boxDateRoomS");
            this.boxDateRoomS.Name = "boxDateRoomS";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // boxRoomStatus
            // 
            resources.ApplyResources(this.boxRoomStatus, "boxRoomStatus");
            this.boxRoomStatus.Name = "boxRoomStatus";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // RoomGridView
            // 
            this.RoomGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.RoomGridView, "RoomGridView");
            this.RoomGridView.Name = "RoomGridView";
            this.RoomGridView.RowTemplate.Height = 24;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // tabGuestManage
            // 
            this.tabGuestManage.BackColor = System.Drawing.Color.Silver;
            this.tabGuestManage.Controls.Add(this.boxGuestsRoom);
            this.tabGuestManage.Controls.Add(this.label19);
            this.tabGuestManage.Controls.Add(this.btnClearGuest);
            this.tabGuestManage.Controls.Add(this.btnSearchAllGuest);
            this.tabGuestManage.Controls.Add(this.btnGuestSearch);
            this.tabGuestManage.Controls.Add(this.boxLastName);
            this.tabGuestManage.Controls.Add(this.boxFirstName);
            this.tabGuestManage.Controls.Add(this.boxCMND);
            this.tabGuestManage.Controls.Add(this.GuestGridView);
            this.tabGuestManage.Controls.Add(this.label11);
            this.tabGuestManage.Controls.Add(this.label10);
            this.tabGuestManage.Controls.Add(this.FirstName);
            resources.ApplyResources(this.tabGuestManage, "tabGuestManage");
            this.tabGuestManage.Name = "tabGuestManage";
            // 
            // btnClearGuest
            // 
            resources.ApplyResources(this.btnClearGuest, "btnClearGuest");
            this.btnClearGuest.Name = "btnClearGuest";
            this.btnClearGuest.UseVisualStyleBackColor = true;
            // 
            // btnSearchAllGuest
            // 
            resources.ApplyResources(this.btnSearchAllGuest, "btnSearchAllGuest");
            this.btnSearchAllGuest.Name = "btnSearchAllGuest";
            this.btnSearchAllGuest.UseVisualStyleBackColor = true;
            // 
            // btnGuestSearch
            // 
            resources.ApplyResources(this.btnGuestSearch, "btnGuestSearch");
            this.btnGuestSearch.Name = "btnGuestSearch";
            this.btnGuestSearch.UseVisualStyleBackColor = true;
            // 
            // boxLastName
            // 
            resources.ApplyResources(this.boxLastName, "boxLastName");
            this.boxLastName.Name = "boxLastName";
            // 
            // boxFirstName
            // 
            resources.ApplyResources(this.boxFirstName, "boxFirstName");
            this.boxFirstName.Name = "boxFirstName";
            // 
            // boxCMND
            // 
            resources.ApplyResources(this.boxCMND, "boxCMND");
            this.boxCMND.Name = "boxCMND";
            // 
            // GuestGridView
            // 
            this.GuestGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.GuestGridView, "GuestGridView");
            this.GuestGridView.Name = "GuestGridView";
            this.GuestGridView.RowTemplate.Height = 24;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // FirstName
            // 
            resources.ApplyResources(this.FirstName, "FirstName");
            this.FirstName.Name = "FirstName";
            // 
            // tabLogCheck
            // 
            this.tabLogCheck.BackColor = System.Drawing.Color.Silver;
            this.tabLogCheck.Controls.Add(this.label14);
            this.tabLogCheck.Controls.Add(this.boxRoomSelect);
            this.tabLogCheck.Controls.Add(this.btnBikeSearch);
            this.tabLogCheck.Controls.Add(this.btnDoorSearch);
            this.tabLogCheck.Controls.Add(this.label2);
            this.tabLogCheck.Controls.Add(this.label1);
            this.tabLogCheck.Controls.Add(this.BikeDoorGridView);
            this.tabLogCheck.Controls.Add(this.RoomLogGridView);
            resources.ApplyResources(this.tabLogCheck, "tabLogCheck");
            this.tabLogCheck.Name = "tabLogCheck";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // boxRoomSelect
            // 
            this.boxRoomSelect.FormattingEnabled = true;
            resources.ApplyResources(this.boxRoomSelect, "boxRoomSelect");
            this.boxRoomSelect.Name = "boxRoomSelect";
            // 
            // btnBikeSearch
            // 
            resources.ApplyResources(this.btnBikeSearch, "btnBikeSearch");
            this.btnBikeSearch.Name = "btnBikeSearch";
            this.btnBikeSearch.UseVisualStyleBackColor = true;
            // 
            // btnDoorSearch
            // 
            resources.ApplyResources(this.btnDoorSearch, "btnDoorSearch");
            this.btnDoorSearch.Name = "btnDoorSearch";
            this.btnDoorSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // BikeDoorGridView
            // 
            this.BikeDoorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.BikeDoorGridView, "BikeDoorGridView");
            this.BikeDoorGridView.Name = "BikeDoorGridView";
            this.BikeDoorGridView.RowTemplate.Height = 24;
            // 
            // RoomLogGridView
            // 
            this.RoomLogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.RoomLogGridView, "RoomLogGridView");
            this.RoomLogGridView.Name = "RoomLogGridView";
            this.RoomLogGridView.RowTemplate.Height = 24;
            // 
            // tabAddGuest
            // 
            this.tabAddGuest.BackColor = System.Drawing.Color.Silver;
            this.tabAddGuest.Controls.Add(this.btnCancelAddG);
            this.tabAddGuest.Controls.Add(this.btnAddGuest);
            this.tabAddGuest.Controls.Add(this.dateTimePickerOut);
            this.tabAddGuest.Controls.Add(this.dateTimePickerIn);
            this.tabAddGuest.Controls.Add(this.label22);
            this.tabAddGuest.Controls.Add(this.label21);
            this.tabAddGuest.Controls.Add(this.textBox5);
            this.tabAddGuest.Controls.Add(this.label20);
            this.tabAddGuest.Controls.Add(this.textBox4);
            this.tabAddGuest.Controls.Add(this.textBox3);
            this.tabAddGuest.Controls.Add(this.textBox2);
            this.tabAddGuest.Controls.Add(this.textBox1);
            this.tabAddGuest.Controls.Add(this.label18);
            this.tabAddGuest.Controls.Add(this.label17);
            this.tabAddGuest.Controls.Add(this.label16);
            this.tabAddGuest.Controls.Add(this.label15);
            resources.ApplyResources(this.tabAddGuest, "tabAddGuest");
            this.tabAddGuest.Name = "tabAddGuest";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // boxGuestsRoom
            // 
            resources.ApplyResources(this.boxGuestsRoom, "boxGuestsRoom");
            this.boxGuestsRoom.Name = "boxGuestsRoom";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // dateTimePickerIn
            // 
            resources.ApplyResources(this.dateTimePickerIn, "dateTimePickerIn");
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            // 
            // dateTimePickerOut
            // 
            resources.ApplyResources(this.dateTimePickerOut, "dateTimePickerOut");
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            // 
            // btnAddGuest
            // 
            resources.ApplyResources(this.btnAddGuest, "btnAddGuest");
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.UseVisualStyleBackColor = true;
            // 
            // btnCancelAddG
            // 
            resources.ApplyResources(this.btnCancelAddG, "btnCancelAddG");
            this.btnCancelAddG.Name = "btnCancelAddG";
            this.btnCancelAddG.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "mainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabCardManage.ResumeLayout(false);
            this.tabCardManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardGridView)).EndInit();
            this.tabRoomManage.ResumeLayout(false);
            this.tabRoomManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).EndInit();
            this.tabGuestManage.ResumeLayout(false);
            this.tabGuestManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuestGridView)).EndInit();
            this.tabLogCheck.ResumeLayout(false);
            this.tabLogCheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BikeDoorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomLogGridView)).EndInit();
            this.tabAddGuest.ResumeLayout(false);
            this.tabAddGuest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCardManage;
        private System.Windows.Forms.Button btnSearchCardId;
        private System.Windows.Forms.TabPage tabRoomManage;
        private System.Windows.Forms.TabPage tabGuestManage;
        private System.Windows.Forms.TabPage tabLogCheck;
        private System.Windows.Forms.DataGridView BikeDoorGridView;
        private System.Windows.Forms.DataGridView RoomLogGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cardidroom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxCardID;
        private System.Windows.Forms.DataGridView CardGridView;
        private System.Windows.Forms.TextBox boxCardsGuest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxCardsRoom;
        private System.Windows.Forms.Button btnDelCardID;
        private System.Windows.Forms.Button btnChangeCardID;
        private System.Windows.Forms.Button btnAddCardID;
        private System.Windows.Forms.Button btnSearchAllCardID;
        private System.Windows.Forms.RichTextBox boxRoomsCardV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox boxDateRoomE;
        private System.Windows.Forms.TextBox boxDateRoomS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boxRoomStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView RoomGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRoomCancel;
        private System.Windows.Forms.Button btnRoomUpdate;
        private System.Windows.Forms.Button btnCardIDClear;
        private System.Windows.Forms.DataGridView GuestGridView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.ComboBox boxRoomID;
        private System.Windows.Forms.TextBox boxLastName;
        private System.Windows.Forms.TextBox boxFirstName;
        private System.Windows.Forms.TextBox boxCMND;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox boxRoomType;
        private System.Windows.Forms.Button btnClearGuest;
        private System.Windows.Forms.Button btnSearchAllGuest;
        private System.Windows.Forms.Button btnGuestSearch;
        private System.Windows.Forms.TextBox boxCardStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRoomTSearch;
        private System.Windows.Forms.Button btnRoomIDSearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox boxRoomSelect;
        private System.Windows.Forms.Button btnBikeSearch;
        private System.Windows.Forms.Button btnDoorSearch;
        private System.Windows.Forms.TabPage tabAddGuest;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox boxGuestsRoom;
        private System.Windows.Forms.Button btnCancelAddG;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label20;
    }
}