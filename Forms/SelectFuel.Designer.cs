namespace Transports
{
    partial class SelectFuel
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.fuelTypeBtn = new System.Windows.Forms.Button();
            this.fuelType = new System.Windows.Forms.GroupBox();
            this.fuelTypeList = new System.Windows.Forms.CheckedListBox();
            this.fuelType.SuspendLayout();
            this.SuspendLayout();
            // 
            // fuelTypeBtn
            // 
            this.fuelTypeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fuelTypeBtn.Location = new System.Drawing.Point(12, 152);
            this.fuelTypeBtn.Name = "fuelTypeBtn";
            this.fuelTypeBtn.Size = new System.Drawing.Size(279, 42);
            this.fuelTypeBtn.TabIndex = 3;
            this.fuelTypeBtn.Text = "Выбрать";
            this.fuelTypeBtn.UseVisualStyleBackColor = true;
            this.fuelTypeBtn.Click += new System.EventHandler(this.FuelTypeBtn_Click);
            // 
            // fuelType
            // 
            this.fuelType.Controls.Add(this.fuelTypeList);
            this.fuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fuelType.Location = new System.Drawing.Point(12, 12);
            this.fuelType.Name = "fuelType";
            this.fuelType.Size = new System.Drawing.Size(279, 134);
            this.fuelType.TabIndex = 4;
            this.fuelType.TabStop = false;
            this.fuelType.Text = "Вид топлива";
            // 
            // fuelTypeList
            // 
            this.fuelTypeList.FormattingEnabled = true;
            this.fuelTypeList.Items.AddRange(new object[] {
            "Дизель",
            "Энергия",
            "Бензин",
            "Газ"});
            this.fuelTypeList.Location = new System.Drawing.Point(6, 28);
            this.fuelTypeList.Name = "fuelTypeList";
            this.fuelTypeList.Size = new System.Drawing.Size(267, 100);
            this.fuelTypeList.TabIndex = 0;
            // 
            // SelectFuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 202);
            this.Controls.Add(this.fuelType);
            this.Controls.Add(this.fuelTypeBtn);
            this.Name = "SelectFuel";
            this.Text = "Топливо";
            this.fuelType.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button fuelTypeBtn;
        private System.Windows.Forms.GroupBox fuelType;
        public System.Windows.Forms.CheckedListBox fuelTypeList;
    }
}

