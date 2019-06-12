using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shawn_pudjowargono_assignment_01
{
    public partial class Windows_Form : Form
    {
        Results_Form results;
        

        public Windows_Form()
        {
            InitializeComponent();   
        }

        private void begin_button_Click(object sender, EventArgs e)
        {
            try
            {
                int start_x = Convert.ToInt32(x_input.Value);
                int start_y = Convert.ToInt32(x_input.Value);
                int number_of_trials = Convert.ToInt32(number_of_trials_input.Value);
                int strategy;

                if (!strategy_A.Checked && !strategy_B.Checked)
                {
                    throw new Exception();
                }
                strategy = strategy_A.Checked ? 0 : 1;

                if (results == null)
                {
                    results = new Results_Form();
                    results.Visible = true;
                }
                else
                {
                    results.Close();
                    results = new Results_Form();
                    results.Visible = true;
                }
                
                Program.Start_Knights_Tour(start_x, start_y, strategy, number_of_trials);

            } catch (Exception ex) {

                string caption = "ERROR:";
                string message = "Please select a strategy!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            //Program.Start_Console();
            //Console.WriteLine("Test");

        }
    }
}
