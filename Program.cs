using System;
using System.Windows.Forms;
using System.Drawing;

public class Hello : Form
{
    public Hello()
    {
        this.Paint += new PaintEventHandler(f1_paint);
        this.Size = new Size(700, 250);
    }
    private void f1_paint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.DrawString("Hello !", new Font("Verdana", 20), new SolidBrush(Color.Tomato), 40, 40);
        g.DrawString("This is a C# program.", new Font("Verdana", 20), new SolidBrush(Color.Green), 40, 80);
        g.DrawString("C# is a good programming language.", new Font("Verdana", 20), new SolidBrush(Color.Blue), 40, 120);
    }
    public static void Main()
    {
        Application.Run(new Hello());
    }

    private void InitializeComponent()
    {
        this.SuspendLayout();
        // 
        // Hello
        // 
        this.ClientSize = new System.Drawing.Size(888, 561);
        this.Name = "Hello";
        this.ResumeLayout(false);
    }
    // End of class  
}