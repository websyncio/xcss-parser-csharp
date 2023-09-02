grammar XCSS;

/*
 * Parser Rules
 */

combinator: '+' S* | '>' S*;

property: IDENT S*;

ruleset: selector[ ',' S* selector ]*;

selector:
	simple_selector[ combinator selector | S+ [ combinator? selector ]? ]?;

simple_selector:
	element_name[ HASH | class | attrib | pseudo ]*
	|[ HASH | class | attrib | pseudo ]+;

class: '.' IDENT;

element_name: IDENT | '*';

attrib:
	'[' S* IDENT S*[ [ '=' | INCLUDES | DASHMATCH ] S* [ IDENT | STRING ] S* ]? ']';

pseudo:
	':'[ IDENT | FUNCTION S* [IDENT S*]? ')' ];

/*
 * Lexer Rules
 */

// fragment A: ['A' | 'a']; fragment S: ('S' | 's'); fragment Y: ('Y' | 'y');

// fragment LOWERCASE: [a-z]; fragment UPPERCASE: [A-Z];

// SAYS: S A Y S;

// WORD: (LOWERCASE | UPPERCASE)+;

// TEXT: '"' .*? '"';

// WHITESPACE: (' ' | '\t')+ -> skip;

// NEWLINE: ('\r'? '\n' | '\r')+;

// ANY: . -> channel(HIDDEN);

NMSTART: [_a-z];
NMCHAR: [_a-z0-9-];
IDENT: NMSTART NMCHAR*;
S: (' ' | '\t' | '\r' | '\n' | '\f')+;
WHITESPACE: (' ' | '\t')+ -> skip;
ANY: . -> channel(HIDDEN);
