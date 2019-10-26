using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

internal class Class3
{
	private Process process_0;

	private IntPtr intptr_0;

	public string string_0;

	public string string_1;

	public string string_2;

	public Class3(string string_3, string string_4)
	{
		Class11.XaVAKfizxKw3a();
		base();
		this.string_0 = string_3;
		this.string_1 = string_4;
	}

	[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	private static extern bool CloseHandle(IntPtr intptr_1);

	public void method_0()
	{
		bool flag = false;
		Process[] processesByName = Process.GetProcessesByName(this.string_1);
		if ((int)processesByName.Length != 0)
		{
			this.process_0 = processesByName[0];
			this.intptr_0 = Class3.OpenProcess(2035711, false, this.process_0.Id);
			flag = (this.intptr_0 != IntPtr.Zero ? true : false);
		}
		if (!flag)
		{
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < processes.Count<Process>(); i++)
			{
				if (processes[i].MainWindowTitle == this.string_0)
				{
					flag = true;
					this.process_0 = processes[i];
				}
			}
			if (flag)
			{
				this.intptr_0 = Class3.OpenProcess(2035711, false, this.process_0.Id);
				return;
			}
			this.intptr_0 = (IntPtr)-1;
		}
	}

	public string method_1()
	{
		if (this.intptr_0 == (IntPtr)-1)
		{
			return "none";
		}
		this.string_1 = this.process_0.ProcessName;
		return this.string_1;
	}

	public bool method_10(IntPtr intptr_1)
	{
		bool flag;
		try
		{
			flag = BitConverter.ToBoolean(this.method_5(intptr_1, 1), 0);
		}
		catch (Exception exception)
		{
			Console.WriteLine(string.Concat("Error in logic: ReadBoolean", exception.ToString()));
			flag = false;
		}
		return flag;
	}

	public byte method_11(IntPtr intptr_1)
	{
		byte num;
		try
		{
			num = this.method_5(intptr_1, 1)[0];
		}
		catch (Exception exception)
		{
			Console.WriteLine(string.Concat("Error in logic: ReadByte", exception.ToString()));
			num = 0;
		}
		return num;
	}

	public short method_12(IntPtr intptr_1)
	{
		short num;
		try
		{
			num = BitConverter.ToInt16(this.method_5(intptr_1, 2), 0);
		}
		catch (Exception exception)
		{
			Console.WriteLine(string.Concat("Error in logic: ReadShort", exception.ToString()));
			num = 0;
		}
		return num;
	}

	public int method_13(IntPtr intptr_1)
	{
		int num;
		try
		{
			num = BitConverter.ToInt32(this.method_5(intptr_1, 4), 0);
		}
		catch (Exception exception)
		{
			Console.WriteLine(string.Concat("Error in logic: ReadInteger", exception.ToString()));
			num = 0;
		}
		return num;
	}

	public long method_14(IntPtr intptr_1)
	{
		long num;
		try
		{
			num = BitConverter.ToInt64(this.method_5(intptr_1, 8), 0);
		}
		catch (Exception exception)
		{
			Console.WriteLine(string.Concat("Error in logic: ReadLong", exception.ToString()));
			num = 0L;
		}
		return num;
	}

	public ushort method_15(IntPtr intptr_1)
	{
		ushort num;
		try
		{
			num = BitConverter.ToUInt16(this.method_5(intptr_1, 2), 0);
		}
		catch (Exception exception)
		{
			Console.WriteLine(string.Concat("Error in logic: ReadUShort", exception.ToString()));
			num = 0;
		}
		return num;
	}

	public uint method_16(IntPtr intptr_1)
	{
		uint num;
		try
		{
			num = BitConverter.ToUInt32(this.method_5(intptr_1, 4), 0);
		}
		catch (Exception exception)
		{
			Console.WriteLine(string.Concat("Error in logic: ReadUInteger", exception.ToString()));
			num = 0;
		}
		return num;
	}

	public ulong method_17(IntPtr intptr_1)
	{
		ulong num;
		try
		{
			num = BitConverter.ToUInt64(this.method_5(intptr_1, 8), 0);
		}
		catch (Exception exception)
		{
			Console.WriteLine(string.Concat("Error in logic: ReadULong", exception.ToString()));
			num = 0L;
		}
		return num;
	}

	public float method_18(IntPtr intptr_1)
	{
		float single;
		try
		{
			single = BitConverter.ToSingle(this.method_5(intptr_1, 4), 0);
		}
		catch (Exception exception)
		{
			Console.WriteLine(string.Concat("Error in logic: ReadFloat", exception.ToString()));
			single = 0f;
		}
		return single;
	}

	public double method_19(IntPtr intptr_1)
	{
		double num;
		try
		{
			num = BitConverter.ToDouble(this.method_5(intptr_1, 8), 0);
		}
		catch (Exception exception)
		{
			Console.WriteLine(string.Concat("Error in logic: ReadDouble", exception.ToString()));
			num = 0;
		}
		return num;
	}

	public string method_2()
	{
		if (this.intptr_0 == (IntPtr)-1)
		{
			return "none";
		}
		try
		{
			this.string_2 = this.process_0.MainModule.ModuleName;
		}
		catch
		{
			Thread.Sleep(1000);
			this.string_2 = this.process_0.MainModule.ModuleName;
		}
		return this.string_2;
	}

	public bool method_20(IntPtr intptr_1, byte byte_0)
	{
		bool flag;
		try
		{
			byte[] byte0 = new byte[] { byte_0 };
			flag = this.method_6(intptr_1, byte0);
		}
		catch (Exception exception)
		{
			Console.WriteLine(string.Concat("Error in logic: WriteByte", exception.ToString()));
			flag = false;
		}
		return flag;
	}

	public bool method_21(IntPtr intptr_1, short short_0)
	{
		bool flag;
		try
		{
			flag = this.method_6(intptr_1, BitConverter.GetBytes(short_0));
		}
		catch (Exception exception)
		{
			Console.WriteLine(string.Concat("Error in logic: WriteShort", exception.ToString()));
			flag = false;
		}
		return flag;
	}

	public bool method_22(IntPtr intptr_1, int int_0)
	{
		bool flag;
		try
		{
			flag = this.method_6(intptr_1, BitConverter.GetBytes(int_0));
		}
		catch (Exception exception)
		{
			Console.WriteLine(string.Concat("Error in logic: WriteInt", exception.ToString()));
			flag = false;
		}
		return flag;
	}

	public bool method_23(IntPtr intptr_1, uint uint_0)
	{
		bool flag;
		try
		{
			flag = this.method_6(intptr_1, BitConverter.GetBytes(uint_0));
		}
		catch (Exception exception)
		{
			Console.WriteLine(string.Concat("Error in logic: WriteUInt", exception.ToString()));
			flag = false;
		}
		return flag;
	}

	public bool method_24(IntPtr intptr_1, float float_0)
	{
		bool flag;
		try
		{
			flag = this.method_6(intptr_1, BitConverter.GetBytes(float_0));
		}
		catch (Exception exception)
		{
			Console.WriteLine(string.Concat("Error in logic: WriteFloat", exception.ToString()));
			flag = false;
		}
		return flag;
	}

	public IntPtr method_3()
	{
		if (this.intptr_0 != (IntPtr)-1)
		{
			return this.intptr_0;
		}
		return (IntPtr)-1;
	}

	public int method_4(string string_3)
	{
		if (this.intptr_0 == (IntPtr)-1)
		{
			return 0;
		}
		ProcessModuleCollection modules = this.process_0.Modules;
		for (int i = 0; i < modules.Count; i++)
		{
			if (modules[i].ModuleName == string_3)
			{
				return (int)modules[i].BaseAddress;
			}
		}
		return 0;
	}

	public byte[] method_5(IntPtr intptr_1, uint uint_0)
	{
		unsafe
		{
			uint num;
			byte[] numArray;
			if (this.intptr_0 == (IntPtr)-1)
			{
				numArray = new byte[1];
			}
			else
			{
				try
				{
					Class3.VirtualProtectEx(this.intptr_0, intptr_1, (UIntPtr)uint_0, 4, out num);
					byte[] numArray1 = new byte[uint_0];
					Class3.ReadProcessMemory(this.intptr_0, intptr_1, numArray1, uint_0, 0);
					Class3.VirtualProtectEx(this.intptr_0, intptr_1, (UIntPtr)uint_0, num, out num);
					numArray = numArray1;
				}
				catch (Exception exception)
				{
					Console.WriteLine(string.Concat("Error in logic: ReadByteArray", exception.ToString()));
					numArray = new byte[1];
				}
			}
			return numArray;
		}
	}

	public bool method_6(IntPtr intptr_1, byte[] byte_0)
	{
		uint num;
		bool flag;
		if (this.intptr_0 == (IntPtr)-1)
		{
			flag = false;
		}
		else
		{
			try
			{
				Class3.VirtualProtectEx(this.intptr_0, intptr_1, (UIntPtr)((long)((int)byte_0.Length)), 4, out num);
				bool flag1 = Class3.WriteProcessMemory(this.intptr_0, intptr_1, byte_0, (uint)byte_0.Length, 0);
				Class3.VirtualProtectEx(this.intptr_0, intptr_1, (UIntPtr)((long)((int)byte_0.Length)), num, out num);
				flag = flag1;
			}
			catch (Exception exception)
			{
				Console.WriteLine(string.Concat("Error in logic: WriteByteArray", exception.ToString()));
				flag = false;
			}
		}
		return flag;
	}

	public char method_7(IntPtr intptr_1)
	{
		char chr;
		try
		{
			chr = BitConverter.ToChar(this.method_5(intptr_1, 1), 0);
		}
		catch (Exception exception)
		{
			Console.WriteLine(string.Concat("Error in logic: ReadByte", exception.ToString()));
			chr = ' ';
		}
		return chr;
	}

	public string method_8(IntPtr intptr_1, uint uint_0)
	{
		string str;
		try
		{
			str = Encoding.Unicode.GetString(this.method_5(intptr_1, uint_0), 0, (int)uint_0);
		}
		catch (Exception exception)
		{
			Console.WriteLine(string.Concat("Error in logic: ReadStringUnicode", exception.ToString()));
			str = "";
		}
		return str;
	}

	public string method_9(IntPtr intptr_1, uint uint_0)
	{
		string str;
		try
		{
			str = Encoding.ASCII.GetString(this.method_5(intptr_1, uint_0), 0, (int)uint_0);
		}
		catch (Exception exception)
		{
			Console.WriteLine(string.Concat("Error in logic: ReadStringASCII", exception.ToString()));
			str = "";
		}
		return str;
	}

	[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	private static extern IntPtr OpenProcess(uint uint_0, bool bool_0, int int_0);

	[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
	private static extern bool ReadProcessMemory(IntPtr intptr_1, IntPtr intptr_2, byte[] byte_0, uint uint_0, uint uint_1);

	[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=true, SetLastError=true)]
	private static extern IntPtr VirtualAllocEx(IntPtr intptr_1, IntPtr intptr_2, uint uint_0, uint uint_1, uint uint_2);

	[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	private static extern bool VirtualProtectEx(IntPtr intptr_1, IntPtr intptr_2, UIntPtr uintptr_0, uint uint_0, out uint uint_1);

	[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	private static extern bool WriteProcessMemory(IntPtr intptr_1, IntPtr intptr_2, byte[] byte_0, uint uint_0, uint uint_1);

	private enum Enum0 : uint
	{

	}

	private enum Enum1 : uint
	{

	}
}