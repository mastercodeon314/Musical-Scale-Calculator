using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Theory
{
    public class MIDI_Notes
    {
        public Dictionary<string, Note> Table = new Dictionary<string, Note>();

        public Dictionary<string, int> BaseNotes = new Dictionary<string, int>()
        {
            { "C", 0 },
            { "C#", 1 },
            { "D", 2 },
            { "D#", 3 },
            { "E", 4 },
            { "F", 5 },
            { "F#", 6 },
            { "G", 7 },
            { "G#", 8 },
            { "A", 9 },
            { "A#", 10 },
            { "B", 11 },
        };

        public Dictionary<int, string> BaseNotesInv = new Dictionary<int, string>()
        {
            { 0, "C"},
            { 1, "C#"},
            { 2, "D"},
            { 3, "D#"},
            { 4, "E"},
            { 5, "F"},
            { 6, "F#"},
            { 7, "G"},
            { 8, "G#"},
            { 9, "A"},
            { 10, "A#"},
            { 11, "B"},
        };
    }
}
