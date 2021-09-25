using System;

namespace DifferentialCryptinalysis
{
    public static class SboxOutput
    {
        public static int Calculate(int input, int[,] sBox)
        {
            // Binary Repesentation
            int[] _input = SboxInput.Inputs[input];
            return GetSBoxOutput(_input, sBox);
        }
        
        public static int GetSBoxOutput(int[] input, int[,] sBox)
        {       
            string row = input[0].ToString() + input[5].ToString();
            string column = input[1].ToString() + input[2].ToString() + input[3].ToString() + input[4].ToString();

            int rowIndex    = BinaryCalculator.Calculate(row);
            int columnIndex = BinaryCalculator.Calculate(column);

            return sBox[rowIndex, columnIndex];
        } 
    }
}