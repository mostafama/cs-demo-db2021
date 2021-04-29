
namespace Demo_Day8_DB
{
    partial class CustomerFrm
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
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerIdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stateTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.postalTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.discardBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.customerIdCBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(137, 73);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(181, 25);
            this.nameTxt.TabIndex = 0;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID";
            // 
            // customerIdTxt
            // 
            this.customerIdTxt.Location = new System.Drawing.Point(362, 27);
            this.customerIdTxt.Name = "customerIdTxt";
            this.customerIdTxt.ReadOnly = true;
            this.customerIdTxt.Size = new System.Drawing.Size(100, 25);
            this.customerIdTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(137, 120);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(181, 25);
            this.addressTxt.TabIndex = 0;
            this.addressTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address";
            // 
            // cityTxt
            // 
            this.cityTxt.Location = new System.Drawing.Point(137, 168);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(181, 25);
            this.cityTxt.TabIndex = 0;
            this.cityTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "City";
            // 
            // stateTxt
            // 
            this.stateTxt.Location = new System.Drawing.Point(352, 171);
            this.stateTxt.Name = "stateTxt";
            this.stateTxt.Size = new System.Drawing.Size(181, 25);
            this.stateTxt.TabIndex = 0;
            this.stateTxt.Visible = false;
            this.stateTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "State";
            // 
            // postalTxt
            // 
            this.postalTxt.Location = new System.Drawing.Point(137, 265);
            this.postalTxt.Name = "postalTxt";
            this.postalTxt.Size = new System.Drawing.Size(181, 25);
            this.postalTxt.TabIndex = 0;
            this.postalTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "postal Code";
            // 
            // backBtn
            // 
            this.backBtn.Enabled = false;
            this.backBtn.Location = new System.Drawing.Point(265, 26);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(36, 25);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "<<";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(307, 26);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(36, 25);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = ">>";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Location = new System.Drawing.Point(59, 329);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(74, 25);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "&Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // discardBtn
            // 
            this.discardBtn.Enabled = false;
            this.discardBtn.Location = new System.Drawing.Point(163, 329);
            this.discardBtn.Name = "discardBtn";
            this.discardBtn.Size = new System.Drawing.Size(74, 25);
            this.discardBtn.TabIndex = 2;
            this.discardBtn.Text = "&Discard";
            this.discardBtn.UseVisualStyleBackColor = true;
            this.discardBtn.Click += new System.EventHandler(this.discardBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(265, 329);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(74, 25);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "&Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(163, 367);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(74, 25);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "&Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(137, 214);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(181, 25);
            this.stateComboBox.TabIndex = 3;
            this.stateComboBox.SelectedIndexChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // customerIdCBox
            // 
            this.customerIdCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerIdCBox.FormattingEnabled = true;
            this.customerIdCBox.Location = new System.Drawing.Point(137, 27);
            this.customerIdCBox.Name = "customerIdCBox";
            this.customerIdCBox.Size = new System.Drawing.Size(63, 25);
            this.customerIdCBox.TabIndex = 4;
            this.customerIdCBox.SelectedIndexChanged += new System.EventHandler(this.customerIdCBox_SelectedIndexChanged);
            // 
            // CustomerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 404);
            this.Controls.Add(this.customerIdCBox);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.discardBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerIdTxt);
            this.Controls.Add(this.postalTxt);
            this.Controls.Add(this.stateTxt);
            this.Controls.Add(this.cityTxt);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.nameTxt);
            this.Name = "CustomerFrm";
            this.Text = "Customer Info";
            this.Load += new System.EventHandler(this.CustomerFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerIdTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cityTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stateTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox postalTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button discardBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;        
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.ComboBox customerIdCBox;
    }
}

