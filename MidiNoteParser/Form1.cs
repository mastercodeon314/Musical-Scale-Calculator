using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Music.Theory;

namespace MidiNoteParser
{
    public partial class Form1 : Form
    {
        public string midiFilePath;

        public List<Note> ScaleNotes = new List<Note>();

        public Form1()
        {
            InitializeComponent();

            this.noteSelector1.NoteChanged += NoteSelector1_NoteChanged;
        }

        private void NoteSelector1_NoteChanged(object sender, EventArgs e)
        {
            this.displayCSVScales();
        }

        private void selectMidiFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog diag = new OpenFileDialog())
            {
                diag.InitialDirectory = Environment.CurrentDirectory;
                if (diag.ShowDialog() == DialogResult.OK)
                {
                    this.midiFilePath = diag.FileName;
                    this.midiFileBox.Text = this.midiFilePath;
                }
            }
        }

        private void LoadMidiBtn_Click(object sender, EventArgs e)
        {
            if (this.midiFilePath != String.Empty && this.midiFilePath != null)
            {
                outputBox.Clear();
                ScaleNotes.Clear();

                var midiFile = new MidiFile(midiFilePath);

                int noteStartValue = -1;
                int noteEndValue = -1;
                foreach (var track in midiFile.Tracks)
                {
                    for (int i = 0; i < track.MidiEvents.Count; i++)
                    {
                        MidiEvent midiEvent = track.MidiEvents[i];
                        if (midiEvent.MidiEventType == MidiEventType.NoteOn)
                        {
                            var note = midiEvent.Note;

                            Note n = new Note(note);
                            if (noteStartValue == -1)
                            {
                                noteStartValue = n.Value;
                                noteEndValue = n.Value + 12;
                            };

                            if (n.Value == noteEndValue)
                            {
                                outputBox.AppendText(n.ToString());

                                ScaleNotes.Add(n);
                                break;
                            }
                            else
                            {
                                outputBox.AppendText(n.ToString() + ", ");

                                ScaleNotes.Add(n);
                            }
                        }
                    }
                }
            }
        }

        private void printFormulaBtn_Click(object sender, EventArgs e)
        {
            if (ScaleNotes.Count > 0)
            {
                string formula = Utils.getScaleFormulaSemitonesStr(this.ScaleNotes);
                outputBox.AppendText(Environment.NewLine);
                outputBox.AppendText(formula);
            }
        }

        private List<Note> loadScaleMidiFile(string file)
        {
            List<Note> result = new List<Note>();
            var midiFile = new MidiFile(file);

            int noteStartValue = -1;
            int noteEndValue = -1;
            foreach (var track in midiFile.Tracks)
            {
                for (int i = 0; i < track.MidiEvents.Count; i++)
                {
                    MidiEvent midiEvent = track.MidiEvents[i];
                    if (midiEvent.MidiEventType == MidiEventType.NoteOn)
                    {
                        var note = midiEvent.Note;

                        Note n = new Note(note);
                        if (noteStartValue == -1)
                        {
                            noteStartValue = n.Value;
                            noteEndValue = n.Value + 12;
                        };

                        if (n.Value == noteEndValue)
                        {
                            outputBox.AppendText(n.ToString());

                            result.Add(n);
                            break;
                        }
                        else
                        {
                            outputBox.AppendText(n.ToString() + ", ");

                            result.Add(n);
                        }
                    }
                }

            }

            return result;
        }

        private void loadAllMidisBtn_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            string[] midis = Directory.GetFiles(Environment.CurrentDirectory, "*.mid");
            string nl = Environment.NewLine;
            ScaleList scList = new ScaleList();
            foreach (string midFile in midis)
            {
                List<Note> notes = null;
                try
                {
                    outputBox.AppendText("Reading scale: " + Path.GetFileNameWithoutExtension(midFile) + nl);
                    notes = loadScaleMidiFile(midFile);
                    outputBox.AppendText(nl);
                }
                catch (Exception ex)
                {
                    outputBox.AppendText("Error Reading scale!" + nl);
                    outputBox.AppendText(ex.ToString() + nl);
                }

                try
                {
                    if (notes != null)
                    {
                        outputBox.AppendText("Calculating scale formula..." + nl);
                        string formula = Utils.getScaleFormulaSemitonesStr(notes);
                        outputBox.AppendText(formula + nl);
                        outputBox.AppendText("Scale List Name: " + scList.getScaleNameFromFormula(formula) + nl);
                        outputBox.AppendText(nl);
                    }
                }
                catch (Exception ex)
                {
                    outputBox.AppendText("Error Calculating scale formula!" + nl);
                    outputBox.AppendText(ex.ToString() + nl);
                }

               // Thread.Sleep(200);
            }
        }

        private void loadCSVBtn_Click(object sender, EventArgs e)
        {
            displayCSVScales();
        }

        private void displayCSVScales()
        {
            outputBox.Clear();
            string nl = Environment.NewLine;
            ScaleList scList = new ScaleList();

            StringBuilder b = new StringBuilder();

            for (int i = 0; i < scList.Length; i++)
            {
                Scale_CSV idx = scList[i];
                b.Append("Scale name: " + idx.ScaleName + nl);
                b.Append("Scale Formula: " + idx.getFormulaString() + nl);
                b.Append("Scale: " + idx.BuildScale(noteSelector1.Value) + nl);
                b.Append("Scale Length: " + idx.ScaleLength.ToString() + nl);
                b.Append("Scale Index Number: " + i.ToString() + nl);
                b.Append("Scale Number: " + idx.ScaleNumber.ToString() + nl);
                if (i < scList.Length - 1) b.Append(nl);
            }

            outputBox.AppendText(b.ToString());
        }
    }
}
