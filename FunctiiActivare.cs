using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retea_neuronala
{
    
    class FunctiiActivare
    {
        double teta = 0.0;
        double g = 1.0;
        double a = 1.0;

        public static double Treapta(List<Neuron> lista, Neuron neuron, double teta, double g, double a) 
        { 
            foreach (Neuron neuronLista in lista)
            {
                foreach (NeuralLink leg in neuronLista.links)
                {
                    if (neuronLista.value * leg.linkValue < teta)
                    {
                        return 1;
                    }
                }
            }
                return 0;
        }

        public static double Sigmoidala(List<Neuron> lista, Neuron neuron, double teta, double g, double a)
        {
            double exit_value = 0.0;
            foreach (Neuron neuronLista in lista)
            { 
                foreach (NeuralLink leg in neuronLista.links)
                {
                   exit_value = 1 / (1 + Math.Pow(Math.E, -g * (neuronLista.value * leg.linkValue - teta)));
                }
            }
            return exit_value;
        }
        public static double Signum(List<Neuron> lista, Neuron neuron, double teta, double g, double a)
        {
            foreach (Neuron neuronLista in lista)
            {
                foreach (NeuralLink leg in neuronLista.links)
                {
                    if (neuronLista.value * leg.linkValue < teta)
                        return -1;
                }
            }
            return 1;
        }
        public static double TangentaHiperbolica(List<Neuron> lista, Neuron neuron, double teta, double g, double a)
        {
            double numarator = 0.0;
            double numitor = 0.0;
            foreach (Neuron neuronLista in lista)
            {
                foreach (NeuralLink leg in neuronLista.links)
                {
                    numarator = (Math.Pow(Math.E, g * (neuronLista.value * leg.linkValue - teta) - Math.Pow(Math.E, -g * (neuronLista.value * leg.linkValue - teta))));
                    numitor = (Math.Pow(Math.E, g * (neuronLista.value * leg.linkValue - teta)) + Math.Pow(Math.E, -g * (neuronLista.value * leg.linkValue - teta)));
                }
            }
            return (numarator / numitor);
        }
        public static double Rampa(List<Neuron> lista, Neuron neuron, double teta, double g, double a)
        { 
            foreach (Neuron neuronLista in lista)
            {
                foreach (NeuralLink leg in neuronLista.links)
                {
                    double x = neuronLista.value * leg.linkValue - teta;
                    if (x < (-a))
                        return -1;
                    else if (x >= (-a) && x <= a)
                        return x / a;
                }
            }
            return 1;
        }
    }
}
