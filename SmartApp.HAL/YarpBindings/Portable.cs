//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Portable : PortReader {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Portable(global::System.IntPtr cPtr, bool cMemoryOwn) : base(yarpPINVOKE.Portable_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Portable obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Portable() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_Portable(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public new bool read(ConnectionReader reader) {
    bool ret = yarpPINVOKE.Portable_read(swigCPtr, ConnectionReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new bool write(ConnectionWriter writer) {
    bool ret = yarpPINVOKE.Portable_write(swigCPtr, ConnectionWriter.getCPtr(writer));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_yarp__os__Type getType() {
    SWIGTYPE_p_yarp__os__Type ret = new SWIGTYPE_p_yarp__os__Type(yarpPINVOKE.Portable_getType(swigCPtr), true);
    return ret;
  }

  public static bool copyPortable(PortWriter writer, PortReader reader) {
    bool ret = yarpPINVOKE.Portable_copyPortable(PortWriter.getCPtr(writer), PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
