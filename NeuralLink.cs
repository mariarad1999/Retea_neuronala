using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retea_neuronala
{
    public class NeuralLink
    {
        public Neuron neuron { get; set; }
        public double linkValue { get; set; }

        public NeuralLink(Neuron neuron, double linkValue) {
            this.neuron = neuron;
            this.linkValue = linkValue;
        }
    }
}
