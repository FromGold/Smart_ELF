//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class DummyConnector : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DummyConnector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DummyConnector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DummyConnector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_DummyConnector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public DummyConnector() : this(yarpPINVOKE.new_DummyConnector(), true) {
  }

  public void setTextMode(bool textmode) {
    yarpPINVOKE.DummyConnector_setTextMode(swigCPtr, textmode);
  }

  public ConnectionWriter getCleanWriter() {
    ConnectionWriter ret = new ConnectionWriter(yarpPINVOKE.DummyConnector_getCleanWriter(swigCPtr), false);
    return ret;
  }

  public ConnectionWriter getWriter() {
    ConnectionWriter ret = new ConnectionWriter(yarpPINVOKE.DummyConnector_getWriter(swigCPtr), false);
    return ret;
  }

  public ConnectionReader getReader() {
    ConnectionReader ret = new ConnectionReader(yarpPINVOKE.DummyConnector_getReader(swigCPtr), false);
    return ret;
  }

  public void reset() {
    yarpPINVOKE.DummyConnector_reset(swigCPtr);
  }

}
