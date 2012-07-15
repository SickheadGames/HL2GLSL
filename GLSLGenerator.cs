// /home/vfpamplona/MonoProjects/hl2glsl/hl2glsl/GLSLGenerator.cs created with MonoDevelop
// User: vfpamplona at 11:15 7/2/2008
//
// To change standard headers go to Edit->Preferences->Coding->Standard Headers
//

using System;
using System.Reflection;
using System.Collections;
using PerCederberg.Grammatica.Parser;

namespace hl2glsl
{
	internal class GLSLGenerator : HlslAnalyzer	{
	
		// list of externalizable mainFunctions. Every one will generate a new file 
		private ArrayList mainFunctions;
        private string activeMainFunction;
        private bool isMain = false;
        private bool replaceReturn = false;

        private string replaceReturnFor;
		
		// list of global vars found in shader
		private ArrayList globalVars;
		
		
        // to replace indentifiers. 
		// used for example to replace semantic variables:
		// from "out float4 oColor : COLOR" to "glFragColor" 
		
		private Hashtable replaceIdentifier = new Hashtable();
        private bool removeRegAndPack = false;
 
	
		// dependency tree
		private DependencyGraph dependencyGraph;
		
		// temporary attribute 
		private DependencyGraphNode functionScope;
        private ArrayList scopeVars; 

        // intrinsic functions that are not supported by GLSL, thus, can not be converted
        private string [] nsIntrinsicFunctions = {"asuint","clip","cosh","D3DCOLORtoUBYTE4","determinant","frexp",
                                                  "GetRenderTargetSampleCount","GetRenderTargetSamplePosition",
                                                  "isfinite","isinf","isnan","ldexp","lit","log10",
                                                  "modf","round","sincos","sinh","tanh","tex1Dbias",
                                                  "tex1Dgrad","tex2Dbias","tex2Dgrad","tex3Dbias","tex3Dgrad",
                                                  "texCUBEbias","texCUBEgrad","transpose","trunc"};
        
        // intrinsic functions that are supported by GLSL but with a different name
        private Hashtable eqIntrinsicFunctions = new Hashtable(); 
	

        private bool CheckAndReplace(Token node, String strHLSL, String strGLSL) {
        	if (node.GetImage().Equals(strHLSL)) {
				node.AddValue(strGLSL);
				return true;
			}
			return false;
        }	
             
		private bool CheckAndReplace(Token node, Hashtable replacement) {
			// Loop through all items of a Hashtable
			IDictionaryEnumerator en = replacement.GetEnumerator();
			while (en.MoveNext()) {
				if (CheckAndReplace(node, en.Key.ToString(), en.Value.ToString()))
					return true;
			}
			return false;
        }

        private Node replaceIntrinsicFunc(Token node)
        {
            ArrayList nsif = new ArrayList();
            nsif.AddRange(nsIntrinsicFunctions);
            
            if (nsif.Contains(node.GetImage()))
                Console.WriteLine("This intrinsic function ({0})is not supported by GLSL", node.GetImage().ToString());

            CheckAndReplace(node, eqIntrinsicFunctions);
            
            return node;        
        }

		public DependencyGraphNode SearchInDependencyGraph(string dependantName) {
			return dependencyGraph.SearchDependant(dependantName);
		}

		public void PrintCallTree() {
			dependencyGraph.PrintCallTree();
		}
		
		public ArrayList GetWhoThisFunctionCalls(string func) {
			return dependencyGraph.GetWhoThisFunctionCalls(func);
		}


		
		/**
		 * Class witch replaces HLSL code to GLSL ones.
		 *
		 * Override a method Exit<Token> and fix the token for GLSL compiler. 
		 */
		public GLSLGenerator(ArrayList _mainFunctions) {
			mainFunctions = _mainFunctions;
			globalVars = new ArrayList();
			dependencyGraph = new DependencyGraph();

            activeMainFunction = mainFunctions[0].ToString();
			scopeVars = new ArrayList();

            eqIntrinsicFunctions.Add("asfloat","float");
            eqIntrinsicFunctions.Add("asint","int");
            eqIntrinsicFunctions.Add("atan2","atan");
            eqIntrinsicFunctions.Add("ddx","dFdx");
            eqIntrinsicFunctions.Add("ddy","dFdy");
            eqIntrinsicFunctions.Add("fmod","mod");
            eqIntrinsicFunctions.Add("frac", "fract");
            eqIntrinsicFunctions.Add("lerp", "mix");
            eqIntrinsicFunctions.Add("noise", "noise1");
            eqIntrinsicFunctions.Add("rsqrt","inversesqrt");
            eqIntrinsicFunctions.Add("tex1D","texture1D");
            eqIntrinsicFunctions.Add("tex1Dlod","texture1DLod");
            eqIntrinsicFunctions.Add("tex1Dproj","texture1DProj");
            eqIntrinsicFunctions.Add("tex2D","texture2D");
            eqIntrinsicFunctions.Add("tex2Dlod","texture2DLod");
            eqIntrinsicFunctions.Add("tex2Dproj","texture2DProj");
            eqIntrinsicFunctions.Add("tex3D","texture3D");
            eqIntrinsicFunctions.Add("tex3Dlod","texture3DLod");
            eqIntrinsicFunctions.Add("tex3Dproj","texture3DProj");
            eqIntrinsicFunctions.Add("texCube", "textureCube");
            eqIntrinsicFunctions.Add("texCubelod", "textureCubeLod");
            eqIntrinsicFunctions.Add("texCubeproj","textureCubeProj");
		}

        
        public override Node ExitPreInclude(Token node)
        {
            throw new UnsupportedTokenException(node.ToString());
            //return node;
        }
        public override Node ExitPreElseif(Token node)
        {
            node.AddValue("#elif");
            return node;
        } 
        
		
		public override Node ExitFloat(Token node) {
  			CheckAndReplace(node, "float2","vec2");
			CheckAndReplace(node, "float3","vec3");
			CheckAndReplace(node, "float4","vec4");			
			CheckAndReplace(node, "float2x2","mat2");		
			CheckAndReplace(node, "float2x3","mat2x3");	
			CheckAndReplace(node, "float2x4","mat2x4");					
			CheckAndReplace(node, "float3x2","mat3x2");				
			CheckAndReplace(node, "float3x3","mat3");
			CheckAndReplace(node, "float3x4","mat3x4");			
			CheckAndReplace(node, "float4x2","mat4x2");
			CheckAndReplace(node, "float4x3","mat4x3");				
			CheckAndReplace(node, "float4x4","mat4");		
            return node;
        }
        
		public override Node ExitBool(Token node) {
			CheckAndReplace(node, "bool2","bvec2");
			CheckAndReplace(node, "bool3","bvec3");
			CheckAndReplace(node, "bool4","bvec4");
			
            return node;
        }     
        
		public override Node ExitInt(Token node) {
			CheckAndReplace(node, "int2","ivec2");
			CheckAndReplace(node, "int3","ivec3");
			CheckAndReplace(node, "int4","ivec4");	
			
            return node;
        }   
        
        
		public override Node ExitHalf(Token node) {
			CheckAndReplace(node, "half2", "ivec2");
			CheckAndReplace(node, "half3","ivec3");
			CheckAndReplace(node, "half4","ivec4");			
				
            return node;
        }        
        public override Node ExitIn(Token node) {
        	node.AddValue("");
        	return node;
        }
        public override Node ExitOut(Token node) {
        	node.AddValue("");
        	return node;
        }
        public override Node ExitInout(Token node) {
        	node.AddValue("");
        	return node;
        }

        public override Node ExitRegisterFunc(Production node)
        {
            Console.WriteLine("GLSL does not support direct access to registers, so, you can't use register.");            
            removeRegAndPack = true;
            return node;
        }

        public override Node ExitPackoffsetFunc(Production node)
        {
            Console.WriteLine("GLSL does not support direct access to registers, so, you can't use packoffset.");
            removeRegAndPack = true;
            return node;
        }

        public override Node ExitBasicUint(Token node)
        {
            Console.WriteLine("GLSL does not support 'uint'. Replacing with 'int'.");
            CheckAndReplace(node, "uint", "int");
            return base.ExitBasicUint(node);
        }

        /**
         * Move the global vars to outside function declaration.
         */
        public override Node ExitFile(Production node) {
			ArrayList lista = GrammaticaNodeUtils.GetChildren(node);
        	
			Node mainFunction = null;
        	for (int i=0; i<lista.Count; i++) {
        		mainFunction = (Node)lista[i]; 

				if (mainFunction.GetName().Equals("Function_OR_Variable_Declaration")) {				
					// move related comment in previous line to inside this function.  
					GrammaticaNodeUtils.MovePreviousLineRelatedCommentToInsideANode(node, i, (Production)mainFunction);
				}
			}
        	
			// search for the first main function.
        	for (int i=0; i<lista.Count; i++) {
        		mainFunction = (Node)lista[i]; 
				if (mainFunction.GetName().Equals("Function_OR_Variable_Declaration")) {
					if (mainFunctions.Contains(((Token)GrammaticaNodeUtils.FindChildOf(mainFunction, "IDENTIFIER")).GetImage())) {
						break;
					}
        		}
        	}
        	
        	// put the global vars before the first MainFunction
        	foreach (Node var in globalVars) {
        		lista.Insert(lista.IndexOf(mainFunction), var);
        		//GrammaticaNodeUtils.SetParent(var, node);
        	}
        	      	
        	return node;
        }
				
		public override Node ExitParameters(Production node) {
			ArrayList listOfParams = GrammaticaNodeUtils.GetChildren(node);
			ArrayList trash = new ArrayList();
			for (int i=0; i<listOfParams.Count; i++) {
				if ((((Node)listOfParams[i]).GetName().Equals("WS")))
					trash.Add(listOfParams[i]);
			}
			
			for (int j=0; j<trash.Count; j++) {
				listOfParams.Remove(trash[j]);
			}
			return node;
		}
		
		
		public bool MarkToReplaceIfNodeIsOfTokenType(Production node, string tokenType, string to) {
			Node isOfType = GrammaticaNodeUtils.FindChildOf(node, 
				new string[4] {"Variable_Declaration", "SemanticalParameters", "InOutSemanticalParameters", tokenType});

			if (isOfType == null)
			  isOfType = GrammaticaNodeUtils.FindChildOf(node, 
				new string[4] {"Variable_Declaration", "SemanticalParameters", "InputSemanticalParameters", tokenType});

			if (isOfType == null)
			  isOfType = GrammaticaNodeUtils.FindChildOf(node, 
				new string[4] {"Variable_Declaration", "SemanticalParameters", "OutputSemanticalParameters", tokenType});
			
			if (isOfType != null) {
				Token name = (Token) GrammaticaNodeUtils.FindChildOf(node, new string[2] {"Variable_Declaration", "IDENTIFIER"});
				replaceIdentifier.Add(name.GetImage(), to);
				return true;
			}
			return false;
		} 
	
		
		
		public bool MarkToReplaceIfNodeIsOfTokenType(Production node, string tokenType, string to, bool isIN) {
			Node isOfType = GrammaticaNodeUtils.FindChildOf(node, 
				new string[4] {"Variable_Declaration", "SemanticalParameters", "InOutSemanticalParameters", tokenType});
			
			if (isOfType == null)
			  isOfType = GrammaticaNodeUtils.FindChildOf(node, 
				new string[4] {"Variable_Declaration", "SemanticalParameters", "InputSemanticalParameters", tokenType});

			if (isOfType == null)
			  isOfType = GrammaticaNodeUtils.FindChildOf(node, 
				new string[4] {"Variable_Declaration", "SemanticalParameters", "OutputSemanticalParameters", tokenType});			
			
			bool ok = false;
			
			if (isIN) {
				if (GrammaticaNodeUtils.FindChildOf(node, new string [2] {"In_out_inout", "INOUT"}) != null
				|| GrammaticaNodeUtils.FindChildOf(node, new string [2] {"In_out_inout", "IN"}) != null
				|| GrammaticaNodeUtils.FindChildOf(node, new string [2] {"In_out_inout", "OUT"}) == null
				|| GrammaticaNodeUtils.FindChildOf(node, new string [1] {"In_out_inout"}) == null
				)
					ok = true;
			} else {  
				if (GrammaticaNodeUtils.FindChildOf(node, new string [2] {"In_out_inout", "INOUT"}) != null
				|| GrammaticaNodeUtils.FindChildOf(node, new string [2] {"In_out_inout", "OUT"}) != null
				)
					ok = true;
			}
			
			if (ok && isOfType != null) {
				Token name = (Token) GrammaticaNodeUtils.FindChildOf(node, new string[2] {"Variable_Declaration", "IDENTIFIER"});
				replaceIdentifier.Add(name.GetImage(), to);
				return true;
			}
			return false;
		}
        public Node RemoveTypeFromMain(Production node)
        {
            Production tempType = (Production) GrammaticaNodeUtils.FindChildOf(node, "Type");
            ArrayList tempVoid = GrammaticaNodeUtils.GetChildren(tempType);

            if (tempVoid != null)
            {
                tempVoid.RemoveAt(0);
                tempVoid.Insert(0, GrammaticaNodeUtils.CreateVoidToken());
            }

            return node;
        }
		
		public Node RemoveSemanticParams(Production node) {
			ArrayList lista = GrammaticaNodeUtils.GetChildren(node);
			ArrayList trash = new ArrayList();
			for (int i=0; i<lista.Count; i++) {
				if ((((Node)lista[i]).GetName().Equals("DOUBLE_DOT")))
					trash.Add(lista[i]);
				if ((((Node)lista[i]).GetName().Equals("SemanticalParameters"))) 
					trash.Add(lista[i]);
				if ((((Node)lista[i]).GetName().Equals("Register_Func")))
					trash.Add(lista[i]);
                if ((((Node)lista[i]).GetName().Equals("Packoffset_Func")))
                    trash.Add(lista[i]);						
			}
			
			for (int j=0; j<trash.Count; j++) {
				lista.Remove(trash[j]);
			}			
			trash = new ArrayList();
			
			// Remove spaces left
			for (int i=lista.Count-1; i>=0; i--) {
				if ((((Node)lista[i]).GetName().Equals("WS")))
					trash.Add(lista[i]);
				else
					break;
			}

			for (int j=0; j<trash.Count; j++) {
				lista.Remove(trash[j]);
			}						

			return node;
		}
		
		
		public Node CheckIfThisNodeIsSemanticAndRemoveIfItIs(Production node) {


			if (MarkToReplaceIfNodeIsOfTokenType(node, "COLOR", "gl_FragColor")
			||  MarkToReplaceIfNodeIsOfTokenType(node, "NORMAL", "gl_Normal")
			||  MarkToReplaceIfNodeIsOfTokenType(node, "POSITION", "gl_Position", false)
			||  MarkToReplaceIfNodeIsOfTokenType(node, "POSITION", "gl_Vertex", true)
			||  MarkToReplaceIfNodeIsOfTokenType(node, "TEXCOORD0", "gl_MultiTexCoord0", true)
			) {
			

				//GrammaticaNodeUtils.GetChildren((Production)GrammaticaNodeUtils.FindChildOf(node, "Variable_Declaration")).;
				return node;
			}
			return RemoveSemanticParams(node);
		} 
	 
			
        // For each param in every main HLSL function
        // Move the uniform and varying params outside the function with his own comments
        public override Node ExitListOfParams(Production node) {
			ArrayList listOfParams = GrammaticaNodeUtils.GetChildren(node);
			
			// Only main mainFunctions.
			// Based on the presence of in, out or inout keywords
			
			if (!isMain) return node;

            isMain = false;
			// Searching params that will be removed at ExitFunctionParam
			for (int i=0; i<listOfParams.Count; i++) {
				if (!(listOfParams[i] is Production))
					continue;
				
                            
				Production functionParam = (Production)listOfParams[i];	
				
        		functionParam = (Production)CheckIfThisNodeIsSemanticAndRemoveIfItIs(functionParam); 
	
				
				// Only uniform params are moved
				Node n = GrammaticaNodeUtils.FindChildOf(functionParam, 
						new string[1] {"Variable_Declaration"});
						
				if (n != null) { // Param found
					// Getting childrens of it
				

					Production variableDeclaration = (Production) n;
			        variableDeclaration = (Production)RemoveSemanticParams(variableDeclaration); 
	
									
					ArrayList variableDeclarationChildren = GrammaticaNodeUtils.GetChildren(variableDeclaration);

			 		// add dot_comma and new line	
			 		variableDeclarationChildren.Add(GrammaticaNodeUtils.CreateDotCommaToken());
					
					// move related comment in previous line to inside this param.  
					GrammaticaNodeUtils.MovePreviousLineRelatedCommentToInsideANode(node, i, variableDeclaration);
					// move related commnet in the same line after the comma but before \n to this param.
					GrammaticaNodeUtils.MoveSameLineRelatedCommentToInsideANode(node, i, variableDeclaration);
					
					// add varying to all non-uniform parameters
					Node hasUniform = GrammaticaNodeUtils.FindChildOf(variableDeclaration, 
						new string[2] {"Storage_Class", "UNIFORM"});
						
					if (hasUniform == null) {
					    GrammaticaNodeUtils.GetChildren(variableDeclaration).Insert(0, GrammaticaNodeUtils.CreateSpaceToken());
                        GrammaticaNodeUtils.GetChildren(variableDeclaration).Insert(0, GrammaticaNodeUtils.CreateVaryingToken());
                        GrammaticaNodeUtils.GetChildren(variableDeclaration).Insert(0, GrammaticaNodeUtils.CreateNewLineToken());
					}
					
			 		// move uniform to outside.
					globalVars.Add(variableDeclaration);	
					
					// remove from param.
					GrammaticaNodeUtils.GetChildren(functionParam).Remove(variableDeclaration);
				}
			}	

			ArrayList trash = new ArrayList();
			
			// cleaning the trash: Spaces, commas and newlines before the ) of the function 
			for (int i=listOfParams.Count-1; i>=0; i--) {
				if (listOfParams[i] is Production) {
					if (((Production)listOfParams[i]).GetChildCount() == 0 
					 || ((Production)listOfParams[i]).GetName().Equals("WS")  ) {
						trash.Add(listOfParams[i]);
					} else {
					    break;
					}
				}
			
				if (listOfParams[i] is Token) {
					if (((Token)listOfParams[i]).GetName().Equals("COMMA")) {
						trash.Add(listOfParams[i]);
					}
				}
			}	
			
			for (int j=0; j<trash.Count; j++) {
				listOfParams.Remove(trash[j]);
			}			
			
			
			return node;
        }
        		
		public override Node ExitFunctionConstructorCallOrVariableDeclaration(Production node) {
			Token identifier = (Token) GrammaticaNodeUtils.FindChildOf(node, new string[2] {"Type", "IDENTIFIER"});		

			if (identifier == null) return node;

            replaceIntrinsicFunc(identifier);

			// mul(term, term) => term * term
			if (identifier.GetImage().Equals("mul")) {
				identifier.AddValue("");
				
				Node virgula = GrammaticaNodeUtils.FindChildOf(node, new string[2] {"PartOf_Constructor_Call", "COMMA"});
				virgula.AddValue(" * ");
			}
		
			// cross(T,N) => cross(N,T).
			if (identifier.GetImage().Equals("cross")) {
				
				Production listOfParam = (Production) GrammaticaNodeUtils.FindChildOf(node, "PartOf_Constructor_Call");
				
				Node exp1 = GrammaticaNodeUtils.FindChildOf(listOfParam, "Expression", 1);
				Node exp2 = GrammaticaNodeUtils.FindChildOf(listOfParam, "Expression", 2);
				
				GrammaticaNodeUtils.SwapChildrenPosition(listOfParam, exp1, exp2);
			}

            // saturate(x) => clamp(x,0.0,1.0).
            if (identifier.GetImage().Equals("saturate"))
            {
                identifier.AddValue("clamp");

                var listOfParam = (Production)GrammaticaNodeUtils.FindChildOf(node, "PartOf_Constructor_Call");
                var children = GrammaticaNodeUtils.GetChildren(listOfParam);
                children.Insert(2, GrammaticaNodeUtils.CreateCommaToken());
                children.Insert(3, GrammaticaNodeUtils.CreateNumberToken(0.0f));
                children.Insert(4, GrammaticaNodeUtils.CreateCommaToken());
                children.Insert(5, GrammaticaNodeUtils.CreateNumberToken(1.0f));
            }

            // add dependent function
			Node n = GrammaticaNodeUtils.FindChildOf(node, "PartOf_Constructor_Call");
			if (n != null && identifier != null && functionScope != null) {
				// function call or constructor call.
				
				dependencyGraph.SearchDependant(identifier.GetImage()).AddCallsBy(functionScope);
			}		

			// Adds only globalVars. 
			
		if (!scopeVars.Contains(identifier.GetImage()))
				dependencyGraph.SearchDependant(identifier.GetImage()).AddCallsBy(functionScope);			
		 
	
			return node;
		}

        public override Node ExitNumber(Token node)
        {
            
            if (node.GetImage().Contains("f"))
            {
                string temp = node.GetImage();

                node.RemoveAllValues();
                node.AddValue(temp.Replace("f",""));
            }
            return base.ExitNumber(node);
        }
		
		public override Node ExitAtom(Production node) {
			Token identifier = (Token) GrammaticaNodeUtils.FindChildOf(node, new string[2] {"Type", "IDENTIFIER"});
			
			// Adds only globalVars. 
			if (identifier != null && !scopeVars.Contains(identifier.GetImage()))
				dependencyGraph.SearchDependant(identifier.GetImage()).AddCallsBy(functionScope);
				
			ArrayList identifiers = GrammaticaNodeUtils.FindChildrenOf(node, new string[2] {"Identifier_Composed_Required", "IDENTIFIER"});
			
			// Adds only globalVars.
			for (int i=0; i<identifiers.Count; i++) {
				if (!scopeVars.Contains(((Token)identifiers[i]).GetImage()))
					dependencyGraph.SearchDependant(((Token)identifiers[i]).GetImage()).AddCallsBy(functionScope);
			}
			
			return node;
		}


        public override Node ExitPartOfVariableDeclaration(Production node) {
			// record all variable declarations inside this function. 			
			Token variableDeclaration = (Token) GrammaticaNodeUtils.FindChildOf(node, new string[1] {"IDENTIFIER"});	
			if (variableDeclaration != null) {
				//Console.WriteLine(variableDeclaration.GetImage());
                scopeVars.Add(variableDeclaration.GetImage());
                if(removeRegAndPack == true)
                    RemoveSemanticParams(node);
			}		
			return node;
		}

        public override Node ExitVariableAssignment(Production node)
        {
            return base.ExitVariableAssignment(node);
        }

		public override Node ExitIdentifier(Token node) {
			CheckAndReplace(node, "tex2D", "texture2D");
			CheckAndReplace(node, replaceIdentifier);
            if (node.GetImage().Equals(activeMainFunction))
            {
                isMain = true;
                replaceReturn = true;
            }
            

			return node;
		} 
	

		/**
		 * Creates a Graph of function calls to decide to what file goes each 
		 * function when the HLSL have more than one main function.
		 */
		public override void EnterFunctionOrVariableDeclaration(Production node) {
			functionScope = new DependencyGraphNode("Nova Função");
			dependencyGraph.AddDependant(functionScope);
			
		    scopeVars = new ArrayList();
			replaceIdentifier = new Hashtable();
            
		}

        
		public override Node ExitFunctionOrVariableDeclaration(Production node) {
			DependencyGraphNode antiga = dependencyGraph.SearchDependant(((Token)GrammaticaNodeUtils.FindChildOf(node, "IDENTIFIER")).GetImage());
			// se a função já existir
			if (antiga != null) {
				// trocar a nova pela n em todo o grafo.
				dependencyGraph.ReplaceDependant("Nova Função", antiga);
			} else {
				dependencyGraph.SearchDependant("Nova Função").SetDependencyName(((Token)GrammaticaNodeUtils.FindChildOf(node, "IDENTIFIER")).GetImage());
			}
			functionScope = null;


            if (((Token)GrammaticaNodeUtils.FindChildOf(node, "IDENTIFIER")).GetImage().Equals(activeMainFunction))
            {
                RemoveTypeFromMain(node);
            }
		    scopeVars = new ArrayList();
			replaceIdentifier = new Hashtable();
            
			return node;
		}

        public override Node ExitStatement(Production node)
        {

            if (replaceReturn == false) return node;
 
            Node n = GrammaticaNodeUtils.FindChildOf(node, new string[1] { "Return_Statement" });
            if (n != null)
            {
               Node returnStatement = GrammaticaNodeUtils.FindChildOf(n, new string[1] { "RETURN" });

               if (returnStatement != null)
                {
                   ArrayList returnStatementChildren = GrammaticaNodeUtils.GetChildren((Production)n);
                    returnStatementChildren.Insert(1, GrammaticaNodeUtils.CreateEqualToken());
                    returnStatementChildren.Insert(1, GrammaticaNodeUtils.CreateSpaceToken());
                }
                
               
            }
            return node;
        }
        
        public bool MarkIfNodeIsFuncSemanticalParameter(Production node, string tokenType, string to)
        {
            ArrayList lista = GrammaticaNodeUtils.GetChildren(node);
            
            for (int i = 0; i < lista.Count; i++)
            {
                if ((((Node)lista[i]).GetName().Equals("SemanticalParameters")))
                {
                    Token name = (Token) GrammaticaNodeUtils.FindChildOf(node, new string[3] {"SemanticalParameters", "InOutSemanticalParameters", tokenType});
                    if (name != null)
                    {
                        replaceReturnFor=to;
                        return true;
                    }
                    return false;
				}
                      
            }
            return false;
        }
        
        public override Node ExitFunctionPart(Production node)
        {

            if (MarkIfNodeIsFuncSemanticalParameter(node, "COLOR", "gl_FragColor")
            || MarkIfNodeIsFuncSemanticalParameter(node, "NORMAL", "gl_Normal")
          //  || MarkIfNodeIsFuncSemanticalParameter(node, "POSITION", "gl_Position", false)
          //  || MarkIfNodeIsFuncSemanticalParameter(node, "POSITION", "gl_Vertex", true)
          //  || MarkIfNodeIsFuncSemanticalParameter(node, "TEXCOORD0", "gl_MultiTexCoord0", true)
            )
            {
                RemoveSemanticParams(node);
            }
            if (replaceReturn == true)
            {
                replaceReturn = false;

                Node funcBody = GrammaticaNodeUtils.FindChildOf(node, "Function_Body");
                if (funcBody != null)
                {
                    for (int i = 0; i < funcBody.GetChildCount(); i++)
                    {
                        Node tempStatement = GrammaticaNodeUtils.FindChildOf(funcBody.GetChildAt(i), "Return_Statement");
                        if (tempStatement != null)
                        {
                            Token tempReturn = (Token)GrammaticaNodeUtils.FindChildOf(tempStatement, "RETURN");
                            if (tempReturn != null)
                            {
                                tempReturn.RemoveAllValues();
                                tempReturn.AddValue(replaceReturnFor);
                            }

                        }
                    }
                }
            }


            return base.ExitFunctionPart(node);
        }

        
	}
}
