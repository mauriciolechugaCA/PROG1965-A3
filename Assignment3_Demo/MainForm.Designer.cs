namespace Assignment3_Demo
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
            buttonStartNewNode = new Button();
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
            // buttonStartNewNode
            // 
            buttonStartNewNode.Location = new Point(41, 28);
            buttonStartNewNode.Name = "buttonStartNewNode";
            buttonStartNewNode.Size = new Size(132, 29);
            buttonStartNewNode.TabIndex = 0;
            buttonStartNewNode.Text = "Start new node";
            buttonStartNewNode.UseVisualStyleBackColor = true;
            // 
            // listBoxNotes
            // 
            listBoxNotes.FormattingEnabled = true;
            listBoxNotes.Location = new Point(41, 79);
            listBoxNotes.Name = "listBoxNotes";
            listBoxNotes.Size = new Size(191, 424);
            listBoxNotes.TabIndex = 1;
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
            groupBoxEcounterNote.Location = new Point(274, 12);
            groupBoxEcounterNote.Name = "groupBoxEcounterNote";
            groupBoxEcounterNote.Size = new Size(866, 531);
            groupBoxEcounterNote.TabIndex = 2;
            groupBoxEcounterNote.TabStop = false;
            groupBoxEcounterNote.Text = "Add/Edit/Delet Ecounter Note:";
            // 
            // listBoxVitals
            // 
            listBoxVitals.FormattingEnabled = true;
            listBoxVitals.Location = new Point(635, 64);
            listBoxVitals.Name = "listBoxVitals";
            listBoxVitals.Size = new Size(207, 204);
            listBoxVitals.TabIndex = 19;
            // 
            // buttonDeleteNote
            // 
            buttonDeleteNote.Location = new Point(297, 489);
            buttonDeleteNote.Name = "buttonDeleteNote";
            buttonDeleteNote.Size = new Size(119, 29);
            buttonDeleteNote.TabIndex = 18;
            buttonDeleteNote.Text = "Delete Note";
            buttonDeleteNote.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateNote
            // 
            buttonUpdateNote.Location = new Point(165, 489);
            buttonUpdateNote.Name = "buttonUpdateNote";
            buttonUpdateNote.Size = new Size(119, 29);
            buttonUpdateNote.TabIndex = 17;
            buttonUpdateNote.Text = "Update note";
            buttonUpdateNote.UseVisualStyleBackColor = true;
            // 
            // buttonAddNote
            // 
            buttonAddNote.Location = new Point(33, 489);
            buttonAddNote.Name = "buttonAddNote";
            buttonAddNote.Size = new Size(119, 29);
            buttonAddNote.TabIndex = 16;
            buttonAddNote.Text = "Add note";
            buttonAddNote.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 272);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 15;
            label7.Text = "Notes:";
            // 
            // richTextBoxNotes
            // 
            richTextBoxNotes.Location = new Point(33, 295);
            richTextBoxNotes.Name = "richTextBoxNotes";
            richTextBoxNotes.Size = new Size(809, 166);
            richTextBoxNotes.TabIndex = 14;
            richTextBoxNotes.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(627, 35);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 13;
            label6.Text = "Vitals";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(470, 36);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 12;
            label5.Text = "Problems";
            // 
            // buttonRemoveProblem
            // 
            buttonRemoveProblem.Location = new Point(470, 246);
            buttonRemoveProblem.Name = "buttonRemoveProblem";
            buttonRemoveProblem.Size = new Size(134, 29);
            buttonRemoveProblem.TabIndex = 10;
            buttonRemoveProblem.Text = "Remove Problem";
            buttonRemoveProblem.UseVisualStyleBackColor = true;
            // 
            // listBoxProblems
            // 
            listBoxProblems.FormattingEnabled = true;
            listBoxProblems.Location = new Point(471, 63);
            listBoxProblems.Name = "listBoxProblems";
            listBoxProblems.Size = new Size(141, 164);
            listBoxProblems.TabIndex = 9;
            // 
            // buttonAddNewProblem
            // 
            buttonAddNewProblem.Location = new Point(360, 182);
            buttonAddNewProblem.Name = "buttonAddNewProblem";
            buttonAddNewProblem.Size = new Size(59, 29);
            buttonAddNewProblem.TabIndex = 8;
            buttonAddNewProblem.Text = "Add";
            buttonAddNewProblem.UseVisualStyleBackColor = true;
            // 
            // textBoxNewProblem
            // 
            textBoxNewProblem.Location = new Point(129, 182);
            textBoxNewProblem.Name = "textBoxNewProblem";
            textBoxNewProblem.Size = new Size(212, 27);
            textBoxNewProblem.TabIndex = 7;
            // 
            // dateTimePickerDateOfBirth
            // 
            dateTimePickerDateOfBirth.Format = DateTimePickerFormat.Short;
            dateTimePickerDateOfBirth.Location = new Point(129, 135);
            dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            dateTimePickerDateOfBirth.Size = new Size(117, 27);
            dateTimePickerDateOfBirth.TabIndex = 6;
            // 
            // textBoxPatientName
            // 
            textBoxPatientName.Location = new Point(129, 88);
            textBoxPatientName.Name = "textBoxPatientName";
            textBoxPatientName.Size = new Size(276, 27);
            textBoxPatientName.TabIndex = 5;
            // 
            // textBoxNoteID
            // 
            textBoxNoteID.Location = new Point(129, 41);
            textBoxNoteID.Name = "textBoxNoteID";
            textBoxNoteID.Size = new Size(125, 27);
            textBoxNoteID.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 191);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 3;
            label4.Text = "New problem:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 142);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Date of Birth:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 91);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "Patient name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 48);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Note ID:";
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(41, 528);
            labelMessage.MinimumSize = new Size(180, 50);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(180, 50);
            labelMessage.TabIndex = 3;
            labelMessage.Text = "Message container";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 630);
            Controls.Add(labelMessage);
            Controls.Add(groupBoxEcounterNote);
            Controls.Add(listBoxNotes);
            Controls.Add(buttonStartNewNode);
            Name = "MainForm";
            Text = "Assignment 3 Demo";
            groupBoxEcounterNote.ResumeLayout(false);
            groupBoxEcounterNote.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStartNewNode;
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
