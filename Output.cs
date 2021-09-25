namespace DifferentialCryptinalysis
{
    using System.Collections.Generic;
    using System;
    using System.Linq;

    public class Output
    {
        int[,] _sbox;

        int X { get; }
        int Y { get; }
        public List<Delta> Deltas { get; }

        public Output(int[,] sbox, int x, int y)
        {
            _sbox = sbox;
            X = x;
            Y = y;
            Deltas = new List<Delta>();
        }

        public void CalculateDeltas()
        {
            for(int i = 0; i < SboxInput.Inputs.Count; i++)
            {
                Delta d = new Delta();
                d.DeltaX = i;

                d.DeltaY = CalculateDeltaY.Calculate(X, Y, i, _sbox);
                Deltas.Add(d);
            }
        }

        public void WriteToConsole()
        {  
            Console.Write($"    {X.ToString().PadRight(5)}|    {Y.ToString().PadRight(4)}");
            Deltas.ForEach(d => {
                Console.Write($" |    {d.DeltaY.ToString().PadRight(5)} ");
            });
            Console.Write(" |\n");
            Console.WriteLine("".PadRight(788, '-'));
        }
    }
}