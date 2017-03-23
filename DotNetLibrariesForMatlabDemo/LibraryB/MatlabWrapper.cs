using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionANative;

namespace LibraryB
{
    public class MatlabWrapper
    {

#if DEBUG
        /// <summary>
        /// To be called from MATLAB to overload the AssemblyResolve event. 
        /// </summary>
        public static void SetupAssemblyResolveForMatlabUnitTests()
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
        }

        /// <summary>
        /// AssemblyResolve implementation which allows MATLAB to use already loaded Assemblies for deserialization
        /// instead of only allowing Assemblies from the executable directory
        /// </summary>
        private static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            System.Reflection.Assembly ayResult = null;
            string sShortAssemblyName = args.Name.Split(',')[0];
            System.Reflection.Assembly[] ayAssemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (System.Reflection.Assembly ayAssembly in ayAssemblies)
            {
                if (sShortAssemblyName == ayAssembly.FullName.Split(',')[0])
                {
                    ayResult = ayAssembly;
                    break;
                }
            }
            return ayResult;
        }
#endif
        public static void Run()
        {
            DotNetPocoExample input = new DotNetPocoExample {MyProperty = "csharp string variable"};
            Class1 matlabScript = new Class1();
            Console.WriteLine(System.Reflection.Assembly.GetExecutingAssembly().Location);
#if DEBUG
            // First call the initLib function with the location of the libraryB.dll Assembly
            // This code is made generic since this class is going to be used in a template mostly.
            Type wrapperClass = typeof(MatlabWrapper);
            string callBackFunctionCall = $"{wrapperClass.Namespace}.{wrapperClass.Name}.SetupAssemblyResolveForMatlabUnitTests";
            matlabScript.LoadDotNetWrapper(System.Reflection.Assembly.GetExecutingAssembly().Location, callBackFunctionCall);
#endif

            // Then call the normal function
            matlabScript.FunctionA(input);
        }
    }

#if DEBUG
    [Serializable()]
#endif
    public class DotNetPocoExample
    {
        public string MyProperty { get; set; }
    }
}
