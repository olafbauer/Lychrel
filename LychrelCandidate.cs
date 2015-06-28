using System;

namespace Lychrel
{
	public class LychrelCandidate
	{
		public readonly Int64 Number;
		public readonly int MaxIterations;
		public readonly int IterationsDone;
		public bool IsNotLychrel;
		public string Result;

		public LychrelCandidate (Int64 number, int maxIterations, int iterationsDone = 0, bool isNotLychrel = false, string result = "")
		{
			this.Number = number;
			this.MaxIterations = maxIterations;
			this.IterationsDone = iterationsDone;
			this.IsNotLychrel = isNotLychrel;
			this.Result = result;
		}
	}
}