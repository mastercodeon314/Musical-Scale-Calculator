using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Theory
{
    public class Utils
    {
        public static int[] stringFormulaToArray(string stringFormula)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < stringFormula.Length; i++)
            {
                string sub = stringFormula.Substring(i, 1);
                result.Add(int.Parse(stringFormula[i].ToString()));
            }

            return result.ToArray();
        }

        public static string arrayFormulaToString(int[] ScaleFormula)
        {
            string result = "";

            for (int i = 0; i < ScaleFormula.Length; i++)
            {
                result += ScaleFormula[i].ToString();
            }

            return result;
        }

        public static string getScaleFormulaSemitonesStr(List<Note> notes)
        {
            string result = "";

            for (int i = 1; i < notes.Count; i++)
            {
                int val = notes[i].Value;
                int prevVal = notes[i - 1].Value;
                int diff = val - prevVal;
                string step = diff.ToString();

                result += step;
            }

            return result;
        }

        public static string getScaleFormulaSemitonesStr(int[] notes)
        {
            string result = "";

            for (int i = 1; i < notes.Length; i++)
            {
                int val = notes[i];
                int prevVal = notes[i - 1];
                int diff = val - prevVal;
                string step = diff.ToString();

                result += step;
            }

            return result;
        }

        public static int[] getScaleFormulaSemitones(List<Note> notes)
        {
            List<int> result = new List<int>();

            for (int i = 1; i < notes.Count; i++)
            {
                int val = notes[i].Value;
                int prevVal = notes[i - 1].Value;
                int diff = val - prevVal;
                result.Add(diff);
            }

            return result.ToArray();
        }

        public static int[] getScaleFormulaSemitones(int[] notes)
        {
            List<int> result = new List<int>();

            for (int i = 1; i < notes.Length; i++)
            {
                int val = notes[i];
                int prevVal = notes[i - 1];
                int diff = val - prevVal;
                result.Add(diff);
            }

            return result.ToArray();
        }

        public static string CalculateScaleFormula(int[] semitoneFormula, string rootNoteName)
        {
            List<Note> scaleNotes = new List<Note>();
            string result = "";
            Note rootNote = new Note(rootNoteName);
            Note lastNote = null;
            scaleNotes.Add(rootNote);

            for (int i = 0; i < semitoneFormula.Length; i++)
            {
                if (i == 0)
                {
                    lastNote = rootNote.Add(semitoneFormula[i]);
                    scaleNotes.Add(lastNote);
                }
                else
                {
                    lastNote = lastNote.Add(semitoneFormula[i]);
                    scaleNotes.Add(lastNote);
                }
            }

            for (int i = 0; i < scaleNotes.Count; i++)
            {
                result += scaleNotes[i].NoteName;
                if (i < scaleNotes.Count - 1)
                {
                    result += ", ";
                }
            }

            return result;
        }

        public static string CalculateScaleFormula(int[] semitoneFormula, int rootNotevalue)
        {
            List<Note> scaleNotes = new List<Note>();
            string result = "";
            Note rootNote = new Note();
            Note lastNote = null;
            rootNote.Value = rootNotevalue;
            scaleNotes.Add(rootNote);

            for (int i = 0; i < semitoneFormula.Length; i++)
            {
                if (i == 0)
                {
                    lastNote = rootNote.Add(semitoneFormula[i]);
                    scaleNotes.Add(lastNote);
                }
                else
                {
                    lastNote = lastNote.Add(semitoneFormula[i]);
                    scaleNotes.Add(lastNote);
                }
            }

            for (int i = 0; i < scaleNotes.Count; i++)
            {
                result += scaleNotes[i].NoteName;
                if (i < scaleNotes.Count - 1)
                {
                    result += ", ";
                }
            }

            return result;
        }

        public static string CalculateScaleFormula(int[] semitoneFormula, Note rootNote)
        {
            List<Note> scaleNotes = new List<Note>();
            string result = "";
            scaleNotes.Add(rootNote);
            Note lastNote = null;

            for (int i = 0; i < semitoneFormula.Length; i++)
            {
                if (i == 0)
                {
                    lastNote = rootNote.Add(semitoneFormula[i]);
                    scaleNotes.Add(lastNote);
                }
                else
                {
                    lastNote = lastNote.Add(semitoneFormula[i]);
                    scaleNotes.Add(lastNote);
                }
            }

            for (int i = 0; i < scaleNotes.Count; i++)
            {
                result += scaleNotes[i].NoteName;
                if (i < scaleNotes.Count - 1)
                {
                    result += ", ";
                }
            }

            return result;
        }
    }
}
