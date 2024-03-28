using Assignment3;
using System.Text;

namespace Assignment3
{
    public class Note
    {

        public int NoteId { get; private set; }
        public string PatientName { get; set; }
        public DateTime PatientDOB { get; set; }
        public string PatientProblem { get; set; }
        public string PatientNotes { get; set; }

        public Note()
        {
            
        }

        public Note(int noteId, string patientName, DateTime patientDOB, string patientProblem)
        {
            NoteId = noteId;
            PatientName = patientName;
            PatientDOB = patientDOB;
            PatientProblem = patientProblem;
            //PatientNotes = patientNotes;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Note ID: {NoteId}");
            sb.AppendLine($"Patient Name: {PatientName}");
            sb.AppendLine($"Date of Birth: {PatientDOB}");
            sb.AppendLine($"Problem: {PatientProblem}");
            //sb.AppendLine($"Notes: {PatientNotes}");
            return sb.ToString();
        }

    }



}