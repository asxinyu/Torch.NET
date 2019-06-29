// Code generated by CodeMinion: https://github.com/SciSharp/CodeMinion

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using Numpy;
using Numpy.Models;

namespace Torch
{
    public static partial class torch {
        public static partial class nn {
            /// <summary>
            ///	Creates a criterion that optimizes a two-class classification
            ///	logistic loss between input tensor \(x\) and target tensor \(y\)
            ///	(containing 1 or -1).<br></br>
            ///	
            ///	\[\text{loss}(x, y) = \sum_i \frac{\log(1 + \exp(-y[i]*x[i]))}{\text{x.nelement}()}
            ///	
            ///	\]
            /// </summary>
            public partial class SoftMarginLoss : Module
            {
                // auto-generated class
                
                public SoftMarginLoss(PyObject pyobj) : base(pyobj) { }
                
                public SoftMarginLoss(Module other) : base(other.PyObject as PyObject) { }
                
                public SoftMarginLoss(bool? size_average = null, bool? reduce = null, string reduction = "mean")
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var __self__=nn;
                    var pyargs=ToTuple(new object[]
                    {
                    });
                    var kwargs=new PyDict();
                    if (size_average!=null) kwargs["size_average"]=ToPython(size_average);
                    if (reduce!=null) kwargs["reduce"]=ToPython(reduce);
                    if (reduction!="mean") kwargs["reduction"]=ToPython(reduction);
                    dynamic py = __self__.InvokeMethod("SoftMarginLoss", pyargs, kwargs);
                    self=py as PyObject;
                }
                
            }
        }
    }
    
}
