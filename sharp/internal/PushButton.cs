/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/
// This File has been auto-generated by SWIG and then modified using DALi Ruby Scripts
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Dali {

public class PushButton : Button {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PushButton(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.PushButton_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PushButton obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PushButton() {
    DisposeQueue.Instance.Add(this);
  }

  public override void Dispose() {
    if (!Window.IsInstalled()) {
      DisposeQueue.Instance.Add(this);
      return;
    }

    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_PushButton(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }


  public class Property : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Property(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Property obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Property() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            NDalicPINVOKE.delete_PushButton_Property(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public Property() : this(NDalicPINVOKE.new_PushButton_Property(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public static readonly int UNSELECTED_ICON = NDalicPINVOKE.PushButton_Property_UNSELECTED_ICON_get();
    public static readonly int SELECTED_ICON = NDalicPINVOKE.PushButton_Property_SELECTED_ICON_get();
    public static readonly int ICON_ALIGNMENT = NDalicPINVOKE.PushButton_Property_ICON_ALIGNMENT_get();
    public static readonly int LABEL_PADDING = NDalicPINVOKE.PushButton_Property_LABEL_PADDING_get();
    public static readonly int ICON_PADDING = NDalicPINVOKE.PushButton_Property_ICON_PADDING_get();
  
  }

  public PushButton () : this (NDalicPINVOKE.PushButton_New(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

  }
  public PushButton(PushButton pushButton) : this(NDalicPINVOKE.new_PushButton__SWIG_1(PushButton.getCPtr(pushButton)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public PushButton Assign(PushButton pushButton) {
    PushButton ret = new PushButton(NDalicPINVOKE.PushButton_Assign(swigCPtr, PushButton.getCPtr(pushButton)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static PushButton DownCast(BaseHandle handle) {
    PushButton ret = new PushButton(NDalicPINVOKE.PushButton_DownCast(BaseHandle.getCPtr(handle)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new void SetButtonImage(Image image) {
    NDalicPINVOKE.PushButton_SetButtonImage__SWIG_0_0(swigCPtr, Image.getCPtr(image));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetButtonImage(View image) {
    NDalicPINVOKE.PushButton_SetButtonImage__SWIG_1(swigCPtr, View.getCPtr(image));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetBackgroundImage(View image) {
    NDalicPINVOKE.PushButton_SetBackgroundImage(swigCPtr, View.getCPtr(image));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void SetSelectedImage(Image image) {
    NDalicPINVOKE.PushButton_SetSelectedImage__SWIG_0_0(swigCPtr, Image.getCPtr(image));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSelectedImage(View image) {
    NDalicPINVOKE.PushButton_SetSelectedImage__SWIG_1(swigCPtr, View.getCPtr(image));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSelectedBackgroundImage(View image) {
    NDalicPINVOKE.PushButton_SetSelectedBackgroundImage(swigCPtr, View.getCPtr(image));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDisabledBackgroundImage(View image) {
    NDalicPINVOKE.PushButton_SetDisabledBackgroundImage(swigCPtr, View.getCPtr(image));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDisabledImage(View image) {
    NDalicPINVOKE.PushButton_SetDisabledImage(swigCPtr, View.getCPtr(image));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDisabledSelectedImage(View image) {
    NDalicPINVOKE.PushButton_SetDisabledSelectedImage(swigCPtr, View.getCPtr(image));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum PropertyRange {
    PROPERTY_START_INDEX = PropertyRanges.PROPERTY_REGISTRATION_START_INDEX,
    PROPERTY_END_INDEX = View.PropertyRange.PROPERTY_START_INDEX+1000
  }

  public string UnselectedIcon
  {
    get
    {
      string temp;
      GetProperty( PushButton.Property.UNSELECTED_ICON).Get( out temp );
      return temp;
    }
    set
    {
      SetProperty( PushButton.Property.UNSELECTED_ICON, new Dali.Property.Value( value ) );
    }
  }
  public string SelectedIcon
  {
    get
    {
      string temp;
      GetProperty( PushButton.Property.SELECTED_ICON).Get( out temp );
      return temp;
    }
    set
    {
      SetProperty( PushButton.Property.SELECTED_ICON, new Dali.Property.Value( value ) );
    }
  }
  public string IconAlignment
  {
    get
    {
      string temp;
      GetProperty( PushButton.Property.ICON_ALIGNMENT).Get( out temp );
      return temp;
    }
    set
    {
      SetProperty( PushButton.Property.ICON_ALIGNMENT, new Dali.Property.Value( value ) );
    }
  }
  public string LabelPadding
  {
    get
    {
      string temp;
      GetProperty( PushButton.Property.LABEL_PADDING).Get( out temp );
      return temp;
    }
    set
    {
      SetProperty( PushButton.Property.LABEL_PADDING, new Dali.Property.Value( value ) );
    }
  }
  public string IconPadding
  {
    get
    {
      string temp;
      GetProperty( PushButton.Property.ICON_PADDING).Get( out temp );
      return temp;
    }
    set
    {
      SetProperty( PushButton.Property.ICON_PADDING, new Dali.Property.Value( value ) );
    }
  }

}

}
