//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class IFrameGrabberImage : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IFrameGrabberImage(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IFrameGrabberImage obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~IFrameGrabberImage() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_IFrameGrabberImage(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual bool getImage(ImageRgb image) {
    bool ret = yarpPINVOKE.IFrameGrabberImage_getImage(swigCPtr, ImageRgb.getCPtr(image));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getImageCrop(cropType_id_t cropType, SWIGTYPE_p_yarp__sig__VectorOfT_std__pairT_int_int_t_t vertices, ImageRgb image) {
    bool ret = yarpPINVOKE.IFrameGrabberImage_getImageCrop(swigCPtr, (int)cropType, SWIGTYPE_p_yarp__sig__VectorOfT_std__pairT_int_int_t_t.getCPtr(vertices), ImageRgb.getCPtr(image));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int height() {
    int ret = yarpPINVOKE.IFrameGrabberImage_height(swigCPtr);
    return ret;
  }

  public virtual int width() {
    int ret = yarpPINVOKE.IFrameGrabberImage_width(swigCPtr);
    return ret;
  }

}
