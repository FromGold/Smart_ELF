//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CartesianEvent : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CartesianEvent(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CartesianEvent obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CartesianEvent() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_CartesianEvent(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public CartesianEventParameters cartesianEventParameters {
    set {
      yarpPINVOKE.CartesianEvent_cartesianEventParameters_set(swigCPtr, CartesianEventParameters.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = yarpPINVOKE.CartesianEvent_cartesianEventParameters_get(swigCPtr);
      CartesianEventParameters ret = (cPtr == global::System.IntPtr.Zero) ? null : new CartesianEventParameters(cPtr, false);
      return ret;
    } 
  }

  public CartesianEventVariables cartesianEventVariables {
    set {
      yarpPINVOKE.CartesianEvent_cartesianEventVariables_set(swigCPtr, CartesianEventVariables.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = yarpPINVOKE.CartesianEvent_cartesianEventVariables_get(swigCPtr);
      CartesianEventVariables ret = (cPtr == global::System.IntPtr.Zero) ? null : new CartesianEventVariables(cPtr, false);
      return ret;
    } 
  }

  public virtual void cartesianEventCallback() {
    yarpPINVOKE.CartesianEvent_cartesianEventCallback(swigCPtr);
  }

}
