public static class Year
{
	public static bool IsLeap(int year)
	{
		if (year % 100 == 0 && year % 400 != 0)
		{
			return false;
		}
		
		return year % 4 == 0;
	}
}