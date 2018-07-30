// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33943,y:31566,varname:node_3138,prsc:2|normal-6580-OUT,emission-4858-OUT,custl-2934-OUT;n:type:ShaderForge.SFN_Color,id:797,x:32879,y:30649,ptovrint:False,ptlb:MainColor,ptin:_MainColor,varname:node_797,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:9840,x:33055,y:30578,varname:node_9840,prsc:2|A-7686-OUT,B-797-RGB;n:type:ShaderForge.SFN_Set,id:1349,x:33225,y:30578,varname:DiffuseColor,prsc:2|IN-9840-OUT;n:type:ShaderForge.SFN_Get,id:5608,x:32988,y:32608,varname:node_5608,prsc:2|IN-1349-OUT;n:type:ShaderForge.SFN_Dot,id:6763,x:31427,y:32376,varname:node_6763,prsc:2,dt:1|A-3008-OUT,B-7381-OUT;n:type:ShaderForge.SFN_LightVector,id:7381,x:31252,y:32460,varname:node_7381,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:3008,x:31252,y:32293,prsc:2,pt:True;n:type:ShaderForge.SFN_LightColor,id:7885,x:32012,y:32482,varname:node_7885,prsc:2;n:type:ShaderForge.SFN_Multiply,id:7179,x:32211,y:32540,varname:node_7179,prsc:2|A-7885-RGB,B-6150-OUT;n:type:ShaderForge.SFN_LightAttenuation,id:5662,x:31607,y:32504,varname:node_5662,prsc:2;n:type:ShaderForge.SFN_Set,id:466,x:32375,y:32540,varname:LightData,prsc:2|IN-7179-OUT;n:type:ShaderForge.SFN_Get,id:5631,x:32988,y:32661,varname:node_5631,prsc:2|IN-466-OUT;n:type:ShaderForge.SFN_Dot,id:7609,x:31525,y:32974,varname:node_7609,prsc:2,dt:0|A-5874-OUT,B-7965-OUT;n:type:ShaderForge.SFN_HalfVector,id:7965,x:31308,y:33059,varname:node_7965,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:5874,x:31308,y:32890,prsc:2,pt:True;n:type:ShaderForge.SFN_Multiply,id:9382,x:31741,y:32831,varname:node_9382,prsc:2|A-4596-OUT,B-7609-OUT;n:type:ShaderForge.SFN_Exp,id:1088,x:31993,y:32963,varname:node_1088,prsc:2,et:0|IN-8001-OUT;n:type:ShaderForge.SFN_Power,id:1183,x:32015,y:32833,varname:node_1183,prsc:2|VAL-9382-OUT,EXP-1088-OUT;n:type:ShaderForge.SFN_Slider,id:8001,x:31677,y:33011,ptovrint:False,ptlb:SpecularGloss,ptin:_SpecularGloss,varname:node_8001,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:3.179487,max:4;n:type:ShaderForge.SFN_Multiply,id:3116,x:32205,y:32833,varname:node_3116,prsc:2|A-1183-OUT,B-6465-OUT,C-7790-RGB;n:type:ShaderForge.SFN_Slider,id:6465,x:31836,y:33129,ptovrint:False,ptlb:SpecularIntensity,ptin:_SpecularIntensity,varname:node_6465,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.8376068,max:2;n:type:ShaderForge.SFN_Set,id:9398,x:32821,y:32830,varname:SpecularData,prsc:2|IN-3352-OUT;n:type:ShaderForge.SFN_Get,id:272,x:33175,y:32747,varname:node_272,prsc:2|IN-9398-OUT;n:type:ShaderForge.SFN_NormalVector,id:9575,x:31222,y:31920,prsc:2,pt:True;n:type:ShaderForge.SFN_Fresnel,id:8375,x:31431,y:31930,varname:node_8375,prsc:2|NRM-9575-OUT,EXP-7876-OUT;n:type:ShaderForge.SFN_Slider,id:7876,x:31352,y:32079,ptovrint:False,ptlb:Fresnel,ptin:_Fresnel,varname:node_7876,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:2.196581,max:10;n:type:ShaderForge.SFN_Set,id:2449,x:31790,y:31891,varname:RimLight,prsc:2|IN-9080-OUT;n:type:ShaderForge.SFN_Set,id:9085,x:31756,y:32376,varname:ShadowData,prsc:2|IN-645-OUT;n:type:ShaderForge.SFN_Multiply,id:645,x:31607,y:32376,varname:node_645,prsc:2|A-6763-OUT,B-5662-OUT;n:type:ShaderForge.SFN_Get,id:6150,x:32012,y:32610,varname:node_6150,prsc:2|IN-9085-OUT;n:type:ShaderForge.SFN_Get,id:4596,x:31504,y:32831,varname:node_4596,prsc:2|IN-9085-OUT;n:type:ShaderForge.SFN_Multiply,id:9080,x:31614,y:31891,varname:node_9080,prsc:2|A-2829-OUT,B-8375-OUT,C-3311-RGB;n:type:ShaderForge.SFN_Get,id:2829,x:31431,y:31847,varname:node_2829,prsc:2|IN-9085-OUT;n:type:ShaderForge.SFN_Get,id:655,x:33175,y:32801,varname:node_655,prsc:2|IN-2449-OUT;n:type:ShaderForge.SFN_AmbientLight,id:9556,x:32939,y:31843,varname:node_9556,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:9865,x:32611,y:31408,ptovrint:False,ptlb:NormalMap,ptin:_NormalMap,varname:node_9865,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:c4221e01dfb24904d9921a57d13f2f70,ntxv:3,isnm:True|UVIN-827-UVOUT;n:type:ShaderForge.SFN_Multiply,id:7659,x:33196,y:32625,varname:node_7659,prsc:2|A-5608-OUT,B-5631-OUT;n:type:ShaderForge.SFN_Add,id:8013,x:33383,y:32688,varname:node_8013,prsc:2|A-7659-OUT,B-272-OUT,C-655-OUT;n:type:ShaderForge.SFN_Multiply,id:8430,x:33150,y:31843,varname:node_8430,prsc:2|A-9556-RGB,B-6203-OUT;n:type:ShaderForge.SFN_Get,id:6203,x:32939,y:31972,varname:node_6203,prsc:2|IN-1349-OUT;n:type:ShaderForge.SFN_Color,id:7790,x:32205,y:33005,ptovrint:False,ptlb:SpecularColor,ptin:_SpecularColor,varname:node_7790,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Color,id:3311,x:31614,y:31746,ptovrint:False,ptlb:RimColor,ptin:_RimColor,varname:node_3311,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Tex2d,id:5489,x:32611,y:31216,ptovrint:False,ptlb:AlbedoMap,ptin:_AlbedoMap,varname:node_5489,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:36d6ffbfeef19d54796c92950db58e62,ntxv:0,isnm:False|UVIN-827-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:7171,x:32254,y:31036,ptovrint:False,ptlb:CloudMap,ptin:_CloudMap,varname:node_7171,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:1177b4d45d9e4f945b8c313929f551b1,ntxv:0,isnm:False|UVIN-5822-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:5886,x:32611,y:31036,ptovrint:False,ptlb:HeightMap,ptin:_HeightMap,varname:node_5886,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:ce982c63d4575e846adb4086cf2eca25,ntxv:0,isnm:False|UVIN-827-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:8926,x:32254,y:31214,ptovrint:False,ptlb:NightLightMap,ptin:_NightLightMap,varname:node_8926,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:dafa214b554686246b7ab9061d1d734e,ntxv:0,isnm:False|UVIN-827-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:5907,x:32254,y:31406,ptovrint:False,ptlb:OceanMaskMap,ptin:_OceanMaskMap,varname:node_5907,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:de2849a75aa8e304aa7d9b211ba1b09a,ntxv:0,isnm:False|UVIN-827-UVOUT;n:type:ShaderForge.SFN_Set,id:4926,x:32776,y:31036,varname:Height,prsc:2|IN-5886-RGB;n:type:ShaderForge.SFN_Set,id:4417,x:32790,y:31216,varname:Albedo,prsc:2|IN-5489-RGB;n:type:ShaderForge.SFN_Set,id:7433,x:32790,y:31408,varname:Normal,prsc:2|IN-9865-RGB;n:type:ShaderForge.SFN_Set,id:6831,x:32421,y:31036,varname:Clouds,prsc:2|IN-7171-RGB;n:type:ShaderForge.SFN_Set,id:5815,x:32421,y:31214,varname:NightLighs,prsc:2|IN-8926-RGB;n:type:ShaderForge.SFN_Set,id:3998,x:32421,y:31406,varname:OceanMask,prsc:2|IN-5907-RGB;n:type:ShaderForge.SFN_Get,id:3478,x:33626,y:31640,varname:node_3478,prsc:2|IN-7433-OUT;n:type:ShaderForge.SFN_Time,id:1799,x:31690,y:31216,varname:node_1799,prsc:2;n:type:ShaderForge.SFN_Panner,id:827,x:31911,y:31144,varname:node_827,prsc:2,spu:-1,spv:0|UVIN-2013-UVOUT,DIST-1799-TSL;n:type:ShaderForge.SFN_TexCoord,id:2013,x:31690,y:31073,varname:node_2013,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:3352,x:32541,y:32831,varname:node_3352,prsc:2|A-3116-OUT,B-1263-OUT;n:type:ShaderForge.SFN_Get,id:4348,x:32520,y:33127,varname:node_4348,prsc:2|IN-3998-OUT;n:type:ShaderForge.SFN_OneMinus,id:1263,x:32541,y:32976,varname:node_1263,prsc:2|IN-4348-OUT;n:type:ShaderForge.SFN_Get,id:4237,x:32777,y:32286,varname:node_4237,prsc:2|IN-9085-OUT;n:type:ShaderForge.SFN_Get,id:4126,x:32939,y:32065,varname:node_4126,prsc:2|IN-5815-OUT;n:type:ShaderForge.SFN_Multiply,id:4913,x:33161,y:32065,varname:node_4913,prsc:2|A-4126-OUT,B-4296-RGB,C-1962-OUT;n:type:ShaderForge.SFN_Color,id:4296,x:32960,y:32148,ptovrint:False,ptlb:LightsColor,ptin:_LightsColor,varname:node_4296,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.9779412,c2:0.9620719,c3:0.4026816,c4:1;n:type:ShaderForge.SFN_OneMinus,id:1962,x:32960,y:32286,varname:node_1962,prsc:2|IN-4237-OUT;n:type:ShaderForge.SFN_Add,id:5190,x:33386,y:31959,varname:node_5190,prsc:2|A-8430-OUT,B-4913-OUT;n:type:ShaderForge.SFN_Lerp,id:7164,x:32450,y:30515,varname:node_7164,prsc:2|A-8132-RGB,B-1752-RGB,T-3895-OUT;n:type:ShaderForge.SFN_Color,id:8132,x:32183,y:30369,ptovrint:False,ptlb:CloudColorA,ptin:_CloudColorA,varname:node_8132,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.07136678,c2:0.1976941,c3:0.4044118,c4:1;n:type:ShaderForge.SFN_Color,id:1752,x:32183,y:30541,ptovrint:False,ptlb:CloudColorB,ptin:_CloudColorB,varname:node_1752,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.3308824,c2:0.7508115,c3:1,c4:1;n:type:ShaderForge.SFN_Relay,id:6580,x:33814,y:31640,varname:node_6580,prsc:2|IN-3478-OUT;n:type:ShaderForge.SFN_Relay,id:2934,x:33814,y:31789,varname:node_2934,prsc:2|IN-8013-OUT;n:type:ShaderForge.SFN_Relay,id:4858,x:33814,y:31691,varname:node_4858,prsc:2|IN-5190-OUT;n:type:ShaderForge.SFN_Get,id:3895,x:32162,y:30694,varname:node_3895,prsc:2|IN-6831-OUT;n:type:ShaderForge.SFN_Get,id:4574,x:32429,y:30659,varname:node_4574,prsc:2|IN-466-OUT;n:type:ShaderForge.SFN_Multiply,id:7544,x:32658,y:30568,varname:node_7544,prsc:2|A-7164-OUT,B-4574-OUT;n:type:ShaderForge.SFN_Get,id:7087,x:32637,y:30478,varname:node_7087,prsc:2|IN-4417-OUT;n:type:ShaderForge.SFN_Add,id:7686,x:32861,y:30488,varname:node_7686,prsc:2|A-7087-OUT,B-7544-OUT;n:type:ShaderForge.SFN_Panner,id:5822,x:31911,y:30994,varname:node_5822,prsc:2,spu:0.3,spv:0|UVIN-2013-UVOUT,DIST-1799-TSL;proporder:5489-9865-797-8001-6465-7876-7790-3311-5907-8926-4296-8132-1752-7171;pass:END;sub:END;*/

Shader "Uniat/GFX_02_EarthShader" {
    Properties {
        _AlbedoMap ("AlbedoMap", 2D) = "white" {}
        _NormalMap ("NormalMap", 2D) = "bump" {}
        _MainColor ("MainColor", Color) = (1,1,1,1)
        _SpecularGloss ("SpecularGloss", Range(0, 4)) = 3.179487
        _SpecularIntensity ("SpecularIntensity", Range(0, 2)) = 0.8376068
        _Fresnel ("Fresnel", Range(0, 10)) = 2.196581
        _SpecularColor ("SpecularColor", Color) = (1,1,1,1)
        _RimColor ("RimColor", Color) = (1,1,1,1)
        _OceanMaskMap ("OceanMaskMap", 2D) = "white" {}
        _NightLightMap ("NightLightMap", 2D) = "white" {}
        _LightsColor ("LightsColor", Color) = (0.9779412,0.9620719,0.4026816,1)
        _CloudColorA ("CloudColorA", Color) = (0.07136678,0.1976941,0.4044118,1)
        _CloudColorB ("CloudColorB", Color) = (0.3308824,0.7508115,1,1)
        _CloudMap ("CloudMap", 2D) = "white" {}
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _MainColor;
            uniform float _SpecularGloss;
            uniform float _SpecularIntensity;
            uniform float _Fresnel;
            uniform sampler2D _NormalMap; uniform float4 _NormalMap_ST;
            uniform float4 _SpecularColor;
            uniform float4 _RimColor;
            uniform sampler2D _AlbedoMap; uniform float4 _AlbedoMap_ST;
            uniform sampler2D _CloudMap; uniform float4 _CloudMap_ST;
            uniform sampler2D _NightLightMap; uniform float4 _NightLightMap_ST;
            uniform sampler2D _OceanMaskMap; uniform float4 _OceanMaskMap_ST;
            uniform float4 _LightsColor;
            uniform float4 _CloudColorA;
            uniform float4 _CloudColorB;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_1799 = _Time;
                float2 node_827 = (i.uv0+node_1799.r*float2(-1,0));
                float3 _NormalMap_var = UnpackNormal(tex2D(_NormalMap,TRANSFORM_TEX(node_827, _NormalMap)));
                float3 Normal = _NormalMap_var.rgb;
                float3 normalLocal = Normal;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
////// Emissive:
                float4 _AlbedoMap_var = tex2D(_AlbedoMap,TRANSFORM_TEX(node_827, _AlbedoMap));
                float3 Albedo = _AlbedoMap_var.rgb;
                float2 node_5822 = (i.uv0+node_1799.r*float2(0.3,0));
                float4 _CloudMap_var = tex2D(_CloudMap,TRANSFORM_TEX(node_5822, _CloudMap));
                float3 Clouds = _CloudMap_var.rgb;
                float ShadowData = (max(0,dot(normalDirection,lightDirection))*attenuation);
                float3 LightData = (_LightColor0.rgb*ShadowData);
                float3 DiffuseColor = ((Albedo+(lerp(_CloudColorA.rgb,_CloudColorB.rgb,Clouds)*LightData))*_MainColor.rgb);
                float4 _NightLightMap_var = tex2D(_NightLightMap,TRANSFORM_TEX(node_827, _NightLightMap));
                float3 NightLighs = _NightLightMap_var.rgb;
                float3 emissive = ((UNITY_LIGHTMODEL_AMBIENT.rgb*DiffuseColor)+(NightLighs*_LightsColor.rgb*(1.0 - ShadowData)));
                float4 _OceanMaskMap_var = tex2D(_OceanMaskMap,TRANSFORM_TEX(node_827, _OceanMaskMap));
                float3 OceanMask = _OceanMaskMap_var.rgb;
                float3 SpecularData = ((pow((ShadowData*dot(normalDirection,halfDirection)),exp(_SpecularGloss))*_SpecularIntensity*_SpecularColor.rgb)*(1.0 - OceanMask));
                float3 RimLight = (ShadowData*pow(1.0-max(0,dot(normalDirection, viewDirection)),_Fresnel)*_RimColor.rgb);
                float3 finalColor = emissive + ((DiffuseColor*LightData)+SpecularData+RimLight);
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _MainColor;
            uniform float _SpecularGloss;
            uniform float _SpecularIntensity;
            uniform float _Fresnel;
            uniform sampler2D _NormalMap; uniform float4 _NormalMap_ST;
            uniform float4 _SpecularColor;
            uniform float4 _RimColor;
            uniform sampler2D _AlbedoMap; uniform float4 _AlbedoMap_ST;
            uniform sampler2D _CloudMap; uniform float4 _CloudMap_ST;
            uniform sampler2D _NightLightMap; uniform float4 _NightLightMap_ST;
            uniform sampler2D _OceanMaskMap; uniform float4 _OceanMaskMap_ST;
            uniform float4 _LightsColor;
            uniform float4 _CloudColorA;
            uniform float4 _CloudColorB;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_1799 = _Time;
                float2 node_827 = (i.uv0+node_1799.r*float2(-1,0));
                float3 _NormalMap_var = UnpackNormal(tex2D(_NormalMap,TRANSFORM_TEX(node_827, _NormalMap)));
                float3 Normal = _NormalMap_var.rgb;
                float3 normalLocal = Normal;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float4 _AlbedoMap_var = tex2D(_AlbedoMap,TRANSFORM_TEX(node_827, _AlbedoMap));
                float3 Albedo = _AlbedoMap_var.rgb;
                float2 node_5822 = (i.uv0+node_1799.r*float2(0.3,0));
                float4 _CloudMap_var = tex2D(_CloudMap,TRANSFORM_TEX(node_5822, _CloudMap));
                float3 Clouds = _CloudMap_var.rgb;
                float ShadowData = (max(0,dot(normalDirection,lightDirection))*attenuation);
                float3 LightData = (_LightColor0.rgb*ShadowData);
                float3 DiffuseColor = ((Albedo+(lerp(_CloudColorA.rgb,_CloudColorB.rgb,Clouds)*LightData))*_MainColor.rgb);
                float4 _OceanMaskMap_var = tex2D(_OceanMaskMap,TRANSFORM_TEX(node_827, _OceanMaskMap));
                float3 OceanMask = _OceanMaskMap_var.rgb;
                float3 SpecularData = ((pow((ShadowData*dot(normalDirection,halfDirection)),exp(_SpecularGloss))*_SpecularIntensity*_SpecularColor.rgb)*(1.0 - OceanMask));
                float3 RimLight = (ShadowData*pow(1.0-max(0,dot(normalDirection, viewDirection)),_Fresnel)*_RimColor.rgb);
                float3 finalColor = ((DiffuseColor*LightData)+SpecularData+RimLight);
                return fixed4(finalColor * 1,0);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
