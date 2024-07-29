using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Module5
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
		private Quiz q = new Quiz();
		private List<int> lst = new List<int>();
		private string ans;
		private int score = 0;
		private int number = 1;
		public MainPage()
        {
            this.InitializeComponent();
        }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			start.Visibility = Visibility.Collapsed;
			quest.Visibility = Visibility.Visible;
			ans1.Visibility = Visibility.Visible;
			ans2.Visibility = Visibility.Visible;
			ans3.Visibility = Visibility.Visible;
			ans4.Visibility = Visibility.Visible;
			scoreLbl.Visibility = Visibility.Visible;
			//
			int i = this.getRandom();
			quest.Text = q.getQuestion(i);
			//
			ans1.Content = q.getAnswer(i, 1);
			ans2.Content = q.getAnswer(i, 2);
			ans3.Content = q.getAnswer(i, 3);
			ans4.Content = q.getAnswer(i, 4);
			if (Convert.ToString(ans1.Content).StartsWith("*"))
			{
				this.ans = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
				ans1.Content = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
			}
			else
			{
				if (Convert.ToString(ans2.Content).StartsWith("*"))
				{
					this.ans = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
					ans2.Content = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
				}
				else
				{
					if (Convert.ToString(ans3.Content).StartsWith("*"))
					{
						this.ans = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
						ans3.Content = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
					}
					else
					{
						this.ans = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
						ans4.Content = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
					}
				}
			}


			lst.Add(i);
		}
		public int getRandom()
		{
			Random rnd = new Random();
			int i = rnd.Next(11);
			if (lst.Contains(i) && lst.Count() < 11)
				while (lst.Contains(i))
					i = rnd.Next(0, 11);
			return i;
		}

		private void ans1_Click(object sender, RoutedEventArgs e)
		{
			if (this.number < 11)
			{
				this.number++;
				if (Convert.ToString(ans1.Content) == this.ans)
					this.score++;
				int i = this.getRandom();
				quest.Text = q.getQuestion(i);
				//
				ans1.Content = q.getAnswer(i, 1);
				ans2.Content = q.getAnswer(i, 2);
				ans3.Content = q.getAnswer(i, 3);
				ans4.Content = q.getAnswer(i, 4);
				if (Convert.ToString(ans1.Content).StartsWith("*"))
				{
					this.ans = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
					ans1.Content = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
				}
				else
				{
					if (Convert.ToString(ans2.Content).StartsWith("*"))
					{
						this.ans = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
						ans2.Content = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
					}
					else
					{
						if (Convert.ToString(ans3.Content).StartsWith("*"))
						{
							this.ans = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
							ans3.Content = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
						}
						else
						{
							this.ans = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
							ans4.Content = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
						}
					}
				}
				lst.Add(i);
				scoreLbl.Text = "Score : " + this.score;
			}
			else
			{
				quest.Visibility = Visibility.Collapsed;
				ans1.Visibility = Visibility.Collapsed;
				ans2.Visibility = Visibility.Collapsed;
				ans3.Visibility = Visibility.Collapsed;
				ans4.Visibility = Visibility.Collapsed;
				final.Visibility = Visibility.Visible;
				final.Text = "         Congratulations" + "\n          Your score is " + this.score;
				restart.Visibility = Visibility.Visible;
			}
		}

		private void ans2_Click(object sender, RoutedEventArgs e)
		{
			if (this.number < 11)
			{
				this.number++;
				if (Convert.ToString(ans2.Content) == this.ans)
					this.score++;
				int i = this.getRandom();
				quest.Text = q.getQuestion(i);
				//
				ans1.Content = q.getAnswer(i, 1);
				ans2.Content = q.getAnswer(i, 2);
				ans3.Content = q.getAnswer(i, 3);
				ans4.Content = q.getAnswer(i, 4);
				if (Convert.ToString(ans1.Content).StartsWith("*"))
				{
					this.ans = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
					ans1.Content = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
				}
				else
				{
					if (Convert.ToString(ans2.Content).StartsWith("*"))
					{
						this.ans = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
						ans2.Content = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
					}
					else
					{
						if (Convert.ToString(ans3.Content).StartsWith("*"))
						{
							this.ans = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
							ans3.Content = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
						}
						else
						{
							this.ans = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
							ans4.Content = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
						}
					}
				}
				lst.Add(i);
				scoreLbl.Text = "Score : " + this.score;
			}
			else
			{
				quest.Visibility = Visibility.Collapsed;
				ans1.Visibility = Visibility.Collapsed;
				ans2.Visibility = Visibility.Collapsed;
				ans3.Visibility = Visibility.Collapsed;
				ans4.Visibility = Visibility.Collapsed;
				final.Visibility = Visibility.Visible;
				final.Text = "         Congratulations" + "\n          Your score is " + this.score;
				restart.Visibility = Visibility.Visible;
			}
		}

		private void ans3_Click(object sender, RoutedEventArgs e)
		{
			if (this.number < 11)
			{
				this.number++;
				if (Convert.ToString(ans3.Content) == this.ans)
					this.score++;
				int i = this.getRandom();
				quest.Text = q.getQuestion(i);
				//
				ans1.Content = q.getAnswer(i, 1);
				ans2.Content = q.getAnswer(i, 2);
				ans3.Content = q.getAnswer(i, 3);
				ans4.Content = q.getAnswer(i, 4);
				if (Convert.ToString(ans1.Content).StartsWith("*"))
				{
					this.ans = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
					ans1.Content = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
				}
				else
				{
					if (Convert.ToString(ans2.Content).StartsWith("*"))
					{
						this.ans = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
						ans2.Content = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
					}
					else
					{
						if (Convert.ToString(ans3.Content).StartsWith("*"))
						{
							this.ans = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
							ans3.Content = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
						}
						else
						{
							this.ans = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
							ans4.Content = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
						}
					}
				}
				lst.Add(i);
				scoreLbl.Text = "Score : " + this.score;
			}
			else
			{
				quest.Visibility = Visibility.Collapsed;
				ans1.Visibility = Visibility.Collapsed;
				ans2.Visibility = Visibility.Collapsed;
				ans3.Visibility = Visibility.Collapsed;
				ans4.Visibility = Visibility.Collapsed;
				final.Visibility = Visibility.Visible;
				final.Text = "         Congratulations" + "\n          Your score is " + this.score;
				
				restart.Visibility = Visibility.Visible;
			}
		}

		private void ans4_Click(object sender, RoutedEventArgs e)
		{
			if (this.number < 11)
			{
				this.number++;
				if (Convert.ToString(ans4.Content) == this.ans)
					this.score++;
				int i = this.getRandom();
				quest.Text = q.getQuestion(i);
				//
				ans1.Content = q.getAnswer(i, 1);
				ans2.Content = q.getAnswer(i, 2);
				ans3.Content = q.getAnswer(i, 3);
				ans4.Content = q.getAnswer(i, 4);
				if (Convert.ToString(ans1.Content).StartsWith("*"))
				{
					this.ans = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
					ans1.Content = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
				}
				else
				{
					if (Convert.ToString(ans2.Content).StartsWith("*"))
					{
						this.ans = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
						ans2.Content = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
					}
					else
					{
						if (Convert.ToString(ans3.Content).StartsWith("*"))
						{
							this.ans = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
							ans3.Content = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
						}
						else
						{
							this.ans = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
							ans4.Content = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
						}
					}
				}
				lst.Add(i);
				scoreLbl.Text = "Score : " + this.score;
			}
			else
			{
				quest.Visibility = Visibility.Collapsed;
				ans1.Visibility = Visibility.Collapsed;
				ans2.Visibility = Visibility.Collapsed;
				ans3.Visibility = Visibility.Collapsed;
				ans4.Visibility = Visibility.Collapsed;
				final.Visibility = Visibility.Visible;
				final.Text = "         Congratulations" + "\n          Your score is " + this.score;
				restart.Visibility = Visibility.Visible;

			}
		}

		private void Button_Click2(object sender, RoutedEventArgs e)
		{
			this.score = 0;
			scoreLbl.Text = "Score : " + this.score;
			this.number = 1;
			final.Visibility = Visibility.Collapsed;
			lst.Clear();
			restart.Visibility = Visibility.Collapsed;
			quest.Visibility = Visibility.Visible;
			ans1.Visibility = Visibility.Visible;
			ans2.Visibility = Visibility.Visible;
			ans3.Visibility = Visibility.Visible;
			ans4.Visibility = Visibility.Visible;
			scoreLbl.Visibility = Visibility.Visible;
			//
			int i = this.getRandom();
			quest.Text = q.getQuestion(i);
			//
			ans1.Content = q.getAnswer(i, 1);
			ans2.Content = q.getAnswer(i, 2);
			ans3.Content = q.getAnswer(i, 3);
			ans4.Content = q.getAnswer(i, 4);
			if (Convert.ToString(ans1.Content).StartsWith("*"))
			{
				this.ans = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
				ans1.Content = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
			}
			else
			{
				if (Convert.ToString(ans2.Content).StartsWith("*"))
				{
					this.ans = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
					ans2.Content = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
				}
				else
				{
					if (Convert.ToString(ans3.Content).StartsWith("*"))
					{
						this.ans = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
						ans3.Content = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
					}
					else
					{
						this.ans = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
						ans4.Content = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
					}
				}
			}
			lst.Add(i);
		}
	}
}
