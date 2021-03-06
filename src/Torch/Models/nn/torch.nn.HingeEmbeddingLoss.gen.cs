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
            ///	Measures the loss given an input tensor \(x\) and a labels tensor \(y\)
            ///	(containing 1 or -1).<br></br>
            ///	
            ///	This is usually used for measuring whether two inputs are similar or
            ///	dissimilar, e.g.<br></br>
            ///	 using the L1 pairwise distance as \(x\), and is typically
            ///	used for learning nonlinear embeddings or semi-supervised learning.<br></br>
            ///	
            ///	The loss function for \(n\)-th sample in the mini-batch is
            ///	
            ///	\[l_n = \begin{cases}
            ///	    x_n, & \text{if}\; y_n = 1,\\
            ///	    \max \{0, \Delta - x_n\}, & \text{if}\; y_n = -1,
            ///	\end{cases}
            ///	
            ///	\]
            ///	
            ///	and the total loss functions is
            ///	
            ///	\[\ell(x, y) = \begin{cases}
            ///	    \operatorname{mean}(L), & \text{if reduction} = \text{'mean';}\\
            ///	    \operatorname{sum}(L),  & \text{if reduction} = \text{'sum'.}
            ///	\end{cases}
            ///	
            ///	\]
            ///	
            ///	where \(L = \{l_1,\dots,l_N\}^\top\).
            /// </summary>
            public partial class HingeEmbeddingLoss : Module
            {
                // auto-generated class
                
                public HingeEmbeddingLoss(PyObject pyobj) : base(pyobj) { }
                
                public HingeEmbeddingLoss(Module other) : base(other.PyObject as PyObject) { }
                
                public HingeEmbeddingLoss(float? margin = 1.0f, bool? size_average = null, bool? reduce = null, string reduction = "mean")
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var __self__=nn;
                    var pyargs=ToTuple(new object[]
                    {
                    });
                    var kwargs=new PyDict();
                    if (margin!=1.0f) kwargs["margin"]=ToPython(margin);
                    if (size_average!=null) kwargs["size_average"]=ToPython(size_average);
                    if (reduce!=null) kwargs["reduce"]=ToPython(reduce);
                    if (reduction!="mean") kwargs["reduction"]=ToPython(reduction);
                    dynamic py = __self__.InvokeMethod("HingeEmbeddingLoss", pyargs, kwargs);
                    self=py as PyObject;
                }
                
            }
        }
    }
    
}
