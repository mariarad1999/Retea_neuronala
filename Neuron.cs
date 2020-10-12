using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retea_neuronala
{
    public class Neuron
    {
        public int id { get; set; }
        public string nume { get; set; }
        public double entryFunctionValue { get; set; }
        public double activationFunctionValue { get; set; }
        public double value { get; set; } //asta va fi output-ul neuronului
        public List<NeuralLink> links { get; set; }

        public Neuron(int id, string nume) {
            this.id = id;
            this.nume = nume;
            this.links = new List<NeuralLink>();
        }

        public Neuron(int id, string nume, double valoare)
        {
            this.id = id;
            this.nume = nume;
            this.value = valoare;
            this.links = new List<NeuralLink>();
        }

        public void addLink(Neuron neuron, double linkValue) {
            links.Add(new NeuralLink(neuron, linkValue));
        }
        
    }
}
