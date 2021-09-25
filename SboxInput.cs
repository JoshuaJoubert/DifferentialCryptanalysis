namespace DifferentialCryptinalysis
{
    using System.Collections.Generic;
    using System;

    public static class SboxInput
    {
        public static List<int[]> Inputs { get; }
        
        static SboxInput()
        {
            Inputs = new List<int[]>();
            Inputs.Add(new int[] {0,0,0,0,0,0});
            Inputs.Add(new int[] {0,0,0,0,0,1});  
            Inputs.Add(new int[] {0,0,0,0,1,0});
            Inputs.Add(new int[] {0,0,0,0,1,1});
            Inputs.Add(new int[] {0,0,0,1,0,0});
            Inputs.Add(new int[] {0,0,0,1,0,1});
            Inputs.Add(new int[] {0,0,0,1,1,0});
            Inputs.Add(new int[] {0,0,0,1,1,1});
            Inputs.Add(new int[] {0,0,1,0,0,0});
            Inputs.Add(new int[] {0,0,1,0,0,1});
            Inputs.Add(new int[] {0,0,1,0,1,0});
            Inputs.Add(new int[] {0,0,1,0,1,1});
            Inputs.Add(new int[] {0,0,1,1,0,0});
            Inputs.Add(new int[] {0,0,1,1,0,1});
            Inputs.Add(new int[] {0,0,1,1,1,0});
            Inputs.Add(new int[] {0,0,1,1,1,1});
            Inputs.Add(new int[] {0,1,0,0,0,0});
            Inputs.Add(new int[] {0,1,0,0,0,1});
            Inputs.Add(new int[] {0,1,0,0,1,0});
            Inputs.Add(new int[] {0,1,0,0,1,1});
            Inputs.Add(new int[] {0,1,0,1,0,0});
            Inputs.Add(new int[] {0,1,0,1,0,1});
            Inputs.Add(new int[] {0,1,0,1,1,0});
            Inputs.Add(new int[] {0,1,0,1,1,1});
            Inputs.Add(new int[] {0,1,1,0,0,0});
            Inputs.Add(new int[] {0,1,1,0,0,1});
            Inputs.Add(new int[] {0,1,1,0,1,0});
            Inputs.Add(new int[] {0,1,1,0,1,1});
            Inputs.Add(new int[] {0,1,1,1,0,0});
            Inputs.Add(new int[] {0,1,1,1,0,1});
            Inputs.Add(new int[] {0,1,1,1,1,0});
            Inputs.Add(new int[] {0,1,1,1,1,1});
            Inputs.Add(new int[] {1,0,0,0,0,0});
            Inputs.Add(new int[] {1,0,0,0,0,1});
            Inputs.Add(new int[] {1,0,0,0,1,0});
            Inputs.Add(new int[] {1,0,0,0,1,1});
            Inputs.Add(new int[] {1,0,0,1,0,0});
            Inputs.Add(new int[] {1,0,0,1,0,1});
            Inputs.Add(new int[] {1,0,0,1,1,0});
            Inputs.Add(new int[] {1,0,0,1,1,1});
            Inputs.Add(new int[] {1,0,1,0,0,0});
            Inputs.Add(new int[] {1,0,1,0,0,1});
            Inputs.Add(new int[] {1,0,1,0,1,0});
            Inputs.Add(new int[] {1,0,1,0,1,1});
            Inputs.Add(new int[] {1,0,1,1,0,0});
            Inputs.Add(new int[] {1,0,1,1,0,1});
            Inputs.Add(new int[] {1,0,1,1,1,0});
            Inputs.Add(new int[] {1,0,1,1,1,1});
            Inputs.Add(new int[] {1,1,0,0,0,0});
            Inputs.Add(new int[] {1,1,0,0,0,1});
            Inputs.Add(new int[] {1,1,0,0,1,0});
            Inputs.Add(new int[] {1,1,0,0,1,1});
            Inputs.Add(new int[] {1,1,0,1,0,0});
            Inputs.Add(new int[] {1,1,0,1,0,1});
            Inputs.Add(new int[] {1,1,0,1,1,0});
            Inputs.Add(new int[] {1,1,0,1,1,1});
            Inputs.Add(new int[] {1,1,1,0,0,0});
            Inputs.Add(new int[] {1,1,1,0,0,1});
            Inputs.Add(new int[] {1,1,1,0,1,0});
            Inputs.Add(new int[] {1,1,1,0,1,1});
            Inputs.Add(new int[] {1,1,1,1,0,0});
            Inputs.Add(new int[] {1,1,1,1,0,1});
            Inputs.Add(new int[] {1,1,1,1,1,0});
            Inputs.Add(new int[] {1,1,1,1,1,1});                  
        }
    }
}