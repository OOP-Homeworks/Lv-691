using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalaOks_HW3_tsk3
{
    internal class CheckPositiveSum5
    {
        public int Sum { get; set; }
        //int sum = 0;
        private void CalcSum (int start, int[] arr)
        {
            for (int i = start; i < arr.Length; i++)
            {
                Sum += arr[i];
            }
        }
        public void SumOf5(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0 & i <= 4)
                {
                    Sum += arr[i];
                    //break;
                }
                else if (arr[i] < 0 || i <= 4)
                {
                    Sum = 0;
                    for (int j = 5; j < arr.Length; j++)
                    {
                        Sum += arr[j];
                    }
                    break;
                }
            }
            //Console.WriteLine($"Sum of 5 entered numbers = {Sum}");
        }
        
    }
}
