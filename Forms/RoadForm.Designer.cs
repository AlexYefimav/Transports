namespace Transports
{
    partial class RoadForm
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
            this.one = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.type = new System.Windows.Forms.GroupBox();
            this.oneType = new System.Windows.Forms.ComboBox();
            this.twoType = new System.Windows.Forms.ComboBox();
            this.fiveType = new System.Windows.Forms.ComboBox();
            this.threeType = new System.Windows.Forms.ComboBox();
            this.fourType = new System.Windows.Forms.ComboBox();
            this.logs = new System.Windows.Forms.GroupBox();
            this.road1 = new System.Windows.Forms.Button();
            this.road5 = new System.Windows.Forms.Button();
            this.road3 = new System.Windows.Forms.Button();
            this.road4 = new System.Windows.Forms.Button();
            this.road2 = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.TextBox();
            this.four = new System.Windows.Forms.TextBox();
            this.three = new System.Windows.Forms.TextBox();
            this.two = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.type.SuspendLayout();
            this.logs.SuspendLayout();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(6, 28);
            this.one.Name = "one";
            this.one.ReadOnly = true;
            this.one.Size = new System.Drawing.Size(1116, 29);
            this.one.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.logs);
            this.groupBox1.Controls.Add(this.stop);
            this.groupBox1.Controls.Add(this.start);
            this.groupBox1.Controls.Add(this.five);
            this.groupBox1.Controls.Add(this.four);
            this.groupBox1.Controls.Add(this.three);
            this.groupBox1.Controls.Add(this.two);
            this.groupBox1.Controls.Add(this.one);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1442, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дороги";
            // 
            // type
            // 
            this.type.Controls.Add(this.oneType);
            this.type.Controls.Add(this.twoType);
            this.type.Controls.Add(this.fiveType);
            this.type.Controls.Add(this.threeType);
            this.type.Controls.Add(this.fourType);
            this.type.Location = new System.Drawing.Point(1128, 0);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(263, 398);
            this.type.TabIndex = 18;
            this.type.TabStop = false;
            this.type.Text = "Вид";
            // 
            // oneType
            // 
            this.oneType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oneType.FormattingEnabled = true;
            this.oneType.Location = new System.Drawing.Point(6, 25);
            this.oneType.Name = "oneType";
            this.oneType.Size = new System.Drawing.Size(251, 32);
            this.oneType.TabIndex = 7;
            this.oneType.SelectedIndexChanged += new System.EventHandler(this.OneType_SelectedIndexChanged);
            // 
            // twoType
            // 
            this.twoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.twoType.FormattingEnabled = true;
            this.twoType.Location = new System.Drawing.Point(6, 60);
            this.twoType.Name = "twoType";
            this.twoType.Size = new System.Drawing.Size(251, 32);
            this.twoType.TabIndex = 8;
            this.twoType.SelectedIndexChanged += new System.EventHandler(this.TwoType_SelectedIndexChanged);
            // 
            // fiveType
            // 
            this.fiveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fiveType.FormattingEnabled = true;
            this.fiveType.Location = new System.Drawing.Point(6, 165);
            this.fiveType.Name = "fiveType";
            this.fiveType.Size = new System.Drawing.Size(251, 32);
            this.fiveType.TabIndex = 11;
            this.fiveType.SelectedIndexChanged += new System.EventHandler(this.FiveType_SelectedIndexChanged);
            // 
            // threeType
            // 
            this.threeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.threeType.FormattingEnabled = true;
            this.threeType.Location = new System.Drawing.Point(6, 95);
            this.threeType.Name = "threeType";
            this.threeType.Size = new System.Drawing.Size(251, 32);
            this.threeType.TabIndex = 9;
            this.threeType.SelectedIndexChanged += new System.EventHandler(this.ThreeType_SelectedIndexChanged);
            // 
            // fourType
            // 
            this.fourType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fourType.FormattingEnabled = true;
            this.fourType.Location = new System.Drawing.Point(6, 130);
            this.fourType.Name = "fourType";
            this.fourType.Size = new System.Drawing.Size(251, 32);
            this.fourType.TabIndex = 10;
            this.fourType.SelectedIndexChanged += new System.EventHandler(this.FourType_SelectedIndexChanged);
            // 
            // logs
            // 
            this.logs.Controls.Add(this.road1);
            this.logs.Controls.Add(this.road5);
            this.logs.Controls.Add(this.road3);
            this.logs.Controls.Add(this.road4);
            this.logs.Controls.Add(this.road2);
            this.logs.Enabled = false;
            this.logs.Location = new System.Drawing.Point(479, 203);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(501, 195);
            this.logs.TabIndex = 17;
            this.logs.TabStop = false;
            this.logs.Text = "Логи";
            // 
            // road1
            // 
            this.road1.Location = new System.Drawing.Point(20, 28);
            this.road1.Name = "road1";
            this.road1.Size = new System.Drawing.Size(217, 46);
            this.road1.TabIndex = 12;
            this.road1.Text = "Дорога 1";
            this.road1.UseVisualStyleBackColor = true;
            this.road1.Click += new System.EventHandler(this.Road1_Click);
            // 
            // road5
            // 
            this.road5.Location = new System.Drawing.Point(141, 130);
            this.road5.Name = "road5";
            this.road5.Size = new System.Drawing.Size(217, 44);
            this.road5.TabIndex = 16;
            this.road5.Text = "Дорога 5";
            this.road5.UseVisualStyleBackColor = true;
            this.road5.Click += new System.EventHandler(this.Road5_Click);
            // 
            // road3
            // 
            this.road3.Location = new System.Drawing.Point(20, 80);
            this.road3.Name = "road3";
            this.road3.Size = new System.Drawing.Size(217, 44);
            this.road3.TabIndex = 13;
            this.road3.Text = "Дорога 3";
            this.road3.UseVisualStyleBackColor = true;
            this.road3.Click += new System.EventHandler(this.Road3_Click);
            // 
            // road4
            // 
            this.road4.Location = new System.Drawing.Point(243, 80);
            this.road4.Name = "road4";
            this.road4.Size = new System.Drawing.Size(217, 44);
            this.road4.TabIndex = 15;
            this.road4.Text = "Дорога 4";
            this.road4.UseVisualStyleBackColor = true;
            this.road4.Click += new System.EventHandler(this.Road4_Click);
            // 
            // road2
            // 
            this.road2.Location = new System.Drawing.Point(243, 28);
            this.road2.Name = "road2";
            this.road2.Size = new System.Drawing.Size(217, 46);
            this.road2.TabIndex = 14;
            this.road2.Text = "Дорога 2";
            this.road2.UseVisualStyleBackColor = true;
            this.road2.Click += new System.EventHandler(this.Road2_Click);
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.Location = new System.Drawing.Point(6, 255);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(217, 44);
            this.stop.TabIndex = 6;
            this.stop.Text = "Стоп";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.Location = new System.Drawing.Point(6, 203);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(217, 46);
            this.start.TabIndex = 5;
            this.start.Text = "Старт";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.Start_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(6, 168);
            this.five.Name = "five";
            this.five.ReadOnly = true;
            this.five.Size = new System.Drawing.Size(1116, 29);
            this.five.TabIndex = 4;
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(6, 133);
            this.four.Name = "four";
            this.four.ReadOnly = true;
            this.four.Size = new System.Drawing.Size(1116, 29);
            this.four.TabIndex = 3;
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(6, 98);
            this.three.Name = "three";
            this.three.ReadOnly = true;
            this.three.Size = new System.Drawing.Size(1116, 29);
            this.three.TabIndex = 2;
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(6, 63);
            this.two.Name = "two";
            this.two.ReadOnly = true;
            this.two.Size = new System.Drawing.Size(1116, 29);
            this.two.TabIndex = 1;
            // 
            // RoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "RoadForm";
            this.Text = "Road";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.type.ResumeLayout(false);
            this.logs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox one;
        public System.Windows.Forms.TextBox five;
        public System.Windows.Forms.TextBox four;
        public System.Windows.Forms.TextBox three;
        public System.Windows.Forms.TextBox two;
        public System.Windows.Forms.ComboBox fiveType;
        public System.Windows.Forms.ComboBox fourType;
        public System.Windows.Forms.ComboBox threeType;
        public System.Windows.Forms.ComboBox twoType;
        public System.Windows.Forms.ComboBox oneType;
        public System.Windows.Forms.Button stop;
        public System.Windows.Forms.Button start;
        public System.Windows.Forms.Button road1;
        public System.Windows.Forms.Button road5;
        public System.Windows.Forms.Button road3;
        public System.Windows.Forms.Button road4;
        public System.Windows.Forms.Button road2;
        public System.Windows.Forms.GroupBox logs;
        private System.Windows.Forms.GroupBox type;
    }
}