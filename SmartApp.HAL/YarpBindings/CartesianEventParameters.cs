//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CartesianEventParameters : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CartesianEventParameters(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CartesianEventParameters obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CartesianEventParameters() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_CartesianEventParameters(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string type {
    set {
      yarpPINVOKE.CartesianEventParameters_type_set(swigCPtr, value);
      if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = yarpPINVOKE.CartesianEventParameters_type_get(swigCPtr);
      if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double motionOngoingCheckPoint {
    set {
      yarpPINVOKE.CartesianEventParameters_motionOngoingCheckPoint_set(swigCPtr, value);
    } 
    get {
      double ret = yarpPINVOKE.CartesianEventParameters_motionOngoingCheckPoint_get(swigCPtr);
      return ret;
    } 
  }

  public CartesianEventParameters() : this(yarpPINVOKE.new_CartesianEventParameters(), true) {
  }

}
