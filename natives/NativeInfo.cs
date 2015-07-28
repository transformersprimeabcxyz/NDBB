using System;
using System.Collections.Generic;
using System.Text;

namespace NDBB
{
    public class NativeNamespace
    {
        public String Name { get; set; }
        public List<NativeFunction> Functions { get; set; }
    }

    public class NativeFunction
    {
        public String Namespace { get; set; }
        public String Hash { get; set; }
        public String Name { get; set; }
        public List<FunctionParameter> Params { get; set; }
        public String Result { get; set; }
        public String JHash { get; set; }
    }

    public class FunctionParameter
    {
        public String Type { get; set; }
        public String Name { get; set; }
    }
}
