using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace WorldShaderNew
{
	public class Form1 : Form
	{
		private static string string_0;

		private static string string_1;

		private string string_2 = "";

		private string string_3 = "";

		private IntPtr intptr_0;

		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private int int_4;

		private int int_5;

		private int int_6;

		private bool bool_0 = true;

		private bool bool_1;

		private Thread thread_0;

		private Class3 class3_0 = new Class3(Form1.string_0, Form1.string_1);

		private List<TrackBar> list_0 = new List<TrackBar>();

		private List<Label> list_1 = new List<Label>();

		private List<Label> list_2 = new List<Label>();

		private List<TrackBar> list_3 = new List<TrackBar>();

		private List<Label> list_4 = new List<Label>();

		private List<Label> list_5 = new List<Label>();

		private List<Class2> list_6 = new List<Class2>();

		private List<Class2> list_7 = new List<Class2>();

		private List<Class1> list_8 = new List<Class1>();

		private List<Class1> list_9 = new List<Class1>();

		private static string string_4;

		private static string string_5;

		private IContainer icontainer_0;

		private TabControl tabMaterial;

		private TabPage tabPage1;

		private TabPage tabPage2;

		private Label label2;

		private ComboBox comboBoxCarMaterial;

		private Label label1;

		private ComboBox comboBoxWorldMaterial;

		private TextBox textBox1;

		private ListBox listBox1;

		private Button button3;

		private Button button2;

		private Button button1;

		private System.Windows.Forms.Timer timer_0;

		private LinkLabel linkLabel2;

		private LinkLabel linkLabel3;

		private LinkLabel linkLabel1;

		private Panel panel1;

		private Panel panel2;

		static Form1()
		{
			Form1.string_0 = "NEED FOR SPEED™ WORLD";
			Form1.string_1 = "nfsw";
			Form1.string_4 = "Shaders";
			Form1.string_5 = "v3";
		}

		public Form1()
		{
			string[] strArrays = new string[] { "Cracked by berkay2578, no phoning required. Enjoy!", "0x8B4BD8", "0x912028" };
			MessageBox.Show(strArrays[0], "Up and running", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.int_1 = Convert.ToInt32(strArrays[1], 16);
			this.int_3 = Convert.ToInt32(strArrays[2], 16);
			this.InitializeComponent();
		}

		private void ahshlbXrJ(object sender, EventArgs e)
		{
			this.int_5 = this.comboBoxWorldMaterial.SelectedIndex;
			this.method_6();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.bool_1 = true;
			try
			{
				if (this.listBox1.SelectedIndex == -1)
				{
					MessageBox.Show("Please select file :)", "Hm...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					string str = string.Concat(Directory.GetCurrentDirectory(), "\\Shaders\\");
					string str1 = this.listBox1.SelectedItem.ToString();
					if (File.Exists(string.Concat(str, str1, ".xml")))
					{
						FileStream fileStream = new FileStream(string.Concat(str, str1, ".xml"), FileMode.Open);
						XmlTextReader xmlTextReader = new XmlTextReader(fileStream)
						{
							WhitespaceHandling = WhitespaceHandling.None
						};
						try
						{
							while (xmlTextReader.Read())
							{
								if (xmlTextReader.NodeType != XmlNodeType.Element)
								{
									continue;
								}
								if (!(xmlTextReader.Name.ToLower() != "world") || !(xmlTextReader.Name.ToLower() != "garage") || !(xmlTextReader.Name.ToLower() != "scene"))
								{
									if (xmlTextReader.Name.ToLower() == "world")
									{
										for (int i = 0; i < 200; i++)
										{
											this.class3_0.method_24(((IntPtr)this.class3_0.method_13(((IntPtr)this.int_0 + this.int_3) + 0) + 400) + 4 * i, Convert.ToSingle(xmlTextReader.GetAttribute(string.Concat("n", i.ToString()))));
										}
									}
									if (xmlTextReader.Name.ToLower() == "garage")
									{
										for (int j = 0; j < 200; j++)
										{
											this.class3_0.method_24(((IntPtr)this.class3_0.method_13(((IntPtr)this.int_0 + this.int_3) + 4) + 400) + 4 * j, Convert.ToSingle(xmlTextReader.GetAttribute(string.Concat("n", j.ToString()))));
										}
									}
									if (xmlTextReader.Name.ToLower() != "scene")
									{
										continue;
									}
									for (int k = 0; k < 200; k++)
									{
										this.class3_0.method_24(((IntPtr)this.class3_0.method_13(((IntPtr)this.int_0 + this.int_3) + 8) + 400) + 4 * k, Convert.ToSingle(xmlTextReader.GetAttribute(string.Concat("n", k.ToString()))));
									}
								}
								else
								{
									foreach (Class1 list8 in this.list_8)
									{
										if (xmlTextReader.Name.ToLower() != list8.string_0)
										{
											continue;
										}
										for (int l = 0; l < 50; l++)
										{
											this.class3_0.method_24((((IntPtr)this.int_2 + 48) + 4 * l) + list8.int_0 * 260, Convert.ToSingle(xmlTextReader.GetAttribute(string.Concat("n", l.ToString()))));
										}
									}
								}
							}
							MessageBox.Show("Loaded successfully :)", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							this.method_5();
							this.method_6();
						}
						catch
						{
							MessageBox.Show("File is corrupted :/", "Hm...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
						xmlTextReader.Close();
						fileStream.Close();
					}
				}
			}
			catch
			{
				MessageBox.Show("Can't load :/", "Hm...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			this.bool_1 = false;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				string str = string.Concat(Directory.GetCurrentDirectory(), "\\Shaders\\");
				if (this.textBox1.Text == "")
				{
					this.textBox1.Text = "NoName";
				}
				string text = this.textBox1.Text;
				while (File.Exists(string.Concat(str, text, ".xml")))
				{
					text = string.Concat(text, "+");
				}
				FileStream fileStream = new FileStream(string.Concat(str, text, ".xml"), FileMode.Create);
				XmlTextWriter xmlTextWriter = new XmlTextWriter(fileStream, Encoding.UTF8)
				{
					Formatting = Formatting.Indented
				};
				xmlTextWriter.WriteStartDocument();
				xmlTextWriter.WriteStartElement("Shader");
				foreach (Class1 list8 in this.list_8)
				{
					xmlTextWriter.WriteStartElement(list8.string_0);
					for (int i = 0; i < 50; i++)
					{
						string str1 = string.Concat("n", i.ToString());
						float single = this.class3_0.method_18((((IntPtr)this.int_2 + 48) + 4 * i) + list8.int_0 * 260);
						xmlTextWriter.WriteAttributeString(str1, single.ToString());
					}
					xmlTextWriter.WriteEndElement();
				}
				xmlTextWriter.WriteStartElement("world");
				for (int j = 0; j < 200; j++)
				{
					string str2 = string.Concat("n", j.ToString());
					float single1 = this.class3_0.method_18(((IntPtr)this.class3_0.method_13(((IntPtr)this.int_0 + this.int_3) + 0) + 400) + 4 * j);
					xmlTextWriter.WriteAttributeString(str2, single1.ToString());
				}
				xmlTextWriter.WriteEndElement();
				xmlTextWriter.WriteStartElement("garage");
				for (int k = 0; k < 200; k++)
				{
					string str3 = string.Concat("n", k.ToString());
					float single2 = this.class3_0.method_18(((IntPtr)this.class3_0.method_13(((IntPtr)this.int_0 + this.int_3) + 4) + 400) + 4 * k);
					xmlTextWriter.WriteAttributeString(str3, single2.ToString());
				}
				xmlTextWriter.WriteEndElement();
				xmlTextWriter.WriteStartElement("scene");
				for (int l = 0; l < 200; l++)
				{
					string str4 = string.Concat("n", l.ToString());
					float single3 = this.class3_0.method_18(((IntPtr)this.class3_0.method_13(((IntPtr)this.int_0 + this.int_3) + 8) + 400) + 4 * l);
					xmlTextWriter.WriteAttributeString(str4, single3.ToString());
				}
				xmlTextWriter.WriteEndElement();
				xmlTextWriter.WriteEndElement();
				xmlTextWriter.WriteEndDocument();
				xmlTextWriter.Close();
				fileStream.Close();
				this.listBox1.Items.Add(text);
				MessageBox.Show("Saved successfully :)", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch
			{
				MessageBox.Show("Can't save :/", "Oh...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (this.listBox1.SelectedIndex == -1)
			{
				MessageBox.Show("File not selected", "Hm...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (MessageBox.Show(string.Concat("Do you want delete \"", this.listBox1.SelectedItem, "\" file?"), "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
			{
				string str = string.Concat(Directory.GetCurrentDirectory(), "\\Shaders\\");
				if (File.Exists(string.Concat(str, this.listBox1.SelectedItem, ".xml")))
				{
					File.Delete(string.Concat(str, this.listBox1.SelectedItem, ".xml"));
				}
				this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
				return;
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.method_2();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.intefeiseWorldLoader();
			this.intefeiseCarLoader();
			for (int i = 0; i < 200; i++)
			{
				TrackBar trackBar = new TrackBar()
				{
					LargeChange = 10,
					Location = new Point(25, i * 45 + 30),
					Size = new System.Drawing.Size(600, 20),
					TabIndex = i + 1,
					Text = "0",
					Name = i.ToString(),
					RightToLeft = System.Windows.Forms.RightToLeft.No,
					TickFrequency = 5000 * this.list_7[i].int_2 / 100,
					TickStyle = TickStyle.Both,
					Maximum = this.list_7[i].int_2 * 1000,
					Minimum = this.list_7[i].int_1 * 1000,
					Enabled = this.list_7[i].bool_0
				};
				trackBar.ValueChanged += new EventHandler(this.method_4);
				Label label = new Label()
				{
					Location = new Point(0, i * 45 + 15 + 30),
					Size = new System.Drawing.Size(28, 20)
				};
				int num = i + 1;
				label.Text = string.Concat(num.ToString(), ".");
				label.TextAlign = ContentAlignment.TopRight;
				Label label1 = new Label()
				{
					Location = new Point(625, i * 45 + 15 + 30),
					Size = new System.Drawing.Size(60, 20),
					Text = "0",
					TextAlign = ContentAlignment.TopLeft
				};
				this.list_3.Add(trackBar);
				this.list_4.Add(label);
				this.list_5.Add(label1);
				this.panel2.Controls.Add(trackBar);
				this.panel2.Controls.Add(label);
				this.panel2.Controls.Add(label1);
			}
			for (int j = 0; j < 50; j++)
			{
				TrackBar trackBar1 = new TrackBar()
				{
					LargeChange = 10,
					Location = new Point(25, j * 45 + 30),
					Size = new System.Drawing.Size(600, 20),
					TabIndex = j + 1,
					Text = "0",
					Name = j.ToString(),
					RightToLeft = System.Windows.Forms.RightToLeft.No,
					TickFrequency = 5000,
					TickStyle = TickStyle.Both,
					Maximum = this.list_6[j].int_2 * 1000,
					Minimum = this.list_6[j].int_1 * 1000,
					Enabled = this.list_6[j].bool_0
				};
				trackBar1.ValueChanged += new EventHandler(this.method_3);
				Label label2 = new Label()
				{
					Location = new Point(0, j * 45 + 15 + 30),
					Size = new System.Drawing.Size(28, 20)
				};
				int num1 = j + 1;
				label2.Text = string.Concat(num1.ToString(), ".");
				label2.TextAlign = ContentAlignment.TopRight;
				Label label3 = new Label()
				{
					Location = new Point(625, j * 45 + 15 + 30),
					Size = new System.Drawing.Size(60, 20),
					Text = "0",
					TextAlign = ContentAlignment.TopLeft
				};
				this.list_0.Add(trackBar1);
				this.list_1.Add(label2);
				this.list_2.Add(label3);
				this.panel1.Controls.Add(trackBar1);
				this.panel1.Controls.Add(label2);
				this.panel1.Controls.Add(label3);
			}
			this.thread_0 = new Thread(new ThreadStart(this.method_0))
			{
				IsBackground = false
			};
			this.thread_0.Start();
			Thread.Sleep(200);
			this.obrqvaVjM();
			this.method_7();
			this.method_8();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			string str = "";
			for (int i = 0; i < this.int_6; i++)
			{
				str = (i != 0 ? string.Concat(str, ")") : ":");
			}
			System.Drawing.Font font = new System.Drawing.Font("Times New Roman", 16f);
			SolidBrush solidBrush = new SolidBrush(Color.Black);
			StringFormat stringFormat = new StringFormat()
			{
				FormatFlags = StringFormatFlags.DirectionVertical
			};
			PointF pointF = new PointF(765f, 3f);
			e.Graphics.DrawString(str, font, solidBrush, pointF, stringFormat);
		}

		private void InitializeComponent()
		{
			this.icontainer_0 = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
			this.tabMaterial = new TabControl();
			this.tabPage1 = new TabPage();
			this.panel1 = new Panel();
			this.label2 = new Label();
			this.comboBoxCarMaterial = new ComboBox();
			this.tabPage2 = new TabPage();
			this.panel2 = new Panel();
			this.label1 = new Label();
			this.comboBoxWorldMaterial = new ComboBox();
			this.textBox1 = new TextBox();
			this.listBox1 = new ListBox();
			this.button3 = new Button();
			this.button2 = new Button();
			this.button1 = new Button();
			this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
			this.linkLabel2 = new LinkLabel();
			this.linkLabel3 = new LinkLabel();
			this.linkLabel1 = new LinkLabel();
			this.tabMaterial.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			base.SuspendLayout();
			this.tabMaterial.Controls.Add(this.tabPage1);
			this.tabMaterial.Controls.Add(this.tabPage2);
			this.tabMaterial.Cursor = Cursors.Default;
			this.tabMaterial.Location = new Point(12, 12);
			this.tabMaterial.Name = "tabMaterial";
			this.tabMaterial.SelectedIndex = 0;
			this.tabMaterial.Size = new System.Drawing.Size(713, 479);
			this.tabMaterial.TabIndex = 0;
			this.tabPage1.BackColor = SystemColors.Control;
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.comboBoxCarMaterial);
			this.tabPage1.Location = new Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(705, 453);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Car material";
			this.panel1.AutoScroll = true;
			this.panel1.Location = new Point(0, 33);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(705, 420);
			this.panel1.TabIndex = 4;
			this.label2.AutoSize = true;
			this.label2.Location = new Point(6, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Material";
			this.comboBoxCarMaterial.FormattingEnabled = true;
			this.comboBoxCarMaterial.Location = new Point(56, 6);
			this.comboBoxCarMaterial.Name = "comboBoxCarMaterial";
			this.comboBoxCarMaterial.Size = new System.Drawing.Size(196, 21);
			this.comboBoxCarMaterial.TabIndex = 2;
			this.comboBoxCarMaterial.SelectedIndexChanged += new EventHandler(this.klepPyofr);
			this.tabPage2.BackColor = SystemColors.Control;
			this.tabPage2.Controls.Add(this.panel2);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.comboBoxWorldMaterial);
			this.tabPage2.Location = new Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(705, 453);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "World material";
			this.panel2.AutoScroll = true;
			this.panel2.Location = new Point(0, 33);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(705, 420);
			this.panel2.TabIndex = 5;
			this.label1.AutoSize = true;
			this.label1.Location = new Point(6, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Material";
			this.comboBoxWorldMaterial.FormattingEnabled = true;
			this.comboBoxWorldMaterial.Location = new Point(56, 6);
			this.comboBoxWorldMaterial.Name = "comboBoxWorldMaterial";
			this.comboBoxWorldMaterial.Size = new System.Drawing.Size(196, 21);
			this.comboBoxWorldMaterial.TabIndex = 0;
			this.comboBoxWorldMaterial.SelectedIndexChanged += new EventHandler(this.ahshlbXrJ);
			this.textBox1.Location = new Point(731, 97);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(97, 20);
			this.textBox1.TabIndex = 14;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new Point(731, 152);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(97, 238);
			this.listBox1.Sorted = true;
			this.listBox1.TabIndex = 13;
			this.button3.Location = new Point(731, 396);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(97, 23);
			this.button3.TabIndex = 12;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new EventHandler(this.button3_Click);
			this.button2.Location = new Point(731, 123);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(97, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "Save";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new EventHandler(this.button2_Click);
			this.button1.Location = new Point(731, 68);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(97, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "Load";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 500;
			this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Location = new Point(738, 481);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(83, 13);
			this.linkLabel2.TabIndex = 31;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "2017 © berkay2578";
			this.linkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.Location = new Point(759, 459);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(69, 13);
			this.linkLabel3.TabIndex = 32;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "";
			this.linkLabel3.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new Point(776, 437);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(52, 13);
			this.linkLabel1.TabIndex = 33;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "";
			this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			base.ClientSize = new System.Drawing.Size(840, 503);
			base.Controls.Add(this.linkLabel1);
			base.Controls.Add(this.linkLabel3);
			base.Controls.Add(this.linkLabel2);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.listBox1);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.tabMaterial);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Form1";
			this.Text = "Shader Editor";
			base.FormClosed += new FormClosedEventHandler(this.Form1_FormClosed);
			base.Load += new EventHandler(this.Form1_Load);
			base.Paint += new PaintEventHandler(this.Form1_Paint);
			this.tabMaterial.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public void intefeiseCarLoader()
		{
			this.list_6.Add(new Class2(0, -100, 100, true));
			this.list_6.Add(new Class2(1, -100, 100, true));
			this.list_6.Add(new Class2(2, -100, 100, true));
			this.list_6.Add(new Class2(3, -100, 100, true));
			this.list_6.Add(new Class2(4, -100, 100, true));
			this.list_6.Add(new Class2(5, -100, 100, true));
			this.list_6.Add(new Class2(6, -100, 100, true));
			this.list_6.Add(new Class2(7, -100, 100, true));
			this.list_6.Add(new Class2(8, -100, 100, true));
			this.list_6.Add(new Class2(9, -100, 100, true));
			this.list_6.Add(new Class2(10, -100, 100, true));
			this.list_6.Add(new Class2(11, -100, 100, true));
			this.list_6.Add(new Class2(12, -100, 100, true));
			this.list_6.Add(new Class2(13, -100, 100, true));
			this.list_6.Add(new Class2(14, -100, 100, true));
			this.list_6.Add(new Class2(15, -100, 100, true));
			this.list_6.Add(new Class2(16, -100, 100, true));
			this.list_6.Add(new Class2(17, -100, 100, true));
			this.list_6.Add(new Class2(18, -100, 100, true));
			this.list_6.Add(new Class2(19, -100, 100, true));
			this.list_6.Add(new Class2(20, -100, 100, true));
			this.list_6.Add(new Class2(21, -100, 100, true));
			this.list_6.Add(new Class2(22, -100, 100, true));
			this.list_6.Add(new Class2(23, -100, 100, true));
			this.list_6.Add(new Class2(24, -100, 100, true));
			this.list_6.Add(new Class2(25, -100, 100, true));
			this.list_6.Add(new Class2(26, -100, 100, true));
			this.list_6.Add(new Class2(27, -100, 100, true));
			this.list_6.Add(new Class2(28, -100, 100, true));
			this.list_6.Add(new Class2(29, -100, 100, true));
			this.list_6.Add(new Class2(30, -100, 100, true));
			this.list_6.Add(new Class2(31, -100, 100, true));
			this.list_6.Add(new Class2(32, -100, 100, true));
			this.list_6.Add(new Class2(33, -100, 100, true));
			this.list_6.Add(new Class2(34, -100, 100, true));
			this.list_6.Add(new Class2(35, -100, 100, true));
			this.list_6.Add(new Class2(36, -100, 100, true));
			this.list_6.Add(new Class2(37, -100, 100, true));
			this.list_6.Add(new Class2(38, -100, 100, true));
			this.list_6.Add(new Class2(39, -100, 100, true));
			this.list_6.Add(new Class2(40, -100, 100, true));
			this.list_6.Add(new Class2(41, -100, 100, true));
			this.list_6.Add(new Class2(42, -100, 100, true));
			this.list_6.Add(new Class2(43, -100, 100, true));
			this.list_6.Add(new Class2(44, -100, 100, true));
			this.list_6.Add(new Class2(45, -100, 100, true));
			this.list_6.Add(new Class2(46, -100, 100, true));
			this.list_6.Add(new Class2(47, -100, 100, true));
			this.list_6.Add(new Class2(48, -100, 100, true));
			this.list_6.Add(new Class2(49, -100, 100, true));
		}

		public void intefeiseWorldLoader()
		{
			this.list_7.Add(new Class2(0, -25, 25, true));
			this.list_7.Add(new Class2(1, -25, 25, true));
			this.list_7.Add(new Class2(2, -25, 25, true));
			this.list_7.Add(new Class2(3, -25, 25, true));
			this.list_7.Add(new Class2(4, -25, 25, true));
			this.list_7.Add(new Class2(5, -25, 25, true));
			this.list_7.Add(new Class2(6, -25, 25, true));
			this.list_7.Add(new Class2(7, -25, 25, true));
			this.list_7.Add(new Class2(8, -100, 100, true));
			this.list_7.Add(new Class2(9, -100, 100, true));
			this.list_7.Add(new Class2(10, -100, 100, true));
			this.list_7.Add(new Class2(11, -100, 100, true));
			this.list_7.Add(new Class2(12, -100, 100, true));
			this.list_7.Add(new Class2(13, -100, 100, true));
			this.list_7.Add(new Class2(14, -100, 100, true));
			this.list_7.Add(new Class2(15, -100, 100, true));
			this.list_7.Add(new Class2(16, -100, 100, true));
			this.list_7.Add(new Class2(17, -100, 100, true));
			this.list_7.Add(new Class2(18, -100, 100, true));
			this.list_7.Add(new Class2(19, -100, 100, true));
			this.list_7.Add(new Class2(20, -100, 100, true));
			this.list_7.Add(new Class2(21, -100, 100, true));
			this.list_7.Add(new Class2(22, -100, 100, true));
			this.list_7.Add(new Class2(23, -100, 100, true));
			this.list_7.Add(new Class2(24, -100, 100, true));
			this.list_7.Add(new Class2(25, -100, 100, true));
			this.list_7.Add(new Class2(26, -100, 100, true));
			this.list_7.Add(new Class2(27, -100, 100, true));
			this.list_7.Add(new Class2(28, -100, 100, true));
			this.list_7.Add(new Class2(29, -100, 100, true));
			this.list_7.Add(new Class2(30, -100, 100, true));
			this.list_7.Add(new Class2(31, -100, 100, true));
			this.list_7.Add(new Class2(32, -100, 100, true));
			this.list_7.Add(new Class2(33, -100, 100, true));
			this.list_7.Add(new Class2(34, -100, 100, true));
			this.list_7.Add(new Class2(35, -100, 100, true));
			this.list_7.Add(new Class2(36, -100, 100, true));
			this.list_7.Add(new Class2(37, -100, 100, true));
			this.list_7.Add(new Class2(38, -100, 100, true));
			this.list_7.Add(new Class2(39, -100, 100, true));
			this.list_7.Add(new Class2(40, -100, 100, true));
			this.list_7.Add(new Class2(41, -100, 100, true));
			this.list_7.Add(new Class2(42, -100, 100, true));
			this.list_7.Add(new Class2(43, -100, 100, true));
			this.list_7.Add(new Class2(44, -100, 100, true));
			this.list_7.Add(new Class2(45, -100, 100, true));
			this.list_7.Add(new Class2(46, -100, 100, true));
			this.list_7.Add(new Class2(47, -100, 100, true));
			this.list_7.Add(new Class2(48, -100, 100, true));
			this.list_7.Add(new Class2(49, -100, 100, false));
			this.list_7.Add(new Class2(50, -100, 100, true));
			this.list_7.Add(new Class2(51, -100, 100, true));
			this.list_7.Add(new Class2(52, -100, 100, true));
			this.list_7.Add(new Class2(53, -100, 100, true));
			this.list_7.Add(new Class2(54, -100, 100, true));
			this.list_7.Add(new Class2(55, -100, 100, true));
			this.list_7.Add(new Class2(56, -100, 100, true));
			this.list_7.Add(new Class2(57, -100, 100, true));
			this.list_7.Add(new Class2(58, -100, 100, true));
			this.list_7.Add(new Class2(59, -100, 100, true));
			this.list_7.Add(new Class2(60, -1000, 1000, true));
			this.list_7.Add(new Class2(61, -1000, 1000, true));
			this.list_7.Add(new Class2(62, -1000, 1000, true));
			this.list_7.Add(new Class2(63, -100, 100, true));
			this.list_7.Add(new Class2(64, -100, 100, true));
			this.list_7.Add(new Class2(65, -100, 100, true));
			this.list_7.Add(new Class2(66, -100, 100, true));
			this.list_7.Add(new Class2(67, -100, 100, true));
			this.list_7.Add(new Class2(68, -1000, 1000, true));
			this.list_7.Add(new Class2(69, -1000, 1000, true));
			this.list_7.Add(new Class2(70, -1000, 1000, true));
			this.list_7.Add(new Class2(71, -100, 100, true));
			this.list_7.Add(new Class2(72, -100, 100, true));
			this.list_7.Add(new Class2(73, -100, 100, true));
			this.list_7.Add(new Class2(74, -100, 100, true));
			this.list_7.Add(new Class2(75, -100, 100, true));
			this.list_7.Add(new Class2(76, -1000, 1000, true));
			this.list_7.Add(new Class2(77, -1000, 1000, true));
			this.list_7.Add(new Class2(78, -1000, 1000, true));
			this.list_7.Add(new Class2(79, -100, 100, true));
			this.list_7.Add(new Class2(80, -100, 100, true));
			this.list_7.Add(new Class2(81, -100, 100, true));
			this.list_7.Add(new Class2(82, -100, 100, true));
			this.list_7.Add(new Class2(83, -100, 100, true));
			this.list_7.Add(new Class2(84, -1000, 1000, true));
			this.list_7.Add(new Class2(85, -100, 100, true));
			this.list_7.Add(new Class2(86, -1000, 1000, true));
			this.list_7.Add(new Class2(87, -10000, 10000, true));
			this.list_7.Add(new Class2(88, -100, 100, true));
			this.list_7.Add(new Class2(89, -100, 100, true));
			this.list_7.Add(new Class2(90, -100, 100, true));
			this.list_7.Add(new Class2(91, -100, 100, true));
			this.list_7.Add(new Class2(92, -100, 100, true));
			this.list_7.Add(new Class2(93, -100, 100, true));
			this.list_7.Add(new Class2(94, -100, 100, true));
			this.list_7.Add(new Class2(95, -100, 100, true));
			this.list_7.Add(new Class2(96, -100, 100, true));
			this.list_7.Add(new Class2(97, -100, 100, true));
			this.list_7.Add(new Class2(98, -100, 100, true));
			this.list_7.Add(new Class2(99, -100, 100, true));
			this.list_7.Add(new Class2(100, -100, 100, true));
			this.list_7.Add(new Class2(101, -100, 100, true));
			this.list_7.Add(new Class2(102, -100, 100, true));
			this.list_7.Add(new Class2(103, -100, 100, true));
			this.list_7.Add(new Class2(104, -100, 100, true));
			this.list_7.Add(new Class2(105, -100, 100, true));
			this.list_7.Add(new Class2(106, -100, 100, true));
			this.list_7.Add(new Class2(107, -100, 100, true));
			this.list_7.Add(new Class2(108, -100, 100, true));
			this.list_7.Add(new Class2(109, -100, 100, true));
			this.list_7.Add(new Class2(110, -100, 100, true));
			this.list_7.Add(new Class2(111, -100, 100, true));
			this.list_7.Add(new Class2(112, -100, 100, true));
			this.list_7.Add(new Class2(113, -100, 100, true));
			this.list_7.Add(new Class2(114, -100, 100, true));
			this.list_7.Add(new Class2(115, -100, 100, true));
			this.list_7.Add(new Class2(116, -100, 100, true));
			this.list_7.Add(new Class2(117, -100, 100, true));
			this.list_7.Add(new Class2(118, -100, 100, true));
			this.list_7.Add(new Class2(119, -100, 100, true));
			this.list_7.Add(new Class2(120, -100, 100, true));
			this.list_7.Add(new Class2(121, -100, 100, true));
			this.list_7.Add(new Class2(122, -100, 100, true));
			this.list_7.Add(new Class2(123, -100, 100, true));
			this.list_7.Add(new Class2(124, -100, 100, true));
			this.list_7.Add(new Class2(125, -100, 100, true));
			this.list_7.Add(new Class2(126, -100, 100, true));
			this.list_7.Add(new Class2(127, -100, 100, true));
			this.list_7.Add(new Class2(128, -100, 100, true));
			this.list_7.Add(new Class2(129, -100, 100, true));
			this.list_7.Add(new Class2(130, -100, 100, true));
			this.list_7.Add(new Class2(131, -100, 100, true));
			this.list_7.Add(new Class2(132, -100, 100, true));
			this.list_7.Add(new Class2(133, -100, 100, true));
			this.list_7.Add(new Class2(134, -100, 100, true));
			this.list_7.Add(new Class2(135, -100, 100, true));
			this.list_7.Add(new Class2(136, -100, 100, true));
			this.list_7.Add(new Class2(137, -100, 100, true));
			this.list_7.Add(new Class2(138, -100, 100, true));
			this.list_7.Add(new Class2(139, -100, 100, true));
			this.list_7.Add(new Class2(140, -100, 100, true));
			this.list_7.Add(new Class2(141, -100, 100, true));
			this.list_7.Add(new Class2(142, -100, 100, true));
			this.list_7.Add(new Class2(143, -100, 100, true));
			this.list_7.Add(new Class2(144, -100, 100, true));
			this.list_7.Add(new Class2(145, -100, 100, true));
			this.list_7.Add(new Class2(146, -100, 100, true));
			this.list_7.Add(new Class2(147, -100, 100, true));
			this.list_7.Add(new Class2(148, -100, 100, true));
			this.list_7.Add(new Class2(149, -100, 100, false));
			this.list_7.Add(new Class2(150, -100, 100, true));
			this.list_7.Add(new Class2(151, -100, 100, true));
			this.list_7.Add(new Class2(152, -100, 100, true));
			this.list_7.Add(new Class2(153, -100, 100, true));
			this.list_7.Add(new Class2(154, -100, 100, true));
			this.list_7.Add(new Class2(155, -100, 100, true));
			this.list_7.Add(new Class2(156, -100, 100, true));
			this.list_7.Add(new Class2(157, -100, 100, true));
			this.list_7.Add(new Class2(158, -100, 100, true));
			this.list_7.Add(new Class2(159, -100, 100, true));
			this.list_7.Add(new Class2(160, -1000, 1000, true));
			this.list_7.Add(new Class2(161, -100, 100, true));
			this.list_7.Add(new Class2(162, -1000, 1000, true));
			this.list_7.Add(new Class2(163, -100, 100, true));
			this.list_7.Add(new Class2(164, -100, 100, true));
			this.list_7.Add(new Class2(165, -100, 100, true));
			this.list_7.Add(new Class2(166, -100, 100, true));
			this.list_7.Add(new Class2(167, -100, 100, true));
			this.list_7.Add(new Class2(168, -1000, 1000, true));
			this.list_7.Add(new Class2(169, -100, 100, true));
			this.list_7.Add(new Class2(170, -1000, 1000, true));
			this.list_7.Add(new Class2(171, -100, 100, true));
			this.list_7.Add(new Class2(172, -100, 100, true));
			this.list_7.Add(new Class2(173, -100, 100, true));
			this.list_7.Add(new Class2(174, -100, 100, true));
			this.list_7.Add(new Class2(175, -100, 100, true));
			this.list_7.Add(new Class2(176, -1000, 1000, true));
			this.list_7.Add(new Class2(177, -100, 100, true));
			this.list_7.Add(new Class2(178, -1000, 1000, true));
			this.list_7.Add(new Class2(179, -1000, 1000, true));
			this.list_7.Add(new Class2(180, -100, 100, true));
			this.list_7.Add(new Class2(181, -100, 100, true));
			this.list_7.Add(new Class2(182, -100, 100, true));
			this.list_7.Add(new Class2(183, -100, 100, true));
			this.list_7.Add(new Class2(184, -100, 100, true));
			this.list_7.Add(new Class2(185, -100, 100, true));
			this.list_7.Add(new Class2(186, -10000, 10000, true));
			this.list_7.Add(new Class2(187, -10000, 10000, true));
			this.list_7.Add(new Class2(188, -100, 100, true));
			this.list_7.Add(new Class2(189, -100, 100, true));
			this.list_7.Add(new Class2(190, -100, 100, true));
			this.list_7.Add(new Class2(191, -100, 100, true));
			this.list_7.Add(new Class2(192, -100, 100, true));
			this.list_7.Add(new Class2(193, -100, 100, true));
			this.list_7.Add(new Class2(194, -100, 100, true));
			this.list_7.Add(new Class2(195, -100, 100, true));
			this.list_7.Add(new Class2(196, -100, 100, true));
			this.list_7.Add(new Class2(197, -100, 100, true));
			this.list_7.Add(new Class2(198, -100, 100, true));
			this.list_7.Add(new Class2(199, -100, 100, true));
		}

		private void klepPyofr(object sender, EventArgs e)
		{
			this.method_5();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://invulnerable-pages.000webhostapp.com/lol.php");
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://invulnerable-pages.000webhostapp.com/lol.php");
		}

		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://invulnerable-pages.000webhostapp.com/lol.php");
		}

		private void method_0()
		{
			bool flag = true;
			while (flag)
			{
				this.method_1();
				this.int_2 = this.class3_0.method_13((IntPtr)this.int_0 + this.int_1);
				this.int_4 = this.class3_0.method_13(((IntPtr)this.int_0 + this.int_3) + 4 * this.int_5);
				Thread.Sleep(200);
			}
		}

		private void method_1()
		{
			if ((int)Process.GetProcessesByName(this.string_2).Length == 0)
			{
				this.bool_0 = true;
			}
			if (this.bool_0)
			{
				this.class3_0.method_0();
				this.string_2 = this.class3_0.method_1();
				this.string_3 = this.class3_0.method_2();
				this.intptr_0 = this.class3_0.method_3();
				this.int_0 = this.class3_0.method_4(this.string_3);
				if (this.intptr_0 != (IntPtr)-1)
				{
					this.bool_0 = false;
				}
			}
		}

		private void method_2()
		{
			Process.GetCurrentProcess().Kill();
		}

		private void method_3(object sender, EventArgs e)
		{
			TrackBar trackBar = sender as TrackBar;
			Label item = this.list_2[Convert.ToInt32(trackBar.Name)];
			float value = (float)trackBar.Value / 1000f;
			item.Text = value.ToString();
			if (!this.bool_1)
			{
				this.class3_0.method_24((((IntPtr)this.int_2 + 48) + 4 * Convert.ToInt32(trackBar.Name)) + this.comboBoxCarMaterial.SelectedIndex * 260, (float)trackBar.Value / 1000f);
			}
		}

		private void method_4(object sender, EventArgs e)
		{
			TrackBar trackBar = sender as TrackBar;
			Label item = this.list_5[Convert.ToInt32(trackBar.Name)];
			float value = (float)trackBar.Value / 1000f;
			item.Text = value.ToString();
			if (!this.bool_1)
			{
				this.class3_0.method_24(((IntPtr)this.int_4 + 400) + 4 * Convert.ToInt32(trackBar.Name), (float)trackBar.Value / 1000f);
			}
		}

		private void method_5()
		{
			if (!this.bool_0)
			{
				this.bool_1 = true;
				for (int i = 0; i < 50; i++)
				{
					try
					{
						this.list_0[i].Value = Convert.ToInt32(this.class3_0.method_18((((IntPtr)this.int_2 + 48) + 4 * i) + this.comboBoxCarMaterial.SelectedIndex * 260) * 1000f);
					}
					catch
					{
						this.list_0[i].Maximum = 100;
						this.list_0[i].Minimum = -100;
						try
						{
							this.list_0[i].Value = Convert.ToInt32(this.class3_0.method_18((((IntPtr)this.int_2 + 48) + 4 * i) + this.comboBoxCarMaterial.SelectedIndex * 260) * 100f);
						}
						catch
						{
							try
							{
								this.list_0[i].Value = Convert.ToInt32(this.class3_0.method_18((((IntPtr)this.int_2 + 48) + 4 * i) + this.comboBoxCarMaterial.SelectedIndex * 260));
							}
							catch
							{
							}
						}
					}
				}
				this.bool_1 = false;
			}
		}

		private void method_6()
		{
			if (!this.bool_0)
			{
				this.bool_1 = true;
				for (int i = 0; i < 200; i++)
				{
					try
					{
						this.list_3[i].Value = Convert.ToInt32(this.class3_0.method_18(((IntPtr)this.int_4 + 400) + 4 * i) * 1000f);
					}
					catch
					{
						this.list_3[i].Maximum = 100;
						this.list_3[i].Minimum = -100;
						try
						{
							this.list_3[i].Value = Convert.ToInt32(this.class3_0.method_18(((IntPtr)this.int_4 + 400) + 4 * i) * 100f);
						}
						catch
						{
							try
							{
								this.list_3[i].Value = Convert.ToInt32(this.class3_0.method_18(((IntPtr)this.int_4 + 400) + 4 * i));
							}
							catch
							{
							}
						}
					}
				}
				this.bool_1 = false;
			}
		}

		private void method_7()
		{
			string str = "World";
			this.list_9.Add(new Class1(str.ToLower(), 0));
			this.comboBoxWorldMaterial.Items.Add(str);
			str = "Garage";
			this.list_9.Add(new Class1(str.ToLower(), 1));
			this.comboBoxWorldMaterial.Items.Add(str);
			str = "Scene";
			this.list_9.Add(new Class1(str.ToLower(), 2));
			this.comboBoxWorldMaterial.Items.Add(str);
			this.comboBoxWorldMaterial.SelectedIndex = 0;
		}

		private void method_8()
		{
			this.listBox1.Items.Clear();
			string str = string.Concat(Directory.GetCurrentDirectory(), "\\Shaders");
			if (!Directory.Exists(str))
			{
				Directory.CreateDirectory(str);
			}
			foreach (string str1 in Directory.EnumerateFiles(str, "*.xml"))
			{
				string str2 = "";
				str2 = str1.Substring(str.Length + 1);
				str2 = str2.Substring(0, str2.Length - 4);
				this.listBox1.Items.Add(str2);
			}
		}

		private void obrqvaVjM()
		{
			string str = "Aaaa";
			this.list_8.Add(new Class1(str.ToLower(), 0));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Aluminum";
			this.list_8.Add(new Class1(str.ToLower(), 1));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Bottom";
			this.list_8.Add(new Class1(str.ToLower(), 2));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "BrakeDisc";
			this.list_8.Add(new Class1(str.ToLower(), 3));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "BrakeLight";
			this.list_8.Add(new Class1(str.ToLower(), 4));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "BrakeLightdullPlastic";
			this.list_8.Add(new Class1(str.ToLower(), 5));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "BrakeLightdullPlastic_on";
			this.list_8.Add(new Class1(str.ToLower(), 6));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "BrakeLightglass";
			this.list_8.Add(new Class1(str.ToLower(), 7));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "BrakeLightglassRed";
			this.list_8.Add(new Class1(str.ToLower(), 8));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "BrakeLightglassRed_on";
			this.list_8.Add(new Class1(str.ToLower(), 9));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "BrakeLightglass_on";
			this.list_8.Add(new Class1(str.ToLower(), 10));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "BrakeLight_on";
			this.list_8.Add(new Class1(str.ToLower(), 11));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Caliper";
			this.list_8.Add(new Class1(str.ToLower(), 12));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "CandyPaintBlack";
			this.list_8.Add(new Class1(str.ToLower(), 13));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "CandyPaintBlue";
			this.list_8.Add(new Class1(str.ToLower(), 14));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "CandyPaintGreen";
			this.list_8.Add(new Class1(str.ToLower(), 15));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "CandyPaintIndigo";
			this.list_8.Add(new Class1(str.ToLower(), 16));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "CandyPaintRed";
			this.list_8.Add(new Class1(str.ToLower(), 17));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "CandyPaintViolet";
			this.list_8.Add(new Class1(str.ToLower(), 18));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "CandyPaintWhite";
			this.list_8.Add(new Class1(str.ToLower(), 19));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "CandyPaintYellow";
			this.list_8.Add(new Class1(str.ToLower(), 20));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "CarbonFiber";
			this.list_8.Add(new Class1(str.ToLower(), 21));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Char_cloth";
			this.list_8.Add(new Class1(str.ToLower(), 22));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Char_hair";
			this.list_8.Add(new Class1(str.ToLower(), 23));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Char_hair_angie";
			this.list_8.Add(new Class1(str.ToLower(), 24));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Char_hair_kenji";
			this.list_8.Add(new Class1(str.ToLower(), 25));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Char_hair_neville";
			this.list_8.Add(new Class1(str.ToLower(), 26));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Char_hair_wolf";
			this.list_8.Add(new Class1(str.ToLower(), 27));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Char_latex";
			this.list_8.Add(new Class1(str.ToLower(), 28));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Char_leather";
			this.list_8.Add(new Class1(str.ToLower(), 29));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Char_Plastic";
			this.list_8.Add(new Class1(str.ToLower(), 30));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Char_rubber";
			this.list_8.Add(new Class1(str.ToLower(), 31));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Char_skin";
			this.list_8.Add(new Class1(str.ToLower(), 32));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Char_skin_angie";
			this.list_8.Add(new Class1(str.ToLower(), 33));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Char_skin_darius";
			this.list_8.Add(new Class1(str.ToLower(), 34));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Char_skin_kenji";
			this.list_8.Add(new Class1(str.ToLower(), 35));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Char_skin_neville";
			this.list_8.Add(new Class1(str.ToLower(), 36));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Char_skin_wolf";
			this.list_8.Add(new Class1(str.ToLower(), 37));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Chrome";
			this.list_8.Add(new Class1(str.ToLower(), 38));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "ChromePaintBlack";
			this.list_8.Add(new Class1(str.ToLower(), 39));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "ChromePaintBlue";
			this.list_8.Add(new Class1(str.ToLower(), 40));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "ChromePaintGreen";
			this.list_8.Add(new Class1(str.ToLower(), 41));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "ChromePaintIndigo";
			this.list_8.Add(new Class1(str.ToLower(), 42));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "ChromePaintRed";
			this.list_8.Add(new Class1(str.ToLower(), 43));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "ChromePaintViolet";
			this.list_8.Add(new Class1(str.ToLower(), 44));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "ChromePaintWhite";
			this.list_8.Add(new Class1(str.ToLower(), 45));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "ChromePaintYellow";
			this.list_8.Add(new Class1(str.ToLower(), 46));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "ClearPlastic";
			this.list_8.Add(new Class1(str.ToLower(), 47));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "CopPaint";
			this.list_8.Add(new Class1(str.ToLower(), 48));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Damage";
			this.list_8.Add(new Class1(str.ToLower(), 49));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Decal";
			this.list_8.Add(new Class1(str.ToLower(), 50));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "DecalDull";
			this.list_8.Add(new Class1(str.ToLower(), 51));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Default";
			this.list_8.Add(new Class1(str.ToLower(), 52));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "DoorLine";
			this.list_8.Add(new Class1(str.ToLower(), 53));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Driver";
			this.list_8.Add(new Class1(str.ToLower(), 54));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "DullPlastic";
			this.list_8.Add(new Class1(str.ToLower(), 55));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "DullPlastict";
			this.list_8.Add(new Class1(str.ToLower(), 56));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Engine";
			this.list_8.Add(new Class1(str.ToLower(), 57));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Grill";
			this.list_8.Add(new Class1(str.ToLower(), 58));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "GrillChrome";
			this.list_8.Add(new Class1(str.ToLower(), 59));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "HeadLightGlass";
			this.list_8.Add(new Class1(str.ToLower(), 60));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "HeadLightReflector";
			this.list_8.Add(new Class1(str.ToLower(), 61));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "HlChrome";
			this.list_8.Add(new Class1(str.ToLower(), 62));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "HldullPlastic";
			this.list_8.Add(new Class1(str.ToLower(), 63));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Interior";
			this.list_8.Add(new Class1(str.ToLower(), 64));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "IridPaintBlack";
			this.list_8.Add(new Class1(str.ToLower(), 65));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "IridPaintBlue";
			this.list_8.Add(new Class1(str.ToLower(), 66));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "IridPaintGreen";
			this.list_8.Add(new Class1(str.ToLower(), 67));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "IridPaintIndigo";
			this.list_8.Add(new Class1(str.ToLower(), 68));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "IridPaintRed";
			this.list_8.Add(new Class1(str.ToLower(), 69));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "IridPaintViolet";
			this.list_8.Add(new Class1(str.ToLower(), 70));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "IridPaintWhite";
			this.list_8.Add(new Class1(str.ToLower(), 71));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "IridPaintYellow";
			this.list_8.Add(new Class1(str.ToLower(), 72));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "LicensePlate";
			this.list_8.Add(new Class1(str.ToLower(), 73));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagChrome";
			this.list_8.Add(new Class1(str.ToLower(), 74));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagChromeBlack";
			this.list_8.Add(new Class1(str.ToLower(), 75));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagChromeBlue";
			this.list_8.Add(new Class1(str.ToLower(), 76));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagChromeGreen";
			this.list_8.Add(new Class1(str.ToLower(), 77));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagChromeIndigo";
			this.list_8.Add(new Class1(str.ToLower(), 78));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagChromeRed";
			this.list_8.Add(new Class1(str.ToLower(), 79));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagChromeViolet";
			this.list_8.Add(new Class1(str.ToLower(), 80));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagChromeWhite";
			this.list_8.Add(new Class1(str.ToLower(), 81));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagChromeYellow";
			this.list_8.Add(new Class1(str.ToLower(), 82));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Maglip";
			this.list_8.Add(new Class1(str.ToLower(), 83));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagMatte";
			this.list_8.Add(new Class1(str.ToLower(), 84));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagMatteBlack";
			this.list_8.Add(new Class1(str.ToLower(), 85));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagMatteBlue";
			this.list_8.Add(new Class1(str.ToLower(), 86));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagMatteGreen";
			this.list_8.Add(new Class1(str.ToLower(), 87));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagMatteIndigo";
			this.list_8.Add(new Class1(str.ToLower(), 88));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagMatteRed";
			this.list_8.Add(new Class1(str.ToLower(), 89));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagMatteViolet";
			this.list_8.Add(new Class1(str.ToLower(), 90));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagMatteWhite";
			this.list_8.Add(new Class1(str.ToLower(), 91));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagMatteYellow";
			this.list_8.Add(new Class1(str.ToLower(), 92));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagmetBlack";
			this.list_8.Add(new Class1(str.ToLower(), 93));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagmetBlue";
			this.list_8.Add(new Class1(str.ToLower(), 94));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagmetGreen";
			this.list_8.Add(new Class1(str.ToLower(), 95));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagmetIndigo";
			this.list_8.Add(new Class1(str.ToLower(), 96));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagmetRed";
			this.list_8.Add(new Class1(str.ToLower(), 97));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagmetViolet";
			this.list_8.Add(new Class1(str.ToLower(), 98));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagmetWhite";
			this.list_8.Add(new Class1(str.ToLower(), 99));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagmetYellow";
			this.list_8.Add(new Class1(str.ToLower(), 100));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MagSilver";
			this.list_8.Add(new Class1(str.ToLower(), 101));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MattePaintBlack";
			this.list_8.Add(new Class1(str.ToLower(), 102));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MattePaintBlue";
			this.list_8.Add(new Class1(str.ToLower(), 103));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MattePaintGreen";
			this.list_8.Add(new Class1(str.ToLower(), 104));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MattePaintIndigo";
			this.list_8.Add(new Class1(str.ToLower(), 105));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MattePaintRed";
			this.list_8.Add(new Class1(str.ToLower(), 106));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MattePaintViolet";
			this.list_8.Add(new Class1(str.ToLower(), 107));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MattePaintWhite";
			this.list_8.Add(new Class1(str.ToLower(), 108));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MattePaintYellow";
			this.list_8.Add(new Class1(str.ToLower(), 109));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MetPaintBlack";
			this.list_8.Add(new Class1(str.ToLower(), 110));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MetPaintBlue";
			this.list_8.Add(new Class1(str.ToLower(), 111));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MetPaintGreen";
			this.list_8.Add(new Class1(str.ToLower(), 112));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MetPaintIndigo";
			this.list_8.Add(new Class1(str.ToLower(), 113));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MetPaintRed";
			this.list_8.Add(new Class1(str.ToLower(), 114));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MetPaintViolet";
			this.list_8.Add(new Class1(str.ToLower(), 115));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MetPaintWhite";
			this.list_8.Add(new Class1(str.ToLower(), 116));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "MetPaintYellow";
			this.list_8.Add(new Class1(str.ToLower(), 117));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "PearlPaintBlack";
			this.list_8.Add(new Class1(str.ToLower(), 118));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "PearlPaintBlue";
			this.list_8.Add(new Class1(str.ToLower(), 119));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "PearlPaintGreen";
			this.list_8.Add(new Class1(str.ToLower(), 120));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "PearlPaintIndigo";
			this.list_8.Add(new Class1(str.ToLower(), 121));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "PearlPaintRed";
			this.list_8.Add(new Class1(str.ToLower(), 122));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "PearlPaintViolet";
			this.list_8.Add(new Class1(str.ToLower(), 123));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "PearlPaintWhite";
			this.list_8.Add(new Class1(str.ToLower(), 124));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "PearlPaintYellow";
			this.list_8.Add(new Class1(str.ToLower(), 125));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "PlainNothing";
			this.list_8.Add(new Class1(str.ToLower(), 126));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Rad";
			this.list_8.Add(new Class1(str.ToLower(), 127));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "ReflectiveSign";
			this.list_8.Add(new Class1(str.ToLower(), 128));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "RegPaintBlack";
			this.list_8.Add(new Class1(str.ToLower(), 129));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "RegPaintBlue";
			this.list_8.Add(new Class1(str.ToLower(), 130));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "RegPaintGreen";
			this.list_8.Add(new Class1(str.ToLower(), 131));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "RegPaintIndigo";
			this.list_8.Add(new Class1(str.ToLower(), 132));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "RegPaintRed";
			this.list_8.Add(new Class1(str.ToLower(), 133));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "RegPaintViolet";
			this.list_8.Add(new Class1(str.ToLower(), 134));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "RegPaintWhite";
			this.list_8.Add(new Class1(str.ToLower(), 135));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "RegPaintYellow";
			this.list_8.Add(new Class1(str.ToLower(), 136));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Road";
			this.list_8.Add(new Class1(str.ToLower(), 137));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Rubber";
			this.list_8.Add(new Class1(str.ToLower(), 138));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "Traffic";
			this.list_8.Add(new Class1(str.ToLower(), 139));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "TrafficWindows";
			this.list_8.Add(new Class1(str.ToLower(), 140));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "WindowMask";
			this.list_8.Add(new Class1(str.ToLower(), 141));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "WindShield";
			this.list_8.Add(new Class1(str.ToLower(), 142));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "WindShield_tint_l1_Black";
			this.list_8.Add(new Class1(str.ToLower(), 143));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "WindShield_tint_l1_Blue";
			this.list_8.Add(new Class1(str.ToLower(), 144));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "WindShield_tint_l1_Green";
			this.list_8.Add(new Class1(str.ToLower(), 145));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "WindShield_tint_l1_Indigo";
			this.list_8.Add(new Class1(str.ToLower(), 146));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "WindShield_tint_l1_Red";
			this.list_8.Add(new Class1(str.ToLower(), 147));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "WindShield_tint_l1_Silver";
			this.list_8.Add(new Class1(str.ToLower(), 148));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "WindShield_tint_l1_Violet";
			this.list_8.Add(new Class1(str.ToLower(), 149));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "WindShield_tint_l1_Yellow";
			this.list_8.Add(new Class1(str.ToLower(), 150));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "WindShield_tint_l3_Black";
			this.list_8.Add(new Class1(str.ToLower(), 151));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "WindShield_tint_l3_Blue";
			this.list_8.Add(new Class1(str.ToLower(), 152));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "WindShield_tint_l3_Green";
			this.list_8.Add(new Class1(str.ToLower(), 153));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "WindShield_tint_l3_Indigo";
			this.list_8.Add(new Class1(str.ToLower(), 154));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "WindShield_tint_l3_Red";
			this.list_8.Add(new Class1(str.ToLower(), 155));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "WindShield_tint_l3_Silver";
			this.list_8.Add(new Class1(str.ToLower(), 156));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "WindShield_tint_l3_Violet";
			this.list_8.Add(new Class1(str.ToLower(), 157));
			this.comboBoxCarMaterial.Items.Add(str);
			str = "WindShield_tint_l3_Yellow";
			this.list_8.Add(new Class1(str.ToLower(), 158));
			this.comboBoxCarMaterial.Items.Add(str);
			this.comboBoxCarMaterial.SelectedIndex = 0;
		}

		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (this.int_6 <= 6)
			{
				this.int_6++;
			}
			else
			{
				this.int_6 = 0;
			}
			base.Invalidate();
			if (!this.bool_0 && !this.bool_1)
			{
				for (int i = 0; i < 200; i++)
				{
					try
					{
						this.class3_0.method_24(((IntPtr)this.int_4 + 400) + 4 * i, (float)this.list_3[i].Value / 1000f);
					}
					catch
					{
					}
				}
			}
		}
	}
}