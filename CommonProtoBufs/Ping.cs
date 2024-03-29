// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VRBrowserCommonGRPCProtos/CommonProtoBufs/Ping.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace VRWorlds.Schemas.Browser.Common {

  /// <summary>Holder for reflection information generated from VRBrowserCommonGRPCProtos/CommonProtoBufs/Ping.proto</summary>
  public static partial class PingReflection {

    #region Descriptor
    /// <summary>File descriptor for VRBrowserCommonGRPCProtos/CommonProtoBufs/Ping.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRWUkJyb3dzZXJDb21tb25HUlBDUHJvdG9zL0NvbW1vblByb3RvQnVmcy9Q",
            "aW5nLnByb3RvEh9WUldvcmxkcy5TY2hlbWFzLkJyb3dzZXIuQ29tbW9uGkFW",
            "UkJyb3dzZXJDb21tb25HUlBDUHJvdG9zL1N0YW5kYXJkc1Byb3RvQnVmcy9E",
            "YXRlVGltZU9mZnNldC5wcm90bxo3VlJCcm93c2VyQ29tbW9uR1JQQ1Byb3Rv",
            "cy9TdGFuZGFyZHNQcm90b0J1ZnMvVVVJRC5wcm90byLHAQoKUGluZ1JldHVy",
            "bhI8CgpTZXJ2ZXJVdWlkGAEgASgLMiguVlJXb3JsZHMuU2NoZW1hcy5Ccm93",
            "c2VyLlN0YW5kYXJkcy5VVUlEEjoKCEt1ZG9VdWlkGAIgASgLMiguVlJXb3Js",
            "ZHMuU2NoZW1hcy5Ccm93c2VyLlN0YW5kYXJkcy5VVUlEEj8KA05vdxgDIAEo",
            "CzIyLlZSV29ybGRzLlNjaGVtYXMuQnJvd3Nlci5TdGFuZGFyZHMuRGF0ZVRp",
            "bWVPZmZzZXQiDQoLUGluZ1JlcXVlc3QyaQoEUGluZxJhCgRQaW5nEiwuVlJX",
            "b3JsZHMuU2NoZW1hcy5Ccm93c2VyLkNvbW1vbi5QaW5nUmVxdWVzdBorLlZS",
            "V29ybGRzLlNjaGVtYXMuQnJvd3Nlci5Db21tb24uUGluZ1JldHVybmIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::VRWorlds.Schemas.Browser.Standards.DateTimeOffsetReflection.Descriptor, global::VRWorlds.Schemas.Browser.Standards.UUIDReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::VRWorlds.Schemas.Browser.Common.PingReturn), global::VRWorlds.Schemas.Browser.Common.PingReturn.Parser, new[]{ "ServerUuid", "KudoUuid", "Now" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::VRWorlds.Schemas.Browser.Common.PingRequest), global::VRWorlds.Schemas.Browser.Common.PingRequest.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PingReturn : pb::IMessage<PingReturn> {
    private static readonly pb::MessageParser<PingReturn> _parser = new pb::MessageParser<PingReturn>(() => new PingReturn());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PingReturn> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::VRWorlds.Schemas.Browser.Common.PingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PingReturn() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PingReturn(PingReturn other) : this() {
      serverUuid_ = other.serverUuid_ != null ? other.serverUuid_.Clone() : null;
      kudoUuid_ = other.kudoUuid_ != null ? other.kudoUuid_.Clone() : null;
      now_ = other.now_ != null ? other.now_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PingReturn Clone() {
      return new PingReturn(this);
    }

    /// <summary>Field number for the "ServerUuid" field.</summary>
    public const int ServerUuidFieldNumber = 1;
    private global::VRWorlds.Schemas.Browser.Standards.UUID serverUuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::VRWorlds.Schemas.Browser.Standards.UUID ServerUuid {
      get { return serverUuid_; }
      set {
        serverUuid_ = value;
      }
    }

    /// <summary>Field number for the "KudoUuid" field.</summary>
    public const int KudoUuidFieldNumber = 2;
    private global::VRWorlds.Schemas.Browser.Standards.UUID kudoUuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::VRWorlds.Schemas.Browser.Standards.UUID KudoUuid {
      get { return kudoUuid_; }
      set {
        kudoUuid_ = value;
      }
    }

    /// <summary>Field number for the "Now" field.</summary>
    public const int NowFieldNumber = 3;
    private global::VRWorlds.Schemas.Browser.Standards.DateTimeOffset now_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::VRWorlds.Schemas.Browser.Standards.DateTimeOffset Now {
      get { return now_; }
      set {
        now_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PingReturn);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PingReturn other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ServerUuid, other.ServerUuid)) return false;
      if (!object.Equals(KudoUuid, other.KudoUuid)) return false;
      if (!object.Equals(Now, other.Now)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (serverUuid_ != null) hash ^= ServerUuid.GetHashCode();
      if (kudoUuid_ != null) hash ^= KudoUuid.GetHashCode();
      if (now_ != null) hash ^= Now.GetHashCode();
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
      if (serverUuid_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ServerUuid);
      }
      if (kudoUuid_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(KudoUuid);
      }
      if (now_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Now);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (serverUuid_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ServerUuid);
      }
      if (kudoUuid_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(KudoUuid);
      }
      if (now_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Now);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PingReturn other) {
      if (other == null) {
        return;
      }
      if (other.serverUuid_ != null) {
        if (serverUuid_ == null) {
          ServerUuid = new global::VRWorlds.Schemas.Browser.Standards.UUID();
        }
        ServerUuid.MergeFrom(other.ServerUuid);
      }
      if (other.kudoUuid_ != null) {
        if (kudoUuid_ == null) {
          KudoUuid = new global::VRWorlds.Schemas.Browser.Standards.UUID();
        }
        KudoUuid.MergeFrom(other.KudoUuid);
      }
      if (other.now_ != null) {
        if (now_ == null) {
          Now = new global::VRWorlds.Schemas.Browser.Standards.DateTimeOffset();
        }
        Now.MergeFrom(other.Now);
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
            if (serverUuid_ == null) {
              ServerUuid = new global::VRWorlds.Schemas.Browser.Standards.UUID();
            }
            input.ReadMessage(ServerUuid);
            break;
          }
          case 18: {
            if (kudoUuid_ == null) {
              KudoUuid = new global::VRWorlds.Schemas.Browser.Standards.UUID();
            }
            input.ReadMessage(KudoUuid);
            break;
          }
          case 26: {
            if (now_ == null) {
              Now = new global::VRWorlds.Schemas.Browser.Standards.DateTimeOffset();
            }
            input.ReadMessage(Now);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PingRequest : pb::IMessage<PingRequest> {
    private static readonly pb::MessageParser<PingRequest> _parser = new pb::MessageParser<PingRequest>(() => new PingRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PingRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::VRWorlds.Schemas.Browser.Common.PingReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PingRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PingRequest(PingRequest other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PingRequest Clone() {
      return new PingRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PingRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PingRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PingRequest other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
