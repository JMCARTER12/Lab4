// Grade ID: R8206
// Lab # 4
// Due date: Feb 16 , 2020
// Section : 01
// This program determines if someone qualifies for this college by the user given inputs for GPA and test scores.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class QualificationForm : Form
    {
        public QualificationForm()
        {
            InitializeComponent();
        }
        // This event handler calculates Accept or Rejct from a user input of GPA and Test score, with also counting how many accepts and rejects generated
        private void button1_Click(object sender, EventArgs e)
        {
            // declaring variables
            float GradePointAverage;
            int TestScore;
            int AcceptCount = 0;
            int RejectCount = 0;
            const int LOW_SCORE = 0;
            const int HIGH_SCORE = 100;
            const double LOW_GPA = 0.0;
            const double HIGH_GPA = 4.0;
 
            float.TryParse(GPAInput.Text, out GradePointAverage); // converting user input using TryParse
            
            int.TryParse(TestScoreInput.Text, out TestScore);

            if (TestScore < LOW_SCORE || TestScore > HIGH_SCORE) // sends error messages if user input incorrect GPA or Test score
            {
                MessageBox.Show("Enter Valid Test Score");
            }
            else if (GradePointAverage < LOW_GPA || GradePointAverage > HIGH_GPA)
            {
                MessageBox.Show("Enter Valid GPA");
            }

            // Determines if the inputs are accept or reject, given the qualifications for accept
            if ((GradePointAverage >= 3.0 && TestScore >= 60) || (GradePointAverage <= 3.0 && TestScore >= 80))
            {
                QualificationOutput.Text = "\nAccept!"; // Output for Accept
                ++AcceptCount; // Adds to Accept count
                AcceptOutput.Text = (AcceptCount.ToString(""));
            }
            if ((GradePointAverage < 3.0 && TestScore < 60) || (GradePointAverage < 3.0 && TestScore > 80))
            {
                QualificationOutput.Text = "\nReject"; // Output for Reject
                ++RejectCount; // Adds to reject count
                RejectOutput.Text = (RejectCount.ToString(""));
            }
        }
        
        

        private void GPAInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void QualificationOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
