

using System.Collections;
using System.Text;

/** 
 * 
 * Assignment 3 for PROG1965
 * 
 * Fernando Carvalho de Souza
 * Mauricio Lechuga
 * 
 * March 2024
 * 
 */

namespace Assignment3
{
    public partial class MainForm : Form
    {
        private NoteManager noteManager;
        private Note newNote;
        public StringBuilder alertMessages = new StringBuilder();
        public int nextNoteId = 0;

        public MainForm()
        {
            InitializeComponent();

            //labelMessage.Text = "Teste";

            noteManager = new NoteManager();
            ValidationHelper validation = new ValidationHelper(alertMessages);
            noteManager.LoadNote();

            //Getting all the notes from the file
            UpdateList();

        }

        public void UpdateList()
        {
            listBoxNotes.Items.Clear();

            foreach (Note x in noteManager.ListNotes())
            {
                listBoxNotes.Items.Add($"{x.PatientName} (NoteId: {x.NoteId})");
            }
        }

        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            alertMessages.Clear();


            ValidationHelper validation = new ValidationHelper(alertMessages);

            //Validations using the VallidationHelper class
            validation.IsValidPatientName(textBoxPatientName.Text);
            validation.IsValidPatientDOB(dateTimePickerDateOfBirth.Value.Date);

            //Checking if has any error
            if (alertMessages.Length > 0)
            {
                labelMessage.ForeColor = Color.Red;
                labelMessage.Text = alertMessages.ToString();
            }
            else
            {
                //Replacing the '\n' by '; '
                //string listProblems = listBoxProblems.Items.Replace("\n", "; ");
                List<string> listProblems = listBoxProblems.Items.Cast<string>().ToList();
                string problems = string.Join(";", listProblems);

                Note newNote = new Note
                    (
                        nextNoteId, // O ID será gerado posteriormente
                        textBoxPatientName.Text,
                        dateTimePickerDateOfBirth.Value.Date,
                        problems
                        //richTextBoxNotes.Text
                        );

                noteManager.AddNote(newNote);

                labelMessage.ForeColor = Color.Black;
                labelMessage.Text = $"NoteId: {nextNoteId} added successfully.";

                //Cleaning all the fields
                //Managing all the fields and buttons. Enable and Disable
                textBoxNoteID.Enabled = false;
                groupBoxEcounterNote.Enabled = false;
                textBoxPatientName.Enabled = false;
                dateTimePickerDateOfBirth.Enabled = false;
                textBoxNewProblem.Enabled = false;
                buttonAddNewProblem.Enabled = false;
                richTextBoxNotes.Enabled = false;
                buttonRemoveProblem.Enabled = false;
                buttonAddNote.Enabled = false;
                buttonUpdateNote.Enabled = false;
                buttonDeleteNote.Enabled = false;

                //Cleaning all the fields of the form
                textBoxNoteID.Text = string.Empty;
                textBoxPatientName.Text = string.Empty;
                dateTimePickerDateOfBirth.Value = DateTime.Now;
                textBoxNewProblem.Text = string.Empty;
                listBoxProblems.Items.Clear();
                listBoxVitals.Items.Clear();
                richTextBoxNotes.Text = string.Empty;

                //Updating list
                UpdateList();

            }

        }

        private void buttonAddNewProblem_Click(object sender, EventArgs e)
        {
            //TODO: Add the validations

            //Add the new problem to the problem list
            listBoxProblems.Items.Add(textBoxNewProblem.Text);
            //Clearing the newProblem text box
            textBoxNewProblem.Text = string.Empty;

        }

        private void buttonRemoveProblem_Click(object sender, EventArgs e)
        {
            //TODO: Add the validations

            //Removing the selected problem in the list
            listBoxProblems.Items.Remove(listBoxProblems.SelectedItem);

            List<string> listProblems = listBoxProblems.Items.Cast<string>().ToList();
            string problems = string.Join(";", listProblems);

            noteManager.UpdateNote(Int32.Parse(textBoxNoteID.Text), textBoxPatientName.Text, dateTimePickerDateOfBirth.Value.Date, problems);

            labelMessage.ForeColor = Color.Black;
            labelMessage.Text = $"NoteId: {textBoxNoteID.Text} updated successfully after a problem was removed.";
        }

        private void buttonStartNewNote_Click(object sender, EventArgs e)
        {
            //No note loaded
            newNote = null;

            //Geting the new ID
            nextNoteId = noteManager.GetNextNoteId();
            textBoxNoteID.Text = nextNoteId.ToString();

            //labelMessage.Text = "Test: click start new note";

            //Managing all the fields and buttons. Enable and Disable
            textBoxNoteID.Enabled = false;
            groupBoxEcounterNote.Enabled = true;
            textBoxPatientName.Enabled = true;
            dateTimePickerDateOfBirth.Enabled = true;
            textBoxNewProblem.Enabled = true;
            buttonAddNewProblem.Enabled = true;
            richTextBoxNotes.Enabled = true;
            buttonRemoveProblem.Enabled = true;
            buttonAddNote.Enabled = true;
            buttonUpdateNote.Enabled = false;
            buttonDeleteNote.Enabled = false;

            //Cleaning all the fields of the form
            textBoxPatientName.Text = string.Empty;
            dateTimePickerDateOfBirth.Value = DateTime.Now;
            textBoxNewProblem.Text = string.Empty;
            listBoxProblems.Items.Clear();
            listBoxVitals.Items.Clear();
            richTextBoxNotes.Text = string.Empty;
        }

        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Managing all the fields and buttons. Enable and Disable
            textBoxNoteID.Enabled = false;
            groupBoxEcounterNote.Enabled = true;
            textBoxPatientName.Enabled = true;
            dateTimePickerDateOfBirth.Enabled = true;
            textBoxNewProblem.Enabled = true;
            buttonAddNewProblem.Enabled = true;
            richTextBoxNotes.Enabled = true;
            buttonRemoveProblem.Enabled = true;
            buttonAddNote.Enabled = false;
            buttonUpdateNote.Enabled = true;
            buttonDeleteNote.Enabled = true;

            //Clearing the values from the last selection
            textBoxPatientName.Text = string.Empty;
            dateTimePickerDateOfBirth.Value = DateTime.Now;
            textBoxNewProblem.Text = string.Empty;
            listBoxProblems.Items.Clear();
            listBoxVitals.Items.Clear();
            richTextBoxNotes.Text = string.Empty;
            textBoxNoteID.Text = string.Empty;


            //Geting the selectedd index
            int selectedIndex = listBoxNotes.SelectedIndex;

            //Getting the list
            List<Note> notes = noteManager.ListNotes();

            //Getting the object note using the index
            Note selectedNote = notes[selectedIndex];

            //Getting the noteid
            int selectedNoteId = selectedNote.NoteId;

            //Updating the fields
            textBoxNoteID.Text = selectedNote.NoteId.ToString();
            textBoxPatientName.Text = selectedNote.PatientName;
            dateTimePickerDateOfBirth.Value = selectedNote.PatientDOB;
            //listBoxProblems.Items = selectedNote.PatientProblem;

            //Using the ';' to break the string to a list
            List<string> problems = selectedNote.PatientProblem.Split(';').ToList();
            foreach (string x in problems)
            {
                listBoxProblems.Items.Add(x);
            }

        }

        private void buttonUpdateNote_Click(object sender, EventArgs e)
        {
            List<string> listProblems = listBoxProblems.Items.Cast<string>().ToList();
            string problems = string.Join(";", listProblems);

            noteManager.UpdateNote(Int32.Parse(textBoxNoteID.Text), textBoxPatientName.Text, dateTimePickerDateOfBirth.Value.Date, problems);

            labelMessage.ForeColor = Color.Black;
            labelMessage.Text = $"NoteId: {textBoxNoteID.Text} updated successfully.";

            //Cleaning all the fields
            //Managing all the fields and buttons. Enable and Disable
            textBoxNoteID.Enabled = false;
            groupBoxEcounterNote.Enabled = false;
            textBoxPatientName.Enabled = false;
            dateTimePickerDateOfBirth.Enabled = false;
            textBoxNewProblem.Enabled = false;
            buttonAddNewProblem.Enabled = false;
            richTextBoxNotes.Enabled = false;
            buttonRemoveProblem.Enabled = false;
            buttonAddNote.Enabled = false;
            buttonUpdateNote.Enabled = false;
            buttonDeleteNote.Enabled = false;

            //Cleaning all the fields of the form
            textBoxNoteID.Text = string.Empty;
            textBoxPatientName.Text = string.Empty;
            dateTimePickerDateOfBirth.Value = DateTime.Now;
            textBoxNewProblem.Text = string.Empty;
            listBoxProblems.Items.Clear();
            listBoxVitals.Items.Clear();
            richTextBoxNotes.Text = string.Empty;

            //Updating list
            UpdateList();
        }

        private void buttonDeleteNote_Click(object sender, EventArgs e)
        {
            noteManager.DeleteNote(Int32.Parse(textBoxNoteID.Text));

            labelMessage.ForeColor = Color.Black;
            labelMessage.Text = $"NoteId: {textBoxNoteID.Text} updated successfully.";

            //Managing all the fields and buttons. Enable and Disable
            textBoxNoteID.Enabled = false;
            groupBoxEcounterNote.Enabled = false;
            textBoxPatientName.Enabled = false;
            dateTimePickerDateOfBirth.Enabled = false;
            textBoxNewProblem.Enabled = false;
            buttonAddNewProblem.Enabled = false;
            richTextBoxNotes.Enabled = false;
            buttonRemoveProblem.Enabled = false;
            buttonAddNote.Enabled = false;
            buttonUpdateNote.Enabled = false;
            buttonDeleteNote.Enabled = false;

            //Cleaning all the fields of the form
            textBoxNoteID.Text = string.Empty;
            textBoxPatientName.Text = string.Empty;
            dateTimePickerDateOfBirth.Value = DateTime.Now;
            textBoxNewProblem.Text = string.Empty;
            listBoxProblems.Items.Clear();
            listBoxVitals.Items.Clear();
            richTextBoxNotes.Text = string.Empty;

            //Updating list
            UpdateList();
        }
    }
}
