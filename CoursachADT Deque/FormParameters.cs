using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoursachADT_Deque
{
    public partial class FormParameters : Form
    {
        private ParameterClass parameterClass;

        public event Action<ParameterClass> ParameterChanged;


        public FormParameters()
        {
            InitializeComponent();
        }

        public void AddEvent(Action<ParameterClass> action)
        {
            ParameterChanged += action;
        }

        private void checkBoxStartValue_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownValues.Enabled = checkBoxStartValue.Checked;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            int numElems = 0;
            if (checkBoxStartValue.Checked)
            {
                numElems = (int)numericUpDownValues.Value;
            }

            parameterClass = new ParameterClass(numElems);
            ParameterChanged.Invoke(parameterClass);
            Close();


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
