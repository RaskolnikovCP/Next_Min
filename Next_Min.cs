public int Next_Min(int[] arr, int a)
        {
            int size = arr.Length;

            int[] brr = new Int32[size];

            int b = Int32.MaxValue;

            int min_index = 0;

            int result = 0;

            for (int i = 0; i < size; i++)
            {
                brr[i] = arr[i] - a;

                if (brr[i] < b && brr[i] > 0)
                {
                    min_index = i;

                    b = brr[i];
                }
            }

            result = a + brr[min_index];

            return result;

        }
