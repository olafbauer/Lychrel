using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Lychrel
{
	public static class Lychrel
	{
		public static LychrelCandidate ProcessLychrelCandidate (LychrelCandidate c)
		{
			bool isNotLychrel = false;
			int count = 0;
			BigInteger n = c.Number;

			while (!isNotLychrel && count < c.MaxIterations) {
				n = AddReverse (n);
				isNotLychrel = IsPalindrome (n.ToString ());
				count++;
			}
			return new LychrelCandidate (c.Number, c.MaxIterations, count, isNotLychrel, n.ToString ());
		}

		public static BigInteger AddReverse (BigInteger i)
		{
			return i + BigInteger.Parse (GetReverseString (Convert.ToString (i)));
		}

		public static string GetReverseString (string str)
		{
			char[] c = str.ToCharArray ();
			Array.Reverse (c);
			return new string (c);
		}

		public static bool IsPalindrome (string str)
		{
			if (str.Length == 0) {
				return true;
			}

			string s = str.ToLower ();

			string str1 = s.Substring (0, str.Length / 2);
			string str2 = s.Substring (str.Length / 2 + str.Length % 2);

			return GetReverseString (str1).Equals (str2);
		}
	}
}
