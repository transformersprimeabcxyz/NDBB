using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDBB
{
    public partial class formMain
    {
        // Returns the selected namespace
        String SelectedNamespace
        {
            get
            {
                return namespaceListBox.Items[namespaceListBox.SelectedIndex].ToString();
            }
        }

        // Returns the current selected function's hash
        String SelectedHash
        {
            get
            {
                if (nativesListView.SelectedItems.Count > 0)
                    return nativesListView.SelectedItems[0].Text;
                return string.Empty;
            }
        }

        // Returns documentions for given hash
        // function parameters, jhash
        String Docs(String hash)
        {
            if (natives == null) return null;

            String doc = String.Empty;

            NativeFunction function = GetNativeFunction(hash);
            if (function == null) return string.Empty;

            doc += String.Format("\n Details for {0}::_{1} [{2}] JHash {3}\n", function.Namespace, hash, function.Name, function.JHash);

            doc += "\n Function result: " + function.Result + "\n";

            doc += "\n Function parameters:\n";
            foreach (FunctionParameter _parameter in function.Params)
                doc += String.Format("\t{0} {1}\n", _parameter.Type, _parameter.Name);

            doc += "\n Native call:\n\t";
            doc += GetFunctionCallString(function) + '\n';

            return doc;
        }

        // Returns native function based on given hash
        NativeFunction GetNativeFunction(String hash)
        {
            if (natives == null) return null;

            foreach (NativeNamespace _namespace in natives)
                foreach (NativeFunction _function in _namespace.Functions)
                    if (_function.Hash == hash)
                        return _function;
            return null;
        }

        // Returns a string that can be used for calling a c++ native function
        String GetFunctionCallString(NativeFunction function)
        {
            if (natives == null) return null;

            String name = function.Namespace + "::";
            if (function.Name.Length > 0)
                name += function.Name;
            else
                name += "_" + function.Hash;

            String pstr = String.Empty;
            foreach (FunctionParameter _parameter in function.Params)
                pstr += String.Format("{0}, ", _parameter.Name);
            if (pstr.Length >= 3)
                pstr = pstr.Remove(pstr.Length - 2);

            return String.Format("{0}({1})", name, pstr);
        }
    }
}
