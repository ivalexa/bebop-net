//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ARCONTROLLER_DICTIONARY_VALUE_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ARCONTROLLER_DICTIONARY_VALUE_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ARCONTROLLER_DICTIONARY_VALUE_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ARCONTROLLER_DICTIONARY_VALUE_t() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ARDroneSDK3PINVOKE.delete_ARCONTROLLER_DICTIONARY_VALUE_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public byte U8 {
    set {
      ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_U8_set(swigCPtr, value);
    } 
    get {
      byte ret = ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_U8_get(swigCPtr);
      return ret;
    } 
  }

  public sbyte I8 {
    set {
      ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_I8_set(swigCPtr, value);
    } 
    get {
      sbyte ret = ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_I8_get(swigCPtr);
      return ret;
    } 
  }

  public ushort U16 {
    set {
      ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_U16_set(swigCPtr, value);
    } 
    get {
      ushort ret = ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_U16_get(swigCPtr);
      return ret;
    } 
  }

  public short I16 {
    set {
      ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_I16_set(swigCPtr, value);
    } 
    get {
      short ret = ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_I16_get(swigCPtr);
      return ret;
    } 
  }

  public uint U32 {
    set {
      ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_U32_set(swigCPtr, value);
    } 
    get {
      uint ret = ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_U32_get(swigCPtr);
      return ret;
    } 
  }

  public int I32 {
    set {
      ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_I32_set(swigCPtr, value);
    } 
    get {
      int ret = ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_I32_get(swigCPtr);
      return ret;
    } 
  }

  public ulong U64 {
    set {
      ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_U64_set(swigCPtr, value);
    } 
    get {
      ulong ret = ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_U64_get(swigCPtr);
      return ret;
    } 
  }

  public long I64 {
    set {
      ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_I64_set(swigCPtr, value);
    } 
    get {
      long ret = ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_I64_get(swigCPtr);
      return ret;
    } 
  }

  public float Float {
    set {
      ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_Float_set(swigCPtr, value);
    } 
    get {
      float ret = ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_Float_get(swigCPtr);
      return ret;
    } 
  }

  public double Double {
    set {
      ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_Double_set(swigCPtr, value);
    } 
    get {
      double ret = ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_Double_get(swigCPtr);
      return ret;
    } 
  }

  public string String {
    set {
      ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_String_set(swigCPtr, value);
    } 
    get {
      string ret = ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_VALUE_t_String_get(swigCPtr);
      return ret;
    } 
  }

  public ARCONTROLLER_DICTIONARY_VALUE_t() : this(ARDroneSDK3PINVOKE.new_ARCONTROLLER_DICTIONARY_VALUE_t(), true) {
  }

}
