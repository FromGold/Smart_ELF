//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ITorqueControlRaw : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ITorqueControlRaw(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ITorqueControlRaw obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ITorqueControlRaw() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_ITorqueControlRaw(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual bool getAxes(SWIGTYPE_p_int ax) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getAxes(swigCPtr, SWIGTYPE_p_int.getCPtr(ax));
    return ret;
  }

  public virtual bool getTorqueRaw(int j, SWIGTYPE_p_double t) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getTorqueRaw(swigCPtr, j, SWIGTYPE_p_double.getCPtr(t));
    return ret;
  }

  public virtual bool getTorquesRaw(SWIGTYPE_p_double t) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getTorquesRaw(swigCPtr, SWIGTYPE_p_double.getCPtr(t));
    return ret;
  }

  public virtual bool getTorqueRangeRaw(int j, SWIGTYPE_p_double min, SWIGTYPE_p_double max) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getTorqueRangeRaw(swigCPtr, j, SWIGTYPE_p_double.getCPtr(min), SWIGTYPE_p_double.getCPtr(max));
    return ret;
  }

  public virtual bool getTorqueRangesRaw(SWIGTYPE_p_double min, SWIGTYPE_p_double max) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getTorqueRangesRaw(swigCPtr, SWIGTYPE_p_double.getCPtr(min), SWIGTYPE_p_double.getCPtr(max));
    return ret;
  }

  public virtual bool setRefTorquesRaw(SWIGTYPE_p_double t) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_setRefTorquesRaw__SWIG_0(swigCPtr, SWIGTYPE_p_double.getCPtr(t));
    return ret;
  }

  public virtual bool setRefTorqueRaw(int j, double t) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_setRefTorqueRaw(swigCPtr, j, t);
    return ret;
  }

  public virtual bool setRefTorquesRaw(int n_joint, SWIGTYPE_p_int joints, SWIGTYPE_p_double t) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_setRefTorquesRaw__SWIG_1(swigCPtr, n_joint, SWIGTYPE_p_int.getCPtr(joints), SWIGTYPE_p_double.getCPtr(t));
    return ret;
  }

  public virtual bool getRefTorquesRaw(SWIGTYPE_p_double t) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getRefTorquesRaw(swigCPtr, SWIGTYPE_p_double.getCPtr(t));
    return ret;
  }

  public virtual bool getRefTorqueRaw(int j, SWIGTYPE_p_double t) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getRefTorqueRaw(swigCPtr, j, SWIGTYPE_p_double.getCPtr(t));
    return ret;
  }

  public virtual bool getMotorTorqueParamsRaw(int j, MotorTorqueParameters arg1) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getMotorTorqueParamsRaw(swigCPtr, j, MotorTorqueParameters.getCPtr(arg1));
    return ret;
  }

  public virtual bool setMotorTorqueParamsRaw(int j, MotorTorqueParameters arg1) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_setMotorTorqueParamsRaw(swigCPtr, j, MotorTorqueParameters.getCPtr(arg1));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
