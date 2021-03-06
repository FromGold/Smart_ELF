//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Vector : VectorBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Vector(global::System.IntPtr cPtr, bool cMemoryOwn) : base(yarpPINVOKE.Vector_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Vector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Vector() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_Vector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Vector() : this(yarpPINVOKE.new_Vector__SWIG_0(), true) {
  }

  public Vector(uint size) : this(yarpPINVOKE.new_Vector__SWIG_1(size), true) {
  }

  public Vector(uint s, double def) : this(yarpPINVOKE.new_Vector__SWIG_2(s, def), true) {
  }

  public Vector(uint s, SWIGTYPE_p_double p) : this(yarpPINVOKE.new_Vector__SWIG_3(s, SWIGTYPE_p_double.getCPtr(p)), true) {
  }

  public Vector(Vector r) : this(yarpPINVOKE.new_Vector__SWIG_4(Vector.getCPtr(r)), true) {
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override uint getElementSize() {
    uint ret = yarpPINVOKE.Vector_getElementSize(swigCPtr);
    return ret;
  }

  public override int getBottleTag() {
    int ret = yarpPINVOKE.Vector_getBottleTag(swigCPtr);
    return ret;
  }

  public override uint getListSize() {
    uint ret = yarpPINVOKE.Vector_getListSize(swigCPtr);
    return ret;
  }

  public override string getMemoryBlock() {
    string ret = yarpPINVOKE.Vector_getMemoryBlock__SWIG_0(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_double getFirst() {
    global::System.IntPtr cPtr = yarpPINVOKE.Vector_getFirst__SWIG_0(swigCPtr);
    SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_double data() {
    global::System.IntPtr cPtr = yarpPINVOKE.Vector_data__SWIG_0(swigCPtr);
    SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
    return ret;
  }

  public override void resize(uint size) {
    yarpPINVOKE.Vector_resize__SWIG_0(swigCPtr, size);
  }

  public void resize(uint size, double def) {
    yarpPINVOKE.Vector_resize__SWIG_1(swigCPtr, size, def);
  }

  public void push_back(double elem) {
    yarpPINVOKE.Vector_push_back(swigCPtr, elem);
  }

  public void pop_back() {
    yarpPINVOKE.Vector_pop_back(swigCPtr);
  }

  public SWIGTYPE_p_double access(uint i) {
    SWIGTYPE_p_double ret = new SWIGTYPE_p_double(yarpPINVOKE.Vector_access__SWIG_0(swigCPtr, i), false);
    return ret;
  }

  public uint size() {
    uint ret = yarpPINVOKE.Vector_size(swigCPtr);
    return ret;
  }

  public uint length() {
    uint ret = yarpPINVOKE.Vector_length(swigCPtr);
    return ret;
  }

  public void zero() {
    yarpPINVOKE.Vector_zero(swigCPtr);
  }

  public new string toString(int precision, int width) {
    string ret = yarpPINVOKE.Vector_toString__SWIG_0(swigCPtr, precision, width);
    return ret;
  }

  public new string toString(int precision) {
    string ret = yarpPINVOKE.Vector_toString__SWIG_1(swigCPtr, precision);
    return ret;
  }

  public new string toString_c() {
    string ret = yarpPINVOKE.Vector_toString_c(swigCPtr);
    return ret;
  }

  public Vector subVector(uint first, uint last) {
    Vector ret = new Vector(yarpPINVOKE.Vector_subVector(swigCPtr, first, last), true);
    return ret;
  }

  public bool setSubvector(int position, Vector v) {
    bool ret = yarpPINVOKE.Vector_setSubvector(swigCPtr, position, Vector.getCPtr(v));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isEqual(Vector r) {
    bool ret = yarpPINVOKE.Vector_isEqual(swigCPtr, Vector.getCPtr(r));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void clear() {
    yarpPINVOKE.Vector_clear(swigCPtr);
  }

  public double get(int j) {
    double ret = yarpPINVOKE.Vector_get(swigCPtr, j);
    return ret;
  }

  public void set(int j, double v) {
    yarpPINVOKE.Vector_set(swigCPtr, j, v);
  }

}
