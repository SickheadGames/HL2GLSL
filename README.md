HL2GLSL
=======

HL2GLSL is pure C# translator between High Level Shading Language and the OpenGL Shading Language.

This is a fork of the [original HL2GLSL project](http://hl2glsl.codeplex.com/) hosted on CodePlex.


**WARNING:** *This project is still in development and may not function with your shaders yet.*

Usage
=====

The command line tool will convert one or more vertex or pixel shader entrypoints in a HLSL/FX file
and generate a new GLSL file for each.

HL2GLSL MyShader.hlsl VsFunc
HL2GLSL MyEffect.fx VsFunc Vs2Func PsFunc


