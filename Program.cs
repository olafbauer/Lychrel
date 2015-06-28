using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lychrel
{
	class Program
	{
		static void Main (string[] args)
		{
			var range = Enumerable.Range (1, 1000);
			var cand = range.Select (r => new LychrelCandidate (r, maxIterations: 100));
			var result = cand.Select (c => Lychrel.ProcessLychrelCandidate (c));
			result.Where (r => !r.IsNotLychrel).ToList ().ForEach (Display);
			Console.ReadLine ();
		}

		public static void Display (LychrelCandidate c)
		{
			Console.WriteLine (c.Number + " " + c.IterationsDone + " " + c.Result);
		}
	}
}