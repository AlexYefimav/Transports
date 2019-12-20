namespace Transports
{
    partial class SelectTransport
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
            this.transportGroup = new System.Windows.Forms.GroupBox();
            this.sb = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.GroupBox();
            this.saveData = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.maxSpeed = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.startSpeed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.stamina = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ownerAge = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.passangerCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.GroupBox();
            this.sco = new System.Windows.Forms.RadioButton();
            this.tan = new System.Windows.Forms.RadioButton();
            this.cart = new System.Windows.Forms.RadioButton();
            this.tra = new System.Windows.Forms.RadioButton();
            this.tro = new System.Windows.Forms.RadioButton();
            this.vel = new System.Windows.Forms.RadioButton();
            this.loa = new System.Windows.Forms.RadioButton();
            this.bus = new System.Windows.Forms.RadioButton();
            this.car = new System.Windows.Forms.RadioButton();
            this.mot = new System.Windows.Forms.RadioButton();
            this.fuelTypeBtn = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.GroupBox();
            this.transpOne = new System.Windows.Forms.RadioButton();
            this.transpTwo = new System.Windows.Forms.RadioButton();
            this.transpFive = new System.Windows.Forms.RadioButton();
            this.transpThree = new System.Windows.Forms.RadioButton();
            this.transpFour = new System.Windows.Forms.RadioButton();
            this.transportGroup.SuspendLayout();
            this.data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stamina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passangerCount)).BeginInit();
            this.type.SuspendLayout();
            this.num.SuspendLayout();
            this.SuspendLayout();
            // 
            // transportGroup
            // 
            this.transportGroup.Controls.Add(this.sb);
            this.transportGroup.Controls.Add(this.data);
            this.transportGroup.Controls.Add(this.type);
            this.transportGroup.Controls.Add(this.fuelTypeBtn);
            this.transportGroup.Controls.Add(this.num);
            this.transportGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transportGroup.Location = new System.Drawing.Point(12, 12);
            this.transportGroup.Name = "transportGroup";
            this.transportGroup.Size = new System.Drawing.Size(997, 405);
            this.transportGroup.TabIndex = 6;
            this.transportGroup.TabStop = false;
            this.transportGroup.Text = "Транспорт";
            // 
            // sb
            // 
            this.sb.Location = new System.Drawing.Point(15, 28);
            this.sb.Name = "sb";
            this.sb.ReadOnly = true;
            this.sb.Size = new System.Drawing.Size(969, 29);
            this.sb.TabIndex = 15;
            // 
            // data
            // 
            this.data.Controls.Add(this.saveData);
            this.data.Controls.Add(this.label6);
            this.data.Controls.Add(this.maxSpeed);
            this.data.Controls.Add(this.label5);
            this.data.Controls.Add(this.startSpeed);
            this.data.Controls.Add(this.label4);
            this.data.Controls.Add(this.stamina);
            this.data.Controls.Add(this.label2);
            this.data.Controls.Add(this.ownerAge);
            this.data.Controls.Add(this.label3);
            this.data.Controls.Add(this.passangerCount);
            this.data.Controls.Add(this.label1);
            this.data.Controls.Add(this.model);
            this.data.Location = new System.Drawing.Point(639, 63);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(345, 287);
            this.data.TabIndex = 16;
            this.data.TabStop = false;
            this.data.Text = "Данные";
            // 
            // saveData
            // 
            this.saveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveData.Location = new System.Drawing.Point(10, 237);
            this.saveData.Name = "saveData";
            this.saveData.Size = new System.Drawing.Size(327, 42);
            this.saveData.TabIndex = 17;
            this.saveData.Text = "Выбрать";
            this.saveData.UseVisualStyleBackColor = true;
            this.saveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Макс. скор.:";
            // 
            // maxSpeed
            // 
            this.maxSpeed.Location = new System.Drawing.Point(202, 202);
            this.maxSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxSpeed.Name = "maxSpeed";
            this.maxSpeed.Size = new System.Drawing.Size(72, 29);
            this.maxSpeed.TabIndex = 13;
            this.maxSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Начальная скор.:";
            // 
            // startSpeed
            // 
            this.startSpeed.Location = new System.Drawing.Point(202, 168);
            this.startSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startSpeed.Name = "startSpeed";
            this.startSpeed.Size = new System.Drawing.Size(72, 29);
            this.startSpeed.TabIndex = 11;
            this.startSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Км без остановки:";
            // 
            // stamina
            // 
            this.stamina.Location = new System.Drawing.Point(202, 134);
            this.stamina.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.stamina.Name = "stamina";
            this.stamina.Size = new System.Drawing.Size(72, 29);
            this.stamina.TabIndex = 9;
            this.stamina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Возраст владельца:";
            // 
            // ownerAge
            // 
            this.ownerAge.Location = new System.Drawing.Point(202, 100);
            this.ownerAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ownerAge.Name = "ownerAge";
            this.ownerAge.Size = new System.Drawing.Size(72, 29);
            this.ownerAge.TabIndex = 7;
            this.ownerAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кол-во пассажиров:";
            // 
            // passangerCount
            // 
            this.passangerCount.Location = new System.Drawing.Point(202, 62);
            this.passangerCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.passangerCount.Name = "passangerCount";
            this.passangerCount.Size = new System.Drawing.Size(72, 29);
            this.passangerCount.TabIndex = 5;
            this.passangerCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Модель";
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(139, 22);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(135, 29);
            this.model.TabIndex = 1;
            // 
            // type
            // 
            this.type.Controls.Add(this.sco);
            this.type.Controls.Add(this.tan);
            this.type.Controls.Add(this.cart);
            this.type.Controls.Add(this.tra);
            this.type.Controls.Add(this.tro);
            this.type.Controls.Add(this.vel);
            this.type.Controls.Add(this.loa);
            this.type.Controls.Add(this.bus);
            this.type.Controls.Add(this.car);
            this.type.Controls.Add(this.mot);
            this.type.Location = new System.Drawing.Point(114, 63);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(519, 287);
            this.type.TabIndex = 6;
            this.type.TabStop = false;
            this.type.Text = "Вид";
            // 
            // sco
            // 
            this.sco.AutoSize = true;
            this.sco.Location = new System.Drawing.Point(239, 28);
            this.sco.Name = "sco";
            this.sco.Size = new System.Drawing.Size(106, 28);
            this.sco.TabIndex = 10;
            this.sco.TabStop = true;
            this.sco.Text = "6 Скутер";
            this.sco.UseVisualStyleBackColor = true;
            // 
            // tan
            // 
            this.tan.AutoSize = true;
            this.tan.Location = new System.Drawing.Point(239, 62);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(85, 28);
            this.tan.TabIndex = 11;
            this.tan.TabStop = true;
            this.tan.Text = "7 Танк";
            this.tan.UseVisualStyleBackColor = true;
            // 
            // cart
            // 
            this.cart.AutoSize = true;
            this.cart.Location = new System.Drawing.Point(239, 164);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(128, 28);
            this.cart.TabIndex = 14;
            this.cart.TabStop = true;
            this.cart.Text = "10 Повозка";
            this.cart.UseVisualStyleBackColor = true;
            // 
            // tra
            // 
            this.tra.AutoSize = true;
            this.tra.Location = new System.Drawing.Point(239, 96);
            this.tra.Name = "tra";
            this.tra.Size = new System.Drawing.Size(121, 28);
            this.tra.TabIndex = 12;
            this.tra.TabStop = true;
            this.tra.Text = "8 Трамвай";
            this.tra.UseVisualStyleBackColor = true;
            // 
            // tro
            // 
            this.tro.AutoSize = true;
            this.tro.Location = new System.Drawing.Point(239, 130);
            this.tro.Name = "tro";
            this.tro.Size = new System.Drawing.Size(149, 28);
            this.tro.TabIndex = 13;
            this.tro.TabStop = true;
            this.tro.Text = "9 Троллейбус";
            this.tro.UseVisualStyleBackColor = true;
            // 
            // vel
            // 
            this.vel.AutoSize = true;
            this.vel.Location = new System.Drawing.Point(6, 28);
            this.vel.Name = "vel";
            this.vel.Size = new System.Drawing.Size(142, 28);
            this.vel.TabIndex = 5;
            this.vel.TabStop = true;
            this.vel.Text = "1 Велосипед";
            this.vel.UseVisualStyleBackColor = true;
            // 
            // loa
            // 
            this.loa.AutoSize = true;
            this.loa.Location = new System.Drawing.Point(6, 130);
            this.loa.Name = "loa";
            this.loa.Size = new System.Drawing.Size(129, 28);
            this.loa.TabIndex = 8;
            this.loa.TabStop = true;
            this.loa.Text = "4 Погрущик";
            this.loa.UseVisualStyleBackColor = true;
            // 
            // bus
            // 
            this.bus.AutoSize = true;
            this.bus.Location = new System.Drawing.Point(6, 62);
            this.bus.Name = "bus";
            this.bus.Size = new System.Drawing.Size(118, 28);
            this.bus.TabIndex = 6;
            this.bus.TabStop = true;
            this.bus.Text = "2 Автобус";
            this.bus.UseVisualStyleBackColor = true;
            // 
            // car
            // 
            this.car.AutoSize = true;
            this.car.Location = new System.Drawing.Point(6, 96);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(88, 28);
            this.car.TabIndex = 7;
            this.car.TabStop = true;
            this.car.Text = "3 Авто";
            this.car.UseVisualStyleBackColor = true;
            // 
            // mot
            // 
            this.mot.AutoSize = true;
            this.mot.Location = new System.Drawing.Point(6, 164);
            this.mot.Name = "mot";
            this.mot.Size = new System.Drawing.Size(132, 28);
            this.mot.TabIndex = 9;
            this.mot.TabStop = true;
            this.mot.Text = "5 Мотоцикл";
            this.mot.UseVisualStyleBackColor = true;
            // 
            // fuelTypeBtn
            // 
            this.fuelTypeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fuelTypeBtn.Location = new System.Drawing.Point(15, 356);
            this.fuelTypeBtn.Name = "fuelTypeBtn";
            this.fuelTypeBtn.Size = new System.Drawing.Size(969, 42);
            this.fuelTypeBtn.TabIndex = 5;
            this.fuelTypeBtn.Text = "Выбрать";
            this.fuelTypeBtn.UseVisualStyleBackColor = true;
            this.fuelTypeBtn.Click += new System.EventHandler(this.FuelTypeBtn_Click);
            // 
            // num
            // 
            this.num.Controls.Add(this.transpOne);
            this.num.Controls.Add(this.transpTwo);
            this.num.Controls.Add(this.transpFive);
            this.num.Controls.Add(this.transpThree);
            this.num.Controls.Add(this.transpFour);
            this.num.Location = new System.Drawing.Point(15, 63);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(93, 287);
            this.num.TabIndex = 5;
            this.num.TabStop = false;
            this.num.Text = "Номер";
            // 
            // transpOne
            // 
            this.transpOne.AutoSize = true;
            this.transpOne.Location = new System.Drawing.Point(6, 28);
            this.transpOne.Name = "transpOne";
            this.transpOne.Size = new System.Drawing.Size(73, 28);
            this.transpOne.TabIndex = 0;
            this.transpOne.TabStop = true;
            this.transpOne.Text = "1 -ый";
            this.transpOne.UseVisualStyleBackColor = true;
            // 
            // transpTwo
            // 
            this.transpTwo.AutoSize = true;
            this.transpTwo.Location = new System.Drawing.Point(6, 62);
            this.transpTwo.Name = "transpTwo";
            this.transpTwo.Size = new System.Drawing.Size(71, 28);
            this.transpTwo.TabIndex = 1;
            this.transpTwo.TabStop = true;
            this.transpTwo.Text = "2 -ой";
            this.transpTwo.UseVisualStyleBackColor = true;
            // 
            // transpFive
            // 
            this.transpFive.AutoSize = true;
            this.transpFive.Location = new System.Drawing.Point(6, 164);
            this.transpFive.Name = "transpFive";
            this.transpFive.Size = new System.Drawing.Size(73, 28);
            this.transpFive.TabIndex = 4;
            this.transpFive.TabStop = true;
            this.transpFive.Text = "5 -ый";
            this.transpFive.UseVisualStyleBackColor = true;
            // 
            // transpThree
            // 
            this.transpThree.AutoSize = true;
            this.transpThree.Location = new System.Drawing.Point(6, 96);
            this.transpThree.Name = "transpThree";
            this.transpThree.Size = new System.Drawing.Size(71, 28);
            this.transpThree.TabIndex = 2;
            this.transpThree.TabStop = true;
            this.transpThree.Text = "3 -ий";
            this.transpThree.UseVisualStyleBackColor = true;
            // 
            // transpFour
            // 
            this.transpFour.AutoSize = true;
            this.transpFour.Location = new System.Drawing.Point(6, 130);
            this.transpFour.Name = "transpFour";
            this.transpFour.Size = new System.Drawing.Size(73, 28);
            this.transpFour.TabIndex = 3;
            this.transpFour.TabStop = true;
            this.transpFour.Text = "4 -ый";
            this.transpFour.UseVisualStyleBackColor = true;
            // 
            // SelectTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 423);
            this.Controls.Add(this.transportGroup);
            this.Name = "SelectTransport";
            this.Text = "Транспорт";
            this.transportGroup.ResumeLayout(false);
            this.transportGroup.PerformLayout();
            this.data.ResumeLayout(false);
            this.data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stamina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passangerCount)).EndInit();
            this.type.ResumeLayout(false);
            this.type.PerformLayout();
            this.num.ResumeLayout(false);
            this.num.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox transportGroup;
        public System.Windows.Forms.Button fuelTypeBtn;
        private System.Windows.Forms.GroupBox type;
        private System.Windows.Forms.GroupBox num;
        private System.Windows.Forms.GroupBox data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox sb;
        public System.Windows.Forms.TextBox model;
        public System.Windows.Forms.NumericUpDown passangerCount;
        public System.Windows.Forms.NumericUpDown ownerAge;
        public System.Windows.Forms.NumericUpDown maxSpeed;
        public System.Windows.Forms.NumericUpDown startSpeed;
        public System.Windows.Forms.NumericUpDown stamina;
        public System.Windows.Forms.RadioButton transpFive;
        public System.Windows.Forms.RadioButton transpFour;
        public System.Windows.Forms.RadioButton transpThree;
        public System.Windows.Forms.RadioButton transpTwo;
        public System.Windows.Forms.RadioButton transpOne;
        public System.Windows.Forms.RadioButton sco;
        public System.Windows.Forms.RadioButton tan;
        public System.Windows.Forms.RadioButton cart;
        public System.Windows.Forms.RadioButton tra;
        public System.Windows.Forms.RadioButton tro;
        public System.Windows.Forms.RadioButton vel;
        public System.Windows.Forms.RadioButton loa;
        public System.Windows.Forms.RadioButton bus;
        public System.Windows.Forms.RadioButton car;
        public System.Windows.Forms.RadioButton mot;
        public System.Windows.Forms.Button saveData;
    }
}