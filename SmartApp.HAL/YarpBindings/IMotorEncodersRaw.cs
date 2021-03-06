//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class IMotorEncodersRaw : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IMotorEncodersRaw(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IMotorEncodersRaw obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~IMotorEncodersRaw() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_IMotorEncodersRaw(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual bool getNumberOfMotorEncodersRaw(SWIGTYPE_p_int num) {
    bool ret = yarpPINVOKE.IMotorEncodersRaw_getNumberOfMotorEncodersRaw(swigCPtr, SWIGTYPE_p_int.getCPtr(num));
    return ret;
  }

  public virtual bool resetMotorEncoderRaw(int m) {
    bool ret = yarpPINVOKE.IMotorEncodersRaw_resetMotorEncoderRaw(swigCPtr, m);
    return ret;
  }

  public virtual bool resetMotorEncodersRaw() {
    bool ret = yarpPINVOKE.IMotorEncodersRaw_resetMotorEncodersRaw(swigCPtr);
    return ret;
  }

  public virtual bool setMotorEncoderCountsPerRevolutionRaw(int m, double cpr) {
    bool ret = yarpPINVOKE.IMotorEncodersRaw_setMotorEncoderCountsPerRevolutionRaw(swigCPtr, m, cpr);
    return ret;
  }

  public virtual bool getMotorEncoderCountsPerRevolutionRaw(int m, SWIGTYPE_p_double cpr) {
    bool ret = yarpPINVOKE.IMotorEncodersRaw_getMotorEncoderCountsPerRevolutionRaw(swigCPtr, m, SWIGTYPE_p_double.getCPtr(cpr));
    return ret;
  }

  public virtual bool setMotorEncoderRaw(int m, double val) {
    bool ret = yarpPINVOKE.IMotorEncodersRaw_setMotorEncoderRaw(swigCPtr, m, val);
    return ret;
  }

  public virtual bool setMotorEncodersRaw(SWIGTYPE_p_double vals) {
    bool ret = yarpPINVOKE.IMotorEncodersRaw_setMotorEncodersRaw(swigCPtr, SWIGTYPE_p_double.getCPtr(vals));
    return ret;
  }

  public virtual bool getMotorEncoderRaw(int m, SWIGTYPE_p_double v) {
    bool ret = yarpPINVOKE.IMotorEncodersRaw_getMotorEncoderRaw(swigCPtr, m, SWIGTYPE_p_double.getCPtr(v));
    return ret;
  }

  public virtual bool getMotorEncodersRaw(SWIGTYPE_p_double encs) {
    bool ret = yarpPINVOKE.IMotorEncodersRaw_getMotorEncodersRaw(swigCPtr, SWIGTYPE_p_double.getCPtr(encs));
    return ret;
  }

  public virtual bool getMotorEncodersTimedRaw(SWIGTYPE_p_double encs, SWIGTYPE_p_double stamps) {
    bool ret = yarpPINVOKE.IMotorEncodersRaw_getMotorEncodersTimedRaw(swigCPtr, SWIGTYPE_p_double.getCPtr(encs), SWIGTYPE_p_double.getCPtr(stamps));
    return ret;
  }

  public virtual bool getMotorEncoderTimedRaw(int m, SWIGTYPE_p_double encs, SWIGTYPE_p_double stamp) {
    bool ret = yarpPINVOKE.IMotorEncodersRaw_getMotorEncoderTimedRaw(swigCPtr, m, SWIGTYPE_p_double.getCPtr(encs), SWIGTYPE_p_double.getCPtr(stamp));
    return ret;
  }

  public virtual bool getMotorEncoderSpeedRaw(int m, SWIGTYPE_p_double sp) {
    bool ret = yarpPINVOKE.IMotorEncodersRaw_getMotorEncoderSpeedRaw(swigCPtr, m, SWIGTYPE_p_double.getCPtr(sp));
    return ret;
  }

  public virtual bool getMotorEncoderSpeedsRaw(SWIGTYPE_p_double spds) {
    bool ret = yarpPINVOKE.IMotorEncodersRaw_getMotorEncoderSpeedsRaw(swigCPtr, SWIGTYPE_p_double.getCPtr(spds));
    return ret;
  }

  public virtual bool getMotorEncoderAccelerationRaw(int m, SWIGTYPE_p_double spds) {
    bool ret = yarpPINVOKE.IMotorEncodersRaw_getMotorEncoderAccelerationRaw(swigCPtr, m, SWIGTYPE_p_double.getCPtr(spds));
    return ret;
  }

  public virtual bool getMotorEncoderAccelerationsRaw(SWIGTYPE_p_double accs) {
    bool ret = yarpPINVOKE.IMotorEncodersRaw_getMotorEncoderAccelerationsRaw(swigCPtr, SWIGTYPE_p_double.getCPtr(accs));
    return ret;
  }

}
