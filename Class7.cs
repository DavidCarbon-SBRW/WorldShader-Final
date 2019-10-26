using Microsoft.Win32;
using System;
using System.Windows.Forms;

internal class Class7
{
	private bool bool_0;

	private string string_0;

	private RegistryKey registryKey_0;

	public Class7()
	{
		Class11.XaVAKfizxKw3a();
		this.string_0 = string.Concat("SOFTWARE\\", Application.ProductName.ToUpper());
		this.registryKey_0 = Registry.LocalMachine;
		base();
	}

	public bool method_0()
	{
		return this.bool_0;
	}

	public void method_1(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	public int method_10()
	{
		int num;
		try
		{
			RegistryKey registryKey = this.registryKey_0.OpenSubKey(this.string_0);
			num = (registryKey == null ? 0 : registryKey.SubKeyCount);
		}
		catch (Exception exception)
		{
			this.method_12(exception, string.Concat("Retriving subkeys of ", this.string_0));
			num = 0;
		}
		return num;
	}

	public int method_11()
	{
		int num;
		try
		{
			RegistryKey registryKey = this.registryKey_0.OpenSubKey(this.string_0);
			num = (registryKey == null ? 0 : registryKey.ValueCount);
		}
		catch (Exception exception)
		{
			this.method_12(exception, string.Concat("Retriving keys of ", this.string_0));
			num = 0;
		}
		return num;
	}

	private void method_12(Exception exception_0, string string_1)
	{
		if (this.bool_0)
		{
			MessageBox.Show(exception_0.Message, string_1, MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	public string method_2()
	{
		return this.string_0;
	}

	public void method_3(string string_1)
	{
		this.string_0 = string_1;
	}

	public RegistryKey method_4()
	{
		return this.registryKey_0;
	}

	public void method_5(RegistryKey registryKey_1)
	{
		this.registryKey_0 = registryKey_1;
	}

	public string method_6(string string_1)
	{
		string value;
		RegistryKey registryKey = this.registryKey_0.OpenSubKey(this.string_0);
		if (registryKey == null)
		{
			return null;
		}
		try
		{
			value = (string)registryKey.GetValue(string_1);
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_12(exception, string.Concat("Reading registry ", string_1.ToUpper()));
			value = null;
		}
		return value;
	}

	public bool method_7(string string_1, object object_0)
	{
		bool flag;
		try
		{
			RegistryKey registryKey = this.registryKey_0.CreateSubKey(this.string_0);
			registryKey.SetValue(string_1.ToUpper(), object_0);
			flag = true;
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_12(exception, string.Concat("Writing registry ", string_1.ToUpper()));
			flag = false;
		}
		return flag;
	}

	public bool method_8(string string_1)
	{
		bool flag;
		try
		{
			RegistryKey registryKey = this.registryKey_0.CreateSubKey(this.string_0);
			if (registryKey != null)
			{
				registryKey.DeleteValue(string_1);
				flag = true;
			}
			else
			{
				flag = true;
			}
		}
		catch (Exception exception)
		{
			this.method_12(exception, string.Concat("Deleting SubKey ", this.string_0));
			flag = false;
		}
		return flag;
	}

	public bool method_9()
	{
		bool flag;
		try
		{
			RegistryKey registryKey0 = this.registryKey_0;
			if (registryKey0.OpenSubKey(this.string_0) != null)
			{
				registryKey0.DeleteSubKeyTree(this.string_0);
			}
			flag = true;
		}
		catch (Exception exception)
		{
			this.method_12(exception, string.Concat("Deleting SubKey ", this.string_0));
			flag = false;
		}
		return flag;
	}
}