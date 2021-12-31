
namespace Function_Plotter
{
    partial class HomeBage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeBage));
            this.txt_Fun = new System.Windows.Forms.TextBox();
            this.btn_plot = new System.Windows.Forms.Button();
            this.lbl_Fun = new System.Windows.Forms.Label();
            this.lbl_Max = new System.Windows.Forms.Label();
            this.txt_MaxVal = new System.Windows.Forms.TextBox();
            this.lbl_Min = new System.Windows.Forms.Label();
            this.txt_MinVal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Fun
            // 
            this.txt_Fun.AcceptsTab = true;
            this.txt_Fun.Location = new System.Drawing.Point(274, 74);
            this.txt_Fun.Name = "txt_Fun";
            this.txt_Fun.Size = new System.Drawing.Size(332, 24);
            this.txt_Fun.TabIndex = 1;
            // 
            // btn_plot
            // 
            this.btn_plot.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_plot.Location = new System.Drawing.Point(121, 241);
            this.btn_plot.Name = "btn_plot";
            this.btn_plot.Size = new System.Drawing.Size(485, 38);
            this.btn_plot.TabIndex = 4;
            this.btn_plot.Text = "Plot";
            this.btn_plot.UseVisualStyleBackColor = true;
            this.btn_plot.Click += new System.EventHandler(this.Btn_plot_Click);
            // 
            // lbl_Fun
            // 
            this.lbl_Fun.AutoSize = true;
            this.lbl_Fun.Location = new System.Drawing.Point(118, 74);
            this.lbl_Fun.Name = "lbl_Fun";
            this.lbl_Fun.Size = new System.Drawing.Size(98, 17);
            this.lbl_Fun.TabIndex = 3;
            this.lbl_Fun.Text = "Enter Function";
            // 
            // lbl_Max
            // 
            this.lbl_Max.AutoSize = true;
            this.lbl_Max.Location = new System.Drawing.Point(128, 180);
            this.lbl_Max.Name = "lbl_Max";
            this.lbl_Max.Size = new System.Drawing.Size(79, 17);
            this.lbl_Max.TabIndex = 5;
            this.lbl_Max.Text = "interval end";
            // 
            // txt_MaxVal
            // 
            this.txt_MaxVal.AcceptsTab = true;
            this.txt_MaxVal.Location = new System.Drawing.Point(271, 177);
            this.txt_MaxVal.Name = "txt_MaxVal";
            this.txt_MaxVal.Size = new System.Drawing.Size(335, 24);
            this.txt_MaxVal.TabIndex = 3;
            // 
            // lbl_Min
            // 
            this.lbl_Min.AutoSize = true;
            this.lbl_Min.Location = new System.Drawing.Point(109, 127);
            this.lbl_Min.Name = "lbl_Min";
            this.lbl_Min.Size = new System.Drawing.Size(117, 17);
            this.lbl_Min.TabIndex = 7;
            this.lbl_Min.Text = "Interval beginning";
            // 
            // txt_MinVal
            // 
            this.txt_MinVal.AcceptsTab = true;
            this.txt_MinVal.Location = new System.Drawing.Point(274, 124);
            this.txt_MinVal.Name = "txt_MinVal";
            this.txt_MinVal.Size = new System.Drawing.Size(332, 24);
            this.txt_MinVal.TabIndex = 2;
            // 
            // HomeBage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 345);
            this.Controls.Add(this.lbl_Min);
            this.Controls.Add(this.txt_MinVal);
            this.Controls.Add(this.lbl_Max);
            this.Controls.Add(this.txt_MaxVal);
            this.Controls.Add(this.lbl_Fun);
            this.Controls.Add(this.btn_plot);
            this.Controls.Add(this.txt_Fun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(794, 392);
            this.MinimumSize = new System.Drawing.Size(794, 392);
            this.Name = "HomeBage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plotter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Fun;
        private System.Windows.Forms.Button btn_plot;
        private System.Windows.Forms.Label lbl_Fun;
        private System.Windows.Forms.Label lbl_Max;
        private System.Windows.Forms.TextBox txt_MaxVal;
        private System.Windows.Forms.Label lbl_Min;
        private System.Windows.Forms.TextBox txt_MinVal;
    }
}

