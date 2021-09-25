namespace DifferentialCryptinalysis
{
    using System.Collections.Generic;
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<Output> outputList = new List<Output>();

            //WriteHeaderToConsole();
            for(int i = 0; i < SboxInput.Inputs.Count; i++)
            {
                int y = SboxOutput.Calculate(i, SBoxes.Box1);
                Output output = new Output(SBoxes.Box1, i, y);
                output.CalculateDeltas();
                outputList.Add(output);

                //output.WriteToConsole();
            }

            // Get all Deltas where DeltaY = 0 Get Count
            int[,] differences = new int[64, 16];
            for(int i = 0; i < 64; i++)
            {
                for(int j = 0; j < 16; j++)
                {
                    differences[i,j] = outputList.Where(o => o.Deltas.Where(d => d.DeltaX == i).Select(d => d.DeltaY).Contains(j)).Count();
                }
            }

            WriteDifferenceToConsole(differences);
        }

        public static void WriteDifferenceToConsole(int[,] differences)
        {
            Console.Write("  | ");
            for(int k = 0; k < 16; k++)
            {
                Console.Write(k.ToString().PadRight(2));
                Console.Write("| ");
            }
            Console.Write("\n");
            Console.WriteLine("-".PadRight(67, '-'));
            for(int i = 0; i < 64; i++)
            {
                Console.Write($"{i.ToString().PadRight(2)}| ");
                for(int j = 0; j < 16; j++)
                {
                    Console.Write(differences[i,j].ToString().PadRight(2));
                    Console.Write("| ");
                }
                Console.Write("\n");
            }
        }

        public static void WriteHeaderToConsole()
        {
            Console.WriteLine($"{"|".PadLeft(20)}{"ΔY".PadLeft(384)}{"|".PadLeft(384)}");
            Console.WriteLine("".PadRight(788, '-'));
            Console.Write($"    X    |    Y   ");
            SboxInput.Inputs.ForEach(i => {
                Console.Write($" | ΔX={string.Join("", i)}");
            });
            Console.Write(" |\n");
            Console.WriteLine("".PadRight(788, '-'));
        }
    }    
}
