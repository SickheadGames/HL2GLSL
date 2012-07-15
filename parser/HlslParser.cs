/*
 * HlslParser.cs
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
 * <remarks>A token stream parser.</remarks>
 */
internal class HlslParser : RecursiveDescentParser {

    /**
     * <summary>An enumeration with the generated production node
     * identity constants.</summary>
     */
    private enum SynteticPatterns {
        SUBPRODUCTION_1 = 3001,
        SUBPRODUCTION_2 = 3002,
        SUBPRODUCTION_3 = 3003,
        SUBPRODUCTION_4 = 3004,
        SUBPRODUCTION_5 = 3005,
        SUBPRODUCTION_6 = 3006,
        SUBPRODUCTION_7 = 3007,
        SUBPRODUCTION_8 = 3008,
        SUBPRODUCTION_9 = 3009,
        SUBPRODUCTION_10 = 3010,
        SUBPRODUCTION_11 = 3011,
        SUBPRODUCTION_12 = 3012,
        SUBPRODUCTION_13 = 3013,
        SUBPRODUCTION_14 = 3014,
        SUBPRODUCTION_15 = 3015,
        SUBPRODUCTION_16 = 3016,
        SUBPRODUCTION_17 = 3017,
        SUBPRODUCTION_18 = 3018,
        SUBPRODUCTION_19 = 3019,
        SUBPRODUCTION_20 = 3020,
        SUBPRODUCTION_21 = 3021,
        SUBPRODUCTION_22 = 3022,
        SUBPRODUCTION_23 = 3023,
        SUBPRODUCTION_24 = 3024,
        SUBPRODUCTION_25 = 3025,
        SUBPRODUCTION_26 = 3026,
        SUBPRODUCTION_27 = 3027,
        SUBPRODUCTION_28 = 3028,
        SUBPRODUCTION_29 = 3029,
        SUBPRODUCTION_30 = 3030,
        SUBPRODUCTION_31 = 3031,
        SUBPRODUCTION_32 = 3032,
        SUBPRODUCTION_33 = 3033,
        SUBPRODUCTION_34 = 3034,
        SUBPRODUCTION_35 = 3035,
        SUBPRODUCTION_36 = 3036,
        SUBPRODUCTION_37 = 3037,
        SUBPRODUCTION_38 = 3038,
        SUBPRODUCTION_39 = 3039,
        SUBPRODUCTION_40 = 3040,
        SUBPRODUCTION_41 = 3041,
        SUBPRODUCTION_42 = 3042,
        SUBPRODUCTION_43 = 3043,
        SUBPRODUCTION_44 = 3044,
        SUBPRODUCTION_45 = 3045,
        SUBPRODUCTION_46 = 3046,
        SUBPRODUCTION_47 = 3047,
        SUBPRODUCTION_48 = 3048,
        SUBPRODUCTION_49 = 3049,
        SUBPRODUCTION_50 = 3050,
        SUBPRODUCTION_51 = 3051,
        SUBPRODUCTION_52 = 3052,
        SUBPRODUCTION_53 = 3053,
        SUBPRODUCTION_54 = 3054,
        SUBPRODUCTION_55 = 3055,
        SUBPRODUCTION_56 = 3056,
        SUBPRODUCTION_57 = 3057,
        SUBPRODUCTION_58 = 3058,
        SUBPRODUCTION_59 = 3059,
        SUBPRODUCTION_60 = 3060,
        SUBPRODUCTION_61 = 3061,
        SUBPRODUCTION_62 = 3062
    }

    /**
     * <summary>Creates a new parser.</summary>
     * 
     * <param name='input'>the input stream to read from</param>
     * 
     * <exception cref='ParserCreationException'>if the parser
     * couldn't be initialized correctly</exception>
     */
    public HlslParser(TextReader input)
        : base(new HlslTokenizer(input)) {

        CreatePatterns();
    }

    /**
     * <summary>Creates a new parser.</summary>
     * 
     * <param name='input'>the input stream to read from</param>
     * 
     * <param name='analyzer'>the analyzer to parse with</param>
     * 
     * <exception cref='ParserCreationException'>if the parser
     * couldn't be initialized correctly</exception>
     */
    public HlslParser(TextReader input, Analyzer analyzer)
        : base(new HlslTokenizer(input), analyzer) {

        CreatePatterns();
    }

    /**
     * <summary>Initializes the parser by creating all the production
     * patterns.</summary>
     * 
     * <exception cref='ParserCreationException'>if the parser
     * couldn't be initialized correctly</exception>
     */
    private void CreatePatterns() {
        ProductionPattern             pattern;
        ProductionPatternAlternative  alt;

        pattern = new ProductionPattern((int) HlslConstants.FILE,
                                        "File");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.WS, 1, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_1, 1, -1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.TECHNIQUE_DECLARATION,
                                        "Technique_Declaration");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.TECHNIQUE, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 1, 1);
        alt.AddToken((int) HlslConstants.IDENTIFIER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.OPEN_BREACKET, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_2, 0, -1);
        alt.AddToken((int) HlslConstants.CLOSE_BREACKET, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.PASS_DECLARATION,
                                        "Pass_Declaration");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.PASS, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 1, 1);
        alt.AddToken((int) HlslConstants.IDENTIFIER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.OPEN_BREACKET, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_3, 0, -1);
        alt.AddToken((int) HlslConstants.CLOSE_BREACKET, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.PASS_INSTRUCTIONS,
                                        "Pass_Instructions");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.IDENTIFIER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.EQUAL, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_4, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_5, 1, 1);
        alt.AddToken((int) HlslConstants.DOT_COMMA, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.STRUCT_DECLARATION,
                                        "Struct_Declaration");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.STRUCT, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 1, 1);
        alt.AddToken((int) HlslConstants.IDENTIFIER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.OPEN_BREACKET, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_6, 1, -1);
        alt.AddToken((int) HlslConstants.CLOSE_BREACKET, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.DOT_COMMA, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.FUNCTION_OR_VARIABLE_DECLARATION,
                                        "Function_OR_Variable_Declaration");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_7, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_8, 0, 1);
        alt.AddProduction((int) HlslConstants.TYPE, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 1, 1);
        alt.AddToken((int) HlslConstants.IDENTIFIER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_9, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.VARIABLE_DECLARATION_PART,
                                        "Variable_Declaration_PART");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_10, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_12, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_14, 0, -1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_15, 0, 1);
        alt.AddToken((int) HlslConstants.DOT_COMMA, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.FUNCTION_PART,
                                        "Function_PART");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.PARAMETERS, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_16, 0, 1);
        alt.AddToken((int) HlslConstants.OPEN_BREACKET, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.FUNCTION_BODY, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.CLOSE_BREACKET, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.PARAMETERS,
                                        "Parameters");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.OPEN_PAREN, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_17, 0, 1);
        alt.AddToken((int) HlslConstants.CLOSE_PAREN, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.LIST_OF_PARAMS,
                                        "List_Of_Params");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.FUNCTION_PARAM, 1, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_18, 0, -1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.FUNCTION_PARAM,
                                        "Function_Param");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_19, 0, 1);
        alt.AddProduction((int) HlslConstants.VARIABLE_DECLARATION, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.FUNCTION_BODY,
                                        "Function_Body");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_20, 1, -1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.STATEMENT,
                                        "Statement");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.RETURN_STATEMENT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.FLOW_CONTROL_WORDS, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.DO_STATEMENT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.IF_SWITCH_ATTRIBUTES, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_21, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.WHILE_FOR_ATTRIBUTES, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_22, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.PRE_PROCESSOR_DIRECTIVES, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.IF_STATEMENT,
                                        "IF_Statement");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.IF, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.OPEN_PAREN, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.CONDITION, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.CLOSE_PAREN, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_23, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_24, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.SWITCH_STATEMENT,
                                        "Switch_Statement");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.SWITCH, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.OPEN_PAREN, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.EXPRESSION, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.CLOSE_PAREN, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.OPEN_BREACKET, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_25, 1, -1);
        alt.AddToken((int) HlslConstants.CLOSE_BREACKET, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.CASE_STATEMENT,
                                        "Case_Statement");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_26, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.DOUBLE_DOT, 1, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_27, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.WHILE_STATEMENT,
                                        "While_Statement");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.WHILE, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.OPEN_PAREN, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.CONDITION, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.CLOSE_PAREN, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.STATEMENT_SCOPE, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.DO_STATEMENT,
                                        "Do_Statement");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.DO, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.STATEMENT_SCOPE, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.WHILE, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.OPEN_PAREN, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.CONDITION, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.CLOSE_PAREN, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.DOT_COMMA, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.FOR_STATEMENT,
                                        "For_Statement");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.FOR, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.OPEN_PAREN, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_28, 0, 1);
        alt.AddToken((int) HlslConstants.DOT_COMMA, 1, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_29, 0, 1);
        alt.AddToken((int) HlslConstants.DOT_COMMA, 1, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_30, 0, 1);
        alt.AddToken((int) HlslConstants.CLOSE_PAREN, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.STATEMENT_SCOPE, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.PRE_PROCESSOR_DIRECTIVES,
                                        "Pre_Processor_Directives");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_31, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.STATEMENT_SCOPE,
                                        "Statement_Scope");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.OPEN_BREACKET, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.FUNCTION_BODY, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.CLOSE_BREACKET, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.FUNCTION_BODY, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.VARIABLE_DECLARATION,
                                        "Variable_Declaration");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_32, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_33, 0, 1);
        alt.AddProduction((int) HlslConstants.TYPE, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 1, 1);
        alt.AddToken((int) HlslConstants.IDENTIFIER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_34, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_36, 0, -1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_37, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.RETURN_STATEMENT,
                                        "Return_Statement");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_38, 0, 1);
        alt.AddProduction((int) HlslConstants.EXPRESSION, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.DOT_COMMA, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.VARIABLE_ASSIGNMENT,
                                        "Variable_Assignment");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.IDENTIFIER_COMPOSED, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_39, 0, 1);
        alt.AddProduction((int) HlslConstants.ASSIGNMENT_OPERATOR, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.INITIALIZERS, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.DOT_COMMA, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.VARIABLE_ASSIGNMENT_WITHOUT_DOT_COMMA,
                                        "Variable_Assignment_WithoutDotComma");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.IDENTIFIER_COMPOSED, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_40, 0, 1);
        alt.AddProduction((int) HlslConstants.ASSIGNMENT_OPERATOR, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.INITIALIZERS, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.CONDITION,
                                        "Condition");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.EXPRESSION, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.COMPARISON_OPERATORS, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.EXPRESSION, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.INITIALIZERS,
                                        "Initializers");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.NOT, 0, 1);
        alt.AddProduction((int) HlslConstants.EXPRESSION, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.EXPRESSION,
                                        "Expression");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.SUB, 0, 1);
        alt.AddProduction((int) HlslConstants.TERM, 1, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_41, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.EXPRESSION_TAIL,
                                        "ExpressionTail");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_42, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.EXPRESSION, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.TERM,
                                        "Term");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.FACTOR, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.TERM_TAIL, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.TERM_TAIL,
                                        "TermTail");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_43, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.TERM, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.FACTOR,
                                        "Factor");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.ATOM, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.OPEN_PAREN, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.EXPRESSION, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.CLOSE_PAREN, 1, 1);
        alt.AddProduction((int) HlslConstants.COMPOSE_IDENTIFIER, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.ATOM,
                                        "Atom");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.NUMBER, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.FUNCTION_CONSTRUCTOR_CALL_OR_VARIABLE_DECLARATION, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.PREFIX_POSTFIX_OPERATORS, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.IDENTIFIER_COMPOSED, 1, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_44, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.IDENTIFIER_COMPOSED_REQUIRED, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_45, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_47, 1, 1);
        alt.AddProduction((int) HlslConstants.TYPE, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.PART_OF_VARIABLE_DECLARATION, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.FUNCTION_CONSTRUCTOR_CALL_OR_VARIABLE_DECLARATION,
                                        "Function_Constructor_Call_OR_Variable_Declaration");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.TYPE, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_48, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.PART_OF_PROPERTY_SPECIFICATION,
                                        "PartOf_Property_Specification");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.OPEN_BREACKET, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_49, 1, -1);
        alt.AddToken((int) HlslConstants.CLOSE_BREACKET, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.PART_OF_CONSTRUCTOR_CALL,
                                        "PartOf_Constructor_Call");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.OPEN_PAREN, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_51, 0, 1);
        alt.AddToken((int) HlslConstants.CLOSE_PAREN, 1, 1);
        alt.AddProduction((int) HlslConstants.COMPOSE_IDENTIFIER, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.PART_OF_VARIABLE_DECLARATION,
                                        "PartOf_Variable_Declaration");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.IDENTIFIER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_52, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_54, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_56, 0, -1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_57, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.PART_OF_VARIABLE_ASSIGNMENT,
                                        "PartOf_Variable_Assignment");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_58, 0, 1);
        alt.AddProduction((int) HlslConstants.ASSIGNMENT_OPERATOR, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.INITIALIZERS, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.STORAGE_CLASS,
                                        "Storage_Class");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.EXTERN, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.STATIC, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.NOINTERPOLATION, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.SHARED, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.UNIFORM, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.VOLATILE, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.TYPE_MODIFIER,
                                        "Type_Modifier");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.CONST, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.ROW_MAJOR, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.COLUMN_MAJOR, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.TYPE,
                                        "Type");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.BASIC_FLOAT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.FLOAT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.BASIC_INT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.INT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.BASIC_UINT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.BASIC_HALF, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.HALF, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.BASIC_DOUBLE, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.DOUBLE, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.BASIC_BOOL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.BOOL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.VECTOR_EXP, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.MATRIX_EXP, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.SAMPLER, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.SAMPLER1D, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.SAMPLER2D, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.SAMPLER3D, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.SAMPLERCUBE, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.SAMPLER_STATE, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.TEXTURE, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.TEXTURE1D, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.TEXTURE2D, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.TEXTURE3D, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.TEXTURECUBE, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.VOID, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.IDENTIFIER, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.VECTOR_EXP,
                                        "VectorExp");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.VECTOR, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.MINOR, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_59, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.MAJOR, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.VECTOR_EXP_TYPE,
                                        "VectorExp_Type");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.BASIC_TYPE, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.VECTOR_EXP_NUMBER,
                                        "VectorExp_Number");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.NUMBER_2_4, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.VECTOR_EXP_TYPE_NUMBER,
                                        "VectorExp_Type_Number");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.BASIC_TYPE, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.COMMA, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.NUMBER, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.MATRIX_EXP,
                                        "MatrixExp");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.MATRIX, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.MINOR, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.BASIC_TYPE, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.COMMA, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.NUMBER_1_4, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.COMMA, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.NUMBER_1_4, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.MAJOR, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.BASIC_TYPE,
                                        "Basic_Type");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.BASIC_FLOAT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.BASIC_INT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.BASIC_HALF, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.BASIC_DOUBLE, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.BASIC_BOOL, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.SEMANTICAL_PARAMETERS,
                                        "SemanticalParameters");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.INPUT_SEMANTICAL_PARAMETERS, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.OUTPUT_SEMANTICAL_PARAMETERS, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.IN_OUT_SEMANTICAL_PARAMETERS, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.SEMANTIC_MATRIXES, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.INPUT_SEMANTICAL_PARAMETERS,
                                        "InputSemanticalParameters");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.BINORMAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.BLENDINDICES, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.BLENDWEIGHT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.NORMAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.POSITIONT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.TANGENT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.VFACE, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.VPOS, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.OUTPUT_SEMANTICAL_PARAMETERS,
                                        "OutputSemanticalParameters");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.FOG, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.TESSFACTOR, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.DEPTH, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.IN_OUT_SEMANTICAL_PARAMETERS,
                                        "InOutSemanticalParameters");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.POSITION, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.TEXCOORD, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.TEXUNIT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.COLOR, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.PSIZE, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.ASSIGNMENT_OPERATOR,
                                        "Assignment_Operator");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.EQUAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.ADD_EQUAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.SUB_EQUAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.MULT_EQUAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.DIV_EQUAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.MOD_EQUAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.MINOR_MINOR_EQUAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.MAJOR_MAJOR_EQUAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.AND_EQUAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.OR_EQUAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.POT_EQUAL, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.PREFIX_POSTFIX_OPERATORS,
                                        "Prefix_Postfix_Operators");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.ADD_ADD, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.SUB_SUB, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.COMPARISON_OPERATORS,
                                        "Comparison_Operators");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.MINOR, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.MAJOR, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.EQUAL_EQUAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.DIFF, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.LESS_EQUAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.MORE_EQUAL, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.BOOLEAN_OPERATORS,
                                        "Boolean_Operators");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.AND_AND, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.OR_OR, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.NOT, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.IN_OUT_INOUT,
                                        "In_out_inout");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.IN, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.OUT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.INOUT, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.REGISTER_FUNC,
                                        "Register_Func");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.REGISTER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.OPEN_PAREN, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.IDENTIFIER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.CLOSE_PAREN, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.PACKOFFSET_FUNC,
                                        "Packoffset_Func");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.PACKOFFSET, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.OPEN_PAREN, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.IDENTIFIER_COMPOSED, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.CLOSE_PAREN, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.IDENTIFIER_COMPOSED,
                                        "Identifier_Composed");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.IDENTIFIER, 1, 1);
        alt.AddProduction((int) HlslConstants.COMPOSE_IDENTIFIER, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.COMPOSE_IDENTIFIER,
                                        "Compose_Identifier");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_60, 1, -1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.IDENTIFIER_COMPOSED_REQUIRED,
                                        "Identifier_Composed_Required");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.IDENTIFIER, 1, 1);
        alt.AddProduction((int) HlslConstants.COMPOSE_IDENTIFIER, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.FLOW_CONTROL_WORDS,
                                        "Flow_Control_Words");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_61, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.DOT_COMMA, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.WHILE_FOR_ATTRIBUTES,
                                        "While_For_Attributes");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.UNROLL, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.OPEN_PAREN, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.NUMBER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.CLOSE_PAREN, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.LOOP, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.IF_SWITCH_ATTRIBUTES,
                                        "IF_Switch_Attributes");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.CALL, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.FORCECASE, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.FLATTEN, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.BRANCH, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.SEMANTIC_MATRIXES,
                                        "SemanticMatrixes");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.WORLDVIEWPROJ, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.WORLDVIEW, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.WORLDPROJ, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.VIEWPROJ, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.WORLD, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.VIEW, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.PROJ, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) HlslConstants.WS,
                                        "WS");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_62, 1, -1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_1,
                                        "Subproduction1");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.FUNCTION_OR_VARIABLE_DECLARATION, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.STRUCT_DECLARATION, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.TECHNIQUE_DECLARATION, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.PRE_PROCESSOR_DIRECTIVES, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_2,
                                        "Subproduction2");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.PASS_DECLARATION, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_3,
                                        "Subproduction3");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.PASS_INSTRUCTIONS, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_4,
                                        "Subproduction4");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.COMPILE, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 1, 1);
        alt.AddToken((int) HlslConstants.IDENTIFIER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_5,
                                        "Subproduction5");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.EXPRESSION, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_6,
                                        "Subproduction6");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.VARIABLE_DECLARATION, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.DOT_COMMA, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_7,
                                        "Subproduction7");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.STORAGE_CLASS, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_8,
                                        "Subproduction8");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.TYPE_MODIFIER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_9,
                                        "Subproduction9");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.FUNCTION_PART, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.VARIABLE_DECLARATION_PART, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_10,
                                        "Subproduction10");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.OPEN_COLCHETES, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.NUMBER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.CLOSE_COLCHETES, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_11,
                                        "Subproduction11");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.OPEN_COLCHETES, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.NUMBER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.CLOSE_COLCHETES, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_12,
                                        "Subproduction12");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.COMMA, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.IDENTIFIER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_11, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_13,
                                        "Subproduction13");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.SEMANTICAL_PARAMETERS, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.REGISTER_FUNC, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.PACKOFFSET_FUNC, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_14,
                                        "Subproduction14");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.DOUBLE_DOT, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_13, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_15,
                                        "Subproduction15");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.ASSIGNMENT_OPERATOR, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.INITIALIZERS, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_16,
                                        "Subproduction16");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.DOUBLE_DOT, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.SEMANTICAL_PARAMETERS, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_17,
                                        "Subproduction17");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.LIST_OF_PARAMS, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_18,
                                        "Subproduction18");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.COMMA, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.FUNCTION_PARAM, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_19,
                                        "Subproduction19");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.IN_OUT_INOUT, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_20,
                                        "Subproduction20");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.STATEMENT, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_21,
                                        "Subproduction21");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.SWITCH_STATEMENT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.IF_STATEMENT, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_22,
                                        "Subproduction22");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.FOR_STATEMENT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.WHILE_STATEMENT, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_23,
                                        "Subproduction23");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.STATEMENT_SCOPE, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_24,
                                        "Subproduction24");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.ELSE, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.STATEMENT_SCOPE, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_25,
                                        "Subproduction25");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.CASE_STATEMENT, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_26,
                                        "Subproduction26");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.CASE, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.NUMBER, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.DEFAULT, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_27,
                                        "Subproduction27");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.STATEMENT_SCOPE, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_28,
                                        "Subproduction28");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.EXPRESSION, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_29,
                                        "Subproduction29");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.CONDITION, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_30,
                                        "Subproduction30");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.EXPRESSION, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_31,
                                        "Subproduction31");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.PRE_DEFINE, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.PRE_IF, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.PRE_ELSEIF, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.PRE_ENDIF, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.PRE_IFDEF, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.PRE_IFNDEF, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.PRE_ERROR, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.PRE_INCLUDE, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.PRE_LINE, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.PRE_PRAGMA, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_32,
                                        "Subproduction32");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.STORAGE_CLASS, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_33,
                                        "Subproduction33");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.TYPE_MODIFIER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_34,
                                        "Subproduction34");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.OPEN_COLCHETES, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.NUMBER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.CLOSE_COLCHETES, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_35,
                                        "Subproduction35");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.SEMANTICAL_PARAMETERS, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.REGISTER_FUNC, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.PACKOFFSET_FUNC, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_36,
                                        "Subproduction36");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.DOUBLE_DOT, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_35, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_37,
                                        "Subproduction37");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.ASSIGNMENT_OPERATOR, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.INITIALIZERS, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_38,
                                        "Subproduction38");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.RETURN, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_39,
                                        "Subproduction39");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.OPEN_COLCHETES, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.NUMBER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.CLOSE_COLCHETES, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_40,
                                        "Subproduction40");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.OPEN_COLCHETES, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.NUMBER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.CLOSE_COLCHETES, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_41,
                                        "Subproduction41");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.EXPRESSION_TAIL, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_42,
                                        "Subproduction42");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.ADD, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.SUB, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_43,
                                        "Subproduction43");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.MULT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.DIV, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.MOD, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_44,
                                        "Subproduction44");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.PREFIX_POSTFIX_OPERATORS, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_45,
                                        "Subproduction45");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.PREFIX_POSTFIX_OPERATORS, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.PART_OF_VARIABLE_ASSIGNMENT, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_46,
                                        "Subproduction46");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.TYPE_MODIFIER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_47,
                                        "Subproduction47");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.STORAGE_CLASS, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 1, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_46, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.TYPE_MODIFIER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_48,
                                        "Subproduction48");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.PREFIX_POSTFIX_OPERATORS, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.PART_OF_CONSTRUCTOR_CALL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.PART_OF_VARIABLE_DECLARATION, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.PART_OF_PROPERTY_SPECIFICATION, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.PART_OF_VARIABLE_ASSIGNMENT, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_49,
                                        "Subproduction49");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.VARIABLE_ASSIGNMENT, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_50,
                                        "Subproduction50");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.COMMA, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.EXPRESSION, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_51,
                                        "Subproduction51");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.EXPRESSION, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_50, 0, -1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_52,
                                        "Subproduction52");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.OPEN_COLCHETES, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.NUMBER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.CLOSE_COLCHETES, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_53,
                                        "Subproduction53");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.OPEN_COLCHETES, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.NUMBER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.CLOSE_COLCHETES, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_54,
                                        "Subproduction54");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.COMMA, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.IDENTIFIER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_53, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_55,
                                        "Subproduction55");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.SEMANTICAL_PARAMETERS, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.REGISTER_FUNC, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.PACKOFFSET_FUNC, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_56,
                                        "Subproduction56");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.DOUBLE_DOT, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_55, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_57,
                                        "Subproduction57");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.ASSIGNMENT_OPERATOR, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddProduction((int) HlslConstants.INITIALIZERS, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_58,
                                        "Subproduction58");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.OPEN_COLCHETES, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.NUMBER, 1, 1);
        alt.AddProduction((int) HlslConstants.WS, 0, 1);
        alt.AddToken((int) HlslConstants.CLOSE_COLCHETES, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_59,
                                        "Subproduction59");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.VECTOR_EXP_TYPE, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.VECTOR_EXP_TYPE_NUMBER, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) HlslConstants.VECTOR_EXP_NUMBER, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_60,
                                        "Subproduction60");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.DOT, 1, 1);
        alt.AddToken((int) HlslConstants.XYZW, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.DOT, 1, 1);
        alt.AddToken((int) HlslConstants.RGBA, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.DOT, 1, 1);
        alt.AddToken((int) HlslConstants.IDENTIFIER, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_61,
                                        "Subproduction61");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.STOP, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.CONTINUE, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.BREAK, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.DISCARD, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_62,
                                        "Subproduction62");
        pattern.SetSyntetic(true);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.WHITESPACE, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.TAB, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.NEWLINE, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.NEWLINE2, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.NEWLINE3, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.FORMFEED, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.COMMENT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) HlslConstants.COMMENTCPP, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);
    }
}
