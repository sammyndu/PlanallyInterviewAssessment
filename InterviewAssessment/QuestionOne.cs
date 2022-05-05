
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    public class QuestionOne
    {
        public int Challenge(int[] input)
        {
            //your code here
            Dictionary<int, int> frequecy = new Dictionary<int, int>();
            int sum = 0;
            int highestFrequency = 0;

            foreach (int i in input)
            {
                if (!frequecy.ContainsKey(i))
                {
                    frequecy[i] = 1;
                }
                else
                {
                    frequecy[i] = frequecy[i] + 1;
                    if (highestFrequency < frequecy[i])
                    {
                        highestFrequency = frequecy[i];
                    }
                    //frequecy.Remove(i);
                }
            }

            input = input.Where(x => frequecy[x] >= highestFrequency - 1).ToArray();

            for (int i = 0; i < input.Length - 1; i++)
            {
                int neigborSum = input[i] + input[i + 1];
                if (sum < neigborSum)
                {
                    sum = neigborSum;
                }
            }

            return sum;
        }
    }
}
