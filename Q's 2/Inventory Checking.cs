using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_s_2
{
    public partial class Inventory_Checking : Component
    {
        public Inventory_Checking()
        {
            InitializeComponent();
        }

        public Inventory_Checking(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
