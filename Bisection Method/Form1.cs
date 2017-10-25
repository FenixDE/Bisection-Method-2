using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using info.lundin.math;
using System.Diagnostics;
using System.Threading;

namespace Bisection_Method
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }
        private bool CheckValidG()
        {
            if (fTB1.Text == "" | aTB2.Text == "" | bTB3.Text == "" | tTB4.Text == "")
            {
                MessageBox.Show("Некоторые из полей пусты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Add.isNumeric(aTB2.Text) | !Add.isNumeric(bTB3.Text) | !Add.isNumeric(tTB4.Text))
            {
                MessageBox.Show("Поля содержат символы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        } 
       private void chkKMax_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkKMax.Checked) //if checkbox don't checked, don't show textbox
            {
                kmTB5.Visible = false;
                label5.Visible = false;
            }
            else
            {
                kmTB5.Visible = true;
                label5.Visible = true;
            }
        }

       private void button1_Click(object sender, EventArgs e)
       {
           progressBar1.Visible = true;
           if (CheckValidG() == false)
               return;
           BM bis = new BM();
           string function = fTB1.Text;
           decimal a = Decimal.Parse(aTB2.Text);
           decimal b = Decimal.Parse(bTB3.Text);
           double to = Double.Parse(tTB4.Text);
           decimal Tol = (decimal)to;
           if (b > a)
           {
               progressBar1.Style = ProgressBarStyle.Marquee;
               progressBar1.MarqueeAnimationSpeed = 30;
               progressBar1.Show(); //x^2-4*sin(x)  1500*x^3-0,001*exp(2*x)-0.01*exp(x)^2
               progressBar1.Style = ProgressBarStyle.Blocks;
               progressBar1.Value = progressBar1.Maximum;
               int k = 0;
               bis.addFunction(function);
               //Stopwatch stopWatch = new Stopwatch();
               //stopWatch.Start();
               double ti;
               //DateTime before = DateTime.Now;
               if (chkKMax.Checked)
               {
                   try { k = Int32.Parse(kmTB5.Text); }
                   catch { MessageBox.Show("Введите количество итераций!!!"); }                   
                       ti = Double.Parse(textBox1.Text);
                       bis.setBMvariables(a, b, Tol, k, ti);
                       bis.BiMeit();
                       kTB9.Text = bis.getL();
                       label11.Text = bis.getM(); 
               }
               else
               {
                   bis.setBMvariables(a, b, Tol);
                   bis.BiMe();
                   kTB9.Text = bis.getIterations().ToString();
                   label11.Text = bis.getM();
               }
               //stopWatch.Stop();
               //TimeSpan ts = stopWatch.Elapsed;
               //label11.Text = String.Format(String.Format("{0000}", ts.Milliseconds));
               int tx = Tol.ToString().Length;
               try
               {
                   if (bis.getX() > 0)
                   {
                       xTB6.Text = bis.getX().ToString().Substring(0, tx);
                   }
                   else
                   {
                       xTB6.Text = bis.getX().ToString().Substring(0, tx + 1);
                   }
               }
               catch
               {
                   xTB6.Text = Math.Round(bis.getX(), 28).ToString();
               } bis.getR1();
               decimal i1 = Math.Abs(bis.getB() - bis.getA());
               //int i=i1.ToString().Length;
               //decimal abs = Math.Round(i1, i-2);
               //double ab = (double)abs;
               absTB8.Text = i1.ToString("0E0");
               /*DateTime after = DateTime.Now;
               if (after == before) { label11.Text = "0.00001"; }
               double m = (after - before).TotalMilliseconds;*/

               double a1 = Double.Parse(absTB8.Text);

               if (a1 > to) { label15.Text = "Погрешность не достигнута, нужно больше итераций!"; }
               else { label15.Text = ""; }

               fxTB7.Text = bis.getFx().ToString();
               label10.Text = bis.getR();
               if (label13.Text == bis.getR1())
               {
                   label15.Text = "";
                   MessageBox.Show("Знаки f(a) и f(b) одинаковы, введите другой интервал");
               }
               if (label15.Text == bis.getTim())
               {
                   MessageBox.Show("Ошибка в функции"); label15.Text = "";
               }
               label13.Text = bis.getR1();
               /*if (chkKMax.Checked)
               {
                   ti = Double.Parse(textBox1.Text);
                   if (m > ti)
                   {
                       label10.Text = "Время вышло!!!";
                       label11.Text = String.Format(String.Format("{00000}", ti.ToString()));                       
                   }
                   else { label11.Text = String.Format(String.Format("{00000}", m.ToString()));}
               }
               else label11.Text = m.ToString();*/
           }
           else
           {
               MessageBox.Show("Должно быть A < B");
           }
           progressBar1.Visible = false;     
       }

        private void button2_Click(object sender, EventArgs e)
        {
            xTB6.Text = null;
            fxTB7.Text = null;
            absTB8.Text = null;
            kTB9.Text = null;
            label10.Text = null;
            label11.Text = null;
            label13.Text = null;
            label15.Text = null;
            progressBar1.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*private void timer1_Tick(object sender, EventArgs e)
        {
            /*if (progressBar1.Maximum == progressBar1.Value)
            {
                this.progressBar1.Hide();
            }
            else
            {
                this.progressBar1.Show();
                progressBar1.Increment(100);
            progressBar1.Value++; }
        }   */     
    }
}
