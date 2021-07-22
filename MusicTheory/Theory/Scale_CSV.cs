using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Theory
{
    public struct Scale_CSV
    {
        public int ScaleLength;
        public int ScaleNumber;
        public string ScaleName;
        public int[] ScaleFormula;

        public override string ToString()
        {
            return ScaleName + ", " + Utils.arrayFormulaToString(ScaleFormula);
        }

        public string getFormulaString()
        {
            return Utils.arrayFormulaToString(this.ScaleFormula);
        }

        public string BuildScale()
        {
            return Utils.CalculateScaleFormula(this.ScaleFormula, Note.MiddleC);
        }

        public string BuildScale(Note rootNote)
        {
            return Utils.CalculateScaleFormula(this.ScaleFormula, rootNote);
        }
    }
}
