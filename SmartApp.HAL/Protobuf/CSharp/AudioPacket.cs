// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AudioPacket.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SmartApp.HAL.Model {

  /// <summary>Holder for reflection information generated from AudioPacket.proto</summary>
  public static partial class AudioPacketReflection {

    #region Descriptor
    /// <summary>File descriptor for AudioPacket.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AudioPacketReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFBdWRpb1BhY2tldC5wcm90byIxCgtBdWRpb1BhY2tldBIRCgl0aW1lc3Rh",
            "bXAYASABKAQSDwoHd2F2RGF0YRgCIAEoDEIVqgISU21hcnRBcHAuSEFMLk1v",
            "ZGVsYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::SmartApp.HAL.Model.AudioPacket), global::SmartApp.HAL.Model.AudioPacket.Parser, new[]{ "Timestamp", "WavData" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AudioPacket : pb::IMessage<AudioPacket> {
    private static readonly pb::MessageParser<AudioPacket> _parser = new pb::MessageParser<AudioPacket>(() => new AudioPacket());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AudioPacket> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SmartApp.HAL.Model.AudioPacketReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AudioPacket() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AudioPacket(AudioPacket other) : this() {
      timestamp_ = other.timestamp_;
      wavData_ = other.wavData_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AudioPacket Clone() {
      return new AudioPacket(this);
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 1;
    private ulong timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    /// <summary>Field number for the "wavData" field.</summary>
    public const int WavDataFieldNumber = 2;
    private pb::ByteString wavData_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString WavData {
      get { return wavData_; }
      set {
        wavData_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AudioPacket);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AudioPacket other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Timestamp != other.Timestamp) return false;
      if (WavData != other.WavData) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Timestamp != 0UL) hash ^= Timestamp.GetHashCode();
      if (WavData.Length != 0) hash ^= WavData.GetHashCode();
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
      if (Timestamp != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Timestamp);
      }
      if (WavData.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(WavData);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Timestamp != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Timestamp);
      }
      if (WavData.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(WavData);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AudioPacket other) {
      if (other == null) {
        return;
      }
      if (other.Timestamp != 0UL) {
        Timestamp = other.Timestamp;
      }
      if (other.WavData.Length != 0) {
        WavData = other.WavData;
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
          case 8: {
            Timestamp = input.ReadUInt64();
            break;
          }
          case 18: {
            WavData = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
