using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArabicToRomanServices;

namespace ArabicToRomanTests
{
    [TestClass]
    public class ArabicToRoman_ToRomanShould
    {
	private readonly ArabicToRoman _arabicToRoman;

	public ArabicToRoman_ToRomanShould()
	{
		_arabicToRoman = new ArabicToRoman(); 
	}

        [TestMethod]
        public void ResturnsIIIFor3()
        {
		var result = _arabicToRoman.ToRoman(3);

		Assert.AreEqual("III", result, false, string.Empty);
        }

        [TestMethod]
        public void ResturnsIIFor2()
        {
		var result = _arabicToRoman.ToRoman(2);

		Assert.AreEqual("II", result, false, string.Empty);
        }

        [TestMethod]
        public void ResturnsIFor1()
        {
		var result = _arabicToRoman.ToRoman(1);

		Assert.AreEqual("I", result, false, string.Empty);
        }
    }
}
