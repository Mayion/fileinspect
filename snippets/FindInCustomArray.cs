private bool FindInCustomArray(string Array, string ValueToFind, bool IgnoreCase)
{
		//If ValueToFind is in Array
		List<string> List = new List<string>();
		ConvertCustomArrayToList(Array, List);
		if (IgnoreCase == true)
		{
			if (List.Contains(ValueToFind, StringComparer.OrdinalIgnoreCase))
			{
				return true;
			}
		}
		else
		{
			if (List.Contains(ValueToFind, StringComparer.CurrentCulture))
			{
				return true;
			}
		}
		return false;
	}
