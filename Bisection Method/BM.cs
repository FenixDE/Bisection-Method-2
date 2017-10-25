using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using info.lundin.math;
using System.Diagnostics;

namespace Bisection_Method
{
    class BM
    {
        decimal a, b, с, c1, t, fa, fb, fс; string r,r1,m,l,tim;
        int it, k; double ti; 
        string func;
        ExpressionParser parser;
        
        #region set variables
        public BM()
        {
            с = 0;
            fс = 0;
            t = 1/100;
            func = "";
            it = 0;
            k = 0;
            parser = new ExpressionParser();
            a = 0;
            b = 0;
            ti=0.0;
        }

        public void setBMvariables(decimal A, decimal B, decimal Tol, int k_m,double ti1)
        {
            a = A;
            b = B;
            t = Tol;
            k = k_m;
            ti = ti1;
        }

        public void setBMvariables(decimal A, decimal B, decimal Tol)
        {
            a = A;
            b = B;
            t = Tol;
        }

        public void addFunction(string function)
        {
            func = function;
        }
        #endregion

        #region get variables
        public decimal getX()
        {            
            return с;
        }

        public decimal getFx()
        {
            return fс;//лимит на количество знаков после запятой
        }

        public int getIterations()
        {
            return it-1;
        }

        public decimal getA()
        {
            return a;
        }

        public decimal getB()
        {
            return b;
        }
        public string getL()
        {
            return l;
        }
        public string getM()
        {
            return m;
        }
        public string getR()
        {
            return r;
        }
        public string getR1()
        {
            return r1;
        }
        
        public string getTim()
        {
            return tim;
        }
        #endregion

        public void BiMe()
        {
            try
                {
                    parser.Values.Add("x", (double)с);
                    fс = (decimal)parser.Parse(func);
                }
                catch
                {
                    tim = "";
                }
                it = 1;
                Stopwatch Watch = new Stopwatch();
                Watch.Start();
                //DateTime before = DateTime.Now; 
            while (Math.Abs(b - a) > t)
                {
                    if (it > 1000000)
                    {
                        r1 = "Превышено время ожидaния, введите точность меньше"; 
                        с = 0;
                        fс = 0;
                        a = 0;
                        b = 0;
                        it = 1;
                        break;
                    }
                    else
                    {
                        fa = f(a);
                        fb = f(b);
                        if (Math.Sign(fa) == Math.Sign(fb))
                        {
                            r1 = "";
                            с = 0;
                            fс = 0;
                            a = 0;
                            b = 0;
                            it = 1;
                            break;
                        }
                        else
                        {                            
                               с = (a + b) / 2;
                            it++;
                            c1 = с;
                            fa = f(a);
                            fb = f(b);
                            fс = f(с);
                            if (Math.Sign(fa) == Math.Sign(fс))
                            {
                                // функция имеет значения разных знаков
                                // на концах интервала [c,b]                            
                                a = с; fa = fс;
                            }
                            else
                            {
                                // функция имеет значения разных знаков
                                // на концах интервала [a,c]
                                b = с; fb = fс;
                            }
                            if (fс == 0)        //если f(c)=0, это означает, что корень найден
                            {
                                с = c1;     //Вывести корень уравнения и выйти из цикла
                                break;
                            }
                            
                        } 
                    }
                } //parser.Values.Clear();
            //DateTime after = DateTime.Now;
            Watch.Stop(); 
            m = Watch.Elapsed.Milliseconds.ToString();
            //m = after.Millisecond - before.Millisecond;
            
        }      
         public void BiMeit()
        {            
                Stopwatch Watch = new Stopwatch();
                Watch.Start(); 
                //DateTime before = DateTime.Now;
                try
                {
                    parser.Values.Add("x", (double)с);
                    fс = (decimal)parser.Parse(func);
                }
                catch
                {
                    tim = "";
                }
                int counter = 1;
                it = 1;
                fa = f(a);
                    fb = f(b);
                    if (Math.Sign(f(a)) == Math.Sign(f(b)))
                    {
                        r1 = "";

                    }
                    else
                    {
                        while (it <= k)
                        {
                            с = (a + b) / 2;//Делим пополам интервал и найдем значение с
                            it++;
                            c1 = с;
                            fa = f(a);
                            fb = f(b);
                            fс = f(с);
                            if (Math.Abs(b - a) <= t)
                            {
                                it = k;
                                break;
                            }
                            if (counter == it)
                            {
                                break;
                            }
                            //
                            if (Math.Abs(b - a) > t) { l = (it - 1).ToString(); }

                            if (Math.Sign(fa) == Math.Sign(fс))
                            {
                                // функция имеет значения разных знаков
                                // на концах интервала [c,b]                            
                                a = с; fa = fс;
                            }
                            else
                            {
                                // функция имеет значения разных знаков
                                // на концах интервала [a,c]
                                b = с; fb = fс;
                            }
                            if (fс == 0)
                            {
                                с = c1;     //Вывести корень уравнения и выйти из цикла
                                break;
                            }
                            counter = counter + 1;
                            if (Watch.Elapsed.TotalMilliseconds > ti)
                            {
                                r = "Время вышло!!!";
                                break;
                                m = ti.ToString();
                            }
                            else m = Watch.Elapsed.TotalMilliseconds.ToString();
                        }Watch.Stop();
                            
                        /*DateTime after = DateTime.Now;
                        double m1 = (after - before).TotalMilliseconds;                        
                        if (m1 >= ti)
                        {
                            r = "Время вышло!!!";
                            с = 0;
                            fс = 0;
                            a = 0;
                            b = 0;
                            m = ti.ToString();
                        }
                        else m = m1.ToString();
                    } parser.Values.Clear();*/
                 
                        // DateTime after = DateTime.Now;
                        // m = after.Millisecond - before.Millisecond;
                        //t1 = Convert.ToString(stopWatch.Elapsed);    
                    } 
           
         }

         private decimal f(decimal x)
        {
            decimal res = 0;    
            try
            {
                parser.Values["x"].SetValue((double)x); 
                res = (decimal)parser.Parse(func);
            }
            catch
            {
                tim = "";
            } 
            return res;
        }
    }
}
