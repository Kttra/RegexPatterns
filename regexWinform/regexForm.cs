/*  Regex program used to test regex expressions.
 *  
 *  The program has be set up to check the regex expression and the data
 *  after each key press while the "Real-time" checkbox is checked.
 *  If it is not, then you will need to press enter or confirm initiate the
 *  check.
*/
using System.Text.RegularExpressions;

namespace regexWinform
{
    public partial class regexForm : Form
    {
        public regexForm()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            CheckRegex();
            //Example of formats
            //-----Date format-----
            //^[0-3]{0,1}[0-9]{1}/[0-3]{0,1}[0-9]{0,1}/[0-9]{0,2}$
            //  12/12/22
            //-----Time Format-----
            //[(][0-9]{1,2}[:][0-9]{1,2}[)]
            //  (12:45)
        }
        //Check when enter is pressed
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckRegex();
            }
        }
        //Realtime check when data is entered in the 2nd textbox & Real-time is checked
        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (checkBox1.Checked)
            {
                CheckRegex();
            }
        }
        //Realtime check when data is entered in the 1st textbox & Real-time is checked
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (checkBox1.Checked)
            {
                CheckRegex();
            }
        }
        //Check if the data matches the regex pattern, if it does set the label to true, else false
        private void CheckRegex()
        {
            try
            {
                Regex obj = new Regex(textBox1.Text);
                label3.Text = obj.IsMatch(textBox2.Text).ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}