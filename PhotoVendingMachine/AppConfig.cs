using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Accord.Video.DirectShow;

namespace PhotoVendingMachine
{
    public static class AppConfig
    {
        public static Color colorLightGray = Color.FromArgb(230, 230, 230);
        public static Color colorLightBlue = Color.FromArgb(81, 172, 251);
        public static Color colorBlue = Color.FromArgb(12, 111, 239);
        public static Color colorDarkBlue = Color.FromArgb(11, 92, 202);
        public static Color colorRed = Color.FromArgb(254, 16, 44);
        public static Color colorDarkRed = Color.FromArgb(242, 2, 32);

        public static List<FilterInfo> cameraList = new FilterInfoCollection(FilterCategory.VideoInputDevice).ToList().Where(x => x.Name.Trim().Length > 0).ToList();
    }
}
