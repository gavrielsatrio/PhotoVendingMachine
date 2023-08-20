using PhotoVendingMachine.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoVendingMachine.Types
{
    public class CameraType
    {
        public string OutputType { get; set; }
        public GradientButton Btn { get; set; }
        public UserControl Layout { get; set; }
        public string MethodToCaptureName { get; set; }
    }
}
