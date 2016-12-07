using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AzureLib
{
    [Serializable]
    public class SimpleNamedString : ISerializable  // this is used to pass some simple JSON lists back with  name\value pairs; and without the extra tokens
    {                                               // that .NET FRK classes:  KeyValuePair or Dictionary put in the serialized JSON
        public string name;
        public string value;

        public SimpleNamedString(string inName, string inValue)    // ctor
        {
            name = inName;
            value = inValue;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(this.name, this.value);
        }
    }
}
