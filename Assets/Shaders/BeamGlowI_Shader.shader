Shader "Unlit/BeamGlow_Shader"
{
    Properties
    {
        _MainTexture("Texture", 2D) = "transparent" {}
        [HDR]_Color("Color (RGBA)", Color) = (1,1,1,1)
        _ScrollSpeed("Scroll Speed", Float) = 0
    }

    SubShader
    {
        Tags{"Queue" = "Transparent" "IgnoreProjector" = "True" "RenderType"="Transparent"}
        Blend SrcAlpha One //SrcAlpha OneMinusSrcAlpha
        
        Lighting Off
        ZTest LEqual
        ZWrite Off
        //Offset -1, -1  

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
            float _ScrollSpeed;
            sampler2D _MainTexture;

            v2f vertFunc(appdata IN)
            {
                v2f OUT;

                OUT.position = UnityObjectToClipPos(IN.vertex);
                OUT.uv = IN.uv;

                //OUT.uv = (IN.uv.x + _Time * _ScrollSpeed, IN.uv.y + _Time * _ScrollSpeed);
                


                return OUT;
    
            }

            fixed4 fragFunc(v2f IN) : SV_Target
            {
                return _Color;
                //fixed4 pixelColor = tex2D(_MainTexture, IN.uv) * 10.0f * _Color;

                //return pixelColor;
            }

            ENDCG
        }   
    }
}
