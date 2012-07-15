// /home/vfpamplona/MonoProjects/hl2glsl/hl2glsl/UnsupportedToken.cs created with MonoDevelop
// User: vfpamplona at 17:16 7/2/2008
//
// To change standard headers go to Edit->Preferences->Coding->Standard Headers
//

using System;

namespace hl2glsl {
	public class UnsupportedTokenException : Exception {
		public UnsupportedTokenException(string str) {
			Console.WriteLine("Token " + str + " is not supported yet.");
		}
	}
}