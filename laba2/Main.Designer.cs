
namespace laba2
{
    partial class Main
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
            this.turnOnButton = new System.Windows.Forms.Button();
            this.subList = new System.Windows.Forms.ListBox();
            this.showButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.turnOffButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // turnOnButton
            // 
            this.turnOnButton.Enabled = false;
            this.turnOnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.turnOnButton.Location = new System.Drawing.Point(54, 32);
            this.turnOnButton.Name = "turnOnButton";
            this.turnOnButton.Size = new System.Drawing.Size(120, 38);
            this.turnOnButton.TabIndex = 0;
            this.turnOnButton.Text = "Включить";
            this.turnOnButton.UseVisualStyleBackColor = true;
            this.turnOnButton.Click += new System.EventHandler(this.turnOnButton_Click);
            // 
            // subList
            // 
            this.subList.FormattingEnabled = true;
            this.subList.ItemHeight = 18;
            this.subList.Location = new System.Drawing.Point(6, 33);
            this.subList.Name = "subList";
            this.subList.Size = new System.Drawing.Size(225, 94);
            this.subList.TabIndex = 1;
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showButton.Location = new System.Drawing.Point(54, 133);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(120, 38);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Показать ";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subList);
            this.groupBox1.Controls.Add(this.showButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 178);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подписчики";
            // 
            // turnOffButton
            // 
            this.turnOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.turnOffButton.Location = new System.Drawing.Point(54, 76);
            this.turnOffButton.Name = "turnOffButton";
            this.turnOffButton.Size = new System.Drawing.Size(120, 38);
            this.turnOffButton.TabIndex = 4;
            this.turnOffButton.Text = "Выключить";
            this.turnOffButton.UseVisualStyleBackColor = true;
            this.turnOffButton.Click += new System.EventHandler(this.turnOffButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.turnOnButton);
            this.groupBox2.Controls.Add(this.turnOffButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 128);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оповещение";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 349);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Weather Data";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button turnOnButton;
        private System.Windows.Forms.ListBox subList;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button turnOffButton;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

