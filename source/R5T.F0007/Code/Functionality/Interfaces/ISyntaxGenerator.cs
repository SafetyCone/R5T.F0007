using System;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0132;


namespace R5T.F0007
{
    [FunctionalityMarker]
    public interface ISyntaxGenerator : IFunctionalityMarker,
        F0004.ISyntaxGenerator
    {
        public new ClassDeclarationSyntax Class(
            string classTypeName)
        {
            var output = Instances.SyntaxOperator.Decorate(
                Instances.SyntaxGenerator_Simple.Class(classTypeName),
                Instances.SyntaxOperator.PostGenerationInitialSimpleDecorator);

            return output;
        }

        public new NamespaceDeclarationSyntax Namespace(
            string namespaceName)
        {
            var output = Instances.SyntaxOperator.Decorate(
                Instances.SyntaxGenerator_Simple.Namespace(namespaceName),
                Instances.SyntaxOperator.PostGenerationInitialSimpleDecorator);

            return output;
        }
    }
}
