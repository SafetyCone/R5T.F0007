using System;
using System.Collections.Generic;

using Microsoft.CodeAnalysis;

using R5T.T0132;


namespace R5T.F0007
{
	[FunctionalityMarker]
	public interface ISpacingGenerator : IFunctionalityMarker
	{
        /// <summary>
        /// A blank line is two new lines in a row.
        /// </summary>
        public SyntaxTriviaList BlankLine()
        {
            var output = this.GetNewLines_AsSyntaxTriviaList(2);
            return output;
        }

        public SyntaxTriviaList ByTabCount(
            int tabCount)
        {
            var output = this.GetTabs_AsSyntaxTriviaList(tabCount);
            return output;
        }

        public IEnumerable<SyntaxTrivia> GetTabs_AsEnumerable(
            int tabCount)
        {
            var tab = this.Tab();

            for (int i = 0; i < tabCount; i++)
            {
                yield return tab;
            }
        }

        public SyntaxTriviaList GetTabs_AsSyntaxTriviaList(
            int tabCount)
        {
            var output = new SyntaxTriviaList(
                this.GetTabs_AsEnumerable(tabCount));

            return output;
        }

        public IEnumerable<SyntaxTrivia> GetNewLines_AsEnumerable(
            int newLineCount)
        {
            var newLine = this.NewLine();

            for (int i = 0; i < newLineCount; i++)
            {
                yield return newLine;
            }
        }

        public SyntaxTriviaList GetNewLines_AsSyntaxTriviaList(
            int newLineCount)
        {
            var output = new SyntaxTriviaList(
                this.GetNewLines_AsEnumerable(newLineCount));

            return output;
        }

        /// <summary>
        /// Chooses <see cref="GetNewLines_AsEnumerable(int)"/> as the default.
        /// </summary>
        public IEnumerable<SyntaxTrivia> GetNewLines(
            int newLineCount)
        {
            return this.GetNewLines_AsEnumerable(newLineCount);
        }

        public SyntaxTrivia NewLine()
		{
			return Instances.SyntaxGenerator_Simple.NewLine();
		}

        public SyntaxTriviaList None()
        {
            var output = new SyntaxTriviaList();
            return output;
        }

        public SyntaxTrivia Space()
		{
			return Instances.SyntaxGenerator_Simple.Space();
		}

        public SyntaxTrivia Tab()
        {
            return Instances.SyntaxGenerator_Simple.Tab();
        }

        /// <summary>
        /// Two blank lines are three new lines in a row.
        /// </summary>
        public SyntaxTriviaList TwoBlankLines()
        {
            var output = this.GetNewLines_AsSyntaxTriviaList(3);
            return output;
        }
    }
}