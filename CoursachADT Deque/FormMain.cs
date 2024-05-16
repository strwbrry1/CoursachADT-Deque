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
            deque = new DequeRealizer(parameters.maxSize, parameters.numElems);
            stateStorage.AddState(deque.SaveState());
            if (!deque.isEmpty())
            {
                pictureBoxVisualizer.Image = ShowDeque();
            }
        }

        private Bitmap? ShowDeque()
        {
            visualizer = new DrawingDeque(deque.SaveState());

            Bitmap bitmap = new(pictureBoxVisualizer.Width, pictureBoxVisualizer.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            visualizer.Visualize(graphics);
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
        }

        private void buttonAddLast_Click(object sender, EventArgs e)
        {
            if (deque == null)
            {
                return;
            }
            deque.InsertLast((int)numericUpDownInput.Value);
            stateStorage.AddState(deque.SaveState());
        }

        private void buttonRemoveFrist_Click(object sender, EventArgs e)
        {
            if (deque == null)
            {
                return;
            }
            deque.PopFirst();
            stateStorage.AddState(deque.SaveState());
        }

        private void buttonRemoveLast_Click(object sender, EventArgs e)
        {
            if (deque == null)
            {
                return;
            }
            deque.PopLast();
            stateStorage.AddState(deque.SaveState());
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (deque == null)
            {
                return;
            }
            deque.Clear();
            stateStorage.AddState(deque.SaveState());
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo form = new();
            form.Show();
        }
    }
}
