namespace SampleWinForm
{
    partial class MainForm
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
            nameLabel = new Label();
            nameText = new TextBox();
            emailLabel = new Label();
            emailText = new TextBox();
            birthdayLabel = new Label();
            birthdayDatePicker = new DateTimePicker();
            colorLabel = new Label();
            yellowRadioButton = new RadioButton();
            greenRadioButton = new RadioButton();
            purpleRadioButton = new RadioButton();
            marriedLabel = new Label();
            yesCheckBox = new CheckBox();
            submitButton = new Button();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(8, 17);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // nameText
            // 
            nameText.Location = new Point(69, 15);
            nameText.Margin = new Padding(2, 2, 2, 2);
            nameText.Name = "nameText";
            nameText.Size = new Size(336, 23);
            nameText.TabIndex = 1;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(8, 46);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(39, 15);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // emailText
            // 
            emailText.Location = new Point(69, 44);
            emailText.Margin = new Padding(2, 2, 2, 2);
            emailText.Name = "emailText";
            emailText.Size = new Size(336, 23);
            emailText.TabIndex = 3;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new Point(8, 73);
            birthdayLabel.Margin = new Padding(2, 0, 2, 0);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(54, 15);
            birthdayLabel.TabIndex = 4;
            birthdayLabel.Text = "Birthday:";
            // 
            // birthdayDatePicker
            // 
            birthdayDatePicker.Location = new Point(69, 73);
            birthdayDatePicker.Margin = new Padding(2, 2, 2, 2);
            birthdayDatePicker.Name = "birthdayDatePicker";
            birthdayDatePicker.Size = new Size(335, 23);
            birthdayDatePicker.TabIndex = 5;
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new Point(8, 103);
            colorLabel.Margin = new Padding(2, 0, 2, 0);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(39, 15);
            colorLabel.TabIndex = 6;
            colorLabel.Text = "Color:";
            // 
            // yellowRadioButton
            // 
            yellowRadioButton.AutoSize = true;
            yellowRadioButton.Location = new Point(69, 103);
            yellowRadioButton.Margin = new Padding(2, 2, 2, 2);
            yellowRadioButton.Name = "yellowRadioButton";
            yellowRadioButton.Size = new Size(59, 19);
            yellowRadioButton.TabIndex = 7;
            yellowRadioButton.TabStop = true;
            yellowRadioButton.Text = "Yellow";
            yellowRadioButton.UseVisualStyleBackColor = true;
            // 
            // greenRadioButton
            // 
            greenRadioButton.AutoSize = true;
            greenRadioButton.Location = new Point(151, 103);
            greenRadioButton.Margin = new Padding(2, 2, 2, 2);
            greenRadioButton.Name = "greenRadioButton";
            greenRadioButton.Size = new Size(56, 19);
            greenRadioButton.TabIndex = 8;
            greenRadioButton.TabStop = true;
            greenRadioButton.Text = "Green";
            greenRadioButton.UseVisualStyleBackColor = true;
            // 
            // purpleRadioButton
            // 
            purpleRadioButton.AutoSize = true;
            purpleRadioButton.Location = new Point(234, 103);
            purpleRadioButton.Margin = new Padding(2, 2, 2, 2);
            purpleRadioButton.Name = "purpleRadioButton";
            purpleRadioButton.Size = new Size(59, 19);
            purpleRadioButton.TabIndex = 9;
            purpleRadioButton.TabStop = true;
            purpleRadioButton.Text = "Purple";
            purpleRadioButton.UseVisualStyleBackColor = true;
            // 
            // marriedLabel
            // 
            marriedLabel.AutoSize = true;
            marriedLabel.Location = new Point(8, 129);
            marriedLabel.Margin = new Padding(2, 0, 2, 0);
            marriedLabel.Name = "marriedLabel";
            marriedLabel.Size = new Size(51, 15);
            marriedLabel.TabIndex = 10;
            marriedLabel.Text = "Married:";
            // 
            // yesCheckBox
            // 
            yesCheckBox.AutoSize = true;
            yesCheckBox.Location = new Point(69, 129);
            yesCheckBox.Margin = new Padding(2, 2, 2, 2);
            yesCheckBox.Name = "yesCheckBox";
            yesCheckBox.Size = new Size(43, 19);
            yesCheckBox.TabIndex = 11;
            yesCheckBox.Text = "Yes";
            yesCheckBox.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(279, 146);
            submitButton.Margin = new Padding(2, 2, 2, 2);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(125, 20);
            submitButton.TabIndex = 12;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += SubmitButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(8, 184);
            dataGridView.Margin = new Padding(2, 2, 2, 2);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.Size = new Size(395, 243);
            dataGridView.TabIndex = 13;
            dataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(418, 454);
            Controls.Add(dataGridView);
            Controls.Add(submitButton);
            Controls.Add(yesCheckBox);
            Controls.Add(marriedLabel);
            Controls.Add(purpleRadioButton);
            Controls.Add(greenRadioButton);
            Controls.Add(yellowRadioButton);
            Controls.Add(colorLabel);
            Controls.Add(birthdayDatePicker);
            Controls.Add(birthdayLabel);
            Controls.Add(emailText);
            Controls.Add(emailLabel);
            Controls.Add(nameText);
            Controls.Add(nameLabel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MainForm";
            Text = "Sample";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameText;
        private Label emailLabel;
        private TextBox emailText;
        private Label birthdayLabel;
        private DateTimePicker birthdayDatePicker;
        private Label colorLabel;
        private RadioButton yellowRadioButton;
        private RadioButton greenRadioButton;
        private RadioButton purpleRadioButton;
        private Label marriedLabel;
        private CheckBox yesCheckBox;
        private Button submitButton;
        private DataGridView dataGridView;
    }
}