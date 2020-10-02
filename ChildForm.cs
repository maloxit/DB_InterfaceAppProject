using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GabdushevDB_InterfaceAppProject
{
    public class ChildForm: Form
    {
        public event Action<ChildForm> ChildFormGoBack;
        protected void GoBack()
        {
            ChildFormGoBack(this);
        }
    }

    
}
