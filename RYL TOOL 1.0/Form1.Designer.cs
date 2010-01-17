namespace RYL_TOOL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboRaca = new System.Windows.Forms.ComboBox();
            this.comboClasse = new System.Windows.Forms.ComboBox();
            this.comboLvl = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelStatWIS = new System.Windows.Forms.Label();
            this.labelStatINT = new System.Windows.Forms.Label();
            this.labelStatDEX = new System.Windows.Forms.Label();
            this.labelStatCON = new System.Windows.Forms.Label();
            this.labelStatSTR = new System.Windows.Forms.Label();
            this.wis = new System.Windows.Forms.Label();
            this.inte = new System.Windows.Forms.Label();
            this.dex = new System.Windows.Forms.Label();
            this.con = new System.Windows.Forms.Label();
            this.str = new System.Windows.Forms.Label();
            this.comboSTR = new System.Windows.Forms.ComboBox();
            this.comboCON = new System.Windows.Forms.ComboBox();
            this.comboDEX = new System.Windows.Forms.ComboBox();
            this.comboINT = new System.Windows.Forms.ComboBox();
            this.comboWIS = new System.Windows.Forms.ComboBox();
            this.bPointsValue = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.rYLFusionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skillTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nation:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bonus Points:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stats";
            // 
            // comboRaca
            // 
            this.comboRaca.FormattingEnabled = true;
            this.comboRaca.Items.AddRange(new object[] {
            "Merkhadian (Ak\'kan)",
            "Karthefant (Human)"});
            this.comboRaca.Location = new System.Drawing.Point(59, 10);
            this.comboRaca.Name = "comboRaca";
            this.comboRaca.Size = new System.Drawing.Size(133, 21);
            this.comboRaca.TabIndex = 10;
            this.comboRaca.Text = "Select";
            this.comboRaca.SelectedIndexChanged += new System.EventHandler(this.comboRaca_SelectedIndexChanged);
            // 
            // comboClasse
            // 
            this.comboClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClasse.FormattingEnabled = true;
            this.comboClasse.Location = new System.Drawing.Point(59, 45);
            this.comboClasse.Name = "comboClasse";
            this.comboClasse.Size = new System.Drawing.Size(133, 21);
            this.comboClasse.TabIndex = 11;
            this.comboClasse.SelectedIndexChanged += new System.EventHandler(this.comboClasse_SelectedIndexChanged);
            // 
            // comboLvl
            // 
            this.comboLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLvl.FormattingEnabled = true;
            this.comboLvl.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126"});
            this.comboLvl.Location = new System.Drawing.Point(59, 79);
            this.comboLvl.MaxDropDownItems = 12;
            this.comboLvl.Name = "comboLvl";
            this.comboLvl.Size = new System.Drawing.Size(74, 21);
            this.comboLvl.TabIndex = 12;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(139, 79);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(53, 21);
            this.buttonOK.TabIndex = 13;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelStatWIS
            // 
            this.labelStatWIS.AutoSize = true;
            this.labelStatWIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatWIS.Location = new System.Drawing.Point(49, 300);
            this.labelStatWIS.Name = "labelStatWIS";
            this.labelStatWIS.Size = new System.Drawing.Size(14, 13);
            this.labelStatWIS.TabIndex = 48;
            this.labelStatWIS.Text = "0";
            // 
            // labelStatINT
            // 
            this.labelStatINT.AutoSize = true;
            this.labelStatINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatINT.Location = new System.Drawing.Point(49, 273);
            this.labelStatINT.Name = "labelStatINT";
            this.labelStatINT.Size = new System.Drawing.Size(14, 13);
            this.labelStatINT.TabIndex = 47;
            this.labelStatINT.Text = "0";
            // 
            // labelStatDEX
            // 
            this.labelStatDEX.AutoSize = true;
            this.labelStatDEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatDEX.Location = new System.Drawing.Point(49, 245);
            this.labelStatDEX.Name = "labelStatDEX";
            this.labelStatDEX.Size = new System.Drawing.Size(14, 13);
            this.labelStatDEX.TabIndex = 46;
            this.labelStatDEX.Text = "0";
            // 
            // labelStatCON
            // 
            this.labelStatCON.AutoSize = true;
            this.labelStatCON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatCON.Location = new System.Drawing.Point(49, 218);
            this.labelStatCON.Name = "labelStatCON";
            this.labelStatCON.Size = new System.Drawing.Size(14, 13);
            this.labelStatCON.TabIndex = 45;
            this.labelStatCON.Text = "0";
            // 
            // labelStatSTR
            // 
            this.labelStatSTR.AutoSize = true;
            this.labelStatSTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatSTR.Location = new System.Drawing.Point(49, 191);
            this.labelStatSTR.Name = "labelStatSTR";
            this.labelStatSTR.Size = new System.Drawing.Size(14, 13);
            this.labelStatSTR.TabIndex = 44;
            this.labelStatSTR.Text = "0";
            // 
            // wis
            // 
            this.wis.AutoSize = true;
            this.wis.Location = new System.Drawing.Point(13, 300);
            this.wis.Name = "wis";
            this.wis.Size = new System.Drawing.Size(28, 13);
            this.wis.TabIndex = 43;
            this.wis.Text = "Wis:";
            // 
            // inte
            // 
            this.inte.AutoSize = true;
            this.inte.Location = new System.Drawing.Point(13, 273);
            this.inte.Name = "inte";
            this.inte.Size = new System.Drawing.Size(22, 13);
            this.inte.TabIndex = 42;
            this.inte.Text = "Int:";
            // 
            // dex
            // 
            this.dex.AutoSize = true;
            this.dex.Location = new System.Drawing.Point(13, 245);
            this.dex.Name = "dex";
            this.dex.Size = new System.Drawing.Size(29, 13);
            this.dex.TabIndex = 41;
            this.dex.Text = "Dex:";
            // 
            // con
            // 
            this.con.AutoSize = true;
            this.con.Location = new System.Drawing.Point(13, 218);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(29, 13);
            this.con.TabIndex = 40;
            this.con.Text = "Con:";
            // 
            // str
            // 
            this.str.AutoSize = true;
            this.str.Location = new System.Drawing.Point(13, 191);
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(23, 13);
            this.str.TabIndex = 39;
            this.str.Text = "Str:";
            // 
            // comboSTR
            // 
            this.comboSTR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSTR.FormattingEnabled = true;
            this.comboSTR.Location = new System.Drawing.Point(93, 188);
            this.comboSTR.MaxDropDownItems = 10;
            this.comboSTR.Name = "comboSTR";
            this.comboSTR.Size = new System.Drawing.Size(69, 21);
            this.comboSTR.TabIndex = 49;
            this.comboSTR.SelectedIndexChanged += new System.EventHandler(this.comboSTR_SelectedIndexChanged);
            // 
            // comboCON
            // 
            this.comboCON.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCON.FormattingEnabled = true;
            this.comboCON.Location = new System.Drawing.Point(93, 215);
            this.comboCON.MaxDropDownItems = 10;
            this.comboCON.Name = "comboCON";
            this.comboCON.Size = new System.Drawing.Size(69, 21);
            this.comboCON.TabIndex = 50;
            this.comboCON.SelectedIndexChanged += new System.EventHandler(this.comboCON_SelectedIndexChanged);
            // 
            // comboDEX
            // 
            this.comboDEX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDEX.FormattingEnabled = true;
            this.comboDEX.Location = new System.Drawing.Point(93, 242);
            this.comboDEX.MaxDropDownItems = 10;
            this.comboDEX.Name = "comboDEX";
            this.comboDEX.Size = new System.Drawing.Size(69, 21);
            this.comboDEX.TabIndex = 51;
            this.comboDEX.SelectedIndexChanged += new System.EventHandler(this.comboDEX_SelectedIndexChanged);
            // 
            // comboINT
            // 
            this.comboINT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboINT.FormattingEnabled = true;
            this.comboINT.Location = new System.Drawing.Point(93, 270);
            this.comboINT.MaxDropDownItems = 10;
            this.comboINT.Name = "comboINT";
            this.comboINT.Size = new System.Drawing.Size(69, 21);
            this.comboINT.TabIndex = 52;
            this.comboINT.SelectedIndexChanged += new System.EventHandler(this.comboINT_SelectedIndexChanged);
            // 
            // comboWIS
            // 
            this.comboWIS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWIS.FormattingEnabled = true;
            this.comboWIS.Location = new System.Drawing.Point(93, 297);
            this.comboWIS.MaxDropDownItems = 10;
            this.comboWIS.Name = "comboWIS";
            this.comboWIS.Size = new System.Drawing.Size(69, 21);
            this.comboWIS.TabIndex = 53;
            this.comboWIS.SelectedIndexChanged += new System.EventHandler(this.comboWIS_SelectedIndexChanged);
            // 
            // bPointsValue
            // 
            this.bPointsValue.AutoSize = true;
            this.bPointsValue.Location = new System.Drawing.Point(91, 125);
            this.bPointsValue.Name = "bPointsValue";
            this.bPointsValue.Size = new System.Drawing.Size(13, 13);
            this.bPointsValue.TabIndex = 54;
            this.bPointsValue.Text = "0";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(211, 22);
            this.statusStrip1.TabIndex = 57;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem2,
            this.rYLFusionToolStripMenuItem,
            this.skillTableToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(46, 20);
            this.toolStripDropDownButton1.Text = "Menu";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // aboutToolStripMenuItem2
            // 
            this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            this.aboutToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem2.Text = "About";
            this.aboutToolStripMenuItem2.Click += new System.EventHandler(this.aboutToolStripMenuItem2_Click);
            // 
            // rYLFusionToolStripMenuItem
            // 
            this.rYLFusionToolStripMenuItem.Name = "rYLFusionToolStripMenuItem";
            this.rYLFusionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rYLFusionToolStripMenuItem.Text = "RYL Fusion";
            this.rYLFusionToolStripMenuItem.Click += new System.EventHandler(this.rYLFusionToolStripMenuItem_Click);
            // 
            // skillTableToolStripMenuItem
            // 
            this.skillTableToolStripMenuItem.Name = "skillTableToolStripMenuItem";
            this.skillTableToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.skillTableToolStripMenuItem.Text = "Skill Table";
            this.skillTableToolStripMenuItem.Click += new System.EventHandler(this.skillTableToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 361);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bPointsValue);
            this.Controls.Add(this.comboWIS);
            this.Controls.Add(this.comboINT);
            this.Controls.Add(this.comboDEX);
            this.Controls.Add(this.comboCON);
            this.Controls.Add(this.comboSTR);
            this.Controls.Add(this.labelStatWIS);
            this.Controls.Add(this.labelStatINT);
            this.Controls.Add(this.labelStatDEX);
            this.Controls.Add(this.labelStatCON);
            this.Controls.Add(this.labelStatSTR);
            this.Controls.Add(this.wis);
            this.Controls.Add(this.inte);
            this.Controls.Add(this.dex);
            this.Controls.Add(this.con);
            this.Controls.Add(this.str);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboLvl);
            this.Controls.Add(this.comboClasse);
            this.Controls.Add(this.comboRaca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(219, 390);
            this.MinimumSize = new System.Drawing.Size(219, 390);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RYL Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboRaca;
        private System.Windows.Forms.ComboBox comboClasse;
        private System.Windows.Forms.ComboBox comboLvl;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelStatWIS;
        private System.Windows.Forms.Label labelStatINT;
        private System.Windows.Forms.Label labelStatDEX;
        private System.Windows.Forms.Label labelStatCON;
        private System.Windows.Forms.Label labelStatSTR;
        private System.Windows.Forms.Label wis;
        private System.Windows.Forms.Label inte;
        private System.Windows.Forms.Label dex;
        private System.Windows.Forms.Label con;
        private System.Windows.Forms.Label str;
        private System.Windows.Forms.ComboBox comboSTR;
        private System.Windows.Forms.ComboBox comboCON;
        private System.Windows.Forms.ComboBox comboDEX;
        private System.Windows.Forms.ComboBox comboINT;
        private System.Windows.Forms.ComboBox comboWIS;
        private System.Windows.Forms.Label bPointsValue;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem rYLFusionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skillTableToolStripMenuItem;
    }
}

