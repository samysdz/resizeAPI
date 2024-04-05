using Resize.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resize.Application
{
    public class ResizeApplication : IResizeApplication
    {
        public Task<Dimensions> InitialDimentions(string info)
        {
            return null;
        }

        public Task<Dimensions> UpdateDimentions(string info)
        {
            return null;
        }
    }
}
