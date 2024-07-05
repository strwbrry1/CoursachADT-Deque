namespace CoursachADT_Deque
{
    public partial class FormMain : Form
    {

        private DequeRealizer deque;
        private DrawingDeque visualizer;
        private StateStorage stateStorage;
        public FormMain()
        {
            InitializeComponent();
            if (deque == null) 
            {
                saveToolStripMenuItem.Enabled = false;
                loadToolStripMenuItem.Enabled = false;
            }
        }

        private void buttonCreateDeque_Click(object sender, EventArgs e)
        {
            FormParameters form = new();

            form.AddEvent(CreateDeque);
            form.Show();
        }

        private void CreateDeque(ParameterClass parameters)
        {
            this.stateStorage = new StateStorage();
            deque = new DequeRealizer(parameters.numElems);
            stateStorage.AddState(deque.SaveState());
            stateStorage.NextState();
            saveToolStripMenuItem.Enabled = true;
            loadToolStripMenuItem.Enabled = true;
            if (!deque.isEmpty())
            {
                pictureBoxVisualizer.Image = ShowDeque();
            }
        }

        private Bitmap? ShowDeque()
        {
            if (stateStorage.GetCurrentState() == null) return null;
            if (deque.isEmpty()) return new Bitmap(pictureBoxVisualizer.Width, pictureBoxVisualizer.Height);
            visualizer = new DrawingDeque(pictureBoxVisualizer.Width, pictureBoxVisualizer.Height);

            Bitmap bitmap = new(pictureBoxVisualizer.Width, pictureBoxVisualizer.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            visualizer.Visualize(graphics, stateStorage.GetCurrentState());
            return bitmap;
        }

        private void buttonAddFirst_Click(object sender, EventArgs e)
        {
            if (deque == null)
            {
                return;
            }
            deque.SetState(stateStorage.GetLastState());
            deque.InsertFirst((int)numericUpDownInput.Value);
            stateStorage.AddState(deque.SaveState());
            stateStorage.NextState();
            if (!deque.isEmpty())
            {
                pictureBoxVisualizer.Image = ShowDeque();
            }
        }

        private void buttonAddLast_Click(object sender, EventArgs e)
        {
            if (deque == null)
            {
                return;
            }
            deque.SetState(stateStorage.GetLastState());
            deque.InsertLast((int)numericUpDownInput.Value);
            stateStorage.AddState(deque.SaveState());
            stateStorage.NextState();
            pictureBoxVisualizer.Image = ShowDeque();
        }

        private void buttonRemoveFrist_Click(object sender, EventArgs e)
        {
            if (deque == null)
            {
                return;
            }
            deque.SetState(stateStorage.GetLastState());
            deque.PopFirst();
            stateStorage.AddState(deque.SaveState());
            stateStorage.NextState();
            pictureBoxVisualizer.Image = ShowDeque();
        }

        private void buttonRemoveLast_Click(object sender, EventArgs e)
        {
            if (deque == null)
            {
                return;
            }
            deque.SetState(stateStorage.GetLastState());
            deque.PopLast();
            stateStorage.AddState(deque.SaveState());
            stateStorage.NextState();
            pictureBoxVisualizer.Image = ShowDeque();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (deque == null)
            {
                return;
            }
            deque.Clear();
            stateStorage.AddState(deque.SaveState());
            stateStorage.NextState();
            pictureBoxVisualizer.Image = ShowDeque();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo form = new();
            form.Show();
        }

        private void buttonNextStep_Click(object sender, EventArgs e)
        {
            if (stateStorage != null && stateStorage.NextState())
            {
                deque.SetState(stateStorage.GetCurrentState());
                pictureBoxVisualizer.Image = ShowDeque();
            }
            return;
        }

        private void buttonPrevStep_Click(object sender, EventArgs e)
        {
            if (stateStorage != null && stateStorage.PreviousState())
            {
                deque.SetState(stateStorage.GetCurrentState());
                pictureBoxVisualizer.Image = ShowDeque();
            }
            return;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName.Equals("")) return;
                stateStorage.SaveToFile(saveFileDialog1.FileName);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Œ¯Ë·Í‡!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1 = new OpenFileDialog();
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName.Equals("")) return;
                stateStorage.LoadFromFile(openFileDialog1.FileName);
                stateStorage.Reset();
                pictureBoxVisualizer.Image = ShowDeque();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Œ¯Ë·Í‡!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
