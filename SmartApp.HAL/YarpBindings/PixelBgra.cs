//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PixelBgra : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PixelBgra(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PixelBgra obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PixelBgra() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_PixelBgra(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public byte b {
    set {
      yarpPINVOKE.PixelBgra_b_set(swigCPtr, value);
    } 
    get {
      byte ret = yarpPINVOKE.PixelBgra_b_get(swigCPtr);
      return ret;
    } 
  }

  public byte g {
    set {
      yarpPINVOKE.PixelBgra_g_set(swigCPtr, value);
    } 
    get {
      byte ret = yarpPINVOKE.PixelBgra_g_get(swigCPtr);
      return ret;
    } 
  }

  public byte r {
    set {
      yarpPINVOKE.PixelBgra_r_set(swigCPtr, value);
    } 
    get {
      byte ret = yarpPINVOKE.PixelBgra_r_get(swigCPtr);
      return ret;
    } 
  }

  public byte a {
    set {
      yarpPINVOKE.PixelBgra_a_set(swigCPtr, value);
    } 
    get {
      byte ret = yarpPINVOKE.PixelBgra_a_get(swigCPtr);
      return ret;
    } 
  }

  public PixelBgra() : this(yarpPINVOKE.new_PixelBgra__SWIG_0(), true) {
  }

  public PixelBgra(byte n_r, byte n_g, byte n_b, byte n_a) : this(yarpPINVOKE.new_PixelBgra__SWIG_1(n_r, n_g, n_b, n_a), true) {
  }

}
