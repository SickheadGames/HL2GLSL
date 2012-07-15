// /home/vfpamplona/MonoProjects/hl2glsl/hl2glsl/ArrayListUtils.cs created with MonoDevelop
// User: vfpamplona at 16:40 25/3/2008
//
// To change standard headers go to Edit->Preferences->Coding->Standard Headers
//



using System;
using System.Collections;

namespace hl2glsl {	
	public class ArrayListUtils	{
		public static void SwapPosition(ArrayList lista, Object node1, Object node2) {
			int exp1idx = lista.IndexOf(node1);
			int exp2idx = lista.IndexOf(node2);
			lista.RemoveAt(exp1idx);
			lista.Insert(exp1idx, node2);
			lista.RemoveAt(exp2idx);
			lista.Insert(exp2idx, node1);
		}
	}
}
