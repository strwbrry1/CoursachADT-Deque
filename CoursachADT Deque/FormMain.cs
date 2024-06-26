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
            deque.InsertFirst((int)numericUpDownInput.Value);
            stateStorage.AddState(deque.SaveState());
            stateStorage.NextState();
            if (!deque.isEmpty())
            {
                pictureBoxVisualizer.Image = ShowDeque();
            }
            textBoxDebug.Text = deque.list.ToString();
        }

        private void buttonAddLast_Click(object sender, EventArgs e)
        {
            if (deque == null)
            {
                return;
            }
            deque.InsertLast((int)numericUpDownInput.Value);
            stateStorage.AddState(deque.SaveState());
            stateStorage.NextState();
            pictureBoxVisualizer.Image = ShowDeque();
            textBoxDebug.Text = deque.list.ToString();
        }

        private void buttonRemoveFrist_Click(object sender, EventArgs e)
        {
            if (deque == null)
            {
                return;
            }
            deque.PopFirst();
            stateStorage.AddState(deque.SaveState());
            stateStorage.NextState();
            pictureBoxVisualizer.Image = ShowDeque();
            textBoxDebug.Text = deque.list.ToString();
        }

        private void buttonRemoveLast_Click(object sender, EventArgs e)
        {
            if (deque == null)
            {
                return;
            }
            deque.PopLast();
            stateStorage.AddState(deque.SaveState());
            stateStorage.NextState();
            pictureBoxVisualizer.Image = ShowDeque();
            textBoxDebug.Text = deque.list.ToString();
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
            textBoxDebug.Text = deque.list.ToString();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo form = new();
            form.Show();
        }

        private void buttonNextStep_Click(object sender, EventArgs e)
        {
            if (stateStorage.NextState())
            {
                deque.SetState(stateStorage.GetCurrentState());
                pictureBoxVisualizer.Image = ShowDeque();
            }
            return;
        }

        private void buttonPrevStep_Click(object sender, EventArgs e)
        {
            if (stateStorage.PreviousState())
            {
                deque.SetState(stateStorage.GetCurrentState());
                pictureBoxVisualizer.Image = ShowDeque();
            }
            return;
        }
    }
}
