using System;


namespace R5T.F0007
{
	public class IndentationGenerator : IIndentationGenerator
	{
		#region Infrastructure

	    public static IndentationGenerator Instance { get; } = new();

	    private IndentationGenerator()
	    {
	    }

	    #endregion
	}
}