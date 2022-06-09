using System;

using Microsoft.CodeAnalysis;

using R5T.T0132;


namespace R5T.F0007
{
	[FunctionalityMarker]
	public interface IIndentationGenerator : IFunctionalityMarker
	{
        public SyntaxTriviaList ForClass()
        {
            var output = this.ForType();
            return output;
        }

        public SyntaxTriviaList ForInterface()
        {
            var output = this.ForType();
            return output;
        }

        public SyntaxTriviaList ForType()
        {
            var output = Instances.SpacingGenerator.ByTabCount(
                Instances.TabCounts.ForTypeDeclaration);

            return output;
        }
    }
}