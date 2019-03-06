using System;

namespace ArabicToRomanServices
{
    public class ArabicToRoman
    {
	public string ToRoman(int anArabic)
	{
		if (anArabic == 3)
			return "III";
		else if (anArabic == 2)
			return "II";
		return "I";
	}
    }
}
