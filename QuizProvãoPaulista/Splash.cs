/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 13/10/2025
 * Time: 13:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuizProvãoPaulista
{
	/// <summary>
	/// Description of Splashcs.
	/// </summary>
	public partial class Splash : Form
	{
		public Splash()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			Login telalogin = new Login();
			telalogin.Show();
			this.Hide();			
		}
	}
}
