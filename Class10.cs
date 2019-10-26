using System;
using System.Reflection;

internal class Class10
{
	internal static Module module_0;

	static Class10()
	{
		Class11.XaVAKfizxKw3a();
		Class10.module_0 = typeof(Class10).Assembly.ManifestModule;
	}

	public Class10()
	{
		Class11.XaVAKfizxKw3a();
		base();
	}

	internal static void pgMAKfiivAs46(int typemdt)
	{
		Type type = Class10.module_0.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		for (int i = 0; i < (int)fields.Length; i++)
		{
			FieldInfo fieldInfo = fields[i];
			MethodInfo methodInfo = (MethodInfo)Class10.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, methodInfo));
		}
	}

	internal delegate void Delegate0(object o);
}