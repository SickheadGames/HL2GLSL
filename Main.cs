// project created on 1/10/2007 at 08:59
using System;
using System.IO;
using System.Collections;

using PerCederberg.Grammatica.Parser;

namespace hl2glsl
{
	class MainClass
	{
		void PrintLogFile(Node node) {
			TokenTreeToText logWriter = new TokenTreeToText("log.txt");
			logWriter.WriteTree(node);
		}
		
		void PrintGLSLFile(Node rootNode, GLSLGenerator gen, string nameToExport) {
			ArrayList dependenciesToExport = gen.GetWhoThisFunctionCalls(nameToExport);
						
			TokenTreeToText glslWriter = new TokenTreeToText(nameToExport, dependenciesToExport);
			glslWriter.WriteValues(rootNode);
		}
	
		TextReader ReadFile(String file) {
			return new StreamReader(file); 
		}
		
		Node ParseFile(String file, HlslAnalyzer analyzer) {
			HlslParser hlslParser = new HlslParser(ReadFile(file), analyzer);
			return hlslParser.Parse();
		}
	
		public static void Main(string[] args) {
    		Console.WriteLine("Test Began!");
    		
    		if (args.Length < 2) {
    			Console.WriteLine("You must pass at least one externalizable function as the main!");	
    		}
	
			MainClass m = new MainClass();

			//string[] functions = args[0..3];
			ArrayList mainFunctions = new ArrayList();
			for (int i=1; i<args.Length; i++) {
				mainFunctions.Add(args[i]);
			}
	
			GLSLGenerator gen = new GLSLGenerator(mainFunctions);
			Node node = m.ParseFile(args[0], gen);
	
			m.PrintLogFile(node);
			for (int i=0; i<mainFunctions.Count; i++) {
				m.PrintGLSLFile(node, gen, (string)mainFunctions[i]);
			}
			//gen.PrintCallTree();
	
			Console.WriteLine("Test OK!");
		}
	}
}