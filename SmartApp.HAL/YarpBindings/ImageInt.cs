//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ImageInt : Image {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ImageInt(global::System.IntPtr cPtr, bool cMemoryOwn) : base(yarpPINVOKE.ImageInt_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ImageInt obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ImageInt() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_ImageInt(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ImageInt() : this(yarpPINVOKE.new_ImageInt(), true) {
  }

  public override uint getPixelSize() {
    uint ret = yarpPINVOKE.ImageInt_getPixelSize(swigCPtr);
    return ret;
  }

  public override int getPixelCode() {
    int ret = yarpPINVOKE.ImageInt_getPixelCode(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_int pixel(uint x, uint y) {
    SWIGTYPE_p_int ret = new SWIGTYPE_p_int(yarpPINVOKE.ImageInt_pixel__SWIG_0(swigCPtr, x, y), false);
    return ret;
  }

  public int access(uint x, uint y) {
    int ret = yarpPINVOKE.ImageInt_access__SWIG_0(swigCPtr, x, y);
    return ret;
  }

  public SWIGTYPE_p_int safePixel(uint x, uint y) {
    SWIGTYPE_p_int ret = new SWIGTYPE_p_int(yarpPINVOKE.ImageInt_safePixel__SWIG_0(swigCPtr, x, y), false);
    return ret;
  }

  public int getPixel(int x, int y) {
    int ret = yarpPINVOKE.ImageInt_getPixel(swigCPtr, x, y);
    return ret;
  }

  public void setPixel(int x, int y, int v) {
    yarpPINVOKE.ImageInt_setPixel(swigCPtr, x, y, v);
  }

}
