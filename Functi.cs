using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retea_neuronala
{
    public partial class Functi : Form
    {
        public Functi()
        {
            InitializeComponent();
        }


        public void CalcGLobalInput(double y)
        {
            double suma = 0;
            double produs = 1;
            
            try
            {
                switch (OperationComboBox.SelectedItem.ToString().Trim())
                {
                    case "Suma":
                        suma = suma + y;
                        break;
                    case "Produs":
                        produs = produs * y;
                        break;
                    case "Maxim":
                        double max = -999;
                        if (y > max)
                            max = y;
                        break;
                    case "Minim":
                        double min = 999;
                        if (y < min)
                           min = y;     
                        break;    
                        
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public double CalcAct()
        {
            float x = 0;
            double acti = 0;
            float teta = (float)Teta.Value;
            double g = (double)G.Value;
            double e = Math.E;
            x = x - teta;
            double outi=0;

            try
            {
                switch (ActivationComboBox.SelectedItem.ToString().Trim())
                {
                    case "Treaptă":
                        if (x < teta)
                            acti = 0;
                        else
                            acti = 1;
                       outi= CalcOutput(acti, 1);
                            break;
                    case "Sigmoidală":

                        double f1 = 1 / (1 + Math.Pow(e, -g * x));
                        acti = f1;
                        outi=CalcOutput(acti, 2);
                        break;
                    case "Signum":
                        if (x < teta)
                            acti = -1;
                        else
                            acti = 1;
                        outi=CalcOutput(acti, 3);
                            break;
                    case "TanH":
                        double f2 = (Math.Pow(e, g * x) - Math.Pow(e, -g * x)) / (Math.Pow(e, g * x) + Math.Pow(e, -g * x));
                        acti = f2;
                        outi=CalcOutput(acti, 4);
                        break;
                    case "Liniară":
                        if (x < (-g))
                            acti = -1;
                        else
                            if (x > g)
                            acti = 1;

                        else
                        {
                            double a = x / g;
                            acti = a;
                        }
                        outi=CalcOutput(acti, 5);
                        break;
                }
                return outi;
            }
            catch (Exception ex)
            {
                return outi;
            }
        }
        public double CalcOutput(double acti,int contor)
        {
            double outi = 0;
            if (contor == 1 || contor == 3)//treapta, signum
            {
                outi=acti;
            }
            else if (contor == 2)//sigmoidala
            {
                if (checkBox1.Checked)
                {
                    if (acti < 0.5)
                        outi=0;
                    else
                        outi=1;
                }
                else
                    outi=acti;
            }
            else if (contor == 4 || contor == 5) //tanh, liniara
            {
                if (checkBox1.Checked)
                {
                    if (acti < 0)
                        outi=-1;
                    else
                        outi=1;
                }
                else
                    outi=acti;
            }
            return outi;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
