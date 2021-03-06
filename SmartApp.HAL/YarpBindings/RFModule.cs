//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class RFModule : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RFModule(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RFModule obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RFModule() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_RFModule(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public RFModule() : this(yarpPINVOKE.new_RFModule(), true) {
    SwigDirectorConnect();
  }

  public virtual double getPeriod() {
    double ret = (SwigDerivedClassHasMethod("getPeriod", swigMethodTypes0) ? yarpPINVOKE.RFModule_getPeriodSwigExplicitRFModule(swigCPtr) : yarpPINVOKE.RFModule_getPeriod(swigCPtr));
    return ret;
  }

  public virtual bool updateModule() {
    bool ret = yarpPINVOKE.RFModule_updateModule(swigCPtr);
    return ret;
  }

  public virtual int runModule() {
    int ret = (SwigDerivedClassHasMethod("runModule", swigMethodTypes2) ? yarpPINVOKE.RFModule_runModuleSwigExplicitRFModule__SWIG_0(swigCPtr) : yarpPINVOKE.RFModule_runModule__SWIG_0(swigCPtr));
    return ret;
  }

  public virtual int runModule(ResourceFinder rf) {
    int ret = (SwigDerivedClassHasMethod("runModule", swigMethodTypes3) ? yarpPINVOKE.RFModule_runModuleSwigExplicitRFModule__SWIG_1(swigCPtr, ResourceFinder.getCPtr(rf)) : yarpPINVOKE.RFModule_runModule__SWIG_1(swigCPtr, ResourceFinder.getCPtr(rf)));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int runModuleThreaded() {
    int ret = (SwigDerivedClassHasMethod("runModuleThreaded", swigMethodTypes4) ? yarpPINVOKE.RFModule_runModuleThreadedSwigExplicitRFModule__SWIG_0(swigCPtr) : yarpPINVOKE.RFModule_runModuleThreaded__SWIG_0(swigCPtr));
    return ret;
  }

  public virtual int runModuleThreaded(ResourceFinder rf) {
    int ret = (SwigDerivedClassHasMethod("runModuleThreaded", swigMethodTypes5) ? yarpPINVOKE.RFModule_runModuleThreadedSwigExplicitRFModule__SWIG_1(swigCPtr, ResourceFinder.getCPtr(rf)) : yarpPINVOKE.RFModule_runModuleThreaded__SWIG_1(swigCPtr, ResourceFinder.getCPtr(rf)));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool configure(ResourceFinder rf) {
    bool ret = (SwigDerivedClassHasMethod("configure", swigMethodTypes6) ? yarpPINVOKE.RFModule_configureSwigExplicitRFModule(swigCPtr, ResourceFinder.getCPtr(rf)) : yarpPINVOKE.RFModule_configure(swigCPtr, ResourceFinder.getCPtr(rf)));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool respond(Bottle command, Bottle reply) {
    bool ret = (SwigDerivedClassHasMethod("respond", swigMethodTypes7) ? yarpPINVOKE.RFModule_respondSwigExplicitRFModule(swigCPtr, Bottle.getCPtr(command), Bottle.getCPtr(reply)) : yarpPINVOKE.RFModule_respond(swigCPtr, Bottle.getCPtr(command), Bottle.getCPtr(reply)));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool attach(Port source) {
    bool ret = (SwigDerivedClassHasMethod("attach", swigMethodTypes8) ? yarpPINVOKE.RFModule_attachSwigExplicitRFModule(swigCPtr, Port.getCPtr(source)) : yarpPINVOKE.RFModule_attach(swigCPtr, Port.getCPtr(source)));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool attach_rpc_server(RpcServer source) {
    bool ret = (SwigDerivedClassHasMethod("attach_rpc_server", swigMethodTypes9) ? yarpPINVOKE.RFModule_attach_rpc_serverSwigExplicitRFModule(swigCPtr, RpcServer.getCPtr(source)) : yarpPINVOKE.RFModule_attach_rpc_server(swigCPtr, RpcServer.getCPtr(source)));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool attachTerminal() {
    bool ret = yarpPINVOKE.RFModule_attachTerminal(swigCPtr);
    return ret;
  }

  public bool detachTerminal() {
    bool ret = yarpPINVOKE.RFModule_detachTerminal(swigCPtr);
    return ret;
  }

  public virtual bool interruptModule() {
    bool ret = (SwigDerivedClassHasMethod("interruptModule", swigMethodTypes10) ? yarpPINVOKE.RFModule_interruptModuleSwigExplicitRFModule(swigCPtr) : yarpPINVOKE.RFModule_interruptModule(swigCPtr));
    return ret;
  }

  public virtual bool close() {
    bool ret = (SwigDerivedClassHasMethod("close", swigMethodTypes11) ? yarpPINVOKE.RFModule_closeSwigExplicitRFModule(swigCPtr) : yarpPINVOKE.RFModule_close(swigCPtr));
    return ret;
  }

  public void stopModule(bool wait) {
    yarpPINVOKE.RFModule_stopModule__SWIG_0(swigCPtr, wait);
  }

  public void stopModule() {
    yarpPINVOKE.RFModule_stopModule__SWIG_1(swigCPtr);
  }

  public bool isStopping() {
    bool ret = yarpPINVOKE.RFModule_isStopping(swigCPtr);
    return ret;
  }

  public bool joinModule(double seconds) {
    bool ret = yarpPINVOKE.RFModule_joinModule__SWIG_0(swigCPtr, seconds);
    return ret;
  }

  public bool joinModule() {
    bool ret = yarpPINVOKE.RFModule_joinModule__SWIG_1(swigCPtr);
    return ret;
  }

  public string getName(string subName) {
    string ret = yarpPINVOKE.RFModule_getName__SWIG_0(swigCPtr, subName);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getName() {
    string ret = yarpPINVOKE.RFModule_getName__SWIG_1(swigCPtr);
    return ret;
  }

  public void setName(string name) {
    yarpPINVOKE.RFModule_setName(swigCPtr, name);
  }

  public bool safeRespond(Bottle command, Bottle reply) {
    bool ret = yarpPINVOKE.RFModule_safeRespond(swigCPtr, Bottle.getCPtr(command), Bottle.getCPtr(reply));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("getPeriod", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateRFModule_0(SwigDirectorgetPeriod);
    if (SwigDerivedClassHasMethod("updateModule", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateRFModule_1(SwigDirectorupdateModule);
    if (SwigDerivedClassHasMethod("runModule", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateRFModule_2(SwigDirectorrunModule__SWIG_0);
    if (SwigDerivedClassHasMethod("runModule", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateRFModule_3(SwigDirectorrunModule__SWIG_1);
    if (SwigDerivedClassHasMethod("runModuleThreaded", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateRFModule_4(SwigDirectorrunModuleThreaded__SWIG_0);
    if (SwigDerivedClassHasMethod("runModuleThreaded", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateRFModule_5(SwigDirectorrunModuleThreaded__SWIG_1);
    if (SwigDerivedClassHasMethod("configure", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateRFModule_6(SwigDirectorconfigure);
    if (SwigDerivedClassHasMethod("respond", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateRFModule_7(SwigDirectorrespond);
    if (SwigDerivedClassHasMethod("attach", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateRFModule_8(SwigDirectorattach);
    if (SwigDerivedClassHasMethod("attach_rpc_server", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateRFModule_9(SwigDirectorattach_rpc_server);
    if (SwigDerivedClassHasMethod("interruptModule", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateRFModule_10(SwigDirectorinterruptModule);
    if (SwigDerivedClassHasMethod("close", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateRFModule_11(SwigDirectorclose);
    yarpPINVOKE.RFModule_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(RFModule));
    return hasDerivedMethod;
  }

  private double SwigDirectorgetPeriod() {
    return getPeriod();
  }

  private bool SwigDirectorupdateModule() {
    return updateModule();
  }

  private int SwigDirectorrunModule__SWIG_0() {
    return runModule();
  }

  private int SwigDirectorrunModule__SWIG_1(global::System.IntPtr rf) {
    return runModule(new ResourceFinder(rf, false));
  }

  private int SwigDirectorrunModuleThreaded__SWIG_0() {
    return runModuleThreaded();
  }

  private int SwigDirectorrunModuleThreaded__SWIG_1(global::System.IntPtr rf) {
    return runModuleThreaded(new ResourceFinder(rf, false));
  }

  private bool SwigDirectorconfigure(global::System.IntPtr rf) {
    return configure(new ResourceFinder(rf, false));
  }

  private bool SwigDirectorrespond(global::System.IntPtr command, global::System.IntPtr reply) {
    return respond(new Bottle(command, false), new Bottle(reply, false));
  }

  private bool SwigDirectorattach(global::System.IntPtr source) {
    return attach(new Port(source, false));
  }

  private bool SwigDirectorattach_rpc_server(global::System.IntPtr source) {
    return attach_rpc_server(new RpcServer(source, false));
  }

  private bool SwigDirectorinterruptModule() {
    return interruptModule();
  }

  private bool SwigDirectorclose() {
    return close();
  }

  public delegate double SwigDelegateRFModule_0();
  public delegate bool SwigDelegateRFModule_1();
  public delegate int SwigDelegateRFModule_2();
  public delegate int SwigDelegateRFModule_3(global::System.IntPtr rf);
  public delegate int SwigDelegateRFModule_4();
  public delegate int SwigDelegateRFModule_5(global::System.IntPtr rf);
  public delegate bool SwigDelegateRFModule_6(global::System.IntPtr rf);
  public delegate bool SwigDelegateRFModule_7(global::System.IntPtr command, global::System.IntPtr reply);
  public delegate bool SwigDelegateRFModule_8(global::System.IntPtr source);
  public delegate bool SwigDelegateRFModule_9(global::System.IntPtr source);
  public delegate bool SwigDelegateRFModule_10();
  public delegate bool SwigDelegateRFModule_11();

  private SwigDelegateRFModule_0 swigDelegate0;
  private SwigDelegateRFModule_1 swigDelegate1;
  private SwigDelegateRFModule_2 swigDelegate2;
  private SwigDelegateRFModule_3 swigDelegate3;
  private SwigDelegateRFModule_4 swigDelegate4;
  private SwigDelegateRFModule_5 swigDelegate5;
  private SwigDelegateRFModule_6 swigDelegate6;
  private SwigDelegateRFModule_7 swigDelegate7;
  private SwigDelegateRFModule_8 swigDelegate8;
  private SwigDelegateRFModule_9 swigDelegate9;
  private SwigDelegateRFModule_10 swigDelegate10;
  private SwigDelegateRFModule_11 swigDelegate11;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(ResourceFinder) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] { typeof(ResourceFinder) };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] { typeof(ResourceFinder) };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] { typeof(Bottle), typeof(Bottle) };
  private static global::System.Type[] swigMethodTypes8 = new global::System.Type[] { typeof(Port) };
  private static global::System.Type[] swigMethodTypes9 = new global::System.Type[] { typeof(RpcServer) };
  private static global::System.Type[] swigMethodTypes10 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes11 = new global::System.Type[] {  };
}
