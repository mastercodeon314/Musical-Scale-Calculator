using Music.Theory.Controls;

namespace MidiNoteParser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectMidiFileBtn = new System.Windows.Forms.Button();
            this.midiFileBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.LoadMidiBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.printFormulaBtn = new System.Windows.Forms.Button();
            this.loadAllMidisBtn = new System.Windows.Forms.Button();
            this.loadCSVBtn = new System.Windows.Forms.Button();
            this.noteSelector1 = new Music.Theory.Controls.NoteSelector();
            this.SuspendLayout();
            // 
            // selectMidiFileBtn
            // 
            this.selectMidiFileBtn.Location = new System.Drawing.Point(651, 28);
            this.selectMidiFileBtn.Name = "selectMidiFileBtn";
            this.selectMidiFileBtn.Size = new System.Drawing.Size(31, 23);
            this.selectMidiFileBtn.TabIndex = 0;
            this.selectMidiFileBtn.UseVisualStyleBackColor = true;
            this.selectMidiFileBtn.Click += new System.EventHandler(this.selectMidiFileBtn_Click);
            // 
            // midiFileBox
            // 
            this.midiFileBox.Location = new System.Drawing.Point(12, 30);
            this.midiFileBox.Name = "midiFileBox";
            this.midiFileBox.Size = new System.Drawing.Size(633, 20);
            this.midiFileBox.TabIndex = 1;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 104);
            this.outputBox.Name = "outputBox";
            this.outputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.outputBox.Size = new System.Drawing.Size(670, 217);
            this.outputBox.TabIndex = 2;
            this.outputBox.Text = "";
            // 
            // LoadMidiBtn
            // 
            this.LoadMidiBtn.Location = new System.Drawing.Point(12, 75);
            this.LoadMidiBtn.Name = "LoadMidiBtn";
            this.LoadMidiBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadMidiBtn.TabIndex = 3;
            this.LoadMidiBtn.Text = "Load Midi";
            this.LoadMidiBtn.UseVisualStyleBackColor = true;
            this.LoadMidiBtn.Click += new System.EventHandler(this.LoadMidiBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "MIDI File path";
            // 
            // printFormulaBtn
            // 
            this.printFormulaBtn.Location = new System.Drawing.Point(93, 75);
            this.printFormulaBtn.Name = "printFormulaBtn";
            this.printFormulaBtn.Size = new System.Drawing.Size(84, 23);
            this.printFormulaBtn.TabIndex = 5;
            this.printFormulaBtn.Text = "Print Formula";
            this.printFormulaBtn.UseVisualStyleBackColor = true;
            this.printFormulaBtn.Click += new System.EventHandler(this.printFormulaBtn_Click);
            // 
            // loadAllMidisBtn
            // 
            this.loadAllMidisBtn.Location = new System.Drawing.Point(207, 75);
            this.loadAllMidisBtn.Name = "loadAllMidisBtn";
            this.loadAllMidisBtn.Size = new System.Drawing.Size(89, 23);
            this.loadAllMidisBtn.TabIndex = 6;
            this.loadAllMidisBtn.Text = "Load All Midis";
            this.loadAllMidisBtn.UseVisualStyleBackColor = true;
            this.loadAllMidisBtn.Click += new System.EventHandler(this.loadAllMidisBtn_Click);
            // 
            // loadCSVBtn
            // 
            this.loadCSVBtn.Location = new System.Drawing.Point(302, 75);
            this.loadCSVBtn.Name = "loadCSVBtn";
            this.loadCSVBtn.Size = new System.Drawing.Size(100, 23);
            this.loadCSVBtn.TabIndex = 7;
            this.loadCSVBtn.Text = "Load CSV Scales";
            this.loadCSVBtn.UseVisualStyleBackColor = true;
            this.loadCSVBtn.Click += new System.EventHandler(this.loadCSVBtn_Click);
            // 
            // noteSelector1
            // 
            this.noteSelector1.Index = 0;
            this.noteSelector1.Location = new System.Drawing.Point(688, 104);
            this.noteSelector1.Name = "noteSelector1";
            this.noteSelector1.Size = new System.Drawing.Size(46, 83);
            this.noteSelector1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 338);
            this.Controls.Add(this.noteSelector1);
            this.Controls.Add(this.loadCSVBtn);
            this.Controls.Add(this.loadAllMidisBtn);
            this.Controls.Add(this.printFormulaBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadMidiBtn);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.midiFileBox);
            this.Controls.Add(this.selectMidiFileBtn);
            this.Name = "Form1";
            this.Text = "MIDI Note Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectMidiFileBtn;
        private System.Windows.Forms.TextBox midiFileBox;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Button LoadMidiBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button printFormulaBtn;
        private System.Windows.Forms.Button loadAllMidisBtn;
        private System.Windows.Forms.Button loadCSVBtn;
        private NoteSelector noteSelector1;
    }
}

