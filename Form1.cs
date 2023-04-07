using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HesapMak_210408009
{
	public partial class Form1 : Form
	{
        HesapMak_210408009 calc;
		char operation;
		bool giris;// true - "+", false - "-"
		String temp;

		public Form1()
		{
			InitializeComponent();
			calc = new HesapMak_210408009();
			giris = true;
			sonuç.Text = "0";
			historyData.Text = "Henüz Geçmiş Yok\r\n";
		}

		public void Calculate()
		{
			if (operation == '+')
				sonuç.Text = calc.Sum(Convert.ToDouble(sonuç.Text)).ToString();
			else if (operation == '-')
				sonuç.Text = calc.Substract(Convert.ToDouble(sonuç.Text)).ToString();
			else if (operation == '×')
				sonuç.Text = calc.Multiplication(Convert.ToDouble(sonuç.Text)).ToString();
			else if (operation == '÷')
			{
				if(calc.Division(Convert.ToDouble(sonuç.Text)).ToString() == "∞")
				{
					sonuç.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
					sonuç.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
					sonuç.Text = "Деление на ноль невозможно";

					calc.CanErease = true;
					btnArtıEksi.Enabled = false;
                    nokta.Enabled = false;
					btnTopla.Enabled = false;
					btnÇıkar.Enabled = false;
					btnBöl.Enabled = false;
					btnÇarp.Enabled = false;
					btnEşittir.Enabled = false;
				}
				else
					sonuç.Text = calc.Division(Convert.ToDouble(sonuç.Text)).ToString();
			}
		}
		
		private void number_Click(object sender, EventArgs e)
		{
			
			Button btn = (Button)sender;
            

            int num = Convert.ToInt32(btn.Text);

			if (sonuç.Text == "0" || calc.CanErease)
			{
				sonuç.Font = new System.Drawing.Font("Segoe UI Semibold", 34F, System.Drawing.FontStyle.Bold);
				sonuç.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				sonuç.Text = num.ToString();

				btnArtıEksi.Enabled = true;
                nokta.Enabled = true;
				btnTopla.Enabled = true;
				btnÇıkar.Enabled = true;
				btnBöl.Enabled = true;
				btnÇarp.Enabled = true;
				btnEşittir.Enabled = true;

				calc.CanErease = false;
				ResimSifirla();
			}
			else
				sonuç.Text += num.ToString();
            ResimHesapla(sonuç.Text);

        }
		
		private void plusMin_Click(object sender, EventArgs e)
		{
			if (giris)
			{
				sonuç.Text = "-" + sonuç.Text;
				giris = false;
				
			}
			else
			{
				sonuç.Text = sonuç.Text.Replace("-", "");
				giris = true;
			}
			ResimHesapla(sonuç.Text);

		}

		private void plus_Click(object sender, EventArgs e)
		{
			if (lastString.Text != "")
			{
				string op1 = lastString.Text;
				string op2 = sonuç.Text;

				lastString.Text = "";
				Calculate();
				calc.AddToHistory(op1, op2, sonuç.Text);
				calc.CanErease = true;
                ResimSifirla();
            }
			calc.SetA(Convert.ToDouble(sonuç.Text));
			operation = '+';
			lastString.Text = Convert.ToDouble(sonuç.Text) + " + ";
			giris = true;
			calc.CanErease = true;
            ResimHesapla(sonuç.Text);
        }
		private void minus_Click(object sender, EventArgs e)
		{
			if (lastString.Text != "")
			{
				string op1 = lastString.Text;
				string op2 = sonuç.Text;

				lastString.Text = "";
				Calculate();
				calc.AddToHistory(op1, op2, sonuç.Text);
				calc.CanErease = true;
                ResimSifirla();
            }
			calc.SetA(Convert.ToDouble(sonuç.Text));
			operation = '-';
			lastString.Text = Convert.ToDouble(sonuç.Text) + " - ";
			giris = true;
			calc.CanErease = true;
            ResimHesapla(sonuç.Text);
        }
		private void mult_Click(object sender, EventArgs e)
		{
			if (lastString.Text != "")
			{
				string op1 = lastString.Text;
				string op2 = sonuç.Text;

				lastString.Text = "";
				Calculate();
				calc.AddToHistory(op1, op2, sonuç.Text);
				calc.CanErease = true;
                ResimSifirla();
            }
			calc.SetA(Convert.ToDouble(sonuç.Text));
			operation = '×';
			lastString.Text = Convert.ToDouble(sonuç.Text) + " × ";
			giris = true;
			calc.CanErease = true;
            ResimHesapla(sonuç.Text);
			
        }
		private void div_Click(object sender, EventArgs e)
		{
			if(lastString.Text != "")
			{
				string op1 = lastString.Text;
				string op2 = sonuç.Text;

				lastString.Text = "";
				Calculate();
				calc.AddToHistory(op1, op2, sonuç.Text);
				calc.CanErease = true;
				ResimSifirla();
			}
			calc.SetA(Convert.ToDouble(sonuç.Text));
			operation = '÷';
			lastString.Text = Convert.ToDouble(sonuç.Text) + " ÷ ";
			giris = true;
			calc.CanErease = true;
            ResimHesapla(sonuç.Text);
        }
		private void eşittir_Click(object sender, EventArgs e)
		{
			string op1 = lastString.Text;
			string op2 = sonuç.Text;

			lastString.Text = "";
			Calculate();
			calc.AddToHistory(op1, op2, sonuç.Text);
			calc.CanErease = true;

			if (sonuç.Text == "210408009")
			{
				MessageBox.Show("Öğrenci Numarama Ulaştınız");
			}

			ResimHesapla(sonuç.Text);

        }

		private void purcent_Click(object sender, EventArgs e)
		{
			double p = Convert.ToDouble(sonuç.Text);

			if(calc.Percent(p, operation) != 0.0)
			{
				lastString.Text += p;
				sonuç.Text = calc.Percent(p, operation).ToString();
				calc.AddToHistory(lastString.Text, "%", sonuç.Text);
				calc.CanErease = true;
			}	
		}
		private void root_Click(object sender, EventArgs e)
		{
			lastString.Text = $"√({sonuç.Text})";
			sonuç.Text = calc.Root(Convert.ToInt32(sonuç.Text)).ToString();
			calc.AddToHistory(lastString.Text, "", sonuç.Text);
			calc.CanErease = true;
		}
		private void power_Click(object sender, EventArgs e)
		{
			lastString.Text = $"({sonuç.Text})²";
			sonuç.Text = calc.Square(Convert.ToInt32(sonuç.Text)).ToString();
			calc.AddToHistory(lastString.Text, "", sonuç.Text);
			calc.CanErease = true;
		}
		private void oneToX_Click(object sender, EventArgs e)
		{
			lastString.Text = $"1/({sonuç.Text})";
			sonuç.Text = calc.OneToX(Convert.ToInt32(sonuç.Text)).ToString();
			calc.AddToHistory(lastString.Text, "", sonuç.Text);
			calc.CanErease = true;
		}

		private void clear_Click(object sender, EventArgs e)
		{
			sonuç.Text = "0";
			lastString.Text = "";

			ResimSifirla();
        }
		private void clearE_Click(object sender, EventArgs e)
		{
			sonuç.Text = "0";

            this.pictureBox1.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox2.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox3.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox4.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox5.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox6.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox7.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox8.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox9.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox10.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox11.BackgroundImage = global::Calculator.Properties.Resources.hK;
        }
		private void clearLast_Click(object sender, EventArgs e)
		{
			int len = sonuç.Text.Length - 1;
			string text = sonuç.Text;
			sonuç.Clear();

			for (int i = 0; i < len; i++)
				sonuç.Text = sonuç.Text + text[i];

			if (sonuç.Text == "")
				sonuç.Text = "0";
		}
		
		
		private void memoryRead_Click(object sender, EventArgs e)
		{
			sonuç.Text = calc.MemoryRead().ToString();
		}
		
		
		private void trash_Click(object sender, EventArgs e)
		{
			calc.MemoryClear();
			memoryData.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
			memoryData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			memoryData.Text = "В памяти ничего не сохранено";
		}

		private void equals_MouseEnter(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			btn.BackColor = System.Drawing.SystemColors.Highlight;
			btn.ForeColor = Color.White;
		}
		private void equals_MouseLeave(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			btn.BackColor = System.Drawing.SystemColors.InactiveBorder;
			btn.ForeColor = Color.Black;
		}

		
		private void historyTrash_Click(object sender, EventArgs e)
		{
			calc.DeleteHistory();
			historyData.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			historyData.Text = "Журнала еще нет";
		}

        private void memoryList_Click(object sender, EventArgs e)
        {

        }

        private void memorySave_Click(object sender, EventArgs e)
        {

        }

        private void ShowNumber(double number)
        {
            string numStr = number.ToString();
            for (int i = 0; i < numStr.Length; i++)
            {
                int digit = int.Parse(numStr[i].ToString());
                PictureBox pb = (PictureBox)Controls["pictureBox" + digit];
                pb.Visible = true;
                pb.Location = new Point(i * pb.Width, 0);
            }
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void nokta_Click(object sender, EventArgs e)
        {
            if (sonuç.Text.IndexOf(',') == -1)
                sonuç.Text += ",";
        }

		private void ResimSifirla()
		{
            this.pictureBox1.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox2.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox3.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox4.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox5.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox6.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox7.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox8.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox9.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox10.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox11.BackgroundImage = global::Calculator.Properties.Resources.hK;
        }



		private string ResimHesapla(string sonuc)
		{
            char[] sayiArray = sonuc.ToCharArray();
            Array.Reverse(sayiArray);
			int basamakSayisi = 0;



            foreach (var item in sayiArray)
			{

                if (item.ToString().Contains("-"))
				{
                    pictureBox11.BackgroundImage = new Bitmap($"C:\\Users\\EnesAkkaya\\source\\repos\\WinFormsApp4\\Resources\\eksiA.png");
					continue;
                }
				basamakSayisi++;
				int basamak = Convert.ToInt32(item.ToString());
                string startupPath = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
                switch (basamakSayisi)
				{
					case 1:
                        pictureBox1.BackgroundImage = new Bitmap(startupPath + $"\\Resources\\{basamak}.png");
                        break;
					case 2:
						pictureBox2.BackgroundImage = new Bitmap(startupPath + $"\\Resources\\{basamak}.png");
                        break;
					case 3:
						pictureBox3.BackgroundImage = new Bitmap(startupPath + $"\\Resources\\{basamak}.png");
                        break;
                    case 4:
                        pictureBox4.BackgroundImage = new Bitmap(startupPath + $"\\Resources\\{basamak}.png");
                        break;
					case 5:
                        pictureBox5.BackgroundImage = new Bitmap(startupPath + $"\\Resources\\{basamak}.png");
                        break;
                    case 6:
                        pictureBox6.BackgroundImage = new Bitmap(startupPath + $"\\Resources\\{basamak}.png");
                        break;
                    case 7:
                        pictureBox7.BackgroundImage = new Bitmap(startupPath + $"\\Resources\\{basamak}.png");
                        break;
                    case 8:
                        pictureBox8.BackgroundImage = new Bitmap(startupPath + $"\\Resources\\{basamak}.png");
                        break;
                    case 9:
                        pictureBox9.BackgroundImage = new Bitmap(startupPath + $"\\Resources\\{basamak}.png");
                        break;
                    case 10:
                        pictureBox10.BackgroundImage = new Bitmap(startupPath + $"\\Resources\\{basamak}.png");
                        break;
                    default:
                        pictureBox11.BackgroundImage = new Bitmap(startupPath + $"\\Resources\\{basamak}.png");
                        break;
				}
			}

            basamakSayisi++;

            //pictureBox1.BackgroundImage = new Bitmap($"C:\\Users\\EnesAkkaya\\source\\repos\\WinFormsApp4\\Resources\\{sonuc}nK.png");
            return "Test";
		}
    }
}