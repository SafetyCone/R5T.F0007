using System;


namespace R5T.F0007
{
    public class SyntaxGenerator : ISyntaxGenerator
    {
        #region Infrastructure

        public static SyntaxGenerator Instance { get; } = new();

        private SyntaxGenerator()
        {
        }

        #endregion
    }
}
