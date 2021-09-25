namespace DifferentialCryptinalysis
{
    using System;
    using System.Text;

    public class BinaryCalculator
    {
        public static int Calculate(string row) 
        {            
            return Convert.ToInt32(row, 2);
        } 

        public static int[] Calculate(int value)
        {
            switch(value){
                case 1:
                    return new int[] {0,0,0,1};//"0001"
                case 2:
                    return new int[] {0,0,1,1};//"0010"
                case 3:
                    return new int[] {0,0,1,1};//"0011"
                case 4:
                    return new int[] {0,1,0,0};//"0100"
                case 5:
                    return new int[] {0,1,0,1};//"0101"
                case 6:
                    return new int[] {0,1,1,0};//"0110"
                case 7:
                    return new int[] {0,1,1,1};//"0111"
                case 8:
                    return new int[] {1,0,0,0};//"1000"
                case 9:
                    return new int[] {1,0,0,1};//"1001"
                case 10:
                    return new int[] {1,0,1,0};//"1010"
                case 11:
                    return new int[] {1,0,1,1};//"1011"
                case 12:
                    return new int[] {1,1,0,0};//"1100"
                case 13:
                    return new int[] {1,1,0,1};//"1101"
                case 14:
                    return new int[] {1,1,1,0};//"1110"
                case 15:
                    return new int[] {1,1,1,1};//"1111"
                default:
                    return new int[] {0,0,0,0};//"0000"
            }
        } 
    }
}