using System.Collections.Generic;

namespace AzureLib
{
    public interface IResourceGroup
    {
        List<KeyValuePair<string,string>> GetResourceGroupNames();
    }
}