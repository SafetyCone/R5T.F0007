using System;


namespace R5T.F0007
{
	public class SpacingGenerator : ISpacingGenerator
	{
		#region Infrastructure

	    public static SpacingGenerator Instance { get; } = new();

	    private SpacingGenerator()
	    {
	    }

	    #endregion
	}
}