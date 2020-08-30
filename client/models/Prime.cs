// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: prime.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Prime {

  /// <summary>Holder for reflection information generated from prime.proto</summary>
  public static partial class PrimeReflection {

    #region Descriptor
    /// <summary>File descriptor for prime.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PrimeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtwcmltZS5wcm90bxIFcHJpbWUiMQofUHJpbWVOdW1iZXJEZWNvbXBvc2l0",
            "aW9uUmVxdWVzdBIOCgZudW1iZXIYASABKAUiOAogUHJpbWVOdW1iZXJEZWNv",
            "bXBvc2l0aW9uUmVzcG9uc2USFAoMcHJpbWVfZmFjdG9yGAEgASgFMoUBChJQ",
            "cmltZU51bWJlclNlcnZpY2USbwoYUHJpbWVOdW1iZXJEZWNvbXBvc2l0aW9u",
            "EiYucHJpbWUuUHJpbWVOdW1iZXJEZWNvbXBvc2l0aW9uUmVxdWVzdBonLnBy",
            "aW1lLlByaW1lTnVtYmVyRGVjb21wb3NpdGlvblJlc3BvbnNlIgAwAWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Prime.PrimeNumberDecompositionRequest), global::Prime.PrimeNumberDecompositionRequest.Parser, new[]{ "Number" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Prime.PrimeNumberDecompositionResponse), global::Prime.PrimeNumberDecompositionResponse.Parser, new[]{ "PrimeFactor" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PrimeNumberDecompositionRequest : pb::IMessage<PrimeNumberDecompositionRequest> {
    private static readonly pb::MessageParser<PrimeNumberDecompositionRequest> _parser = new pb::MessageParser<PrimeNumberDecompositionRequest>(() => new PrimeNumberDecompositionRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PrimeNumberDecompositionRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Prime.PrimeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PrimeNumberDecompositionRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PrimeNumberDecompositionRequest(PrimeNumberDecompositionRequest other) : this() {
      number_ = other.number_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PrimeNumberDecompositionRequest Clone() {
      return new PrimeNumberDecompositionRequest(this);
    }

    /// <summary>Field number for the "number" field.</summary>
    public const int NumberFieldNumber = 1;
    private int number_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Number {
      get { return number_; }
      set {
        number_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PrimeNumberDecompositionRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PrimeNumberDecompositionRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Number != other.Number) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Number != 0) hash ^= Number.GetHashCode();
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
      if (Number != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Number);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Number != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Number);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PrimeNumberDecompositionRequest other) {
      if (other == null) {
        return;
      }
      if (other.Number != 0) {
        Number = other.Number;
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
            Number = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class PrimeNumberDecompositionResponse : pb::IMessage<PrimeNumberDecompositionResponse> {
    private static readonly pb::MessageParser<PrimeNumberDecompositionResponse> _parser = new pb::MessageParser<PrimeNumberDecompositionResponse>(() => new PrimeNumberDecompositionResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PrimeNumberDecompositionResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Prime.PrimeReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PrimeNumberDecompositionResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PrimeNumberDecompositionResponse(PrimeNumberDecompositionResponse other) : this() {
      primeFactor_ = other.primeFactor_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PrimeNumberDecompositionResponse Clone() {
      return new PrimeNumberDecompositionResponse(this);
    }

    /// <summary>Field number for the "prime_factor" field.</summary>
    public const int PrimeFactorFieldNumber = 1;
    private int primeFactor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PrimeFactor {
      get { return primeFactor_; }
      set {
        primeFactor_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PrimeNumberDecompositionResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PrimeNumberDecompositionResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PrimeFactor != other.PrimeFactor) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PrimeFactor != 0) hash ^= PrimeFactor.GetHashCode();
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
      if (PrimeFactor != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PrimeFactor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PrimeFactor != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PrimeFactor);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PrimeNumberDecompositionResponse other) {
      if (other == null) {
        return;
      }
      if (other.PrimeFactor != 0) {
        PrimeFactor = other.PrimeFactor;
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
            PrimeFactor = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
