/*
 * Multi-function and operators Shader Test.
 * by Vitor Pamplona
 */

float otherFunction(float4 teste, float4 outroTeste) {
    return dot(teste, outroTeste);
}

// Main function of the fragment shader.
float4 pixelShader(float4 color : COLOR0) : COLOR { 

	// Creating Green Color
	float4 teste = float4(0+0.5,1,40*0.5,0);
	
	teste++;
	
	// Other function
	otherFunction(teste, teste);
	
	
	return teste;  //returns always black
} 