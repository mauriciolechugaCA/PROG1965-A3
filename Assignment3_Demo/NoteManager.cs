using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class NoteManager
    {
        /// <summary>
        /// List with the notes.
        /// List for object Note.
        /// </summary>
        private List<Note> listNotes;
        public string FileName {  get; set; }

        public NoteManager()
        {
            listNotes = new List<Note>();
            FileName = "patients_notes.txt";

        }

        /// <summary>
        /// Load the notes from the file.
        /// Display all the content.
        /// </summary>
        public void LoadNote()
        {
            //Checking if the file exists
            if (!File.Exists(FileName))
            {
                //TODO: Add some exception here
                return;
            }

            listNotes.Clear();

            //TODO: Add the using to load and read the file
            using (StreamReader reader = new StreamReader(FileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    int noteId = int.Parse(parts[0]);
                    string patientName = parts[1];
                    DateTime patientDOB = DateTime.Parse(parts[2]);
                    string patientProblem = parts[3];
                    string patientNotes = parts[4];

                    listNotes.Add(new Note(noteId, patientName, patientDOB, patientProblem, patientNotes));
                }
            }
        }

        /// <summary>
        /// Save/Write the note to the file.
        /// </summary>
        public void SaveNote()
        {
            using (StreamWriter writer = new StreamWriter(FileName))
            {
                //Reading all the fields from the list
                foreach (Note x in listNotes)
                {
                    StringBuilder sb = new StringBuilder();

                    //Add the fields to the SB
                    sb.Append(x.NoteId).Append("|");
                    sb.Append(x.PatientName).Append("|");
                    sb.Append(x.PatientDOB).Append("|");
                    sb.Append(x.PatientProblem).Append("|");
                    sb.Append(x.PatientNotes);

                    //Writing the fields to the file
                    writer.WriteLine(sb.ToString());
                }
            }
        }

        /// <summary>
        /// Update the content of a specific note.
        /// Using the specific index to manage.
        /// </summary>
        public void UpdateNote()
        {

        }

        /// <summary>
        /// Add a new note.
        /// Managing the UniqueId.
        /// </summary>
        public void AddNote(Note newNote)
        {

            // Adiciona a nova nota à lista
            listNotes.Add(newNote);

            // Pode salvar as notas no arquivo aqui, se desejado
            SaveNote();
        }

        /// <summary>
        /// Delete a specific note.
        /// Using the specific index
        /// </summary>
        public void DeleteNote()
        {

        }

        /// <summary>
        /// Listing all the notes
        /// </summary>
        /// <returns>Return the list with all the notes</returns>
        public List<Note> ListNotes()
        {
            return listNotes;
        }

        public int GetNextNoteId()
        {
            //Checking if the file is not empty
            if (listNotes.Count > 0)
            {
                //Geting the max noteid and adding + 1
                return listNotes.Max(note => note.NoteId) + 1;
            }
            //If the file is empty, use the first values as 1
            else
            {
                return 1;
            }
        }
    }

}
