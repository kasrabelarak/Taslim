using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationHost.Service
{
    public interface IViewerCountService
    {
        int IncrementViewer();
    }
    public class ViewerCountService: IViewerCountService
    {
        int counter = 0;
        public int IncrementViewer()
        {
            return ++counter;
        }
    }
}
