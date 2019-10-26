using System;
using System.Drawing;
using System.Runtime.InteropServices;

internal class Class6
{
	private IntPtr intptr_0;

	private string string_0;

	public Class6(string string_1)
	{
		Class11.XaVAKfizxKw3a();
		this.intptr_0 = IntPtr.Zero;
		this.string_0 = "";
		base();
		this.string_0 = string_1;
		this.intptr_0 = Class6.FindWindow(null, string_1);
	}

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
	internal static extern IntPtr FindWindow(string string_1, string string_2);

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
	private static extern bool GetClientRect(IntPtr intptr_1, out Rectangle rectangle_0);

	public Rectangle method_0()
	{
		Rectangle rectangle = new Rectangle();
		Class6.GetClientRect(this.intptr_0, out rectangle);
		return rectangle;
	}
}