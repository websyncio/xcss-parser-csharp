//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\dev\xcss-parser-csharp\AntlrCSharp\antlr\XCSSParser.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="XCSSParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public interface IXCSSParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParse([NotNull] XCSSParser.ParseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParse([NotNull] XCSSParser.ParseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.selectorGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelectorGroup([NotNull] XCSSParser.SelectorGroupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.selectorGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelectorGroup([NotNull] XCSSParser.SelectorGroupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.selector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelector([NotNull] XCSSParser.SelectorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.selector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelector([NotNull] XCSSParser.SelectorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.combinator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCombinator([NotNull] XCSSParser.CombinatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.combinator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCombinator([NotNull] XCSSParser.CombinatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.simpleSelectorSequence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleSelectorSequence([NotNull] XCSSParser.SimpleSelectorSequenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.simpleSelectorSequence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleSelectorSequence([NotNull] XCSSParser.SimpleSelectorSequenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.elementId"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElementId([NotNull] XCSSParser.ElementIdContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.elementId"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElementId([NotNull] XCSSParser.ElementIdContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.elementIdValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElementIdValue([NotNull] XCSSParser.ElementIdValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.elementIdValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElementIdValue([NotNull] XCSSParser.ElementIdValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.tagName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTagName([NotNull] XCSSParser.TagNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.tagName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTagName([NotNull] XCSSParser.TagNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.typeSelector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeSelector([NotNull] XCSSParser.TypeSelectorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.typeSelector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeSelector([NotNull] XCSSParser.TypeSelectorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.typeNamespacePrefix"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeNamespacePrefix([NotNull] XCSSParser.TypeNamespacePrefixContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.typeNamespacePrefix"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeNamespacePrefix([NotNull] XCSSParser.TypeNamespacePrefixContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.elementName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElementName([NotNull] XCSSParser.ElementNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.elementName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElementName([NotNull] XCSSParser.ElementNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.universal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUniversal([NotNull] XCSSParser.UniversalContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.universal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUniversal([NotNull] XCSSParser.UniversalContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.className"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassName([NotNull] XCSSParser.ClassNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.className"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassName([NotNull] XCSSParser.ClassNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.classNameValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassNameValue([NotNull] XCSSParser.ClassNameValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.classNameValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassNameValue([NotNull] XCSSParser.ClassNameValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondition([NotNull] XCSSParser.ConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondition([NotNull] XCSSParser.ConditionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.text"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterText([NotNull] XCSSParser.TextContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.text"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitText([NotNull] XCSSParser.TextContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.textValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTextValue([NotNull] XCSSParser.TextValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.textValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTextValue([NotNull] XCSSParser.TextValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.textMatchStyle"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTextMatchStyle([NotNull] XCSSParser.TextMatchStyleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.textMatchStyle"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTextMatchStyle([NotNull] XCSSParser.TextMatchStyleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.attrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttrib([NotNull] XCSSParser.AttribContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.attrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttrib([NotNull] XCSSParser.AttribContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.attribName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttribName([NotNull] XCSSParser.AttribNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.attribName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttribName([NotNull] XCSSParser.AttribNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.attribMatchStyle"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttribMatchStyle([NotNull] XCSSParser.AttribMatchStyleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.attribMatchStyle"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttribMatchStyle([NotNull] XCSSParser.AttribMatchStyleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.attribValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttribValue([NotNull] XCSSParser.AttribValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.attribValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttribValue([NotNull] XCSSParser.AttribValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.pseudo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPseudo([NotNull] XCSSParser.PseudoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.pseudo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPseudo([NotNull] XCSSParser.PseudoContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.functionalPseudo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionalPseudo([NotNull] XCSSParser.FunctionalPseudoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.functionalPseudo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionalPseudo([NotNull] XCSSParser.FunctionalPseudoContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] XCSSParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] XCSSParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.negation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNegation([NotNull] XCSSParser.NegationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.negation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNegation([NotNull] XCSSParser.NegationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.negationArg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNegationArg([NotNull] XCSSParser.NegationArgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.negationArg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNegationArg([NotNull] XCSSParser.NegationArgContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.ident"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdent([NotNull] XCSSParser.IdentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.ident"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdent([NotNull] XCSSParser.IdentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XCSSParser.ws"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWs([NotNull] XCSSParser.WsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XCSSParser.ws"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWs([NotNull] XCSSParser.WsContext context);
}
