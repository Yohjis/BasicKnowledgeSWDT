using System;

public class Task3
{
	public Task3()
	{
	}

	public static int digital_root(int input)
	{
		int dig;
		int sum = 0;

		while (input > 0)
		{
			dig = input % 10;
			sum += dig;
			input = input / 10;
		}
		if (sum > 9)
		{
			sum = digital_root(sum);
		}
		return sum;
	}
}
