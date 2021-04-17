// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Unlit/BackGround_Shader"
{
    Properties
    {
        _MainTexture("Texture", 2D) = "transparent" {}
        [HDR]_Color("Color (RGBA)", Color) = (1,1,1,1)
        _RotationSpeed("Rotation Speed", Float) = 1
    }

    SubShader
    {
        Tags{"Queue" = "Transparent" "IgnoreProjector" = "True" "RenderType" = "Transparent"}
        Blend SrcAlpha OneMinusSrcAlpha

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

            float _RotationSpeed;
            


            v2f vertFunc(appdata IN)  
            {
                v2f OUT;

                //OUT.position = UnityObjectToClipPos(IN.vertex);
                OUT.position = UnityObjectToClipPos(IN.vertex);

                float angle = _RotationSpeed * _Time;

                // Pivot
                float2 pivot = float2(0.5, 0.5);
                // Rotation Matrix
                float cosAngle = cos(angle);
                float sinAngle = sin(angle);
                float2x2 rot = float2x2(cosAngle, -sinAngle, sinAngle, cosAngle);

                // Rotation around pivot point
                float2 uv = IN.uv.xy - pivot;
                OUT.uv = mul(rot, uv);
                OUT.uv += pivot;

                

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
