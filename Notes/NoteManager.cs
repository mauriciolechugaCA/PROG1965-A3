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

    }
}
