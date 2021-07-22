using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Theory
{
    public class Scale
    {
        public string Formula;

        public static Dictionary<int, string> Vals = new Dictionary<int, string>()
        {
            { 1, "H" },
            { 2, "W" },
            { 3, "WH" },
            { 4, "WW" },
            { 5, "WWH" },
            { 6, "WWW" },
            { 7, "WWWH" },
            { 8, "WWWW" },
            { 9, "WWWWH" },
            { 10, "WWWWW" },
            { 11, "WWWWWH" },
            { 12, "WWWWWW" }
        };

        public static string getScaleFormula(List<Note> notes)
        {
            string result = "";

            for (int i = 1; i < notes.Count; i++)
            {
                int val = notes[i].Value;
                int prevVal = notes[i - 1].Value;
                int diff = val - prevVal;
                string step = Vals[diff];

                if (i < notes.Count - 1)
                {
                    step += ", ";
                }

                result += step;
            }

            return result;
        }

        public static string getScaleFormula(int[] notes)
        {
            string result = "";

            for (int i = 1; i < notes.Length; i++)
            {
                int val = notes[i];
                int prevVal = notes[i - 1];
                int diff = val - prevVal;
                string step = Vals[diff];

                if (i < notes.Length - 1)
                {
                    step += ", ";
                }

                result += step;
            }

            return result;
        }
    }
}
