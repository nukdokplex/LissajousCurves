using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LissajousCurves
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void glControl_Resize(object sender, EventArgs e)
        {
            glControl.MakeCurrent();
            GL.Viewport(0, 0, glControl.Width, glControl.Height);

        }

        private void glControl_Paint(object sender, PaintEventArgs e)
        {
            glControl.MakeCurrent();
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Color3(Color.Green);
            GL.LineWidth(2.0f);
            float t = 0.0f;
            GL.Begin(BeginMode.LineStrip);
            while (t <= 50.0f)
            {
                GL.Vertex2(getPoint(t));

                t += ((float)deltaTInput.Value);
            }
            GL.End();
            
            glControl.SwapBuffers();
            deltaInput.Value += deltaDeltaInput.Value;
            alphaInput.Value += deltaAlphaInput.Value;
            betaInput.Value += deltaBetaInput.Value;
        }

        private Vector2 getPoint(float t)
        {
            float alpha = (float) alphaInput.Value;
            float beta = (float) betaInput.Value;
            float delta = (float) deltaInput.Value;

            return new Vector2
            {
                X = 0.95f * ((float)Math.Sin(alpha * t + delta)),
                Y = 0.95f * ((float)Math.Sin(beta * t)),
            };
            
        
        }

        private void glTimer_Tick(object sender, EventArgs e)
        {
            glControl.Invalidate();
        }
    }
}
