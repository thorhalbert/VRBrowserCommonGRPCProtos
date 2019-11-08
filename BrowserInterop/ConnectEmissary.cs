// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VRBrowserCommonGRPCProtos/BrowserInterop/ConnectEmissary.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace VRWorlds.Schemas.Browser.InterOp {

  /// <summary>Holder for reflection information generated from VRBrowserCommonGRPCProtos/BrowserInterop/ConnectEmissary.proto</summary>
  public static partial class ConnectEmissaryReflection {

    #region Descriptor
    /// <summary>File descriptor for VRBrowserCommonGRPCProtos/BrowserInterop/ConnectEmissary.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConnectEmissaryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5WUkJyb3dzZXJDb21tb25HUlBDUHJvdG9zL0Jyb3dzZXJJbnRlcm9wL0Nv",
            "bm5lY3RFbWlzc2FyeS5wcm90bxIgVlJXb3JsZHMuU2NoZW1hcy5Ccm93c2Vy",
            "LkludGVyT3AaN1ZSQnJvd3NlckNvbW1vbkdSUENQcm90b3MvU3RhbmRhcmRz",
            "UHJvdG9CdWZzL1VVSUQucHJvdG8i8wEKFkNvbm5lY3RFbWlzc2FyeVJlcXVl",
            "c3QSPAoKRW1pc3NhcnlJZBgBIAEoCzIoLlZSV29ybGRzLlNjaGVtYXMuQnJv",
            "d3Nlci5TdGFuZGFyZHMuVVVJRBI9CgtBY2Nlc3NUb2tlbhgCIAEoCzIoLlZS",
            "V29ybGRzLlNjaGVtYXMuQnJvd3Nlci5TdGFuZGFyZHMuVVVJRBJACg5Ccm93",
            "c2VyU2Vzc2lvbhgDIAEoCzIoLlZSV29ybGRzLlNjaGVtYXMuQnJvd3Nlci5T",
            "dGFuZGFyZHMuVVVJRBIaChJFbWlzc2FyeUdSUENTZXJ2ZXIYBCABKAki1gEK",
            "FUNvbm5lY3RFbWlzc2FyeVJldHVybhJJChdEZWRpY2F0ZWRNYW51ZmFjdHVy",
            "ZXJJZBgBIAEoCzIoLlZSV29ybGRzLlNjaGVtYXMuQnJvd3Nlci5TdGFuZGFy",
            "ZHMuVVVJRBJDChFEZWRpY2F0ZWRTZXJ2ZXJJZBgCIAEoCzIoLlZSV29ybGRz",
            "LlNjaGVtYXMuQnJvd3Nlci5TdGFuZGFyZHMuVVVJRBIaChJDb25uZWN0Tm90",
            "QWNjZXB0ZWQYAyABKAgSEQoJRXJyb3JUZXh0GAQgASgJMpgBCg9Db25uZWN0",
            "RW1pc3NhcnkShAEKD0Nvbm5lY3RFbWlzc2FyeRI4LlZSV29ybGRzLlNjaGVt",
            "YXMuQnJvd3Nlci5JbnRlck9wLkNvbm5lY3RFbWlzc2FyeVJlcXVlc3QaNy5W",
            "Uldvcmxkcy5TY2hlbWFzLkJyb3dzZXIuSW50ZXJPcC5Db25uZWN0RW1pc3Nh",
            "cnlSZXR1cm5iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::VRWorlds.Schemas.Browser.Standards.UUIDReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::VRWorlds.Schemas.Browser.InterOp.ConnectEmissaryRequest), global::VRWorlds.Schemas.Browser.InterOp.ConnectEmissaryRequest.Parser, new[]{ "EmissaryId", "AccessToken", "BrowserSession", "EmissaryGRPCServer" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::VRWorlds.Schemas.Browser.InterOp.ConnectEmissaryReturn), global::VRWorlds.Schemas.Browser.InterOp.ConnectEmissaryReturn.Parser, new[]{ "DedicatedManufacturerId", "DedicatedServerId", "ConnectNotAccepted", "ErrorText" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ConnectEmissaryRequest : pb::IMessage<ConnectEmissaryRequest> {
    private static readonly pb::MessageParser<ConnectEmissaryRequest> _parser = new pb::MessageParser<ConnectEmissaryRequest>(() => new ConnectEmissaryRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ConnectEmissaryRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::VRWorlds.Schemas.Browser.InterOp.ConnectEmissaryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConnectEmissaryRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConnectEmissaryRequest(ConnectEmissaryRequest other) : this() {
      emissaryId_ = other.emissaryId_ != null ? other.emissaryId_.Clone() : null;
      accessToken_ = other.accessToken_ != null ? other.accessToken_.Clone() : null;
      browserSession_ = other.browserSession_ != null ? other.browserSession_.Clone() : null;
      emissaryGRPCServer_ = other.emissaryGRPCServer_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConnectEmissaryRequest Clone() {
      return new ConnectEmissaryRequest(this);
    }

    /// <summary>Field number for the "EmissaryId" field.</summary>
    public const int EmissaryIdFieldNumber = 1;
    private global::VRWorlds.Schemas.Browser.Standards.UUID emissaryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::VRWorlds.Schemas.Browser.Standards.UUID EmissaryId {
      get { return emissaryId_; }
      set {
        emissaryId_ = value;
      }
    }

    /// <summary>Field number for the "AccessToken" field.</summary>
    public const int AccessTokenFieldNumber = 2;
    private global::VRWorlds.Schemas.Browser.Standards.UUID accessToken_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::VRWorlds.Schemas.Browser.Standards.UUID AccessToken {
      get { return accessToken_; }
      set {
        accessToken_ = value;
      }
    }

    /// <summary>Field number for the "BrowserSession" field.</summary>
    public const int BrowserSessionFieldNumber = 3;
    private global::VRWorlds.Schemas.Browser.Standards.UUID browserSession_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::VRWorlds.Schemas.Browser.Standards.UUID BrowserSession {
      get { return browserSession_; }
      set {
        browserSession_ = value;
      }
    }

    /// <summary>Field number for the "EmissaryGRPCServer" field.</summary>
    public const int EmissaryGRPCServerFieldNumber = 4;
    private string emissaryGRPCServer_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EmissaryGRPCServer {
      get { return emissaryGRPCServer_; }
      set {
        emissaryGRPCServer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ConnectEmissaryRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ConnectEmissaryRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EmissaryId, other.EmissaryId)) return false;
      if (!object.Equals(AccessToken, other.AccessToken)) return false;
      if (!object.Equals(BrowserSession, other.BrowserSession)) return false;
      if (EmissaryGRPCServer != other.EmissaryGRPCServer) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (emissaryId_ != null) hash ^= EmissaryId.GetHashCode();
      if (accessToken_ != null) hash ^= AccessToken.GetHashCode();
      if (browserSession_ != null) hash ^= BrowserSession.GetHashCode();
      if (EmissaryGRPCServer.Length != 0) hash ^= EmissaryGRPCServer.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (emissaryId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(EmissaryId);
      }
      if (accessToken_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AccessToken);
      }
      if (browserSession_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(BrowserSession);
      }
      if (EmissaryGRPCServer.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(EmissaryGRPCServer);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (emissaryId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EmissaryId);
      }
      if (accessToken_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AccessToken);
      }
      if (browserSession_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BrowserSession);
      }
      if (EmissaryGRPCServer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EmissaryGRPCServer);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ConnectEmissaryRequest other) {
      if (other == null) {
        return;
      }
      if (other.emissaryId_ != null) {
        if (emissaryId_ == null) {
          EmissaryId = new global::VRWorlds.Schemas.Browser.Standards.UUID();
        }
        EmissaryId.MergeFrom(other.EmissaryId);
      }
      if (other.accessToken_ != null) {
        if (accessToken_ == null) {
          AccessToken = new global::VRWorlds.Schemas.Browser.Standards.UUID();
        }
        AccessToken.MergeFrom(other.AccessToken);
      }
      if (other.browserSession_ != null) {
        if (browserSession_ == null) {
          BrowserSession = new global::VRWorlds.Schemas.Browser.Standards.UUID();
        }
        BrowserSession.MergeFrom(other.BrowserSession);
      }
      if (other.EmissaryGRPCServer.Length != 0) {
        EmissaryGRPCServer = other.EmissaryGRPCServer;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (emissaryId_ == null) {
              EmissaryId = new global::VRWorlds.Schemas.Browser.Standards.UUID();
            }
            input.ReadMessage(EmissaryId);
            break;
          }
          case 18: {
            if (accessToken_ == null) {
              AccessToken = new global::VRWorlds.Schemas.Browser.Standards.UUID();
            }
            input.ReadMessage(AccessToken);
            break;
          }
          case 26: {
            if (browserSession_ == null) {
              BrowserSession = new global::VRWorlds.Schemas.Browser.Standards.UUID();
            }
            input.ReadMessage(BrowserSession);
            break;
          }
          case 34: {
            EmissaryGRPCServer = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ConnectEmissaryReturn : pb::IMessage<ConnectEmissaryReturn> {
    private static readonly pb::MessageParser<ConnectEmissaryReturn> _parser = new pb::MessageParser<ConnectEmissaryReturn>(() => new ConnectEmissaryReturn());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ConnectEmissaryReturn> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::VRWorlds.Schemas.Browser.InterOp.ConnectEmissaryReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConnectEmissaryReturn() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConnectEmissaryReturn(ConnectEmissaryReturn other) : this() {
      dedicatedManufacturerId_ = other.dedicatedManufacturerId_ != null ? other.dedicatedManufacturerId_.Clone() : null;
      dedicatedServerId_ = other.dedicatedServerId_ != null ? other.dedicatedServerId_.Clone() : null;
      connectNotAccepted_ = other.connectNotAccepted_;
      errorText_ = other.errorText_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConnectEmissaryReturn Clone() {
      return new ConnectEmissaryReturn(this);
    }

    /// <summary>Field number for the "DedicatedManufacturerId" field.</summary>
    public const int DedicatedManufacturerIdFieldNumber = 1;
    private global::VRWorlds.Schemas.Browser.Standards.UUID dedicatedManufacturerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::VRWorlds.Schemas.Browser.Standards.UUID DedicatedManufacturerId {
      get { return dedicatedManufacturerId_; }
      set {
        dedicatedManufacturerId_ = value;
      }
    }

    /// <summary>Field number for the "DedicatedServerId" field.</summary>
    public const int DedicatedServerIdFieldNumber = 2;
    private global::VRWorlds.Schemas.Browser.Standards.UUID dedicatedServerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::VRWorlds.Schemas.Browser.Standards.UUID DedicatedServerId {
      get { return dedicatedServerId_; }
      set {
        dedicatedServerId_ = value;
      }
    }

    /// <summary>Field number for the "ConnectNotAccepted" field.</summary>
    public const int ConnectNotAcceptedFieldNumber = 3;
    private bool connectNotAccepted_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ConnectNotAccepted {
      get { return connectNotAccepted_; }
      set {
        connectNotAccepted_ = value;
      }
    }

    /// <summary>Field number for the "ErrorText" field.</summary>
    public const int ErrorTextFieldNumber = 4;
    private string errorText_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ErrorText {
      get { return errorText_; }
      set {
        errorText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ConnectEmissaryReturn);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ConnectEmissaryReturn other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(DedicatedManufacturerId, other.DedicatedManufacturerId)) return false;
      if (!object.Equals(DedicatedServerId, other.DedicatedServerId)) return false;
      if (ConnectNotAccepted != other.ConnectNotAccepted) return false;
      if (ErrorText != other.ErrorText) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (dedicatedManufacturerId_ != null) hash ^= DedicatedManufacturerId.GetHashCode();
      if (dedicatedServerId_ != null) hash ^= DedicatedServerId.GetHashCode();
      if (ConnectNotAccepted != false) hash ^= ConnectNotAccepted.GetHashCode();
      if (ErrorText.Length != 0) hash ^= ErrorText.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (dedicatedManufacturerId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DedicatedManufacturerId);
      }
      if (dedicatedServerId_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DedicatedServerId);
      }
      if (ConnectNotAccepted != false) {
        output.WriteRawTag(24);
        output.WriteBool(ConnectNotAccepted);
      }
      if (ErrorText.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ErrorText);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (dedicatedManufacturerId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DedicatedManufacturerId);
      }
      if (dedicatedServerId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DedicatedServerId);
      }
      if (ConnectNotAccepted != false) {
        size += 1 + 1;
      }
      if (ErrorText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ErrorText);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ConnectEmissaryReturn other) {
      if (other == null) {
        return;
      }
      if (other.dedicatedManufacturerId_ != null) {
        if (dedicatedManufacturerId_ == null) {
          DedicatedManufacturerId = new global::VRWorlds.Schemas.Browser.Standards.UUID();
        }
        DedicatedManufacturerId.MergeFrom(other.DedicatedManufacturerId);
      }
      if (other.dedicatedServerId_ != null) {
        if (dedicatedServerId_ == null) {
          DedicatedServerId = new global::VRWorlds.Schemas.Browser.Standards.UUID();
        }
        DedicatedServerId.MergeFrom(other.DedicatedServerId);
      }
      if (other.ConnectNotAccepted != false) {
        ConnectNotAccepted = other.ConnectNotAccepted;
      }
      if (other.ErrorText.Length != 0) {
        ErrorText = other.ErrorText;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (dedicatedManufacturerId_ == null) {
              DedicatedManufacturerId = new global::VRWorlds.Schemas.Browser.Standards.UUID();
            }
            input.ReadMessage(DedicatedManufacturerId);
            break;
          }
          case 18: {
            if (dedicatedServerId_ == null) {
              DedicatedServerId = new global::VRWorlds.Schemas.Browser.Standards.UUID();
            }
            input.ReadMessage(DedicatedServerId);
            break;
          }
          case 24: {
            ConnectNotAccepted = input.ReadBool();
            break;
          }
          case 34: {
            ErrorText = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
