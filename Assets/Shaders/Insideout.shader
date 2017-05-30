// Tarek:
// Please note that this shader script is taken from this link:
//	https://www.youtube.com/watch?v=xyLkPVehdA8&t=218s
// I could have used the other shader (Pano360Shader) also here, but I used this for video360 at start, then I found that
//	MovieTexture was not supported on mobile devices, so I searched a lot to find this link http://fusedvr.com/building-a-360-video-player-from-scratch/
// about using the Oculus package. So at the end I didn't want to change it.
// 
//
// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'
//
// Based on Unlit shader, but culls the front faces instead of the back

Shader "Insideout" {
Properties {
	_MainTex ("Base (RGB)", 2D) = "white" {}
}

SubShader {
	Tags { "RenderType"="Opaque" }
	Cull front    // ADDED BY BERNIE, TO FLIP THE SURFACES
	LOD 100
	
	Pass {  
		CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata_t {
				float4 vertex : POSITION;
				float2 texcoord : TEXCOORD0;
			};

			struct v2f {
				float4 vertex : SV_POSITION;
				half2 texcoord : TEXCOORD0;
			};

			sampler2D _MainTex;
			float4 _MainTex_ST;
			
			v2f vert (appdata_t v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				// ADDED BY BERNIE:
				v.texcoord.x = 1 - v.texcoord.x;				
				o.texcoord = TRANSFORM_TEX(v.texcoord, _MainTex);
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{
				fixed4 col = tex2D(_MainTex, i.texcoord);
				return col;
			}
		ENDCG
	}
}

}