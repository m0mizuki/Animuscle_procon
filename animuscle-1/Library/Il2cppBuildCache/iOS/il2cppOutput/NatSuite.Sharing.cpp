#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


template <typename R>
struct VirtualFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1, typename T2>
struct InvokerActionInvoker2
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1 p1, T2 p2)
	{
		void* params[2] = { &p1, &p2 };
		method->invoker_method(methodPtr, method, obj, params, NULL);
	}
};
template <typename T1, typename T2, typename T3>
struct InvokerActionInvoker3;
template <typename T1, typename T2, typename T3>
struct InvokerActionInvoker3<T1*, T2, T3>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1, T2 p2, T3 p3)
	{
		void* params[3] = { p1, &p2, &p3 };
		method->invoker_method(methodPtr, method, obj, params, NULL);
	}
};

// System.Action`1<System.Object>
struct Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87;
// System.Collections.Generic.Dictionary`2<System.Int32,System.Threading.Tasks.Task>
struct Dictionary_2_t403063CE4960B4F46C688912237C6A27E550FF55;
// System.Func`1<System.Threading.Tasks.Task/ContingentProperties>
struct Func_1_tD59A12717D79BFB403BF973694B1BE5B85474BD1;
// System.Predicate`1<System.Object>
struct Predicate_1_t8342C85FF4E41CD1F7024AC0CDC3E5312A32CB12;
// System.Predicate`1<System.Threading.Tasks.Task>
struct Predicate_1_t7F48518B008C1472339EEEBABA3DE203FE1F26ED;
// System.Threading.Tasks.TaskCompletionSource`1<System.Boolean>
struct TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14;
// System.Threading.Tasks.TaskFactory`1<System.Boolean>
struct TaskFactory_1_tFAEAC22A1E986463E6956C344A78A7C7197288E0;
// System.Threading.Tasks.Task`1<System.Boolean>
struct Task_1_t824317F4B958F7512E8F7300511752937A6C6043;
// System.Byte[]
struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031;
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
// System.AsyncCallback
struct AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C;
// System.Attribute
struct Attribute_tFDA8EFEFB0711976D22474794576DAF28F7440AA;
// System.Threading.ContextCallback
struct ContextCallback_tE8AFBDBFCC040FDA8DA8C1EEFE9BD66B16BDA007;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E;
// Microsoft.CodeAnalysis.EmbeddedAttribute
struct EmbeddedAttribute_t9265EBAEE5A94BFE10568D61CAB9D8E8EF163B39;
// System.IAsyncResult
struct IAsyncResult_t7B9B5A0ECB35DCEC31B8A8122C37D687369253B5;
// System.Runtime.CompilerServices.IsUnmanagedAttribute
struct IsUnmanagedAttribute_t9D6DB26BA863EE5252773DB55457B2F24700E9B9;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// NatSuite.Sharing.Internal.NativePayload
struct NativePayload_t6BA646CD27EAB43F98E63FCDE5B236FE1AF22DFE;
// NatSuite.Sharing.PrintPayload
struct PrintPayload_tB95D34D4C81CF445C73D8E88CDF09613854EC4A3;
// NatSuite.Sharing.SavePayload
struct SavePayload_tA351C0AE87F117EE45D72C6007552E4ABAC5AAF3;
// NatSuite.Sharing.SharePayload
struct SharePayload_t70A932F29157647E7DC8A51AEA00D3EB4395F9EB;
// System.Threading.Tasks.StackGuard
struct StackGuard_tACE063A1B7374BDF4AD472DE4585D05AD8745352;
// System.String
struct String_t;
// System.Threading.Tasks.TaskFactory
struct TaskFactory_tF781BD37BE23917412AD83424D1497C7C1509DF0;
// System.Threading.Tasks.TaskScheduler
struct TaskScheduler_t3F0550EBEF7C41F74EC8C08FF4BED0D8CE66006E;
// UnityEngine.Texture2D
struct Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// NatSuite.Sharing.Internal.NatShare/CompletionHandler
struct CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690;
// System.Threading.Tasks.Task/ContingentProperties
struct ContingentProperties_t3FA59480914505CEA917B1002EC675F29D0CB540;

IL2CPP_EXTERN_C RuntimeClass* Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IntPtr_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RuntimePlatform_t9A8AAF204603076FCAAECCCC05DA386AEE7BF66E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral0ECA1F1B3EAFB7AB365A952126A44D4B20673360;
IL2CPP_EXTERN_C String_t* _stringLiteral1E1246962420BA0009704AC0055549B0249109EC;
IL2CPP_EXTERN_C String_t* _stringLiteral20FC19F814D4953B75471571F60DF8EC6A7A6A0E;
IL2CPP_EXTERN_C String_t* _stringLiteralA8E6CD7671815F92F64A76C69771D7003226F136;
IL2CPP_EXTERN_C const RuntimeMethod* NativePayload_OnCompletion_mB7CEB2F987365BBC864A74D259178D8E111F43A9_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TaskCompletionSource_1_SetResult_mA4C94A8605B8E4A2646C0C2B08A3D373E1174448_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TaskCompletionSource_1__ctor_mBAB8D6EFEAD1AA6482D19D7CE639528BE66AF646_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TaskCompletionSource_1_get_Task_m068E06095F165AE266E15C328CBDA1543429EC66_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Task_FromResult_TisBoolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_m390F8F1169B06A0B55B488C1C66A1539F6DD5D9B_RuntimeMethod_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;

struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031;
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_t9B20CE91526448A20F565392AC7AEB5522341D1F 
{
};

// System.Threading.Tasks.TaskCompletionSource`1<System.Boolean>
struct TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14  : public RuntimeObject
{
	// System.Threading.Tasks.Task`1<TResult> System.Threading.Tasks.TaskCompletionSource`1::_task
	Task_1_t824317F4B958F7512E8F7300511752937A6C6043* ____task_0;
};
struct Il2CppArrayBounds;

// System.Attribute
struct Attribute_tFDA8EFEFB0711976D22474794576DAF28F7440AA  : public RuntimeObject
{
};

// NatSuite.Sharing.Internal.NatShare
struct NatShare_t9461112550AF447CA0777E4A37E4B85F1ACEF225  : public RuntimeObject
{
};

// System.String
struct String_t  : public RuntimeObject
{
	// System.Int32 System.String::_stringLength
	int32_t ____stringLength_4;
	// System.Char System.String::_firstChar
	Il2CppChar ____firstChar_5;
};

struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// System.Threading.Tasks.Task
struct Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572  : public RuntimeObject
{
	// System.Int32 modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.Tasks.Task::m_taskId
	int32_t ___m_taskId_1;
	// System.Delegate System.Threading.Tasks.Task::m_action
	Delegate_t* ___m_action_2;
	// System.Object System.Threading.Tasks.Task::m_stateObject
	RuntimeObject* ___m_stateObject_3;
	// System.Threading.Tasks.TaskScheduler System.Threading.Tasks.Task::m_taskScheduler
	TaskScheduler_t3F0550EBEF7C41F74EC8C08FF4BED0D8CE66006E* ___m_taskScheduler_4;
	// System.Threading.Tasks.Task System.Threading.Tasks.Task::m_parent
	Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572* ___m_parent_5;
	// System.Int32 modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.Tasks.Task::m_stateFlags
	int32_t ___m_stateFlags_6;
	// System.Object modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.Tasks.Task::m_continuationObject
	RuntimeObject* ___m_continuationObject_23;
	// System.Threading.Tasks.Task/ContingentProperties modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.Tasks.Task::m_contingentProperties
	ContingentProperties_t3FA59480914505CEA917B1002EC675F29D0CB540* ___m_contingentProperties_26;
};

struct Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572_StaticFields
{
	// System.Int32 System.Threading.Tasks.Task::s_taskIdCounter
	int32_t ___s_taskIdCounter_0;
	// System.Object System.Threading.Tasks.Task::s_taskCompletionSentinel
	RuntimeObject* ___s_taskCompletionSentinel_24;
	// System.Boolean System.Threading.Tasks.Task::s_asyncDebuggingEnabled
	bool ___s_asyncDebuggingEnabled_25;
	// System.Action`1<System.Object> System.Threading.Tasks.Task::s_taskCancelCallback
	Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87* ___s_taskCancelCallback_27;
	// System.Func`1<System.Threading.Tasks.Task/ContingentProperties> System.Threading.Tasks.Task::s_createContingentProperties
	Func_1_tD59A12717D79BFB403BF973694B1BE5B85474BD1* ___s_createContingentProperties_30;
	// System.Threading.Tasks.TaskFactory System.Threading.Tasks.Task::<Factory>k__BackingField
	TaskFactory_tF781BD37BE23917412AD83424D1497C7C1509DF0* ___U3CFactoryU3Ek__BackingField_31;
	// System.Threading.Tasks.Task System.Threading.Tasks.Task::<CompletedTask>k__BackingField
	Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572* ___U3CCompletedTaskU3Ek__BackingField_32;
	// System.Predicate`1<System.Threading.Tasks.Task> System.Threading.Tasks.Task::s_IsExceptionObservedByParentPredicate
	Predicate_1_t7F48518B008C1472339EEEBABA3DE203FE1F26ED* ___s_IsExceptionObservedByParentPredicate_33;
	// System.Threading.ContextCallback System.Threading.Tasks.Task::s_ecCallback
	ContextCallback_tE8AFBDBFCC040FDA8DA8C1EEFE9BD66B16BDA007* ___s_ecCallback_34;
	// System.Predicate`1<System.Object> System.Threading.Tasks.Task::s_IsTaskContinuationNullPredicate
	Predicate_1_t8342C85FF4E41CD1F7024AC0CDC3E5312A32CB12* ___s_IsTaskContinuationNullPredicate_35;
	// System.Collections.Generic.Dictionary`2<System.Int32,System.Threading.Tasks.Task> System.Threading.Tasks.Task::s_currentActiveTasks
	Dictionary_2_t403063CE4960B4F46C688912237C6A27E550FF55* ___s_currentActiveTasks_36;
	// System.Object System.Threading.Tasks.Task::s_activeTasksLock
	RuntimeObject* ___s_activeTasksLock_37;
};

struct Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572_ThreadStaticFields
{
	// System.Threading.Tasks.Task System.Threading.Tasks.Task::t_currentTask
	Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572* ___t_currentTask_28;
	// System.Threading.Tasks.StackGuard System.Threading.Tasks.Task::t_stackGuard
	StackGuard_tACE063A1B7374BDF4AD472DE4585D05AD8745352* ___t_stackGuard_29;
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// System.Threading.Tasks.Task`1<System.Boolean>
struct Task_1_t824317F4B958F7512E8F7300511752937A6C6043  : public Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572
{
	// TResult System.Threading.Tasks.Task`1::m_result
	bool ___m_result_38;
};

struct Task_1_t824317F4B958F7512E8F7300511752937A6C6043_StaticFields
{
	// System.Threading.Tasks.TaskFactory`1<TResult> System.Threading.Tasks.Task`1::s_defaultFactory
	TaskFactory_1_tFAEAC22A1E986463E6956C344A78A7C7197288E0* ___s_defaultFactory_39;
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// System.Byte
struct Byte_t94D9231AC217BE4D2E004C4CD32DF6D099EA41A3 
{
	// System.Byte System.Byte::m_value
	uint8_t ___m_value_0;
};

// Microsoft.CodeAnalysis.EmbeddedAttribute
struct EmbeddedAttribute_t9265EBAEE5A94BFE10568D61CAB9D8E8EF163B39  : public Attribute_tFDA8EFEFB0711976D22474794576DAF28F7440AA
{
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
};

// System.Runtime.CompilerServices.IsUnmanagedAttribute
struct IsUnmanagedAttribute_t9D6DB26BA863EE5252773DB55457B2F24700E9B9  : public Attribute_tFDA8EFEFB0711976D22474794576DAF28F7440AA
{
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// System.Delegate
struct Delegate_t  : public RuntimeObject
{
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject* ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.IntPtr System.Delegate::interp_method
	intptr_t ___interp_method_7;
	// System.IntPtr System.Delegate::interp_invoke_impl
	intptr_t ___interp_invoke_impl_8;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t* ___method_info_9;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t* ___original_method_info_10;
	// System.DelegateData System.Delegate::data
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_12;
};
// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};

// System.Runtime.InteropServices.GCHandle
struct GCHandle_tC44F6F72EE68BD4CFABA24309DA7A179D41127DC 
{
	// System.IntPtr System.Runtime.InteropServices.GCHandle::handle
	intptr_t ___handle_0;
};

// NatSuite.Sharing.Internal.NativePayload
struct NativePayload_t6BA646CD27EAB43F98E63FCDE5B236FE1AF22DFE  : public RuntimeObject
{
	// System.IntPtr NatSuite.Sharing.Internal.NativePayload::payload
	intptr_t ___payload_0;
};

// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C  : public RuntimeObject
{
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;
};

struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_StaticFields
{
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;
};
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// System.MulticastDelegate
struct MulticastDelegate_t  : public Delegate_t
{
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771* ___delegates_13;
};
// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_13;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_13;
};

// NatSuite.Sharing.PrintPayload
struct PrintPayload_tB95D34D4C81CF445C73D8E88CDF09613854EC4A3  : public NativePayload_t6BA646CD27EAB43F98E63FCDE5B236FE1AF22DFE
{
};

// NatSuite.Sharing.SavePayload
struct SavePayload_tA351C0AE87F117EE45D72C6007552E4ABAC5AAF3  : public NativePayload_t6BA646CD27EAB43F98E63FCDE5B236FE1AF22DFE
{
};

// NatSuite.Sharing.SharePayload
struct SharePayload_t70A932F29157647E7DC8A51AEA00D3EB4395F9EB  : public NativePayload_t6BA646CD27EAB43F98E63FCDE5B236FE1AF22DFE
{
};

// UnityEngine.Texture
struct Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

struct Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700_StaticFields
{
	// System.Int32 UnityEngine.Texture::GenerateAllMips
	int32_t ___GenerateAllMips_4;
};

// System.AsyncCallback
struct AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C  : public MulticastDelegate_t
{
};

// UnityEngine.Texture2D
struct Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4  : public Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700
{
};

// NatSuite.Sharing.Internal.NatShare/CompletionHandler
struct CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690  : public MulticastDelegate_t
{
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif
// System.Byte[]
struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031  : public RuntimeArray
{
	ALIGN_FIELD (8) uint8_t m_Items[1];

	inline uint8_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline uint8_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, uint8_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline uint8_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline uint8_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, uint8_t value)
	{
		m_Items[index] = value;
	}
};
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771  : public RuntimeArray
{
	ALIGN_FIELD (8) Delegate_t* m_Items[1];

	inline Delegate_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Delegate_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Delegate_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Delegate_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};


// System.Threading.Tasks.Task`1<TResult> System.Threading.Tasks.Task::FromResult<System.Boolean>(TResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Task_1_t824317F4B958F7512E8F7300511752937A6C6043* Task_FromResult_TisBoolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_m390F8F1169B06A0B55B488C1C66A1539F6DD5D9B_gshared (bool ___result0, const RuntimeMethod* method) ;
// System.Void System.Threading.Tasks.TaskCompletionSource`1<System.Boolean>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TaskCompletionSource_1__ctor_mBAB8D6EFEAD1AA6482D19D7CE639528BE66AF646_gshared (TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14* __this, const RuntimeMethod* method) ;
// System.Threading.Tasks.Task`1<TResult> System.Threading.Tasks.TaskCompletionSource`1<System.Boolean>::get_Task()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Task_1_t824317F4B958F7512E8F7300511752937A6C6043* TaskCompletionSource_1_get_Task_m068E06095F165AE266E15C328CBDA1543429EC66_gshared_inline (TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14* __this, const RuntimeMethod* method) ;
// System.Void System.Threading.Tasks.TaskCompletionSource`1<System.Boolean>::SetResult(TResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TaskCompletionSource_1_SetResult_mA4C94A8605B8E4A2646C0C2B08A3D373E1174448_gshared (TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14* __this, bool ___result0, const RuntimeMethod* method) ;

// System.Void System.Attribute::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Attribute__ctor_m79ED1BF1EE36D1E417BA89A0D9F91F8AAD8D19E2 (Attribute_tFDA8EFEFB0711976D22474794576DAF28F7440AA* __this, const RuntimeMethod* method) ;
// System.IntPtr NatSuite.Sharing.PrintPayload::Create(System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t PrintPayload_Create_mCB3FB97196F34DC3EEEDAD80A68DD2D8639258F5 (bool ___color0, bool ___landscape1, const RuntimeMethod* method) ;
// System.Void NatSuite.Sharing.Internal.NativePayload::.ctor(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NativePayload__ctor_m7A0AA779573E6E3B1BD9F7BB08AA13A87AAE2347 (NativePayload_t6BA646CD27EAB43F98E63FCDE5B236FE1AF22DFE* __this, intptr_t ___payload0, const RuntimeMethod* method) ;
// UnityEngine.RuntimePlatform UnityEngine.Application::get_platform()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Application_get_platform_m59EF7D6155D18891B24767F83F388160B1FF2138 (const RuntimeMethod* method) ;
// System.Void NatSuite.Sharing.Internal.NatShare::CreatePrintPayload(System.Boolean,System.Boolean,System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NatShare_CreatePrintPayload_mCCA89A5A2E90461F509CFD6A6A7EB16DF658582B (bool ___color0, bool ___landscape1, intptr_t* ___payload2, const RuntimeMethod* method) ;
// System.String System.String::Format(System.String,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_mA8DBB4C2516B9723C5A41E6CB1E2FAF4BBE96DD8 (String_t* ___format0, RuntimeObject* ___arg01, const RuntimeMethod* method) ;
// System.Void UnityEngine.Debug::LogWarning(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogWarning_m33EF1B897E0C7C6FF538989610BFAFFEF4628CA9 (RuntimeObject* ___message0, const RuntimeMethod* method) ;
// System.IntPtr NatSuite.Sharing.SavePayload::Create(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t SavePayload_Create_mC9576BECF97E80829B0DDC50A1A3D0A382553E96 (String_t* ___album0, const RuntimeMethod* method) ;
// System.Void NatSuite.Sharing.Internal.NativePayload::AddText(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NativePayload_AddText_mBD9BBEDE0C3F4A9CFD43773CE585695BC119CA21 (NativePayload_t6BA646CD27EAB43F98E63FCDE5B236FE1AF22DFE* __this, String_t* ___text0, const RuntimeMethod* method) ;
// System.Void NatSuite.Sharing.Internal.NatShare::CreateSavePayload(System.String,System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NatShare_CreateSavePayload_m0A4DC0A2A5889C4E9623155DC88EECD28B83E646 (String_t* ___album0, intptr_t* ___payload1, const RuntimeMethod* method) ;
// System.IntPtr NatSuite.Sharing.SharePayload::Create()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t SharePayload_Create_mEC62769945A9D47869F8EA60C925A7316139FCDE (const RuntimeMethod* method) ;
// System.Void NatSuite.Sharing.Internal.NatShare::CreateSharePayload(System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NatShare_CreateSharePayload_m929593E58816E5DB881BDC85E7D64432F0633F5D (intptr_t* ___payload0, const RuntimeMethod* method) ;
// System.Void NatSuite.Sharing.Internal.NativePayload::OnCompletion(System.IntPtr,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NativePayload_OnCompletion_mB7CEB2F987365BBC864A74D259178D8E111F43A9 (intptr_t ___context0, bool ___success1, const RuntimeMethod* method) ;
// System.Boolean System.IntPtr::op_Inequality(System.IntPtr,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool IntPtr_op_Inequality_m90EFC9C4CAD9A33E309F2DDF98EE4E1DD253637B (intptr_t ___value10, intptr_t ___value21, const RuntimeMethod* method) ;
// System.Void NatSuite.Sharing.Internal.NatShare::AddText(System.IntPtr,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NatShare_AddText_mFA5218BCB89290F9BBE1C84C8D019E9DA1C55227 (intptr_t ___payload0, String_t* ___text1, const RuntimeMethod* method) ;
// System.Boolean System.IntPtr::op_Equality(System.IntPtr,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool IntPtr_op_Equality_m7D9CDCDE9DC2A0C2C614633F4921E90187FAB271 (intptr_t ___value10, intptr_t ___value21, const RuntimeMethod* method) ;
// System.Void UnityEngine.Debug::LogError(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2 (RuntimeObject* ___message0, const RuntimeMethod* method) ;
// System.Byte[] UnityEngine.ImageConversion::EncodeToJPG(UnityEngine.Texture2D)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ImageConversion_EncodeToJPG_mD3B358B8645CF85EBAD979554FFDE05A54A99804 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___tex0, const RuntimeMethod* method) ;
// System.Void NatSuite.Sharing.Internal.NatShare::AddImage(System.IntPtr,System.Byte[],System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NatShare_AddImage_m70F6826454722946A27D211A84554E90D6413F8A (intptr_t ___payload0, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___jpegData1, int32_t ___dataSize2, const RuntimeMethod* method) ;
// System.Void NatSuite.Sharing.Internal.NatShare::AddMedia(System.IntPtr,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NatShare_AddMedia_m2F44B763AD5C9B89BFBE8E3F07BACD80943AAE98 (intptr_t ___payload0, String_t* ___uri1, const RuntimeMethod* method) ;
// System.Threading.Tasks.Task`1<TResult> System.Threading.Tasks.Task::FromResult<System.Boolean>(TResult)
inline Task_1_t824317F4B958F7512E8F7300511752937A6C6043* Task_FromResult_TisBoolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_m390F8F1169B06A0B55B488C1C66A1539F6DD5D9B (bool ___result0, const RuntimeMethod* method)
{
	return ((  Task_1_t824317F4B958F7512E8F7300511752937A6C6043* (*) (bool, const RuntimeMethod*))Task_FromResult_TisBoolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_m390F8F1169B06A0B55B488C1C66A1539F6DD5D9B_gshared)(___result0, method);
}
// System.Void System.Threading.Tasks.TaskCompletionSource`1<System.Boolean>::.ctor()
inline void TaskCompletionSource_1__ctor_mBAB8D6EFEAD1AA6482D19D7CE639528BE66AF646 (TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14* __this, const RuntimeMethod* method)
{
	((  void (*) (TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14*, const RuntimeMethod*))TaskCompletionSource_1__ctor_mBAB8D6EFEAD1AA6482D19D7CE639528BE66AF646_gshared)(__this, method);
}
// System.Runtime.InteropServices.GCHandle System.Runtime.InteropServices.GCHandle::Alloc(System.Object,System.Runtime.InteropServices.GCHandleType)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GCHandle_tC44F6F72EE68BD4CFABA24309DA7A179D41127DC GCHandle_Alloc_m3BFD398427352FC756FFE078F01A504B681352EC (RuntimeObject* ___value0, int32_t ___type1, const RuntimeMethod* method) ;
// System.Void NatSuite.Sharing.Internal.NatShare/CompletionHandler::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CompletionHandler__ctor_m544DA25AB5F00FD9FCA0FBD146F2CB97964E435A (CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) ;
// System.IntPtr System.Runtime.InteropServices.GCHandle::op_Explicit(System.Runtime.InteropServices.GCHandle)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR intptr_t GCHandle_op_Explicit_m03DD8D9FB45D565431455A6EE5C30A87305EF73C_inline (GCHandle_tC44F6F72EE68BD4CFABA24309DA7A179D41127DC ___value0, const RuntimeMethod* method) ;
// System.Void NatSuite.Sharing.Internal.NatShare::Commit(System.IntPtr,NatSuite.Sharing.Internal.NatShare/CompletionHandler,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NatShare_Commit_m9079894963514B1EC4AD88ADB3786E6BFC1844D5 (intptr_t ___payload0, CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690* ___completionHandler1, intptr_t ___context2, const RuntimeMethod* method) ;
// System.Threading.Tasks.Task`1<TResult> System.Threading.Tasks.TaskCompletionSource`1<System.Boolean>::get_Task()
inline Task_1_t824317F4B958F7512E8F7300511752937A6C6043* TaskCompletionSource_1_get_Task_m068E06095F165AE266E15C328CBDA1543429EC66_inline (TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14* __this, const RuntimeMethod* method)
{
	return ((  Task_1_t824317F4B958F7512E8F7300511752937A6C6043* (*) (TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14*, const RuntimeMethod*))TaskCompletionSource_1_get_Task_m068E06095F165AE266E15C328CBDA1543429EC66_gshared_inline)(__this, method);
}
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
// System.Runtime.InteropServices.GCHandle System.Runtime.InteropServices.GCHandle::op_Explicit(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GCHandle_tC44F6F72EE68BD4CFABA24309DA7A179D41127DC GCHandle_op_Explicit_mA5F28206637454AD677BE13DF86C6152190B6F0F (intptr_t ___value0, const RuntimeMethod* method) ;
// System.Object System.Runtime.InteropServices.GCHandle::get_Target()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* GCHandle_get_Target_m481F9508DA5E384D33CD1F4450060DC56BBD4CD5 (GCHandle_tC44F6F72EE68BD4CFABA24309DA7A179D41127DC* __this, const RuntimeMethod* method) ;
// System.Void System.Runtime.InteropServices.GCHandle::Free()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GCHandle_Free_m1320A260E487EB1EA6D95F9E54BFFCB5A4EF83A3 (GCHandle_tC44F6F72EE68BD4CFABA24309DA7A179D41127DC* __this, const RuntimeMethod* method) ;
// System.Void System.Threading.Tasks.TaskCompletionSource`1<System.Boolean>::SetResult(TResult)
inline void TaskCompletionSource_1_SetResult_mA4C94A8605B8E4A2646C0C2B08A3D373E1174448 (TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14* __this, bool ___result0, const RuntimeMethod* method)
{
	((  void (*) (TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14*, bool, const RuntimeMethod*))TaskCompletionSource_1_SetResult_mA4C94A8605B8E4A2646C0C2B08A3D373E1174448_gshared)(__this, ___result0, method);
}
IL2CPP_EXTERN_C void DEFAULT_CALL NSSharePayloadAddText(intptr_t, char*);
IL2CPP_EXTERN_C void DEFAULT_CALL NSSharePayloadAddImage(intptr_t, uint8_t*, int32_t);
IL2CPP_EXTERN_C void DEFAULT_CALL NSSharePayloadAddMedia(intptr_t, char*);
IL2CPP_EXTERN_C void DEFAULT_CALL NSSharePayloadCommit(intptr_t, Il2CppMethodPointer, intptr_t);
IL2CPP_EXTERN_C void DEFAULT_CALL NSCreateSharePayload(intptr_t*);
IL2CPP_EXTERN_C void DEFAULT_CALL NSCreateSavePayload(char*, intptr_t*);
IL2CPP_EXTERN_C void DEFAULT_CALL NSCreatePrintPayload(int32_t, int32_t, intptr_t*);
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EmbeddedAttribute__ctor_m09BC71B5BEAE60BDE53B766D866B4740D4883B6D (EmbeddedAttribute_t9265EBAEE5A94BFE10568D61CAB9D8E8EF163B39* __this, const RuntimeMethod* method) 
{
	{
		Attribute__ctor_m79ED1BF1EE36D1E417BA89A0D9F91F8AAD8D19E2(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void System.Runtime.CompilerServices.IsUnmanagedAttribute::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void IsUnmanagedAttribute__ctor_mF785903AAE037A336A5A7600B0A025CC57C7295F (IsUnmanagedAttribute_t9D6DB26BA863EE5252773DB55457B2F24700E9B9* __this, const RuntimeMethod* method) 
{
	{
		Attribute__ctor_m79ED1BF1EE36D1E417BA89A0D9F91F8AAD8D19E2(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void NatSuite.Sharing.PrintPayload::.ctor(System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PrintPayload__ctor_m29CBDECCBEF1B09065DFC677BA2D92900B2CCBC5 (PrintPayload_tB95D34D4C81CF445C73D8E88CDF09613854EC4A3* __this, bool ___color0, bool ___landscape1, const RuntimeMethod* method) 
{
	{
		// public PrintPayload (bool color = true, bool landscape = false) : base(Create(color, landscape)) { }
		bool L_0 = ___color0;
		bool L_1 = ___landscape1;
		intptr_t L_2;
		L_2 = PrintPayload_Create_mCB3FB97196F34DC3EEEDAD80A68DD2D8639258F5(L_0, L_1, NULL);
		NativePayload__ctor_m7A0AA779573E6E3B1BD9F7BB08AA13A87AAE2347(__this, L_2, NULL);
		// public PrintPayload (bool color = true, bool landscape = false) : base(Create(color, landscape)) { }
		return;
	}
}
// System.IntPtr NatSuite.Sharing.PrintPayload::Create(System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t PrintPayload_Create_mCB3FB97196F34DC3EEEDAD80A68DD2D8639258F5 (bool ___color0, bool ___landscape1, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IntPtr_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimePlatform_t9A8AAF204603076FCAAECCCC05DA386AEE7BF66E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1E1246962420BA0009704AC0055549B0249109EC);
		s_Il2CppMethodInitialized = true;
	}
	intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	int32_t V_1 = 0;
	{
		// switch (Application.platform) {
		int32_t L_0;
		L_0 = Application_get_platform_m59EF7D6155D18891B24767F83F388160B1FF2138(NULL);
		V_1 = L_0;
		int32_t L_1 = V_1;
		if ((((int32_t)L_1) == ((int32_t)8)))
		{
			goto IL_000f;
		}
	}
	{
		int32_t L_2 = V_1;
		if ((!(((uint32_t)L_2) == ((uint32_t)((int32_t)11)))))
		{
			goto IL_001a;
		}
	}

IL_000f:
	{
		// NatShare.CreatePrintPayload(color, landscape, out var payload);
		bool L_3 = ___color0;
		bool L_4 = ___landscape1;
		NatShare_CreatePrintPayload_mCCA89A5A2E90461F509CFD6A6A7EB16DF658582B(L_3, L_4, (&V_0), NULL);
		// return payload;
		intptr_t L_5 = V_0;
		return L_5;
	}

IL_001a:
	{
		// Debug.LogWarning($"NatShare: PrintPayload is not supported on {Application.platform}");
		int32_t L_6;
		L_6 = Application_get_platform_m59EF7D6155D18891B24767F83F388160B1FF2138(NULL);
		int32_t L_7 = L_6;
		RuntimeObject* L_8 = Box(RuntimePlatform_t9A8AAF204603076FCAAECCCC05DA386AEE7BF66E_il2cpp_TypeInfo_var, &L_7);
		String_t* L_9;
		L_9 = String_Format_mA8DBB4C2516B9723C5A41E6CB1E2FAF4BBE96DD8(_stringLiteral1E1246962420BA0009704AC0055549B0249109EC, L_8, NULL);
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogWarning_m33EF1B897E0C7C6FF538989610BFAFFEF4628CA9(L_9, NULL);
		// return IntPtr.Zero;
		intptr_t L_10 = ((IntPtr_t_StaticFields*)il2cpp_codegen_static_fields_for(IntPtr_t_il2cpp_TypeInfo_var))->___Zero_1;
		return L_10;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void NatSuite.Sharing.SavePayload::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SavePayload__ctor_mC5090EA56D52BBC6997DAC29D1F5DD21E8F390EF (SavePayload_tA351C0AE87F117EE45D72C6007552E4ABAC5AAF3* __this, String_t* ___album0, const RuntimeMethod* method) 
{
	{
		// public SavePayload (string album = default) : base(Create(album)) { }
		String_t* L_0 = ___album0;
		intptr_t L_1;
		L_1 = SavePayload_Create_mC9576BECF97E80829B0DDC50A1A3D0A382553E96(L_0, NULL);
		NativePayload__ctor_m7A0AA779573E6E3B1BD9F7BB08AA13A87AAE2347(__this, L_1, NULL);
		// public SavePayload (string album = default) : base(Create(album)) { }
		return;
	}
}
// System.Void NatSuite.Sharing.SavePayload::AddText(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SavePayload_AddText_m8DDC3035E106222BB2F69223693B5C4CDB3762E8 (SavePayload_tA351C0AE87F117EE45D72C6007552E4ABAC5AAF3* __this, String_t* ___text0, const RuntimeMethod* method) 
{
	{
		// public override void AddText (string text) => base.AddText(text);
		String_t* L_0 = ___text0;
		NativePayload_AddText_mBD9BBEDE0C3F4A9CFD43773CE585695BC119CA21(__this, L_0, NULL);
		return;
	}
}
// System.IntPtr NatSuite.Sharing.SavePayload::Create(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t SavePayload_Create_mC9576BECF97E80829B0DDC50A1A3D0A382553E96 (String_t* ___album0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IntPtr_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimePlatform_t9A8AAF204603076FCAAECCCC05DA386AEE7BF66E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA8E6CD7671815F92F64A76C69771D7003226F136);
		s_Il2CppMethodInitialized = true;
	}
	intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	int32_t V_1 = 0;
	{
		// switch (Application.platform) {
		int32_t L_0;
		L_0 = Application_get_platform_m59EF7D6155D18891B24767F83F388160B1FF2138(NULL);
		V_1 = L_0;
		int32_t L_1 = V_1;
		if ((((int32_t)L_1) == ((int32_t)8)))
		{
			goto IL_000f;
		}
	}
	{
		int32_t L_2 = V_1;
		if ((!(((uint32_t)L_2) == ((uint32_t)((int32_t)11)))))
		{
			goto IL_0019;
		}
	}

IL_000f:
	{
		// NatShare.CreateSavePayload(album, out var payload);
		String_t* L_3 = ___album0;
		NatShare_CreateSavePayload_m0A4DC0A2A5889C4E9623155DC88EECD28B83E646(L_3, (&V_0), NULL);
		// return payload;
		intptr_t L_4 = V_0;
		return L_4;
	}

IL_0019:
	{
		// Debug.LogWarning($"NatShare: SavePayload is not supported on {Application.platform}");
		int32_t L_5;
		L_5 = Application_get_platform_m59EF7D6155D18891B24767F83F388160B1FF2138(NULL);
		int32_t L_6 = L_5;
		RuntimeObject* L_7 = Box(RuntimePlatform_t9A8AAF204603076FCAAECCCC05DA386AEE7BF66E_il2cpp_TypeInfo_var, &L_6);
		String_t* L_8;
		L_8 = String_Format_mA8DBB4C2516B9723C5A41E6CB1E2FAF4BBE96DD8(_stringLiteralA8E6CD7671815F92F64A76C69771D7003226F136, L_7, NULL);
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogWarning_m33EF1B897E0C7C6FF538989610BFAFFEF4628CA9(L_8, NULL);
		// return IntPtr.Zero;
		intptr_t L_9 = ((IntPtr_t_StaticFields*)il2cpp_codegen_static_fields_for(IntPtr_t_il2cpp_TypeInfo_var))->___Zero_1;
		return L_9;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void NatSuite.Sharing.SharePayload::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SharePayload__ctor_mF4BF61BFB619E79E958F6E8256113E319ED8AC2D (SharePayload_t70A932F29157647E7DC8A51AEA00D3EB4395F9EB* __this, const RuntimeMethod* method) 
{
	{
		// public SharePayload () : base(Create()) { }
		intptr_t L_0;
		L_0 = SharePayload_Create_mEC62769945A9D47869F8EA60C925A7316139FCDE(NULL);
		NativePayload__ctor_m7A0AA779573E6E3B1BD9F7BB08AA13A87AAE2347(__this, L_0, NULL);
		// public SharePayload () : base(Create()) { }
		return;
	}
}
// System.IntPtr NatSuite.Sharing.SharePayload::Create()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t SharePayload_Create_mEC62769945A9D47869F8EA60C925A7316139FCDE (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IntPtr_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimePlatform_t9A8AAF204603076FCAAECCCC05DA386AEE7BF66E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral20FC19F814D4953B75471571F60DF8EC6A7A6A0E);
		s_Il2CppMethodInitialized = true;
	}
	intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	int32_t V_1 = 0;
	{
		// switch (Application.platform) {
		int32_t L_0;
		L_0 = Application_get_platform_m59EF7D6155D18891B24767F83F388160B1FF2138(NULL);
		V_1 = L_0;
		int32_t L_1 = V_1;
		if ((((int32_t)L_1) == ((int32_t)8)))
		{
			goto IL_000f;
		}
	}
	{
		int32_t L_2 = V_1;
		if ((!(((uint32_t)L_2) == ((uint32_t)((int32_t)11)))))
		{
			goto IL_0018;
		}
	}

IL_000f:
	{
		// NatShare.CreateSharePayload(out var payload);
		NatShare_CreateSharePayload_m929593E58816E5DB881BDC85E7D64432F0633F5D((&V_0), NULL);
		// return payload;
		intptr_t L_3 = V_0;
		return L_3;
	}

IL_0018:
	{
		// Debug.LogWarning($"NatShare: SharePayload is not supported on {Application.platform}");
		int32_t L_4;
		L_4 = Application_get_platform_m59EF7D6155D18891B24767F83F388160B1FF2138(NULL);
		int32_t L_5 = L_4;
		RuntimeObject* L_6 = Box(RuntimePlatform_t9A8AAF204603076FCAAECCCC05DA386AEE7BF66E_il2cpp_TypeInfo_var, &L_5);
		String_t* L_7;
		L_7 = String_Format_mA8DBB4C2516B9723C5A41E6CB1E2FAF4BBE96DD8(_stringLiteral20FC19F814D4953B75471571F60DF8EC6A7A6A0E, L_6, NULL);
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogWarning_m33EF1B897E0C7C6FF538989610BFAFFEF4628CA9(L_7, NULL);
		// return IntPtr.Zero;
		intptr_t L_8 = ((IntPtr_t_StaticFields*)il2cpp_codegen_static_fields_for(IntPtr_t_il2cpp_TypeInfo_var))->___Zero_1;
		return L_8;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_NativePayload_OnCompletion_mB7CEB2F987365BBC864A74D259178D8E111F43A9(intptr_t ___context0, int32_t ___success1)
{
	il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

	// Managed method invocation
	NativePayload_OnCompletion_mB7CEB2F987365BBC864A74D259178D8E111F43A9(___context0, static_cast<bool>(___success1), NULL);

}
// System.Boolean NatSuite.Sharing.Internal.NativePayload::get_Supported()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NativePayload_get_Supported_mAA3B4213FD3E519EAC0C7A67C3CBD92A30C81C4C (const RuntimeMethod* method) 
{
	{
		// public static bool Supported => Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer;
		int32_t L_0;
		L_0 = Application_get_platform_m59EF7D6155D18891B24767F83F388160B1FF2138(NULL);
		if ((((int32_t)L_0) == ((int32_t)((int32_t)11))))
		{
			goto IL_0012;
		}
	}
	{
		int32_t L_1;
		L_1 = Application_get_platform_m59EF7D6155D18891B24767F83F388160B1FF2138(NULL);
		return (bool)((((int32_t)L_1) == ((int32_t)8))? 1 : 0);
	}

IL_0012:
	{
		return (bool)1;
	}
}
// System.Void NatSuite.Sharing.Internal.NativePayload::AddText(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NativePayload_AddText_mBD9BBEDE0C3F4A9CFD43773CE585695BC119CA21 (NativePayload_t6BA646CD27EAB43F98E63FCDE5B236FE1AF22DFE* __this, String_t* ___text0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IntPtr_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (payload != IntPtr.Zero)
		intptr_t L_0 = __this->___payload_0;
		intptr_t L_1 = ((IntPtr_t_StaticFields*)il2cpp_codegen_static_fields_for(IntPtr_t_il2cpp_TypeInfo_var))->___Zero_1;
		bool L_2;
		L_2 = IntPtr_op_Inequality_m90EFC9C4CAD9A33E309F2DDF98EE4E1DD253637B(L_0, L_1, NULL);
		if (!L_2)
		{
			goto IL_001e;
		}
	}
	{
		// payload.AddText(text);
		intptr_t L_3 = __this->___payload_0;
		String_t* L_4 = ___text0;
		NatShare_AddText_mFA5218BCB89290F9BBE1C84C8D019E9DA1C55227(L_3, L_4, NULL);
	}

IL_001e:
	{
		// }
		return;
	}
}
// System.Void NatSuite.Sharing.Internal.NativePayload::AddImage(UnityEngine.Texture2D)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NativePayload_AddImage_mE66546E2FD46BBCC7EBFF8CF645E641FF9FA8258 (NativePayload_t6BA646CD27EAB43F98E63FCDE5B236FE1AF22DFE* __this, Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___image0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IntPtr_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0ECA1F1B3EAFB7AB365A952126A44D4B20673360);
		s_Il2CppMethodInitialized = true;
	}
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	{
		// if (payload == IntPtr.Zero)
		intptr_t L_0 = __this->___payload_0;
		intptr_t L_1 = ((IntPtr_t_StaticFields*)il2cpp_codegen_static_fields_for(IntPtr_t_il2cpp_TypeInfo_var))->___Zero_1;
		bool L_2;
		L_2 = IntPtr_op_Equality_m7D9CDCDE9DC2A0C2C614633F4921E90187FAB271(L_0, L_1, NULL);
		if (!L_2)
		{
			goto IL_0013;
		}
	}
	{
		// return;
		return;
	}

IL_0013:
	{
		// if (!image.isReadable) {
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_3 = ___image0;
		NullCheck(L_3);
		bool L_4;
		L_4 = VirtualFuncInvoker0< bool >::Invoke(8 /* System.Boolean UnityEngine.Texture::get_isReadable() */, L_3);
		if (L_4)
		{
			goto IL_0026;
		}
	}
	{
		// Debug.LogError("NatShare Error: Cannot add non-readable texture to payload");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2(_stringLiteral0ECA1F1B3EAFB7AB365A952126A44D4B20673360, NULL);
		// return;
		return;
	}

IL_0026:
	{
		// var jpegData = ImageConversion.EncodeToJPG(image); // Faster than PNG #85
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_5 = ___image0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_6;
		L_6 = ImageConversion_EncodeToJPG_mD3B358B8645CF85EBAD979554FFDE05A54A99804(L_5, NULL);
		V_0 = L_6;
		// payload.AddImage(jpegData, jpegData.Length);
		intptr_t L_7 = __this->___payload_0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_8 = V_0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_9 = V_0;
		NullCheck(L_9);
		NatShare_AddImage_m70F6826454722946A27D211A84554E90D6413F8A(L_7, L_8, ((int32_t)(((RuntimeArray*)L_9)->max_length)), NULL);
		// }
		return;
	}
}
// System.Void NatSuite.Sharing.Internal.NativePayload::AddMedia(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NativePayload_AddMedia_mD93BBAA0FBF19B0D7143CAB7D3AAE15E0682EE49 (NativePayload_t6BA646CD27EAB43F98E63FCDE5B236FE1AF22DFE* __this, String_t* ___uri0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IntPtr_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (payload != IntPtr.Zero)
		intptr_t L_0 = __this->___payload_0;
		intptr_t L_1 = ((IntPtr_t_StaticFields*)il2cpp_codegen_static_fields_for(IntPtr_t_il2cpp_TypeInfo_var))->___Zero_1;
		bool L_2;
		L_2 = IntPtr_op_Inequality_m90EFC9C4CAD9A33E309F2DDF98EE4E1DD253637B(L_0, L_1, NULL);
		if (!L_2)
		{
			goto IL_001e;
		}
	}
	{
		// payload.AddMedia(uri);
		intptr_t L_3 = __this->___payload_0;
		String_t* L_4 = ___uri0;
		NatShare_AddMedia_m2F44B763AD5C9B89BFBE8E3F07BACD80943AAE98(L_3, L_4, NULL);
	}

IL_001e:
	{
		// }
		return;
	}
}
// System.Threading.Tasks.Task`1<System.Boolean> NatSuite.Sharing.Internal.NativePayload::Commit()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Task_1_t824317F4B958F7512E8F7300511752937A6C6043* NativePayload_Commit_m165AA2465ED290F6DF1BDB7569C580226739ABC8 (NativePayload_t6BA646CD27EAB43F98E63FCDE5B236FE1AF22DFE* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IntPtr_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NativePayload_OnCompletion_mB7CEB2F987365BBC864A74D259178D8E111F43A9_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TaskCompletionSource_1__ctor_mBAB8D6EFEAD1AA6482D19D7CE639528BE66AF646_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TaskCompletionSource_1_get_Task_m068E06095F165AE266E15C328CBDA1543429EC66_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Task_FromResult_TisBoolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_m390F8F1169B06A0B55B488C1C66A1539F6DD5D9B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	GCHandle_tC44F6F72EE68BD4CFABA24309DA7A179D41127DC V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		// if (payload == IntPtr.Zero)
		intptr_t L_0 = __this->___payload_0;
		intptr_t L_1 = ((IntPtr_t_StaticFields*)il2cpp_codegen_static_fields_for(IntPtr_t_il2cpp_TypeInfo_var))->___Zero_1;
		bool L_2;
		L_2 = IntPtr_op_Equality_m7D9CDCDE9DC2A0C2C614633F4921E90187FAB271(L_0, L_1, NULL);
		if (!L_2)
		{
			goto IL_0019;
		}
	}
	{
		// return Task.FromResult(false);
		il2cpp_codegen_runtime_class_init_inline(Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572_il2cpp_TypeInfo_var);
		Task_1_t824317F4B958F7512E8F7300511752937A6C6043* L_3;
		L_3 = Task_FromResult_TisBoolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_m390F8F1169B06A0B55B488C1C66A1539F6DD5D9B((bool)0, Task_FromResult_TisBoolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_m390F8F1169B06A0B55B488C1C66A1539F6DD5D9B_RuntimeMethod_var);
		return L_3;
	}

IL_0019:
	{
		// var commitTask = new TaskCompletionSource<bool>();
		TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14* L_4 = (TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14*)il2cpp_codegen_object_new(TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14_il2cpp_TypeInfo_var);
		NullCheck(L_4);
		TaskCompletionSource_1__ctor_mBAB8D6EFEAD1AA6482D19D7CE639528BE66AF646(L_4, TaskCompletionSource_1__ctor_mBAB8D6EFEAD1AA6482D19D7CE639528BE66AF646_RuntimeMethod_var);
		// var handle = GCHandle.Alloc(commitTask, GCHandleType.Normal);
		TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14* L_5 = L_4;
		GCHandle_tC44F6F72EE68BD4CFABA24309DA7A179D41127DC L_6;
		L_6 = GCHandle_Alloc_m3BFD398427352FC756FFE078F01A504B681352EC(L_5, 2, NULL);
		V_0 = L_6;
		// payload.Commit(OnCompletion, (IntPtr)handle);
		intptr_t L_7 = __this->___payload_0;
		CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690* L_8 = (CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690*)il2cpp_codegen_object_new(CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690_il2cpp_TypeInfo_var);
		NullCheck(L_8);
		CompletionHandler__ctor_m544DA25AB5F00FD9FCA0FBD146F2CB97964E435A(L_8, NULL, (intptr_t)((void*)NativePayload_OnCompletion_mB7CEB2F987365BBC864A74D259178D8E111F43A9_RuntimeMethod_var), NULL);
		GCHandle_tC44F6F72EE68BD4CFABA24309DA7A179D41127DC L_9 = V_0;
		intptr_t L_10;
		L_10 = GCHandle_op_Explicit_m03DD8D9FB45D565431455A6EE5C30A87305EF73C_inline(L_9, NULL);
		NatShare_Commit_m9079894963514B1EC4AD88ADB3786E6BFC1844D5(L_7, L_8, L_10, NULL);
		// return commitTask.Task;
		NullCheck(L_5);
		Task_1_t824317F4B958F7512E8F7300511752937A6C6043* L_11;
		L_11 = TaskCompletionSource_1_get_Task_m068E06095F165AE266E15C328CBDA1543429EC66_inline(L_5, TaskCompletionSource_1_get_Task_m068E06095F165AE266E15C328CBDA1543429EC66_RuntimeMethod_var);
		return L_11;
	}
}
// System.Void NatSuite.Sharing.Internal.NativePayload::.ctor(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NativePayload__ctor_m7A0AA779573E6E3B1BD9F7BB08AA13A87AAE2347 (NativePayload_t6BA646CD27EAB43F98E63FCDE5B236FE1AF22DFE* __this, intptr_t ___payload0, const RuntimeMethod* method) 
{
	{
		// protected NativePayload (IntPtr payload) => this.payload = payload;
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// protected NativePayload (IntPtr payload) => this.payload = payload;
		intptr_t L_0 = ___payload0;
		__this->___payload_0 = L_0;
		return;
	}
}
// System.Void NatSuite.Sharing.Internal.NativePayload::OnCompletion(System.IntPtr,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NativePayload_OnCompletion_mB7CEB2F987365BBC864A74D259178D8E111F43A9 (intptr_t ___context0, bool ___success1, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TaskCompletionSource_1_SetResult_mA4C94A8605B8E4A2646C0C2B08A3D373E1174448_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	GCHandle_tC44F6F72EE68BD4CFABA24309DA7A179D41127DC V_0;
	memset((&V_0), 0, sizeof(V_0));
	TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14* G_B2_0 = NULL;
	TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14* G_B1_0 = NULL;
	{
		// var handle = (GCHandle)context;
		intptr_t L_0 = ___context0;
		GCHandle_tC44F6F72EE68BD4CFABA24309DA7A179D41127DC L_1;
		L_1 = GCHandle_op_Explicit_mA5F28206637454AD677BE13DF86C6152190B6F0F(L_0, NULL);
		V_0 = L_1;
		// var commitTask = handle.Target as TaskCompletionSource<bool>;
		RuntimeObject* L_2;
		L_2 = GCHandle_get_Target_m481F9508DA5E384D33CD1F4450060DC56BBD4CD5((&V_0), NULL);
		// handle.Free();
		GCHandle_Free_m1320A260E487EB1EA6D95F9E54BFFCB5A4EF83A3((&V_0), NULL);
		// commitTask?.SetResult(success);
		TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14* L_3 = ((TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14*)IsInstClass((RuntimeObject*)L_2, TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14_il2cpp_TypeInfo_var));
		G_B1_0 = L_3;
		if (L_3)
		{
			G_B2_0 = L_3;
			goto IL_001f;
		}
	}
	{
		return;
	}

IL_001f:
	{
		bool L_4 = ___success1;
		NullCheck(G_B2_0);
		TaskCompletionSource_1_SetResult_mA4C94A8605B8E4A2646C0C2B08A3D373E1174448(G_B2_0, L_4, TaskCompletionSource_1_SetResult_mA4C94A8605B8E4A2646C0C2B08A3D373E1174448_RuntimeMethod_var);
		// }
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void NatSuite.Sharing.Internal.NatShare::AddText(System.IntPtr,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NatShare_AddText_mFA5218BCB89290F9BBE1C84C8D019E9DA1C55227 (intptr_t ___payload0, String_t* ___text1, const RuntimeMethod* method) 
{
	typedef void (DEFAULT_CALL *PInvokeFunc) (intptr_t, char*);

	// Marshaling of parameter '___text1' to native representation
	char* ____text1_marshaled = NULL;
	____text1_marshaled = il2cpp_codegen_marshal_string(___text1);

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(NSSharePayloadAddText)(___payload0, ____text1_marshaled);

	// Marshaling cleanup of parameter '___text1' native representation
	il2cpp_codegen_marshal_free(____text1_marshaled);
	____text1_marshaled = NULL;

}
// System.Void NatSuite.Sharing.Internal.NatShare::AddImage(System.IntPtr,System.Byte[],System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NatShare_AddImage_m70F6826454722946A27D211A84554E90D6413F8A (intptr_t ___payload0, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___jpegData1, int32_t ___dataSize2, const RuntimeMethod* method) 
{
	typedef void (DEFAULT_CALL *PInvokeFunc) (intptr_t, uint8_t*, int32_t);

	// Marshaling of parameter '___jpegData1' to native representation
	uint8_t* ____jpegData1_marshaled = NULL;
	if (___jpegData1 != NULL)
	{
		____jpegData1_marshaled = reinterpret_cast<uint8_t*>((___jpegData1)->GetAddressAtUnchecked(0));
	}

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(NSSharePayloadAddImage)(___payload0, ____jpegData1_marshaled, ___dataSize2);

}
// System.Void NatSuite.Sharing.Internal.NatShare::AddMedia(System.IntPtr,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NatShare_AddMedia_m2F44B763AD5C9B89BFBE8E3F07BACD80943AAE98 (intptr_t ___payload0, String_t* ___uri1, const RuntimeMethod* method) 
{
	typedef void (DEFAULT_CALL *PInvokeFunc) (intptr_t, char*);

	// Marshaling of parameter '___uri1' to native representation
	char* ____uri1_marshaled = NULL;
	____uri1_marshaled = il2cpp_codegen_marshal_string(___uri1);

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(NSSharePayloadAddMedia)(___payload0, ____uri1_marshaled);

	// Marshaling cleanup of parameter '___uri1' native representation
	il2cpp_codegen_marshal_free(____uri1_marshaled);
	____uri1_marshaled = NULL;

}
// System.Void NatSuite.Sharing.Internal.NatShare::Commit(System.IntPtr,NatSuite.Sharing.Internal.NatShare/CompletionHandler,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NatShare_Commit_m9079894963514B1EC4AD88ADB3786E6BFC1844D5 (intptr_t ___payload0, CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690* ___completionHandler1, intptr_t ___context2, const RuntimeMethod* method) 
{
	typedef void (DEFAULT_CALL *PInvokeFunc) (intptr_t, Il2CppMethodPointer, intptr_t);

	// Marshaling of parameter '___completionHandler1' to native representation
	Il2CppMethodPointer ____completionHandler1_marshaled = NULL;
	____completionHandler1_marshaled = il2cpp_codegen_marshal_delegate(reinterpret_cast<MulticastDelegate_t*>(___completionHandler1));

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(NSSharePayloadCommit)(___payload0, ____completionHandler1_marshaled, ___context2);

}
// System.Void NatSuite.Sharing.Internal.NatShare::CreateSharePayload(System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NatShare_CreateSharePayload_m929593E58816E5DB881BDC85E7D64432F0633F5D (intptr_t* ___payload0, const RuntimeMethod* method) 
{
	typedef void (DEFAULT_CALL *PInvokeFunc) (intptr_t*);

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(NSCreateSharePayload)(___payload0);

}
// System.Void NatSuite.Sharing.Internal.NatShare::CreateSavePayload(System.String,System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NatShare_CreateSavePayload_m0A4DC0A2A5889C4E9623155DC88EECD28B83E646 (String_t* ___album0, intptr_t* ___payload1, const RuntimeMethod* method) 
{
	typedef void (DEFAULT_CALL *PInvokeFunc) (char*, intptr_t*);

	// Marshaling of parameter '___album0' to native representation
	char* ____album0_marshaled = NULL;
	____album0_marshaled = il2cpp_codegen_marshal_string(___album0);

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(NSCreateSavePayload)(____album0_marshaled, ___payload1);

	// Marshaling cleanup of parameter '___album0' native representation
	il2cpp_codegen_marshal_free(____album0_marshaled);
	____album0_marshaled = NULL;

}
// System.Void NatSuite.Sharing.Internal.NatShare::CreatePrintPayload(System.Boolean,System.Boolean,System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NatShare_CreatePrintPayload_mCCA89A5A2E90461F509CFD6A6A7EB16DF658582B (bool ___color0, bool ___landscape1, intptr_t* ___payload2, const RuntimeMethod* method) 
{
	typedef void (DEFAULT_CALL *PInvokeFunc) (int32_t, int32_t, intptr_t*);

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(NSCreatePrintPayload)(static_cast<int32_t>(___color0), static_cast<int32_t>(___landscape1), ___payload2);

}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void CompletionHandler_Invoke_m0B11E835BF78B7434CFE627937918F0195C878EC_Multicast(CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690* __this, intptr_t ___context0, bool ___success1, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates_13->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates_13->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690* currentDelegate = reinterpret_cast<CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, intptr_t, bool, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl_1)((Il2CppObject*)currentDelegate->___method_code_6, ___context0, ___success1, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method_3));
	}
}
void CompletionHandler_Invoke_m0B11E835BF78B7434CFE627937918F0195C878EC_OpenInst(CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690* __this, intptr_t ___context0, bool ___success1, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (intptr_t, bool, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(___context0, ___success1, method);
}
void CompletionHandler_Invoke_m0B11E835BF78B7434CFE627937918F0195C878EC_OpenStatic(CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690* __this, intptr_t ___context0, bool ___success1, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (intptr_t, bool, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(___context0, ___success1, method);
}
void CompletionHandler_Invoke_m0B11E835BF78B7434CFE627937918F0195C878EC_OpenStaticInvoker(CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690* __this, intptr_t ___context0, bool ___success1, const RuntimeMethod* method)
{
	InvokerActionInvoker2< intptr_t, bool >::Invoke(__this->___method_ptr_0, method, NULL, ___context0, ___success1);
}
void CompletionHandler_Invoke_m0B11E835BF78B7434CFE627937918F0195C878EC_ClosedStaticInvoker(CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690* __this, intptr_t ___context0, bool ___success1, const RuntimeMethod* method)
{
	InvokerActionInvoker3< RuntimeObject*, intptr_t, bool >::Invoke(__this->___method_ptr_0, method, NULL, __this->___m_target_2, ___context0, ___success1);
}
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690 (CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690* __this, intptr_t ___context0, bool ___success1, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)(intptr_t, int32_t);
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_reverse_pinvoke_function_ptr(__this));
	// Native function invocation
	il2cppPInvokeFunc(___context0, static_cast<int32_t>(___success1));

}
// System.Void NatSuite.Sharing.Internal.NatShare/CompletionHandler::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CompletionHandler__ctor_m544DA25AB5F00FD9FCA0FBD146F2CB97964E435A (CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) 
{
	__this->___method_ptr_0 = il2cpp_codegen_get_virtual_call_method_pointer((RuntimeMethod*)___method1);
	__this->___method_3 = ___method1;
	__this->___m_target_2 = ___object0;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target_2), (void*)___object0);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___method1);
	__this->___method_code_6 = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___method1))
	{
		bool isOpen = parameterCount == 2;
		if (il2cpp_codegen_call_method_via_invoker((RuntimeMethod*)___method1))
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&CompletionHandler_Invoke_m0B11E835BF78B7434CFE627937918F0195C878EC_OpenStaticInvoker;
			else
				__this->___invoke_impl_1 = (intptr_t)&CompletionHandler_Invoke_m0B11E835BF78B7434CFE627937918F0195C878EC_ClosedStaticInvoker;
		else
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&CompletionHandler_Invoke_m0B11E835BF78B7434CFE627937918F0195C878EC_OpenStatic;
			else
				{
					__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
					__this->___method_code_6 = (intptr_t)__this->___m_target_2;
				}
	}
	else
	{
		if (___object0 == NULL)
			il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
		__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
		__this->___method_code_6 = (intptr_t)__this->___m_target_2;
	}
	__this->___extra_arg_5 = (intptr_t)&CompletionHandler_Invoke_m0B11E835BF78B7434CFE627937918F0195C878EC_Multicast;
}
// System.Void NatSuite.Sharing.Internal.NatShare/CompletionHandler::Invoke(System.IntPtr,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CompletionHandler_Invoke_m0B11E835BF78B7434CFE627937918F0195C878EC (CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690* __this, intptr_t ___context0, bool ___success1, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, intptr_t, bool, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___context0, ___success1, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
// System.IAsyncResult NatSuite.Sharing.Internal.NatShare/CompletionHandler::BeginInvoke(System.IntPtr,System.Boolean,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* CompletionHandler_BeginInvoke_m7A22897DB397E0257D0A89409BD096A026275F34 (CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690* __this, intptr_t ___context0, bool ___success1, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___callback2, RuntimeObject* ___object3, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IntPtr_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	void *__d_args[3] = {0};
	__d_args[0] = Box(IntPtr_t_il2cpp_TypeInfo_var, &___context0);
	__d_args[1] = Box(Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_il2cpp_TypeInfo_var, &___success1);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback2, (RuntimeObject*)___object3);
}
// System.Void NatSuite.Sharing.Internal.NatShare/CompletionHandler::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CompletionHandler_EndInvoke_mC3755D1F8AF01F551C40B03DDA2D897E167AA89D (CompletionHandler_t1CB668784830E87AA0E3CB641F997CA322547690* __this, RuntimeObject* ___result0, const RuntimeMethod* method) 
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR intptr_t GCHandle_op_Explicit_m03DD8D9FB45D565431455A6EE5C30A87305EF73C_inline (GCHandle_tC44F6F72EE68BD4CFABA24309DA7A179D41127DC ___value0, const RuntimeMethod* method) 
{
	{
		GCHandle_tC44F6F72EE68BD4CFABA24309DA7A179D41127DC L_0 = ___value0;
		intptr_t L_1 = L_0.___handle_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Task_1_t824317F4B958F7512E8F7300511752937A6C6043* TaskCompletionSource_1_get_Task_m068E06095F165AE266E15C328CBDA1543429EC66_gshared_inline (TaskCompletionSource_1_t486CD8AD64929E5C47B9FE9AD7AE2CB00B5BAB14* __this, const RuntimeMethod* method) 
{
	{
		Task_1_t824317F4B958F7512E8F7300511752937A6C6043* L_0 = (Task_1_t824317F4B958F7512E8F7300511752937A6C6043*)__this->____task_0;
		return L_0;
	}
}
