namespace ParkingCounter
{
    partial class Form1
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
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRentCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCarType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFactor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelBill = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxHours
            // 
            this.textBoxHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHours.Location = new System.Drawing.Point(19, 48);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(100, 38);
            this.textBoxHours.TabIndex = 0;
            this.textBoxHours.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hours";
            // 
            // textBoxRentCost
            // 
            this.textBoxRentCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRentCost.Location = new System.Drawing.Point(125, 48);
            this.textBoxRentCost.Name = "textBoxRentCost";
            this.textBoxRentCost.Size = new System.Drawing.Size(128, 38);
            this.textBoxRentCost.TabIndex = 0;
            this.textBoxRentCost.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(119, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rent cost";
            // 
            // comboBoxCarType
            // 
            this.comboBoxCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCarType.FormattingEnabled = true;
            this.comboBoxCarType.Location = new System.Drawing.Point(259, 48);
            this.comboBoxCarType.Name = "comboBoxCarType";
            this.comboBoxCarType.Size = new System.Drawing.Size(308, 39);
            this.comboBoxCarType.TabIndex = 4;
            this.comboBoxCarType.Text = "RegularCar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(253, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Car type";
            // 
            // textBoxFactor
            // 
            this.textBoxFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFactor.Location = new System.Drawing.Point(573, 48);
            this.textBoxFactor.Name = "textBoxFactor";
            this.textBoxFactor.Size = new System.Drawing.Size(128, 38);
            this.textBoxFactor.TabIndex = 0;
            this.textBoxFactor.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(567, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Factor";
            // 
            // labelBill
            // 
            this.labelBill.AutoSize = true;
            this.labelBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBill.Location = new System.Drawing.Point(13, 133);
            this.labelBill.Name = "labelBill";
            this.labelBill.Size = new System.Drawing.Size(63, 32);
            this.labelBill.TabIndex = 1;
            this.labelBill.Text = "Bill:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(19, 92);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(151, 38);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 190);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.comboBoxCarType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFactor);
            this.Controls.Add(this.textBoxRentCost);
            this.Controls.Add(this.textBoxHours);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRentCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCarType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFactor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelBill;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

