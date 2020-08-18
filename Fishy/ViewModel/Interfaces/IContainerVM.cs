using System.Collections.Generic;
using System.Windows.Controls;

namespace Fishy.ViewModel.Interfaces
{
    public interface IContainerVM
    {
        Dictionary<string, Page> Pages { get; set; }
    }
}
