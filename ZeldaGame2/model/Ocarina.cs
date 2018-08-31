﻿
// Retro music during start up of game
using System;
using System.Threading;

namespace ZeldaGame2.model

{

    class Ocarina
    {
        
        public void PlayZeldaTune()
        {
            // Declare the first few notes of the song, "Zelda's lullaby".
            Note[] Lullaby =
                {
        new Note(Tone.E, Duration.HALF),
        new Note(Tone.G, Duration.QUARTER),
        new Note(Tone.D, Duration.HALF),
        new Note(Tone.C, Duration.EIGHTH),
        new Note(Tone.D, Duration.EIGHTH),
        new Note(Tone.E, Duration.HALF),
        new Note(Tone.G, Duration.QUARTER),
        new Note(Tone.D, Duration.THREEQUARTER),
        new Note(Tone.E, Duration.HALF),
        new Note(Tone.G, Duration.QUARTER),
        new Note(Tone.Dhigh, Duration.HALF),
        new Note(Tone.Chigh, Duration.QUARTER),
        new Note(Tone.G, Duration.HALF),
        new Note(Tone.F, Duration.EIGHTH),
        new Note(Tone.E, Duration.EIGHTH),
        new Note(Tone.D, Duration.THREEQUARTER),

        };
            // Play the song
            Play(Lullaby);
        }

        // Play the notes in a song.
        protected static void Play(Note[] tune)
        {
            foreach (Note n in tune)
            {
                if (n.NoteTone == Tone.REST)
                    Thread.Sleep((int)n.NoteDuration);
                else
                    Console.Beep((int)n.NoteTone, (int)n.NoteDuration);
            }
        }

        // Define the frequencies of notes in an octave, as well as 
        // silence (rest).
        protected enum Tone
        {
            REST = 0,
            GbelowC = 196,
            A = 220,
            Asharp = 233,
            B = 247,
            C = 262,
            Csharp = 277,
            D = 294,
            Dsharp = 311,
            E = 330,
            F = 349,
            Fsharp = 370,
            G = 392,
            Gsharp = 415,
            Ahigh = 440,
            Bhigh = 494,
            Chigh = 523,
            Dhigh = 587
        }

        // Define the duration of a note in units of milliseconds.
        protected enum Duration
        {
            WHOLE = 1600,
            THREEQUARTER = WHOLE/4*3,
            HALF = WHOLE / 2,
            QUARTER = HALF / 2,
            EIGHTH = QUARTER / 2,
            SIXTEENTH = EIGHTH / 2,
        }

        // Define a note as a frequency (tone) and the amount of 
        // time (duration) the note plays.
        protected struct Note
        {
            Tone toneVal;
            Duration durVal;

            // Define a constructor to create a specific note.
            public Note(Tone frequency, Duration time)
            {
                toneVal = frequency;
                durVal = time;
            }

            // Define properties to return the note's tone and duration.
            public Tone NoteTone { get { return toneVal; } }
            public Duration NoteDuration { get { return durVal; } }
        }
    }
}
/*
This example produces the following results:

This example plays the first few notes of "Zelda's lullaby" 
through the console speaker.
*/
