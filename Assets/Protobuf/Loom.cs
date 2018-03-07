// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: loom.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from loom.proto</summary>
public static partial class LoomReflection {

  #region Descriptor
  /// <summary>File descriptor for loom.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static LoomReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cgpsb29tLnByb3RvIi8KBlNpZ25lchIRCglzaWduYXR1cmUYASABKAwSEgoK",
          "cHVibGljX2tleRgCIAEoDCIzCghTaWduZWRUeBINCgVpbm5lchgBIAEoDBIY",
          "CgdzaWduZXJzGAIgAygLMgcuU2lnbmVyIhYKB0R1bW15VHgSCwoDdmFsGAEg",
          "ASgJYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Signer), global::Signer.Parser, new[]{ "Signature", "PublicKey" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::SignedTx), global::SignedTx.Parser, new[]{ "Inner", "Signers" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::DummyTx), global::DummyTx.Parser, new[]{ "Val" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class Signer : pb::IMessage<Signer> {
  private static readonly pb::MessageParser<Signer> _parser = new pb::MessageParser<Signer>(() => new Signer());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Signer> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::LoomReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Signer() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Signer(Signer other) : this() {
    signature_ = other.signature_;
    publicKey_ = other.publicKey_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Signer Clone() {
    return new Signer(this);
  }

  /// <summary>Field number for the "signature" field.</summary>
  public const int SignatureFieldNumber = 1;
  private pb::ByteString signature_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString Signature {
    get { return signature_; }
    set {
      signature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "public_key" field.</summary>
  public const int PublicKeyFieldNumber = 2;
  private pb::ByteString publicKey_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString PublicKey {
    get { return publicKey_; }
    set {
      publicKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Signer);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Signer other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Signature != other.Signature) return false;
    if (PublicKey != other.PublicKey) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Signature.Length != 0) hash ^= Signature.GetHashCode();
    if (PublicKey.Length != 0) hash ^= PublicKey.GetHashCode();
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
    if (Signature.Length != 0) {
      output.WriteRawTag(10);
      output.WriteBytes(Signature);
    }
    if (PublicKey.Length != 0) {
      output.WriteRawTag(18);
      output.WriteBytes(PublicKey);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Signature.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(Signature);
    }
    if (PublicKey.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(PublicKey);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Signer other) {
    if (other == null) {
      return;
    }
    if (other.Signature.Length != 0) {
      Signature = other.Signature;
    }
    if (other.PublicKey.Length != 0) {
      PublicKey = other.PublicKey;
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
          Signature = input.ReadBytes();
          break;
        }
        case 18: {
          PublicKey = input.ReadBytes();
          break;
        }
      }
    }
  }

}

public sealed partial class SignedTx : pb::IMessage<SignedTx> {
  private static readonly pb::MessageParser<SignedTx> _parser = new pb::MessageParser<SignedTx>(() => new SignedTx());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<SignedTx> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::LoomReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SignedTx() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SignedTx(SignedTx other) : this() {
    inner_ = other.inner_;
    signers_ = other.signers_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SignedTx Clone() {
    return new SignedTx(this);
  }

  /// <summary>Field number for the "inner" field.</summary>
  public const int InnerFieldNumber = 1;
  private pb::ByteString inner_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString Inner {
    get { return inner_; }
    set {
      inner_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "signers" field.</summary>
  public const int SignersFieldNumber = 2;
  private static readonly pb::FieldCodec<global::Signer> _repeated_signers_codec
      = pb::FieldCodec.ForMessage(18, global::Signer.Parser);
  private readonly pbc::RepeatedField<global::Signer> signers_ = new pbc::RepeatedField<global::Signer>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::Signer> Signers {
    get { return signers_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as SignedTx);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(SignedTx other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Inner != other.Inner) return false;
    if(!signers_.Equals(other.signers_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Inner.Length != 0) hash ^= Inner.GetHashCode();
    hash ^= signers_.GetHashCode();
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
    if (Inner.Length != 0) {
      output.WriteRawTag(10);
      output.WriteBytes(Inner);
    }
    signers_.WriteTo(output, _repeated_signers_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Inner.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(Inner);
    }
    size += signers_.CalculateSize(_repeated_signers_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(SignedTx other) {
    if (other == null) {
      return;
    }
    if (other.Inner.Length != 0) {
      Inner = other.Inner;
    }
    signers_.Add(other.signers_);
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
          Inner = input.ReadBytes();
          break;
        }
        case 18: {
          signers_.AddEntriesFrom(input, _repeated_signers_codec);
          break;
        }
      }
    }
  }

}

public sealed partial class DummyTx : pb::IMessage<DummyTx> {
  private static readonly pb::MessageParser<DummyTx> _parser = new pb::MessageParser<DummyTx>(() => new DummyTx());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<DummyTx> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::LoomReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public DummyTx() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public DummyTx(DummyTx other) : this() {
    val_ = other.val_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public DummyTx Clone() {
    return new DummyTx(this);
  }

  /// <summary>Field number for the "val" field.</summary>
  public const int ValFieldNumber = 1;
  private string val_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Val {
    get { return val_; }
    set {
      val_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as DummyTx);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(DummyTx other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Val != other.Val) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Val.Length != 0) hash ^= Val.GetHashCode();
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
    if (Val.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Val);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Val.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Val);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(DummyTx other) {
    if (other == null) {
      return;
    }
    if (other.Val.Length != 0) {
      Val = other.Val;
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
          Val = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code