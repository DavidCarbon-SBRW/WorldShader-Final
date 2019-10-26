using System;
using System.Runtime.InteropServices;

internal class Class8
{
	private int int_0;

	public Class8(string string_0)
	{
		Class11.XaVAKfizxKw3a();
		base();
		this.int_0 = Class8.FindWindow(null, string_0);
	}

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	public static extern int FindWindow(string string_0, string string_1);

	private IntPtr method_0(short short_0, short short_1)
	{
		return (IntPtr)(short_1 << 16 | short_0 & 65535);
	}

	public void method_1(IntPtr intptr_0)
	{
		Class8.PostMessage(this.int_0, 256, intptr_0, IntPtr.Zero);
	}

	public void method_2(short short_0, short short_1)
	{
		IntPtr intPtr = this.method_0(short_0, short_1);
		Class8.PostMessage(this.int_0, 513, IntPtr.Zero, intPtr);
		Class8.PostMessage(this.int_0, 514, IntPtr.Zero, intPtr);
	}

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
	public static extern bool PostMessage(int int_1, uint uint_0, IntPtr intptr_0, IntPtr intptr_1);
}