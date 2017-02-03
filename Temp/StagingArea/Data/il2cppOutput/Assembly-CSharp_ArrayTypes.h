#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


// BubbleBehavior
struct BubbleBehavior_t2953284492;
// ShapeBehavior
struct ShapeBehavior_t1433886141;

#include "mscorlib_System_Array3829468939.h"
#include "AssemblyU2DCSharp_BubbleBehavior2953284492.h"
#include "AssemblyU2DCSharp_ShapeBehavior1433886141.h"

#pragma once
// BubbleBehavior[]
struct BubbleBehaviorU5BU5D_t4084922565  : public Il2CppArray
{
public:
	ALIGN_FIELD (8) BubbleBehavior_t2953284492 * m_Items[1];

public:
	inline BubbleBehavior_t2953284492 * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline BubbleBehavior_t2953284492 ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, BubbleBehavior_t2953284492 * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
	inline BubbleBehavior_t2953284492 * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline BubbleBehavior_t2953284492 ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, BubbleBehavior_t2953284492 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
// ShapeBehavior[]
struct ShapeBehaviorU5BU5D_t3707816624  : public Il2CppArray
{
public:
	ALIGN_FIELD (8) ShapeBehavior_t1433886141 * m_Items[1];

public:
	inline ShapeBehavior_t1433886141 * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline ShapeBehavior_t1433886141 ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, ShapeBehavior_t1433886141 * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
	inline ShapeBehavior_t1433886141 * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline ShapeBehavior_t1433886141 ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, ShapeBehavior_t1433886141 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
