

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

        public MainForm()
        {
            InitializeComponent();

            noteManager = new NoteManager();
            ValidationHelper validation = new ValidationHelper(alertMessages);

            //Getting all the notes from the file
            foreach (Note x in noteManager.ListNotes())
            {
                listBoxNotes.Items.Add($"{x.PatientName}: {x.NoteId}");
            }

        }

        public void buttonStartNewNode_Click(object sender, EventArgs e)
        {
            //No note loaded
            newNote = null;

            //Managing all the fields and buttons. Enable and Disable
            textBoxNoteID.Enabled = false;
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
            textBoxNoteID.Text = string.Empty; //TODO: Load the UniqueID
            textBoxPatientName.Text = string.Empty;
            dateTimePickerDateOfBirth.Value = DateTime.Now;
            textBoxNewProblem.Text = string.Empty;
            listBoxProblems.Items.Clear();
            listBoxVitals.Items.Clear();
            richTextBoxNotes.Text = string.Empty;
        }

        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            alertMessages.Clear();

            int nextNoteId = noteManager.GetNextNoteId();
            textBoxNoteID.Text = nextNoteId.ToString();

            ValidationHelper validation = new ValidationHelper(alertMessages);

            //Validations using the VallidationHelper class
            validation.IsValidPatientName(textBoxPatientName.Text);
            validation.IsValidPatientDOB(dateTimePickerDateOfBirth.Value);

            //Checking if has any error
            if (alertMessages.Length > 0)
            {
                labelMessage.ForeColor = Color.Red;
                labelMessage.Text = alertMessages.ToString();
            }
            else
            {
                
                Note newNote = new Note
                    (
                        nextNoteId, // O ID será gerado posteriormente
                        textBoxPatientName.Text,
                        dateTimePickerDateOfBirth.Value,
                        listBoxProblems.Items.Cast<string>().FirstOrDefault(),
                        richTextBoxNotes.Text
                        );

                // Adiciona a nova nota à lista de notas no NoteManager
                noteManager.AddNote(newNote);

                labelMessage.ForeColor = Color.Green;
                labelMessage.Text = "Note added successfully.";
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
        }
    }
}
