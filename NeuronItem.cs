using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Retea_neuronala
{
    public class NeuronItem
    {
        public int layer { get; set; }
        public Neuron neuron { get; set; }
        public Label label { get; set; }
        public TextBox textBox { get; set; }
        public Button tarii { get; set; }

        public NeuronItem(int left, int top, Neuron neuron, Boolean cuTarii, int layer) {
            Label label = new Label();
            label.Text = neuron.nume;
            label.Left = left;
            label.Top = top;
            label.Width = 30;
            label.Height = 30;
            this.label = label;
            TextBox value = new TextBox();
            value.Text = neuron.value.ToString();
            value.Left = left - 30;
            value.Top = top + 5;
            value.Width = 30;
            value.Height = 30;
            this.textBox = value;
            if (cuTarii) {
                Button tarii = new Button();
                tarii.Text = "W";
                tarii.Left = left + 30;
                tarii.Top = top + 5;
                tarii.Width = 30;
                tarii.Height = 30;
                tarii.Name = neuron.nume;
                this.tarii = tarii;
            }
            this.neuron = neuron;
            this.layer = layer;
        }
    }
}
