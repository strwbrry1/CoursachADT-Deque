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
            int maxSize;
            int numElems = 0;
            if (checkBoxStartValue.Checked)
            {
                numElems = (int)numericUpDownValues.Value;
            }

            maxSize = (int)numericUpDownMaxSize.Value;
            if (maxSize != 0)
            {
                parameterClass = new ParameterClass(maxSize, numElems);
                ParameterChanged.Invoke(parameterClass);
                Close();
            }
            else
            {
                MessageBox.Show("Максимальное количество элементов не может быть 0!", "Ошибка", MessageBoxButtons.OK);
            }
           
        }
    }
}
