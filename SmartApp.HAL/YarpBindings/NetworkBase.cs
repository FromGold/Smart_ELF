//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class NetworkBase : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal NetworkBase(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NetworkBase obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NetworkBase() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_NetworkBase(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static void initMinimum() {
    yarpPINVOKE.NetworkBase_initMinimum__SWIG_0();
  }

  public static void initMinimum(yarpClockType clockType, SWIGTYPE_p_yarp__os__Clock custom) {
    yarpPINVOKE.NetworkBase_initMinimum__SWIG_1((int)clockType, SWIGTYPE_p_yarp__os__Clock.getCPtr(custom));
  }

  public static void initMinimum(yarpClockType clockType) {
    yarpPINVOKE.NetworkBase_initMinimum__SWIG_2((int)clockType);
  }

  public static void autoInitMinimum() {
    yarpPINVOKE.NetworkBase_autoInitMinimum__SWIG_0();
  }

  public static void autoInitMinimum(yarpClockType clockType, SWIGTYPE_p_yarp__os__Clock custom) {
    yarpPINVOKE.NetworkBase_autoInitMinimum__SWIG_1((int)clockType, SWIGTYPE_p_yarp__os__Clock.getCPtr(custom));
  }

  public static void autoInitMinimum(yarpClockType clockType) {
    yarpPINVOKE.NetworkBase_autoInitMinimum__SWIG_2((int)clockType);
  }

  public static void yarpClockInit(yarpClockType clockType, SWIGTYPE_p_Clock custom) {
    yarpPINVOKE.NetworkBase_yarpClockInit__SWIG_0((int)clockType, SWIGTYPE_p_Clock.getCPtr(custom));
  }

  public static void yarpClockInit(yarpClockType clockType) {
    yarpPINVOKE.NetworkBase_yarpClockInit__SWIG_1((int)clockType);
  }

  public static void finiMinimum() {
    yarpPINVOKE.NetworkBase_finiMinimum();
  }

  public static bool connect(string src, string dest, string carrier, bool quiet) {
    bool ret = yarpPINVOKE.NetworkBase_connect__SWIG_0(src, dest, carrier, quiet);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool connect(string src, string dest, string carrier) {
    bool ret = yarpPINVOKE.NetworkBase_connect__SWIG_1(src, dest, carrier);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool connect(string src, string dest) {
    bool ret = yarpPINVOKE.NetworkBase_connect__SWIG_2(src, dest);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool connect(string src, string dest, ContactStyle style) {
    bool ret = yarpPINVOKE.NetworkBase_connect__SWIG_5(src, dest, ContactStyle.getCPtr(style));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool disconnect(string src, string dest, bool quiet) {
    bool ret = yarpPINVOKE.NetworkBase_disconnect__SWIG_0(src, dest, quiet);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool disconnect(string src, string dest) {
    bool ret = yarpPINVOKE.NetworkBase_disconnect__SWIG_1(src, dest);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool disconnect(string src, string dest, ContactStyle style) {
    bool ret = yarpPINVOKE.NetworkBase_disconnect__SWIG_2(src, dest, ContactStyle.getCPtr(style));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool isConnected(string src, string dest, bool quiet) {
    bool ret = yarpPINVOKE.NetworkBase_isConnected__SWIG_0(src, dest, quiet);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool isConnected(string src, string dest) {
    bool ret = yarpPINVOKE.NetworkBase_isConnected__SWIG_1(src, dest);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool isConnected(string src, string dest, ContactStyle style) {
    bool ret = yarpPINVOKE.NetworkBase_isConnected__SWIG_2(src, dest, ContactStyle.getCPtr(style));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool exists(string port, bool quiet, bool checkVer) {
    bool ret = yarpPINVOKE.NetworkBase_exists__SWIG_0(port, quiet, checkVer);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool exists(string port, bool quiet) {
    bool ret = yarpPINVOKE.NetworkBase_exists__SWIG_1(port, quiet);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool exists(string port) {
    bool ret = yarpPINVOKE.NetworkBase_exists__SWIG_2(port);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool exists(string port, ContactStyle style, bool checkVer) {
    bool ret = yarpPINVOKE.NetworkBase_exists__SWIG_3(port, ContactStyle.getCPtr(style), checkVer);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool exists(string port, ContactStyle style) {
    bool ret = yarpPINVOKE.NetworkBase_exists__SWIG_4(port, ContactStyle.getCPtr(style));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool sync(string port, bool quiet) {
    bool ret = yarpPINVOKE.NetworkBase_sync__SWIG_0(port, quiet);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool sync(string port) {
    bool ret = yarpPINVOKE.NetworkBase_sync__SWIG_1(port);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void assertion(bool shouldBeTrue) {
    yarpPINVOKE.NetworkBase_assertion(shouldBeTrue);
  }

  public static Contact queryName(string name) {
    Contact ret = new Contact(yarpPINVOKE.NetworkBase_queryName(name), true);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Contact registerName(string name) {
    Contact ret = new Contact(yarpPINVOKE.NetworkBase_registerName(name), true);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Contact registerContact(Contact contact) {
    Contact ret = new Contact(yarpPINVOKE.NetworkBase_registerContact(Contact.getCPtr(contact)), true);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Contact unregisterName(string name) {
    Contact ret = new Contact(yarpPINVOKE.NetworkBase_unregisterName(name), true);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Contact unregisterContact(Contact contact) {
    Contact ret = new Contact(yarpPINVOKE.NetworkBase_unregisterContact(Contact.getCPtr(contact)), true);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool setProperty(string name, string key, Value value) {
    bool ret = yarpPINVOKE.NetworkBase_setProperty(name, key, Value.getCPtr(value));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Value getProperty(string name, string key) {
    global::System.IntPtr cPtr = yarpPINVOKE.NetworkBase_getProperty(name, key);
    Value ret = (cPtr == global::System.IntPtr.Zero) ? null : new Value(cPtr, false);
    return ret;
  }

  public static string getNameServerName() {
    string ret = yarpPINVOKE.NetworkBase_getNameServerName();
    return ret;
  }

  public static Contact getNameServerContact() {
    Contact ret = new Contact(yarpPINVOKE.NetworkBase_getNameServerContact(), true);
    return ret;
  }

  public static bool setNameServerName(string name) {
    bool ret = yarpPINVOKE.NetworkBase_setNameServerName(name);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool setLocalMode(bool flag) {
    bool ret = yarpPINVOKE.NetworkBase_setLocalMode(flag);
    return ret;
  }

  public static bool getLocalMode() {
    bool ret = yarpPINVOKE.NetworkBase_getLocalMode();
    return ret;
  }

  public static string readString(SWIGTYPE_p_bool eof) {
    string ret = yarpPINVOKE.NetworkBase_readString__SWIG_0(SWIGTYPE_p_bool.getCPtr(eof));
    return ret;
  }

  public static string readString() {
    string ret = yarpPINVOKE.NetworkBase_readString__SWIG_1();
    return ret;
  }

  public new static bool write(Contact contact, PortWriter cmd, PortReader reply, bool admin, bool quiet, double timeout) {
    bool ret = yarpPINVOKE.NetworkBase_write__SWIG_0(Contact.getCPtr(contact), PortWriter.getCPtr(cmd), PortReader.getCPtr(reply), admin, quiet, timeout);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static bool write(Contact contact, PortWriter cmd, PortReader reply, bool admin, bool quiet) {
    bool ret = yarpPINVOKE.NetworkBase_write__SWIG_1(Contact.getCPtr(contact), PortWriter.getCPtr(cmd), PortReader.getCPtr(reply), admin, quiet);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static bool write(Contact contact, PortWriter cmd, PortReader reply, bool admin) {
    bool ret = yarpPINVOKE.NetworkBase_write__SWIG_2(Contact.getCPtr(contact), PortWriter.getCPtr(cmd), PortReader.getCPtr(reply), admin);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static bool write(Contact contact, PortWriter cmd, PortReader reply) {
    bool ret = yarpPINVOKE.NetworkBase_write__SWIG_3(Contact.getCPtr(contact), PortWriter.getCPtr(cmd), PortReader.getCPtr(reply));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static bool write(Contact contact, PortWriter cmd, PortReader reply, ContactStyle style) {
    bool ret = yarpPINVOKE.NetworkBase_write__SWIG_4(Contact.getCPtr(contact), PortWriter.getCPtr(cmd), PortReader.getCPtr(reply), ContactStyle.getCPtr(style));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool writeToNameServer(PortWriter cmd, PortReader reply, ContactStyle style) {
    bool ret = yarpPINVOKE.NetworkBase_writeToNameServer(PortWriter.getCPtr(cmd), PortReader.getCPtr(reply), ContactStyle.getCPtr(style));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static bool write(string port_name, PortWriter cmd, PortReader reply) {
    bool ret = yarpPINVOKE.NetworkBase_write__SWIG_5(port_name, PortWriter.getCPtr(cmd), PortReader.getCPtr(reply));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool checkNetwork() {
    bool ret = yarpPINVOKE.NetworkBase_checkNetwork__SWIG_0();
    return ret;
  }

  public static bool checkNetwork(double timeout) {
    bool ret = yarpPINVOKE.NetworkBase_checkNetwork__SWIG_1(timeout);
    return ret;
  }

  public static bool initialized() {
    bool ret = yarpPINVOKE.NetworkBase_initialized();
    return ret;
  }

  public static void setVerbosity(int verbosity) {
    yarpPINVOKE.NetworkBase_setVerbosity(verbosity);
  }

  public static void queryBypass(SWIGTYPE_p_NameStore store) {
    yarpPINVOKE.NetworkBase_queryBypass(SWIGTYPE_p_NameStore.getCPtr(store));
  }

  public static SWIGTYPE_p_NameStore getQueryBypass() {
    global::System.IntPtr cPtr = yarpPINVOKE.NetworkBase_getQueryBypass();
    SWIGTYPE_p_NameStore ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_NameStore(cPtr, false);
    return ret;
  }

  public static string getEnvironment(string key, SWIGTYPE_p_bool found) {
    string ret = yarpPINVOKE.NetworkBase_getEnvironment__SWIG_0(key, SWIGTYPE_p_bool.getCPtr(found));
    return ret;
  }

  public static string getEnvironment(string key) {
    string ret = yarpPINVOKE.NetworkBase_getEnvironment__SWIG_1(key);
    return ret;
  }

  public static void setEnvironment(string key, string val) {
    yarpPINVOKE.NetworkBase_setEnvironment(key, val);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void unsetEnvironment(string key) {
    yarpPINVOKE.NetworkBase_unsetEnvironment(key);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public static string getDirectorySeparator() {
    string ret = yarpPINVOKE.NetworkBase_getDirectorySeparator();
    return ret;
  }

  public static string getPathSeparator() {
    string ret = yarpPINVOKE.NetworkBase_getPathSeparator();
    return ret;
  }

  public static bool registerCarrier(string name, string dll) {
    bool ret = yarpPINVOKE.NetworkBase_registerCarrier(name, dll);
    return ret;
  }

  public static void lock_() {
    yarpPINVOKE.NetworkBase_lock_();
  }

  public static void unlock() {
    yarpPINVOKE.NetworkBase_unlock();
  }

  public static bool localNetworkAllocation() {
    bool ret = yarpPINVOKE.NetworkBase_localNetworkAllocation();
    return ret;
  }

  public static Contact detectNameServer(bool useDetectedServer, SWIGTYPE_p_bool scanNeeded, SWIGTYPE_p_bool serverUsed) {
    Contact ret = new Contact(yarpPINVOKE.NetworkBase_detectNameServer(useDetectedServer, SWIGTYPE_p_bool.getCPtr(scanNeeded), SWIGTYPE_p_bool.getCPtr(serverUsed)), true);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool setNameServerContact(Contact nameServerContact) {
    bool ret = yarpPINVOKE.NetworkBase_setNameServerContact(Contact.getCPtr(nameServerContact));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string getConfigFile(string fname) {
    string ret = yarpPINVOKE.NetworkBase_getConfigFile(fname);
    return ret;
  }

  public static int getDefaultPortRange() {
    int ret = yarpPINVOKE.NetworkBase_getDefaultPortRange();
    return ret;
  }

  public static bool setConnectionQos(string src, string dest, QosStyle srcStyle, QosStyle destStyle, bool quiet) {
    bool ret = yarpPINVOKE.NetworkBase_setConnectionQos__SWIG_0(src, dest, QosStyle.getCPtr(srcStyle), QosStyle.getCPtr(destStyle), quiet);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool setConnectionQos(string src, string dest, QosStyle srcStyle, QosStyle destStyle) {
    bool ret = yarpPINVOKE.NetworkBase_setConnectionQos__SWIG_1(src, dest, QosStyle.getCPtr(srcStyle), QosStyle.getCPtr(destStyle));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool setConnectionQos(string src, string dest, QosStyle style, bool quiet) {
    bool ret = yarpPINVOKE.NetworkBase_setConnectionQos__SWIG_2(src, dest, QosStyle.getCPtr(style), quiet);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool setConnectionQos(string src, string dest, QosStyle style) {
    bool ret = yarpPINVOKE.NetworkBase_setConnectionQos__SWIG_3(src, dest, QosStyle.getCPtr(style));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool getConnectionQos(string src, string dest, QosStyle srcStyle, QosStyle destStyle, bool quiet) {
    bool ret = yarpPINVOKE.NetworkBase_getConnectionQos__SWIG_0(src, dest, QosStyle.getCPtr(srcStyle), QosStyle.getCPtr(destStyle), quiet);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool getConnectionQos(string src, string dest, QosStyle srcStyle, QosStyle destStyle) {
    bool ret = yarpPINVOKE.NetworkBase_getConnectionQos__SWIG_1(src, dest, QosStyle.getCPtr(srcStyle), QosStyle.getCPtr(destStyle));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool isValidPortName(string portName) {
    bool ret = yarpPINVOKE.NetworkBase_isValidPortName(portName);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool waitConnection(string source, string destination, bool quiet) {
    bool ret = yarpPINVOKE.NetworkBase_waitConnection__SWIG_0(source, destination, quiet);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool waitConnection(string source, string destination) {
    bool ret = yarpPINVOKE.NetworkBase_waitConnection__SWIG_1(source, destination);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool waitPort(string target, bool quiet) {
    bool ret = yarpPINVOKE.NetworkBase_waitPort__SWIG_0(target, quiet);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool waitPort(string target) {
    bool ret = yarpPINVOKE.NetworkBase_waitPort__SWIG_1(target);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int sendMessage(string port, PortWriter writable, bool silent) {
    int ret = yarpPINVOKE.NetworkBase_sendMessage__SWIG_0(port, PortWriter.getCPtr(writable), silent);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int sendMessage(string port, PortWriter writable) {
    int ret = yarpPINVOKE.NetworkBase_sendMessage__SWIG_1(port, PortWriter.getCPtr(writable));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int sendMessage(string port, PortWriter writable, SWIGTYPE_p_std__string output, bool quiet) {
    int ret = yarpPINVOKE.NetworkBase_sendMessage__SWIG_2(port, PortWriter.getCPtr(writable), SWIGTYPE_p_std__string.getCPtr(output), quiet);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int disconnectInput(string src, string dest, bool silent) {
    int ret = yarpPINVOKE.NetworkBase_disconnectInput__SWIG_0(src, dest, silent);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int disconnectInput(string src, string dest) {
    int ret = yarpPINVOKE.NetworkBase_disconnectInput__SWIG_1(src, dest);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int poll(string target, bool silent) {
    int ret = yarpPINVOKE.NetworkBase_poll__SWIG_0(target, silent);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int poll(string target) {
    int ret = yarpPINVOKE.NetworkBase_poll__SWIG_1(target);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public NetworkBase() : this(yarpPINVOKE.new_NetworkBase(), true) {
  }

}
