//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\dev\xcss-parser-csharp\AntlrCSharp\XCSSParser.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="XCSSParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public interface IXCSSParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="XCSSParser.selectorGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelectorGroup([NotNull] XCSSParser.SelectorGroupContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="XCSSParser.selector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelector([NotNull] XCSSParser.SelectorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="XCSSParser.combinator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCombinator([NotNull] XCSSParser.CombinatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="XCSSParser.simpleSelectorSequence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleSelectorSequence([NotNull] XCSSParser.SimpleSelectorSequenceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="XCSSParser.typeSelector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeSelector([NotNull] XCSSParser.TypeSelectorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="XCSSParser.typeNamespacePrefix"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeNamespacePrefix([NotNull] XCSSParser.TypeNamespacePrefixContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="XCSSParser.elementName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElementName([NotNull] XCSSParser.ElementNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="XCSSParser.universal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUniversal([NotNull] XCSSParser.UniversalContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="XCSSParser.className"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassName([NotNull] XCSSParser.ClassNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="XCSSParser.attrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAttrib([NotNull] XCSSParser.AttribContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="XCSSParser.pseudo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPseudo([NotNull] XCSSParser.PseudoContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="XCSSParser.functionalPseudo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionalPseudo([NotNull] XCSSParser.FunctionalPseudoContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="XCSSParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] XCSSParser.ExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="XCSSParser.negation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNegation([NotNull] XCSSParser.NegationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="XCSSParser.negationArg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNegationArg([NotNull] XCSSParser.NegationArgContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="XCSSParser.ident"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdent([NotNull] XCSSParser.IdentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="XCSSParser.ws"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWs([NotNull] XCSSParser.WsContext context);
}
