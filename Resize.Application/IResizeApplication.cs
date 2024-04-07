using Resize.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resize.Application
{
    public interface IResizeApplication
    {
        Task<Dimensions> InitialDimentions();
        Task<Dimensions> UpdateDimentions(Dimensions info);
    }
}
