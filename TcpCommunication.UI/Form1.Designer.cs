namespace Mul3
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
            this._btnOr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._rbB1 = new System.Windows.Forms.RadioButton();
            this._rbB0 = new System.Windows.Forms.RadioButton();
            this._btnAnd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this._lblResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._rbA0 = new System.Windows.Forms.RadioButton();
            this._rbA1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnOr
            // 
            this._btnOr.Location = new System.Drawing.Point(32, 80);
            this._btnOr.Name = "_btnOr";
            this._btnOr.Size = new System.Drawing.Size(38, 23);
            this._btnOr.TabIndex = 0;
            this._btnOr.Text = "OR";
            this._btnOr.UseVisualStyleBackColor = true;
            this._btnOr.Click += new System.EventHandler(this._btnOr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "b";
            // 
            // _rbB1
            // 
            this._rbB1.AutoSize = true;
            this._rbB1.Checked = true;
            this._rbB1.Location = new System.Drawing.Point(6, 9);
            this._rbB1.Name = "_rbB1";
            this._rbB1.Size = new System.Drawing.Size(31, 17);
            this._rbB1.TabIndex = 5;
            this._rbB1.TabStop = true;
            this._rbB1.Text = "1";
            this._rbB1.UseVisualStyleBackColor = true;
            // 
            // _rbB0
            // 
            this._rbB0.AutoSize = true;
            this._rbB0.Location = new System.Drawing.Point(43, 8);
            this._rbB0.Name = "_rbB0";
            this._rbB0.Size = new System.Drawing.Size(31, 17);
            this._rbB0.TabIndex = 6;
            this._rbB0.Text = "0";
            this._rbB0.UseVisualStyleBackColor = true;
            // 
            // _btnAnd
            // 
            this._btnAnd.Location = new System.Drawing.Point(71, 80);
            this._btnAnd.Name = "_btnAnd";
            this._btnAnd.Size = new System.Drawing.Size(38, 23);
            this._btnAnd.TabIndex = 7;
            this._btnAnd.Text = "AND";
            this._btnAnd.UseVisualStyleBackColor = true;
            this._btnAnd.Click += new System.EventHandler(this._btnAnd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result";
            // 
            // _lblResult
            // 
            this._lblResult.AutoSize = true;
            this._lblResult.Location = new System.Drawing.Point(55, 106);
            this._lblResult.Name = "_lblResult";
            this._lblResult.Size = new System.Drawing.Size(0, 13);
            this._lblResult.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._rbA0);
            this.groupBox1.Controls.Add(this._rbA1);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(76, 30);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // _rbA0
            // 
            this._rbA0.AutoSize = true;
            this._rbA0.Location = new System.Drawing.Point(40, 8);
            this._rbA0.Name = "_rbA0";
            this._rbA0.Size = new System.Drawing.Size(31, 17);
            this._rbA0.TabIndex = 13;
            this._rbA0.Text = "0";
            this._rbA0.UseVisualStyleBackColor = true;
            // 
            // _rbA1
            // 
            this._rbA1.AutoSize = true;
            this._rbA1.Checked = true;
            this._rbA1.Location = new System.Drawing.Point(3, 7);
            this._rbA1.Name = "_rbA1";
            this._rbA1.Size = new System.Drawing.Size(31, 17);
            this._rbA1.TabIndex = 12;
            this._rbA1.TabStop = true;
            this._rbA1.Text = "1";
            this._rbA1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._rbB0);
            this.groupBox2.Controls.Add(this._rbB1);
            this.groupBox2.Location = new System.Drawing.Point(33, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(76, 30);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 141);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._btnAnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnOr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnOr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton _rbB1;
        private System.Windows.Forms.RadioButton _rbB0;
        private System.Windows.Forms.Button _btnAnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _lblResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton _rbA0;
        private System.Windows.Forms.RadioButton _rbA1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

