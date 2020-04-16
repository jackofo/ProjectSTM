using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSTM
{
	public partial class Form1 : Form
	{
		string endMessage;
		short spaceLeft;
		bool player; //true - player1; false - player2
		static int i = 0, j = 0;
		Label[,] ttt;
		Thread readThread;
		string data;
		bool newCommand;
		Size windowSize;

		public Form1()
		{
			InitializeComponent();
			//consoleBox.Text = data; // set console text to received data from com
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			spaceLeft = 9;
			player = true;
			tabControl1.Selecting += tab_control_Selecting; // event - prevent choosing tabs
			ttt = new Label[3, 3]; //
			ttt[0, 0] = label6; //
			ttt[0, 1] = label7; //
			ttt[0, 2] = label8; //
			ttt[1, 0] = label11; //
			ttt[1, 1] = label10; //
			ttt[1, 2] = label9; //
			ttt[2, 0] = label14; //
			ttt[2, 1] = label13; //
			ttt[2, 2] = label12; // put tic tac toe objects to array for easier access
			foreach (Label label in ttt)
			{
				label.Visible = false; // hide all tic tac toe objects befor play
			}
			windowSize = this.Size;
			this.FormClosing += (Object s, FormClosingEventArgs fe) => serialPort1.Close(); // close port when before closing window
			data = ""; // just set default data value to nothing
			newCommand = false;
			consoleBox.TextChanged += (Object s, EventArgs fe) =>
			 {
				 consoleBox.SelectionStart = consoleBox.TextLength;
				 consoleBox.ScrollToCaret();
			 };
			string[] comPorts = SerialPort.GetPortNames(); //
			comPortsCB.Items.AddRange(comPorts); // put available com ports to combobox
			if (comPorts != null)
			{
				comPortsCB.SelectedIndex = 0; //
			}
			baudRateCB.SelectedIndex = 2; //
			dataBitsCB.SelectedIndex = 0; //
			parityCB.SelectedIndex = 1; //
			stopBitsCB.SelectedIndex = 0; // set default combobox values
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				serialPort1.PortName = comPortsCB.Text; //
				serialPort1.BaudRate = int.Parse(baudRateCB.Text); //
				serialPort1.DataBits = int.Parse(dataBitsCB.Text); //
				switch (stopBitsCB.Text)
				{
					case "1":
						serialPort1.StopBits = StopBits.One; //
						break;
					case "1.5":
						serialPort1.StopBits = StopBits.OnePointFive; //
						break;
					case "2":
						serialPort1.StopBits = StopBits.Two; //
						break;
					default:
						break; //
				}
				switch (parityCB.Text)
				{
					case "None":
						serialPort1.Parity = Parity.None; //
						break;
					case "Even":
						serialPort1.Parity = Parity.Even; //
						break;
					case "Odd":
						serialPort1.Parity = Parity.Odd; //
						break;
					default:
						break; //
				} // set serial port settings according to comboboxes
				serialPort1.DataReceived += new SerialDataReceivedEventHandler(COMRead); // add behaviour to receiving data event
				serialPort1.Open(); // open communication with com port
				button1.Enabled = false; // disable button to avoid rerunning this click method
				groupBox1.Visible = false; // hide connection settings
				tabControl1.Selecting -= tab_control_Selecting; // 
				tabControl1.SelectedIndex = 1; //
				tabControl1.Selecting += tab_control_Selecting2; // change tab
				consoleBox.Text += "Press blue button to start\r\n"; //
				readThread = new Thread(Game); //
				readThread.Start(); // run game
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // show exception in window
			}
		}

		delegate void GameDelegate();
		delegate void GameDelegate2(int i, int j);

		void Game()
		{
			if (CheckCommand("a", "DUPA"))
			{
				//Thread.Sleep(100);
				if (CheckCommand("b", "show"))
				{
					foreach (Label label in ttt)
					{
						//label.Visible = true;
						this.BeginInvoke(new GameDelegate(() => label.Visible = true));
					}
					this.BeginInvoke(new GameDelegate(() => ttt[i, j].BackColor = Color.Aqua));
					try
					{
						while (true)
						{
							this.BeginInvoke(new CheckCommandDelegate(ConsoleWrite), new object[] { "Player " + (player ? "1" : "2") + " round\r\n" });
							if (CheckCommand("n", "NEXT", "OKOK"))
							{
								if (data == "NEXT")
								{
									this.BeginInvoke(new GameDelegate(ChangeTile));
								}
								else if (data == "OKOK")
								{
									if (player)
									{
										this.BeginInvoke(new GameDelegate(() => ttt[i, j].Text = "X"));
										bool win = false;
										for (int a = 0; a < 3; a++)
										{
											string s = "";
											string sss = "";
											for (int b = 0; b < 3; b++)
											{
												s += ttt[a, b].Text;
												sss += ttt[b, a].Text;
											}
											if (s == "XXX" || sss == "XXX")
											{
												win = true;
											}
										}
										string ss = "";
										for (int a = 0; a < 3; a++)
										{
											ss += ttt[a, a].Text;
										}
										if (ss == "XXX")
										{
											win = true;
										}
										if (ttt[0, 2].Text + ttt[1, 1].Text + ttt[2, 0].Text == "XXX")
										{
											win = true;
										}
										if (win)
										{
											endMessage = "Player 1 (X) won!";
											serialPort1.Write("g");
											break;
										}
									}
									else
									{
										this.BeginInvoke(new GameDelegate(() => ttt[i, j].Text = "O"));
										bool win = false;
										for (int a = 0; a < 3; a++)
										{
											string s = "";
											string sss = "";
											for (int b = 0; b < 3; b++)
											{
												s += ttt[a, b].Text;
												sss += ttt[b, a].Text;
											}
											if (s == "OOO" || sss == "OOO")
											{
												win = true;
											}
										}
										string ss = "";
										for (int a = 0; a < 3; a++)
										{
											ss += ttt[a, a].Text;
										}
										if (ss == "OOO")
										{
											win = true;
										}
										if (ttt[0, 2].Text + ttt[1, 1].Text + ttt[2, 0].Text == "OOO")
										{
											win = true;
										}
										if (win)
										{
											endMessage = "Player 2 (O) won!";
											serialPort1.Write("h");
											break;
										}
									}
									player = !player;
									spaceLeft--;
									if (spaceLeft == 0)
									{
										if (CheckCommand("e", "ENDD"))
										{
											if (endMessage == null)
											{
												endMessage = "DRAW!";
											}
										}
										break;
									}
									this.BeginInvoke(new GameDelegate(ChangeTile));
								}
							}
						}
					}
					catch (ThreadInterruptedException ex)
					{
						Console.WriteLine(ex);
					}
				}
			}
			Console.WriteLine("!!!!!!!!!!!!!!!!!!!END!!!!!!!!!!!!");
			this.BeginInvoke(new CheckCommandDelegate(ConsoleWrite), new object[] { endMessage });
			PlayMario();
		}

		void ChangeTile()
		{
			ttt[i, j].BackColor = Color.Gray;
			do
			{
				j++;
				if (j > 2)
				{
					j = 0;
					i++;
					if (i > 2)
					{
						i = 0;
					}
				}
			}
			while (ttt[i, j].Text == "X" || ttt[i, j].Text == "O");
			ttt[i, j].BackColor = Color.Aqua;
			Console.WriteLine(i + " " + j);
		}

		void ConsoleWrite(string text)
		{
			consoleBox.Text += text;
		}

		delegate void CheckCommandDelegate(string s);

		bool CheckCommand(string responseToken, string command, string command1)// checking if command received from serial port match expecting command
		{
			try
			{
				serialPort1.Write(responseToken);
				this.BeginInvoke(new CheckCommandDelegate(ConsoleWrite), new object[] { "Send info to controller\r\nWaiting for response" });
				while (!newCommand)
				{
					//consoleBox.Text += ".";
					this.BeginInvoke(new CheckCommandDelegate(ConsoleWrite), new object[] { "." });
					//this.Refresh();
					Thread.Sleep(1000);
				}
				//consoleBox.Text += "\r\n";
				this.BeginInvoke(new CheckCommandDelegate(ConsoleWrite), new object[] { "\r\n" });
				if (data == command)
				{
					//consoleBox.Text += "Successful!";
					this.BeginInvoke(new CheckCommandDelegate(ConsoleWrite), new object[] { "Successful!\r\n" });
					newCommand = false;
					return true;
				}
				else if (data == command1)
				{
					this.BeginInvoke(new CheckCommandDelegate(ConsoleWrite), new object[] { "Successful!\r\n" });
					newCommand = false;
					return true;
				}
				else
				{
					//consoleBox.Text += "Failed.";
					this.BeginInvoke(new CheckCommandDelegate(ConsoleWrite), new object[] { "Failed\r\n" });
					newCommand = false;
					return false;
				}
			}
			catch (InvalidOperationException ex)
			{
				Console.WriteLine(ex);
				return false;
			}
		}

		bool CheckCommand(string responseToken, string command)// checking if command received from serial port match expecting command
		{
			try
			{
				serialPort1.Write(responseToken);
				this.BeginInvoke(new CheckCommandDelegate(ConsoleWrite), new object[] { "Send info to controller\r\nWaiting for response" });
				while (!newCommand)
				{
					//consoleBox.Text += ".";
					this.BeginInvoke(new CheckCommandDelegate(ConsoleWrite), new object[] { "." });
					//this.Refresh();
					Thread.Sleep(1000);
				}
				//consoleBox.Text += "\r\n";
				this.BeginInvoke(new CheckCommandDelegate(ConsoleWrite), new object[] { "\r\n" });
				if (data == command)
				{
					//consoleBox.Text += "Successful!";
					this.BeginInvoke(new CheckCommandDelegate(ConsoleWrite), new object[] { "Successful!\r\n" });
					newCommand = false;
					return true;
				}
				else
				{
					//consoleBox.Text += "Failed.";
					this.BeginInvoke(new CheckCommandDelegate(ConsoleWrite), new object[] { "Failed\r\n" });
					newCommand = false;
					return false;
				}
			}
			catch (InvalidOperationException ex)
			{
				Console.WriteLine(ex);
				return false;
			}
		}

		delegate void COMReadDelegate(string s);

		void COMRead(object sender, SerialDataReceivedEventArgs e)
		{
			if (serialPort1.IsOpen)
			{
				try
				{
					data = serialPort1.ReadLine(); // set variable 'data' to received data
												   //this.BeginInvoke(new COMReadDelegate((data) => consoleBox.Text += data + "\r\n"), new object[] { data }); // set console text to recived data through variable 'data'
					newCommand = true;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex);
				}
				Console.WriteLine(data);
			}
		}

		void Write(string data) { consoleBox.Text = data; this.Refresh(); }

		private void tab_control_Selecting(object sender, TabControlCancelEventArgs e)
		{
			if (e.TabPage == tabPage2)
			{
				e.Cancel = true;
			}
		}
		private void tab_control_Selecting2(object sender, TabControlCancelEventArgs e)
		{
			if (e.TabPage == tabPage1)
			{
				e.Cancel = true;
			}
		}

		void PlayMario()
		{
			//	Console.Beep(330, 100); Thread.Sleep(100);
			//	Console.Beep(330, 100); Thread.Sleep(300);
			//	Console.Beep(330, 100); Thread.Sleep(300);
			//	Console.Beep(262, 100); Thread.Sleep(100);
			//	Console.Beep(330, 100); Thread.Sleep(300);
			//	Console.Beep(392, 100); Thread.Sleep(700);
			//	Console.Beep(196, 100); Thread.Sleep(700);
			//	Console.Beep(262, 300); Thread.Sleep(300);
			//	Console.Beep(196, 300); Thread.Sleep(300);
			//	Console.Beep(164, 300); Thread.Sleep(300);
			//	Console.Beep(220, 300); Thread.Sleep(100);
			//	Console.Beep(246, 100); Thread.Sleep(300);
			//	Console.Beep(233, 200);
			//	Console.Beep(220, 100); Thread.Sleep(300);
			//	Console.Beep(196, 100); Thread.Sleep(150);
			//	Console.Beep(330, 100); Thread.Sleep(150);
			//	Console.Beep(392, 100); Thread.Sleep(150);
			//	Console.Beep(440, 100); Thread.Sleep(300);
			//	Console.Beep(349, 100); Thread.Sleep(100);
			//	Console.Beep(392, 100); Thread.Sleep(300);
			//	Console.Beep(330, 100); Thread.Sleep(300);
			//	Console.Beep(262, 100); Thread.Sleep(100);
			//	Console.Beep(294, 100); Thread.Sleep(100);
			//	Console.Beep(247, 100); Thread.Sleep(500);
			//	Console.Beep(262, 300); Thread.Sleep(300);
			//	Console.Beep(196, 300); Thread.Sleep(300);
			//	Console.Beep(164, 300); Thread.Sleep(300);
			//	Console.Beep(220, 300); Thread.Sleep(100);
			//	Console.Beep(246, 100); Thread.Sleep(300);
			//	Console.Beep(233, 200);
			//	Console.Beep(220, 100); Thread.Sleep(300);
			//	Console.Beep(196, 100); Thread.Sleep(150);
			//	Console.Beep(330, 100); Thread.Sleep(150);
			//	Console.Beep(392, 100); Thread.Sleep(150);
			//	Console.Beep(440, 100); Thread.Sleep(300);
			//	Console.Beep(349, 100); Thread.Sleep(100);
			//	Console.Beep(392, 100); Thread.Sleep(300);
			//	Console.Beep(330, 100); Thread.Sleep(300);
			//	Console.Beep(262, 100); Thread.Sleep(100);
			//	Console.Beep(294, 100); Thread.Sleep(100);
			//	Console.Beep(247, 100); Thread.Sleep(900);
			//	Console.Beep(392, 100); Thread.Sleep(100);
			//	Console.Beep(370, 100); Thread.Sleep(100);
			//	Console.Beep(349, 100); Thread.Sleep(100);
			//	Console.Beep(311, 100); Thread.Sleep(300);
			//	Console.Beep(330, 100); Thread.Sleep(300);
			//	Console.Beep(207, 100); Thread.Sleep(100);
			//	Console.Beep(220, 100); Thread.Sleep(100);
			//	Console.Beep(262, 100); Thread.Sleep(300);
			//	Console.Beep(220, 100); Thread.Sleep(100);
			//	Console.Beep(262, 100); Thread.Sleep(100);
			//	Console.Beep(294, 100); Thread.Sleep(500);
			//	Console.Beep(392, 100); Thread.Sleep(100);
			//	Console.Beep(370, 100); Thread.Sleep(100);
			//	Console.Beep(349, 100); Thread.Sleep(100);
			//	Console.Beep(311, 100); Thread.Sleep(300);
			//	Console.Beep(330, 100); Thread.Sleep(300);
			//	Console.Beep(523, 100); Thread.Sleep(300);
			//	Console.Beep(523, 100); Thread.Sleep(100);
			//	Console.Beep(523, 100); Thread.Sleep(1100);
			//	Console.Beep(392, 100); Thread.Sleep(100);
			//	Console.Beep(370, 100); Thread.Sleep(100);
			//	Console.Beep(349, 100); Thread.Sleep(100);
			//	Console.Beep(311, 100); Thread.Sleep(300);
			//	Console.Beep(330, 100); Thread.Sleep(300);
			//	Console.Beep(207, 100); Thread.Sleep(100);
			//	Console.Beep(220, 100); Thread.Sleep(100);
			//	Console.Beep(262, 100); Thread.Sleep(300);
			//	Console.Beep(220, 100); Thread.Sleep(100);
			//	Console.Beep(262, 100); Thread.Sleep(100);
			//	Console.Beep(294, 100); Thread.Sleep(500);
			//	Console.Beep(311, 300); Thread.Sleep(300);
			//	Console.Beep(296, 300); Thread.Sleep(300);
			//	Console.Beep(262, 300); Thread.Sleep(1300);
			//	Console.Beep(262, 100); Thread.Sleep(100);
			//	Console.Beep(262, 100); Thread.Sleep(300);
			//	Console.Beep(262, 100); Thread.Sleep(300);
			//	Console.Beep(262, 100); Thread.Sleep(100);
			//	Console.Beep(294, 100); Thread.Sleep(300);
			//	Console.Beep(330, 200); Thread.Sleep(50);
			//	Console.Beep(262, 200); Thread.Sleep(50);
			//	Console.Beep(220, 200); Thread.Sleep(50);
			//	Console.Beep(196, 100); Thread.Sleep(700);
			//	Console.Beep(262, 100); Thread.Sleep(100);
			//	Console.Beep(262, 100); Thread.Sleep(300);
			//	Console.Beep(262, 100); Thread.Sleep(300);
			//	Console.Beep(262, 100); Thread.Sleep(100);
			//	Console.Beep(294, 100); Thread.Sleep(100);
			//	Console.Beep(330, 100); Thread.Sleep(700);
			//	Console.Beep(440, 100); Thread.Sleep(300);
			//	Console.Beep(392, 100); Thread.Sleep(500);
			//	Console.Beep(262, 100); Thread.Sleep(100);
			//	Console.Beep(262, 100); Thread.Sleep(300);
			//	Console.Beep(262, 100); Thread.Sleep(300);
			//	Console.Beep(262, 100); Thread.Sleep(100);
			//	Console.Beep(294, 100); Thread.Sleep(300);
			//	Console.Beep(330, 200); Thread.Sleep(50);
			//	Console.Beep(262, 200); Thread.Sleep(50);
			//	Console.Beep(220, 200); Thread.Sleep(50);
			//	Console.Beep(196, 100); Thread.Sleep(700);
			/*Intro*/
			Console.Beep(330, 100); Thread.Sleep(100);
			Console.Beep(330, 100); Thread.Sleep(300);
			Console.Beep(330, 100); Thread.Sleep(300);
			Console.Beep(262, 100); Thread.Sleep(100);
			Console.Beep(330, 100); Thread.Sleep(300);
			Console.Beep(392, 100); Thread.Sleep(700);
			Console.Beep(196, 100); Thread.Sleep(700);
			Console.Beep(196, 100); Thread.Sleep(125);
			Console.Beep(262, 100); Thread.Sleep(125);
			Console.Beep(330, 100); Thread.Sleep(125);
			Console.Beep(392, 100); Thread.Sleep(125);
			Console.Beep(523, 100); Thread.Sleep(125);
			Console.Beep(660, 100); Thread.Sleep(125);
			Console.Beep(784, 100); Thread.Sleep(575);
			Console.Beep(660, 100); Thread.Sleep(575);
			Console.Beep(207, 100); Thread.Sleep(125);
			Console.Beep(262, 100); Thread.Sleep(125);
			Console.Beep(311, 100); Thread.Sleep(125);
			Console.Beep(415, 100); Thread.Sleep(125);
			Console.Beep(523, 100); Thread.Sleep(125);
			Console.Beep(622, 100); Thread.Sleep(125);
			Console.Beep(830, 100); Thread.Sleep(575);
			Console.Beep(622, 100); Thread.Sleep(575);
			Console.Beep(233, 100); Thread.Sleep(125);
			Console.Beep(294, 100); Thread.Sleep(125);
			Console.Beep(349, 100); Thread.Sleep(125);
			Console.Beep(466, 100); Thread.Sleep(125);
			Console.Beep(587, 100); Thread.Sleep(125);
			Console.Beep(698, 100); Thread.Sleep(125);
			Console.Beep(932, 100); Thread.Sleep(575);
			Console.Beep(932, 100); Thread.Sleep(125);
			Console.Beep(932, 100); Thread.Sleep(125);
			Console.Beep(932, 100); Thread.Sleep(125);
			Console.Beep(1046, 675);
			Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			consoleBox.Visible = !consoleBox.Visible;
			if (consoleBox.Visible)
			{
				button2.Text = "<";
				this.Size = windowSize;
			}
			else
			{
				button2.Text = ">";
				this.Size = new Size(this.Width - consoleBox.Width, this.Size.Height);
			}
		}
	}
}
