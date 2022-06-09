using System;

using R5T.Z0002;

using ISyntaxGenerator_Simple = R5T.F0004.ISyntaxGenerator;


namespace R5T.F0007
{
    public static class Instances
    {
        public static ISpacingGenerator SpacingGenerator { get; } = F0007.SpacingGenerator.Instance;
        public static ISyntaxGenerator_Simple SyntaxGenerator_Simple { get; } = F0004.SyntaxGenerator.Instance;
        public static ISyntaxOperator SyntaxOperator { get; } = F0007.SyntaxOperator.Instance;
        public static ITabCounts TabCounts { get; } = Z0002.TabCounts.Instance;
    }
}
