namespace DifferentialCryptinalysis
{
    using System;

    public class Delta
    {
        public int DeltaX { get; set; }
        public int DeltaY { get; set; }
    }

    public class CalculateDeltaY
    {
        public static int Calculate(int x, int y, int deltaX, int[,] sbox) 
        {
            // Xor it with the Original X Input
            int xordX = Xor64(x, deltaX);

            // Binary representation
            int[] sboxXXor = SboxInput.Inputs[xordX];

            // Get new Y output
            int newY = SboxOutput.GetSBoxOutput(sboxXXor, sbox);

            // Get Delta Y
            return Xor16(y, newY);
        } 

        private static int Xor16(int x, int y)
        {
             return (int)(Math.Abs(x - y) % 16);
        }

        private static int Xor64(int x, int y)
        {
             return (int)(Math.Abs(x - y) % 64);
        }
    }
}