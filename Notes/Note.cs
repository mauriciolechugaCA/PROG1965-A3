using Assignment3;
using System.Text;

namespace Assignment3_Demo
{
    public class Note
    {
        private int noteId;
        private string patientName;
        private DateTime dateNote;
        private string patientProblem;
        private string patientNotes;

        public int NoteId
        {
            get { return noteId; }
            set { noteId = value; }
        }

        public string PatientName
        {
            get { return patientName; }
            set { patientName = value; }
        }

        public DateTime DateNote
        {
            get { return dateNote; }
            set { dateNote = value; }
        }

        public string PatientProblem
        {
            get { return patientProblem; }
            set { patientProblem = value; }
        }

        public string PatientNotes
        {
            get { return patientNotes; }
            set { patientNotes = value; }
        }

        public Note()
        {
            this.noteId = 0;
            this.patientName = string.Empty;
            this.dateNote = DateTime.Today;
            this.patientProblem = string.Empty;
            this.patientNotes = string.Empty;
        }

        public Note(int noteId, string patientName, DateTime dateNote, string patientProblem, string patientNotes)
        {
            this.noteId = noteId;
            this.patientName = patientName;
            this.dateNote = dateNote;
            this.patientProblem = patientProblem;
            this.patientNotes = patientNotes;
        }

        public string GetNoteContents()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.noteId.ToString()).Append(", ");
            sb.AppendLine(this.patientName.ToString()).Append(", ");
            sb.AppendLine(this.dateNote.ToString()).Append(", ");
            sb.AppendLine(this.patientProblem.ToString()).Append(", ");
            sb.AppendLine(this.patientNotes.ToString()).Append(", ");
            
            return sb.ToString();
        }

        public int GenerateUniqueNoteId()
        {
            System.Random random = new System.Random();

            return random.Next(100, int.MaxValue);
        }

    }



}