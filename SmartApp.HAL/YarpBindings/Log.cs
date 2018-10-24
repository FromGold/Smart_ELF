//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Log : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Log(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Log obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Log() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_Log(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Log(string file, uint line, string func) : this(yarpPINVOKE.new_Log__SWIG_0(file, line, func), true) {
  }

  public Log() : this(yarpPINVOKE.new_Log__SWIG_1(), true) {
  }

  public void trace(string msg) {
    yarpPINVOKE.Log_trace__SWIG_0(swigCPtr, msg);
  }

  public void debug(string msg) {
    yarpPINVOKE.Log_debug__SWIG_0(swigCPtr, msg);
  }

  public void info(string msg) {
    yarpPINVOKE.Log_info__SWIG_0(swigCPtr, msg);
  }

  public void warning(string msg) {
    yarpPINVOKE.Log_warning__SWIG_0(swigCPtr, msg);
  }

  public void error(string msg) {
    yarpPINVOKE.Log_error__SWIG_0(swigCPtr, msg);
  }

  public void fatal(string msg) {
    yarpPINVOKE.Log_fatal__SWIG_0(swigCPtr, msg);
  }

  public LogStream trace() {
    LogStream ret = new LogStream(yarpPINVOKE.Log_trace__SWIG_1(swigCPtr), true);
    return ret;
  }

  public LogStream debug() {
    LogStream ret = new LogStream(yarpPINVOKE.Log_debug__SWIG_1(swigCPtr), true);
    return ret;
  }

  public LogStream info() {
    LogStream ret = new LogStream(yarpPINVOKE.Log_info__SWIG_1(swigCPtr), true);
    return ret;
  }

  public LogStream warning() {
    LogStream ret = new LogStream(yarpPINVOKE.Log_warning__SWIG_1(swigCPtr), true);
    return ret;
  }

  public LogStream error() {
    LogStream ret = new LogStream(yarpPINVOKE.Log_error__SWIG_1(swigCPtr), true);
    return ret;
  }

  public LogStream fatal() {
    LogStream ret = new LogStream(yarpPINVOKE.Log_fatal__SWIG_1(swigCPtr), true);
    return ret;
  }

  public static void setLogCallback(SWIGTYPE_p_f_enum_yarp__os__Log__LogType_p_q_const__char_p_q_const__char_q_const__unsigned_int_p_q_const__char__void arg0) {
    yarpPINVOKE.Log_setLogCallback(SWIGTYPE_p_f_enum_yarp__os__Log__LogType_p_q_const__char_p_q_const__char_q_const__unsigned_int_p_q_const__char__void.getCPtr(arg0));
  }

  public enum LogType {
    TraceType,
    DebugType,
    InfoType,
    WarningType,
    ErrorType,
    FatalType
  }

}
