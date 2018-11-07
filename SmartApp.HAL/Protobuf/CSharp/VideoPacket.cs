// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VideoPacket.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SmartApp.HAL.Model {

  /// <summary>Holder for reflection information generated from VideoPacket.proto</summary>
  public static partial class VideoPacketReflection {

    #region Descriptor
    /// <summary>File descriptor for VideoPacket.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VideoPacketReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFWaWRlb1BhY2tldC5wcm90byIvCgtWaWRlb1BhY2tldBIRCgl0aW1lc3Rh",
            "bXAYASABKAQSDQoFZmFjZXMYAiADKAxCFaoCElNtYXJ0QXBwLkhBTC5Nb2Rl",
            "bGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::SmartApp.HAL.Model.VideoPacket), global::SmartApp.HAL.Model.VideoPacket.Parser, new[]{ "Timestamp", "Faces" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VideoPacket : pb::IMessage<VideoPacket> {
    private static readonly pb::MessageParser<VideoPacket> _parser = new pb::MessageParser<VideoPacket>(() => new VideoPacket());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VideoPacket> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SmartApp.HAL.Model.VideoPacketReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VideoPacket() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VideoPacket(VideoPacket other) : this() {
      timestamp_ = other.timestamp_;
      faces_ = other.faces_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VideoPacket Clone() {
      return new VideoPacket(this);
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

    /// <summary>Field number for the "faces" field.</summary>
    public const int FacesFieldNumber = 2;
    private static readonly pb::FieldCodec<pb::ByteString> _repeated_faces_codec
        = pb::FieldCodec.ForBytes(18);
    private readonly pbc::RepeatedField<pb::ByteString> faces_ = new pbc::RepeatedField<pb::ByteString>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<pb::ByteString> Faces {
      get { return faces_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VideoPacket);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VideoPacket other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Timestamp != other.Timestamp) return false;
      if(!faces_.Equals(other.faces_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Timestamp != 0UL) hash ^= Timestamp.GetHashCode();
      hash ^= faces_.GetHashCode();
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
      faces_.WriteTo(output, _repeated_faces_codec);
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
      size += faces_.CalculateSize(_repeated_faces_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VideoPacket other) {
      if (other == null) {
        return;
      }
      if (other.Timestamp != 0UL) {
        Timestamp = other.Timestamp;
      }
      faces_.Add(other.faces_);
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
            faces_.AddEntriesFrom(input, _repeated_faces_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
