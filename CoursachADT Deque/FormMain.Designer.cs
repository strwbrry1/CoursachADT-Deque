namespace CoursachADT_Deque
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAddFirst = new Button();
            buttonAddLast = new Button();
            buttonRemoveFrist = new Button();
            buttonRemoveLast = new Button();
            buttonClear = new Button();
            groupBoxControls = new GroupBox();
            textBoxDebug = new TextBox();
            button1 = new Button();
            buttonPrevStep = new Button();
            buttonNextStep = new Button();
            numericUpDownInput = new NumericUpDown();
            buttonCreateDeque = new Button();
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            pictureBoxVisualizer = new PictureBox();
            groupBoxControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInput).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVisualizer).BeginInit();
            SuspendLayout();
            // 
            // buttonAddFirst
            // 
            buttonAddFirst.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddFirst.BackColor = Color.FromArgb(128, 255, 128);
            buttonAddFirst.Location = new Point(182, 26);
            buttonAddFirst.Name = "buttonAddFirst";
            buttonAddFirst.Size = new Size(147, 48);
            buttonAddFirst.TabIndex = 1;
            buttonAddFirst.Text = "Добавить в начало";
            buttonAddFirst.UseVisualStyleBackColor = false;
            buttonAddFirst.Click += buttonAddFirst_Click;
            // 
            // buttonAddLast
            // 
            buttonAddLast.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddLast.BackColor = Color.FromArgb(128, 255, 128);
            buttonAddLast.Location = new Point(335, 26);
            buttonAddLast.Name = "buttonAddLast";
            buttonAddLast.Size = new Size(147, 48);
            buttonAddLast.TabIndex = 2;
            buttonAddLast.Text = "Добавить в конец";
            buttonAddLast.UseVisualStyleBackColor = false;
            buttonAddLast.Click += buttonAddLast_Click;
            // 
            // buttonRemoveFrist
            // 
            buttonRemoveFrist.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRemoveFrist.BackColor = Color.FromArgb(255, 192, 128);
            buttonRemoveFrist.Location = new Point(182, 80);
            buttonRemoveFrist.Name = "buttonRemoveFrist";
            buttonRemoveFrist.Size = new Size(147, 48);
            buttonRemoveFrist.TabIndex = 3;
            buttonRemoveFrist.Text = "Извлечь из начала";
            buttonRemoveFrist.UseVisualStyleBackColor = false;
            buttonRemoveFrist.Click += buttonRemoveFrist_Click;
            // 
            // buttonRemoveLast
            // 
            buttonRemoveLast.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRemoveLast.BackColor = Color.FromArgb(255, 192, 128);
            buttonRemoveLast.Location = new Point(335, 80);
            buttonRemoveLast.Name = "buttonRemoveLast";
            buttonRemoveLast.Size = new Size(147, 48);
            buttonRemoveLast.TabIndex = 4;
            buttonRemoveLast.Text = "Извлечь из конца";
            buttonRemoveLast.UseVisualStyleBackColor = false;
            buttonRemoveLast.Click += buttonRemoveLast_Click;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonClear.BackColor = Color.FromArgb(192, 0, 0);
            buttonClear.ForeColor = Color.Transparent;
            buttonClear.Location = new Point(488, 80);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(147, 48);
            buttonClear.TabIndex = 5;
            buttonClear.Text = "Очистить очередь";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // groupBoxControls
            // 
            groupBoxControls.Controls.Add(textBoxDebug);
            groupBoxControls.Controls.Add(button1);
            groupBoxControls.Controls.Add(buttonPrevStep);
            groupBoxControls.Controls.Add(buttonNextStep);
            groupBoxControls.Controls.Add(numericUpDownInput);
            groupBoxControls.Controls.Add(buttonCreateDeque);
            groupBoxControls.Controls.Add(buttonClear);
            groupBoxControls.Controls.Add(buttonAddFirst);
            groupBoxControls.Controls.Add(buttonRemoveLast);
            groupBoxControls.Controls.Add(buttonAddLast);
            groupBoxControls.Controls.Add(buttonRemoveFrist);
            groupBoxControls.Dock = DockStyle.Bottom;
            groupBoxControls.Location = new Point(0, 461);
            groupBoxControls.Name = "groupBoxControls";
            groupBoxControls.Size = new Size(1166, 142);
            groupBoxControls.TabIndex = 6;
            groupBoxControls.TabStop = false;
            groupBoxControls.Text = "Управление";
            // 
            // textBoxDebug
            // 
            textBoxDebug.Location = new Point(488, 26);
            textBoxDebug.Name = "textBoxDebug";
            textBoxDebug.Size = new Size(147, 23);
            textBoxDebug.TabIndex = 11;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.Teal;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(957, 80);
            button1.Name = "button1";
            button1.Size = new Size(203, 48);
            button1.TabIndex = 10;
            button1.Text = "Проход по изменениям";
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonPrevStep
            // 
            buttonPrevStep.Location = new Point(1063, 26);
            buttonPrevStep.Name = "buttonPrevStep";
            buttonPrevStep.Size = new Size(97, 48);
            buttonPrevStep.TabIndex = 9;
            buttonPrevStep.Text = "Назад";
            buttonPrevStep.UseVisualStyleBackColor = true;
            // 
            // buttonNextStep
            // 
            buttonNextStep.Location = new Point(957, 26);
            buttonNextStep.Name = "buttonNextStep";
            buttonNextStep.Size = new Size(97, 48);
            buttonNextStep.TabIndex = 8;
            buttonNextStep.Text = "Вперёд";
            buttonNextStep.UseVisualStyleBackColor = true;
            // 
            // numericUpDownInput
            // 
            numericUpDownInput.Location = new Point(6, 26);
            numericUpDownInput.Name = "numericUpDownInput";
            numericUpDownInput.Size = new Size(147, 23);
            numericUpDownInput.TabIndex = 7;
            // 
            // buttonCreateDeque
            // 
            buttonCreateDeque.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCreateDeque.Location = new Point(6, 81);
            buttonCreateDeque.Name = "buttonCreateDeque";
            buttonCreateDeque.Size = new Size(147, 48);
            buttonCreateDeque.TabIndex = 6;
            buttonCreateDeque.Text = "Создать очередь";
            buttonCreateDeque.UseVisualStyleBackColor = true;
            buttonCreateDeque.Click += buttonCreateDeque_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1166, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { infoToolStripMenuItem, saveToolStripMenuItem, loadToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(53, 20);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(133, 22);
            infoToolStripMenuItem.Text = "Инфо";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(133, 22);
            saveToolStripMenuItem.Text = "Сохранить";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(133, 22);
            loadToolStripMenuItem.Text = "Загрузить";
            // 
            // pictureBoxVisualizer
            // 
            pictureBoxVisualizer.Dock = DockStyle.Fill;
            pictureBoxVisualizer.Location = new Point(0, 24);
            pictureBoxVisualizer.Name = "pictureBoxVisualizer";
            pictureBoxVisualizer.Size = new Size(1166, 437);
            pictureBoxVisualizer.TabIndex = 9;
            pictureBoxVisualizer.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 603);
            Controls.Add(pictureBoxVisualizer);
            Controls.Add(menuStrip1);
            Controls.Add(groupBoxControls);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "АТД Дек на двусвязном списке";
            groupBoxControls.ResumeLayout(false);
            groupBoxControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInput).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVisualizer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonAddFirst;
        private Button buttonAddLast;
        private Button buttonRemoveFrist;
        private Button buttonRemoveLast;
        private Button buttonClear;
        private GroupBox groupBoxControls;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private Button buttonCreateDeque;
        private PictureBox pictureBoxVisualizer;
        private NumericUpDown numericUpDownInput;
        private Button buttonPrevStep;
        private Button buttonNextStep;
        private Button button1;
        private TextBox textBoxDebug;
    }
}
