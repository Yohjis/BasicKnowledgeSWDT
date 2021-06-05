using System;

public class Task2
{
	public static char first_non_repeating_letter(string input)
	{
		string input_loop = input;
		char ch_loop;
		for (int i = 0; i < input.Length; i++)
		{
			if (i == input.Length - 1)
			{
				break;
			}
			ch_loop = input.ToLower()[i];
			input_loop = input_loop.Substring(i + 1).ToLower();
			if (!input_loop.Contains(ch_loop))
			{
				return input[i];
			}
		}
		return input[input.Length - 1];
	}
}
