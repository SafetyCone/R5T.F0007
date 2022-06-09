using System;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0132;
using R5T.T0136;


namespace R5T.F0007
{
	[FunctionalityMarker]
	public interface ISyntaxOperator : IFunctionalityMarker
	{
        public TNode Decorate<TNode>(
            TNode node,
            Func<TNode, TNode> decorator)
            where TNode : SyntaxNode
        {
            var outputNode = decorator(node);
            return outputNode;
        }

        public TBaseType PostGenerationInitialSimpleDecorator<TBaseType>(
            TBaseType baseType)
            where TBaseType : BaseTypeDeclarationSyntax
        {
            var output = baseType
                .WithIdentifier(
                    baseType.Identifier
                        .WithLeadingTrivia(
                            Instances.SpacingGenerator.Space()))
                .ModifyAsBraced(
                    this.PostGenerationInitialSimpleDecorator)
                as TBaseType;

            return output;
        }

        public void PostGenerationInitialSimpleDecorator(
            IBraced braced)
        {
            braced.CloseBrace = braced.CloseBrace
                .WithLeadingTrivia(
                    Instances.SpacingGenerator.NewLine());

            braced.OpenBrace = braced.OpenBrace
                .WithLeadingTrivia(
                    Instances.SpacingGenerator.NewLine());
        }

        public NamespaceDeclarationSyntax PostGenerationInitialSimpleDecorator(
            NamespaceDeclarationSyntax @namespace)
        {
            var output = @namespace
                .WithName(
                    @namespace.Name
                        .WithLeadingTrivia(
                            Instances.SpacingGenerator.Space()))
                .ModifyAsBraced(
                    this.PostGenerationInitialSimpleDecorator);

            return output;
        }
    }
}