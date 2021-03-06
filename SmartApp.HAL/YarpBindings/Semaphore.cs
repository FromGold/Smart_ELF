//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Semaphore : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Semaphore(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Semaphore obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Semaphore() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_Semaphore(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Semaphore(uint initialCount) : this(yarpPINVOKE.new_Semaphore__SWIG_0(initialCount), true) {
  }

  public Semaphore() : this(yarpPINVOKE.new_Semaphore__SWIG_1(), true) {
  }

  public void wait() {
    yarpPINVOKE.Semaphore_wait(swigCPtr);
  }

  public bool waitWithTimeout(double timeoutInSeconds) {
    bool ret = yarpPINVOKE.Semaphore_waitWithTimeout(swigCPtr, timeoutInSeconds);
    return ret;
  }

  public new bool check() {
    bool ret = yarpPINVOKE.Semaphore_check(swigCPtr);
    return ret;
  }

  public void post() {
    yarpPINVOKE.Semaphore_post(swigCPtr);
  }

}
