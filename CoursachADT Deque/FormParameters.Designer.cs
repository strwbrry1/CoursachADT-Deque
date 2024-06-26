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
            checkBoxStartValue = new CheckBox();
            numericUpDownValues = new NumericUpDown();
            buttonCreate = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownValues).BeginInit();
            SuspendLayout();
            // 
            // checkBoxStartValue
            // 
            checkBoxStartValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxStartValue.AutoSize = true;
            checkBoxStartValue.Location = new Point(10, 11);
            checkBoxStartValue.Margin = new Padding(3, 2, 3, 2);
            checkBoxStartValue.Name = "checkBoxStartValue";
            checkBoxStartValue.Size = new Size(180, 19);
            checkBoxStartValue.TabIndex = 3;
            checkBoxStartValue.Text = "Задать начальные значения";
            checkBoxStartValue.UseVisualStyleBackColor = true;
            checkBoxStartValue.CheckedChanged += checkBoxStartValue_CheckedChanged;
            // 
            // numericUpDownValues
            // 
            numericUpDownValues.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownValues.Enabled = false;
            numericUpDownValues.Location = new Point(10, 34);
            numericUpDownValues.Margin = new Padding(3, 2, 3, 2);
            numericUpDownValues.Name = "numericUpDownValues";
            numericUpDownValues.Size = new Size(79, 23);
            numericUpDownValues.TabIndex = 4;
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCreate.Location = new Point(10, 62);
            buttonCreate.Margin = new Padding(3, 2, 3, 2);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(135, 29);
            buttonCreate.TabIndex = 5;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCancel.BackColor = Color.LightCoral;
            buttonCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCancel.ForeColor = SystemColors.ActiveCaptionText;
            buttonCancel.Location = new Point(154, 62);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(135, 29);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormParameters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 106);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCreate);
            Controls.Add(numericUpDownValues);
            Controls.Add(checkBoxStartValue);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(317, 145);
            MinimumSize = new Size(317, 145);
            Name = "FormParameters";
            Text = "Начальные параметры";
            ((System.ComponentModel.ISupportInitialize)numericUpDownValues).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox checkBoxStartValue;
        private NumericUpDown numericUpDownValues;
        private Button buttonCreate;
        private Button buttonCancel;
    }
}