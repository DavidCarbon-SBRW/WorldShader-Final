using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

internal class Class5
{
	private Random random_0;

	public Class5(int int_0)
	{
		Class11.XaVAKfizxKw3a();
		base();
		this.random_0 = new Random(int_0);
	}

	public string[] method_0(string string_0, string string_1)
	{
		object[] objArray = new object[] { this.random_0.Next(100000000, 999999999), "||", Class5.smethod_0(), "||", string_0, "||", string_1, "||", this.random_0.Next(100000000, 999999999) };
		string str = string.Concat(objArray);
		try
		{
			WebRequest length = WebRequest.Create("http://vsteam.net/vsys/cheats.php");
			length.Method = "POST";
			length.ContentType = "application/x-www-form-urlencoded";
			byte[] bytes = Encoding.GetEncoding("utf-8").GetBytes(string.Concat("text=", this.method_2(this.method_4(this.method_4(str, true), true)), " &get=true"));
			length.ContentLength = (long)((int)bytes.Length);
			Stream requestStream = length.GetRequestStream();
			requestStream.Write(bytes, 0, (int)bytes.Length);
			requestStream.Close();
			using (StreamReader streamReader = new StreamReader(length.GetResponse().GetResponseStream()))
			{
				string end = streamReader.ReadToEnd();
				str = this.method_4(this.method_4(this.method_3(end), false), false);
			}
		}
		catch
		{
			MessageBox.Show("Hm, i think my server is bussy now, or you don't have internet connection, sorry");
		}
		return str.Split(new string[] { "||" }, StringSplitOptions.None);
	}

	public string[] method_1(string string_0, string string_1, string string_2)
	{
		object[] objArray = new object[] { this.random_0.Next(100000000, 999999999), "||", Class5.smethod_0(), "||", string_0, "||", string_1, "||", string_2, "||", this.random_0.Next(100000000, 999999999) };
		string str = string.Concat(objArray);
		try
		{
			WebRequest length = WebRequest.Create("http://vsteam.net/vsys/cheats.php");
			length.Method = "POST";
			length.ContentType = "application/x-www-form-urlencoded";
			byte[] bytes = Encoding.GetEncoding("utf-8").GetBytes(string.Concat("text=", this.method_2(this.method_4(this.method_4(str, true), true)), " &send=true"));
			length.ContentLength = (long)((int)bytes.Length);
			Stream requestStream = length.GetRequestStream();
			requestStream.Write(bytes, 0, (int)bytes.Length);
			requestStream.Close();
			using (StreamReader streamReader = new StreamReader(length.GetResponse().GetResponseStream()))
			{
				string end = streamReader.ReadToEnd();
				str = this.method_4(this.method_4(this.method_3(end), false), false);
			}
		}
		catch
		{
			MessageBox.Show("Hm, i think my server is bussy now, or you don't have internet connection, sorry");
		}
		return str.Split(new string[] { "||" }, StringSplitOptions.None);
	}

	public string method_2(string string_0)
	{
		byte[] bytes = (new UTF8Encoding()).GetBytes(string_0);
		bytes = Encoding.Convert(Encoding.UTF8, Encoding.GetEncoding(1251), bytes);
		string str = "";
		byte[] numArray = bytes;
		for (int i = 0; i < (int)numArray.Length; i++)
		{
			byte num = numArray[i];
			str = string.Concat(str, (num > 15 ? string.Format("{0:X}", num) : string.Format("0{0:X}", num)));
		}
		return str;
	}

	public string method_3(string string_0)
	{
		string str;
		try
		{
			string empty = string.Empty;
			for (int i = 0; i < string_0.Length; i += 2)
			{
				string str1 = string_0[i].ToString();
				char string0 = string_0[i + 1];
				empty = string.Concat(empty, str1, string0.ToString(), " ");
			}
			char[] chrArray = new char[] { ' ' };
			string[] strArrays = empty.Split(chrArray, StringSplitOptions.RemoveEmptyEntries);
			byte[] numArray = new byte[(int)strArrays.Length];
			for (int j = 0; j < (int)strArrays.Length; j++)
			{
				numArray[j] = byte.Parse(strArrays[j], NumberStyles.AllowHexSpecifier);
			}
			str = Encoding.GetEncoding(1251).GetString(numArray);
		}
		catch
		{
			str = "";
		}
		return str;
	}

	private string method_4(string string_0, bool bool_0)
	{
		int num;
		if (string_0.Length == 0)
		{
			return "";
		}
		int num1 = 0;
		if (!bool_0)
		{
			int length = string_0.Length;
			num = Convert.ToInt32(this.method_6(string_0, 2));
			string_0 = this.method_7(string_0, 2);
		}
		else
		{
			int length1 = string_0.Length;
			num1 = this.random_0.Next(10, 99);
			num = num1;
		}
		char[] charArray = string_0.ToCharArray();
		for (int i = 0; i < charArray.Count<char>(); i++)
		{
			charArray[i] = Convert.ToChar(charArray[i] ^ (char)num);
			if (num >= 98)
			{
				num = 0;
			}
			else
			{
				num++;
			}
		}
		return string.Concat((bool_0 ? num1.ToString() : ""), new string(charArray));
	}

	public string method_5(string string_0, bool bool_0)
	{
		int num;
		int num1;
		if (string_0.Length == 0)
		{
			return "";
		}
		int num2 = 0;
		if (!bool_0)
		{
			int length = string_0.Length;
			num = Convert.ToInt32(this.method_6(string_0, 2));
			string_0 = this.method_7(string_0, 2);
		}
		else
		{
			int length1 = string_0.Length;
			num2 = this.random_0.Next(10, 20);
			num = num2;
		}
		char[] charArray = string_0.ToCharArray();
		for (int i = 0; i < charArray.Count<char>(); i++)
		{
			num1 = (i % 2 != 1 ? 2 : 1);
			charArray[i] = Convert.ToChar(charArray[i] ^ (char)(num * num1));
		}
		return string.Concat((bool_0 ? num2.ToString() : ""), new string(charArray));
	}

	private string method_6(string string_0, int int_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		if (int_0 == 0 || string_0.Length == 0)
		{
			return "";
		}
		if (string_0.Length <= int_0)
		{
			return string_0;
		}
		return string_0.Substring(0, int_0);
	}

	private string method_7(string string_0, int int_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		if (int_0 == 0 || string_0.Length == 0)
		{
			return string_0;
		}
		if (string_0.Length <= int_0)
		{
			return "";
		}
		return string_0.Substring(int_0, string_0.Length - int_0);
	}

	private static string smethod_0()
	{
		string str = "";
		string str1 = "";
		string upper = "";
		string upper1 = "";
		ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT Architecture, ProcessorId, Family, Level, Manufacturer, Name, Revision, Version FROM Win32_Processor");
		try
		{
			foreach (ManagementObject managementObject in managementObjectSearcher.Get())
			{
				try
				{
					str = string.Concat(str, managementObject["Version"].ToString());
				}
				catch
				{
				}
				try
				{
					str = string.Concat(str, managementObject["Architecture"].ToString());
				}
				catch
				{
				}
				try
				{
					str = string.Concat(str, managementObject["Family"].ToString());
				}
				catch
				{
				}
				try
				{
					str = string.Concat(str, managementObject["Level"].ToString());
				}
				catch
				{
				}
				try
				{
					str = string.Concat(str, managementObject["Manufacturer"].ToString());
				}
				catch
				{
				}
				try
				{
					str = string.Concat(str, managementObject["Name"].ToString());
				}
				catch
				{
				}
				try
				{
					str = string.Concat(str, managementObject["Revision"].ToString());
				}
				catch
				{
				}
				try
				{
					str = string.Concat(str, managementObject["ProcessorId"].ToString());
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT Manufacturer, Name, SerialNumber, SMBIOSMajorVersion, SMBIOSMinorVersion FROM Win32_BIOS");
			foreach (ManagementObject managementObject1 in managementObjectSearcher.Get())
			{
				try
				{
					str = string.Concat(str, managementObject1["Manufacturer"].ToString());
				}
				catch
				{
				}
				try
				{
					str = string.Concat(str, managementObject1["Name"].ToString());
				}
				catch
				{
				}
				try
				{
					str = string.Concat(str, managementObject1["SerialNumber"].ToString());
				}
				catch
				{
				}
				try
				{
					str = string.Concat(str, managementObject1["SMBIOSMajorVersion"].ToString());
				}
				catch
				{
				}
				try
				{
					str = string.Concat(str, managementObject1["SMBIOSMinorVersion"].ToString());
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT AdapterDACType, VideoProcessor, CreationClassName, Description FROM Win32_VideoController");
			foreach (ManagementObject managementObject2 in managementObjectSearcher.Get())
			{
				try
				{
					str1 = string.Concat(str1, managementObject2["AdapterDACType"].ToString());
				}
				catch
				{
				}
				try
				{
					str1 = string.Concat(str1, managementObject2["VideoProcessor"].ToString());
				}
				catch
				{
				}
				try
				{
					str1 = string.Concat(str1, managementObject2["CreationClassName"].ToString());
				}
				catch
				{
				}
				try
				{
					str1 = string.Concat(str1, managementObject2["Description"].ToString());
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT Capacity, Speed, Name, TotalWidth, BankLabel, Tag FROM Win32_PhysicalMemory");
			foreach (ManagementObject managementObject3 in managementObjectSearcher.Get())
			{
				try
				{
					double num = Math.Round(Convert.ToDouble(managementObject3["Capacity"]) / 1024 / 1024, 2);
					str1 = string.Concat(str1, num.ToString());
				}
				catch
				{
				}
				try
				{
					str1 = string.Concat(str1, managementObject3["Name"].ToString());
				}
				catch
				{
				}
				try
				{
					str1 = string.Concat(str1, managementObject3["TotalWidth"].ToString());
				}
				catch
				{
				}
				try
				{
					str1 = string.Concat(str1, managementObject3["BankLabel"].ToString());
				}
				catch
				{
				}
				try
				{
					str1 = string.Concat(str1, managementObject3["Tag"].ToString());
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		upper = Class5.smethod_1(str).ToUpper();
		upper1 = Class5.smethod_1(str1).ToUpper();
		string[] strArrays = new string[] { "{", upper.Substring(0, 16), "-", upper1.Substring(0, 8), "-", upper.Substring(24, 8), "-", upper1.Substring(16, 8), "-", upper1.Substring(8, 24), "}" };
		return string.Concat(strArrays);
	}

	public static string smethod_1(string string_0)
	{
		string str;
		byte[] bytes = Encoding.Default.GetBytes(string_0);
		try
		{
			byte[] numArray = (new MD5CryptoServiceProvider()).ComputeHash(bytes);
			string str1 = "";
			byte[] numArray1 = numArray;
			for (int i = 0; i < (int)numArray1.Length; i++)
			{
				byte num = numArray1[i];
				str1 = (num >= 16 ? string.Concat(str1, num.ToString("x")) : string.Concat(str1, "0", num.ToString("x")));
			}
			str = str1;
		}
		catch
		{
			throw;
		}
		return str;
	}
}