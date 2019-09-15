namespace Mybikes
{
    partial class Form1
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
            this.ButtonExit = new System.Windows.Forms.Button();
            this.labelTOS2 = new System.Windows.Forms.Label();
            this.labelSH2 = new System.Windows.Forms.Label();
            this.ButtonReadXF = new System.Windows.Forms.Button();
            this.ButtonWriteXF = new System.Windows.Forms.Button();
            this.buttonDisplayR = new System.Windows.Forms.Button();
            this.buttonDisplayM = new System.Windows.Forms.Button();
            this.buttonDisplayAll = new System.Windows.Forms.Button();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelESF = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.labelWH2 = new System.Windows.Forms.Label();
            this.labelW2 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.comboBoxWheel = new System.Windows.Forms.ComboBox();
            this.labelWheel = new System.Windows.Forms.Label();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelHFG = new System.Windows.Forms.Label();
            this.labelC2 = new System.Windows.Forms.Label();
            this.labelB2 = new System.Windows.Forms.Label();
            this.labelMD = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.ListBox();
            this.textBoxSeatH = new System.Windows.Forms.TextBox();
            this.labelSHeight = new System.Windows.Forms.Label();
            this.textBoxHFG = new System.Windows.Forms.TextBox();
            this.labelHFG2 = new System.Windows.Forms.Label();
            this.comboBoxTFS = new System.Windows.Forms.ComboBox();
            this.labelTOS = new System.Windows.Forms.Label();
            this.labelMdate = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.comboBoxSpeed = new System.Windows.Forms.ComboBox();
            this.LableSpeed = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.LabelModel = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.textBoxSn = new System.Windows.Forms.TextBox();
            this.radioButtonMountain = new System.Windows.Forms.RadioButton();
            this.LabelSn = new System.Windows.Forms.Label();
            this.radioButtonRoad = new System.Windows.Forms.RadioButton();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonstop = new System.Windows.Forms.Button();
            this.buttonAcce = new System.Windows.Forms.Button();
            this.buttonBrake = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(698, 249);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 106;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // labelTOS2
            // 
            this.labelTOS2.AutoSize = true;
            this.labelTOS2.Location = new System.Drawing.Point(563, 310);
            this.labelTOS2.Name = "labelTOS2";
            this.labelTOS2.Size = new System.Drawing.Size(108, 13);
            this.labelTOS2.TabIndex = 105;
            this.labelTOS2.Text = "Types Of Suspension";
            // 
            // labelSH2
            // 
            this.labelSH2.AutoSize = true;
            this.labelSH2.Location = new System.Drawing.Point(583, 310);
            this.labelSH2.Name = "labelSH2";
            this.labelSH2.Size = new System.Drawing.Size(66, 13);
            this.labelSH2.TabIndex = 104;
            this.labelSH2.Text = "Seat Height ";
            // 
            // ButtonReadXF
            // 
            this.ButtonReadXF.Location = new System.Drawing.Point(566, 249);
            this.ButtonReadXF.Name = "ButtonReadXF";
            this.ButtonReadXF.Size = new System.Drawing.Size(114, 23);
            this.ButtonReadXF.TabIndex = 103;
            this.ButtonReadXF.Text = "Read From bin File";
            this.ButtonReadXF.UseVisualStyleBackColor = true;
            this.ButtonReadXF.Click += new System.EventHandler(this.ButtonRead_Click);
            // 
            // ButtonWriteXF
            // 
            this.ButtonWriteXF.Location = new System.Drawing.Point(460, 249);
            this.ButtonWriteXF.Name = "ButtonWriteXF";
            this.ButtonWriteXF.Size = new System.Drawing.Size(100, 23);
            this.ButtonWriteXF.TabIndex = 102;
            this.ButtonWriteXF.Text = "Write To bin File";
            this.ButtonWriteXF.UseVisualStyleBackColor = true;
            this.ButtonWriteXF.Click += new System.EventHandler(this.ButtonWrite_Click);
            // 
            // buttonDisplayR
            // 
            this.buttonDisplayR.Location = new System.Drawing.Point(192, 238);
            this.buttonDisplayR.Name = "buttonDisplayR";
            this.buttonDisplayR.Size = new System.Drawing.Size(108, 44);
            this.buttonDisplayR.TabIndex = 100;
            this.buttonDisplayR.Text = "Display Road Bikes";
            this.buttonDisplayR.UseVisualStyleBackColor = true;
            this.buttonDisplayR.Click += new System.EventHandler(this.ButtonDisplayRoad_Click);
            // 
            // buttonDisplayM
            // 
            this.buttonDisplayM.Location = new System.Drawing.Point(72, 238);
            this.buttonDisplayM.Name = "buttonDisplayM";
            this.buttonDisplayM.Size = new System.Drawing.Size(113, 44);
            this.buttonDisplayM.TabIndex = 99;
            this.buttonDisplayM.Text = "Display Mountain Bikes";
            this.buttonDisplayM.UseVisualStyleBackColor = true;
            this.buttonDisplayM.Click += new System.EventHandler(this.ButtonDisplayMountain_Click);
            // 
            // buttonDisplayAll
            // 
            this.buttonDisplayAll.Location = new System.Drawing.Point(316, 238);
            this.buttonDisplayAll.Name = "buttonDisplayAll";
            this.buttonDisplayAll.Size = new System.Drawing.Size(110, 44);
            this.buttonDisplayAll.TabIndex = 98;
            this.buttonDisplayAll.Text = "Display All Bikes";
            this.buttonDisplayAll.UseVisualStyleBackColor = true;
            this.buttonDisplayAll.Click += new System.EventHandler(this.ButtonDisplayall_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Location = new System.Drawing.Point(665, 153);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(75, 23);
            this.ButtonRemove.TabIndex = 97;
            this.ButtonRemove.Text = "Remove";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(665, 124);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(75, 23);
            this.ButtonUpdate.TabIndex = 96;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(704, 200);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearch.TabIndex = 95;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.errorProvider3.SetError(this.textBoxSearch, "Four dagits only!");
            this.textBoxSearch.Location = new System.Drawing.Point(576, 200);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(104, 20);
            this.textBoxSearch.TabIndex = 94;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // labelESF
            // 
            this.labelESF.AutoSize = true;
            this.labelESF.Location = new System.Drawing.Point(471, 205);
            this.labelESF.Name = "labelESF";
            this.labelESF.Size = new System.Drawing.Size(104, 13);
            this.labelESF.TabIndex = 93;
            this.labelESF.Text = "Enter Serial Number:";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(665, 64);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 92;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // labelWH2
            // 
            this.labelWH2.AutoSize = true;
            this.labelWH2.Location = new System.Drawing.Point(453, 310);
            this.labelWH2.Name = "labelWH2";
            this.labelWH2.Size = new System.Drawing.Size(38, 13);
            this.labelWH2.TabIndex = 91;
            this.labelWH2.Text = "Wheel";
            // 
            // labelW2
            // 
            this.labelW2.AutoSize = true;
            this.labelW2.Location = new System.Drawing.Point(170, 310);
            this.labelW2.Name = "labelW2";
            this.labelW2.Size = new System.Drawing.Size(41, 13);
            this.labelW2.TabIndex = 90;
            this.labelW2.Text = "Weight";
            // 
            // textBoxWeight
            // 
            this.errorProvider2.SetError(this.textBoxWeight, "dagits only!");
            this.textBoxWeight.Location = new System.Drawing.Point(111, 150);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeight.TabIndex = 89;
            this.textBoxWeight.TextChanged += new System.EventHandler(this.TextBoxWeight_TextChanged);
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(58, 153);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(47, 13);
            this.labelWeight.TabIndex = 88;
            this.labelWeight.Text = "Weight :";
            // 
            // comboBoxWheel
            // 
            this.comboBoxWheel.FormattingEnabled = true;
            this.comboBoxWheel.Location = new System.Drawing.Point(306, 108);
            this.comboBoxWheel.Name = "comboBoxWheel";
            this.comboBoxWheel.Size = new System.Drawing.Size(94, 21);
            this.comboBoxWheel.TabIndex = 87;
            // 
            // labelWheel
            // 
            this.labelWheel.AutoSize = true;
            this.labelWheel.Location = new System.Drawing.Point(253, 111);
            this.labelWheel.Name = "labelWheel";
            this.labelWheel.Size = new System.Drawing.Size(44, 13);
            this.labelWheel.TabIndex = 86;
            this.labelWheel.Text = "Wheel :";
            // 
            // textBoxDay
            // 
            this.errorProvider6.SetError(this.textBoxDay, "Two digits not more than 31");
            this.textBoxDay.Location = new System.Drawing.Point(419, 193);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(25, 20);
            this.textBoxDay.TabIndex = 85;
            this.textBoxDay.TextChanged += new System.EventHandler(this.TextBoxDay_TextChanged);
            // 
            // textBoxMonth
            // 
            this.errorProvider5.SetError(this.textBoxMonth, "Two digits not more than 12");
            this.textBoxMonth.Location = new System.Drawing.Point(369, 193);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(26, 20);
            this.textBoxMonth.TabIndex = 84;
            this.textBoxMonth.TextChanged += new System.EventHandler(this.TextBoxMonth_TextChanged);
            // 
            // textBoxYear
            // 
            this.errorProvider4.SetError(this.textBoxYear, "Four digits only!");
            this.textBoxYear.Location = new System.Drawing.Point(302, 193);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(45, 20);
            this.textBoxYear.TabIndex = 83;
            this.textBoxYear.TextChanged += new System.EventHandler(this.TextBoxYear_TextChanged);
            // 
            // labelHFG
            // 
            this.labelHFG.AutoSize = true;
            this.labelHFG.Location = new System.Drawing.Point(424, 152);
            this.labelHFG.Name = "labelHFG";
            this.labelHFG.Size = new System.Drawing.Size(108, 13);
            this.labelHFG.TabIndex = 82;
            this.labelHFG.Text = "Height From Ground :";
            // 
            // labelC2
            // 
            this.labelC2.AutoSize = true;
            this.labelC2.Location = new System.Drawing.Point(392, 310);
            this.labelC2.Name = "labelC2";
            this.labelC2.Size = new System.Drawing.Size(34, 13);
            this.labelC2.TabIndex = 81;
            this.labelC2.Text = "Color ";
            // 
            // labelB2
            // 
            this.labelB2.AutoSize = true;
            this.labelB2.Location = new System.Drawing.Point(227, 310);
            this.labelB2.Name = "labelB2";
            this.labelB2.Size = new System.Drawing.Size(35, 13);
            this.labelB2.TabIndex = 80;
            this.labelB2.Text = "Brand";
            // 
            // labelMD
            // 
            this.labelMD.AutoSize = true;
            this.labelMD.Location = new System.Drawing.Point(299, 310);
            this.labelMD.Name = "labelMD";
            this.labelMD.Size = new System.Drawing.Size(63, 13);
            this.labelMD.TabIndex = 79;
            this.labelMD.Text = "Made Date ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(506, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "Speed ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "Model ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 76;
            this.label8.Text = "Serial Number ";
            // 
            // Display
            // 
            this.Display.FormattingEnabled = true;
            this.Display.Location = new System.Drawing.Point(8, 335);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(796, 69);
            this.Display.TabIndex = 75;
            this.Display.SelectedIndexChanged += new System.EventHandler(this.Display_SelectedIndexChanged);
            // 
            // textBoxSeatH
            // 
            this.textBoxSeatH.Location = new System.Drawing.Point(533, 66);
            this.textBoxSeatH.Name = "textBoxSeatH";
            this.textBoxSeatH.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeatH.TabIndex = 74;
            // 
            // labelSHeight
            // 
            this.labelSHeight.AutoSize = true;
            this.labelSHeight.Location = new System.Drawing.Point(458, 69);
            this.labelSHeight.Name = "labelSHeight";
            this.labelSHeight.Size = new System.Drawing.Size(69, 13);
            this.labelSHeight.TabIndex = 73;
            this.labelSHeight.Text = "Seat Height :";
            // 
            // textBoxHFG
            // 
            this.textBoxHFG.Location = new System.Drawing.Point(537, 149);
            this.textBoxHFG.Name = "textBoxHFG";
            this.textBoxHFG.Size = new System.Drawing.Size(100, 20);
            this.textBoxHFG.TabIndex = 72;
            // 
            // labelHFG2
            // 
            this.labelHFG2.AutoSize = true;
            this.labelHFG2.Location = new System.Drawing.Point(677, 310);
            this.labelHFG2.Name = "labelHFG2";
            this.labelHFG2.Size = new System.Drawing.Size(102, 13);
            this.labelHFG2.TabIndex = 71;
            this.labelHFG2.Text = "Height From Ground";
            // 
            // comboBoxTFS
            // 
            this.comboBoxTFS.FormattingEnabled = true;
            this.comboBoxTFS.Location = new System.Drawing.Point(534, 105);
            this.comboBoxTFS.Name = "comboBoxTFS";
            this.comboBoxTFS.Size = new System.Drawing.Size(102, 21);
            this.comboBoxTFS.TabIndex = 70;
            // 
            // labelTOS
            // 
            this.labelTOS.AutoSize = true;
            this.labelTOS.Location = new System.Drawing.Point(416, 109);
            this.labelTOS.Name = "labelTOS";
            this.labelTOS.Size = new System.Drawing.Size(114, 13);
            this.labelTOS.TabIndex = 69;
            this.labelTOS.Text = "Types Of Suspension :";
            this.labelTOS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMdate
            // 
            this.labelMdate.AutoSize = true;
            this.labelMdate.Location = new System.Drawing.Point(227, 196);
            this.labelMdate.Name = "labelMdate";
            this.labelMdate.Size = new System.Drawing.Size(66, 13);
            this.labelMdate.TabIndex = 68;
            this.labelMdate.Text = "Made Date :";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(307, 69);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(96, 21);
            this.comboBoxColor.TabIndex = 67;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(261, 73);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(37, 13);
            this.labelColor.TabIndex = 66;
            this.labelColor.Text = "Color :";
            // 
            // comboBoxSpeed
            // 
            this.comboBoxSpeed.FormattingEnabled = true;
            this.comboBoxSpeed.Location = new System.Drawing.Point(306, 153);
            this.comboBoxSpeed.Name = "comboBoxSpeed";
            this.comboBoxSpeed.Size = new System.Drawing.Size(93, 21);
            this.comboBoxSpeed.TabIndex = 65;
            // 
            // LableSpeed
            // 
            this.LableSpeed.AutoSize = true;
            this.LableSpeed.Location = new System.Drawing.Point(253, 155);
            this.LableSpeed.Name = "LableSpeed";
            this.LableSpeed.Size = new System.Drawing.Size(44, 13);
            this.LableSpeed.TabIndex = 64;
            this.LableSpeed.Text = "Speed :";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(111, 108);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 63;
            // 
            // LabelModel
            // 
            this.LabelModel.AutoSize = true;
            this.LabelModel.Location = new System.Drawing.Point(63, 111);
            this.LabelModel.Name = "LabelModel";
            this.LabelModel.Size = new System.Drawing.Size(42, 13);
            this.LabelModel.TabIndex = 62;
            this.LabelModel.Text = "Model :";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(111, 193);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrand.TabIndex = 61;
            this.textBoxBrand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBrand_KeyPress);
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(65, 200);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(41, 13);
            this.labelBrand.TabIndex = 60;
            this.labelBrand.Text = "Brand :";
            // 
            // textBoxSn
            // 
            this.errorProvider1.SetError(this.textBoxSn, " Four dagits only!");
            this.textBoxSn.Location = new System.Drawing.Point(111, 67);
            this.textBoxSn.Name = "textBoxSn";
            this.textBoxSn.Size = new System.Drawing.Size(100, 20);
            this.textBoxSn.TabIndex = 59;
            this.textBoxSn.TextChanged += new System.EventHandler(this.TextBoxSn_TextChanged);
            // 
            // radioButtonMountain
            // 
            this.radioButtonMountain.AutoSize = true;
            this.radioButtonMountain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMountain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButtonMountain.Location = new System.Drawing.Point(251, 14);
            this.radioButtonMountain.Name = "radioButtonMountain";
            this.radioButtonMountain.Size = new System.Drawing.Size(128, 24);
            this.radioButtonMountain.TabIndex = 56;
            this.radioButtonMountain.TabStop = true;
            this.radioButtonMountain.Text = "Mountian Bike";
            this.radioButtonMountain.UseVisualStyleBackColor = true;
            this.radioButtonMountain.Click += new System.EventHandler(this.RadioButtonMountain_CheckedChanged);
            // 
            // LabelSn
            // 
            this.LabelSn.AutoSize = true;
            this.LabelSn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSn.Location = new System.Drawing.Point(39, 72);
            this.LabelSn.Name = "LabelSn";
            this.LabelSn.Size = new System.Drawing.Size(60, 13);
            this.LabelSn.TabIndex = 58;
            this.LabelSn.Text = "S-Number :";
            // 
            // radioButtonRoad
            // 
            this.radioButtonRoad.AutoSize = true;
            this.radioButtonRoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRoad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButtonRoad.Location = new System.Drawing.Point(405, 14);
            this.radioButtonRoad.Name = "radioButtonRoad";
            this.radioButtonRoad.Size = new System.Drawing.Size(101, 24);
            this.radioButtonRoad.TabIndex = 57;
            this.radioButtonRoad.TabStop = true;
            this.radioButtonRoad.Text = "Road Bike";
            this.radioButtonRoad.UseVisualStyleBackColor = true;
            this.radioButtonRoad.Click += new System.EventHandler(this.RadioButtonRoad_CheckedChanged);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(665, 95);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(75, 23);
            this.ButtonReset.TabIndex = 107;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 108;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 109;
            this.label2.Text = "-";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(5, 20);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(58, 23);
            this.buttonStart.TabIndex = 110;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // buttonstop
            // 
            this.buttonstop.Location = new System.Drawing.Point(6, 50);
            this.buttonstop.Name = "buttonstop";
            this.buttonstop.Size = new System.Drawing.Size(57, 23);
            this.buttonstop.TabIndex = 111;
            this.buttonstop.Text = "Stop";
            this.buttonstop.UseVisualStyleBackColor = true;
            this.buttonstop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // buttonAcce
            // 
            this.buttonAcce.Location = new System.Drawing.Point(6, 80);
            this.buttonAcce.Name = "buttonAcce";
            this.buttonAcce.Size = new System.Drawing.Size(57, 23);
            this.buttonAcce.TabIndex = 112;
            this.buttonAcce.Text = "Accelerate";
            this.buttonAcce.UseVisualStyleBackColor = true;
            this.buttonAcce.Click += new System.EventHandler(this.buttonAcce_Click);
            // 
            // buttonBrake
            // 
            this.buttonBrake.Location = new System.Drawing.Point(6, 110);
            this.buttonBrake.Name = "buttonBrake";
            this.buttonBrake.Size = new System.Drawing.Size(57, 23);
            this.buttonBrake.TabIndex = 113;
            this.buttonBrake.Text = "Brake";
            this.buttonBrake.UseVisualStyleBackColor = true;
            this.buttonBrake.Click += new System.EventHandler(this.buttonBrake_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAcce);
            this.groupBox1.Controls.Add(this.buttonBrake);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Controls.Add(this.buttonstop);
            this.groupBox1.Location = new System.Drawing.Point(766, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(76, 143);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interface:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 430);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.labelTOS2);
            this.Controls.Add(this.labelSH2);
            this.Controls.Add(this.ButtonReadXF);
            this.Controls.Add(this.ButtonWriteXF);
            this.Controls.Add(this.buttonDisplayR);
            this.Controls.Add(this.buttonDisplayM);
            this.Controls.Add(this.buttonDisplayAll);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelESF);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.labelWH2);
            this.Controls.Add(this.labelW2);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.comboBoxWheel);
            this.Controls.Add(this.labelWheel);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelHFG);
            this.Controls.Add(this.labelC2);
            this.Controls.Add(this.labelB2);
            this.Controls.Add(this.labelMD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.textBoxSeatH);
            this.Controls.Add(this.labelSHeight);
            this.Controls.Add(this.textBoxHFG);
            this.Controls.Add(this.labelHFG2);
            this.Controls.Add(this.comboBoxTFS);
            this.Controls.Add(this.labelTOS);
            this.Controls.Add(this.labelMdate);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.comboBoxSpeed);
            this.Controls.Add(this.LableSpeed);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.LabelModel);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.textBoxSn);
            this.Controls.Add(this.radioButtonMountain);
            this.Controls.Add(this.LabelSn);
            this.Controls.Add(this.radioButtonRoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Label labelTOS2;
        private System.Windows.Forms.Label labelSH2;
        private System.Windows.Forms.Button ButtonReadXF;
        private System.Windows.Forms.Button ButtonWriteXF;
        private System.Windows.Forms.Button buttonDisplayR;
        private System.Windows.Forms.Button buttonDisplayM;
        private System.Windows.Forms.Button buttonDisplayAll;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelESF;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label labelWH2;
        private System.Windows.Forms.Label labelW2;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.ComboBox comboBoxWheel;
        private System.Windows.Forms.Label labelWheel;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelHFG;
        private System.Windows.Forms.Label labelC2;
        private System.Windows.Forms.Label labelB2;
        private System.Windows.Forms.Label labelMD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox Display;
        private System.Windows.Forms.TextBox textBoxSeatH;
        private System.Windows.Forms.Label labelSHeight;
        private System.Windows.Forms.TextBox textBoxHFG;
        private System.Windows.Forms.Label labelHFG2;
        private System.Windows.Forms.ComboBox comboBoxTFS;
        private System.Windows.Forms.Label labelTOS;
        private System.Windows.Forms.Label labelMdate;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ComboBox comboBoxSpeed;
        private System.Windows.Forms.Label LableSpeed;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label LabelModel;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.TextBox textBoxSn;
        private System.Windows.Forms.RadioButton radioButtonMountain;
        private System.Windows.Forms.Label LabelSn;
        private System.Windows.Forms.RadioButton radioButtonRoad;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAcce;
        private System.Windows.Forms.Button buttonBrake;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonstop;
    }
}

