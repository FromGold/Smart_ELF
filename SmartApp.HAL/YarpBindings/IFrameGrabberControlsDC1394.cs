//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class IFrameGrabberControlsDC1394 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IFrameGrabberControlsDC1394(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IFrameGrabberControlsDC1394 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~IFrameGrabberControlsDC1394() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_IFrameGrabberControlsDC1394(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual uint getVideoModeMaskDC1394() {
    uint ret = yarpPINVOKE.IFrameGrabberControlsDC1394_getVideoModeMaskDC1394(swigCPtr);
    return ret;
  }

  public virtual uint getVideoModeDC1394() {
    uint ret = yarpPINVOKE.IFrameGrabberControlsDC1394_getVideoModeDC1394(swigCPtr);
    return ret;
  }

  public virtual bool setVideoModeDC1394(int video_mode) {
    bool ret = yarpPINVOKE.IFrameGrabberControlsDC1394_setVideoModeDC1394(swigCPtr, video_mode);
    return ret;
  }

  public virtual uint getFPSMaskDC1394() {
    uint ret = yarpPINVOKE.IFrameGrabberControlsDC1394_getFPSMaskDC1394(swigCPtr);
    return ret;
  }

  public virtual uint getFPSDC1394() {
    uint ret = yarpPINVOKE.IFrameGrabberControlsDC1394_getFPSDC1394(swigCPtr);
    return ret;
  }

  public virtual bool setFPSDC1394(int fps) {
    bool ret = yarpPINVOKE.IFrameGrabberControlsDC1394_setFPSDC1394(swigCPtr, fps);
    return ret;
  }

  public virtual uint getISOSpeedDC1394() {
    uint ret = yarpPINVOKE.IFrameGrabberControlsDC1394_getISOSpeedDC1394(swigCPtr);
    return ret;
  }

  public virtual bool setISOSpeedDC1394(int speed) {
    bool ret = yarpPINVOKE.IFrameGrabberControlsDC1394_setISOSpeedDC1394(swigCPtr, speed);
    return ret;
  }

  public virtual uint getColorCodingMaskDC1394(uint video_mode) {
    uint ret = yarpPINVOKE.IFrameGrabberControlsDC1394_getColorCodingMaskDC1394(swigCPtr, video_mode);
    return ret;
  }

  public virtual uint getColorCodingDC1394() {
    uint ret = yarpPINVOKE.IFrameGrabberControlsDC1394_getColorCodingDC1394(swigCPtr);
    return ret;
  }

  public virtual bool setColorCodingDC1394(int coding) {
    bool ret = yarpPINVOKE.IFrameGrabberControlsDC1394_setColorCodingDC1394(swigCPtr, coding);
    return ret;
  }

  public virtual bool getFormat7MaxWindowDC1394(SWIGTYPE_p_unsigned_int xdim, SWIGTYPE_p_unsigned_int ydim, SWIGTYPE_p_unsigned_int xstep, SWIGTYPE_p_unsigned_int ystep, SWIGTYPE_p_unsigned_int xoffstep, SWIGTYPE_p_unsigned_int yoffstep) {
    bool ret = yarpPINVOKE.IFrameGrabberControlsDC1394_getFormat7MaxWindowDC1394(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(xdim), SWIGTYPE_p_unsigned_int.getCPtr(ydim), SWIGTYPE_p_unsigned_int.getCPtr(xstep), SWIGTYPE_p_unsigned_int.getCPtr(ystep), SWIGTYPE_p_unsigned_int.getCPtr(xoffstep), SWIGTYPE_p_unsigned_int.getCPtr(yoffstep));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getFormat7WindowDC1394(SWIGTYPE_p_unsigned_int xdim, SWIGTYPE_p_unsigned_int ydim, SWIGTYPE_p_int x0, SWIGTYPE_p_int y0) {
    bool ret = yarpPINVOKE.IFrameGrabberControlsDC1394_getFormat7WindowDC1394(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(xdim), SWIGTYPE_p_unsigned_int.getCPtr(ydim), SWIGTYPE_p_int.getCPtr(x0), SWIGTYPE_p_int.getCPtr(y0));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool setFormat7WindowDC1394(uint xdim, uint ydim, int x0, int y0) {
    bool ret = yarpPINVOKE.IFrameGrabberControlsDC1394_setFormat7WindowDC1394(swigCPtr, xdim, ydim, x0, y0);
    return ret;
  }

  public virtual bool setOperationModeDC1394(bool b1394b) {
    bool ret = yarpPINVOKE.IFrameGrabberControlsDC1394_setOperationModeDC1394(swigCPtr, b1394b);
    return ret;
  }

  public virtual bool getOperationModeDC1394() {
    bool ret = yarpPINVOKE.IFrameGrabberControlsDC1394_getOperationModeDC1394(swigCPtr);
    return ret;
  }

  public virtual bool setTransmissionDC1394(bool bTxON) {
    bool ret = yarpPINVOKE.IFrameGrabberControlsDC1394_setTransmissionDC1394(swigCPtr, bTxON);
    return ret;
  }

  public virtual bool getTransmissionDC1394() {
    bool ret = yarpPINVOKE.IFrameGrabberControlsDC1394_getTransmissionDC1394(swigCPtr);
    return ret;
  }

  public virtual bool setBroadcastDC1394(bool onoff) {
    bool ret = yarpPINVOKE.IFrameGrabberControlsDC1394_setBroadcastDC1394(swigCPtr, onoff);
    return ret;
  }

  public virtual bool setDefaultsDC1394() {
    bool ret = yarpPINVOKE.IFrameGrabberControlsDC1394_setDefaultsDC1394(swigCPtr);
    return ret;
  }

  public virtual bool setResetDC1394() {
    bool ret = yarpPINVOKE.IFrameGrabberControlsDC1394_setResetDC1394(swigCPtr);
    return ret;
  }

  public virtual bool setPowerDC1394(bool onoff) {
    bool ret = yarpPINVOKE.IFrameGrabberControlsDC1394_setPowerDC1394(swigCPtr, onoff);
    return ret;
  }

  public virtual bool setCaptureDC1394(bool bON) {
    bool ret = yarpPINVOKE.IFrameGrabberControlsDC1394_setCaptureDC1394(swigCPtr, bON);
    return ret;
  }

  public virtual uint getBytesPerPacketDC1394() {
    uint ret = yarpPINVOKE.IFrameGrabberControlsDC1394_getBytesPerPacketDC1394(swigCPtr);
    return ret;
  }

  public virtual bool setBytesPerPacketDC1394(uint bpp) {
    bool ret = yarpPINVOKE.IFrameGrabberControlsDC1394_setBytesPerPacketDC1394(swigCPtr, bpp);
    return ret;
  }

}
