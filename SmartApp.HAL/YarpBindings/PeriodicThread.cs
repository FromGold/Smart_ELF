//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PeriodicThread : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PeriodicThread(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PeriodicThread obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PeriodicThread() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_PeriodicThread(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public bool start() {
    bool ret = yarpPINVOKE.PeriodicThread_start(swigCPtr);
    return ret;
  }

  public void step() {
    yarpPINVOKE.PeriodicThread_step(swigCPtr);
  }

  public void stop() {
    yarpPINVOKE.PeriodicThread_stop(swigCPtr);
  }

  public void askToStop() {
    yarpPINVOKE.PeriodicThread_askToStop(swigCPtr);
  }

  public bool isRunning() {
    bool ret = yarpPINVOKE.PeriodicThread_isRunning(swigCPtr);
    return ret;
  }

  public bool isSuspended() {
    bool ret = yarpPINVOKE.PeriodicThread_isSuspended(swigCPtr);
    return ret;
  }

  public bool setPeriod(double period) {
    bool ret = yarpPINVOKE.PeriodicThread_setPeriod(swigCPtr, period);
    return ret;
  }

  public double getPeriod() {
    double ret = yarpPINVOKE.PeriodicThread_getPeriod(swigCPtr);
    return ret;
  }

  public void suspend() {
    yarpPINVOKE.PeriodicThread_suspend(swigCPtr);
  }

  public void resume() {
    yarpPINVOKE.PeriodicThread_resume(swigCPtr);
  }

  public void resetStat() {
    yarpPINVOKE.PeriodicThread_resetStat(swigCPtr);
  }

  public double getEstimatedPeriod() {
    double ret = yarpPINVOKE.PeriodicThread_getEstimatedPeriod__SWIG_0(swigCPtr);
    return ret;
  }

  public void getEstimatedPeriod(SWIGTYPE_p_double av, SWIGTYPE_p_double std) {
    yarpPINVOKE.PeriodicThread_getEstimatedPeriod__SWIG_1(swigCPtr, SWIGTYPE_p_double.getCPtr(av), SWIGTYPE_p_double.getCPtr(std));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getIterations() {
    uint ret = yarpPINVOKE.PeriodicThread_getIterations(swigCPtr);
    return ret;
  }

  public double getEstimatedUsed() {
    double ret = yarpPINVOKE.PeriodicThread_getEstimatedUsed__SWIG_0(swigCPtr);
    return ret;
  }

  public void getEstimatedUsed(SWIGTYPE_p_double av, SWIGTYPE_p_double std) {
    yarpPINVOKE.PeriodicThread_getEstimatedUsed__SWIG_1(swigCPtr, SWIGTYPE_p_double.getCPtr(av), SWIGTYPE_p_double.getCPtr(std));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public int setPriority(int priority, int policy) {
    int ret = yarpPINVOKE.PeriodicThread_setPriority__SWIG_0(swigCPtr, priority, policy);
    return ret;
  }

  public int setPriority(int priority) {
    int ret = yarpPINVOKE.PeriodicThread_setPriority__SWIG_1(swigCPtr, priority);
    return ret;
  }

  public int getPriority() {
    int ret = yarpPINVOKE.PeriodicThread_getPriority(swigCPtr);
    return ret;
  }

  public int getPolicy() {
    int ret = yarpPINVOKE.PeriodicThread_getPolicy(swigCPtr);
    return ret;
  }

}
