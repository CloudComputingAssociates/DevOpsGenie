using System.Collections.Generic;

namespace AzureLib
{
    public interface IResourceGroup
    {
        List<SimpleNamedString> GetResourceGroupNames();
    }
}