//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Random : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Random(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Random obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Random() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_Random(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static double uniform() {
    double ret = yarpPINVOKE.Random_uniform__SWIG_0();
    return ret;
  }

  public static double normal(double m, double s) {
    double ret = yarpPINVOKE.Random_normal__SWIG_0(m, s);
    return ret;
  }

  public static void seed_c(int seed) {
    yarpPINVOKE.Random_seed_c(seed);
  }

  public static double normal() {
    double ret = yarpPINVOKE.Random_normal__SWIG_1();
    return ret;
  }

  public static int uniform(int min, int max) {
    int ret = yarpPINVOKE.Random_uniform__SWIG_1(min, max);
    return ret;
  }

  public Random() : this(yarpPINVOKE.new_Random(), true) {
  }

}
