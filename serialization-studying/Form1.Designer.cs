namespace serialization_studying
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
            this.btnSerialize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxNickname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxGender = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxEthnicity = new System.Windows.Forms.TextBox();
            this.nUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(10, 180);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(81, 41);
            this.btnSerialize.TabIndex = 0;
            this.btnSerialize.Text = "Serialize";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nUpDownAge);
            this.panel1.Controls.Add(this.txtBoxEthnicity);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtBoxGender);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtBoxNickname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBoxLastName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDeserialize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBoxName);
            this.panel1.Controls.Add(this.btnSerialize);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 235);
            this.panel1.TabIndex = 1;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(54, 10);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(149, 20);
            this.txtBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age:";
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(109, 180);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(94, 41);
            this.btnDeserialize.TabIndex = 5;
            this.btnDeserialize.Text = "Show Serialized Person";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gender:";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(67, 39);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(136, 20);
            this.txtBoxLastName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ethnicity:";
            // 
            // txtBoxNickname
            // 
            this.txtBoxNickname.Location = new System.Drawing.Point(67, 68);
            this.txtBoxNickname.Name = "txtBoxNickname";
            this.txtBoxNickname.Size = new System.Drawing.Size(136, 20);
            this.txtBoxNickname.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Last Name:";
            // 
            // txtBoxGender
            // 
            this.txtBoxGender.Location = new System.Drawing.Point(54, 124);
            this.txtBoxGender.Name = "txtBoxGender";
            this.txtBoxGender.Size = new System.Drawing.Size(149, 20);
            this.txtBoxGender.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nickname:";
            // 
            // txtBoxEthnicity
            // 
            this.txtBoxEthnicity.Location = new System.Drawing.Point(54, 150);
            this.txtBoxEthnicity.Name = "txtBoxEthnicity";
            this.txtBoxEthnicity.Size = new System.Drawing.Size(149, 20);
            this.txtBoxEthnicity.TabIndex = 13;
            // 
            // nUpDownAge
            // 
            this.nUpDownAge.Location = new System.Drawing.Point(54, 98);
            this.nUpDownAge.Name = "nUpDownAge";
            this.nUpDownAge.Size = new System.Drawing.Size(149, 20);
            this.nUpDownAge.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 242);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Serialization";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxEthnicity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxNickname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUpDownAge;
    }
}

