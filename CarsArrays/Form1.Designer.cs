namespace CarsArrays
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnSaveCar = new Button();
            label2 = new Label();
            txtMotor = new TextBox();
            label3 = new Label();
            txtModel = new TextBox();
            lblShowPrice = new Label();
            cbxBrand = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold);
            label1.Location = new Point(254, 135);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 1;
            label1.Text = "Model:";
            // 
            // btnSaveCar
            // 
            btnSaveCar.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveCar.Location = new Point(344, 244);
            btnSaveCar.Name = "btnSaveCar";
            btnSaveCar.Size = new Size(93, 36);
            btnSaveCar.TabIndex = 2;
            btnSaveCar.Text = "Save Car";
            btnSaveCar.UseVisualStyleBackColor = true;
            btnSaveCar.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold);
            label2.Location = new Point(254, 191);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 4;
            label2.Text = "Motor:";
            // 
            // txtMotor
            // 
            txtMotor.Font = new Font("MS Reference Sans Serif", 14.25F);
            txtMotor.Location = new Point(331, 189);
            txtMotor.Name = "txtMotor";
            txtMotor.Size = new Size(167, 31);
            txtMotor.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold);
            label3.Location = new Point(254, 84);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 6;
            label3.Text = "Brand:";
            // 
            // txtModel
            // 
            txtModel.Font = new Font("MS Reference Sans Serif", 14.25F);
            txtModel.Location = new Point(331, 135);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(167, 31);
            txtModel.TabIndex = 5;
            // 
            // lblShowPrice
            // 
            lblShowPrice.AutoSize = true;
            lblShowPrice.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShowPrice.Location = new Point(151, 343);
            lblShowPrice.Name = "lblShowPrice";
            lblShowPrice.Size = new Size(0, 24);
            lblShowPrice.TabIndex = 7;
            // 
            // cbxBrand
            // 
            cbxBrand.Font = new Font("MS Reference Sans Serif", 14.25F);
            cbxBrand.FormattingEnabled = true;
            cbxBrand.Items.AddRange(new object[] { "TOYOTA", "NISSAN", "HONDA" });
            cbxBrand.Location = new Point(331, 84);
            cbxBrand.Name = "cbxBrand";
            cbxBrand.Size = new Size(167, 32);
            cbxBrand.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbxBrand);
            Controls.Add(lblShowPrice);
            Controls.Add(label3);
            Controls.Add(txtModel);
            Controls.Add(label2);
            Controls.Add(txtMotor);
            Controls.Add(btnSaveCar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnSaveCar;
        private Label label2;
        private TextBox txtMotor;
        private Label label3;
        private TextBox txtModel;
        private Label lblShowPrice;
        private ComboBox cbxBrand;
    }
}
