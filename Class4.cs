using System;
using System.Runtime.InteropServices;

internal class Class4
{
	private IntPtr intptr_0;

	public Class4(IntPtr intptr_1)
	{
		Class11.XaVAKfizxKw3a();
		base();
		this.intptr_0 = intptr_1;
	}

	[DllImport("user32.dll", CharSet=CharSet.Auto, ExactSpelling=true)]
	internal static extern short GetAsyncKeyState(int int_0);

	public void method_0(int int_0, int int_1)
	{
		Class4.RegisterHotKey(this.intptr_0, int_1, 0, (uint)int_0);
	}

	public void method_1(uint uint_0, int int_0)
	{
		Class4.UnregisterHotKey(this.intptr_0, int_0);
	}

	public bool method_2(int int_0)
	{
		if (Class4.GetAsyncKeyState(int_0) != 0)
		{
			return true;
		}
		return false;
	}

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	public static extern bool RegisterHotKey(IntPtr intptr_1, int int_0, uint uint_0, uint uint_1);

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	public static extern bool UnregisterHotKey(IntPtr intptr_1, int int_0);
}