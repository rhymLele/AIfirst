
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_Puzzle_Game
{
    public partial class Eight_Puzzle : Form
    {
        string path = "";
        Timer t;
      
        UserControl_Puzzle_Numbers usdg;
		private int startTime;
		public Timer timer;
		public bool  b_a_star = false;

		public Eight_Puzzle()
        {
			InitializeComponent();
			lbl_time.Text = "time : 00:00:00";
			timer = new Timer();
			timer.Interval = 1000; // 1 giây
			timer.Tick += t_Tick;
			lbl_time.ForeColor = Color.Black;
        }

		private void t_Tick(object sender, EventArgs e)
		{
			TimeSpan timeSpan = TimeSpan.FromMilliseconds(Environment.TickCount - startTime);
			lbl_time.Text = "Time: " + timeSpan.ToString(@"hh\:mm\:ss");
		}

		private void button1_Click(object sender, EventArgs e) {

			startTime = Environment.TickCount;
			timer.Start();      
			panel1.Controls.Clear();
            usdg = new UserControl_Puzzle_Numbers(270, 3, 90, 0);
            panel1.Controls.Add(usdg);
        }

        private void Eight_Puzzle_Load(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 5;
        }


		private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Stop();
            int[,] state;
            string s = "";
            int start = DateTime.Now.Minute * 60 * 1000 +
                DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
           
            {
                state = get_state(usdg.state);

                if (b_a_star && !usdg.is_goal())
                {
                    usdg.obj_astar = new a_star(3);
                    usdg.obj_astar.set_goal(usdg.obj_astar.get_destination());
                    usdg.obj_astar.solve(state); usdg.start();
                    s = "A*";
                }
            }
            
            int end = DateTime.Now.Minute * 60 * 1000 +
                DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
            lbl_time.Text = "time required is : " + (end - start).ToString()
                + " ms, " + s;
        }

        private int[,] get_state(string state)
        {
            int N = (int)Math.Sqrt(state.Length);
            int[,] rs = new int[N, N];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    int idx = i * 3 + j;
                    rs[i, j] = state[idx] - 48;
                }
            return rs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Eight_Puzzle_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Start_Window.__main__ != null)
            {
                Start_Window.__main__.Show();
            }
          
        }

		private void button2_Click_1(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
