/*
* MATLAB Compiler: 6.1 (R2015b)
* Date: Thu Mar 23 16:09:37 2017
* Arguments: "-B" "macro_default" "-W" "dotnet:FunctionA,Class1,0.0,private" "-T"
* "link:lib" "-d"
* "C:\Users\Adrian.vanBerkhout\Documents\MATLAB\dotnettestappdemo\FunctionA\for_testing"
* "-v"
* "class{Class1:C:\Users\Adrian.vanBerkhout\Documents\MATLAB\dotnettestappdemo\FunctionA.m
* ,C:\Users\Adrian.vanBerkhout\Documents\MATLAB\dotnettestappdemo\LoadDotNetWrapper.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace FunctionA
{

  /// <summary>
  /// The Class1 class provides a CLS compliant, MWArray interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\Adrian.vanBerkhout\Documents\MATLAB\dotnettestappdemo\FunctionA.m
  /// <newpara></newpara>
  /// C:\Users\Adrian.vanBerkhout\Documents\MATLAB\dotnettestappdemo\LoadDotNetWrapper.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class Class1 : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static Class1()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "FunctionA.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the Class1 class.
    /// </summary>
    public Class1()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Class1()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the FunctionA MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void FunctionA()
    {
      mcr.EvaluateFunction(0, "FunctionA", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the FunctionA MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="input">Input argument #1</param>
    ///
    public void FunctionA(MWArray input)
    {
      mcr.EvaluateFunction(0, "FunctionA", input);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the FunctionA MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] FunctionA(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "FunctionA", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the FunctionA MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="input">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] FunctionA(int numArgsOut, MWArray input)
    {
      return mcr.EvaluateFunction(numArgsOut, "FunctionA", input);
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the LoadDotNetWrapper MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void LoadDotNetWrapper()
    {
      mcr.EvaluateFunction(0, "LoadDotNetWrapper", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the LoadDotNetWrapper MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="dotNetWrapperLocation">Input argument #1</param>
    ///
    public void LoadDotNetWrapper(MWArray dotNetWrapperLocation)
    {
      mcr.EvaluateFunction(0, "LoadDotNetWrapper", dotNetWrapperLocation);
    }


    /// <summary>
    /// Provides a void output, 2-input MWArrayinterface to the LoadDotNetWrapper MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="dotNetWrapperLocation">Input argument #1</param>
    /// <param name="callBackFunctionCall">Input argument #2</param>
    ///
    public void LoadDotNetWrapper(MWArray dotNetWrapperLocation, MWArray 
                            callBackFunctionCall)
    {
      mcr.EvaluateFunction(0, "LoadDotNetWrapper", dotNetWrapperLocation, callBackFunctionCall);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the LoadDotNetWrapper MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] LoadDotNetWrapper(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "LoadDotNetWrapper", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the LoadDotNetWrapper MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="dotNetWrapperLocation">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] LoadDotNetWrapper(int numArgsOut, MWArray dotNetWrapperLocation)
    {
      return mcr.EvaluateFunction(numArgsOut, "LoadDotNetWrapper", dotNetWrapperLocation);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the LoadDotNetWrapper MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="dotNetWrapperLocation">Input argument #1</param>
    /// <param name="callBackFunctionCall">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] LoadDotNetWrapper(int numArgsOut, MWArray dotNetWrapperLocation, 
                                 MWArray callBackFunctionCall)
    {
      return mcr.EvaluateFunction(numArgsOut, "LoadDotNetWrapper", dotNetWrapperLocation, callBackFunctionCall);
    }



    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
