using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3_Demo;

namespace Assignment3
{
    internal class NoteManager
    {
        private List<Note> notes = new List<Note>();

        public string FileName { get; set; }

        public List<Note> Notes { get { return notes; } }

        public NoteManager()
        {
            FileName = "Notes.txt";

            LoadNotesFromFile();
        }

        public NoteManager(string name)
        {
            FileName = name;

            LoadNotesFromFile();
        }

        public void AddNote(Note newNote)
        {
            notes.Add(newNote);

            SaveNotesToFile();
        }

        public void DeleteNote(int noteId)
        {
            foreach (Note note in notes)
            {
                if (note.NoteId == noteId)
                {
                    notes.Remove(note);
                    break;
                }
            }

            SaveNotesToFile();
        }

        public void UpdateNote(Note oldNote, Note newNote)
        {
            int index = 0;

            foreach (Note note in notes)
            {
                if (note.NoteId == oldNote.NoteId)
                {
                    notes.Remove(note);
                    break;
                }
                index++;
            }

            notes.Insert(index, newNote);

            SaveNotesToFile();
        }
    }
}
