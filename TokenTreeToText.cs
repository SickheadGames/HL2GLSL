// /home/vfpamplona/MonoProjects/hl2glsl/hl2glsl/TokenTreeToText.cs created with MonoDevelop
// User: vfpamplona at 11:35 7/2/2008
//
// To change standard headers go to Edit->Preferences->Coding->Standard Headers
//

using System;
using System.IO;
using PerCederberg.Grammatica.Parser;
using System.Collections;

namespace hl2glsl
{
    /** Transform tokentree in a GLSL code with the same format of the HLSL code or print the tree debug information. */
    public class TokenTreeToText
    {

        TextWriter streamWriter;
        ArrayList functionsToExport;
        string mainFunction;

        /** file - File to save.*/
        public TokenTreeToText(String file)
        {
            streamWriter = new StreamWriter(file);
        }

        /** file - File to save.*/
        public TokenTreeToText(string _mainFunction, ArrayList _functionsToExport)
        {
            streamWriter = new StreamWriter(_mainFunction + ".glsl");
            mainFunction = _mainFunction;
            functionsToExport = _functionsToExport;

            functionsToExport.Add(mainFunction);
        }

        public void WriteTree(Node node)
        {
            node.PrintTo(streamWriter);
            streamWriter.Close();
        }

        /** returns true if the GLSLGenerator replaced the token from HLSL. */
        bool WasChangedByGLSLGenerator(Node node)
        {
            return node.GetValueCount() > 0;
        }

        void WriteToken(Token node)
        {
            try
            {
                if (WasChangedByGLSLGenerator(node))
                    streamWriter.Write(node.GetValue(0));
                else
                    streamWriter.Write(node.GetImage());
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message + "File Error");
                return;
            }
        }

        /** recursive call*/
        void WriteChildren(Node parent)
        {
            for (int i = 0; i < parent.GetChildCount(); i++)
            {
                WriteValuesRecursive(parent.GetChildAt(i));
            }
        }

        /** print the node image and call the print melthod to its children*/
        void WriteValuesRecursive(Node node)
        {
            if (node is Token)
            {
                if (((Token)node).GetImage().Equals(mainFunction))
                    streamWriter.Write("main");
                else
                    WriteToken((Token)node);
            }

            // exports only the dependencies of the function.
            if (node.GetName().Equals("Function_OR_Variable_Declaration"))
            {
                if ((functionsToExport.Contains(((Token)GrammaticaNodeUtils.FindChildOf(node, "IDENTIFIER")).GetImage()))
                    || ((GrammaticaNodeUtils.FindChildOf(node, "Variable_Declaration_PART"))!=null))
                {
                    WriteChildren(node);
                }
                
            }
            else if (node.GetName().Equals("Variable_Declaration") && node.GetParent().GetName().Equals("File"))
            {
                // Affects only variables moved out from function declarations.
                if (functionsToExport.Contains(((Token)GrammaticaNodeUtils.FindChildOf(node, "IDENTIFIER")).GetImage()))
                {
                    WriteChildren(node);
                }

            }
            else
            {
                WriteChildren(node);
            }
        }

        public void WriteValues(Node node)
        {
            WriteValuesRecursive(node);
            streamWriter.Close();
        }
    }
}
