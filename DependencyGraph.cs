// /home/vfpamplona/MonoProjects/hl2glsl/hl2glsl/DependencyGraph.cs created with MonoDevelop
// User: vfpamplona at 16:59 25/3/2008
//
// To change standard headers go to Edit->Preferences->Coding->Standard Headers
//

using System;
using System.Collections;

namespace hl2glsl
{
	public class DependencyGraph
	{
		private ArrayList dependants;	
	
		public DependencyGraph() {
			dependants = new ArrayList();
		}
		
		public void PrintCallTree() {
			for (int i=0; i<dependants.Count; i++) {
				((DependencyGraphNode) dependants[i]).Print();
			}
		}
		
		public ArrayList GetWhoThisFunctionCalls(string func) {
			ArrayList functions = new ArrayList();
			for (int i=0; i<dependants.Count; i++) {
				if (((DependencyGraphNode)dependants[i]).IsCalledBy(func)) {
				    functions.Add(((DependencyGraphNode)dependants[i]).GetDependencyName());
				}
			}	
			return functions;
		}		
		
		public DependencyGraphNode SearchDependant(string dependantName) {
			DependencyGraphNode tmp;
			for (int i=0; i<dependants.Count; i++) {
				tmp = (DependencyGraphNode) dependants[i];
				if (tmp.GetDependencyName().Equals(dependantName))
					return tmp;
			}
			DependencyGraphNode novo = new DependencyGraphNode(dependantName);
			dependants.Add(novo);
			return novo;
		}
		
		public void ReplaceDependant(string toReplace, DependencyGraphNode newNode) {
			DependencyGraphNode replacing = SearchDependant(toReplace);
			for (int i=0; i<CountDependants(); i++) {
				((DependencyGraphNode)dependants[i]).ReplaceCalledBy(replacing, newNode);
			}
			RemoveDependant(replacing);		
		}
		
		public void AddDependant(DependencyGraphNode dep) {
			dependants.Add(dep);
		}
		
		public void RemoveDependant(DependencyGraphNode dep) {
			dependants.Remove(dep);
		}		
		
		public int CountDependants() {
			return dependants.Count;
		}
	}
}
