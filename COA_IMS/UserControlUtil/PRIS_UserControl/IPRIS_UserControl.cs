using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_IMS.UserControlUtil.PRIS_UserControl
{
    public interface IPRIS_UserControl
    {
        string Value { get; set; }

        bool ReadOnly { get; set; }

        string Title { get; set; }

        bool IsRequired { get; set; }

        bool IsVisible { get; set; }

        bool IsMessageVisible { get; set; }

        Control IndicatorRoot { get; }

        Control ErrorRoot { get; }
    }
}
