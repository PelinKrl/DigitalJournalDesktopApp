using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopJournelApp
{
    public partial class MainAppForm : Form
    {
        public MainAppForm()
        {
            InitializeComponent(); 
            this.Paint += new PaintEventHandler(this.MainAppForm_Paint);
            this.Resize += new EventHandler(this.MainAppForm_Resize);
        }

        private void MainAppForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = this.ClientRectangle;
            if (rect.Width == 0 || rect.Height == 0) return;

            using (var brush = new LinearGradientBrush(this.ClientRectangle,  Color.Transparent, Color.Transparent, LinearGradientMode.Vertical))
            {
                var blend = new ColorBlend();
                blend.Positions = new[] { 0, 1/ 4f, 3 / 4f,  1 };
                blend.Colors = new[] { Color.White, Color.White, Color.Violet, Color.BlueViolet };
                brush.InterpolationColors = blend;
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            //using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.BlueViolet, Color.White, 90F))
            //{
            //    // Create a blend object to control the gradient
            //    Blend blend = new Blend();
            //    blend.Positions = new float[] { 0.0f, 0.3f, 1.0f }; // Adjust the position to start with white and transition to violet
            //    blend.Factors = new float[] { 1.0f, 0.7f, 0.0f }; // Adjust the factors to start with full white and transition to violet


            //    // Apply the blend to the brush
            //    brush.Blend = blend;

            //    // Fill the rectangle with the gradient
            //    g.FillRectangle(brush, rect);
            //}
        }

        private void MainAppForm_Resize(object sender, EventArgs e)
        {
            this.Invalidate(); // Redraw the form when it's resized
            
        }


        private void MainAppForm_Load(object sender, EventArgs e)
        {

        }

       

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
               }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
