
namespace Function_Plotter
{
    partial class Ploter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ploter));
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.plot_Fun = new OxyPlot.WindowsForms.PlotView();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(0, 0);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(75, 23);
            this.plotView1.TabIndex = 0;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plot_Fun
            // 
            this.plot_Fun.BackColor = System.Drawing.SystemColors.Control;
            this.plot_Fun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.plot_Fun.Location = new System.Drawing.Point(25, 41);
            this.plot_Fun.Margin = new System.Windows.Forms.Padding(0);
            this.plot_Fun.Name = "plot_Fun";
            this.plot_Fun.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plot_Fun.Size = new System.Drawing.Size(750, 412);
            this.plot_Fun.TabIndex = 1;
            this.plot_Fun.Text = "F(x)";
            this.plot_Fun.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plot_Fun.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plot_Fun.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(169, 495);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(457, 37);
            this.btn_Ok.TabIndex = 2;
            this.btn_Ok.Text = "Back";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Ploter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.plot_Fun);
            this.Controls.Add(this.plotView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 591);
            this.MinimumSize = new System.Drawing.Size(818, 591);
            this.Name = "Ploter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plotter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ploter_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ploter_FormClosed);
            this.Load += new System.EventHandler(this.Ploter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView1;
        private OxyPlot.WindowsForms.PlotView plot_Fun;
        private System.Windows.Forms.Button btn_Ok;
    }
}