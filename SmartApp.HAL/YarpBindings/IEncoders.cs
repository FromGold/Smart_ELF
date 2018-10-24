//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class IEncoders : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IEncoders(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IEncoders obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~IEncoders() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_IEncoders(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual bool getAxes(SWIGTYPE_p_int ax) {
    bool ret = yarpPINVOKE.IEncoders_getAxes__SWIG_0(swigCPtr, SWIGTYPE_p_int.getCPtr(ax));
    return ret;
  }

  public virtual bool resetEncoder(int j) {
    bool ret = yarpPINVOKE.IEncoders_resetEncoder(swigCPtr, j);
    return ret;
  }

  public virtual bool resetEncoders() {
    bool ret = yarpPINVOKE.IEncoders_resetEncoders(swigCPtr);
    return ret;
  }

  public virtual bool setEncoder(int j, double val) {
    bool ret = yarpPINVOKE.IEncoders_setEncoder(swigCPtr, j, val);
    return ret;
  }

  public virtual bool setEncoders(SWIGTYPE_p_double vals) {
    bool ret = yarpPINVOKE.IEncoders_setEncoders__SWIG_0(swigCPtr, SWIGTYPE_p_double.getCPtr(vals));
    return ret;
  }

  public virtual bool getEncoder(int j, SWIGTYPE_p_double v) {
    bool ret = yarpPINVOKE.IEncoders_getEncoder__SWIG_0(swigCPtr, j, SWIGTYPE_p_double.getCPtr(v));
    return ret;
  }

  public virtual bool getEncoders(SWIGTYPE_p_double encs) {
    bool ret = yarpPINVOKE.IEncoders_getEncoders__SWIG_0(swigCPtr, SWIGTYPE_p_double.getCPtr(encs));
    return ret;
  }

  public virtual bool getEncoderSpeed(int j, SWIGTYPE_p_double sp) {
    bool ret = yarpPINVOKE.IEncoders_getEncoderSpeed__SWIG_0(swigCPtr, j, SWIGTYPE_p_double.getCPtr(sp));
    return ret;
  }

  public virtual bool getEncoderSpeeds(SWIGTYPE_p_double spds) {
    bool ret = yarpPINVOKE.IEncoders_getEncoderSpeeds__SWIG_0(swigCPtr, SWIGTYPE_p_double.getCPtr(spds));
    return ret;
  }

  public virtual bool getEncoderAcceleration(int j, SWIGTYPE_p_double spds) {
    bool ret = yarpPINVOKE.IEncoders_getEncoderAcceleration__SWIG_0(swigCPtr, j, SWIGTYPE_p_double.getCPtr(spds));
    return ret;
  }

  public virtual bool getEncoderAccelerations(SWIGTYPE_p_double accs) {
    bool ret = yarpPINVOKE.IEncoders_getEncoderAccelerations__SWIG_0(swigCPtr, SWIGTYPE_p_double.getCPtr(accs));
    return ret;
  }

  public int getAxes() {
    int ret = yarpPINVOKE.IEncoders_getAxes__SWIG_1(swigCPtr);
    return ret;
  }

  public bool setEncoders(DVector data) {
    bool ret = yarpPINVOKE.IEncoders_setEncoders__SWIG_1(swigCPtr, DVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double getEncoder(int j) {
    double ret = yarpPINVOKE.IEncoders_getEncoder__SWIG_1(swigCPtr, j);
    return ret;
  }

  public bool getEncoders(DVector data) {
    bool ret = yarpPINVOKE.IEncoders_getEncoders__SWIG_1(swigCPtr, DVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double getEncoderSpeed(int j) {
    double ret = yarpPINVOKE.IEncoders_getEncoderSpeed__SWIG_1(swigCPtr, j);
    return ret;
  }

  public bool getEncoderSpeeds(DVector data) {
    bool ret = yarpPINVOKE.IEncoders_getEncoderSpeeds__SWIG_1(swigCPtr, DVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double getEncoderAcceleration(int j) {
    double ret = yarpPINVOKE.IEncoders_getEncoderAcceleration__SWIG_1(swigCPtr, j);
    return ret;
  }

  public bool getEncoderAccelerations(DVector data) {
    bool ret = yarpPINVOKE.IEncoders_getEncoderAccelerations__SWIG_1(swigCPtr, DVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
