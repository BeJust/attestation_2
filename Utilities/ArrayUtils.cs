using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class ArrayTransformator
    {
        public int[] arr { get; set; }
       
        public ArrayTransformator(int[] arr)
        {
            this.arr = arr;
        }
        public int FindFirstSeriaLength()
        {
            int firstLength = 1;
            int currentLength = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > 1)
                    {
                        return currentLength;
                    }
                    
                }
             
            }

            return firstLength;
        }
        public int FindLastSeriaLength()
        {
            int lastLength = 1;
            int currentLength = 1;

            for (int i = arr.Length-2; i >= 0; i--)
            {
                if (arr[i] == arr[i + 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > 1)
                    {
                        return currentLength;
                    }

                }

            }

            return lastLength;
        }
        public int[] IncreaseLastSeria()
        {
            bool flag = true;
            int[] result = new int[arr.Length * 2];
            int freeIndex = 0;

            int lastLength = FindLastSeriaLength();
            int currentLength = 1;
            result[freeIndex++] = arr[arr.Length - 2];

            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] == arr[i + 1])
                {
                    currentLength++;
                }

                if (arr[i] != arr[i + 1] || i == 0)
                {
                    if ((currentLength == lastLength)&&(flag))
                    {
                        result[freeIndex++] = arr[i+1];
                        flag = false;
                    }
                    currentLength = 1;
                }
                result[freeIndex++] = arr[i];
            }
            int[] newArray = new int[freeIndex];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = result[i];
            }
            Array.Reverse(newArray);
            return newArray;

        }
        public int[] IncreaseFirstSeria()
        {
            bool flag = true;
            int[] result = new int[arr.Length * 2];
            int freeIndex = 0;

            int firstLength = FindFirstSeriaLength();
            int currentLength = 1;
            result[freeIndex++] = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    currentLength++;
                }

                if (arr[i] != arr[i - 1] || i == arr.Length - 1)
                {
                    if ((currentLength == firstLength) && (flag))
                    {
                        result[freeIndex++] = arr[i - 1];
                        flag = false;
                    }
                    currentLength = 1;
                }
                result[freeIndex++] = arr[i];
            }
            int[] newArray = new int[freeIndex];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = result[i];
            }

            return newArray;

        }
        public int[] IncreaseLongestSerias()
        {
            int[] result = new int[arr.Length*2];
            int freeIndex = 0;

            int maxLength = FindMaxSeriaLength();
            int currentLength = 1;
            result[freeIndex++] = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                
                if (arr[i] == arr[i - 1])
                {
                    currentLength++;
                }

                if (arr[i] != arr[i - 1] || i == arr.Length - 1)
                {
                    if (currentLength == maxLength)
                    {
                        result[freeIndex++] = arr[i-1];
                    }

                    currentLength = 1;
                }

                result[freeIndex++] = arr[i];
            }


            int[] newArray = new int[freeIndex];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = result[i];
            }

            return newArray;
        }

        public int FindMaxSeriaLength() {
            int maxLength = 1;
            int currentLength = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i-1])
                {
                    currentLength++;
                }

                if (arr[i] != arr[i-1] || i == arr.Length - 1)
                {
                    if (currentLength > maxLength)
                        maxLength = currentLength;

                    currentLength = 1;
                }  
            }

            return maxLength;
        }
        public void FindLongestSubsequence(out int maxLength, out int sequanceStart)
        {

            maxLength = arr.Length <= 3 ? arr.Length : 3;
            sequanceStart = 0;

            for (int i = 0; i < arr.Length - 3; i++)
            {
                int errorsCount = 0;
                int mainEl = 0;

                int[] t = GetSubsequence(4, i);
                Array.Sort(t);

                if (t[0] == t[1])
                {
                    mainEl = t[0];
                }
                else if (t[1] == t[2])
                {
                    mainEl = t[1];
                }
                else if (t[2] == t[3])
                {
                    mainEl = t[2];
                }
                else
                {
                    continue;
                }
                
                for (int j = i; j < arr.Length; j++)
                {
                   
                    if (arr[j] != mainEl)
                    {
                        errorsCount++;
                    }

                   
                    
                    if (errorsCount == 3 || j == arr.Length - 1 )
                    {
                        if (errorsCount != 3)
                        {
                            j++;
                            int currentLength = j - i;

                            if (currentLength > maxLength)
                            {
                                maxLength = currentLength;
                                sequanceStart = i;
                            }
                        }
                        else
                        {
                            
                            int currentLength = j - i;

                            if (currentLength > maxLength)
                            {
                                maxLength = currentLength;
                                sequanceStart = i;
                            }
                        }
                        break;
                    }

                }
                
            }


        }

       
        public int[] GetSubsequence(int Length, int sequenceStart)
        {
            int[] result = new int[Length];
            Array.Copy(arr, sequenceStart, result, 0, Length);
            return result;
        }

    }
}
