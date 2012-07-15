 /*
 * Testing variable from outside and .xy atributes. From: http://www.facewound.com/tutorials/shader1/
 * by Vitor Pamplona
 */

sampler2D g_samSrcColor;

float timeraslow=1.0;

float4 MyShader( float2 Tex : TEXCOORD0 ) : COLOR0
{
    float4 Color;
    Color.a = 1.0f;
    Color.rgb = 0.5f;

    Tex.y = Tex.y + (sin(timeraslow)*0.01);
    Tex.x = Tex.x + (cos(timeraslow)*0.01);
   	Color = tex2D( g_samSrcColor, Tex.xy);

    Color -= tex2D( g_samSrcColor, Tex.xy-0.001)*2.0f;
    Color += tex2D( g_samSrcColor, Tex.xy+0.001)*2.0f;
    Color.rgb = (Color.r+Color.g+Color.b)/3.0f;   	
   	
    return Color;
} 