//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ConnectionWriter : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ConnectionWriter(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ConnectionWriter obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ConnectionWriter() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_ConnectionWriter(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual void appendBlock(string data, uint len) {
    yarpPINVOKE.ConnectionWriter_appendBlock(swigCPtr, data, len);
  }

  public virtual void appendInt(int data) {
    yarpPINVOKE.ConnectionWriter_appendInt(swigCPtr, data);
  }

  public virtual void appendInt8(sbyte data) {
    yarpPINVOKE.ConnectionWriter_appendInt8(swigCPtr, data);
  }

  public virtual void appendInt16(short data) {
    yarpPINVOKE.ConnectionWriter_appendInt16(swigCPtr, data);
  }

  public virtual void appendInt32(int data) {
    yarpPINVOKE.ConnectionWriter_appendInt32(swigCPtr, data);
  }

  public virtual void appendInt64(long data) {
    yarpPINVOKE.ConnectionWriter_appendInt64(swigCPtr, data);
  }

  public virtual void appendDouble(double data) {
    yarpPINVOKE.ConnectionWriter_appendDouble(swigCPtr, data);
  }

  public virtual void appendFloat32(float data) {
    yarpPINVOKE.ConnectionWriter_appendFloat32(swigCPtr, data);
  }

  public virtual void appendFloat64(double data) {
    yarpPINVOKE.ConnectionWriter_appendFloat64(swigCPtr, data);
  }

  public virtual void appendString(string str, int terminate) {
    yarpPINVOKE.ConnectionWriter_appendString__SWIG_0(swigCPtr, str, terminate);
  }

  public virtual void appendString(string str) {
    yarpPINVOKE.ConnectionWriter_appendString__SWIG_1(swigCPtr, str);
  }

  public virtual void appendExternalBlock(string data, uint len) {
    yarpPINVOKE.ConnectionWriter_appendExternalBlock(swigCPtr, data, len);
  }

  public virtual bool isTextMode() {
    bool ret = yarpPINVOKE.ConnectionWriter_isTextMode(swigCPtr);
    return ret;
  }

  public virtual bool isBareMode() {
    bool ret = yarpPINVOKE.ConnectionWriter_isBareMode(swigCPtr);
    return ret;
  }

  public virtual void declareSizes(int argc, SWIGTYPE_p_int argv) {
    yarpPINVOKE.ConnectionWriter_declareSizes(swigCPtr, argc, SWIGTYPE_p_int.getCPtr(argv));
  }

  public virtual void setReplyHandler(PortReader reader) {
    yarpPINVOKE.ConnectionWriter_setReplyHandler(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setReference(Portable obj) {
    yarpPINVOKE.ConnectionWriter_setReference(swigCPtr, Portable.getCPtr(obj));
  }

  public virtual bool convertTextMode() {
    bool ret = yarpPINVOKE.ConnectionWriter_convertTextMode(swigCPtr);
    return ret;
  }

  public virtual bool isValid() {
    bool ret = yarpPINVOKE.ConnectionWriter_isValid(swigCPtr);
    return ret;
  }

  public virtual bool isActive() {
    bool ret = yarpPINVOKE.ConnectionWriter_isActive(swigCPtr);
    return ret;
  }

  public virtual bool isError() {
    bool ret = yarpPINVOKE.ConnectionWriter_isError(swigCPtr);
    return ret;
  }

  public virtual void requestDrop() {
    yarpPINVOKE.ConnectionWriter_requestDrop(swigCPtr);
  }

  public virtual bool isNull() {
    bool ret = yarpPINVOKE.ConnectionWriter_isNull(swigCPtr);
    return ret;
  }

  public virtual SWIGTYPE_p_yarp__os__SizedWriter getBuffer() {
    global::System.IntPtr cPtr = yarpPINVOKE.ConnectionWriter_getBuffer(swigCPtr);
    SWIGTYPE_p_yarp__os__SizedWriter ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_yarp__os__SizedWriter(cPtr, false);
    return ret;
  }

  public virtual void appendRawString(string str) {
    yarpPINVOKE.ConnectionWriter_appendRawString(swigCPtr, str);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public static ConnectionWriter createBufferedConnectionWriter() {
    global::System.IntPtr cPtr = yarpPINVOKE.ConnectionWriter_createBufferedConnectionWriter();
    ConnectionWriter ret = (cPtr == global::System.IntPtr.Zero) ? null : new ConnectionWriter(cPtr, false);
    return ret;
  }

  public static bool writeToStream(PortWriter portable, SWIGTYPE_p_yarp__os__OutputStream os) {
    bool ret = yarpPINVOKE.ConnectionWriter_writeToStream(PortWriter.getCPtr(portable), SWIGTYPE_p_yarp__os__OutputStream.getCPtr(os));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
