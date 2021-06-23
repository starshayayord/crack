using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task824_Tests
    {
        [TestCase("I speak Goat Latin", ExpectedResult = "Imaa peaksmaaa oatGmaaaa atinLmaaaaa")]
        [TestCase("The quick brown fox jumped over the lazy dog",
            ExpectedResult =
                "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa")]
        public string Should_ToGoatLatin(string s)
        {
            return Task824.ToGoatLatin(s);
        }
    }
}
