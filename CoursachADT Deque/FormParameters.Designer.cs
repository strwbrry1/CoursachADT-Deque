namespace CoursachADT_Deque
{
    partial class FormParameters
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelType = new Label();
            checkBoxStartValue = new CheckBox();
            numericUpDownValues = new NumericUpDown();
            buttonCreate = new Button();
            buttonCancel = new Button();
            numericUpDownMaxSize = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownValues).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxSize).BeginInit();
            SuspendLayout();
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(12, 9);
            labelType.Name = "labelType";
            labelType.Size = new Size(238, 20);
            labelType.TabIndex = 2;
            labelType.Text = "Максимум элементов в очереди:";
            // 
            // checkBoxStartValue
            // 
            checkBoxStartValue.AutoSize = true;
            checkBoxStartValue.Location = new Point(12, 89);
            checkBoxStartValue.Name = "checkBoxStartValue";
            checkBoxStartValue.Size = new Size(228, 24);
            checkBoxStartValue.TabIndex = 3;
            checkBoxStartValue.Text = "Задать начальные значения";
            checkBoxStartValue.UseVisualStyleBackColor = true;
            checkBoxStartValue.CheckedChanged += checkBoxStartValue_CheckedChanged;
            // 
            // numericUpDownValues
            // 
            numericUpDownValues.Enabled = false;
            numericUpDownValues.Location = new Point(12, 119);
            numericUpDownValues.Name = "numericUpDownValues";
            numericUpDownValues.Size = new Size(90, 27);
            numericUpDownValues.TabIndex = 4;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(12, 162);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(154, 39);
            buttonCreate.TabIndex = 5;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.LightCoral;
            buttonCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCancel.ForeColor = SystemColors.ActiveCaptionText;
            buttonCancel.Location = new Point(176, 162);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(154, 39);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // numericUpDownMaxSize
            // 
            numericUpDownMaxSize.Location = new Point(12, 32);
            numericUpDownMaxSize.Name = "numericUpDownMaxSize";
            numericUpDownMaxSize.Size = new Size(90, 27);
            numericUpDownMaxSize.TabIndex = 7;
            // 
            // FormParameters
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 213);
            Controls.Add(numericUpDownMaxSize);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCreate);
            Controls.Add(numericUpDownValues);
            Controls.Add(checkBoxStartValue);
            Controls.Add(labelType);
            MaximumSize = new Size(360, 260);
            MinimumSize = new Size(360, 260);
            Name = "FormParameters";
            Text = "Начальные параметры";
            ((System.ComponentModel.ISupportInitialize)numericUpDownValues).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelType;
        private CheckBox checkBoxStartValue;
        private NumericUpDown numericUpDownValues;
        private Button buttonCreate;
        private Button buttonCancel;
        private NumericUpDown numericUpDownMaxSize;
    }
}