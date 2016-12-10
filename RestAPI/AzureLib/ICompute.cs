using System.Collections.Generic;

namespace AzureLib
{
    public interface ICompute
    {
        List<SimpleNamedString> GetVirtualMachines(string resourceGroupString);
    }
}