//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace PSMoveService {

public class PSMFrustum : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PSMFrustum(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PSMFrustum obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PSMFrustum() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PSMoveClientPINVOKE.delete_PSMFrustum(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PSMVector3f origin {
    get {
      global::System.IntPtr cPtr = PSMoveClientPINVOKE.PSMFrustum_origin_get(swigCPtr);
      PSMVector3f ret = (cPtr == global::System.IntPtr.Zero) ? null : new PSMVector3f(cPtr, false);
      return ret;
    } 
  }

  public PSMVector3f forward {
    get {
      global::System.IntPtr cPtr = PSMoveClientPINVOKE.PSMFrustum_forward_get(swigCPtr);
      PSMVector3f ret = (cPtr == global::System.IntPtr.Zero) ? null : new PSMVector3f(cPtr, false);
      return ret;
    } 
  }

  public PSMVector3f left {
    get {
      global::System.IntPtr cPtr = PSMoveClientPINVOKE.PSMFrustum_left_get(swigCPtr);
      PSMVector3f ret = (cPtr == global::System.IntPtr.Zero) ? null : new PSMVector3f(cPtr, false);
      return ret;
    } 
  }

  public PSMVector3f up {
    get {
      global::System.IntPtr cPtr = PSMoveClientPINVOKE.PSMFrustum_up_get(swigCPtr);
      PSMVector3f ret = (cPtr == global::System.IntPtr.Zero) ? null : new PSMVector3f(cPtr, false);
      return ret;
    } 
  }

  public float HFOV {
    get {
      float ret = PSMoveClientPINVOKE.PSMFrustum_HFOV_get(swigCPtr);
      return ret;
    } 
  }

  public float VFOV {
    get {
      float ret = PSMoveClientPINVOKE.PSMFrustum_VFOV_get(swigCPtr);
      return ret;
    } 
  }

  public float zNear {
    get {
      float ret = PSMoveClientPINVOKE.PSMFrustum_zNear_get(swigCPtr);
      return ret;
    } 
  }

  public float zFar {
    get {
      float ret = PSMoveClientPINVOKE.PSMFrustum_zFar_get(swigCPtr);
      return ret;
    } 
  }

  public PSMFrustum() : this(PSMoveClientPINVOKE.new_PSMFrustum(), true) {
  }

}

}