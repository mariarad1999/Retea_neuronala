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
    public partial class LinksForm : Form
    {
        Neuron neuron;
        public LinksForm(Neuron neuron)
        {
            this.neuron = neuron;
            foreach (NeuralLink links in neuron.links)
            {
                neuron.   
            }
            InitializeComponent();
        }
    }
}
