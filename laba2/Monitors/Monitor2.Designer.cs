
namespace laba2.Monitors
{
    partial class Monitor2
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
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonUnsub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemp.Location = new System.Drawing.Point(25, 28);
            this.labelTemp.Name = "label1";
            this.labelTemp.Size = new System.Drawing.Size(196, 31);
            this.labelTemp.TabIndex = 0;
            this.labelTemp.Text = "Температура: ";
            // 
            // label2
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHumidity.Location = new System.Drawing.Point(25, 70);
            this.labelHumidity.Name = "label2";
            this.labelHumidity.Size = new System.Drawing.Size(166, 31);
            this.labelHumidity.TabIndex = 1;
            this.labelHumidity.Text = "Влажность: ";
            // 
            // label3
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPressure.Location = new System.Drawing.Point(25, 116);
            this.labelPressure.Name = "label3";
            this.labelPressure.Size = new System.Drawing.Size(154, 31);
            this.labelPressure.TabIndex = 2;
            this.labelPressure.Text = "Давление: ";
            // 
            // button1
            // 
            this.buttonSub.Enabled = false;
            this.buttonSub.Location = new System.Drawing.Point(629, 35);
            this.buttonSub.Name = "button1";
            this.buttonSub.Size = new System.Drawing.Size(143, 53);
            this.buttonSub.TabIndex = 3;
            this.buttonSub.Text = "Подписаться";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.subButton_Click);
            // 
            // button2
            // 
            this.buttonUnsub.Location = new System.Drawing.Point(629, 94);
            this.buttonUnsub.Name = "button2";
            this.buttonUnsub.Size = new System.Drawing.Size(143, 53);
            this.buttonUnsub.TabIndex = 4;
            this.buttonUnsub.Text = "Отписаться";
            this.buttonUnsub.UseVisualStyleBackColor = true;
            this.buttonUnsub.Click += new System.EventHandler(this.unsubButton_Click);
            // 
            // Monitor2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 179);
            this.Controls.Add(this.buttonUnsub);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.labelPressure);
            this.Controls.Add(this.labelHumidity);
            this.Controls.Add(this.labelTemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Monitor2";
            this.Text = "Monitor2";
            this.Load += new System.EventHandler(this.Monitor2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonUnsub;
    }
}