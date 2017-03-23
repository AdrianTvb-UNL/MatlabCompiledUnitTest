 function LoadDotNetWrapper(dotNetWrapperLocation, callBackFunctionCall)
     NET.addAssembly(dotNetWrapperLocation);
     eval(callBackFunctionCall);
 end
