private bool CompareCustomArrays(string Array1, string Array2, bool IgnoreCase)
{
		//If both arrays are the same, no matter the order of values
		List<string> List1 = new List<string>();
		List<string> List2 = new List<string>();
		ConvertCustomArrayToList(Array1, List1);
		ConvertCustomArrayToList(Array2, List2);

		if (List1.Count == List2.Count) //Check if both arrays are identical lenght wise to begin with
		{
			if (!(List1.Count > 0) && List2.Count > 0)
			{
				foreach (var i in List1)
				{
					if (IgnoreCase == true)
					{
						if (!List2.Contains(i, StringComparer.OrdinalIgnoreCase))
						{
							return false;
						}
					}
					else
					{
						if (!List2.Contains(i, StringComparer.CurrentCulture))
						{
							return false;
						}
					}
				}
				return true;
			}
		}
		return false;
	}
