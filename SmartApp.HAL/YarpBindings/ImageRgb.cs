//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ImageRgb : Image {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ImageRgb(global::System.IntPtr cPtr, bool cMemoryOwn) : base(yarpPINVOKE.ImageRgb_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ImageRgb obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ImageRgb() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_ImageRgb(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ImageRgb() : this(yarpPINVOKE.new_ImageRgb(), true) {
  }

  public override uint getPixelSize() {
    uint ret = yarpPINVOKE.ImageRgb_getPixelSize(swigCPtr);
    return ret;
  }

  public override int getPixelCode() {
    int ret = yarpPINVOKE.ImageRgb_getPixelCode(swigCPtr);
    return ret;
  }

  public PixelRgb pixel(uint x, uint y) {
    PixelRgb ret = new PixelRgb(yarpPINVOKE.ImageRgb_pixel__SWIG_0(swigCPtr, x, y), false);
    return ret;
  }

  public PixelRgb access(uint x, uint y) {
    PixelRgb ret = new PixelRgb(yarpPINVOKE.ImageRgb_access__SWIG_0(swigCPtr, x, y), false);
    return ret;
  }

  public PixelRgb safePixel(uint x, uint y) {
    PixelRgb ret = new PixelRgb(yarpPINVOKE.ImageRgb_safePixel__SWIG_0(swigCPtr, x, y), false);
    return ret;
  }

}
