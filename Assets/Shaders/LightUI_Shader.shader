Shader "Unlit/LightUI_Shader"
{
    Properties
    {
        _MainTexture("Texture", 2D) = "transparent" {}
        [HDR]_Color("Color (RGBA)", Color) = (1,1,1,1)
    }

    SubShader
    {
        Tags{"Queue" = "Transparent" "IgnoreProjector" = "True" "RenderType"="Transparent"}
        Blend SrcAlpha One //SrcAlpha OneMinusSrcAlpha

        Pass    
        {
            CGPROGRAM

            #pragma vertex vertFunc
            #pragma fragment fragFunc

            #include "UnityCG.cginc"

            struct appdata {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };
        
            struct v2f {
                float4 position : SV_POSITION;
                float2 uv : TEXCOORD0;
            };

            fixed4 _Color;
            sampler2D _MainTexture;

            v2f vertFunc(appdata IN)
            {
                v2f OUT;

                OUT.position = UnityObjectToClipPos(IN.vertex);
                OUT.uv = IN.uv;

                return OUT;
    
            }

            fixed4 fragFunc(v2f IN) : SV_Target
            {
                fixed4 pixelColor = tex2D(_MainTexture, IN.uv) * _Color;

                return pixelColor;

                
            }

            ENDCG
        }   
    }
}
