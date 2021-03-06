//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class IControlMode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IControlMode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IControlMode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~IControlMode() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_IControlMode(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual bool getControlMode(int j, SWIGTYPE_p_int mode) {
    bool ret = yarpPINVOKE.IControlMode_getControlMode__SWIG_0(swigCPtr, j, SWIGTYPE_p_int.getCPtr(mode));
    return ret;
  }

  public virtual bool getControlModes(SWIGTYPE_p_int modes) {
    bool ret = yarpPINVOKE.IControlMode_getControlModes__SWIG_0(swigCPtr, SWIGTYPE_p_int.getCPtr(modes));
    return ret;
  }

  public virtual bool getControlModes(int n_joint, SWIGTYPE_p_int joints, SWIGTYPE_p_int modes) {
    bool ret = yarpPINVOKE.IControlMode_getControlModes__SWIG_1(swigCPtr, n_joint, SWIGTYPE_p_int.getCPtr(joints), SWIGTYPE_p_int.getCPtr(modes));
    return ret;
  }

  public virtual bool setControlMode(int j, int mode) {
    bool ret = yarpPINVOKE.IControlMode_setControlMode(swigCPtr, j, mode);
    return ret;
  }

  public virtual bool setControlModes(int n_joint, SWIGTYPE_p_int joints, SWIGTYPE_p_int modes) {
    bool ret = yarpPINVOKE.IControlMode_setControlModes__SWIG_0(swigCPtr, n_joint, SWIGTYPE_p_int.getCPtr(joints), SWIGTYPE_p_int.getCPtr(modes));
    return ret;
  }

  public virtual bool setControlModes(SWIGTYPE_p_int modes) {
    bool ret = yarpPINVOKE.IControlMode_setControlModes__SWIG_1(swigCPtr, SWIGTYPE_p_int.getCPtr(modes));
    return ret;
  }

  public int getControlMode(int j) {
    int ret = yarpPINVOKE.IControlMode_getControlMode__SWIG_1(swigCPtr, j);
    return ret;
  }

  public bool getControlModes(IVector data) {
    bool ret = yarpPINVOKE.IControlMode_getControlModes__SWIG_2(swigCPtr, IVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getControlModes(int n_joint, IVector joints, IVector data) {
    bool ret = yarpPINVOKE.IControlMode_getControlModes__SWIG_3(swigCPtr, n_joint, IVector.getCPtr(joints), IVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setControlModes(IVector data) {
    bool ret = yarpPINVOKE.IControlMode_setControlModes__SWIG_2(swigCPtr, IVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setControlModes(int n_joint, IVector joints, IVector data) {
    bool ret = yarpPINVOKE.IControlMode_setControlModes__SWIG_3(swigCPtr, n_joint, IVector.getCPtr(joints), IVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
