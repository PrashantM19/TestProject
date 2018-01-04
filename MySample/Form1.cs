using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            List<int> towerlist = new List<int>();
            var towerlist1 = text.Split(',').ToList();
            towerlist1.ForEach(x => towerlist.Add(Convert.ToInt32(x)));

            int NoOfUnitsLogged = 0;

            int currIndex = 0;

            foreach (int i in towerlist)
            {
                bool Doskip = false;
                if ((towerlist.IndexOf(i) + 1) % 2 == 0)
                {
                    Doskip = true;
                }
                if (Doskip == false)
                {

                    try
                    {
                        NoOfUnitsLogged = NoOfUnitsLogged + Math.Abs(i - towerlist.ElementAt(towerlist.IndexOf(i) + 1));

                        if (towerlist.IndexOf(i) != 0 && (i > towerlist.ElementAt(towerlist.IndexOf(i) + 2)))
                            NoOfUnitsLogged = NoOfUnitsLogged + Math.Abs(i - towerlist.ElementAt(towerlist.IndexOf(i) + 2));
                    }
                    catch (Exception ex)
                    {

                    }
                }

                try
                {
                    if (towerlist.ElementAt(2) < towerlist.ElementAt(0))
                    {
                        NoOfUnitsLogged = NoOfUnitsLogged + Math.Abs(towerlist.ElementAt(2) - towerlist.ElementAt(0));
                    }
                    if (towerlist.ElementAt(0) < towerlist.ElementAt(1))
                    {
                        NoOfUnitsLogged = NoOfUnitsLogged - Math.Abs(towerlist.ElementAt(0) - towerlist.ElementAt(1));
                    }
                }
                catch (Exception ex)
                {

                }
                currIndex = currIndex + 1;
            }
            //foreach (int i in towerlist)
            //{
            //    bool Doskip = false;
            //    if ((currIndex + 1) % 2 == 0)
            //    {
            //        Doskip = true;
            //    }
            //    if (Doskip == false)
            //    {

            //        try
            //        {
            //            NoOfUnitsLogged = NoOfUnitsLogged + Math.Abs(i - towerlist.ElementAt(currIndex + 1));

            //            if (currIndex != 0 && (i > towerlist.ElementAt(currIndex + 2)))
            //                NoOfUnitsLogged = NoOfUnitsLogged + Math.Abs(i - towerlist.ElementAt(currIndex + 2));
            //        }
            //        catch (Exception ex)
            //        {

            //        }
            //    }              

            //    currIndex = currIndex + 1;

            //}
            //try
            //{
            //    if (towerlist.ElementAt(2) < towerlist.ElementAt(0))
            //    {
            //        NoOfUnitsLogged = NoOfUnitsLogged + Math.Abs(towerlist.ElementAt(2) - towerlist.ElementAt(0));
            //    }
            //    if (towerlist.ElementAt(0) < towerlist.ElementAt(1))
            //    {
            //        NoOfUnitsLogged = NoOfUnitsLogged - Math.Abs(towerlist.ElementAt(0) - towerlist.ElementAt(1));
            //    }
            //}
            //catch (Exception ex)
            //{

            //}

            label1.Text ="Number of units logged : "+ NoOfUnitsLogged.ToString();
        }
    }
}
