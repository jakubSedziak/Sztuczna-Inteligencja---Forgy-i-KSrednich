using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Zad_1_Graf
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Chart WykresBledu
        {
            get { return this.WykresBleduKwantyzacji; }
            set { this.WykresBleduKwantyzacji = value; }
        }
    }
}
