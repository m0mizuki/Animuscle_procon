#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Byte[] UnityEngine.ImageConversion::EncodeToJPG(UnityEngine.Texture2D,System.Int32)
extern void ImageConversion_EncodeToJPG_mD0307B5DFF32A3FF39488E97B467F11AFE501F6F (void);
// 0x00000002 System.Byte[] UnityEngine.ImageConversion::EncodeToJPG(UnityEngine.Texture2D)
extern void ImageConversion_EncodeToJPG_mD3B358B8645CF85EBAD979554FFDE05A54A99804 (void);
// 0x00000003 Unity.Collections.NativeArray`1<System.Byte> UnityEngine.ImageConversion::EncodeNativeArrayToJPG(Unity.Collections.NativeArray`1<T>,UnityEngine.Experimental.Rendering.GraphicsFormat,System.UInt32,System.UInt32,System.UInt32,System.Int32)
// 0x00000004 System.Void* UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToJPG(System.Void*,System.Int32&,UnityEngine.Experimental.Rendering.GraphicsFormat,System.UInt32,System.UInt32,System.UInt32,System.Int32)
extern void ImageConversion_UnsafeEncodeNativeArrayToJPG_m19AB03A1F3E5019BEDA20CC0D3A15A760932E53D (void);
static Il2CppMethodPointer s_methodPointers[4] = 
{
	ImageConversion_EncodeToJPG_mD0307B5DFF32A3FF39488E97B467F11AFE501F6F,
	ImageConversion_EncodeToJPG_mD3B358B8645CF85EBAD979554FFDE05A54A99804,
	NULL,
	ImageConversion_UnsafeEncodeNativeArrayToJPG_m19AB03A1F3E5019BEDA20CC0D3A15A760932E53D,
};
static const int32_t s_InvokerIndices[4] = 
{
	4693,
	5088,
	0,
	3603,
};
static const Il2CppTokenRangePair s_rgctxIndices[1] = 
{
	{ 0x06000003, { 0, 2 } },
};
extern const uint32_t g_rgctx_UnsafeUtility_SizeOf_TisT_t7F385DF47AE8A1EC870566CC984AE8566363EAB7_m519470E989AD2C4568D3904E5B6ED36A726772AE;
extern const uint32_t g_rgctx_NativeArrayUnsafeUtility_GetUnsafeBufferPointerWithoutChecks_TisT_t7F385DF47AE8A1EC870566CC984AE8566363EAB7_mFD221EF64968C641FC063BD7CDA732DDED160732;
static const Il2CppRGCTXDefinition s_rgctxValues[2] = 
{
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_UnsafeUtility_SizeOf_TisT_t7F385DF47AE8A1EC870566CC984AE8566363EAB7_m519470E989AD2C4568D3904E5B6ED36A726772AE },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_NativeArrayUnsafeUtility_GetUnsafeBufferPointerWithoutChecks_TisT_t7F385DF47AE8A1EC870566CC984AE8566363EAB7_mFD221EF64968C641FC063BD7CDA732DDED160732 },
};
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_UnityEngine_ImageConversionModule_CodeGenModule;
const Il2CppCodeGenModule g_UnityEngine_ImageConversionModule_CodeGenModule = 
{
	"UnityEngine.ImageConversionModule.dll",
	4,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	1,
	s_rgctxIndices,
	2,
	s_rgctxValues,
	NULL,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
