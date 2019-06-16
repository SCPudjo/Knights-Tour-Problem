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
        
        /*
         * Windows_Form constructor
         */
        public Windows_Form()
        {
            InitializeComponent();   
        }

        /*
         * Starts Knight's Tour run based on user input
         */
        private void begin_button_Click(object sender, EventArgs e)
        {

            // Pull user input data from Form
            int start_x = Convert.ToInt32(x_input.Value);
            int start_y = Convert.ToInt32(y_input.Value);
            int number_of_trials = Convert.ToInt32(number_of_trials_input.Value);
            int strategy = strategy_A.Checked ? 0 : 1;

            // Pass pulled info to method to start Kmight's Tour trials
            Program.Start_Knights_Tour(start_x, start_y, strategy, number_of_trials);

            // Closes Results_Form if one is already created
            if (results != null)
            {
                results.Close();
            }

            results = new Results_Form(number_of_trials, strategy);
            results.Visible = true;
        }
    }
}