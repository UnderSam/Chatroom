using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

public class MySynchronizationContext : SynchronizationContext
{
    public override void Post(SendOrPostCallback d, object state)
    {
        Thread t = new Thread(new ThreadStart(() => {  }));
        t.SetApartmentState(ApartmentState.STA);
        t.Start(state);
    }
}

