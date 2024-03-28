namespace Assignment3
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
            buttonStartNewNote = new Button();
            listBoxNotes = new ListBox();
            groupBoxEcounterNote = new GroupBox();
            listBoxVitals = new ListBox();
            buttonDeleteNote = new Button();
            buttonUpdateNote = new Button();
            buttonAddNote = new Button();
            label7 = new Label();
            richTextBoxNotes = new RichTextBox();
            label6 = new Label();
            label5 = new Label();
            buttonRemoveProblem = new Button();
            listBoxProblems = new ListBox();
            buttonAddNewProblem = new Button();
            textBoxNewProblem = new TextBox();
            dateTimePickerDateOfBirth = new DateTimePicker();
            textBoxPatientName = new TextBox();
            textBoxNoteID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelMessage = new Label();
            groupBoxEcounterNote.SuspendLayout();
            SuspendLayout();
            // 
            // buttonStartNewNote
            // 
            buttonStartNewNote.Location = new Point(36, 21);
            buttonStartNewNote.Margin = new Padding(3, 2, 3, 2);
            buttonStartNewNote.Name = "buttonStartNewNote";
            buttonStartNewNote.Size = new Size(116, 22);
            buttonStartNewNote.TabIndex = 0;
            buttonStartNewNote.Text = "Start new note";
            buttonStartNewNote.UseVisualStyleBackColor = true;
            buttonStartNewNote.Click += buttonStartNewNote_Click;
            // 
            // listBoxNotes
            // 
            listBoxNotes.FormattingEnabled = true;
            listBoxNotes.ItemHeight = 15;
            listBoxNotes.Location = new Point(36, 59);
            listBoxNotes.Margin = new Padding(3, 2, 3, 2);
            listBoxNotes.Name = "listBoxNotes";
            listBoxNotes.Size = new Size(168, 319);
            listBoxNotes.TabIndex = 1;
            listBoxNotes.SelectedIndexChanged += listBoxNotes_SelectedIndexChanged;
            // 
            // groupBoxEcounterNote
            // 
            groupBoxEcounterNote.Controls.Add(listBoxVitals);
            groupBoxEcounterNote.Controls.Add(buttonDeleteNote);
            groupBoxEcounterNote.Controls.Add(buttonUpdateNote);
            groupBoxEcounterNote.Controls.Add(buttonAddNote);
            groupBoxEcounterNote.Controls.Add(label7);
            groupBoxEcounterNote.Controls.Add(richTextBoxNotes);
            groupBoxEcounterNote.Controls.Add(label6);
            groupBoxEcounterNote.Controls.Add(label5);
            groupBoxEcounterNote.Controls.Add(buttonRemoveProblem);
            groupBoxEcounterNote.Controls.Add(listBoxProblems);
            groupBoxEcounterNote.Controls.Add(buttonAddNewProblem);
            groupBoxEcounterNote.Controls.Add(textBoxNewProblem);
            groupBoxEcounterNote.Controls.Add(dateTimePickerDateOfBirth);
            groupBoxEcounterNote.Controls.Add(textBoxPatientName);
            groupBoxEcounterNote.Controls.Add(textBoxNoteID);
            groupBoxEcounterNote.Controls.Add(label4);
            groupBoxEcounterNote.Controls.Add(label3);
            groupBoxEcounterNote.Controls.Add(label2);
            groupBoxEcounterNote.Controls.Add(label1);
            groupBoxEcounterNote.Enabled = false;
            groupBoxEcounterNote.Location = new Point(240, 9);
            groupBoxEcounterNote.Margin = new Padding(3, 2, 3, 2);
            groupBoxEcounterNote.Name = "groupBoxEcounterNote";
            groupBoxEcounterNote.Padding = new Padding(3, 2, 3, 2);
            groupBoxEcounterNote.Size = new Size(758, 398);
            groupBoxEcounterNote.TabIndex = 2;
            groupBoxEcounterNote.TabStop = false;
            groupBoxEcounterNote.Text = "Add/Edit/Delet Ecounter Note:";
            // 
            // listBoxVitals
            // 
            listBoxVitals.FormattingEnabled = true;
            listBoxVitals.ItemHeight = 15;
            listBoxVitals.Location = new Point(556, 48);
            listBoxVitals.Margin = new Padding(3, 2, 3, 2);
            listBoxVitals.Name = "listBoxVitals";
            listBoxVitals.Size = new Size(182, 154);
            listBoxVitals.TabIndex = 19;
            // 
            // buttonDeleteNote
            // 
            buttonDeleteNote.Location = new Point(260, 367);
            buttonDeleteNote.Margin = new Padding(3, 2, 3, 2);
            buttonDeleteNote.Name = "buttonDeleteNote";
            buttonDeleteNote.Size = new Size(104, 22);
            buttonDeleteNote.TabIndex = 18;
            buttonDeleteNote.Text = "Delete Note";
            buttonDeleteNote.UseVisualStyleBackColor = true;
            buttonDeleteNote.Click += buttonDeleteNote_Click;
            // 
            // buttonUpdateNote
            // 
            buttonUpdateNote.Location = new Point(144, 367);
            buttonUpdateNote.Margin = new Padding(3, 2, 3, 2);
            buttonUpdateNote.Name = "buttonUpdateNote";
            buttonUpdateNote.Size = new Size(104, 22);
            buttonUpdateNote.TabIndex = 17;
            buttonUpdateNote.Text = "Update note";
            buttonUpdateNote.UseVisualStyleBackColor = true;
            buttonUpdateNote.Click += buttonUpdateNote_Click;
            // 
            // buttonAddNote
            // 
            buttonAddNote.Location = new Point(29, 367);
            buttonAddNote.Margin = new Padding(3, 2, 3, 2);
            buttonAddNote.Name = "buttonAddNote";
            buttonAddNote.Size = new Size(104, 22);
            buttonAddNote.TabIndex = 16;
            buttonAddNote.Text = "Add note";
            buttonAddNote.UseVisualStyleBackColor = true;
            buttonAddNote.Click += buttonAddNote_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 204);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 15;
            label7.Text = "Notes:";
            // 
            // richTextBoxNotes
            // 
            richTextBoxNotes.Location = new Point(29, 221);
            richTextBoxNotes.Margin = new Padding(3, 2, 3, 2);
            richTextBoxNotes.Name = "richTextBoxNotes";
            richTextBoxNotes.Size = new Size(708, 126);
            richTextBoxNotes.TabIndex = 14;
            richTextBoxNotes.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(549, 26);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 13;
            label6.Text = "Vitals";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(411, 27);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 12;
            label5.Text = "Problems";
            // 
            // buttonRemoveProblem
            // 
            buttonRemoveProblem.Location = new Point(411, 184);
            buttonRemoveProblem.Margin = new Padding(3, 2, 3, 2);
            buttonRemoveProblem.Name = "buttonRemoveProblem";
            buttonRemoveProblem.Size = new Size(117, 22);
            buttonRemoveProblem.TabIndex = 10;
            buttonRemoveProblem.Text = "Remove Problem";
            buttonRemoveProblem.UseVisualStyleBackColor = true;
            buttonRemoveProblem.Click += buttonRemoveProblem_Click;
            // 
            // listBoxProblems
            // 
            listBoxProblems.FormattingEnabled = true;
            listBoxProblems.ItemHeight = 15;
            listBoxProblems.Location = new Point(412, 47);
            listBoxProblems.Margin = new Padding(3, 2, 3, 2);
            listBoxProblems.Name = "listBoxProblems";
            listBoxProblems.Size = new Size(124, 124);
            listBoxProblems.TabIndex = 9;
            // 
            // buttonAddNewProblem
            // 
            buttonAddNewProblem.Location = new Point(315, 136);
            buttonAddNewProblem.Margin = new Padding(3, 2, 3, 2);
            buttonAddNewProblem.Name = "buttonAddNewProblem";
            buttonAddNewProblem.Size = new Size(52, 22);
            buttonAddNewProblem.TabIndex = 8;
            buttonAddNewProblem.Text = "Add";
            buttonAddNewProblem.UseVisualStyleBackColor = true;
            buttonAddNewProblem.Click += buttonAddNewProblem_Click;
            // 
            // textBoxNewProblem
            // 
            textBoxNewProblem.Location = new Point(113, 136);
            textBoxNewProblem.Margin = new Padding(3, 2, 3, 2);
            textBoxNewProblem.Name = "textBoxNewProblem";
            textBoxNewProblem.Size = new Size(186, 23);
            textBoxNewProblem.TabIndex = 7;
            // 
            // dateTimePickerDateOfBirth
            // 
            dateTimePickerDateOfBirth.Format = DateTimePickerFormat.Short;
            dateTimePickerDateOfBirth.Location = new Point(113, 101);
            dateTimePickerDateOfBirth.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            dateTimePickerDateOfBirth.Size = new Size(103, 23);
            dateTimePickerDateOfBirth.TabIndex = 6;
            // 
            // textBoxPatientName
            // 
            textBoxPatientName.Location = new Point(113, 66);
            textBoxPatientName.Margin = new Padding(3, 2, 3, 2);
            textBoxPatientName.Name = "textBoxPatientName";
            textBoxPatientName.Size = new Size(242, 23);
            textBoxPatientName.TabIndex = 5;
            // 
            // textBoxNoteID
            // 
            textBoxNoteID.Location = new Point(113, 31);
            textBoxNoteID.Margin = new Padding(3, 2, 3, 2);
            textBoxNoteID.Name = "textBoxNoteID";
            textBoxNoteID.Size = new Size(110, 23);
            textBoxNoteID.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 143);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 3;
            label4.Text = "New problem:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 106);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 2;
            label3.Text = "Date of Birth:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 68);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Patient name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 36);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Note ID:";
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(36, 412);
            labelMessage.MinimumSize = new Size(158, 38);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(158, 38);
            labelMessage.TabIndex = 3;
            labelMessage.Text = "Message container";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 472);
            Controls.Add(labelMessage);
            Controls.Add(groupBoxEcounterNote);
            Controls.Add(listBoxNotes);
            Controls.Add(buttonStartNewNote);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Assignment 3";
            groupBoxEcounterNote.ResumeLayout(false);
            groupBoxEcounterNote.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStartNewNote;
        private ListBox listBoxNotes;
        private GroupBox groupBoxEcounterNote;
        private DateTimePicker dateTimePickerDateOfBirth;
        private TextBox textBoxPatientName;
        private TextBox textBoxNoteID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonAddNewProblem;
        private TextBox textBoxNewProblem;
        private Button buttonRemoveProblem;
        private ListBox listBoxProblems;
        private Label label7;
        private RichTextBox richTextBoxNotes;
        private Label label6;
        private Label label5;
        private Label labelMessage;
        private Button buttonDeleteNote;
        private Button buttonUpdateNote;
        private Button buttonAddNote;
        private ListBox listBoxVitals;
    }
}
