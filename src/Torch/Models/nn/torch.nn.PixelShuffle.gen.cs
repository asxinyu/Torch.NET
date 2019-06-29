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
            ///	Rearranges elements in a tensor of shape \((*, C \times r^2, H, W)\)
            ///	to a tensor of shape \((*, C, H \times r, W \times r)\).<br></br>
            ///	
            ///	This is useful for implementing efficient sub-pixel convolution
            ///	with a stride of \(1/r\).<br></br>
            ///	
            ///	Look at the paper:
            ///	Real-Time Single Image and Video Super-Resolution Using an Efficient Sub-Pixel Convolutional Neural Network
            ///	by Shi et.<br></br>
            ///	 al (2016) for more details.
            /// </summary>
            public partial class PixelShuffle : Module
            {
                // auto-generated class
                
                public PixelShuffle(PyObject pyobj) : base(pyobj) { }
                
                public PixelShuffle(Module other) : base(other.PyObject as PyObject) { }
                
                public PixelShuffle(int upscale_factor)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var __self__=nn;
                    var pyargs=ToTuple(new object[]
                    {
                        upscale_factor,
                    });
                    var kwargs=new PyDict();
                    dynamic py = __self__.InvokeMethod("PixelShuffle", pyargs, kwargs);
                    self=py as PyObject;
                }
                
            }
        }
    }
    
}
