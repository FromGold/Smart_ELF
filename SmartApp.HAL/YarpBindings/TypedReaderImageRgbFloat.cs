//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TypedReaderImageRgbFloat : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TypedReaderImageRgbFloat(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TypedReaderImageRgbFloat obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TypedReaderImageRgbFloat() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_TypedReaderImageRgbFloat(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public new void setStrict(bool strict) {
    yarpPINVOKE.TypedReaderImageRgbFloat_setStrict__SWIG_0(swigCPtr, strict);
  }

  public new void setStrict() {
    yarpPINVOKE.TypedReaderImageRgbFloat_setStrict__SWIG_1(swigCPtr);
  }

  public new ImageRgbFloat read(bool shouldWait) {
    global::System.IntPtr cPtr = yarpPINVOKE.TypedReaderImageRgbFloat_read__SWIG_0(swigCPtr, shouldWait);
    ImageRgbFloat ret = (cPtr == global::System.IntPtr.Zero) ? null : new ImageRgbFloat(cPtr, false);
    return ret;
  }

  public new ImageRgbFloat read() {
    global::System.IntPtr cPtr = yarpPINVOKE.TypedReaderImageRgbFloat_read__SWIG_1(swigCPtr);
    ImageRgbFloat ret = (cPtr == global::System.IntPtr.Zero) ? null : new ImageRgbFloat(cPtr, false);
    return ret;
  }

  public virtual void interrupt() {
    yarpPINVOKE.TypedReaderImageRgbFloat_interrupt(swigCPtr);
  }

  public new ImageRgbFloat lastRead() {
    global::System.IntPtr cPtr = yarpPINVOKE.TypedReaderImageRgbFloat_lastRead(swigCPtr);
    ImageRgbFloat ret = (cPtr == global::System.IntPtr.Zero) ? null : new ImageRgbFloat(cPtr, false);
    return ret;
  }

  public new bool isClosed() {
    bool ret = yarpPINVOKE.TypedReaderImageRgbFloat_isClosed(swigCPtr);
    return ret;
  }

  public new void useCallback(TypedReaderCallbackImageRgbFloat callback) {
    yarpPINVOKE.TypedReaderImageRgbFloat_useCallback(swigCPtr, TypedReaderCallbackImageRgbFloat.getCPtr(callback));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void disableCallback() {
    yarpPINVOKE.TypedReaderImageRgbFloat_disableCallback(swigCPtr);
  }

  public new int getPendingReads() {
    int ret = yarpPINVOKE.TypedReaderImageRgbFloat_getPendingReads(swigCPtr);
    return ret;
  }

  public virtual string getName() {
    string ret = yarpPINVOKE.TypedReaderImageRgbFloat_getName(swigCPtr);
    return ret;
  }

  public new void setReplier(PortReader reader) {
    yarpPINVOKE.TypedReaderImageRgbFloat_setReplier(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_void acquire() {
    global::System.IntPtr cPtr = yarpPINVOKE.TypedReaderImageRgbFloat_acquire(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public virtual void release(SWIGTYPE_p_void handle) {
    yarpPINVOKE.TypedReaderImageRgbFloat_release(swigCPtr, SWIGTYPE_p_void.getCPtr(handle));
  }

  public new void setTargetPeriod(double period) {
    yarpPINVOKE.TypedReaderImageRgbFloat_setTargetPeriod(swigCPtr, period);
  }

}
