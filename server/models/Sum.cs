// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: sum.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Sum {

  /// <summary>Holder for reflection information generated from sum.proto</summary>
  public static partial class SumReflection {

    #region Descriptor
    /// <summary>File descriptor for sum.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SumReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CglzdW0ucHJvdG8SA3N1bSIwCgNTdW0SFAoMZmlyc3RfbnVtYmVyGAEgASgJ",
            "EhMKC2xhc3RfbnVtYmVyGAIgASgJIiMKClN1bVJlcXVlc3QSFQoDc3VtGAEg",
            "ASgLMgguc3VtLlN1bSIdCgtTdW1SZXNwb25zZRIOCgZyZXN1bHQYASABKAky",
            "PwoKU3VtU2VydmljZRIxCgpTdW1OdW1iZXJzEg8uc3VtLlN1bVJlcXVlc3Qa",
            "EC5zdW0uU3VtUmVzcG9uc2UiAGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Sum.Sum), global::Sum.Sum.Parser, new[]{ "FirstNumber", "LastNumber" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Sum.SumRequest), global::Sum.SumRequest.Parser, new[]{ "Sum" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Sum.SumResponse), global::Sum.SumResponse.Parser, new[]{ "Result" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Sum : pb::IMessage<Sum> {
    private static readonly pb::MessageParser<Sum> _parser = new pb::MessageParser<Sum>(() => new Sum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Sum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sum.SumReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Sum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Sum(Sum other) : this() {
      firstNumber_ = other.firstNumber_;
      lastNumber_ = other.lastNumber_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Sum Clone() {
      return new Sum(this);
    }

    /// <summary>Field number for the "first_number" field.</summary>
    public const int FirstNumberFieldNumber = 1;
    private string firstNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FirstNumber {
      get { return firstNumber_; }
      set {
        firstNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "last_number" field.</summary>
    public const int LastNumberFieldNumber = 2;
    private string lastNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LastNumber {
      get { return lastNumber_; }
      set {
        lastNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Sum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Sum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FirstNumber != other.FirstNumber) return false;
      if (LastNumber != other.LastNumber) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FirstNumber.Length != 0) hash ^= FirstNumber.GetHashCode();
      if (LastNumber.Length != 0) hash ^= LastNumber.GetHashCode();
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
      if (FirstNumber.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FirstNumber);
      }
      if (LastNumber.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(LastNumber);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FirstNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FirstNumber);
      }
      if (LastNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LastNumber);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Sum other) {
      if (other == null) {
        return;
      }
      if (other.FirstNumber.Length != 0) {
        FirstNumber = other.FirstNumber;
      }
      if (other.LastNumber.Length != 0) {
        LastNumber = other.LastNumber;
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
            FirstNumber = input.ReadString();
            break;
          }
          case 18: {
            LastNumber = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SumRequest : pb::IMessage<SumRequest> {
    private static readonly pb::MessageParser<SumRequest> _parser = new pb::MessageParser<SumRequest>(() => new SumRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SumRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sum.SumReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SumRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SumRequest(SumRequest other) : this() {
      sum_ = other.sum_ != null ? other.sum_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SumRequest Clone() {
      return new SumRequest(this);
    }

    /// <summary>Field number for the "sum" field.</summary>
    public const int SumFieldNumber = 1;
    private global::Sum.Sum sum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Sum.Sum Sum {
      get { return sum_; }
      set {
        sum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SumRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SumRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Sum, other.Sum)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (sum_ != null) hash ^= Sum.GetHashCode();
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
      if (sum_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Sum);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (sum_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Sum);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SumRequest other) {
      if (other == null) {
        return;
      }
      if (other.sum_ != null) {
        if (sum_ == null) {
          Sum = new global::Sum.Sum();
        }
        Sum.MergeFrom(other.Sum);
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
            if (sum_ == null) {
              Sum = new global::Sum.Sum();
            }
            input.ReadMessage(Sum);
            break;
          }
        }
      }
    }

  }

  public sealed partial class SumResponse : pb::IMessage<SumResponse> {
    private static readonly pb::MessageParser<SumResponse> _parser = new pb::MessageParser<SumResponse>(() => new SumResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SumResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sum.SumReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SumResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SumResponse(SumResponse other) : this() {
      result_ = other.result_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SumResponse Clone() {
      return new SumResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private string result_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Result {
      get { return result_; }
      set {
        result_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SumResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SumResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result.Length != 0) hash ^= Result.GetHashCode();
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
      if (Result.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Result);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Result);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SumResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result.Length != 0) {
        Result = other.Result;
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
            Result = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code