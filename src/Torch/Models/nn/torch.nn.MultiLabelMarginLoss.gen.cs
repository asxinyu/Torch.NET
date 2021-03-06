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
            ///	Creates a criterion that optimizes a multi-class multi-classification
            ///	hinge loss (margin-based loss) between input \(x\) (a 2D mini-batch Tensor)
            ///	and output \(y\) (which is a 2D Tensor of target class indices).<br></br>
            ///	
            ///	For each sample in the mini-batch:
            ///	
            ///	\[\text{loss}(x, y) = \sum_{ij}\frac{\max(0, 1 - (x[y[j]] - x[i]))}{\text{x.size}(0)}
            ///	
            ///	\]
            ///	
            ///	where \(x \in \left\{0, \; \cdots , \; \text{x.size}(0) - 1\right\}\), \(y \in \left\{0, \; \cdots , \; \text{y.size}(0) - 1\right\}\), \(0 \leq y[j] \leq \text{x.size}(0)-1\), and \(i \neq y[j]\) for all \(i\) and \(j\).<br></br>
            ///	
            ///	\(y\) and \(x\) must have the same size.<br></br>
            ///	
            ///	The criterion only considers a contiguous block of non-negative targets that
            ///	starts at the front.<br></br>
            ///	
            ///	This allows for different samples to have variable amounts of target classes.
            /// </summary>
            public partial class MultiLabelMarginLoss : Module
            {
                // auto-generated class
                
                public MultiLabelMarginLoss(PyObject pyobj) : base(pyobj) { }
                
                public MultiLabelMarginLoss(Module other) : base(other.PyObject as PyObject) { }
                
                public MultiLabelMarginLoss(bool? size_average = null, bool? reduce = null, string reduction = "mean")
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
                    dynamic py = __self__.InvokeMethod("MultiLabelMarginLoss", pyargs, kwargs);
                    self=py as PyObject;
                }
                
            }
        }
    }
    
}
