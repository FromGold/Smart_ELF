//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PixelRgbInt : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PixelRgbInt(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PixelRgbInt obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PixelRgbInt() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_PixelRgbInt(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int r {
    set {
      yarpPINVOKE.PixelRgbInt_r_set(swigCPtr, value);
    } 
    get {
      int ret = yarpPINVOKE.PixelRgbInt_r_get(swigCPtr);
      return ret;
    } 
  }

  public int g {
    set {
      yarpPINVOKE.PixelRgbInt_g_set(swigCPtr, value);
    } 
    get {
      int ret = yarpPINVOKE.PixelRgbInt_g_get(swigCPtr);
      return ret;
    } 
  }

  public int b {
    set {
      yarpPINVOKE.PixelRgbInt_b_set(swigCPtr, value);
    } 
    get {
      int ret = yarpPINVOKE.PixelRgbInt_b_get(swigCPtr);
      return ret;
    } 
  }

  public PixelRgbInt() : this(yarpPINVOKE.new_PixelRgbInt__SWIG_0(), true) {
  }

  public PixelRgbInt(int n_r, int n_g, int n_b) : this(yarpPINVOKE.new_PixelRgbInt__SWIG_1(n_r, n_g, n_b), true) {
  }

}
