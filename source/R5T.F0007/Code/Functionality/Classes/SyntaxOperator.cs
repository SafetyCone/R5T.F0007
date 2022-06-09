using System;


namespace R5T.F0007
{
	public class SyntaxOperator : ISyntaxOperator
	{
		#region Infrastructure

	    public static SyntaxOperator Instance { get; } = new();

	    private SyntaxOperator()
	    {
	    }

	    #endregion
	}
}