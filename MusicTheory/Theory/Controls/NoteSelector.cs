using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music.Theory.Controls
{
    public partial class NoteSelector : UserControl
    {
        static List<string> note_names = new List<string> { "c", "c#", "d", "d#", "e", "f", "f#", "g", "g#", "a", "a#", "b" };
        private Note _value = Note.MiddleC;
        public Note Value
        {
            get
            {
                return _value;
            }
        }

        private int _Index = 0;
        public int Index
        {
            get
            {
                return _Index;
            }
            set
            {
                if (value <= note_names.Count - 1 && value >= 0)
                {
                    _Index = value;
                    this.nameBox.Text = note_names[value].ToUpper();
                    _value = new Note(this.nameBox.Text, 3);
                }
            }
        }

        private event EventHandler _noteChanged;

        public event EventHandler NoteChanged
        {
            add
            {
                _noteChanged += value;
            }
            remove
            {
                _noteChanged -= value;
            }
        }

        public NoteSelector()
        {
            InitializeComponent();

            this.MouseWheel += NoteSelector_MouseWheel;
        }

        private void NoteSelector_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                NextNote();
            }
            else
            {
                PreviousNote();
            }
        }

        private void downBtn_Click(object sender, EventArgs e)
        {
            PreviousNote();
        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            NextNote();
        }

        public void NextNote()
        {
            if (Index + 1 > note_names.Count - 1)
            {
                Index = 0;
                fireNoteChanged();
                return;
            }

            if (Index + 1 <= note_names.Count - 1)
            {
                Index += 1;
                fireNoteChanged();
                return;
            }
        }

        public void PreviousNote()
        {
            if (Index - 1 < 0)
            {
                Index = note_names.Count - 1;
                fireNoteChanged();
                return;
            }

            if (Index - 1 >= 0)
            {
                Index -= 1;
                fireNoteChanged();
                return;
            }
        }

        private void fireNoteChanged()
        {
            if (_noteChanged != null)
            {
                _noteChanged(this, null);
            }
        }
    }
}
