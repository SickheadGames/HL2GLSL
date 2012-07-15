// /home/vfpamplona/MonoProjects/hl2glsl/hl2glsl/GrammaticaNodeUtils.cs created with MonoDevelop
// User: vfpamplona at 16:38 25/3/2008
//
// To change standard headers go to Edit->Preferences->Coding->Standard Headers
//

using System;
using System.Reflection;
using System.Collections;
using PerCederberg.Grammatica.Parser;

namespace hl2glsl {
	public class GrammaticaNodeUtils {

        
		/** Returns the first child of node with the name equals childName. */
		public static Node FindChildOf(Node node, string childName) {
        	return FindChildOf(node, childName, 1);
        }
        
        /** Returns the n-th (order) child of node with the name equals childName. */
        public static Node FindChildOf(Node node, string childName, int nth) {
        	Node temp = null;
        	int howManyTimes = 0;
			for (int i=0; i<node.GetChildCount(); i++) {
				temp = node.GetChildAt(i);
				if (temp.GetName().Equals(childName)) {
					howManyTimes++;
					if (howManyTimes == nth) {
						break;
					}
				}
			}
			
			if (howManyTimes == nth)
				return temp;
			else
				return null;
				
        }        

        public static ArrayList FindChildrenOf(Node node, string[] childNameTree) {
			return FindChildrenOf(node, childNameTree, 0);
		}
		
        public static ArrayList FindChildrenOf(Node node, string[] childNameTree, int index) {
			ArrayList ret = new ArrayList();
			for (int i=0; i<node.GetChildCount(); i++) {
				Node temp = node.GetChildAt(i);
				if (temp.GetName().Equals(childNameTree[index])) {
					if (index < childNameTree.Length - 1)
					    ret.AddRange(FindChildrenOf(temp, childNameTree, index+1));
					else
						ret.Add(temp);
				}
			}
            
            return ret;
        }  		
		
        /** Returns the first child of node with the tree to reach is described by childNameTree. */
        public static Node FindChildOf(Node node, string[] childNameTree) {
            for (int i=0; i<childNameTree.Length; i++) {
            	node = FindChildOf(node, childNameTree[i]);
            	if (node == null)
            		return null;
            }
            
            return node;
        }    		
		
		/** Returns the original ArrayList of a production children */ 
		public static ArrayList GetChildren(Production parent) {
			FieldInfo[] campos = parent.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

			foreach (FieldInfo campo in campos) {
				if (campo.Name.Equals("children")) {
					return (ArrayList) campo.GetValue(parent);
				}
			}
			return null;
		}
		
		/** Returns the original ArrayList of a production children */ 
		public static void SetParent(Node child, Node toBeParent) {
			FieldInfo campo = child.GetType().GetField("parent", BindingFlags.Instance | BindingFlags.NonPublic);

            //FieldInfo field = type.GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Static);
            if (campo == null)
                throw new ArgumentException(string.Format("Could not find the private instance field '{0}'", "parent"));
            
            campo.SetValue(child, toBeParent);
		}				
		
		/* Swaps the position of two children */ 
		public static void SwapChildrenPosition(Production parent, Node node1, Node node2) {
			ArrayList lista = GetChildren(parent);
			ArrayListUtils.SwapPosition(lista, node1, node2);
		}
	
		public static Node CreateDotCommaToken() {
			TokenPattern patternDOT_COMMA = new TokenPattern((int) HlslConstants.DOT_COMMA,
                                      "DOT_COMMA", TokenPattern.PatternType.STRING, ";");	
			return new Token(patternDOT_COMMA, patternDOT_COMMA.GetPattern(), 1, 1);
		}
		
		public static Node CreateSpaceToken() {
			TokenPattern patternWHITESPACE = new TokenPattern((int) HlslConstants.WHITESPACE,
                                      "WHITESPACE", TokenPattern.PatternType.STRING, " ");	
			return new Token(patternWHITESPACE, patternWHITESPACE.GetPattern(), 1, 1);
		}
				
		
		public static Node CreateNewLineToken() {
			TokenPattern patternNEW_LINE = new TokenPattern((int) HlslConstants.NEWLINE,
                                       "NEWLINE", TokenPattern.PatternType.STRING, "\n");
			return new Token(patternNEW_LINE, patternNEW_LINE.GetPattern(), 1, 1);
		}

		public static Node CreateVaryingToken() {
			TokenPattern patternVarying = new TokenPattern((int) HlslConstants.VARYING,
                                       "VARYING", TokenPattern.PatternType.STRING, "varying");
			return new Token(patternVarying, patternVarying.GetPattern(), 1, 1);
		}

        public static Node CreateVoidToken()
        {
            TokenPattern patternVoid = new TokenPattern((int)HlslConstants.VOID,
                                       "VOID", TokenPattern.PatternType.STRING, "void");
            return new Token(patternVoid, patternVoid.GetPattern(), 1, 1);
        }

        public static Node CreateEqualToken()
        {
            TokenPattern patternEqual = new TokenPattern((int)HlslConstants.EQUAL,
                                        "EQUAL", TokenPattern.PatternType.STRING, "=");
            return new Token(patternEqual, patternEqual.GetPattern(), 1, 1);
	

        }
		// Dado um nodo pai, e o índice do nodo filho, esta função busca em índeces anteriores e posteriores 
		// os comentários pertinentes e move para dentro do nodeToPut. 
		// O objetivo desta função é preparar os nodos para serem movidos, levando consigo seus comentários.  
		public static void MovePreviousLineRelatedCommentToInsideANode(Production nodeToSearch, int indexOfTheRelatedInstruction, Production nodeToPut) {
			ArrayList whereSearch = GrammaticaNodeUtils.GetChildren(nodeToSearch);
			ArrayList wherePut    = GrammaticaNodeUtils.GetChildren(nodeToPut);
			
			int WSPos = indexOfTheRelatedInstruction-1; // WS is always one before Function_Param
			if (WSPos >= 0) {
				Production WS = (Production) whereSearch[WSPos];
				if (WS.GetName().Equals("WS")) { // WS is optional
					ArrayList tokens = GrammaticaNodeUtils.GetChildren(WS);
							
					// Search the first newline
					int afterTheFirstNewLine = tokens.Count;
	    			for (int j=tokens.Count-3; j>0; j--) {
	    				if (((Token)tokens[j]).GetName().Equals("NEWLINE")
	    				||  ((Token)tokens[j]).GetName().Equals("NEWLINE2")
	    				||  ((Token)tokens[j]).GetName().Equals("NEWLINE3")) {
	    					afterTheFirstNewLine = j;
							break;
						}		
			    	}
			    			
	    			// add all after the first newline to variable declaration
	    			ArrayList toRemove = new ArrayList();
	    			for (int j=afterTheFirstNewLine; j<tokens.Count; j++) {
	    				// adds to param childrens which will be moved to outside the function
    					if (!((Token)tokens[j]).GetName().Equals("WHITESPACE")
    					&&  !((Token)tokens[j]).GetName().Equals("TAB")) {
    						wherePut.Insert(0, tokens[j]);
    						toRemove.Add(tokens[j]);
    					}
	    			}
		    			
	    			for (int j=0; j<toRemove.Count; j++) {
	    				tokens.Remove(toRemove[j]);
	    			}
				}
			}
		}

		// Dado um nodo pai, e o índice do nodo filho, esta função busca em índeces anteriores e posteriores 
		// os comentários pertinentes e move para dentro do nodeToPut. 
		// O objetivo desta função é preparar os nodos para serem movidos, levando consigo seus comentários.
		public static void MoveSameLineRelatedCommentToInsideANode(Production nodeToSearch, int indexOfTheRelatedInstruction, Production nodeToPut) {
			ArrayList whereSearch = GrammaticaNodeUtils.GetChildren(nodeToSearch);
			ArrayList wherePut    = GrammaticaNodeUtils.GetChildren(nodeToPut);
			
			// find related comment after the comma and before the \n
			Production relatedWS = null;
			Token relatedComma = null;
			// PARAM [WS] COMMA [WS]
			int WSPos = indexOfTheRelatedInstruction+2; // WS is always one before Function_Param
			if (WSPos <= whereSearch.Count) {
				relatedWS = (Production) whereSearch[WSPos];
				if (!relatedWS.GetName().Equals("WS")) { // First WS is optional
					relatedWS = null;
					relatedComma = (Token) whereSearch[WSPos];
					
					WSPos++;
					if (WSPos <= whereSearch.Count) {
						relatedWS = (Production) whereSearch[WSPos];
					}
				} else {
					relatedComma = (Token) whereSearch[WSPos-1];
				}
			}
					
			// move to related comment after the comma and before the \n
			if (relatedWS != null) {
				ArrayList toRemove = new ArrayList();
	    		// add all after the comma and before newline
	    		ArrayList tokens = GrammaticaNodeUtils.GetChildren(relatedWS);
	    		for (int j=0; j<tokens.Count; j++) {
	    			// adds to param childrens which will be moved to outside the function
	    			if (((Token)tokens[j]).GetName().Equals("NEWLINE")
	    			||  ((Token)tokens[j]).GetName().Equals("NEWLINE2")
	    			||  ((Token)tokens[j]).GetName().Equals("NEWLINE3")) {
	    				wherePut.Add(tokens[j]);
	    				toRemove.Add(tokens[j]);
	    				break;
	    			}
    				wherePut.Add(tokens[j]);
    				toRemove.Add(tokens[j]);			    			
	    		}
	    		tokens.Clear();
	    		for (int j=0; j<toRemove.Count; j++) {
	    			tokens.Remove(toRemove[j]);
		    	}
			}
					
			// remove comma
			whereSearch.Remove(relatedComma);			
		}

		
	}
}
