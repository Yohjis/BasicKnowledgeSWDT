using System;

public class Task4
{
	public Task4()
	{
	}

	public static int pair_sum(int[] input, int target)
	{
		int count = 0;
		for (int i = 0; i < input.Length - 1; i++)
		{
			for (int j = i + 1; j < input.Length; j++)
			{
				if (input[i] + input[j] == target)
					count++;
			}
		}
		return count;
	}
}
