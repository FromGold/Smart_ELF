//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class RateThreadWrapper : PeriodicThread {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal RateThreadWrapper(global::System.IntPtr cPtr, bool cMemoryOwn) : base(yarpPINVOKE.RateThreadWrapper_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RateThreadWrapper obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RateThreadWrapper() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_RateThreadWrapper(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public RateThreadWrapper() : this(yarpPINVOKE.new_RateThreadWrapper__SWIG_0(), true) {
  }

  public RateThreadWrapper(SWIGTYPE_p_Runnable helper) : this(yarpPINVOKE.new_RateThreadWrapper__SWIG_1(SWIGTYPE_p_Runnable.getCPtr(helper)), true) {
  }

  public void detach() {
    yarpPINVOKE.RateThreadWrapper_detach(swigCPtr);
  }

  public virtual bool attach(SWIGTYPE_p_Runnable helper) {
    bool ret = yarpPINVOKE.RateThreadWrapper_attach__SWIG_0(swigCPtr, SWIGTYPE_p_Runnable.getCPtr(helper));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool open(double framerate, bool polling) {
    bool ret = yarpPINVOKE.RateThreadWrapper_open__SWIG_0(swigCPtr, framerate, polling);
    return ret;
  }

  public bool open(double framerate) {
    bool ret = yarpPINVOKE.RateThreadWrapper_open__SWIG_1(swigCPtr, framerate);
    return ret;
  }

  public bool open() {
    bool ret = yarpPINVOKE.RateThreadWrapper_open__SWIG_2(swigCPtr);
    return ret;
  }

  public void close() {
    yarpPINVOKE.RateThreadWrapper_close(swigCPtr);
  }

  public new void stop() {
    yarpPINVOKE.RateThreadWrapper_stop(swigCPtr);
  }

  public virtual void run() {
    yarpPINVOKE.RateThreadWrapper_run(swigCPtr);
  }

  public virtual bool threadInit() {
    bool ret = yarpPINVOKE.RateThreadWrapper_threadInit(swigCPtr);
    return ret;
  }

  public virtual void threadRelease() {
    yarpPINVOKE.RateThreadWrapper_threadRelease(swigCPtr);
  }

  public virtual void afterStart(bool success) {
    yarpPINVOKE.RateThreadWrapper_afterStart(swigCPtr, success);
  }

  public virtual void beforeStart() {
    yarpPINVOKE.RateThreadWrapper_beforeStart(swigCPtr);
  }

  public SWIGTYPE_p_Runnable getAttachment() {
    global::System.IntPtr cPtr = yarpPINVOKE.RateThreadWrapper_getAttachment(swigCPtr);
    SWIGTYPE_p_Runnable ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Runnable(cPtr, false);
    return ret;
  }

}
