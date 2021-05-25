using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        bool triggerDraw = false;

        int x;
        int y;


       
        public void ExeShowHide()
        {
            pnlDraw.Refresh();

        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            ExeShowHide();
        }

        private void pnlDraw_Paint()
        {
            
                Graphics paper = pnlDraw.CreateGraphics();

                Pen blackPen = new Pen(Color.Black, 3); Font fy = new Font("Helvetica", 10, FontStyle.Bold);
                Brush br = new SolidBrush(System.Drawing.Color.Red);



                Rectangle rect = new Rectangle(x, y, 50, 50);
                paper.DrawRectangle(blackPen, rect);
                paper.FillRectangle(br, rect);

            

        }


        private void btnDraw_Click(object sender, EventArgs e)
        {

        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {

           
            


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void pnlDraw_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            pnlDraw.Refresh();
            pnlDraw_Paint();
        }
    }
}
