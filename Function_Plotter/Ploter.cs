using System;
using System.Drawing;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace Function_Plotter
{
    public partial class Ploter : Form
    {
        
        private readonly HomeBage homeForm;
        public string Function { get; set; }
        public double MinValue { get; set; }
        public double MaxValue { get; set; }

        public Ploter(HomeBage _homeForm )
        {
           
            homeForm = _homeForm;
            InitializeComponent(); 
            
        }
 
        private void Ploter_Load(object sender, EventArgs e)
        {
            plot_Fun.Model = new PlotModel { Title = "F(x)" };
            plot_Fun.Model.Series.Add(GetFunction());
        }
        private FunctionSeries GetFunction()
        {
            FunctionSeries fs = new FunctionSeries();
            double step = (MaxValue - MinValue) / 20 ;
            if(step == 0)
            {
                step++;
            }
            
            for(double i = MinValue; i <= MaxValue; i+= step)
            {
               DataPoint  dp = new DataPoint(i, Helper.EvaluateFunction(i, Function));
               fs.Points.Add(dp);

            }
            return fs;
        }

        private void Ploter_FormClosed(object sender, FormClosedEventArgs e)
        {
            homeForm.Show();
        }

        private void Ploter_FormClosing(object sender, FormClosingEventArgs e)
        {
            plot_Fun.Model.Series.Clear();

        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            plot_Fun.Model.Series.Clear();
            this.Close();
        }
    }
}
