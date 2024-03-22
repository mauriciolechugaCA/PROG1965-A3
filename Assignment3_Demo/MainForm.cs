

using System.Collections;

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

namespace Assignment3_Demo
{
    public partial class MainForm : Form
    {
        private List<Note> notes = new List<Note>();
        private int noteId = 0;
        public MainForm()
        {
            InitializeComponent();
        }
        
        // Checks that notes added are unique
        private bool IsNoteIdUnique(string noteId)
        {
            if (notes.Count == 0)
            { 
                return true;
            }
            else
            {
                foreach (Note note in notes)
                {
                    if(note.NoteId == int.Parse(noteId))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
