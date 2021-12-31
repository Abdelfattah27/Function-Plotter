using System;
using System.IO;
using System.Windows.Forms;
namespace Function_Plotter
{
    public partial class HomeBage : Form
    {
        private readonly Ploter PlottingForm;
        public HomeBage()
        {
            //object from the plotter Form
            PlottingForm = new Ploter(this);
            InitializeComponent();

        }

        private void Btn_plot_Click(object sender, EventArgs e)
        {
            bool validFunction = CheckValidation(txt_Fun.Text);
            if (validFunction == false)
            {
                //Hide the Main Form
                this.Hide();
                if (MessageBox.Show($"Please Enter A Valid Function. \nInput string was not in a correct format.") == DialogResult.OK)
                {

                    this.Show();
                }

            }
            else
            {
                PlottingForm.Function = txt_Fun.Text;
                PlottingForm.MaxValue = double.Parse(txt_MaxVal.Text);
                PlottingForm.MinValue = double.Parse(txt_MinVal.Text) ;
                if (PlottingForm.MaxValue < PlottingForm.MinValue)
                {
                    double temp = PlottingForm.MaxValue;
                    PlottingForm.MaxValue = PlottingForm.MinValue;
                    PlottingForm.MinValue = temp;
                }
                this.Hide();
                PlottingForm.ShowDialog();
            }
        }

        private bool CheckValidation(string userFunction)
        {
            try
            {
                double minValue = double.Parse(txt_MinVal.Text.Trim());
                double maxValue = double.Parse(txt_MaxVal.Text.Trim());
                if(maxValue < minValue)
                {
                    double temp = maxValue;
                    maxValue = minValue;
                    minValue = temp;
                }
                for (double i = minValue; i <= maxValue; i++)
                {
                    Helper.EvaluateFunction(i, userFunction);

                }
                
            }
            catch (Exception ex)
            {
                File.AppendAllText(string.Format(AppDomain.CurrentDomain.BaseDirectory + @"/LogError.txt" )
                   ,string.Format(userFunction + " :: " + ex.Message));
                return false;
            }
            return true;
        }
  
    }

}
