using System;
using System.Collections.Generic;

public class Task1
{
	public static List<object> filterList(List<object> list)
	{
		var selected = new List<object>();
		foreach (var word in list)
		{
			if (word is int || word is uint)
			{
				selected.Add(word);
			}
		}
		return selected;
	}
}
