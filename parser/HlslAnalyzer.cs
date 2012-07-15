/*
 * HlslAnalyzer.cs
 * 
 * THIS FILE HAS BEEN GENERATED AUTOMATICALLY. DO NOT EDIT!
 * 
 * See GPL v2.
 * 
 * Copyright (c) 2007 Vitor F. Pamplona. All rights reserved.
 */

using PerCederberg.Grammatica.Parser;

/**
 * <remarks>A class providing callback methods for the
 * parser.</remarks>
 */
internal abstract class HlslAnalyzer : Analyzer {

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public override void Enter(Node node) {
        switch (node.GetId()) {
        case (int) HlslConstants.ADD:
            EnterAdd((Token) node);
            break;
        case (int) HlslConstants.SUB:
            EnterSub((Token) node);
            break;
        case (int) HlslConstants.MULT:
            EnterMult((Token) node);
            break;
        case (int) HlslConstants.DIV:
            EnterDiv((Token) node);
            break;
        case (int) HlslConstants.MOD:
            EnterMod((Token) node);
            break;
        case (int) HlslConstants.ADD_ADD:
            EnterAddAdd((Token) node);
            break;
        case (int) HlslConstants.SUB_SUB:
            EnterSubSub((Token) node);
            break;
        case (int) HlslConstants.EQUAL:
            EnterEqual((Token) node);
            break;
        case (int) HlslConstants.ADD_EQUAL:
            EnterAddEqual((Token) node);
            break;
        case (int) HlslConstants.SUB_EQUAL:
            EnterSubEqual((Token) node);
            break;
        case (int) HlslConstants.MULT_EQUAL:
            EnterMultEqual((Token) node);
            break;
        case (int) HlslConstants.DIV_EQUAL:
            EnterDivEqual((Token) node);
            break;
        case (int) HlslConstants.MOD_EQUAL:
            EnterModEqual((Token) node);
            break;
        case (int) HlslConstants.MINOR_MINOR_EQUAL:
            EnterMinorMinorEqual((Token) node);
            break;
        case (int) HlslConstants.MAJOR_MAJOR_EQUAL:
            EnterMajorMajorEqual((Token) node);
            break;
        case (int) HlslConstants.AND_EQUAL:
            EnterAndEqual((Token) node);
            break;
        case (int) HlslConstants.OR_EQUAL:
            EnterOrEqual((Token) node);
            break;
        case (int) HlslConstants.POT_EQUAL:
            EnterPotEqual((Token) node);
            break;
        case (int) HlslConstants.EQUAL_EQUAL:
            EnterEqualEqual((Token) node);
            break;
        case (int) HlslConstants.DIFF:
            EnterDiff((Token) node);
            break;
        case (int) HlslConstants.LESS_EQUAL:
            EnterLessEqual((Token) node);
            break;
        case (int) HlslConstants.MORE_EQUAL:
            EnterMoreEqual((Token) node);
            break;
        case (int) HlslConstants.TIL:
            EnterTil((Token) node);
            break;
        case (int) HlslConstants.MINOR_MINOR:
            EnterMinorMinor((Token) node);
            break;
        case (int) HlslConstants.MAJOR_MAJOR:
            EnterMajorMajor((Token) node);
            break;
        case (int) HlslConstants.AND:
            EnterAnd((Token) node);
            break;
        case (int) HlslConstants.OR:
            EnterOr((Token) node);
            break;
        case (int) HlslConstants.POT:
            EnterPot((Token) node);
            break;
        case (int) HlslConstants.AND_AND:
            EnterAndAnd((Token) node);
            break;
        case (int) HlslConstants.OR_OR:
            EnterOrOr((Token) node);
            break;
        case (int) HlslConstants.NOT:
            EnterNot((Token) node);
            break;
        case (int) HlslConstants.MAJOR:
            EnterMajor((Token) node);
            break;
        case (int) HlslConstants.MINOR:
            EnterMinor((Token) node);
            break;
        case (int) HlslConstants.OPEN_PAREN:
            EnterOpenParen((Token) node);
            break;
        case (int) HlslConstants.CLOSE_PAREN:
            EnterCloseParen((Token) node);
            break;
        case (int) HlslConstants.OPEN_BREACKET:
            EnterOpenBreacket((Token) node);
            break;
        case (int) HlslConstants.CLOSE_BREACKET:
            EnterCloseBreacket((Token) node);
            break;
        case (int) HlslConstants.OPEN_COLCHETES:
            EnterOpenColchetes((Token) node);
            break;
        case (int) HlslConstants.CLOSE_COLCHETES:
            EnterCloseColchetes((Token) node);
            break;
        case (int) HlslConstants.DOUBLE_DOT:
            EnterDoubleDot((Token) node);
            break;
        case (int) HlslConstants.DOT_COMMA:
            EnterDotComma((Token) node);
            break;
        case (int) HlslConstants.COMMA:
            EnterComma((Token) node);
            break;
        case (int) HlslConstants.DOT:
            EnterDot((Token) node);
            break;
        case (int) HlslConstants.NUMBER:
            EnterNumber((Token) node);
            break;
        case (int) HlslConstants.NUMBER_2_4:
            EnterNumber24((Token) node);
            break;
        case (int) HlslConstants.NUMBER_1_4:
            EnterNumber14((Token) node);
            break;
        case (int) HlslConstants.WHITESPACE:
            EnterWhitespace((Token) node);
            break;
        case (int) HlslConstants.TAB:
            EnterTab((Token) node);
            break;
        case (int) HlslConstants.NEWLINE:
            EnterNewline((Token) node);
            break;
        case (int) HlslConstants.NEWLINE2:
            EnterNewline2((Token) node);
            break;
        case (int) HlslConstants.NEWLINE3:
            EnterNewline3((Token) node);
            break;
        case (int) HlslConstants.FORMFEED:
            EnterFormfeed((Token) node);
            break;
        case (int) HlslConstants.STRING:
            EnterString((Token) node);
            break;
        case (int) HlslConstants.RGBA:
            EnterRgba((Token) node);
            break;
        case (int) HlslConstants.XYZW:
            EnterXyzw((Token) node);
            break;
        case (int) HlslConstants.ASM:
            EnterAsm((Token) node);
            break;
        case (int) HlslConstants.ASM_FRAGMENT:
            EnterAsmFragment((Token) node);
            break;
        case (int) HlslConstants.BLENDSTATE:
            EnterBlendstate((Token) node);
            break;
        case (int) HlslConstants.COLUMN_MAJOR:
            EnterColumnMajor((Token) node);
            break;
        case (int) HlslConstants.COMPILE_FRAGMENT:
            EnterCompileFragment((Token) node);
            break;
        case (int) HlslConstants.DISCARD:
            EnterDiscard((Token) node);
            break;
        case (int) HlslConstants.DECL:
            EnterDecl((Token) node);
            break;
        case (int) HlslConstants.DO:
            EnterDo((Token) node);
            break;
        case (int) HlslConstants.ELSE:
            EnterElse((Token) node);
            break;
        case (int) HlslConstants.EXTERN:
            EnterExtern((Token) node);
            break;
        case (int) HlslConstants.END:
            EnterEnd((Token) node);
            break;
        case (int) HlslConstants.FALSE:
            EnterFalse((Token) node);
            break;
        case (int) HlslConstants.FOR:
            EnterFor((Token) node);
            break;
        case (int) HlslConstants.IF:
            EnterIf((Token) node);
            break;
        case (int) HlslConstants.IN:
            EnterIn((Token) node);
            break;
        case (int) HlslConstants.INLINE:
            EnterInline((Token) node);
            break;
        case (int) HlslConstants.INOUT:
            EnterInout((Token) node);
            break;
        case (int) HlslConstants.MATRIX:
            EnterMatrix((Token) node);
            break;
        case (int) HlslConstants.OUT:
            EnterOut((Token) node);
            break;
        case (int) HlslConstants.PACKOFFSET:
            EnterPackoffset((Token) node);
            break;
        case (int) HlslConstants.PASS:
            EnterPass((Token) node);
            break;
        case (int) HlslConstants.PIXELFRAGMENT:
            EnterPixelfragment((Token) node);
            break;
        case (int) HlslConstants.REGISTER:
            EnterRegister((Token) node);
            break;
        case (int) HlslConstants.RETURN:
            EnterReturn((Token) node);
            break;
        case (int) HlslConstants.ROW_MAJOR:
            EnterRowMajor((Token) node);
            break;
        case (int) HlslConstants.SAMPLER:
            EnterSampler((Token) node);
            break;
        case (int) HlslConstants.SAMPLER1D:
            EnterSampler1d((Token) node);
            break;
        case (int) HlslConstants.SAMPLER2D:
            EnterSampler2d((Token) node);
            break;
        case (int) HlslConstants.SAMPLER3D:
            EnterSampler3d((Token) node);
            break;
        case (int) HlslConstants.SAMPLERCUBE:
            EnterSamplercube((Token) node);
            break;
        case (int) HlslConstants.SAMPLER_STATE:
            EnterSamplerState((Token) node);
            break;
        case (int) HlslConstants.SHARED:
            EnterShared((Token) node);
            break;
        case (int) HlslConstants.STATEBLOCK:
            EnterStateblock((Token) node);
            break;
        case (int) HlslConstants.STATEBLOCK_STATE:
            EnterStateblockState((Token) node);
            break;
        case (int) HlslConstants.STATIC:
            EnterStatic((Token) node);
            break;
        case (int) HlslConstants.STRING_TYPE:
            EnterStringType((Token) node);
            break;
        case (int) HlslConstants.STRUCT:
            EnterStruct((Token) node);
            break;
        case (int) HlslConstants.TECHNIQUE:
            EnterTechnique((Token) node);
            break;
        case (int) HlslConstants.TEXTURE:
            EnterTexture((Token) node);
            break;
        case (int) HlslConstants.TEXTURE1D:
            EnterTexture1d((Token) node);
            break;
        case (int) HlslConstants.TEXTURE2D:
            EnterTexture2d((Token) node);
            break;
        case (int) HlslConstants.TEXTURE3D:
            EnterTexture3d((Token) node);
            break;
        case (int) HlslConstants.TEXTURECUBE:
            EnterTexturecube((Token) node);
            break;
        case (int) HlslConstants.TRUE:
            EnterTrue((Token) node);
            break;
        case (int) HlslConstants.TYPEDEF:
            EnterTypedef((Token) node);
            break;
        case (int) HlslConstants.UNIFORM:
            EnterUniform((Token) node);
            break;
        case (int) HlslConstants.VARYING:
            EnterVarying((Token) node);
            break;
        case (int) HlslConstants.VECTOR:
            EnterVector((Token) node);
            break;
        case (int) HlslConstants.VERTEXFRAGMENT:
            EnterVertexfragment((Token) node);
            break;
        case (int) HlslConstants.VOID:
            EnterVoid((Token) node);
            break;
        case (int) HlslConstants.VOLATILE:
            EnterVolatile((Token) node);
            break;
        case (int) HlslConstants.WHILE:
            EnterWhile((Token) node);
            break;
        case (int) HlslConstants.STOP:
            EnterStop((Token) node);
            break;
        case (int) HlslConstants.FLATTEN:
            EnterFlatten((Token) node);
            break;
        case (int) HlslConstants.BRANCH:
            EnterBranch((Token) node);
            break;
        case (int) HlslConstants.UNROLL:
            EnterUnroll((Token) node);
            break;
        case (int) HlslConstants.LOOP:
            EnterLoop((Token) node);
            break;
        case (int) HlslConstants.FORCECASE:
            EnterForcecase((Token) node);
            break;
        case (int) HlslConstants.CALL:
            EnterCall((Token) node);
            break;
        case (int) HlslConstants.AUTO:
            EnterAuto((Token) node);
            break;
        case (int) HlslConstants.BREAK:
            EnterBreak((Token) node);
            break;
        case (int) HlslConstants.COMPILE:
            EnterCompile((Token) node);
            break;
        case (int) HlslConstants.CONST:
            EnterConst((Token) node);
            break;
        case (int) HlslConstants.CHAR:
            EnterChar((Token) node);
            break;
        case (int) HlslConstants.CLASS:
            EnterClass((Token) node);
            break;
        case (int) HlslConstants.CASE:
            EnterCase((Token) node);
            break;
        case (int) HlslConstants.CATCH:
            EnterCatch((Token) node);
            break;
        case (int) HlslConstants.DEFAULT:
            EnterDefault((Token) node);
            break;
        case (int) HlslConstants.DELETE:
            EnterDelete((Token) node);
            break;
        case (int) HlslConstants.CONST_CAST:
            EnterConstCast((Token) node);
            break;
        case (int) HlslConstants.CONTINUE:
            EnterContinue((Token) node);
            break;
        case (int) HlslConstants.EXPLICIT:
            EnterExplicit((Token) node);
            break;
        case (int) HlslConstants.FRIEND:
            EnterFriend((Token) node);
            break;
        case (int) HlslConstants.DYNAMIC_CAST:
            EnterDynamicCast((Token) node);
            break;
        case (int) HlslConstants.ENUM:
            EnterEnum((Token) node);
            break;
        case (int) HlslConstants.MUTABLE:
            EnterMutable((Token) node);
            break;
        case (int) HlslConstants.NAMESPACE:
            EnterNamespace((Token) node);
            break;
        case (int) HlslConstants.GOTO:
            EnterGoto((Token) node);
            break;
        case (int) HlslConstants.LONG:
            EnterLong((Token) node);
            break;
        case (int) HlslConstants.PRIVATE:
            EnterPrivate((Token) node);
            break;
        case (int) HlslConstants.PROTECTED:
            EnterProtected((Token) node);
            break;
        case (int) HlslConstants.NEW:
            EnterNew((Token) node);
            break;
        case (int) HlslConstants.OPERATOR:
            EnterOperator((Token) node);
            break;
        case (int) HlslConstants.PUBLIC:
            EnterPublic((Token) node);
            break;
        case (int) HlslConstants.REINTERPRET_CAST:
            EnterReinterpretCast((Token) node);
            break;
        case (int) HlslConstants.SHORT:
            EnterShort((Token) node);
            break;
        case (int) HlslConstants.STATIC_CAST:
            EnterStaticCast((Token) node);
            break;
        case (int) HlslConstants.SIGNED:
            EnterSigned((Token) node);
            break;
        case (int) HlslConstants.SIZEOF:
            EnterSizeof((Token) node);
            break;
        case (int) HlslConstants.SWITCH:
            EnterSwitch((Token) node);
            break;
        case (int) HlslConstants.TEMPLATE:
            EnterTemplate((Token) node);
            break;
        case (int) HlslConstants.THIS:
            EnterThis((Token) node);
            break;
        case (int) HlslConstants.THROW:
            EnterThrow((Token) node);
            break;
        case (int) HlslConstants.TRY:
            EnterTry((Token) node);
            break;
        case (int) HlslConstants.TYPENAME:
            EnterTypename((Token) node);
            break;
        case (int) HlslConstants.UNION:
            EnterUnion((Token) node);
            break;
        case (int) HlslConstants.UNSIGNED:
            EnterUnsigned((Token) node);
            break;
        case (int) HlslConstants.USING:
            EnterUsing((Token) node);
            break;
        case (int) HlslConstants.VIRTUAL:
            EnterVirtual((Token) node);
            break;
        case (int) HlslConstants.BINORMAL:
            EnterBinormal((Token) node);
            break;
        case (int) HlslConstants.BLENDINDICES:
            EnterBlendindices((Token) node);
            break;
        case (int) HlslConstants.BLENDWEIGHT:
            EnterBlendweight((Token) node);
            break;
        case (int) HlslConstants.NORMAL:
            EnterNormal((Token) node);
            break;
        case (int) HlslConstants.POSITIONT:
            EnterPositiont((Token) node);
            break;
        case (int) HlslConstants.VFACE:
            EnterVface((Token) node);
            break;
        case (int) HlslConstants.VPOS:
            EnterVpos((Token) node);
            break;
        case (int) HlslConstants.FOG:
            EnterFog((Token) node);
            break;
        case (int) HlslConstants.TESSFACTOR:
            EnterTessfactor((Token) node);
            break;
        case (int) HlslConstants.DEPTH:
            EnterDepth((Token) node);
            break;
        case (int) HlslConstants.POSITION:
            EnterPosition((Token) node);
            break;
        case (int) HlslConstants.TEXCOORD:
            EnterTexcoord((Token) node);
            break;
        case (int) HlslConstants.TEXUNIT:
            EnterTexunit((Token) node);
            break;
        case (int) HlslConstants.COLOR:
            EnterColor((Token) node);
            break;
        case (int) HlslConstants.TANGENT:
            EnterTangent((Token) node);
            break;
        case (int) HlslConstants.PSIZE:
            EnterPsize((Token) node);
            break;
        case (int) HlslConstants.WORLD:
            EnterWorld((Token) node);
            break;
        case (int) HlslConstants.VIEW:
            EnterView((Token) node);
            break;
        case (int) HlslConstants.PROJ:
            EnterProj((Token) node);
            break;
        case (int) HlslConstants.WORLDVIEW:
            EnterWorldview((Token) node);
            break;
        case (int) HlslConstants.WORLDPROJ:
            EnterWorldproj((Token) node);
            break;
        case (int) HlslConstants.VIEWPROJ:
            EnterViewproj((Token) node);
            break;
        case (int) HlslConstants.WORLDVIEWPROJ:
            EnterWorldviewproj((Token) node);
            break;
        case (int) HlslConstants.FLOAT:
            EnterFloat((Token) node);
            break;
        case (int) HlslConstants.INT:
            EnterInt((Token) node);
            break;
        case (int) HlslConstants.HALF:
            EnterHalf((Token) node);
            break;
        case (int) HlslConstants.DOUBLE:
            EnterDouble((Token) node);
            break;
        case (int) HlslConstants.BOOL:
            EnterBool((Token) node);
            break;
        case (int) HlslConstants.BASIC_FLOAT:
            EnterBasicFloat((Token) node);
            break;
        case (int) HlslConstants.BASIC_INT:
            EnterBasicInt((Token) node);
            break;
        case (int) HlslConstants.BASIC_HALF:
            EnterBasicHalf((Token) node);
            break;
        case (int) HlslConstants.BASIC_BOOL:
            EnterBasicBool((Token) node);
            break;
        case (int) HlslConstants.BASIC_DOUBLE:
            EnterBasicDouble((Token) node);
            break;
        case (int) HlslConstants.BASIC_UINT:
            EnterBasicUint((Token) node);
            break;
        case (int) HlslConstants.PRE_DEFINE:
            EnterPreDefine((Token) node);
            break;
        case (int) HlslConstants.PRE_IF:
            EnterPreIf((Token) node);
            break;
        case (int) HlslConstants.PRE_ELSEIF:
            EnterPreElseif((Token) node);
            break;
        case (int) HlslConstants.PRE_ENDIF:
            EnterPreEndif((Token) node);
            break;
        case (int) HlslConstants.PRE_IFDEF:
            EnterPreIfdef((Token) node);
            break;
        case (int) HlslConstants.PRE_IFNDEF:
            EnterPreIfndef((Token) node);
            break;
        case (int) HlslConstants.PRE_ERROR:
            EnterPreError((Token) node);
            break;
        case (int) HlslConstants.PRE_INCLUDE:
            EnterPreInclude((Token) node);
            break;
        case (int) HlslConstants.PRE_LINE:
            EnterPreLine((Token) node);
            break;
        case (int) HlslConstants.PRE_PRAGMA:
            EnterPrePragma((Token) node);
            break;
        case (int) HlslConstants.NOINTERPOLATION:
            EnterNointerpolation((Token) node);
            break;
        case (int) HlslConstants.IDENTIFIER:
            EnterIdentifier((Token) node);
            break;
        case (int) HlslConstants.QUOTED_STRING:
            EnterQuotedString((Token) node);
            break;
        case (int) HlslConstants.COMMENT:
            EnterComment((Token) node);
            break;
        case (int) HlslConstants.COMMENTCPP:
            EnterCommentcpp((Token) node);
            break;
        case (int) HlslConstants.FILE:
            EnterFile((Production) node);
            break;
        case (int) HlslConstants.TECHNIQUE_DECLARATION:
            EnterTechniqueDeclaration((Production) node);
            break;
        case (int) HlslConstants.PASS_DECLARATION:
            EnterPassDeclaration((Production) node);
            break;
        case (int) HlslConstants.PASS_INSTRUCTIONS:
            EnterPassInstructions((Production) node);
            break;
        case (int) HlslConstants.STRUCT_DECLARATION:
            EnterStructDeclaration((Production) node);
            break;
        case (int) HlslConstants.FUNCTION_OR_VARIABLE_DECLARATION:
            EnterFunctionOrVariableDeclaration((Production) node);
            break;
        case (int) HlslConstants.VARIABLE_DECLARATION_PART:
            EnterVariableDeclarationPart((Production) node);
            break;
        case (int) HlslConstants.FUNCTION_PART:
            EnterFunctionPart((Production) node);
            break;
        case (int) HlslConstants.PARAMETERS:
            EnterParameters((Production) node);
            break;
        case (int) HlslConstants.LIST_OF_PARAMS:
            EnterListOfParams((Production) node);
            break;
        case (int) HlslConstants.FUNCTION_PARAM:
            EnterFunctionParam((Production) node);
            break;
        case (int) HlslConstants.FUNCTION_BODY:
            EnterFunctionBody((Production) node);
            break;
        case (int) HlslConstants.STATEMENT:
            EnterStatement((Production) node);
            break;
        case (int) HlslConstants.IF_STATEMENT:
            EnterIfStatement((Production) node);
            break;
        case (int) HlslConstants.SWITCH_STATEMENT:
            EnterSwitchStatement((Production) node);
            break;
        case (int) HlslConstants.CASE_STATEMENT:
            EnterCaseStatement((Production) node);
            break;
        case (int) HlslConstants.WHILE_STATEMENT:
            EnterWhileStatement((Production) node);
            break;
        case (int) HlslConstants.DO_STATEMENT:
            EnterDoStatement((Production) node);
            break;
        case (int) HlslConstants.FOR_STATEMENT:
            EnterForStatement((Production) node);
            break;
        case (int) HlslConstants.PRE_PROCESSOR_DIRECTIVES:
            EnterPreProcessorDirectives((Production) node);
            break;
        case (int) HlslConstants.STATEMENT_SCOPE:
            EnterStatementScope((Production) node);
            break;
        case (int) HlslConstants.VARIABLE_DECLARATION:
            EnterVariableDeclaration((Production) node);
            break;
        case (int) HlslConstants.RETURN_STATEMENT:
            EnterReturnStatement((Production) node);
            break;
        case (int) HlslConstants.VARIABLE_ASSIGNMENT:
            EnterVariableAssignment((Production) node);
            break;
        case (int) HlslConstants.VARIABLE_ASSIGNMENT_WITHOUT_DOT_COMMA:
            EnterVariableAssignmentWithoutDotComma((Production) node);
            break;
        case (int) HlslConstants.CONDITION:
            EnterCondition((Production) node);
            break;
        case (int) HlslConstants.INITIALIZERS:
            EnterInitializers((Production) node);
            break;
        case (int) HlslConstants.EXPRESSION:
            EnterExpression((Production) node);
            break;
        case (int) HlslConstants.EXPRESSION_TAIL:
            EnterExpressionTail((Production) node);
            break;
        case (int) HlslConstants.TERM:
            EnterTerm((Production) node);
            break;
        case (int) HlslConstants.TERM_TAIL:
            EnterTermTail((Production) node);
            break;
        case (int) HlslConstants.FACTOR:
            EnterFactor((Production) node);
            break;
        case (int) HlslConstants.ATOM:
            EnterAtom((Production) node);
            break;
        case (int) HlslConstants.FUNCTION_CONSTRUCTOR_CALL_OR_VARIABLE_DECLARATION:
            EnterFunctionConstructorCallOrVariableDeclaration((Production) node);
            break;
        case (int) HlslConstants.PART_OF_PROPERTY_SPECIFICATION:
            EnterPartOfPropertySpecification((Production) node);
            break;
        case (int) HlslConstants.PART_OF_CONSTRUCTOR_CALL:
            EnterPartOfConstructorCall((Production) node);
            break;
        case (int) HlslConstants.PART_OF_VARIABLE_DECLARATION:
            EnterPartOfVariableDeclaration((Production) node);
            break;
        case (int) HlslConstants.PART_OF_VARIABLE_ASSIGNMENT:
            EnterPartOfVariableAssignment((Production) node);
            break;
        case (int) HlslConstants.STORAGE_CLASS:
            EnterStorageClass((Production) node);
            break;
        case (int) HlslConstants.TYPE_MODIFIER:
            EnterTypeModifier((Production) node);
            break;
        case (int) HlslConstants.TYPE:
            EnterType((Production) node);
            break;
        case (int) HlslConstants.VECTOR_EXP:
            EnterVectorExp((Production) node);
            break;
        case (int) HlslConstants.VECTOR_EXP_TYPE:
            EnterVectorExpType((Production) node);
            break;
        case (int) HlslConstants.VECTOR_EXP_NUMBER:
            EnterVectorExpNumber((Production) node);
            break;
        case (int) HlslConstants.VECTOR_EXP_TYPE_NUMBER:
            EnterVectorExpTypeNumber((Production) node);
            break;
        case (int) HlslConstants.MATRIX_EXP:
            EnterMatrixExp((Production) node);
            break;
        case (int) HlslConstants.BASIC_TYPE:
            EnterBasicType((Production) node);
            break;
        case (int) HlslConstants.SEMANTICAL_PARAMETERS:
            EnterSemanticalParameters((Production) node);
            break;
        case (int) HlslConstants.INPUT_SEMANTICAL_PARAMETERS:
            EnterInputSemanticalParameters((Production) node);
            break;
        case (int) HlslConstants.OUTPUT_SEMANTICAL_PARAMETERS:
            EnterOutputSemanticalParameters((Production) node);
            break;
        case (int) HlslConstants.IN_OUT_SEMANTICAL_PARAMETERS:
            EnterInOutSemanticalParameters((Production) node);
            break;
        case (int) HlslConstants.ASSIGNMENT_OPERATOR:
            EnterAssignmentOperator((Production) node);
            break;
        case (int) HlslConstants.PREFIX_POSTFIX_OPERATORS:
            EnterPrefixPostfixOperators((Production) node);
            break;
        case (int) HlslConstants.COMPARISON_OPERATORS:
            EnterComparisonOperators((Production) node);
            break;
        case (int) HlslConstants.BOOLEAN_OPERATORS:
            EnterBooleanOperators((Production) node);
            break;
        case (int) HlslConstants.IN_OUT_INOUT:
            EnterInOutInout((Production) node);
            break;
        case (int) HlslConstants.REGISTER_FUNC:
            EnterRegisterFunc((Production) node);
            break;
        case (int) HlslConstants.PACKOFFSET_FUNC:
            EnterPackoffsetFunc((Production) node);
            break;
        case (int) HlslConstants.IDENTIFIER_COMPOSED:
            EnterIdentifierComposed((Production) node);
            break;
        case (int) HlslConstants.COMPOSE_IDENTIFIER:
            EnterComposeIdentifier((Production) node);
            break;
        case (int) HlslConstants.IDENTIFIER_COMPOSED_REQUIRED:
            EnterIdentifierComposedRequired((Production) node);
            break;
        case (int) HlslConstants.FLOW_CONTROL_WORDS:
            EnterFlowControlWords((Production) node);
            break;
        case (int) HlslConstants.WHILE_FOR_ATTRIBUTES:
            EnterWhileForAttributes((Production) node);
            break;
        case (int) HlslConstants.IF_SWITCH_ATTRIBUTES:
            EnterIfSwitchAttributes((Production) node);
            break;
        case (int) HlslConstants.SEMANTIC_MATRIXES:
            EnterSemanticMatrixes((Production) node);
            break;
        case (int) HlslConstants.WS:
            EnterWs((Production) node);
            break;
        }
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public override Node Exit(Node node) {
        switch (node.GetId()) {
        case (int) HlslConstants.ADD:
            return ExitAdd((Token) node);
        case (int) HlslConstants.SUB:
            return ExitSub((Token) node);
        case (int) HlslConstants.MULT:
            return ExitMult((Token) node);
        case (int) HlslConstants.DIV:
            return ExitDiv((Token) node);
        case (int) HlslConstants.MOD:
            return ExitMod((Token) node);
        case (int) HlslConstants.ADD_ADD:
            return ExitAddAdd((Token) node);
        case (int) HlslConstants.SUB_SUB:
            return ExitSubSub((Token) node);
        case (int) HlslConstants.EQUAL:
            return ExitEqual((Token) node);
        case (int) HlslConstants.ADD_EQUAL:
            return ExitAddEqual((Token) node);
        case (int) HlslConstants.SUB_EQUAL:
            return ExitSubEqual((Token) node);
        case (int) HlslConstants.MULT_EQUAL:
            return ExitMultEqual((Token) node);
        case (int) HlslConstants.DIV_EQUAL:
            return ExitDivEqual((Token) node);
        case (int) HlslConstants.MOD_EQUAL:
            return ExitModEqual((Token) node);
        case (int) HlslConstants.MINOR_MINOR_EQUAL:
            return ExitMinorMinorEqual((Token) node);
        case (int) HlslConstants.MAJOR_MAJOR_EQUAL:
            return ExitMajorMajorEqual((Token) node);
        case (int) HlslConstants.AND_EQUAL:
            return ExitAndEqual((Token) node);
        case (int) HlslConstants.OR_EQUAL:
            return ExitOrEqual((Token) node);
        case (int) HlslConstants.POT_EQUAL:
            return ExitPotEqual((Token) node);
        case (int) HlslConstants.EQUAL_EQUAL:
            return ExitEqualEqual((Token) node);
        case (int) HlslConstants.DIFF:
            return ExitDiff((Token) node);
        case (int) HlslConstants.LESS_EQUAL:
            return ExitLessEqual((Token) node);
        case (int) HlslConstants.MORE_EQUAL:
            return ExitMoreEqual((Token) node);
        case (int) HlslConstants.TIL:
            return ExitTil((Token) node);
        case (int) HlslConstants.MINOR_MINOR:
            return ExitMinorMinor((Token) node);
        case (int) HlslConstants.MAJOR_MAJOR:
            return ExitMajorMajor((Token) node);
        case (int) HlslConstants.AND:
            return ExitAnd((Token) node);
        case (int) HlslConstants.OR:
            return ExitOr((Token) node);
        case (int) HlslConstants.POT:
            return ExitPot((Token) node);
        case (int) HlslConstants.AND_AND:
            return ExitAndAnd((Token) node);
        case (int) HlslConstants.OR_OR:
            return ExitOrOr((Token) node);
        case (int) HlslConstants.NOT:
            return ExitNot((Token) node);
        case (int) HlslConstants.MAJOR:
            return ExitMajor((Token) node);
        case (int) HlslConstants.MINOR:
            return ExitMinor((Token) node);
        case (int) HlslConstants.OPEN_PAREN:
            return ExitOpenParen((Token) node);
        case (int) HlslConstants.CLOSE_PAREN:
            return ExitCloseParen((Token) node);
        case (int) HlslConstants.OPEN_BREACKET:
            return ExitOpenBreacket((Token) node);
        case (int) HlslConstants.CLOSE_BREACKET:
            return ExitCloseBreacket((Token) node);
        case (int) HlslConstants.OPEN_COLCHETES:
            return ExitOpenColchetes((Token) node);
        case (int) HlslConstants.CLOSE_COLCHETES:
            return ExitCloseColchetes((Token) node);
        case (int) HlslConstants.DOUBLE_DOT:
            return ExitDoubleDot((Token) node);
        case (int) HlslConstants.DOT_COMMA:
            return ExitDotComma((Token) node);
        case (int) HlslConstants.COMMA:
            return ExitComma((Token) node);
        case (int) HlslConstants.DOT:
            return ExitDot((Token) node);
        case (int) HlslConstants.NUMBER:
            return ExitNumber((Token) node);
        case (int) HlslConstants.NUMBER_2_4:
            return ExitNumber24((Token) node);
        case (int) HlslConstants.NUMBER_1_4:
            return ExitNumber14((Token) node);
        case (int) HlslConstants.WHITESPACE:
            return ExitWhitespace((Token) node);
        case (int) HlslConstants.TAB:
            return ExitTab((Token) node);
        case (int) HlslConstants.NEWLINE:
            return ExitNewline((Token) node);
        case (int) HlslConstants.NEWLINE2:
            return ExitNewline2((Token) node);
        case (int) HlslConstants.NEWLINE3:
            return ExitNewline3((Token) node);
        case (int) HlslConstants.FORMFEED:
            return ExitFormfeed((Token) node);
        case (int) HlslConstants.STRING:
            return ExitString((Token) node);
        case (int) HlslConstants.RGBA:
            return ExitRgba((Token) node);
        case (int) HlslConstants.XYZW:
            return ExitXyzw((Token) node);
        case (int) HlslConstants.ASM:
            return ExitAsm((Token) node);
        case (int) HlslConstants.ASM_FRAGMENT:
            return ExitAsmFragment((Token) node);
        case (int) HlslConstants.BLENDSTATE:
            return ExitBlendstate((Token) node);
        case (int) HlslConstants.COLUMN_MAJOR:
            return ExitColumnMajor((Token) node);
        case (int) HlslConstants.COMPILE_FRAGMENT:
            return ExitCompileFragment((Token) node);
        case (int) HlslConstants.DISCARD:
            return ExitDiscard((Token) node);
        case (int) HlslConstants.DECL:
            return ExitDecl((Token) node);
        case (int) HlslConstants.DO:
            return ExitDo((Token) node);
        case (int) HlslConstants.ELSE:
            return ExitElse((Token) node);
        case (int) HlslConstants.EXTERN:
            return ExitExtern((Token) node);
        case (int) HlslConstants.END:
            return ExitEnd((Token) node);
        case (int) HlslConstants.FALSE:
            return ExitFalse((Token) node);
        case (int) HlslConstants.FOR:
            return ExitFor((Token) node);
        case (int) HlslConstants.IF:
            return ExitIf((Token) node);
        case (int) HlslConstants.IN:
            return ExitIn((Token) node);
        case (int) HlslConstants.INLINE:
            return ExitInline((Token) node);
        case (int) HlslConstants.INOUT:
            return ExitInout((Token) node);
        case (int) HlslConstants.MATRIX:
            return ExitMatrix((Token) node);
        case (int) HlslConstants.OUT:
            return ExitOut((Token) node);
        case (int) HlslConstants.PACKOFFSET:
            return ExitPackoffset((Token) node);
        case (int) HlslConstants.PASS:
            return ExitPass((Token) node);
        case (int) HlslConstants.PIXELFRAGMENT:
            return ExitPixelfragment((Token) node);
        case (int) HlslConstants.REGISTER:
            return ExitRegister((Token) node);
        case (int) HlslConstants.RETURN:
            return ExitReturn((Token) node);
        case (int) HlslConstants.ROW_MAJOR:
            return ExitRowMajor((Token) node);
        case (int) HlslConstants.SAMPLER:
            return ExitSampler((Token) node);
        case (int) HlslConstants.SAMPLER1D:
            return ExitSampler1d((Token) node);
        case (int) HlslConstants.SAMPLER2D:
            return ExitSampler2d((Token) node);
        case (int) HlslConstants.SAMPLER3D:
            return ExitSampler3d((Token) node);
        case (int) HlslConstants.SAMPLERCUBE:
            return ExitSamplercube((Token) node);
        case (int) HlslConstants.SAMPLER_STATE:
            return ExitSamplerState((Token) node);
        case (int) HlslConstants.SHARED:
            return ExitShared((Token) node);
        case (int) HlslConstants.STATEBLOCK:
            return ExitStateblock((Token) node);
        case (int) HlslConstants.STATEBLOCK_STATE:
            return ExitStateblockState((Token) node);
        case (int) HlslConstants.STATIC:
            return ExitStatic((Token) node);
        case (int) HlslConstants.STRING_TYPE:
            return ExitStringType((Token) node);
        case (int) HlslConstants.STRUCT:
            return ExitStruct((Token) node);
        case (int) HlslConstants.TECHNIQUE:
            return ExitTechnique((Token) node);
        case (int) HlslConstants.TEXTURE:
            return ExitTexture((Token) node);
        case (int) HlslConstants.TEXTURE1D:
            return ExitTexture1d((Token) node);
        case (int) HlslConstants.TEXTURE2D:
            return ExitTexture2d((Token) node);
        case (int) HlslConstants.TEXTURE3D:
            return ExitTexture3d((Token) node);
        case (int) HlslConstants.TEXTURECUBE:
            return ExitTexturecube((Token) node);
        case (int) HlslConstants.TRUE:
            return ExitTrue((Token) node);
        case (int) HlslConstants.TYPEDEF:
            return ExitTypedef((Token) node);
        case (int) HlslConstants.UNIFORM:
            return ExitUniform((Token) node);
        case (int) HlslConstants.VARYING:
            return ExitVarying((Token) node);
        case (int) HlslConstants.VECTOR:
            return ExitVector((Token) node);
        case (int) HlslConstants.VERTEXFRAGMENT:
            return ExitVertexfragment((Token) node);
        case (int) HlslConstants.VOID:
            return ExitVoid((Token) node);
        case (int) HlslConstants.VOLATILE:
            return ExitVolatile((Token) node);
        case (int) HlslConstants.WHILE:
            return ExitWhile((Token) node);
        case (int) HlslConstants.STOP:
            return ExitStop((Token) node);
        case (int) HlslConstants.FLATTEN:
            return ExitFlatten((Token) node);
        case (int) HlslConstants.BRANCH:
            return ExitBranch((Token) node);
        case (int) HlslConstants.UNROLL:
            return ExitUnroll((Token) node);
        case (int) HlslConstants.LOOP:
            return ExitLoop((Token) node);
        case (int) HlslConstants.FORCECASE:
            return ExitForcecase((Token) node);
        case (int) HlslConstants.CALL:
            return ExitCall((Token) node);
        case (int) HlslConstants.AUTO:
            return ExitAuto((Token) node);
        case (int) HlslConstants.BREAK:
            return ExitBreak((Token) node);
        case (int) HlslConstants.COMPILE:
            return ExitCompile((Token) node);
        case (int) HlslConstants.CONST:
            return ExitConst((Token) node);
        case (int) HlslConstants.CHAR:
            return ExitChar((Token) node);
        case (int) HlslConstants.CLASS:
            return ExitClass((Token) node);
        case (int) HlslConstants.CASE:
            return ExitCase((Token) node);
        case (int) HlslConstants.CATCH:
            return ExitCatch((Token) node);
        case (int) HlslConstants.DEFAULT:
            return ExitDefault((Token) node);
        case (int) HlslConstants.DELETE:
            return ExitDelete((Token) node);
        case (int) HlslConstants.CONST_CAST:
            return ExitConstCast((Token) node);
        case (int) HlslConstants.CONTINUE:
            return ExitContinue((Token) node);
        case (int) HlslConstants.EXPLICIT:
            return ExitExplicit((Token) node);
        case (int) HlslConstants.FRIEND:
            return ExitFriend((Token) node);
        case (int) HlslConstants.DYNAMIC_CAST:
            return ExitDynamicCast((Token) node);
        case (int) HlslConstants.ENUM:
            return ExitEnum((Token) node);
        case (int) HlslConstants.MUTABLE:
            return ExitMutable((Token) node);
        case (int) HlslConstants.NAMESPACE:
            return ExitNamespace((Token) node);
        case (int) HlslConstants.GOTO:
            return ExitGoto((Token) node);
        case (int) HlslConstants.LONG:
            return ExitLong((Token) node);
        case (int) HlslConstants.PRIVATE:
            return ExitPrivate((Token) node);
        case (int) HlslConstants.PROTECTED:
            return ExitProtected((Token) node);
        case (int) HlslConstants.NEW:
            return ExitNew((Token) node);
        case (int) HlslConstants.OPERATOR:
            return ExitOperator((Token) node);
        case (int) HlslConstants.PUBLIC:
            return ExitPublic((Token) node);
        case (int) HlslConstants.REINTERPRET_CAST:
            return ExitReinterpretCast((Token) node);
        case (int) HlslConstants.SHORT:
            return ExitShort((Token) node);
        case (int) HlslConstants.STATIC_CAST:
            return ExitStaticCast((Token) node);
        case (int) HlslConstants.SIGNED:
            return ExitSigned((Token) node);
        case (int) HlslConstants.SIZEOF:
            return ExitSizeof((Token) node);
        case (int) HlslConstants.SWITCH:
            return ExitSwitch((Token) node);
        case (int) HlslConstants.TEMPLATE:
            return ExitTemplate((Token) node);
        case (int) HlslConstants.THIS:
            return ExitThis((Token) node);
        case (int) HlslConstants.THROW:
            return ExitThrow((Token) node);
        case (int) HlslConstants.TRY:
            return ExitTry((Token) node);
        case (int) HlslConstants.TYPENAME:
            return ExitTypename((Token) node);
        case (int) HlslConstants.UNION:
            return ExitUnion((Token) node);
        case (int) HlslConstants.UNSIGNED:
            return ExitUnsigned((Token) node);
        case (int) HlslConstants.USING:
            return ExitUsing((Token) node);
        case (int) HlslConstants.VIRTUAL:
            return ExitVirtual((Token) node);
        case (int) HlslConstants.BINORMAL:
            return ExitBinormal((Token) node);
        case (int) HlslConstants.BLENDINDICES:
            return ExitBlendindices((Token) node);
        case (int) HlslConstants.BLENDWEIGHT:
            return ExitBlendweight((Token) node);
        case (int) HlslConstants.NORMAL:
            return ExitNormal((Token) node);
        case (int) HlslConstants.POSITIONT:
            return ExitPositiont((Token) node);
        case (int) HlslConstants.VFACE:
            return ExitVface((Token) node);
        case (int) HlslConstants.VPOS:
            return ExitVpos((Token) node);
        case (int) HlslConstants.FOG:
            return ExitFog((Token) node);
        case (int) HlslConstants.TESSFACTOR:
            return ExitTessfactor((Token) node);
        case (int) HlslConstants.DEPTH:
            return ExitDepth((Token) node);
        case (int) HlslConstants.POSITION:
            return ExitPosition((Token) node);
        case (int) HlslConstants.TEXCOORD:
            return ExitTexcoord((Token) node);
        case (int) HlslConstants.TEXUNIT:
            return ExitTexunit((Token) node);
        case (int) HlslConstants.COLOR:
            return ExitColor((Token) node);
        case (int) HlslConstants.TANGENT:
            return ExitTangent((Token) node);
        case (int) HlslConstants.PSIZE:
            return ExitPsize((Token) node);
        case (int) HlslConstants.WORLD:
            return ExitWorld((Token) node);
        case (int) HlslConstants.VIEW:
            return ExitView((Token) node);
        case (int) HlslConstants.PROJ:
            return ExitProj((Token) node);
        case (int) HlslConstants.WORLDVIEW:
            return ExitWorldview((Token) node);
        case (int) HlslConstants.WORLDPROJ:
            return ExitWorldproj((Token) node);
        case (int) HlslConstants.VIEWPROJ:
            return ExitViewproj((Token) node);
        case (int) HlslConstants.WORLDVIEWPROJ:
            return ExitWorldviewproj((Token) node);
        case (int) HlslConstants.FLOAT:
            return ExitFloat((Token) node);
        case (int) HlslConstants.INT:
            return ExitInt((Token) node);
        case (int) HlslConstants.HALF:
            return ExitHalf((Token) node);
        case (int) HlslConstants.DOUBLE:
            return ExitDouble((Token) node);
        case (int) HlslConstants.BOOL:
            return ExitBool((Token) node);
        case (int) HlslConstants.BASIC_FLOAT:
            return ExitBasicFloat((Token) node);
        case (int) HlslConstants.BASIC_INT:
            return ExitBasicInt((Token) node);
        case (int) HlslConstants.BASIC_HALF:
            return ExitBasicHalf((Token) node);
        case (int) HlslConstants.BASIC_BOOL:
            return ExitBasicBool((Token) node);
        case (int) HlslConstants.BASIC_DOUBLE:
            return ExitBasicDouble((Token) node);
        case (int) HlslConstants.BASIC_UINT:
            return ExitBasicUint((Token) node);
        case (int) HlslConstants.PRE_DEFINE:
            return ExitPreDefine((Token) node);
        case (int) HlslConstants.PRE_IF:
            return ExitPreIf((Token) node);
        case (int) HlslConstants.PRE_ELSEIF:
            return ExitPreElseif((Token) node);
        case (int) HlslConstants.PRE_ENDIF:
            return ExitPreEndif((Token) node);
        case (int) HlslConstants.PRE_IFDEF:
            return ExitPreIfdef((Token) node);
        case (int) HlslConstants.PRE_IFNDEF:
            return ExitPreIfndef((Token) node);
        case (int) HlslConstants.PRE_ERROR:
            return ExitPreError((Token) node);
        case (int) HlslConstants.PRE_INCLUDE:
            return ExitPreInclude((Token) node);
        case (int) HlslConstants.PRE_LINE:
            return ExitPreLine((Token) node);
        case (int) HlslConstants.PRE_PRAGMA:
            return ExitPrePragma((Token) node);
        case (int) HlslConstants.NOINTERPOLATION:
            return ExitNointerpolation((Token) node);
        case (int) HlslConstants.IDENTIFIER:
            return ExitIdentifier((Token) node);
        case (int) HlslConstants.QUOTED_STRING:
            return ExitQuotedString((Token) node);
        case (int) HlslConstants.COMMENT:
            return ExitComment((Token) node);
        case (int) HlslConstants.COMMENTCPP:
            return ExitCommentcpp((Token) node);
        case (int) HlslConstants.FILE:
            return ExitFile((Production) node);
        case (int) HlslConstants.TECHNIQUE_DECLARATION:
            return ExitTechniqueDeclaration((Production) node);
        case (int) HlslConstants.PASS_DECLARATION:
            return ExitPassDeclaration((Production) node);
        case (int) HlslConstants.PASS_INSTRUCTIONS:
            return ExitPassInstructions((Production) node);
        case (int) HlslConstants.STRUCT_DECLARATION:
            return ExitStructDeclaration((Production) node);
        case (int) HlslConstants.FUNCTION_OR_VARIABLE_DECLARATION:
            return ExitFunctionOrVariableDeclaration((Production) node);
        case (int) HlslConstants.VARIABLE_DECLARATION_PART:
            return ExitVariableDeclarationPart((Production) node);
        case (int) HlslConstants.FUNCTION_PART:
            return ExitFunctionPart((Production) node);
        case (int) HlslConstants.PARAMETERS:
            return ExitParameters((Production) node);
        case (int) HlslConstants.LIST_OF_PARAMS:
            return ExitListOfParams((Production) node);
        case (int) HlslConstants.FUNCTION_PARAM:
            return ExitFunctionParam((Production) node);
        case (int) HlslConstants.FUNCTION_BODY:
            return ExitFunctionBody((Production) node);
        case (int) HlslConstants.STATEMENT:
            return ExitStatement((Production) node);
        case (int) HlslConstants.IF_STATEMENT:
            return ExitIfStatement((Production) node);
        case (int) HlslConstants.SWITCH_STATEMENT:
            return ExitSwitchStatement((Production) node);
        case (int) HlslConstants.CASE_STATEMENT:
            return ExitCaseStatement((Production) node);
        case (int) HlslConstants.WHILE_STATEMENT:
            return ExitWhileStatement((Production) node);
        case (int) HlslConstants.DO_STATEMENT:
            return ExitDoStatement((Production) node);
        case (int) HlslConstants.FOR_STATEMENT:
            return ExitForStatement((Production) node);
        case (int) HlslConstants.PRE_PROCESSOR_DIRECTIVES:
            return ExitPreProcessorDirectives((Production) node);
        case (int) HlslConstants.STATEMENT_SCOPE:
            return ExitStatementScope((Production) node);
        case (int) HlslConstants.VARIABLE_DECLARATION:
            return ExitVariableDeclaration((Production) node);
        case (int) HlslConstants.RETURN_STATEMENT:
            return ExitReturnStatement((Production) node);
        case (int) HlslConstants.VARIABLE_ASSIGNMENT:
            return ExitVariableAssignment((Production) node);
        case (int) HlslConstants.VARIABLE_ASSIGNMENT_WITHOUT_DOT_COMMA:
            return ExitVariableAssignmentWithoutDotComma((Production) node);
        case (int) HlslConstants.CONDITION:
            return ExitCondition((Production) node);
        case (int) HlslConstants.INITIALIZERS:
            return ExitInitializers((Production) node);
        case (int) HlslConstants.EXPRESSION:
            return ExitExpression((Production) node);
        case (int) HlslConstants.EXPRESSION_TAIL:
            return ExitExpressionTail((Production) node);
        case (int) HlslConstants.TERM:
            return ExitTerm((Production) node);
        case (int) HlslConstants.TERM_TAIL:
            return ExitTermTail((Production) node);
        case (int) HlslConstants.FACTOR:
            return ExitFactor((Production) node);
        case (int) HlslConstants.ATOM:
            return ExitAtom((Production) node);
        case (int) HlslConstants.FUNCTION_CONSTRUCTOR_CALL_OR_VARIABLE_DECLARATION:
            return ExitFunctionConstructorCallOrVariableDeclaration((Production) node);
        case (int) HlslConstants.PART_OF_PROPERTY_SPECIFICATION:
            return ExitPartOfPropertySpecification((Production) node);
        case (int) HlslConstants.PART_OF_CONSTRUCTOR_CALL:
            return ExitPartOfConstructorCall((Production) node);
        case (int) HlslConstants.PART_OF_VARIABLE_DECLARATION:
            return ExitPartOfVariableDeclaration((Production) node);
        case (int) HlslConstants.PART_OF_VARIABLE_ASSIGNMENT:
            return ExitPartOfVariableAssignment((Production) node);
        case (int) HlslConstants.STORAGE_CLASS:
            return ExitStorageClass((Production) node);
        case (int) HlslConstants.TYPE_MODIFIER:
            return ExitTypeModifier((Production) node);
        case (int) HlslConstants.TYPE:
            return ExitType((Production) node);
        case (int) HlslConstants.VECTOR_EXP:
            return ExitVectorExp((Production) node);
        case (int) HlslConstants.VECTOR_EXP_TYPE:
            return ExitVectorExpType((Production) node);
        case (int) HlslConstants.VECTOR_EXP_NUMBER:
            return ExitVectorExpNumber((Production) node);
        case (int) HlslConstants.VECTOR_EXP_TYPE_NUMBER:
            return ExitVectorExpTypeNumber((Production) node);
        case (int) HlslConstants.MATRIX_EXP:
            return ExitMatrixExp((Production) node);
        case (int) HlslConstants.BASIC_TYPE:
            return ExitBasicType((Production) node);
        case (int) HlslConstants.SEMANTICAL_PARAMETERS:
            return ExitSemanticalParameters((Production) node);
        case (int) HlslConstants.INPUT_SEMANTICAL_PARAMETERS:
            return ExitInputSemanticalParameters((Production) node);
        case (int) HlslConstants.OUTPUT_SEMANTICAL_PARAMETERS:
            return ExitOutputSemanticalParameters((Production) node);
        case (int) HlslConstants.IN_OUT_SEMANTICAL_PARAMETERS:
            return ExitInOutSemanticalParameters((Production) node);
        case (int) HlslConstants.ASSIGNMENT_OPERATOR:
            return ExitAssignmentOperator((Production) node);
        case (int) HlslConstants.PREFIX_POSTFIX_OPERATORS:
            return ExitPrefixPostfixOperators((Production) node);
        case (int) HlslConstants.COMPARISON_OPERATORS:
            return ExitComparisonOperators((Production) node);
        case (int) HlslConstants.BOOLEAN_OPERATORS:
            return ExitBooleanOperators((Production) node);
        case (int) HlslConstants.IN_OUT_INOUT:
            return ExitInOutInout((Production) node);
        case (int) HlslConstants.REGISTER_FUNC:
            return ExitRegisterFunc((Production) node);
        case (int) HlslConstants.PACKOFFSET_FUNC:
            return ExitPackoffsetFunc((Production) node);
        case (int) HlslConstants.IDENTIFIER_COMPOSED:
            return ExitIdentifierComposed((Production) node);
        case (int) HlslConstants.COMPOSE_IDENTIFIER:
            return ExitComposeIdentifier((Production) node);
        case (int) HlslConstants.IDENTIFIER_COMPOSED_REQUIRED:
            return ExitIdentifierComposedRequired((Production) node);
        case (int) HlslConstants.FLOW_CONTROL_WORDS:
            return ExitFlowControlWords((Production) node);
        case (int) HlslConstants.WHILE_FOR_ATTRIBUTES:
            return ExitWhileForAttributes((Production) node);
        case (int) HlslConstants.IF_SWITCH_ATTRIBUTES:
            return ExitIfSwitchAttributes((Production) node);
        case (int) HlslConstants.SEMANTIC_MATRIXES:
            return ExitSemanticMatrixes((Production) node);
        case (int) HlslConstants.WS:
            return ExitWs((Production) node);
        }
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public override void Child(Production node, Node child) {
        switch (node.GetId()) {
        case (int) HlslConstants.FILE:
            ChildFile(node, child);
            break;
        case (int) HlslConstants.TECHNIQUE_DECLARATION:
            ChildTechniqueDeclaration(node, child);
            break;
        case (int) HlslConstants.PASS_DECLARATION:
            ChildPassDeclaration(node, child);
            break;
        case (int) HlslConstants.PASS_INSTRUCTIONS:
            ChildPassInstructions(node, child);
            break;
        case (int) HlslConstants.STRUCT_DECLARATION:
            ChildStructDeclaration(node, child);
            break;
        case (int) HlslConstants.FUNCTION_OR_VARIABLE_DECLARATION:
            ChildFunctionOrVariableDeclaration(node, child);
            break;
        case (int) HlslConstants.VARIABLE_DECLARATION_PART:
            ChildVariableDeclarationPart(node, child);
            break;
        case (int) HlslConstants.FUNCTION_PART:
            ChildFunctionPart(node, child);
            break;
        case (int) HlslConstants.PARAMETERS:
            ChildParameters(node, child);
            break;
        case (int) HlslConstants.LIST_OF_PARAMS:
            ChildListOfParams(node, child);
            break;
        case (int) HlslConstants.FUNCTION_PARAM:
            ChildFunctionParam(node, child);
            break;
        case (int) HlslConstants.FUNCTION_BODY:
            ChildFunctionBody(node, child);
            break;
        case (int) HlslConstants.STATEMENT:
            ChildStatement(node, child);
            break;
        case (int) HlslConstants.IF_STATEMENT:
            ChildIfStatement(node, child);
            break;
        case (int) HlslConstants.SWITCH_STATEMENT:
            ChildSwitchStatement(node, child);
            break;
        case (int) HlslConstants.CASE_STATEMENT:
            ChildCaseStatement(node, child);
            break;
        case (int) HlslConstants.WHILE_STATEMENT:
            ChildWhileStatement(node, child);
            break;
        case (int) HlslConstants.DO_STATEMENT:
            ChildDoStatement(node, child);
            break;
        case (int) HlslConstants.FOR_STATEMENT:
            ChildForStatement(node, child);
            break;
        case (int) HlslConstants.PRE_PROCESSOR_DIRECTIVES:
            ChildPreProcessorDirectives(node, child);
            break;
        case (int) HlslConstants.STATEMENT_SCOPE:
            ChildStatementScope(node, child);
            break;
        case (int) HlslConstants.VARIABLE_DECLARATION:
            ChildVariableDeclaration(node, child);
            break;
        case (int) HlslConstants.RETURN_STATEMENT:
            ChildReturnStatement(node, child);
            break;
        case (int) HlslConstants.VARIABLE_ASSIGNMENT:
            ChildVariableAssignment(node, child);
            break;
        case (int) HlslConstants.VARIABLE_ASSIGNMENT_WITHOUT_DOT_COMMA:
            ChildVariableAssignmentWithoutDotComma(node, child);
            break;
        case (int) HlslConstants.CONDITION:
            ChildCondition(node, child);
            break;
        case (int) HlslConstants.INITIALIZERS:
            ChildInitializers(node, child);
            break;
        case (int) HlslConstants.EXPRESSION:
            ChildExpression(node, child);
            break;
        case (int) HlslConstants.EXPRESSION_TAIL:
            ChildExpressionTail(node, child);
            break;
        case (int) HlslConstants.TERM:
            ChildTerm(node, child);
            break;
        case (int) HlslConstants.TERM_TAIL:
            ChildTermTail(node, child);
            break;
        case (int) HlslConstants.FACTOR:
            ChildFactor(node, child);
            break;
        case (int) HlslConstants.ATOM:
            ChildAtom(node, child);
            break;
        case (int) HlslConstants.FUNCTION_CONSTRUCTOR_CALL_OR_VARIABLE_DECLARATION:
            ChildFunctionConstructorCallOrVariableDeclaration(node, child);
            break;
        case (int) HlslConstants.PART_OF_PROPERTY_SPECIFICATION:
            ChildPartOfPropertySpecification(node, child);
            break;
        case (int) HlslConstants.PART_OF_CONSTRUCTOR_CALL:
            ChildPartOfConstructorCall(node, child);
            break;
        case (int) HlslConstants.PART_OF_VARIABLE_DECLARATION:
            ChildPartOfVariableDeclaration(node, child);
            break;
        case (int) HlslConstants.PART_OF_VARIABLE_ASSIGNMENT:
            ChildPartOfVariableAssignment(node, child);
            break;
        case (int) HlslConstants.STORAGE_CLASS:
            ChildStorageClass(node, child);
            break;
        case (int) HlslConstants.TYPE_MODIFIER:
            ChildTypeModifier(node, child);
            break;
        case (int) HlslConstants.TYPE:
            ChildType(node, child);
            break;
        case (int) HlslConstants.VECTOR_EXP:
            ChildVectorExp(node, child);
            break;
        case (int) HlslConstants.VECTOR_EXP_TYPE:
            ChildVectorExpType(node, child);
            break;
        case (int) HlslConstants.VECTOR_EXP_NUMBER:
            ChildVectorExpNumber(node, child);
            break;
        case (int) HlslConstants.VECTOR_EXP_TYPE_NUMBER:
            ChildVectorExpTypeNumber(node, child);
            break;
        case (int) HlslConstants.MATRIX_EXP:
            ChildMatrixExp(node, child);
            break;
        case (int) HlslConstants.BASIC_TYPE:
            ChildBasicType(node, child);
            break;
        case (int) HlslConstants.SEMANTICAL_PARAMETERS:
            ChildSemanticalParameters(node, child);
            break;
        case (int) HlslConstants.INPUT_SEMANTICAL_PARAMETERS:
            ChildInputSemanticalParameters(node, child);
            break;
        case (int) HlslConstants.OUTPUT_SEMANTICAL_PARAMETERS:
            ChildOutputSemanticalParameters(node, child);
            break;
        case (int) HlslConstants.IN_OUT_SEMANTICAL_PARAMETERS:
            ChildInOutSemanticalParameters(node, child);
            break;
        case (int) HlslConstants.ASSIGNMENT_OPERATOR:
            ChildAssignmentOperator(node, child);
            break;
        case (int) HlslConstants.PREFIX_POSTFIX_OPERATORS:
            ChildPrefixPostfixOperators(node, child);
            break;
        case (int) HlslConstants.COMPARISON_OPERATORS:
            ChildComparisonOperators(node, child);
            break;
        case (int) HlslConstants.BOOLEAN_OPERATORS:
            ChildBooleanOperators(node, child);
            break;
        case (int) HlslConstants.IN_OUT_INOUT:
            ChildInOutInout(node, child);
            break;
        case (int) HlslConstants.REGISTER_FUNC:
            ChildRegisterFunc(node, child);
            break;
        case (int) HlslConstants.PACKOFFSET_FUNC:
            ChildPackoffsetFunc(node, child);
            break;
        case (int) HlslConstants.IDENTIFIER_COMPOSED:
            ChildIdentifierComposed(node, child);
            break;
        case (int) HlslConstants.COMPOSE_IDENTIFIER:
            ChildComposeIdentifier(node, child);
            break;
        case (int) HlslConstants.IDENTIFIER_COMPOSED_REQUIRED:
            ChildIdentifierComposedRequired(node, child);
            break;
        case (int) HlslConstants.FLOW_CONTROL_WORDS:
            ChildFlowControlWords(node, child);
            break;
        case (int) HlslConstants.WHILE_FOR_ATTRIBUTES:
            ChildWhileForAttributes(node, child);
            break;
        case (int) HlslConstants.IF_SWITCH_ATTRIBUTES:
            ChildIfSwitchAttributes(node, child);
            break;
        case (int) HlslConstants.SEMANTIC_MATRIXES:
            ChildSemanticMatrixes(node, child);
            break;
        case (int) HlslConstants.WS:
            ChildWs(node, child);
            break;
        }
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterAdd(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitAdd(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterSub(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitSub(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterMult(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitMult(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterDiv(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitDiv(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterMod(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitMod(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterAddAdd(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitAddAdd(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterSubSub(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitSubSub(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterEqual(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitEqual(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterAddEqual(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitAddEqual(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterSubEqual(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitSubEqual(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterMultEqual(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitMultEqual(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterDivEqual(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitDivEqual(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterModEqual(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitModEqual(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterMinorMinorEqual(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitMinorMinorEqual(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterMajorMajorEqual(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitMajorMajorEqual(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterAndEqual(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitAndEqual(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterOrEqual(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitOrEqual(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPotEqual(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPotEqual(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterEqualEqual(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitEqualEqual(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterDiff(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitDiff(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterLessEqual(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitLessEqual(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterMoreEqual(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitMoreEqual(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTil(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTil(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterMinorMinor(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitMinorMinor(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterMajorMajor(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitMajorMajor(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterAnd(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitAnd(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterOr(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitOr(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPot(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPot(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterAndAnd(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitAndAnd(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterOrOr(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitOrOr(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterNot(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitNot(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterMajor(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitMajor(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterMinor(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitMinor(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterOpenParen(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitOpenParen(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterCloseParen(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitCloseParen(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterOpenBreacket(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitOpenBreacket(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterCloseBreacket(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitCloseBreacket(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterOpenColchetes(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitOpenColchetes(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterCloseColchetes(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitCloseColchetes(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterDoubleDot(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitDoubleDot(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterDotComma(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitDotComma(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterComma(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitComma(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterDot(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitDot(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterNumber(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitNumber(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterNumber24(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitNumber24(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterNumber14(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitNumber14(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterWhitespace(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitWhitespace(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTab(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTab(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterNewline(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitNewline(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterNewline2(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitNewline2(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterNewline3(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitNewline3(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterFormfeed(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitFormfeed(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterString(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitString(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterRgba(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitRgba(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterXyzw(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitXyzw(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterAsm(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitAsm(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterAsmFragment(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitAsmFragment(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterBlendstate(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitBlendstate(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterColumnMajor(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitColumnMajor(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterCompileFragment(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitCompileFragment(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterDiscard(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitDiscard(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterDecl(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitDecl(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterDo(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitDo(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterElse(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitElse(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterExtern(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitExtern(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterEnd(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitEnd(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterFalse(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitFalse(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterFor(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitFor(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterIf(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitIf(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterIn(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitIn(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterInline(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitInline(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterInout(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitInout(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterMatrix(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitMatrix(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterOut(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitOut(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPackoffset(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPackoffset(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPass(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPass(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPixelfragment(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPixelfragment(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterRegister(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitRegister(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterReturn(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitReturn(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterRowMajor(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitRowMajor(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterSampler(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitSampler(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterSampler1d(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitSampler1d(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterSampler2d(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitSampler2d(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterSampler3d(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitSampler3d(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterSamplercube(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitSamplercube(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterSamplerState(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitSamplerState(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterShared(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitShared(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterStateblock(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitStateblock(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterStateblockState(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitStateblockState(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterStatic(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitStatic(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterStringType(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitStringType(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterStruct(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitStruct(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTechnique(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTechnique(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTexture(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTexture(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTexture1d(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTexture1d(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTexture2d(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTexture2d(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTexture3d(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTexture3d(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTexturecube(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTexturecube(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTrue(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTrue(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTypedef(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTypedef(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterUniform(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitUniform(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterVarying(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitVarying(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterVector(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitVector(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterVertexfragment(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitVertexfragment(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterVoid(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitVoid(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterVolatile(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitVolatile(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterWhile(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitWhile(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterStop(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitStop(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterFlatten(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitFlatten(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterBranch(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitBranch(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterUnroll(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitUnroll(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterLoop(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitLoop(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterForcecase(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitForcecase(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterCall(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitCall(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterAuto(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitAuto(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterBreak(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitBreak(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterCompile(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitCompile(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterConst(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitConst(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterChar(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitChar(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterClass(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitClass(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterCase(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitCase(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterCatch(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitCatch(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterDefault(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitDefault(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterDelete(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitDelete(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterConstCast(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitConstCast(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterContinue(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitContinue(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterExplicit(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitExplicit(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterFriend(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitFriend(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterDynamicCast(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitDynamicCast(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterEnum(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitEnum(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterMutable(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitMutable(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterNamespace(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitNamespace(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterGoto(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitGoto(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterLong(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitLong(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPrivate(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPrivate(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterProtected(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitProtected(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterNew(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitNew(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterOperator(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitOperator(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPublic(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPublic(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterReinterpretCast(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitReinterpretCast(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterShort(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitShort(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterStaticCast(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitStaticCast(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterSigned(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitSigned(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterSizeof(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitSizeof(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterSwitch(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitSwitch(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTemplate(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTemplate(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterThis(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitThis(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterThrow(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitThrow(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTry(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTry(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTypename(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTypename(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterUnion(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitUnion(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterUnsigned(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitUnsigned(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterUsing(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitUsing(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterVirtual(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitVirtual(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterBinormal(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitBinormal(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterBlendindices(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitBlendindices(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterBlendweight(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitBlendweight(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterNormal(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitNormal(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPositiont(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPositiont(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterVface(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitVface(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterVpos(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitVpos(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterFog(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitFog(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTessfactor(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTessfactor(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterDepth(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitDepth(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPosition(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPosition(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTexcoord(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTexcoord(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTexunit(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTexunit(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterColor(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitColor(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTangent(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTangent(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPsize(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPsize(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterWorld(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitWorld(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterView(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitView(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterProj(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitProj(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterWorldview(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitWorldview(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterWorldproj(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitWorldproj(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterViewproj(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitViewproj(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterWorldviewproj(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitWorldviewproj(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterFloat(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitFloat(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterInt(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitInt(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterHalf(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitHalf(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterDouble(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitDouble(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterBool(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitBool(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterBasicFloat(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitBasicFloat(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterBasicInt(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitBasicInt(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterBasicHalf(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitBasicHalf(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterBasicBool(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitBasicBool(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterBasicDouble(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitBasicDouble(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterBasicUint(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitBasicUint(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPreDefine(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPreDefine(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPreIf(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPreIf(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPreElseif(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPreElseif(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPreEndif(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPreEndif(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPreIfdef(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPreIfdef(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPreIfndef(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPreIfndef(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPreError(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPreError(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPreInclude(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPreInclude(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPreLine(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPreLine(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPrePragma(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPrePragma(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterNointerpolation(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitNointerpolation(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterIdentifier(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitIdentifier(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterQuotedString(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitQuotedString(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterComment(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitComment(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterCommentcpp(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitCommentcpp(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterFile(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitFile(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildFile(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTechniqueDeclaration(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTechniqueDeclaration(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildTechniqueDeclaration(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPassDeclaration(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPassDeclaration(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildPassDeclaration(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPassInstructions(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPassInstructions(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildPassInstructions(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterStructDeclaration(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitStructDeclaration(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildStructDeclaration(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterFunctionOrVariableDeclaration(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitFunctionOrVariableDeclaration(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildFunctionOrVariableDeclaration(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterVariableDeclarationPart(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitVariableDeclarationPart(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildVariableDeclarationPart(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterFunctionPart(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitFunctionPart(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildFunctionPart(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterParameters(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitParameters(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildParameters(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterListOfParams(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitListOfParams(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildListOfParams(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterFunctionParam(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitFunctionParam(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildFunctionParam(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterFunctionBody(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitFunctionBody(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildFunctionBody(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterStatement(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitStatement(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildStatement(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterIfStatement(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitIfStatement(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildIfStatement(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterSwitchStatement(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitSwitchStatement(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildSwitchStatement(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterCaseStatement(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitCaseStatement(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildCaseStatement(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterWhileStatement(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitWhileStatement(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildWhileStatement(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterDoStatement(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitDoStatement(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildDoStatement(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterForStatement(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitForStatement(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildForStatement(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPreProcessorDirectives(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPreProcessorDirectives(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildPreProcessorDirectives(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterStatementScope(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitStatementScope(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildStatementScope(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterVariableDeclaration(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitVariableDeclaration(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildVariableDeclaration(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterReturnStatement(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitReturnStatement(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildReturnStatement(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterVariableAssignment(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitVariableAssignment(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildVariableAssignment(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterVariableAssignmentWithoutDotComma(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitVariableAssignmentWithoutDotComma(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildVariableAssignmentWithoutDotComma(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterCondition(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitCondition(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildCondition(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterInitializers(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitInitializers(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildInitializers(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterExpression(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitExpression(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildExpression(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterExpressionTail(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitExpressionTail(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildExpressionTail(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTerm(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTerm(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildTerm(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTermTail(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTermTail(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildTermTail(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterFactor(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitFactor(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildFactor(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterAtom(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitAtom(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildAtom(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterFunctionConstructorCallOrVariableDeclaration(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitFunctionConstructorCallOrVariableDeclaration(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildFunctionConstructorCallOrVariableDeclaration(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPartOfPropertySpecification(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPartOfPropertySpecification(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildPartOfPropertySpecification(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPartOfConstructorCall(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPartOfConstructorCall(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildPartOfConstructorCall(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPartOfVariableDeclaration(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPartOfVariableDeclaration(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildPartOfVariableDeclaration(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPartOfVariableAssignment(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPartOfVariableAssignment(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildPartOfVariableAssignment(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterStorageClass(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitStorageClass(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildStorageClass(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTypeModifier(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTypeModifier(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildTypeModifier(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterType(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitType(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildType(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterVectorExp(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitVectorExp(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildVectorExp(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterVectorExpType(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitVectorExpType(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildVectorExpType(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterVectorExpNumber(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitVectorExpNumber(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildVectorExpNumber(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterVectorExpTypeNumber(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitVectorExpTypeNumber(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildVectorExpTypeNumber(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterMatrixExp(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitMatrixExp(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildMatrixExp(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterBasicType(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitBasicType(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildBasicType(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterSemanticalParameters(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitSemanticalParameters(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildSemanticalParameters(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterInputSemanticalParameters(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitInputSemanticalParameters(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildInputSemanticalParameters(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterOutputSemanticalParameters(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitOutputSemanticalParameters(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildOutputSemanticalParameters(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterInOutSemanticalParameters(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitInOutSemanticalParameters(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildInOutSemanticalParameters(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterAssignmentOperator(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitAssignmentOperator(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildAssignmentOperator(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPrefixPostfixOperators(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPrefixPostfixOperators(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildPrefixPostfixOperators(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterComparisonOperators(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitComparisonOperators(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildComparisonOperators(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterBooleanOperators(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitBooleanOperators(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildBooleanOperators(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterInOutInout(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitInOutInout(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildInOutInout(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterRegisterFunc(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitRegisterFunc(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildRegisterFunc(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterPackoffsetFunc(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitPackoffsetFunc(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildPackoffsetFunc(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterIdentifierComposed(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitIdentifierComposed(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildIdentifierComposed(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterComposeIdentifier(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitComposeIdentifier(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildComposeIdentifier(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterIdentifierComposedRequired(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitIdentifierComposedRequired(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildIdentifierComposedRequired(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterFlowControlWords(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitFlowControlWords(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildFlowControlWords(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterWhileForAttributes(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitWhileForAttributes(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildWhileForAttributes(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterIfSwitchAttributes(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitIfSwitchAttributes(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildIfSwitchAttributes(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterSemanticMatrixes(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitSemanticMatrixes(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildSemanticMatrixes(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     * 
     * <param name='node'>the node being entered</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterWs(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     * 
     * <param name='node'>the node being exited</param>
     * 
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitWs(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     * 
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     * 
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildWs(Production node, Node child) {
        node.AddChild(child);
    }
}
