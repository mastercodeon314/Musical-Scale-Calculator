using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Theory
{
    public class Note
    {
        static List<string> note_names = new List<string> { "c", "c#", "d", "d#", "e", "f", "f#", "g", "g#", "a", "a#", "b" };
        public static Note MiddleC = new Note();

        private string _noteName = "C";
        private int _value = 60;
        private int _octave = 3;

        public string NoteName
        {
            get
            {
                return _noteName;
            }
            set
            {
                _noteName = value;
            }
        }
        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                _octave = ((value / 12) - 2);
                _noteName = getNoteFromMidiNumber(_value);
            }
        }
        public int Octave
        {
            get
            {
                return _octave;
            }
            set
            {
                _octave = value;
            }
        }

        public Note(int midiVal)
        {
            this.Value = midiVal;
            this.NoteName = getNoteFromMidiNumber(midiVal);
            this.Octave = getNoteOctave(midiVal);
        }

        public Note(string noteName, int octave = 3)
        {
            int noteIdx = note_names.IndexOf(noteName.ToLower());
            this.Value = noteIdx + ((octave + 2) * 12);
        }

        public Note(int midiVal, string noteName, int octave)
        {
            _value = midiVal;
            _noteName = noteName;
            _octave = octave;
        }

        public Note()
        {
        }

        public Note Add(int value)
        {
            Note n = new Note();
            int newVal = this.Value + value;
            n.Value = newVal;
            return n;
        }

        public Note Subtract(int value)
        {
            Note n = new Note();
            int newVal = this.Value - value;
            n.Value = newVal;
            return n;
        }

        public static Note fromNoteName(string noteName, int octave = 3)
        {
            Note n = new Note();
            int noteIdx = note_names.IndexOf(noteName.ToLower());
            n.Value = noteIdx + ((octave + 2) * 12);
            return n;

        }

        // Taken from : https://stackoverflow.com/a/64408826/8657924
        public static string getNoteFromMidiNumber(int midiNote)
        {
            return note_names[midiNote % 12].ToUpper();
        }

        public static int getNoteOctave(int midiNote)
        {
            return ((midiNote / 12) - 2);
        }

        public override string ToString()
        {
            return this.NoteName.ToUpper() + this.Octave.ToString();
        }
    }
}
