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
    public partial class Fifteen_Puzzle : Form
    {

        string path = "";
        Timer t;
        UserControl_Puzzle_Numbers usdg;
        UserControl_Puzzle_Pictures uspc;
        public bool  b_a_star = false;

        public Fifteen_Puzzle() 
        {
            InitializeComponent();
            lbl_time.Text = "";
            lbl_time.ForeColor = Color.OrangeRed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_time.Text = "";
            panel1.Controls.Clear();
            usdg = new UserControl_Puzzle_Numbers(280, 4, 70);
            panel1.Controls.Add(usdg);
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            int[,] state;
            string s = "";
            int start = DateTime.Now.Minute * 60 * 1000 +
                DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
            {
                state = get_state(usdg.state);
                if (b_a_star && !usdg.is_goal())
                {
                    usdg.obj_astar = new a_star(4);
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
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    int idx = i * N + j;
                    rs[i, j] = state[idx] - 48;
                }
            return rs;
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            
        }

        private void Fifteen_Puzzle_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Start_Window.__main__ != null)
            {
                Start_Window.__main__.Show();
            }
        }

        private void t_click(object sender, EventArgs e)
        {
            
        }

        private void Fifteen_Puzzle_Load(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 5;
            t.Tick += new EventHandler(t_click);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            t.Start();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            t.Start();
        }
    }
}
