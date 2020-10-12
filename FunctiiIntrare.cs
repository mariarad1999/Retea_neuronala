using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retea_neuronala
{
    public class FunctiiIntrare
    {
        public static double suma(List<Neuron> lista, Neuron neuron)
        {
            double suma = 0.0;
            foreach (Neuron neuronLista in lista)
            {
                foreach (NeuralLink leg in neuronLista.links)
                {
                    if (leg.neuron.id == neuron.id)
                    {
                        suma += neuronLista.value * leg.linkValue;
                    }
                }
            }
            return suma;
        }
        public static double produs(List<Neuron> lista, Neuron neuron)
        {
            double produs = 0.0;
            foreach (Neuron neuronLista in lista)
            {
                foreach (NeuralLink leg in neuronLista.links)
                {
                    if (leg.neuron.id == neuron.id)
                    {
                        produs *= neuronLista.value * leg.linkValue;
                    }
                }
            }
            return produs;
        }
        public static double minim(List<Neuron> lista, Neuron neuron)
        {
            double minim = 999;
            foreach (Neuron neuronLista in lista)
            {
                foreach (NeuralLink leg in neuronLista.links)
                {
                    if (leg.neuron.id == neuron.id)
                    {
                        if (neuronLista.value * leg.linkValue < minim)
                            minim = neuronLista.value * leg.linkValue;
                    }
                }
            }
            return minim;
        }
        public static double maxim(List<Neuron> lista, Neuron neuron)
        {
            double maxim = -999;
            foreach (Neuron neuronLista in lista)
            {
                foreach (NeuralLink leg in neuronLista.links)
                {
                    if (leg.neuron.id == neuron.id)
                    {
                        if (neuronLista.value * leg.linkValue > maxim)
                            maxim = neuronLista.value * leg.linkValue;
                    }
                }
            }
            return maxim;
        }
    }
}
