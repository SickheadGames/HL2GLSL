/*
 * HlslTokenizer.cs
 * 
 * THIS FILE HAS BEEN GENERATED AUTOMATICALLY. DO NOT EDIT!
 * 
 * See GPL v2.
 * 
 * Copyright (c) 2007 Vitor F. Pamplona. All rights reserved.
 */

using System.IO;

using PerCederberg.Grammatica.Parser;

/**
 * <remarks>A character stream tokenizer.</remarks>
 */
internal class HlslTokenizer : Tokenizer {

    /**
     * <summary>Creates a new tokenizer for the specified input
     * stream.</summary>
     * 
     * <param name='input'>the input stream to read</param>
     * 
     * <exception cref='ParserCreationException'>if the tokenizer
     * couldn't be initialized correctly</exception>
     */
    public HlslTokenizer(TextReader input)
        : base(input) {

        CreatePatterns();
    }

    /**
     * <summary>Initializes the tokenizer by creating all the token
     * patterns.</summary>
     * 
     * <exception cref='ParserCreationException'>if the tokenizer
     * couldn't be initialized correctly</exception>
     */
    private void CreatePatterns() {
        TokenPattern  pattern;

        pattern = new TokenPattern((int) HlslConstants.ADD,
                                   "ADD",
                                   TokenPattern.PatternType.STRING,
                                   "+");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.SUB,
                                   "SUB",
                                   TokenPattern.PatternType.STRING,
                                   "-");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.MULT,
                                   "MULT",
                                   TokenPattern.PatternType.STRING,
                                   "*");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.DIV,
                                   "DIV",
                                   TokenPattern.PatternType.STRING,
                                   "/");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.MOD,
                                   "MOD",
                                   TokenPattern.PatternType.STRING,
                                   "%");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.ADD_ADD,
                                   "ADD_ADD",
                                   TokenPattern.PatternType.STRING,
                                   "++");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.SUB_SUB,
                                   "SUB_SUB",
                                   TokenPattern.PatternType.STRING,
                                   "--");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.EQUAL,
                                   "EQUAL",
                                   TokenPattern.PatternType.STRING,
                                   "=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.ADD_EQUAL,
                                   "ADD_EQUAL",
                                   TokenPattern.PatternType.STRING,
                                   "+=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.SUB_EQUAL,
                                   "SUB_EQUAL",
                                   TokenPattern.PatternType.STRING,
                                   "-=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.MULT_EQUAL,
                                   "MULT_EQUAL",
                                   TokenPattern.PatternType.STRING,
                                   "*=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.DIV_EQUAL,
                                   "DIV_EQUAL",
                                   TokenPattern.PatternType.STRING,
                                   "/=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.MOD_EQUAL,
                                   "MOD_EQUAL",
                                   TokenPattern.PatternType.STRING,
                                   "%=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.MINOR_MINOR_EQUAL,
                                   "MINOR_MINOR_EQUAL",
                                   TokenPattern.PatternType.STRING,
                                   "<<=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.MAJOR_MAJOR_EQUAL,
                                   "MAJOR_MAJOR_EQUAL",
                                   TokenPattern.PatternType.STRING,
                                   ">>=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.AND_EQUAL,
                                   "AND_EQUAL",
                                   TokenPattern.PatternType.STRING,
                                   "&=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.OR_EQUAL,
                                   "OR_EQUAL",
                                   TokenPattern.PatternType.STRING,
                                   "|=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.POT_EQUAL,
                                   "POT_EQUAL",
                                   TokenPattern.PatternType.STRING,
                                   "^=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.EQUAL_EQUAL,
                                   "EQUAL_EQUAL",
                                   TokenPattern.PatternType.STRING,
                                   "==");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.DIFF,
                                   "DIFF",
                                   TokenPattern.PatternType.STRING,
                                   "!=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.LESS_EQUAL,
                                   "LESS_EQUAL",
                                   TokenPattern.PatternType.STRING,
                                   "<=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.MORE_EQUAL,
                                   "MORE_EQUAL",
                                   TokenPattern.PatternType.STRING,
                                   ">=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.TIL,
                                   "TIL",
                                   TokenPattern.PatternType.STRING,
                                   "~");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.MINOR_MINOR,
                                   "MINOR_MINOR",
                                   TokenPattern.PatternType.STRING,
                                   "<<");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.MAJOR_MAJOR,
                                   "MAJOR_MAJOR",
                                   TokenPattern.PatternType.STRING,
                                   ">>");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.AND,
                                   "AND",
                                   TokenPattern.PatternType.STRING,
                                   "&");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.OR,
                                   "OR",
                                   TokenPattern.PatternType.STRING,
                                   "|");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.POT,
                                   "POT",
                                   TokenPattern.PatternType.STRING,
                                   "^");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.AND_AND,
                                   "AND_AND",
                                   TokenPattern.PatternType.STRING,
                                   "&&");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.OR_OR,
                                   "OR_OR",
                                   TokenPattern.PatternType.STRING,
                                   "||");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.NOT,
                                   "NOT",
                                   TokenPattern.PatternType.STRING,
                                   "!");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.MAJOR,
                                   "MAJOR",
                                   TokenPattern.PatternType.STRING,
                                   ">");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.MINOR,
                                   "MINOR",
                                   TokenPattern.PatternType.STRING,
                                   "<");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.OPEN_PAREN,
                                   "OPEN_PAREN",
                                   TokenPattern.PatternType.STRING,
                                   "(");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.CLOSE_PAREN,
                                   "CLOSE_PAREN",
                                   TokenPattern.PatternType.STRING,
                                   ")");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.OPEN_BREACKET,
                                   "OPEN_BREACKET",
                                   TokenPattern.PatternType.STRING,
                                   "{");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.CLOSE_BREACKET,
                                   "CLOSE_BREACKET",
                                   TokenPattern.PatternType.STRING,
                                   "}");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.OPEN_COLCHETES,
                                   "OPEN_COLCHETES",
                                   TokenPattern.PatternType.STRING,
                                   "[");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.CLOSE_COLCHETES,
                                   "CLOSE_COLCHETES",
                                   TokenPattern.PatternType.STRING,
                                   "]");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.DOUBLE_DOT,
                                   "DOUBLE_DOT",
                                   TokenPattern.PatternType.STRING,
                                   ":");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.DOT_COMMA,
                                   "DOT_COMMA",
                                   TokenPattern.PatternType.STRING,
                                   ";");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.COMMA,
                                   "COMMA",
                                   TokenPattern.PatternType.STRING,
                                   ",");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.DOT,
                                   "DOT",
                                   TokenPattern.PatternType.STRING,
                                   ".");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.NUMBER,
                                   "NUMBER",
                                   TokenPattern.PatternType.REGEXP,
                                   "[0-9]+|[0-9]*\\.[0-9]+(E[0-9]+)?(f)?");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.NUMBER_2_4,
                                   "NUMBER_2_4",
                                   TokenPattern.PatternType.REGEXP,
                                   "[2-4]");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.NUMBER_1_4,
                                   "NUMBER_1_4",
                                   TokenPattern.PatternType.REGEXP,
                                   "[1-4]");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.WHITESPACE,
                                   "WHITESPACE",
                                   TokenPattern.PatternType.REGEXP,
                                   "[ ]+");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.TAB,
                                   "TAB",
                                   TokenPattern.PatternType.REGEXP,
                                   "[\\t]");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.NEWLINE,
                                   "NEWLINE",
                                   TokenPattern.PatternType.REGEXP,
                                   "[\\n]");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.NEWLINE2,
                                   "NEWLINE2",
                                   TokenPattern.PatternType.REGEXP,
                                   "[\\r\\n]");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.NEWLINE3,
                                   "NEWLINE3",
                                   TokenPattern.PatternType.REGEXP,
                                   "[\\n\\r]");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.FORMFEED,
                                   "FORMFEED",
                                   TokenPattern.PatternType.REGEXP,
                                   "[\\r]");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.STRING,
                                   "STRING",
                                   TokenPattern.PatternType.REGEXP,
                                   "(\".*[^\\\\]\")|('.*[^\\\\]')");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.RGBA,
                                   "RGBA",
                                   TokenPattern.PatternType.REGEXP,
                                   "[rgba]+");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.XYZW,
                                   "XYZW",
                                   TokenPattern.PatternType.REGEXP,
                                   "[xyzw]+");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.ASM,
                                   "ASM",
                                   TokenPattern.PatternType.REGEXP,
                                   "( ?i)asm");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.ASM_FRAGMENT,
                                   "ASM_FRAGMENT",
                                   TokenPattern.PatternType.STRING,
                                   "asm_fragment");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.BLENDSTATE,
                                   "BLENDSTATE",
                                   TokenPattern.PatternType.STRING,
                                   "BlendState");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.COLUMN_MAJOR,
                                   "COLUMN_MAJOR",
                                   TokenPattern.PatternType.STRING,
                                   "column_major");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.COMPILE_FRAGMENT,
                                   "COMPILE_FRAGMENT",
                                   TokenPattern.PatternType.STRING,
                                   "compile_frgment");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.DISCARD,
                                   "DISCARD",
                                   TokenPattern.PatternType.STRING,
                                   "discard");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.DECL,
                                   "DECL",
                                   TokenPattern.PatternType.STRING,
                                   "decl");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.DO,
                                   "DO",
                                   TokenPattern.PatternType.STRING,
                                   "do");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.ELSE,
                                   "ELSE",
                                   TokenPattern.PatternType.STRING,
                                   "else");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.EXTERN,
                                   "EXTERN",
                                   TokenPattern.PatternType.STRING,
                                   "extern");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.END,
                                   "END",
                                   TokenPattern.PatternType.STRING,
                                   "end");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.FALSE,
                                   "FALSE",
                                   TokenPattern.PatternType.STRING,
                                   "false");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.FOR,
                                   "FOR",
                                   TokenPattern.PatternType.STRING,
                                   "for");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.IF,
                                   "IF",
                                   TokenPattern.PatternType.STRING,
                                   "if");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.IN,
                                   "IN",
                                   TokenPattern.PatternType.STRING,
                                   "in");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.INLINE,
                                   "INLINE",
                                   TokenPattern.PatternType.STRING,
                                   "inline");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.INOUT,
                                   "INOUT",
                                   TokenPattern.PatternType.STRING,
                                   "inout");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.MATRIX,
                                   "MATRIX",
                                   TokenPattern.PatternType.STRING,
                                   "matrix");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.OUT,
                                   "OUT",
                                   TokenPattern.PatternType.STRING,
                                   "out");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.PACKOFFSET,
                                   "PACKOFFSET",
                                   TokenPattern.PatternType.STRING,
                                   "packoffset");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.PASS,
                                   "PASS",
                                   TokenPattern.PatternType.STRING,
                                   "pass");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.PIXELFRAGMENT,
                                   "PIXELFRAGMENT",
                                   TokenPattern.PatternType.STRING,
                                   "pixelfragment");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.REGISTER,
                                   "REGISTER",
                                   TokenPattern.PatternType.STRING,
                                   "register");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.RETURN,
                                   "RETURN",
                                   TokenPattern.PatternType.STRING,
                                   "return");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.ROW_MAJOR,
                                   "ROW_MAJOR",
                                   TokenPattern.PatternType.STRING,
                                   "row_major");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.SAMPLER,
                                   "SAMPLER",
                                   TokenPattern.PatternType.STRING,
                                   "sampler");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.SAMPLER1D,
                                   "SAMPLER1D",
                                   TokenPattern.PatternType.STRING,
                                   "sampler1D");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.SAMPLER2D,
                                   "SAMPLER2D",
                                   TokenPattern.PatternType.STRING,
                                   "sampler2D");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.SAMPLER3D,
                                   "SAMPLER3D",
                                   TokenPattern.PatternType.STRING,
                                   "sampler3D");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.SAMPLERCUBE,
                                   "SAMPLERCUBE",
                                   TokenPattern.PatternType.STRING,
                                   "samplerCUBE");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.SAMPLER_STATE,
                                   "SAMPLER_STATE",
                                   TokenPattern.PatternType.STRING,
                                   "sampler_state");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.SHARED,
                                   "SHARED",
                                   TokenPattern.PatternType.STRING,
                                   "shared");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.STATEBLOCK,
                                   "STATEBLOCK",
                                   TokenPattern.PatternType.STRING,
                                   "stateblock");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.STATEBLOCK_STATE,
                                   "STATEBLOCK_STATE",
                                   TokenPattern.PatternType.STRING,
                                   "stateblock_state");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.STATIC,
                                   "STATIC",
                                   TokenPattern.PatternType.STRING,
                                   "static");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.STRING_TYPE,
                                   "STRING_TYPE",
                                   TokenPattern.PatternType.STRING,
                                   "string");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.STRUCT,
                                   "STRUCT",
                                   TokenPattern.PatternType.STRING,
                                   "struct");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.TECHNIQUE,
                                   "TECHNIQUE",
                                   TokenPattern.PatternType.STRING,
                                   "technique");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.TEXTURE,
                                   "TEXTURE",
                                   TokenPattern.PatternType.STRING,
                                   "texture");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.TEXTURE1D,
                                   "TEXTURE1D",
                                   TokenPattern.PatternType.STRING,
                                   "texture1D");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.TEXTURE2D,
                                   "TEXTURE2D",
                                   TokenPattern.PatternType.STRING,
                                   "texture2D");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.TEXTURE3D,
                                   "TEXTURE3D",
                                   TokenPattern.PatternType.STRING,
                                   "texture3D");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.TEXTURECUBE,
                                   "TEXTURECUBE",
                                   TokenPattern.PatternType.STRING,
                                   "textureCUBE");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.TRUE,
                                   "TRUE",
                                   TokenPattern.PatternType.STRING,
                                   "true");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.TYPEDEF,
                                   "TYPEDEF",
                                   TokenPattern.PatternType.STRING,
                                   "typedef");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.UNIFORM,
                                   "UNIFORM",
                                   TokenPattern.PatternType.STRING,
                                   "uniform");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.VARYING,
                                   "VARYING",
                                   TokenPattern.PatternType.STRING,
                                   "varying");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.VECTOR,
                                   "VECTOR",
                                   TokenPattern.PatternType.STRING,
                                   "vector");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.VERTEXFRAGMENT,
                                   "VERTEXFRAGMENT",
                                   TokenPattern.PatternType.STRING,
                                   "vertexfragment");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.VOID,
                                   "VOID",
                                   TokenPattern.PatternType.STRING,
                                   "void");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.VOLATILE,
                                   "VOLATILE",
                                   TokenPattern.PatternType.STRING,
                                   "volatile");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.WHILE,
                                   "WHILE",
                                   TokenPattern.PatternType.STRING,
                                   "while");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.STOP,
                                   "STOP",
                                   TokenPattern.PatternType.STRING,
                                   "stop");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.FLATTEN,
                                   "FLATTEN",
                                   TokenPattern.PatternType.STRING,
                                   "flatten");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.BRANCH,
                                   "BRANCH",
                                   TokenPattern.PatternType.STRING,
                                   "branch");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.UNROLL,
                                   "UNROLL",
                                   TokenPattern.PatternType.STRING,
                                   "unroll");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.LOOP,
                                   "LOOP",
                                   TokenPattern.PatternType.STRING,
                                   "loop");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.FORCECASE,
                                   "FORCECASE",
                                   TokenPattern.PatternType.STRING,
                                   "forcecase");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.CALL,
                                   "CALL",
                                   TokenPattern.PatternType.STRING,
                                   "call");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.AUTO,
                                   "AUTO",
                                   TokenPattern.PatternType.STRING,
                                   "auto");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.BREAK,
                                   "BREAK",
                                   TokenPattern.PatternType.STRING,
                                   "break");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.COMPILE,
                                   "COMPILE",
                                   TokenPattern.PatternType.STRING,
                                   "compile");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.CONST,
                                   "CONST",
                                   TokenPattern.PatternType.STRING,
                                   "const");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.CHAR,
                                   "CHAR",
                                   TokenPattern.PatternType.STRING,
                                   "char");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.CLASS,
                                   "CLASS",
                                   TokenPattern.PatternType.STRING,
                                   "class");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.CASE,
                                   "CASE",
                                   TokenPattern.PatternType.STRING,
                                   "case");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.CATCH,
                                   "CATCH",
                                   TokenPattern.PatternType.STRING,
                                   "catch");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.DEFAULT,
                                   "DEFAULT",
                                   TokenPattern.PatternType.STRING,
                                   "default");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.DELETE,
                                   "DELETE",
                                   TokenPattern.PatternType.STRING,
                                   "delete");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.CONST_CAST,
                                   "CONST_CAST",
                                   TokenPattern.PatternType.STRING,
                                   "const_cast");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.CONTINUE,
                                   "CONTINUE",
                                   TokenPattern.PatternType.STRING,
                                   "continue");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.EXPLICIT,
                                   "EXPLICIT",
                                   TokenPattern.PatternType.STRING,
                                   "explicit");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.FRIEND,
                                   "FRIEND",
                                   TokenPattern.PatternType.STRING,
                                   "friend");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.DYNAMIC_CAST,
                                   "DYNAMIC_CAST",
                                   TokenPattern.PatternType.STRING,
                                   "dynamic_cast");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.ENUM,
                                   "ENUM",
                                   TokenPattern.PatternType.STRING,
                                   "enum");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.MUTABLE,
                                   "MUTABLE",
                                   TokenPattern.PatternType.STRING,
                                   "mutable");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.NAMESPACE,
                                   "NAMESPACE",
                                   TokenPattern.PatternType.STRING,
                                   "namespace");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.GOTO,
                                   "GOTO",
                                   TokenPattern.PatternType.STRING,
                                   "goto");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.LONG,
                                   "LONG",
                                   TokenPattern.PatternType.STRING,
                                   "long");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.PRIVATE,
                                   "PRIVATE",
                                   TokenPattern.PatternType.STRING,
                                   "private");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.PROTECTED,
                                   "PROTECTED",
                                   TokenPattern.PatternType.STRING,
                                   "protected");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.NEW,
                                   "NEW",
                                   TokenPattern.PatternType.STRING,
                                   "new");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.OPERATOR,
                                   "OPERATOR",
                                   TokenPattern.PatternType.STRING,
                                   "operator");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.PUBLIC,
                                   "PUBLIC",
                                   TokenPattern.PatternType.STRING,
                                   "public");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.REINTERPRET_CAST,
                                   "REINTERPRET_CAST",
                                   TokenPattern.PatternType.STRING,
                                   "reinterpret_cast");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.SHORT,
                                   "SHORT",
                                   TokenPattern.PatternType.STRING,
                                   "short");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.STATIC_CAST,
                                   "STATIC_CAST",
                                   TokenPattern.PatternType.STRING,
                                   "static_cast");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.SIGNED,
                                   "SIGNED",
                                   TokenPattern.PatternType.STRING,
                                   "signed");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.SIZEOF,
                                   "SIZEOF",
                                   TokenPattern.PatternType.STRING,
                                   "sizeof");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.SWITCH,
                                   "SWITCH",
                                   TokenPattern.PatternType.STRING,
                                   "switch");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.TEMPLATE,
                                   "TEMPLATE",
                                   TokenPattern.PatternType.STRING,
                                   "template");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.THIS,
                                   "THIS",
                                   TokenPattern.PatternType.STRING,
                                   "this");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.THROW,
                                   "THROW",
                                   TokenPattern.PatternType.STRING,
                                   "throw");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.TRY,
                                   "TRY",
                                   TokenPattern.PatternType.STRING,
                                   "try");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.TYPENAME,
                                   "TYPENAME",
                                   TokenPattern.PatternType.STRING,
                                   "typename");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.UNION,
                                   "UNION",
                                   TokenPattern.PatternType.STRING,
                                   "union");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.UNSIGNED,
                                   "UNSIGNED",
                                   TokenPattern.PatternType.STRING,
                                   "unsigned");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.USING,
                                   "USING",
                                   TokenPattern.PatternType.STRING,
                                   "using");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.VIRTUAL,
                                   "VIRTUAL",
                                   TokenPattern.PatternType.STRING,
                                   "virtual");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.BINORMAL,
                                   "BINORMAL",
                                   TokenPattern.PatternType.STRING,
                                   "BINORMAL");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.BLENDINDICES,
                                   "BLENDINDICES",
                                   TokenPattern.PatternType.STRING,
                                   "BLENDINDICES");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.BLENDWEIGHT,
                                   "BLENDWEIGHT",
                                   TokenPattern.PatternType.STRING,
                                   "BLENDWEIGHT");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.NORMAL,
                                   "NORMAL",
                                   TokenPattern.PatternType.STRING,
                                   "NORMAL");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.POSITIONT,
                                   "POSITIONT",
                                   TokenPattern.PatternType.STRING,
                                   "POSITIONT");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.VFACE,
                                   "VFACE",
                                   TokenPattern.PatternType.STRING,
                                   "VFACE");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.VPOS,
                                   "VPOS",
                                   TokenPattern.PatternType.STRING,
                                   "VPOS");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.FOG,
                                   "FOG",
                                   TokenPattern.PatternType.STRING,
                                   "FOG");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.TESSFACTOR,
                                   "TESSFACTOR",
                                   TokenPattern.PatternType.STRING,
                                   "TESSFACTOR");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.DEPTH,
                                   "DEPTH",
                                   TokenPattern.PatternType.STRING,
                                   "DEPTH");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.POSITION,
                                   "POSITION",
                                   TokenPattern.PatternType.REGEXP,
                                   "POSITION([0-9])?");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.TEXCOORD,
                                   "TEXCOORD",
                                   TokenPattern.PatternType.REGEXP,
                                   "TEXCOORD([0-9])?");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.TEXUNIT,
                                   "TEXUNIT",
                                   TokenPattern.PatternType.REGEXP,
                                   "TEXUNIT([0-9])?");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.COLOR,
                                   "COLOR",
                                   TokenPattern.PatternType.REGEXP,
                                   "COLOR([0-9])?");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.TANGENT,
                                   "TANGENT",
                                   TokenPattern.PatternType.REGEXP,
                                   "TANGENT([0-9])?");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.PSIZE,
                                   "PSIZE",
                                   TokenPattern.PatternType.STRING,
                                   "PSIZE");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.WORLD,
                                   "WORLD",
                                   TokenPattern.PatternType.REGEXP,
                                   "WORLD(I)?(T)?");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.VIEW,
                                   "VIEW",
                                   TokenPattern.PatternType.REGEXP,
                                   "VIEW(I)?(T)?");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.PROJ,
                                   "PROJ",
                                   TokenPattern.PatternType.REGEXP,
                                   "PROJ(I)?(T)?");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.WORLDVIEW,
                                   "WORLDVIEW",
                                   TokenPattern.PatternType.REGEXP,
                                   "WORLDVIEW(I)?(T)?");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.WORLDPROJ,
                                   "WORLDPROJ",
                                   TokenPattern.PatternType.REGEXP,
                                   "WORLDPROJ(I)?(T)?");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.VIEWPROJ,
                                   "VIEWPROJ",
                                   TokenPattern.PatternType.REGEXP,
                                   "VIEWPROJ(I)?(T)?");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.WORLDVIEWPROJ,
                                   "WORLDVIEWPROJ",
                                   TokenPattern.PatternType.REGEXP,
                                   "WORLDVIEWPROJ(I)?(T)?");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.FLOAT,
                                   "FLOAT",
                                   TokenPattern.PatternType.REGEXP,
                                   "float([2-4](x[2-4])?)?");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.INT,
                                   "INT",
                                   TokenPattern.PatternType.REGEXP,
                                   "int([2-4](x[2-4])?)?");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.HALF,
                                   "HALF",
                                   TokenPattern.PatternType.REGEXP,
                                   "half([2-4](x[2-4])?)?");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.DOUBLE,
                                   "DOUBLE",
                                   TokenPattern.PatternType.REGEXP,
                                   "double([2-4](x[2-4])?)?");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.BOOL,
                                   "BOOL",
                                   TokenPattern.PatternType.REGEXP,
                                   "bool([2-4](x[2-4])?)?");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.BASIC_FLOAT,
                                   "BASIC_FLOAT",
                                   TokenPattern.PatternType.STRING,
                                   "float");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.BASIC_INT,
                                   "BASIC_INT",
                                   TokenPattern.PatternType.STRING,
                                   "int");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.BASIC_HALF,
                                   "BASIC_HALF",
                                   TokenPattern.PatternType.STRING,
                                   "half");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.BASIC_BOOL,
                                   "BASIC_BOOL",
                                   TokenPattern.PatternType.STRING,
                                   "bool");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.BASIC_DOUBLE,
                                   "BASIC_DOUBLE",
                                   TokenPattern.PatternType.STRING,
                                   "double");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.BASIC_UINT,
                                   "BASIC_UINT",
                                   TokenPattern.PatternType.STRING,
                                   "uint");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.PRE_DEFINE,
                                   "PRE_DEFINE",
                                   TokenPattern.PatternType.REGEXP,
                                   "#define[^\\n\\r]*");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.PRE_IF,
                                   "PRE_IF",
                                   TokenPattern.PatternType.REGEXP,
                                   "#if[^\\n\\r]*");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.PRE_ELSEIF,
                                   "PRE_ELSEIF",
                                   TokenPattern.PatternType.REGEXP,
                                   "#elseif[^\\n\\r]*");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.PRE_ENDIF,
                                   "PRE_ENDIF",
                                   TokenPattern.PatternType.REGEXP,
                                   "#endif[^\\n\\r]*");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.PRE_IFDEF,
                                   "PRE_IFDEF",
                                   TokenPattern.PatternType.REGEXP,
                                   "#ifdef[^\\n\\r]*");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.PRE_IFNDEF,
                                   "PRE_IFNDEF",
                                   TokenPattern.PatternType.REGEXP,
                                   "#ifndef[^\\n\\r]*");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.PRE_ERROR,
                                   "PRE_ERROR",
                                   TokenPattern.PatternType.REGEXP,
                                   "#error[^\\n\\r]*");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.PRE_INCLUDE,
                                   "PRE_INCLUDE",
                                   TokenPattern.PatternType.REGEXP,
                                   "#include[^\\n\\r]*");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.PRE_LINE,
                                   "PRE_LINE",
                                   TokenPattern.PatternType.REGEXP,
                                   "#line[^\\n\\r]*");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.PRE_PRAGMA,
                                   "PRE_PRAGMA",
                                   TokenPattern.PatternType.REGEXP,
                                   "#pragma[^\\n\\r]*");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.NOINTERPOLATION,
                                   "NOINTERPOLATION",
                                   TokenPattern.PatternType.STRING,
                                   "nointerpolation");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.IDENTIFIER,
                                   "IDENTIFIER",
                                   TokenPattern.PatternType.REGEXP,
                                   "[A-Za-z_][A-Za-z0-9_]*");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.QUOTED_STRING,
                                   "QUOTED_STRING",
                                   TokenPattern.PatternType.REGEXP,
                                   "\"([^\"]|\"\")*+\"");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.COMMENT,
                                   "COMMENT",
                                   TokenPattern.PatternType.REGEXP,
                                   "/\\*([^*]|\\*[^/])*\\*/");
        AddPattern(pattern);

        pattern = new TokenPattern((int) HlslConstants.COMMENTCPP,
                                   "COMMENTCPP",
                                   TokenPattern.PatternType.REGEXP,
                                   "//[^\\n\\r]*");
        AddPattern(pattern);
    }
}
