// /home/vfpamplona/MonoProjects/hl2glsl/hl2glsl/DependencyGraph.cs created with MonoDevelop
// User: vfpamplona at 10:29 6/3/2008
//
// To change standard headers go to Edit->Preferences->Coding->Standard Headers
//

using System;
using System.Collections;

namespace hl2glsl {
	public class DependencyGraphNode {
	 	private string dependencyName;
		private ArrayList calledBy;
	
		public DependencyGraphNode(string dependencyName)	{
			this.dependencyName = dependencyName;
			calledBy = new ArrayList();
		}
		
		public void AddCallsBy(DependencyGraphNode func) {

            if (func == null)
                return;

			for (int i=0; i<calledBy.Count; i++) {
				if (func == calledBy[i]) return;	
			}
		
			calledBy.Add(func);
		}
		
		public string GetDependencyName() {
			return dependencyName;
		}
		
		public void SetDependencyName(string name) {
			dependencyName = name;
		}
		
		public void ReplaceCalledBy(DependencyGraphNode toReplace, DependencyGraphNode newOne) {
			for (int i=0; i<calledBy.Count; i++) {
				if (toReplace == calledBy[i]) {
					calledBy.Remove(toReplace);

                    if (newOne != null)
    					calledBy.Add(newOne);
					return;
				}
			}
		}
		
		public bool IsCalledBy(string func) {
			for (int i=0; i<calledBy.Count; i++) {
				if (func.Equals(((DependencyGraphNode)calledBy[i]).GetDependencyName() )) {
					return true;
				}
			}
			return false;
		}		
		
		public ArrayList GetCalledByList() {
			return calledBy;
		}
		
		public void Print() {
			Console.WriteLine(dependencyName);
			if (calledBy.Count > 0) {
				Console.WriteLine("Called By:");
				for (int i=0; i<calledBy.Count; i++) {
					Console.WriteLine("\t" + ((DependencyGraphNode)calledBy[i]).GetDependencyName());	
				}
			} else {
				Console.WriteLine("Called By Anyone");
			}
		}
	}
}
